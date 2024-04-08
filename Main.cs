using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace e2bapp
{
	public partial class Main : Form
	{
		// Initialize variable
		private DataTable dt = new DataTable();
		private Config configForm = new Config();
		private Add addForm = new Add();
		private General.Var Var = new General.Var();

		public Main()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			searchCond.SelectedIndex = 0;
			orderCond.SelectedIndex = 0;
			creditLabel.Text = Var.AppName + " Version " + Var.AppVer;
			coverImg.SizeMode = PictureBoxSizeMode.Zoom;
			Show();

			if (File.Exists(Var.ConfigPath))
			{
				loadItem();
			}
			else
			{
				configForm.ShowDialog();
				if (File.Exists(Var.ConfigPath))
				{
					loadItem();
				}
			}
		}

		/// <summary>
		/// アイテムをロードします。
		/// </summary>
		private void loadItem()
		{
			connLabel.ForeColor = Color.Yellow;
			Application.DoEvents();

			newDataTable();
			bookList.Items.Clear();

			searchText.Text = string.Empty;
			nameText.Text = string.Empty;
			isbnText.Text = string.Empty;
			addDateText.Text = string.Empty;

			// SQL作成
			MySqlConnection cn = Var.SqlCon;

			try
			{
				cn.Open();

				// 全本数取得
				MySqlCommand cm = new MySqlCommand()
				{
					CommandType = CommandType.Text,
					CommandTimeout = 30,
					CommandText = @"SELECT count(*) FROM e2b_item1"
				};
				cm.Connection = cn;

				int sqlAns = Convert.ToInt32(cm.ExecuteScalar().ToString());

				if (sqlAns == 0)
				{
					// 本が1つも登録されていない場合
					connLabel.ForeColor = Color.Blue;
					Application.DoEvents();
					return;
				}

				// DBからデータを取り出す
				MySqlCommand cm2 = new MySqlCommand()
				{
					CommandType = CommandType.Text,
					CommandTimeout = 30,
					CommandText = @"SELECT BOOK_TITLE, VOLUME, STATUS, ISBN13, ISBN10, TAG, INSERT_DATE "
								+ " FROM ( SELECT BOOK_TITLE, VOLUME, STATUS, ISBN13, ISBN10, TAG, INSERT_DATE, ROW_NUMBER() OVER (ORDER BY INSERT_DATE) AS ROW_CNT FROM e2b_item1 ) AS T "
				};
				cm2.Connection = cn;
				using (var reader = cm2.ExecuteReader())
				{
					while (reader.Read() == true)
					{
						dt.Rows.Add(reader["BOOK_TITLE"], reader["ISBN13"], reader["ISBN10"], reader["VOLUME"], reader["STATUS"], reader["INSERT_DATE"]);
						bookList.Items.Add(reader["BOOK_TITLE"].ToString() + " (" + reader["VOLUME"].ToString() + "巻)");
					}
				}

				bookList.SelectedIndex = 0;
				connLabel.ForeColor = Color.Blue;
			}
			catch (Exception ex)
			{
				connLabel.ForeColor = Color.Red;
				Var.WriteErrorLog(ex.Message, MethodBase.GetCurrentMethod().Name, cn.ConnectionString);
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
			}

			Application.DoEvents();
			return;
		}

		/// <summary>
		/// 検索実行
		/// </summary>
		/// <param name="wherePhrase">WHERE条件</param>
		/// <param name="orderPhrase">ORDER句</param>
		private void searchExec(string wherePhrase, string orderPhrase)
		{
			connLabel.ForeColor = Color.Yellow;
			Application.DoEvents();

			bookList.Items.Clear();
			newDataTable();

			string dbUrl = Var.ReadIni("Connect", "URL", "localhost") + "," + Var.ReadIni("Connect", "Port", "3306");

			// SQL作成
			MySqlConnection cn = Var.SqlCon;

			MySqlCommand cm = new MySqlCommand()
			{
				CommandType = CommandType.Text,
				CommandTimeout = 30,
				CommandText = @"SELECT count(*) FROM e2b_item1 " + (wherePhrase.Length != 0 ? wherePhrase : string.Empty)
			};
			cm.Connection = cn;

			MySqlCommand cm2 = new MySqlCommand()
			{
				CommandType = CommandType.Text,
				CommandTimeout = 30,
				CommandText = @"SELECT BOOK_TITLE, ISBN13, ISBN10, VOLUME, STATUS, INSERT_DATE "
							+ " FROM ( SELECT BOOK_TITLE, ISBN13, ISBN10, VOLUME, STATUS, INSERT_DATE, ROW_NUMBER() OVER (ORDER BY ISBN13) AS ROW_CNT FROM e2b_item1 " + (wherePhrase.Length != 0 ? wherePhrase : string.Empty) + " ) AS T "
							+ orderPhrase
			};
			cm2.Connection = cn;

			try
			{
				cn.Open();

				// 全本数取得
				int sqlAns = Convert.ToInt32(cm.ExecuteScalar().ToString());

				if (sqlAns == 0)
				{
					// 本が1つも登録されていない場合
					connLabel.ForeColor = Color.Blue;
					Application.DoEvents();
					return;
				}

				// DBからデータを取り出す
				using (var reader = cm2.ExecuteReader())
				{
					while (reader.Read() == true)
					{
						dt.Rows.Add(reader["BOOK_TITLE"], reader["ISBN13"], reader["ISBN10"], reader["VOLUME"], reader["STATUS"], reader["INSERT_DATE"]);
						bookList.Items.Add(reader["BOOK_TITLE"].ToString() + " (" + reader["VOLUME"].ToString() + "巻)");
					}
				}

				if (bookList.Items.Count > 0)
				{
					bookList.SelectedIndex = 0;
				}
				connLabel.ForeColor = Color.Blue;
			}
			catch (Exception ex)
			{
				connLabel.ForeColor = Color.Red;
				Var.WriteErrorLog(ex.Message, MethodBase.GetCurrentMethod().Name, cn.ConnectionString + " / " + cm.CommandText + " / " + cm2.CommandText);
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
			}

			Application.DoEvents();
			return;
		}

		private void searchStart()
		{
			// 検索実行
			string searchTarget = searchText.Text.Trim();
			StringBuilder whereSb = new StringBuilder();
			StringBuilder orderSb = new StringBuilder();

			if (!File.Exists(Var.ConfigPath))
			{
				return;
			}

			if (searchTarget.Length != 0)
			{
				// 検索条件分岐
				switch (searchCond.SelectedIndex)
				{
					case 1:
						// ISBN13
						whereSb.Append(" WHERE ISBN13 LIKE '%").Append(searchTarget).Append("%' ");
						break;
					case 2:
						// 巻数
						whereSb.Append(" WHERE VOLUME = '").Append(searchTarget).Append("' ");
						break;
					case 0:
					default:
						// タイトル
						whereSb.Append(" WHERE BOOK_TITLE LIKE N'%").Append(searchTarget).Append("%' ");
						break;
				}
			}

			orderSb.Append(" ORDER BY ");

			switch (orderCond.SelectedIndex)
			{
				case 1:
					// 追加日時 昇順
					orderSb.Append(" INSERT_DATE ASC ");
					break;
				case 2:
					// 名前 降順
					orderSb.Append(" BOOK_TITLE DESC ");
					break;
				case 3:
					// 追加日時 降順
					orderSb.Append(" INSERT_DATE DESC ");
					break;
				case 0:
				default:
					// 名前 昇順
					orderSb.Append(" BOOK_TITLE ASC ");
					break;
			}

			searchExec(whereSb.ToString(), orderSb.ToString());
		}

		/// <summary>
		/// リストアイテム変更時イベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bookList_SelectedIndexChanged(object sender, EventArgs e)
		{
			// リスト選択アイテム変更イベント
			if (bookList.SelectedIndex >= 0)
			{
				string name = dt.Rows[bookList.SelectedIndex][0].ToString();
				string isbn13 = dt.Rows[bookList.SelectedIndex][1].ToString();
				string isbn10 = dt.Rows[bookList.SelectedIndex][2].ToString();
				string volume = dt.Rows[bookList.SelectedIndex][3].ToString();
				string stat = dt.Rows[bookList.SelectedIndex][4].ToString();
				string date = dt.Rows[bookList.SelectedIndex][5].ToString();
				nameText.Text = name;
				isbnText.Text = isbn13;
				volumeText.Value = Convert.ToInt32(volume);
				addDateText.Text = date;
				if (stat == "2")
				{
					radioButton3.Checked = true;
				}
				else if (stat == "1")
				{
					radioButton2.Checked = true;
				}
				else
				{
					radioButton1.Checked = true;
				}
				coverImg.ImageLocation = "https://images-na.ssl-images-amazon.com/images/P/" + isbn10 + ".09.LZZZZZZZ";
			}
		}

		private void searchText_KeyPress(object sender, KeyPressEventArgs e)
		{
			//Enter押下で検索を実行
			if (e.KeyChar == (char)Keys.Enter)
			{
				searchStart();
			}
		}

		/// <summary>
		/// 検索ボタン押下イベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void searchButton_Click(object sender, EventArgs e)
		{
			// 検索ボタン押下時イベント
			searchStart();
		}

		/// <summary>
		/// カバー画像クリックイベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			// カバー画像クリックイベント
			try
			{
				string isbn10 = dt.Rows[bookList.SelectedIndex][2].ToString();
				Clipboard.SetText("https://images-na.ssl-images-amazon.com/images/P/" + isbn10 + ".09.MZZZZZZZ");
			}
			catch
			{
				System.Media.SystemSounds.Hand.Play();
			}
		}

		/// <summary>
		/// 本名称コピー
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			if (nameText.Text.Length > 0)
			{
				try
				{
					Clipboard.SetText(nameText.Text);
				}
				catch
				{
					System.Media.SystemSounds.Hand.Play();
				}
			}
		}

		/// <summary>
		/// ISBNコピー
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			if (isbnText.Text.Length > 0)
			{
				try
				{
					Clipboard.SetText(isbnText.Text);
				}
				catch
				{
					System.Media.SystemSounds.Hand.Play();
				}
			}
		}

		/// <summary>
		/// 追加ボタン押下時イベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void addButton_Click(object sender, EventArgs e)
		{
			if (!File.Exists(Var.ConfigPath))
			{
				return;
			}
			// 追加ボタン押下時イベント
			addForm.ShowDialog();
			// 再読込み
			loadItem();

		}

		/// <summary>
		/// 再読込みボタン押下時イベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void reloadButton_Click(object sender, EventArgs e)
		{
			// 再読込み
			if (File.Exists(Var.ConfigPath))
			{
				loadItem();
			}
		}

		/// <summary>
		/// 設定ボタン押下時イベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void configButton_Click(object sender, EventArgs e)
		{
			// 設定
			configForm.ShowDialog();
		}

		private void gitLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			gitLabel.LinkVisited = true;
			System.Diagnostics.Process.Start("https://github.com/dekotan24/e2bapp_mysql");
		}

		private void newDataTable()
		{
			dt = new DataTable();
			dt.TableName = "SubTable";
			dt.Columns.Add("BOOK_TITLE");
			dt.Columns.Add("ISBN13");
			dt.Columns.Add("ISBN10");
			dt.Columns.Add("VOLUME");
			dt.Columns.Add("STATUS");
			dt.Columns.Add("INSERT_DATE");
		}

		private void updateValue(int index, string value, string isbn13)
		{
			if (isbn13.Length != 13)
			{
				MessageBox.Show("ISBN13が不正です。", Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string dbUrl = Var.ReadIni("Connect", "URL", "localhost") + "," + Var.ReadIni("Connect", "Port", "3306");
			try
			{
				// SQL作成
				MySqlConnection cn = Var.SqlCon;
				MySqlCommand cm;
				cm = new MySqlCommand()
				{
					CommandType = CommandType.Text,
					CommandTimeout = 30,
					CommandText = @"UPDATE e2b_item1 SET STATUS = '" + value + "' WHERE ISBN13 = '" + isbn13 + "'"
				};
				cm.Connection = cn;

				try
				{
					cn.Open();
					cm.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Var.WriteErrorLog(ex.Message, MethodBase.GetCurrentMethod().Name, cm.CommandText);
					MessageBox.Show("データベースの更新中にエラーが発生しました。\n\n" + ex.Message, Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					if (cn.State == ConnectionState.Open)
					{
						cn.Close();
					}
				}
				System.Media.SystemSounds.Beep.Play();
				return;
			}
			catch (Exception ex)
			{
				Var.WriteErrorLog(ex.Message, MethodBase.GetCurrentMethod().Name, string.Empty);
				MessageBox.Show("予期せぬエラーが発生しました。\n\n" + ex.Message, Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return;
		}

		private void radioSaveButton_Click(object sender, EventArgs e)
		{
			if (bookList.Items.Count > 0)
			{
				if (radioButton1.Checked)
				{
					updateValue(bookList.SelectedIndex, "0", isbnText.Text.Trim());
				}
				else if (radioButton2.Checked)
				{
					updateValue(bookList.SelectedIndex, "1", isbnText.Text.Trim());
				}
				else
				{
					updateValue(bookList.SelectedIndex, "2", isbnText.Text.Trim());
				}
				// 再読込み
				if (File.Exists(Var.ConfigPath))
				{
					loadItem();
				}
			}
		}
	}
}
