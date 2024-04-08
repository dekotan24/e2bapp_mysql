using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e2bapp
{
	public partial class Add : Form
	{
		private General.Var Var = new General.Var();

		public Add()
		{
			InitializeComponent();
		}

		private void getButton_Click(object sender, EventArgs e)
		{
			bool continueFlg = true;
			// ISBN13から本の情報を取得
			if (isbnText.Text.Trim().StartsWith("978"))
			{
				isbnText.Text = isbnText.Text.Trim().Substring(3);
			}
			string isbn13 = (isbnText.Text.Trim()).Replace("-", "");
			if (isbn13.Length != 10)
			{
				MessageBox.Show("ISBNが不正です。", Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				continueFlg = false;
				isbnText.Focus();
				return;
			}
			lastSearchISBNLink.Text = "978" + isbn13;
			string isbn10 = calcISBN13to10(isbn13);
			isbn10AnsLabel.Text = isbn10;

			// 書籍名取得
			string targetUrl = "https://www.amazon.co.jp/gp/product/" + isbn10 + "/#";

			int engine = 0;
			if (ndlEngine.Checked)
			{
				engine = 1;
				targetUrl = "https://ndlsearch.ndl.go.jp/bib?cs=marc&display=panel&from=0&size=20&keyword=978" + isbn13;
			}

			string fullIsbn13 = "978" + isbn13;
			SearchExec(engine, targetUrl, fullIsbn13, isbn10);

			bool registedFlg = false;
			// 登録チェック
			MySqlConnection cn = Var.SqlCon;

			MySqlCommand cm2 = new MySqlCommand
			{
				CommandType = CommandType.Text,
				CommandTimeout = 30,
				CommandText = @"SELECT BOOK_TITLE FROM e2b_item1 WHERE ISBN13 = '" + fullIsbn13 + "'",
				Connection = cn
			};

			try
			{
				cn.Open();

				// 検索
				using (var reader = cm2.ExecuteReader())
				{
					if (reader.Read())
					{
						addButton.Text = "登録済み";
						registedFlg = true;
					}
					else
					{
						addButton.Text = "登録";
						registedFlg = false;
					}
				}
			}
			catch (Exception ex)
			{
				Var.WriteErrorLog(ex.Message, MethodBase.GetCurrentMethod().Name, cn.ConnectionString + " / " + cm2.CommandText);
				MessageBox.Show("データベース読取中にエラーが発生しました。\n\n" + ex.Message, Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
			}

			if (registedFlg)
			{
				editRegistButton_Click(sender, e);
				isbnText.Focus();
				return;
			}

			// 自動登録処理
			if (autoRegistCheck.Checked && continueFlg)
			{
				addButton_Click(sender, e);
			}
		}

		private async void SearchExec(int searchEngine, string targetUrl, string isbn13, string isbn10)
		{
			bool continueFlg = true;
			try
			{
				string title = string.Empty;
				int volume = 1;

				if (searchEngine == 0)
				{
					// Amazon
					ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
					WebClient wc = new WebClient();

					System.IO.Stream st = wc.OpenRead(targetUrl);

					var parser = new AngleSharp.Html.Parser.HtmlParser();
					var doc = parser.ParseDocument(st);

					var title2 = doc.QuerySelector("#productTitle");
					if (title2 == null)
					{
						MessageBox.Show("データが見つかりませんでした。\n他の検索エンジンをお試しください。", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					title = title2.TextContent;
					string str = Regex.Replace(title, @"^[0-9]", "");
					int dummy = 0;
					volume = (int.TryParse(str, out dummy)) ? int.Parse(str) : 1;
				}
				else
				{
					// NDL
					// キーワードを使用して検索リクエストを送信し、JSONデータを取得
					string jsonResponse = await PerformSearchAsync(isbn13);
					if (jsonResponse == "[null]")
					{
						MessageBox.Show("データが見つかりませんでした。\n他の検索エンジンをお試しください。\n\nResponse:" + jsonResponse, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					// JSONデータから情報を抽出して配列に格納
					JArray array = JArray.Parse(jsonResponse);
					foreach (JObject item in array)
					{
						JObject summary = (JObject)item["summary"];
						if (summary != null)
						{
							title = (string)summary["title"] + " (" + (string)summary["series"] + ")";

							if (volume_title.Checked)
							{
								// タイトルから抽出
								int dummy = 0;
								string str = Regex.Replace(title, @"^[0-9]", "");
								volume = (int.TryParse(str, out dummy)) ? int.Parse(str) : 1;
							}
							else
							{
								// DBから抽出
								int dummy = 0;
								string str = Regex.Replace((string)summary["volume"], @"^[0-9]", "");
								volume = (int.TryParse(str, out dummy)) ? int.Parse(str) : 1;
							}
						}
					}
				}

				nameText.Text = title.Trim();
				dateText.Value = DateTime.Now;

				if (volume <= 1000 && volume > 0 && notGetVolumeCheck.Checked)
				{
					volumeText.Value = volume;
				}
				else
				{
					volumeText.Value = 1;
				}
				coverImg.SizeMode = PictureBoxSizeMode.Zoom;

				if (!ungetImageCheck.Checked)
				{
					coverImg.ImageLocation = "https://images-na.ssl-images-amazon.com/images/P/" + isbn10 + ".09.LZZZZZZZ";
				}
				else
				{
					coverImg.ImageLocation = string.Empty;
				}
				addButton.Focus();
			}
			catch (AggregateException ae)
			{
				MessageBox.Show("詳細取得中にエラーが発生しました。\nこのエラーは通常、ネットワークに接続されていない場合や、選択した検索エンジン上にデータが存在しない場合に発生します。\n\n[" + ae.InnerException + "]\n" + ae.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				isbnText.Focus();
				continueFlg = false;
			}
			catch (NullReferenceException ne)
			{
				MessageBox.Show("タイトル取得中にエラーが発生しました。\nこのエラーは通常、ネットワークに接続されていない場合や、選択した検索エンジン上にデータが存在しない場合に発生します。\n\n[" + ne.InnerException + "]\n" + ne.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				isbnText.Focus();
				continueFlg = false;
			}
			catch (FormatException fe)
			{
				volumeText.Value = 1;
				Var.WriteErrorLog("巻数の取得に失敗しました。", Var.AppName, fe.Message);
				isbnText.Focus();
			}

			return;
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private string calcISBN13to10(string rawIsbn13)
		{
			string ans = string.Empty;
			int sum = 0;
			string isbn9 = rawIsbn13.Substring(0, 9);
			string isbn13 = rawIsbn13;
			string code = string.Empty;
			int cdt = 0;

			for (int i = 0; i < 9; i++)
			{
				int tmp = Convert.ToInt32(isbn9.Substring(i, 1));
				tmp *= (10 - i);
				sum += tmp;
			}

			// チェックディジット計算
			cdt = 11 - (sum % 11);
			code = cdt.ToString();

			if (cdt == 11)
			{
				code = "0";
			}
			else if (cdt == 10)
			{
				code = "X";
			}

			ans = isbn9 + code;

			return ans;
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			string title = nameText.Text.Trim();
			string isbn13 = lastSearchISBNLink.Text;
			string isbn10 = isbn10AnsLabel.Text.Trim();
			string volume = volumeText.Value.ToString();
			string date = dateText.Value.ToString("yyyy-MM-dd HH:mm:ss");
			string status = (radioButton1.Checked ? "0" : (radioButton2.Checked ? "1" : "2"));
			bool hasError = false;

			if (title.Length == 0 || volume.Length == 0 || isbn13.Length == 0 || isbn10.Length != 10)
			{
				MessageBox.Show("必須項目が不正です。", Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			// SQL作成
			MySqlConnection cn = Var.SqlCon;

			MySqlCommand cm = new MySqlCommand
			{
				CommandType = CommandType.Text,
				CommandTimeout = 30,
				CommandText = @"INSERT INTO e2b_item1 (BOOK_TITLE, ISBN13, ISBN10, VOLUME, STATUS, INSERT_DATE) VALUES (N'" + title + "', '" + isbn13 + "', '" + isbn10 + "', '" + volume + "', '" + status + "', '" + date + "')",
				Connection = cn
			};

			MySqlCommand cm2 = new MySqlCommand
			{
				CommandType = CommandType.Text,
				CommandTimeout = 30,
				CommandText = @"SELECT BOOK_TITLE FROM e2b_item1 WHERE ISBN13 = '" + isbn13 + "'",
				Connection = cn
			};

			try
			{
				cn.Open();

				// 重複チェック
				using (var reader = cm2.ExecuteReader())
				{
					if (reader.Read())
					{
						MessageBox.Show("既に登録されています！\n\n" + reader["BOOK_TITLE"], Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
						isbnText.Focus();
						return;
					}
				}

				// 登録
				cm.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Var.WriteErrorLog(ex.Message, MethodBase.GetCurrentMethod().Name, cn.ConnectionString + " / " + cm.CommandText);
				hasError = true;
				MessageBox.Show("データベース登録中にエラーが発生しました。\n\n" + ex.Message, Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
			}

			if (hasError)
			{
				return;
			}

			addButton.Text = "登録";
			isbnText.Text = string.Empty;
			isbn10AnsLabel.Text = string.Empty;
			nameText.Text = string.Empty;
			volumeText.Value = 1;
			radioButton1.Checked = true;
			coverImg.ImageLocation = null;
			isbnText.Focus();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			dateText.Value = DateTime.Now;
		}

		private void isbnText_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Enter押下で検索を実行
			if (e.KeyChar == (char)Keys.Enter)
			{
				getButton_Click(sender, e);
			}
		}

		private void isbn10AnsLabel_Click(object sender, EventArgs e)
		{
			if (isbn10AnsLabel.Text.Length != 0)
			{
				try
				{
					Clipboard.SetText(isbn10AnsLabel.Text);
				}
				catch (Exception ex)
				{
					MessageBox.Show("コピーに失敗しました。\n\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void ndlEngine_CheckedChanged(object sender, EventArgs e)
		{
			if (ndlEngine.Checked)
			{
				volumeGetType.Visible = true;
			}
			else
			{
				volumeGetType.Visible = false;
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://openbd.jp/terms/");
			MessageBox.Show("openBDを使用する場合、必ず利用規約をお読みの上、同意される場合のみご利用ください。\n\nhttps://openbd.jp/terms/", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private async Task<string> PerformSearchAsync(string isbn13)
		{
			using (HttpClient client = new HttpClient())
			{
				string url = "https://api.openbd.jp/v1/get?isbn=" + isbn13;
				var response = await client.GetAsync(url);

				if (response.IsSuccessStatusCode)
				{
					// レスポンスからJSONデータを取得
					string jsonResponse = await response.Content.ReadAsStringAsync();

					return jsonResponse;
				}
				else
				{
					// エラーハンドリングを行うか、エラーを示す値を返すこともできます
					throw new Exception("HTTPリクエストが失敗しました。");
				}
			}
		}

		private void lastSearchISBNLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (lastSearchISBNLink.Text.Length > 10)
			{
				isbnText.Text = lastSearchISBNLink.Text;
			}
		}

		private void editRegistButton_Click(object sender, EventArgs e)
		{
			string isbn13 = lastSearchISBNLink.Text;
			if (isbn13.Length != 13)
			{
				MessageBox.Show("ISBNが不正です。", Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			// SQL作成
			MySqlConnection cn = Var.SqlCon;

			MySqlCommand cm = new MySqlCommand
			{
				CommandType = CommandType.Text,
				CommandTimeout = 30,
				CommandText = @"SELECT BOOK_TITLE, VOLUME, STATUS, INSERT_DATE FROM e2b_item1 WHERE ISBN13 = '" + isbn13 + "'",
				Connection = cn
			};

			try
			{
				cn.Open();

				using (var reader = cm.ExecuteReader())
				{
					if (reader.Read())
					{
						nameText.Text = reader["BOOK_TITLE"].ToString();
						volumeText.Value = int.Parse(reader["VOLUME"].ToString());
						dateText.Text = reader["INSERT_DATE"].ToString();
						if (reader["STATUS"].ToString() == "0")
						{
							radioButton1.Checked = true;
						}
						else if (reader["STATUS"].ToString() == "1")
						{
							radioButton2.Checked = true;
						}
						else
						{
							radioButton3.Checked = true;
						}
					}
				}
			}
			catch (Exception ex)
			{
				Var.WriteErrorLog(ex.Message, MethodBase.GetCurrentMethod().Name, cn.ConnectionString + " / " + cm.CommandText);
				MessageBox.Show("データベース読取中にエラーが発生しました。\n\n" + ex.Message, Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
			}
		}

		private void deleteRegistButton_Click(object sender, EventArgs e)
		{
			string isbn13 = lastSearchISBNLink.Text;
			bool deleteFlg = false;
			string title = string.Empty;
			if (isbn13.Length != 13)
			{
				MessageBox.Show("ISBNが不正です。", Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			// SQL作成
			MySqlConnection cn = Var.SqlCon;

			MySqlCommand cm = new MySqlCommand
			{
				CommandType = CommandType.Text,
				CommandTimeout = 30,
				CommandText = @"DELETE FROM e2b_item1 WHERE ISBN13 = '" + isbn13 + "'",
				Connection = cn
			};

			MySqlCommand cm2 = new MySqlCommand
			{
				CommandType = CommandType.Text,
				CommandTimeout = 30,
				CommandText = @"SELECT BOOK_TITLE FROM e2b_item1 WHERE ISBN13 = '" + isbn13 + "'",
				Connection = cn
			};

			try
			{
				cn.Open();

				// 重複チェック
				using (var reader = cm2.ExecuteReader())
				{
					if (reader.Read())
					{
						deleteFlg = true;
						title = reader["BOOK_TITLE"].ToString();
					}
				}
			}
			catch (Exception ex)
			{
				Var.WriteErrorLog(ex.Message, MethodBase.GetCurrentMethod().Name, cn.ConnectionString + " / " + cm.CommandText);
				MessageBox.Show("データ取得中にエラーが発生しました。\n\n" + ex.Message, Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
			}

			DialogResult dr = MessageBox.Show("本当に削除しますか？\n" + title + "（" + isbn13 + "）", Var.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			if (dr == DialogResult.Yes)
			{
				try
				{
					cn.Open();

					// 削除
					cm.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Var.WriteErrorLog(ex.Message, MethodBase.GetCurrentMethod().Name, cn.ConnectionString + " / " + cm.CommandText);
					MessageBox.Show("データ削除中にエラーが発生しました。\n\n" + ex.Message, Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					if (cn.State == ConnectionState.Open)
					{
						cn.Close();
					}
				}
				MessageBox.Show("削除しました。", Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}