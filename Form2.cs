using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace e2bapp
{
	public partial class Form2 : Form
	{
		General.Var Var = new General.Var();
		public Form2()
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
				portText.Value = Convert.ToInt32(Var.ReadIni("Connect", "Port", "1433"));
				userText.Text = Var.ReadIni("Connect", "User", "sa");
				passText.Text = Var.ReadIni("Connect", "Pass", string.Empty);
			}
			else
			{
				// 初回起動
				urlText.Text = "localhost";
				portText.Value = 1433;
				userText.Text = "sa";
				passText.Text = string.Empty;
			}
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			// iniへ保存
			Var.IniWrite("Connect", "URL", urlText.Text.Trim());
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
			string dbUrl = urlText.Text.Trim() + "," + portText.Value.ToString();

			// 必須チェック
			if (urlText.Text.Length == 0 || string.IsNullOrEmpty(portText.Value.ToString()) || userText.Text.Length == 0 || passText.Text.Length == 0)
			{
				// 必要な情報がないためエラー
				MessageBox.Show("URL、ポート番号、ユーザ名、パスワードのうち1つ以上が不足しています。", Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			try
			{
				// SQL作成
				SqlConnection cn = new SqlConnection(new SqlConnectionStringBuilder()
				{
					IntegratedSecurity = false,
					DataSource = dbUrl,
					UserID = userText.Text.Trim(),
					Password = passText.Text.Trim()
				}.ToString()
				);
				SqlCommand cm;
				cm = new SqlCommand()
				{
					CommandType = CommandType.Text,
					CommandTimeout = 30,
					CommandText = @"CREATE DATABASE [dekosoft_e2b]"
				};
				cm.Connection = cn;

				SqlCommand cm2 = new SqlCommand()
				{
					CommandType = CommandType.Text,
					CommandTimeout = 30,
					CommandText = @"CREATE TABLE [dekosoft_e2b].[dbo].[e2b_item1] ( [ID] INT IDENTITY(1,1) NOT NULL, [BOOK_TITLE] NVARCHAR(255), [VOLUME] INT, [STATUS] INT, [ISBN13] NVARCHAR(13) PRIMARY KEY, [ISBN10] NVARCHAR(10), [TAG] NVARCHAR(255), [INSERT_DATE] DATETIME)"
				};
				cm2.Connection = cn;

				// データベース作成
				try
				{
					cn.Open();
					cm.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Var.WriteErrorLog(ex.Message, MethodBase.GetCurrentMethod().Name, cm.CommandText);
					MessageBox.Show("データベースの作成中にエラーが発生しました。\n\n" + ex.Message, Var.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				// テーブル作成
				try
				{
					cm2.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Var.WriteErrorLog(ex.Message, MethodBase.GetCurrentMethod().Name, cm2.CommandText);
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