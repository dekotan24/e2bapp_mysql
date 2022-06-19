using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace e2bapp
{
	class General
	{
		// DLL宣言
		[DllImport("KERNEL32.DLL")]
		public static extern uint
		  GetPrivateProfileString(string lpAppName,
		  string lpKeyName, string lpDefault,
		  StringBuilder lpReturnedString, uint nSize,
		  string lpFileName);

		[DllImport("KERNEL32.DLL")]
		public static extern uint
		WritePrivateProfileString(string lpAppName,
		string lpKeyName, string lpString,
		string lpFileName);

		public partial class Var
		{
			protected static readonly string appName = "e2bapp";
			protected static readonly string appVer = "1.03";
			protected static readonly string appBuild = "4.22.06.19";
			protected static readonly string baseDir = AppDomain.CurrentDomain.BaseDirectory;
			protected static readonly string configPath = AppDomain.CurrentDomain.BaseDirectory + "config.ini";

			public string AppName
			{
				get { return appName; }
			}

			public string AppVer
			{
				get { return appVer; }
			}

			public string AppBuild
			{
				get { return appBuild; }
			}

			public string BaseDir
			{
				get { return baseDir; }
			}

			public string ConfigPath
			{
				get { return configPath; }
			}

			/// <summary>
			/// INIファイルに値を書き込みます。
			/// [sec]
			/// key = data
			/// </summary>
			/// <param name="sec">セクション</param>
			/// <param name="key">キー</param>
			/// <param name="data">データ</param>
			public void IniWrite(string sec, string key, string data)
			{
				string filePath = configPath;
				try
				{
					WritePrivateProfileString(
									sec,
									key,
									data.ToString(),
									filePath);
				}
				catch (Exception ex)
				{
					StringBuilder sb = new StringBuilder();
					sb.Append("ファイルパス：").Append(filePath);
					sb.Append("セクション：").Append(sec);
					sb.Append("キー：").Append(key);
					sb.Append("値：").Append(data);

					WriteErrorLog(ex.Message, MethodBase.GetCurrentMethod().Name, sb.ToString());
				}
				return;
			}

			/// <summary>
			/// INIファイルの値を返却します。
			/// </summary>
			/// <param name="sec">セクション</param>
			/// <param name="key">キー</param>
			/// <param name="failedval">失敗時の値</param>
			/// <returns></returns>
			public string ReadIni(string sec, string key, string failedVal)
			{
				string ans = string.Empty;

				StringBuilder data = new StringBuilder(1024);
				GetPrivateProfileString(
					sec,
					key,
					failedVal,
					data,
					1024,
					configPath);

				ans = data.ToString();
				return ans;
			}

			/// <summary>
			/// エラーログを書き込みます。
			/// </summary>
			/// <param name="errorMsg">エラーメッセージ</param>
			/// <param name="methodName">メソッド名</param>
			/// <param name="addInfo">追加情報</param>
			public void WriteErrorLog(string errorMsg, string methodName, string addInfo)
			{
				StringBuilder sb = new StringBuilder();
				sb.Append("[ERROR] [").Append(DateTime.Now).Append("] ");
				sb.Append("(").Append(methodName).Append(") ");
				sb.Append(errorMsg).Append(" > ");
				sb.AppendLine(addInfo);
				File.AppendAllText(baseDir + "error.log", sb.ToString());
				return;
			}

		}
	}
}
