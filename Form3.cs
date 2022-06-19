using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace e2bapp
{
	public partial class Form3 : Form
	{
		private General.Var Var = new General.Var();

		public Form3()
		{
			InitializeComponent();
		}

		private void getButton_Click(object sender, EventArgs e)
		{
			// ISBN13から本の情報を取得
			if (isbnText.Text.Trim().StartsWith("978"))
			{
				isbnText.Text = isbnText.Text.Trim().Substring(3);
			}
			string isbn13 = (isbnText.Text.Trim()).Replace("-", "");
			if (isbn13.Length != 10)
			{
				MessageBox.Show("ISBNが不正です。", Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			string isbn10 = calcISBN13to10(isbn13);
			isbn10AnsLabel.Text = isbn10;

			// 書籍名取得
			string targetUrl = "https://www.amazon.co.jp/gp/product/" + isbn10 + "/#";

			try
			{
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
				WebClient wc = new WebClient();
				System.IO.Stream st = wc.OpenRead(targetUrl);

				var parser = new AngleSharp.Html.Parser.HtmlParser();
				var doc = parser.ParseDocument(st);

				var title2 = doc.QuerySelector("#productTitle");
				string title = title2.TextContent;
				nameText.Text = title.Trim();

				string str = Regex.Replace(title, @"[^0-9]", "");
				int volume = int.Parse(str);
				if (volume <= 1000)
				{
					volumeText.Value = volume;
				}
				coverImg.SizeMode = PictureBoxSizeMode.Zoom;
				coverImg.ImageLocation = "http://images-jp.amazon.com/images/P/" + isbn10 + ".09.MZZZZZZZ";
				dateText.Value = DateTime.Now;
			}
			catch (AggregateException ae)
			{
				MessageBox.Show("詳細取得中にエラーが発生しました。\nこのエラーは通常、ネットワークに接続されていない場合や、Amazon上にデータが存在しない場合に発生します。\n\nError:" + ae.InnerException + "\nErrMsg:" + ae.InnerExceptions, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (FormatException fe)
			{
				volumeText.Value = 1;
				Var.WriteErrorLog("巻数の取得に失敗しました。", Var.AppName, fe.Message);
			}
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
				tmp = tmp * (10 - i);
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
			string dbUrl = Var.ReadIni("Connect", "URL", "localhost") + "," + Var.ReadIni("Connect", "Port", "1443");

			string title = nameText.Text.Trim();
			string isbn13 = (isbnText.Text.Trim()).Replace("-", "");
			isbn13 = "978" + isbn13;
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
			SqlConnection cn = new SqlConnection(new SqlConnectionStringBuilder()
			{
				IntegratedSecurity = false,
				DataSource = dbUrl,
				UserID = Var.ReadIni("Connect", "User", "sa"),
				Password = Var.ReadIni("Connect", "Pass", string.Empty)
			}.ToString()
			);

			SqlCommand cm = new SqlCommand()
			{
				CommandType = CommandType.Text,
				CommandTimeout = 30,
				CommandText = @"INSERT INTO [dekosoft_e2b].[dbo].[e2b_item1] ([BOOK_TITLE], [ISBN13], [ISBN10], [VOLUME], [STATUS], [INSERT_DATE]) VALUES ('" + title + "', '" + isbn13 + "', '" + isbn10 + "', '" + volume + "', '" + status + "', '" + date + "')"
			};
			cm.Connection = cn;

			SqlCommand cm2 = new SqlCommand()
			{
				CommandType = CommandType.Text,
				CommandTimeout = 30,
				CommandText = @"SELECT [ISBN13] FROM [dekosoft_e2b].[dbo].[e2b_item1] WHERE [ISBN13] = '" + isbn13 + "'"
			};
			cm2.Connection = cn;

			try
			{
				cn.Open();

				// 重複チェック
				using (var reader = cm2.ExecuteReader())
				{
					if (reader.Read())
					{
						MessageBox.Show("既に登録されています！", Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

			isbnText.Text = string.Empty;
			isbn10AnsLabel.Text = string.Empty;
			nameText.Text = string.Empty;
			volumeText.Value = 1;
			radioButton1.Checked = true;
			coverImg.ImageLocation = null;
			Hide();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			dateText.Value = DateTime.Now;
		}

		private void isbnText_KeyPress(object sender, KeyPressEventArgs e)
		{
			//Enter押下で検索を実行
			if (e.KeyChar == (char)Keys.Enter)
			{
				getButton_Click(sender, e);
			}
		}
	}
}
