using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace e2bapp
{
	public partial class Config : Form
	{
		General.Var Var = new General.Var();
		public Config()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			loadValue();
		}

		private void loadValue()
		{
			if (File.Exists(Var.ConfigPath))
			{
				// iniファイルから読み込み
				urlText.Text = Var.ReadIni("Connect", "URL", "localhost");
				nameText.Text = Var.ReadIni("Connect", "Name", string.Empty);
				portText.Value = Convert.ToInt32(Var.ReadIni("Connect", "Port", "3306"));
				userText.Text = Var.ReadIni("Connect", "User", "root");
				passText.Text = Var.ReadIni("Connect", "Pass", string.Empty);
			}
			else
			{
				// 初回起動
				urlText.Text = "localhost";
				nameText.Text = string.Empty;
				portText.Value = 3306;
				userText.Text = "root";
				passText.Text = string.Empty;
			}
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			// iniへ保存
			Var.IniWrite("Connect", "URL", urlText.Text.Trim());
			Var.IniWrite("Connect", "Name", nameText.Text.Trim());
			Var.IniWrite("Connect", "Port", portText.Value.ToString());
			Var.IniWrite("Connect", "User", userText.Text.Trim());
			Var.IniWrite("Connect", "Pass", passText.Text.Trim());
			Hide();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private void createButton_Click(object sender, EventArgs e)
		{
			// 必須チェック
			if (urlText.Text.Length == 0 || nameText.Text.Length == 0 || string.IsNullOrEmpty(portText.Value.ToString()) || userText.Text.Length == 0 || passText.Text.Length == 0)
			{
				// 必要な情報がないためエラー
				MessageBox.Show("URL、データベース名、ポート番号、ユーザ名、パスワードのうち1つ以上が不足しています。", Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			Var.IniWrite("Connect", "URL", urlText.Text.Trim());
			Var.IniWrite("Connect", "Name", nameText.Text.Trim());
			Var.IniWrite("Connect", "Port", portText.Value.ToString());
			Var.IniWrite("Connect", "User", userText.Text.Trim());
			Var.IniWrite("Connect", "Pass", passText.Text.Trim());

			try
			{
				// SQL作成
				MySqlConnection cn = Var.SqlCon;
				MySqlCommand cm = new MySqlCommand
				{
					CommandType = CommandType.Text,
					CommandTimeout = 30,
					CommandText = @"CREATE TABLE e2b_item1 ( BOOK_TITLE NVARCHAR(255), VOLUME INT, STATUS INT, ISBN13 NVARCHAR(13) PRIMARY KEY, ISBN10 NVARCHAR(10), TAG NVARCHAR(255), INSERT_DATE DATETIME)",
					Connection = cn
				};

				// データベース作成
				try
				{
					cn.Open();
					cm.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Var.WriteErrorLog(ex.Message, MethodBase.GetCurrentMethod().Name, cm.CommandText);
					MessageBox.Show("テーブルの作成中にエラーが発生しました。\n\n" + ex.Message, Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void reloadButton_Click(object sender, EventArgs e)
		{
			loadValue();
		}
	}
}