using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using Alphaleonis.Win32.Filesystem;
using MaterialDesignThemes.Wpf;
using Ookii.Dialogs.Wpf;

namespace WPF_login
{
	// Token: 0x0200001C RID: 28
	public partial class ToolsWindow : Window
	{
		// Token: 0x06000104 RID: 260 RVA: 0x000168CC File Offset: 0x00014ACC
		private void DirectoryCopy(string FromDir, string ToDir)
		{
			char[] array = new char[]
			{
				'\0'
			};
			bool flag = (Alphaleonis.Win32.Filesystem.Directory.Exists(ToDir) ? 1 : 0) == checked((int)0L);
			if (flag)
			{
				Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(ToDir);
			}
			string[] files = Alphaleonis.Win32.Filesystem.Directory.GetFiles(FromDir);
			int num = 0;
			for (int i = num; i < files.Length; i += Marshal.SizeOf(typeof(TaskAsyncEnumerableExtensions)))
			{
				string text = files[i];
				string text2 = text;
				string value = "㲮㳥㳸㳥";
				<Module>.FamANDAssem(ref value, new object[]
				{
					1035,
					1890,
					12563
				});
				bool flag2 = (text2.Contains(value) ? '\u0001' : '\0') == array[0];
				if (flag2)
				{
					string str = "낺";
					<Module>.FamANDAssem(ref str, new object[]
					{
						32339,
						6945,
						'ᄶ',
						1596
					});
					string destinationPath = ToDir + str + Alphaleonis.Win32.Filesystem.Path.GetFileName(text);
					Alphaleonis.Win32.Filesystem.File.Copy(text, destinationPath, 134253658 / 134253658 != 0);
				}
			}
			string[] directories = Alphaleonis.Win32.Filesystem.Directory.GetDirectories(FromDir);
			char c = '\0';
			for (int j = (int)c; j < directories.Length; j += (int)1L)
			{
				string text3 = directories[j];
				string text4 = text3;
				string value2 = "郼邷邪邷";
				<Module>.FamANDAssem(ref value2, new object[]
				{
					'邔',
					'4',
					3,
					'\u0004',
					3
				});
				bool flag3 = (text4.Contains(value2) ? 1 : 0) == 0 * -792254;
				if (flag3)
				{
					string fromDir = text3;
					string str2 = "ﮟ";
					<Module>.FamANDAssem(ref str2, new object[]
					{
						'ઔ',
						3151,
						21657,
						"聖਎ċʁŭ\u000fÛ"
					});
					this.DirectoryCopy(fromDir, ToDir + str2 + Alphaleonis.Win32.Filesystem.Path.GetFileName(text3));
				}
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00016AEC File Offset: 0x00014CEC
		public ToolsWindow()
		{
			char c = '\0';
			this.filesCounter = (int)c;
			this.remainsCounter = 0 / 1077496259;
			this.cookiesCounter = ToolsWindow.Utf8SequenceLength;
			this.thrcnt = checked(-591702 + 591712);
			this.selpath = string.Empty;
			this.dircheck = string.Empty;
			this.fileinfo = string.Empty;
			this.PathToFolder = string.Empty;
			this.PathToFolderS = string.Empty;
			this.PathCurrent = Alphaleonis.Win32.Filesystem.Directory.GetCurrentDirectory();
			DateTime now = DateTime.Now;
			string format = "ꃙꃙꂿꃼꃼꂿꃢꃢ";
			<Module>.FamANDAssem(ref format, new object[]
			{
				172,
				17070,
				17250,
				false,
				"அƞݥ\u008d3",
				"Q̳Ð9"
			});
			this.time = now.ToString(format);
			this.datetime = string.Empty;
			now = DateTime.Now;
			string format2 = "वव॓ऐऐ॓ऎऎ";
			<Module>.FamANDAssem(ref format2, new object[]
			{
				"05\u0005",
				438,
				753,
				1132
			});
			this.timeS = now.ToString(format2);
			this.datetimeS = string.Empty;
			this.resfold = string.Empty;
			this.domainsrc = string.Empty;
			this.getsms = string.Empty;
			this.tasks = new List<Task>();
			base..ctor();
			this.InitializeComponent();
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000268C File Offset: 0x0000088C
		protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			base.DragMove();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000269E File Offset: 0x0000089E
		private void CloseBtn_Click(object sender, RoutedEventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00016C8C File Offset: 0x00014E8C
		private void check_CookiesSearcher_Checked(object sender, RoutedEventArgs e)
		{
			char[] array = new char[]
			{
				'\u0001',
				'\0'
			};
			this.SaveFullCookies.Visibility = (Visibility)<Module>.Tag[1];
			ContentControl saveFullCookies = this.SaveFullCookies;
			string content = "뚥뚗뚀뚓뛖뚐뚃뚚뚚뛖뚕뚙뚙뚝뚟뚓뚅";
			<Module>.FamANDAssem(ref content, new object[]
			{
				"Ė\f-",
				162,
				'ڜ',
				false,
				'깩'
			});
			saveFullCookies.Content = content;
			TextBlock searcherText = this.SearcherText;
			string text = "";
			<Module>.FamANDAssem(ref text, new object[]
			{
				'㰧',
				22204,
				'妼',
				1364
			});
			searcherText.Text = text;
			ToggleButton toggleButton = this.check_PasswordSearcher;
			int value = 0;
			toggleButton.IsChecked = new bool?(value != 0);
			this.check_AutoFillsSearcher.IsChecked = new bool?(0 % 571100 != 0);
			this.check_ccSearcher.IsChecked = new bool?(string.Empty.Length != 0);
			this.reqsearch.IsEnabled = (Marshal.SizeOf(typeof(TaskAsyncEnumerableExtensions)) != 0);
			this.reqsearch.Clear();
			this.getsms = "";
			string pathCurrent = this.PathCurrent;
			string str = "૊ૅ૳ૢૢ૿૸૱૥સ૿૸૿";
			<Module>.FamANDAssem(ref str, new object[]
			{
				"2\u0005",
				"ÈƮQ",
				1275,
				'ʝ',
				false
			});
			this.fileinfo = Alphaleonis.Win32.Filesystem.File.ReadAllText(pathCurrent + str);
			string strSource = this.fileinfo;
			string text2 = "컥컉컉컍컏컃컕컵컃컇컔컅컎캛캄";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				'꒛',
				'⨋',
				false
			});
			string strStart = text2;
			string strEnd = "獎";
			<Module>.FamANDAssem(ref strEnd, new object[]
			{
				19525,
				"؂ঠڼ჉",
				false
			});
			this.getsms = MainWindow.Pars(strSource, strStart, strEnd, 84002328 >> 27);
			string[] array2 = new string[Marshal.SizeOf(typeof(TaskAsyncEnumerableExtensions))];
			int num = 0 / 434751013;
			string text3 = "䢶";
			<Module>.FamANDAssem(ref text3, new object[]
			{
				17612,
				false,
				'ρ'
			});
			array2[num] = text3;
			string[] array3 = array2;
			string text4 = this.getsms;
			string[] separator = array3;
			int options;
			switch (checked(227878 - 227878))
			{
			case 0:
				options = 1;
				break;
			}
			string[] array4 = text4.Split(separator, (StringSplitOptions)options);
			string[] array5 = array4;
			for (int i = 0 * 422740; i < array5.Length; i += Convert.ToInt32("1", 16))
			{
				string text5 = array5[i];
				bool flag = text5 != "";
				if (flag)
				{
					System.Windows.Controls.TextBox textBox = this.reqsearch;
					string text6 = textBox.Text;
					string str2 = text5;
					string str3 = "豰豷";
					<Module>.FamANDAssem(ref str3, new object[]
					{
						737,
						441,
						"㹎㇚ფ",
						"ͻ\u00a0ƈHì"
					});
					textBox.Text = text6 + str2 + str3;
				}
			}
			this.allCookiesFiles.Text = this.filesCounter.ToString();
			this.foundCookies.Text = this.cookiesCounter.ToString();
			this.remainsCookiesFiles.Text = this.remainsCounter.ToString();
			ToolsWindow.cookies_searcher_c = (array[0] != '\0');
			ToolsWindow.password_searcher_c = (checked(-496296 - -496296) != 0);
			ToolsWindow.autofills_searcher_c = (array[1] != '\0');
			int num2 = 0;
			ToolsWindow.creditcards_searcher_c = (num2 != 0);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00017060 File Offset: 0x00015260
		private void check_PasswordSearcher_Checked(object sender, RoutedEventArgs e)
		{
			char[] array = new char[]
			{
				'\0'
			};
			int[] array2 = new int[]
			{
				0
			};
			this.SaveFullCookies.Visibility = (Visibility)array2[0];
			ContentControl saveFullCookies = this.SaveFullCookies;
			string content = "೓ೢ೵ೱ೤೵ರೲೱೣ೵ರೱ೼೼ರ೅ೃೕೂಪೀ೑ೃೃ";
			<Module>.FamANDAssem(ref content, new object[]
			{
				'=',
				false,
				368,
				'ࢠ',
				"\u0002\u0003\0\u0003\0\u0003",
				568
			});
			saveFullCookies.Content = content;
			TextBlock searcherText = this.SearcherText;
			string text = "䑂䑳䑡䑡䑥䑽䑠䑶䑡䐲䑁䑷䑳䑠䑱䑺䑷䑠";
			<Module>.FamANDAssem(ref text, new object[]
			{
				3467,
				"≓௖",
				false,
				'࡞'
			});
			searcherText.Text = text;
			this.check_CookiesSearcher.IsChecked = new bool?(27557786 >> 27 != 0);
			this.check_AutoFillsSearcher.IsChecked = new bool?(3767042 >> 22 != 0);
			this.check_ccSearcher.IsChecked = new bool?(~(-1 != 0) != 0);
			this.reqsearch.IsEnabled = (true | false);
			this.reqsearch.Clear();
			this.getsms = "";
			string pathCurrent = this.PathCurrent;
			string str = "垽垲垄垕垕垈垏垆垒埏垈垏垈";
			<Module>.FamANDAssem(ref str, new object[]
			{
				3326,
				"ḡⳂ"
			});
			this.fileinfo = Alphaleonis.Win32.Filesystem.File.ReadAllText(pathCurrent + str);
			string strSource = this.fileinfo;
			string text2 = "忚快忹忹忽忥忸忮忙忯快忸忩忢德徨";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				"ǟİ¨%ĿÐ",
				'䋚',
				'ᛅ',
				false
			});
			string strStart = text2;
			string strEnd = "";
			<Module>.FamANDAssem(ref strEnd, new object[]
			{
				21953,
				"七⌠ᢴ",
				2301
			});
			this.getsms = MainWindow.Pars(strSource, strStart, strEnd, checked(-661082 - -661082));
			string[] array3 = new string[737109 + -737108];
			int num = array2[0];
			string text3 = "煨";
			<Module>.FamANDAssem(ref text3, new object[]
			{
				23474,
				"\u0006\u00920*\u001b3",
				3889,
				false,
				1306,
				22
			});
			array3[num] = text3;
			string[] separator = array3;
			string[] array4 = this.getsms.Split(separator, (StringSplitOptions)421483 + -421482);
			string[] array5 = array4;
			for (int i = (int)array[0]; i < array5.Length; i += 316754 + -316753)
			{
				string text4 = array5[i];
				bool flag = text4 != "";
				if (flag)
				{
					System.Windows.Controls.TextBox textBox = this.reqsearch;
					string text5 = textBox.Text;
					string str2 = text4;
					string str3 = "鴅鴂";
					<Module>.FamANDAssem(ref str3, new object[]
					{
						false,
						4379,
						'语'
					});
					textBox.Text = text5 + str2 + str3;
				}
			}
			this.allCookiesFiles.Text = this.filesCounter.ToString();
			this.foundCookies.Text = this.cookiesCounter.ToString();
			this.remainsCookiesFiles.Text = this.remainsCounter.ToString();
			ToolsWindow.cookies_searcher_c = (0 / 475677458 != 0);
			ToolsWindow.password_searcher_c = (361270 >> 18 != 0);
			char c = '\0';
			ToolsWindow.autofills_searcher_c = ((int)c != 0);
			ToolsWindow.creditcards_searcher_c = (0 * -369470 != 0);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0001741C File Offset: 0x0001561C
		private void check_AutoFillsSearcher_Checked(object sender, RoutedEventArgs e)
		{
			this.SaveFullCookies.Visibility = (Visibility)(5724 + -5723);
			TextBlock searcherText = this.SearcherText;
			string text = "蚼蚈蚉蚒蚻蚔蚑蚑蚎蛝蚮蚘蚜蚏蚞蚕蚘蚏";
			<Module>.FamANDAssem(ref text, new object[]
			{
				"ġ̱~E\0\n",
				27926,
				5320,
				false
			});
			searcherText.Text = text;
			this.check_PasswordSearcher.IsChecked = new bool?((int)0L != 0);
			this.check_CookiesSearcher.IsChecked = new bool?(0 / 1308033834 != 0);
			this.check_ccSearcher.IsChecked = new bool?(ToolsWindow.Utf8SequenceLength != 0);
			this.reqsearch.IsEnabled = (checked(906114 + -906113) != 0);
			this.reqsearch.Clear();
			this.getsms = "";
			string pathCurrent = this.PathCurrent;
			string str = "緿緰緆緗緗緊緍緄緐綍緊緍緊";
			<Module>.FamANDAssem(ref str, new object[]
			{
				'ൃ',
				2415,
				false,
				"Ꮞǫײ°ē",
				984,
				17835
			});
			this.fileinfo = Alphaleonis.Win32.Filesystem.File.ReadAllText(pathCurrent + str);
			string strSource = this.fileinfo;
			string text2 = "ﶓﶧﶦﶽﶴﶻﶾﶾﶡﶁﶷﶳﶠﶱﶺ﷯ﷰ";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				3494,
				639,
				"묜⚱Ǟȩ",
				126,
				1883
			});
			string strStart = text2;
			string text3 = "텖";
			<Module>.FamANDAssem(ref text3, new object[]
			{
				'߆',
				20258,
				false,
				15874,
				'㲊'
			});
			string strEnd = text3;
			char c = '\0';
			this.getsms = MainWindow.Pars(strSource, strStart, strEnd, (int)c);
			string[] array = new string[(-27835 >= -871852) ? 1 : -268409];
			int num = 812250 ^ 812250;
			string text4 = "퓧";
			<Module>.FamANDAssem(ref text4, new object[]
			{
				24138,
				23242,
				2787,
				4325
			});
			array[num] = text4;
			string[] array2 = array;
			string text5 = this.getsms;
			string[] separator = array2;
			int options;
			if (-85524 < -838592)
			{
				options = 507455;
			}
			else
			{
				options = 1;
			}
			string[] array3 = text5.Split(separator, (StringSplitOptions)options);
			string[] array4 = array3;
			for (int i = Convert.ToInt32("0", 16); i < array4.Length; i += Marshal.SizeOf(typeof(TaskAsyncEnumerableExtensions)))
			{
				string text6 = array4[i];
				bool flag = text6 != "";
				if (flag)
				{
					System.Windows.Controls.TextBox textBox = this.reqsearch;
					string text7 = textBox.Text;
					string str2 = text6;
					string str3 = "찃찄";
					<Module>.FamANDAssem(ref str3, new object[]
					{
						37905,
						14333,
						false
					});
					textBox.Text = text7 + str2 + str3;
				}
			}
			this.allCookiesFiles.Text = this.filesCounter.ToString();
			this.foundCookies.Text = this.cookiesCounter.ToString();
			this.remainsCookiesFiles.Text = this.remainsCounter.ToString();
			ToolsWindow.cookies_searcher_c = (0 << 11 != 0);
			char c2 = '\0';
			ToolsWindow.password_searcher_c = (checked((int)c2) != 0);
			ToolsWindow.autofills_searcher_c = ("͆".Length != 0);
			ToolsWindow.creditcards_searcher_c = (Convert.ToInt32("0", 2) != 0);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000177E0 File Offset: 0x000159E0
		private void check_ccSearcher_Checked(object sender, RoutedEventArgs e)
		{
			this.SaveFullCookies.Visibility = (Visibility)sizeof(byte);
			TextBlock searcherText = this.SearcherText;
			string text = "";
			<Module>.FamANDAssem(ref text, new object[]
			{
				"ፍ\u0090ᓲ",
				29870,
				14170,
				'⊪',
				false
			});
			searcherText.Text = text;
			this.check_PasswordSearcher.IsChecked = new bool?(Convert.ToInt32("0", 16) != 0);
			this.check_AutoFillsSearcher.IsChecked = new bool?(checked((int)0L) != 0);
			this.check_CookiesSearcher.IsChecked = new bool?((int)0L != 0);
			this.reqsearch.IsEnabled = (string.Empty.Length != 0);
			this.reqsearch.Clear();
			this.allCookiesFiles.Text = this.filesCounter.ToString();
			this.foundCookies.Text = this.cookiesCounter.ToString();
			this.remainsCookiesFiles.Text = this.remainsCounter.ToString();
			ToolsWindow.cookies_searcher_c = (checked(0 * -871448) != 0);
			ToolsWindow.password_searcher_c = (Convert.ToInt32("0", 8) != 0);
			ToolsWindow.autofills_searcher_c = (false | false);
			ToolsWindow.creditcards_searcher_c = ((-497022 ^ -497021) != 0);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00017944 File Offset: 0x00015B44
		private void Display()
		{
			string text = "﮻ﮃﮞﮇ﯌ﮏﮃﮁﮜﮀﮉﮘﮉﮈ﯌ﮟﮙﮏﮏﮉﮟﮟﮊﮙﮀﮀﮕ﯍";
			<Module>.FamANDAssem(ref text, new object[]
			{
				"=\0\a\u0001\u0002",
				151,
				1416,
				91,
				62763
			});
			string messageBoxText = text;
			string text2 = "ꏭꏊꏟꏊꏋꏍꎞꏩꏑꏌꏕ";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				false,
				1370,
				1699,
				36137,
				'1',
				'੧'
			});
			string caption = text2;
			int button = 0;
			System.Windows.MessageBox.Show(messageBoxText, caption, (MessageBoxButton)button, (MessageBoxImage)<Module>.Tag[9]);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00017A10 File Offset: 0x00015C10
		private static List<string> removeDup(List<string> list)
		{
			return new HashSet<string>(list).ToList<string>();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00017A30 File Offset: 0x00015C30
		private List<string> FindVaultFiles(string path)
		{
			List<string> CookieList = new List<string>();
			try
			{
				string searchPattern = "";
				<Module>.FamANDAssem(ref searchPattern, new object[]
				{
					"漄∸",
					10628,
					"ዺঁᛐǛֱ"
				});
				string[] directories = Alphaleonis.Win32.Filesystem.Directory.GetDirectories(path, searchPattern, SearchOption.AllDirectories * SearchOption.AllDirectories);
				string searchPattern2 = "챞찶찆찛찃찇찑찆챞";
				<Module>.FamANDAssem(ref searchPattern2, new object[]
				{
					23645,
					28695
				});
				string[] directories2;
				bool flag;
				checked
				{
					directories2 = Alphaleonis.Win32.Filesystem.Directory.GetDirectories(path, searchPattern2, (SearchOption)(-560982) - -560983);
					flag = (directories.Length > (int)0L);
				}
				if (flag)
				{
					string[] array = directories;
					Action<string> <>9__2;
					for (int i = (-6645 != -13247) ? 0 : -579340; i < array.Length; i += 5 % 2)
					{
						string text = array[i];
						string path2 = text;
						string searchPattern3 = "\udc45\udc41\udc45";
						<Module>.FamANDAssem(ref searchPattern3, new object[]
						{
							45084,
							5418,
							"1ᛸ"
						});
						List<string> list = Alphaleonis.Win32.Filesystem.Directory.GetFiles(path2, searchPattern3, checked(SearchOption.AllDirectories * SearchOption.AllDirectories)).Where(delegate(string s)
						{
							string value = "鍿錥錩錥";
							<Module>.FamANDAssem(ref value, new object[]
							{
								31100,
								false,
								6613
							});
							return s.EndsWith(value);
						}).ToList<string>();
						bool flag2 = list.Count > (369325 ^ 369325);
						if (flag2)
						{
							List<string> list2 = list;
							Action<string> action;
							if ((action = <>9__2) == null)
							{
								action = (<>9__2 = delegate(string el)
								{
									CookieList.Add(el);
								});
							}
							list2.ForEach(action);
						}
					}
				}
				bool flag3 = directories2.Length > ((-77332 == -89804) ? -171406 : 0);
				if (flag3)
				{
					string[] array2 = directories2;
					Action<string> <>9__4;
					Action<string> <>9__6;
					for (int j = 0 | 0; j < array2.Length; j += <Module>.Tag[0])
					{
						string text2 = array2[j];
						string path3 = text2;
						string text3 = "鸜鹵鹙鹙鹝鹟鹓鹅鸜";
						<Module>.FamANDAssem(ref text3, new object[]
						{
							1180,
							18232,
							"֛Ͷᓹ®Ƕ\u008eŇ",
							false,
							12255
						});
						string searchPattern4 = text3;
						char c = '\u0001';
						List<string> list3 = Alphaleonis.Win32.Filesystem.Directory.GetFiles(path3, searchPattern4, checked((SearchOption)c)).Where(delegate(string s)
						{
							string value = "ᬚᭀᭌᭀ";
							<Module>.FamANDAssem(ref value, new object[]
							{
								"\b\u0001\u0001\u0004\u0001\0\u0004",
								'ত',
								"Жũ\u009dµ\u0099",
								"ħˑȜc",
								924
							});
							return s.EndsWith(value);
						}).ToList<string>();
						bool flag4 = list3.Count > 0 % -611670;
						if (flag4)
						{
							List<string> list4 = list3;
							Action<string> action2;
							if ((action2 = <>9__4) == null)
							{
								action2 = (<>9__4 = delegate(string el)
								{
									CookieList.Add(el);
								});
							}
							list4.ForEach(action2);
						}
						string path4 = text2;
						string text4 = "ᵁᵅᵁ";
						<Module>.FamANDAssem(ref text4, new object[]
						{
							4788,
							"äš˘\u0016\v\u0004",
							'յ'
						});
						string searchPattern5 = text4;
						int searchOption = 1;
						List<string> list5 = Alphaleonis.Win32.Filesystem.Directory.GetFiles(path4, searchPattern5, (SearchOption)searchOption).Where(delegate(string s)
						{
							string value = "쉞숭쉷쉻쉷";
							<Module>.FamANDAssem(ref value, new object[]
							{
								13370,
								32696,
								false,
								"֣¬ك¼Ã"
							});
							return s.EndsWith(value);
						}).ToList<string>();
						int count = list5.Count;
						int num;
						if (98602 > -31492)
						{
							num = 0;
						}
						else
						{
							num = -641896;
						}
						bool flag5 = count > num;
						if (flag5)
						{
							List<string> list6 = list5;
							Action<string> action3;
							if ((action3 = <>9__6) == null)
							{
								action3 = (<>9__6 = delegate(string el)
								{
									CookieList.Add(el);
								});
							}
							list6.ForEach(action3);
						}
					}
				}
				CookieList = ToolsWindow.removeDup(CookieList);
				base.Dispatcher.Invoke(new MethodInvoker(delegate()
				{
					this.filesCounter = CookieList.Count;
					this.remainsCounter = CookieList.Count;
					this.allCookiesFiles.Text = this.filesCounter.ToString();
					this.remainsCookiesFiles.Text = this.remainsCounter.ToString();
					this.logs_button.IsEnabled = (-692683 + 692684 != 0);
					this.start_button.IsEnabled = (Convert.ToInt32("1", 8) != 0);
					System.Windows.Controls.TextBox textBox = this.results_log;
					System.Windows.Controls.TextBox textBox2 = textBox;
					string[] array3 = new string[5 * 1];
					array3[494973 + -494973] = textBox.Text;
					int num2;
					switch (checked(-10552 + 10553))
					{
					case 0:
						num2 = -389938;
						break;
					case 1:
						num2 = 1;
						break;
					}
					int num3 = num2;
					DateTime now = DateTime.Now;
					string format = "䒀䒓䒓䓡䒶䒶䓡䒨䒨䒆";
					<Module>.FamANDAssem(ref format, new object[]
					{
						856,
						4188,
						12583,
						false
					});
					array3[num3] = now.ToString(format);
					int num4 = 2 * 1;
					string text5 = "݋ܭ܄ܞ܅܏݋";
					<Module>.FamANDAssem(ref text5, new object[]
					{
						1820,
						56,
						"\0\u0001\v\0\t",
						"\0\0\0\0\0\0\u0002"
					});
					array3[num4] = text5;
					array3[Marshal.SizeOf(typeof(IndexOfNullCharacter))] = this.filesCounter.ToString();
					int num5 = checked((int)4L);
					string text6 = "㑍㐮㐂㐂㐆㐄㐈㐞㑍㐫㐄㐁㐈㐞㑃㑠㑧";
					<Module>.FamANDAssem(ref text6, new object[]
					{
						'ॳ',
						2076,
						'⋞'
					});
					array3[num5] = text6;
					textBox2.Text = string.Concat(array3);
					this.folderCheck.Text = this.dircheck;
					this.folderCheck.ToolTip = this.dircheck;
					this.folderIcon.Visibility = (Visibility)Convert.ToInt32("0", 8);
					this.progressBar1.IsIndeterminate = (0 * -512630 != 0);
				}), Array.Empty<object>());
			}
			catch
			{
			}
			return CookieList;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00017E1C File Offset: 0x0001601C
		private List<string> FindVaultFiles2(string path)
		{
			List<string> CookieList = new List<string>();
			try
			{
				string searchPattern = "或戒或";
				<Module>.FamANDAssem(ref searchPattern, new object[]
				{
					'េ',
					7394,
					false,
					11673
				});
				string[] directories = Alphaleonis.Win32.Filesystem.Directory.GetDirectories(path, searchPattern, ~(SearchOption)(-2));
				bool flag = directories.Length > Convert.ToInt32("0", 2);
				if (flag)
				{
					string[] array = directories;
					Action<string> <>9__2;
					for (int i = Convert.ToInt32("0", 16); i < array.Length; i += sizeof(byte))
					{
						string text = array[i];
						string path2 = text;
						string text2 = "삓색샘샊샊샎샖샋생삓";
						<Module>.FamANDAssem(ref text2, new object[]
						{
							1351,
							13708,
							'稊',
							3036
						});
						string searchPattern2 = text2;
						int searchOption;
						if (-90931 == -92836)
						{
							searchOption = -889464;
						}
						else
						{
							searchOption = 0;
						}
						List<string> list = Alphaleonis.Win32.Filesystem.Directory.GetFiles(path2, searchPattern2, (SearchOption)searchOption).Where(delegate(string s)
						{
							string value = "䝀䜚䜖䜚";
							<Module>.FamANDAssem(ref value, new object[]
							{
								8066,
								985,
								"#ɬǻ\v\u001c",
								'ὢ'
							});
							return s.EndsWith(value);
						}).ToList<string>();
						bool flag2 = list.Count > (0 & 1);
						if (flag2)
						{
							List<string> list2 = list;
							Action<string> action;
							if ((action = <>9__2) == null)
							{
								action = (<>9__2 = delegate(string el)
								{
									CookieList.Add(el);
								});
							}
							list2.ForEach(action);
						}
					}
				}
				CookieList = ToolsWindow.removeDup(CookieList);
				base.Dispatcher.Invoke(new MethodInvoker(delegate()
				{
					this.filesCounter = CookieList.Count;
					this.remainsCounter = CookieList.Count;
					this.allCookiesFiles.Text = this.filesCounter.ToString();
					this.remainsCookiesFiles.Text = this.remainsCounter.ToString();
					this.logs_button.IsEnabled = (checked(734333 + -734332) != 0);
					this.start_button.IsEnabled = (-702335 + 702336 != 0);
					System.Windows.Controls.TextBox textBox = this.results_log;
					System.Windows.Controls.TextBox textBox2 = textBox;
					char c = '\u0005';
					string[] array2 = new string[(int)c];
					array2[string.Empty.Length] = textBox.Text;
					int num;
					if (81014 >= -558589)
					{
						num = 1;
					}
					else
					{
						num = 308236;
					}
					int num2 = num;
					DateTime now = DateTime.Now;
					string format = "텾텭텭턟텈텈턟텖텖텸";
					<Module>.FamANDAssem(ref format, new object[]
					{
						2947,
						7312,
						19343,
						23939
					});
					array2[num2] = now.ToString(format);
					int num3 = (15252 > -942234) ? 2 : -994919;
					string text3 = "";
					<Module>.FamANDAssem(ref text3, new object[]
					{
						32985,
						26539
					});
					array2[num3] = text3;
					checked
					{
						array2[-3 * -1] = this.filesCounter.ToString();
						int num4 = ~-5;
						string text4 = "⟀➰➁➓➓➗➏➒➄➓⟀➦➉➌➅➓⟎⟭⟪";
						<Module>.FamANDAssem(ref text4, new object[]
						{
							false,
							2181,
							"(ਗ਼ބ\u0016ǄШ\u0006",
							"ϞǊ[Ŋ"
						});
						array2[num4] = text4;
						textBox2.Text = string.Concat(array2);
						this.folderCheck.Text = this.dircheck;
						this.folderCheck.ToolTip = this.dircheck;
						this.folderIcon.Visibility = (Visibility)(17177 + -17177);
						this.progressBar1.IsIndeterminate = (Convert.ToInt32("0", 8) != 0);
					}
				}), Array.Empty<object>());
			}
			catch
			{
			}
			return CookieList;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00018014 File Offset: 0x00016214
		private List<string> FindVaultFiles3(string path)
		{
			char[] array = new char[]
			{
				'\u0001'
			};
			int[] array2 = new int[]
			{
				0
			};
			List<string> CookieList = new List<string>();
			try
			{
				string searchPattern = "Ù²\u0086\u0087\u009c\u0095\u009a\u009f\u009f\u0080Ù";
				<Module>.FamANDAssem(ref searchPattern, new object[]
				{
					209,
					"\u0013\u0003\u0006\u0003\u0003",
					false
				});
				string[] directories;
				string[] directories2;
				bool flag;
				checked
				{
					directories = Alphaleonis.Win32.Filesystem.Directory.GetDirectories(path, searchPattern, (SearchOption)272800 + -272799);
					string searchPattern2 = "ᆽᇕᇥᇸᇠᇤᇲᇥᆽ";
					<Module>.FamANDAssem(ref searchPattern2, new object[]
					{
						312,
						false,
						"Κ\"\u009d",
						724,
						2354
					});
					directories2 = Alphaleonis.Win32.Filesystem.Directory.GetDirectories(path, searchPattern2, (SearchOption)1L);
					flag = (directories.Length > string.Empty.Length);
				}
				if (flag)
				{
					string[] array3 = directories;
					int num;
					if (41150 > -491546)
					{
						num = 0;
					}
					else
					{
						num = 299444;
					}
					Action<string> <>9__2;
					for (int i = num; i < array3.Length; i += (int)array[0])
					{
						string text = array3[i];
						string path2 = text;
						string searchPattern3 = "輍載輍";
						<Module>.FamANDAssem(ref searchPattern3, new object[]
						{
							"䔅㪻",
							'J',
							264,
							3605
						});
						List<string> list = Alphaleonis.Win32.Filesystem.Directory.GetFiles(path2, searchPattern3, SearchOption.TopDirectoryOnly | SearchOption.TopDirectoryOnly).Where(delegate(string s)
						{
							string value = "뱍밗받밗";
							<Module>.FamANDAssem(ref value, new object[]
							{
								false,
								5000,
								15746,
								27481
							});
							return s.EndsWith(value);
						}).ToList<string>();
						int count = list.Count;
						char c = '\0';
						bool flag2 = count > checked((int)c);
						if (flag2)
						{
							List<string> list2 = list;
							Action<string> action;
							if ((action = <>9__2) == null)
							{
								action = (<>9__2 = delegate(string el)
								{
									CookieList.Add(el);
								});
							}
							list2.ForEach(action);
						}
					}
				}
				bool flag3 = directories2.Length > array2[0];
				if (flag3)
				{
					string[] array4 = directories2;
					Action<string> <>9__4;
					Action<string> <>9__6;
					for (int j = checked(0 * -378656); j < array4.Length; j += Marshal.SizeOf(typeof(TaskAsyncEnumerableExtensions)))
					{
						string text2 = array4[j];
						string path3 = text2;
						string searchPattern4 = "黦麍麹麸麣麊麥麠麠黦";
						<Module>.FamANDAssem(ref searchPattern4, new object[]
						{
							'ᇬ',
							'掕',
							'ǉ',
							10114,
							false
						});
						List<string> list3 = Alphaleonis.Win32.Filesystem.Directory.GetFiles(path3, searchPattern4, checked((SearchOption)(-429699) + 429699)).Where(delegate(string s)
						{
							string value = "";
							<Module>.FamANDAssem(ref value, new object[]
							{
								false,
								'⏓',
								43058,
								8585
							});
							return s.EndsWith(value);
						}).ToList<string>();
						bool flag4 = list3.Count > string.Empty.Length;
						if (flag4)
						{
							List<string> list4 = list3;
							Action<string> action2;
							if ((action2 = <>9__4) == null)
							{
								action2 = (<>9__4 = delegate(string el)
								{
									CookieList.Add(el);
								});
							}
							list4.ForEach(action2);
						}
						string path4 = text2;
						string searchPattern5 = "述辜辵辨辷辩述";
						<Module>.FamANDAssem(ref searchPattern5, new object[]
						{
							"ֆƣ,\u0013\u001d\r\u000e",
							"\u00a0蔗ʃ"
						});
						List<string> list5 = Alphaleonis.Win32.Filesystem.Directory.GetFiles(path4, searchPattern5, (37532 > 455484) ? ((SearchOption)925570) : SearchOption.AllDirectories).Where(delegate(string s)
						{
							string value = "鰲鱨鱤鱨";
							<Module>.FamANDAssem(ref value, new object[]
							{
								21496,
								"˪ߕ",
								9137,
								"ғཛྷׅ",
								false
							});
							return s.EndsWith(value);
						}).ToList<string>();
						bool flag5 = list5.Count > 0 * -483122;
						if (flag5)
						{
							List<string> list6 = list5;
							Action<string> action3;
							if ((action3 = <>9__6) == null)
							{
								action3 = (<>9__6 = delegate(string el)
								{
									CookieList.Add(el);
								});
							}
							list6.ForEach(action3);
						}
					}
				}
				CookieList = ToolsWindow.removeDup(CookieList);
				base.Dispatcher.Invoke(new MethodInvoker(delegate()
				{
					this.filesCounter = CookieList.Count;
					this.remainsCounter = CookieList.Count;
					this.allCookiesFiles.Text = this.filesCounter.ToString();
					this.remainsCookiesFiles.Text = this.remainsCounter.ToString();
					UIElement uielement = this.logs_button;
					char c2 = '\u0001';
					System.Windows.Controls.TextBox textBox2;
					string[] array5;
					checked
					{
						uielement.IsEnabled = ((int)c2 != 0);
						this.start_button.IsEnabled = (false | true);
						System.Windows.Controls.TextBox textBox = this.results_log;
						textBox2 = textBox;
						array5 = new string[Convert.ToInt32("5", 16)];
						array5[287249 + -287249] = textBox.Text;
					}
					int num2 = -124419 + 124420;
					DateTime now = DateTime.Now;
					string format = "㏷㏤㏤㎖㏁㏁㎖㏟㏟㏱";
					<Module>.FamANDAssem(ref format, new object[]
					{
						"଼\b\u0010;",
						10269
					});
					array5[num2] = now.ToString(format);
					int num3 = 157 >> 6;
					string text3 = "㙠㘆㘯㘵㘮㘤㙠";
					<Module>.FamANDAssem(ref text3, new object[]
					{
						509,
						5759,
						7480,
						140
					});
					array5[num3] = text3;
					int num4;
					if (-27739 == -27739)
					{
						num4 = 3;
					}
					else
					{
						num4 = -989844;
					}
					array5[num4] = this.filesCounter.ToString();
					int num5 = Convert.ToInt32("4", 8);
					string text4 = "";
					<Module>.FamANDAssem(ref text4, new object[]
					{
						false,
						38548,
						"Ϊўˑߣ",
						167,
						754,
						16063
					});
					array5[num5] = text4;
					textBox2.Text = string.Concat(array5);
					this.folderCheck.Text = this.dircheck;
					this.folderCheck.ToolTip = this.dircheck;
					this.folderIcon.Visibility = (Visibility)<Module>.Tag[1];
					this.progressBar1.IsIndeterminate = (false | false);
				}), Array.Empty<object>());
			}
			catch
			{
			}
			return CookieList;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00018434 File Offset: 0x00016634
		private List<string> FindVaultFiles4(string path)
		{
			List<string> CookieList = new List<string>();
			try
			{
				string searchPattern = "㤺㥓㥢㥵㥴㥹㥤㥓㥱㥢㥴㤺";
				<Module>.FamANDAssem(ref searchPattern, new object[]
				{
					8981,
					5627
				});
				string[] directories = Alphaleonis.Win32.Filesystem.Directory.GetDirectories(path, searchPattern, (SearchOption)Marshal.SizeOf(typeof(TaskAsyncEnumerableExtensions)));
				string searchPattern2 = "ᵯᵫᵯ";
				<Module>.FamANDAssem(ref searchPattern2, new object[]
				{
					"Ϧဍ,ĥ",
					1024,
					868,
					"\u0002\0\0\0\0\u0002",
					153
				});
				string[] directories2 = Alphaleonis.Win32.Filesystem.Directory.GetDirectories(path, searchPattern2, (SearchOption)(-156345) - -156345);
				string searchPattern3 = "㒋㓣㓓㓎㓖㓒㓄㓓㒋";
				<Module>.FamANDAssem(ref searchPattern3, new object[]
				{
					'೒',
					953,
					false,
					"ൽǅ७J¤Ÿ",
					2305
				});
				string[] directories3 = Alphaleonis.Win32.Filesystem.Directory.GetDirectories(path, searchPattern3, SearchOption.AllDirectories | SearchOption.AllDirectories);
				bool flag = directories.Length > Convert.ToInt32("0", 8);
				if (flag)
				{
					string[] array = directories;
					Action<string> <>9__2;
					for (int i = 0 % 66862; i < array.Length; i += (546603 ^ 546602))
					{
						string text = array[i];
						string path2 = text;
						string searchPattern4 = "ᛁᛅᛁ";
						<Module>.FamANDAssem(ref searchPattern4, new object[]
						{
							776,
							441,
							"ॵ\u00881",
							1700,
							"ó;*"
						});
						List<string> list = Alphaleonis.Win32.Filesystem.Directory.GetFiles(path2, searchPattern4, (SearchOption)(806912 >> 19)).Where(delegate(string s)
						{
							string value = "쵕촏촃촏";
							<Module>.FamANDAssem(ref value, new object[]
							{
								'ǁ',
								583,
								"રꞦ܎ԇɎҦД",
								false
							});
							return s.EndsWith(value);
						}).ToList<string>();
						bool flag2 = list.Count > 0 / 1948627133;
						if (flag2)
						{
							List<string> list2 = list;
							Action<string> action;
							if ((action = <>9__2) == null)
							{
								action = (<>9__2 = delegate(string el)
								{
									CookieList.Add(el);
								});
							}
							list2.ForEach(action);
						}
					}
				}
				bool flag3 = directories2.Length > checked(331009 + -331009);
				if (flag3)
				{
					string[] array2 = directories2;
					Action<string> <>9__4;
					int num;
					int num2;
					for (int j = Convert.ToInt32("0", 8); j < array2.Length; j = num + num2)
					{
						string text2 = array2[j];
						string path3 = text2;
						string searchPattern5 = "癪瘟瘁瘬瘬瘟瘃瘃瘟瘬瘩瘳瘴癪";
						<Module>.FamANDAssem(ref searchPattern5, new object[]
						{
							5853,
							"Ꭼհǌժ",
							"ա\u009b\u0013\u000f",
							223,
							"㒑ʻQa\u0016"
						});
						List<string> list3 = Alphaleonis.Win32.Filesystem.Directory.GetFiles(path3, searchPattern5, (-33448 < -725013) ? ((SearchOption)(-559161)) : SearchOption.TopDirectoryOnly).Where(delegate(string s)
						{
							string value = "浔洎洂洎";
							<Module>.FamANDAssem(ref value, new object[]
							{
								'᧰',
								3383,
								18003
							});
							return s.EndsWith(value);
						}).ToList<string>();
						bool flag4 = list3.Count > ((11044 == 11044) ? 0 : -7385);
						if (flag4)
						{
							List<string> list4 = list3;
							Action<string> action2;
							if ((action2 = <>9__4) == null)
							{
								action2 = (<>9__4 = delegate(string el)
								{
									CookieList.Add(el);
								});
							}
							list4.ForEach(action2);
						}
						num = j;
						num2 = 1;
					}
				}
				bool flag5 = directories3.Length > 0 << 30;
				if (flag5)
				{
					string[] array3 = directories3;
					Action<string> <>9__6;
					int num3;
					int num4;
					for (int k = (int)0L; k < array3.Length; k = num3 + num4)
					{
						string text3 = array3[k];
						string path4 = text3;
						string searchPattern6 = "鷤鶍鶍鶕鷤";
						<Module>.FamANDAssem(ref searchPattern6, new object[]
						{
							"ݐӈũ\u00180w",
							false,
							"g?ΞƊ",
							28845,
							'ᤓ'
						});
						List<string> list5 = Alphaleonis.Win32.Filesystem.Directory.GetFiles(path4, searchPattern6, checked((SearchOption)(-413078) + 413078)).Where(delegate(string s)
						{
							string value = "";
							<Module>.FamANDAssem(ref value, new object[]
							{
								"軉ጽΧזӒ",
								"ৗᴃ",
								2679,
								203,
								"\u0005\u0010\u0005\0\u0001\0\u0003"
							});
							return s.EndsWith(value);
						}).ToList<string>();
						bool flag6 = list5.Count > 64435 - 64435;
						if (flag6)
						{
							List<string> list6 = list5;
							Action<string> action3;
							if ((action3 = <>9__6) == null)
							{
								action3 = (<>9__6 = delegate(string el)
								{
									CookieList.Add(el);
								});
							}
							list6.ForEach(action3);
						}
						num3 = k;
						num4 = 1;
					}
				}
				CookieList = ToolsWindow.removeDup(CookieList);
				base.Dispatcher.Invoke(new MethodInvoker(checked(delegate()
				{
					this.filesCounter = CookieList.Count;
					this.remainsCounter = CookieList.Count;
					this.allCookiesFiles.Text = this.filesCounter.ToString();
					this.remainsCookiesFiles.Text = this.remainsCounter.ToString();
					this.logs_button.IsEnabled = (Marshal.SizeOf(typeof(TaskAsyncEnumerableExtensions)) != 0);
					this.start_button.IsEnabled = (ToolsWindow.<>c__DisplayClass38_0.get_Epsilon != 0);
					System.Windows.Controls.TextBox textBox = this.results_log;
					System.Windows.Controls.TextBox textBox2 = textBox;
					string[] array4 = new string[(int)5L];
					array4[unchecked(481247 - 481247)] = textBox.Text;
					int num5 = (int)1L;
					DateTime now = DateTime.Now;
					string format = "尰尣尣屑将将屑尘尘尶";
					<Module>.FamANDAssem(ref format, new object[]
					{
						5303,
						'䞴'
					});
					array4[num5] = now.ToString(format);
					int num6 = (int)2L;
					string text4 = "\udde7\udd81\udda8\uddb2\udda9\udda3\udde7";
					<Module>.FamANDAssem(ref text4, new object[]
					{
						false,
						4605,
						'∪',
						43424
					});
					array4[num6] = text4;
					array4["̶͌ͯ".Length] = this.filesCounter.ToString();
					char c = '\u0004';
					int num7 = unchecked((int)c);
					string text5 = "ʹ̵̧̗̦̱̰̠̗̦̰̽ʹ̸̧̱̒̽ͺ͙͞";
					<Module>.FamANDAssem(ref text5, new object[]
					{
						false,
						571,
						281
					});
					array4[num7] = text5;
					textBox2.Text = string.Concat(array4);
					this.folderCheck.Text = this.dircheck;
					this.folderCheck.ToolTip = this.dircheck;
					this.folderIcon.Visibility = (Visibility)(205292 - 205292);
					System.Windows.Controls.ProgressBar progressBar = this.progressBar1;
					char c2 = '\0';
					progressBar.IsIndeterminate = ((int)c2 != 0);
				})), Array.Empty<object>());
			}
			catch
			{
			}
			return CookieList;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00018910 File Offset: 0x00016B10
		private void FindVaultFiles5(string path)
		{
			int[] array = new int[]
			{
				4
			};
			try
			{
				base.Dispatcher.Invoke(new MethodInvoker(delegate()
				{
					System.Windows.Controls.TextBox textBox = this.results_log;
					string text11 = textBox.Text;
					DateTime now = DateTime.Now;
					string format = "㣊㣙㣙㢫㣼㣼㢫㣢㣢㣌";
					<Module>.FamANDAssem(ref format, new object[]
					{
						3623,
						10595,
						false,
						'ć'
					});
					string str2 = now.ToString(format);
					string str3 = "踾蹍蹻蹿蹬蹽蹶蹻蹬踾蹍蹪蹻蹿蹳踾蹒蹱蹹蹭踾蹷蹭踾蹬蹫蹰踲踾蹩蹿蹷蹪蹷蹰蹹踰踰踰踓踔";
					<Module>.FamANDAssem(ref str3, new object[]
					{
						9304,
						281,
						false,
						"ўƍl;R\f",
						25021
					});
					textBox.Text = text11 + str2 + str3;
					this.folderCheck.Text = this.dircheck;
					this.folderCheck.ToolTip = this.dircheck;
					this.folderIcon.Visibility = (Visibility)(-511385 + 511385);
				}), Array.Empty<object>());
				string searchPattern = "⊖⋯⋈⋙⋝⋑⊖";
				<Module>.FamANDAssem(ref searchPattern, new object[]
				{
					'⇗',
					'å'
				});
				string[] directories = Alphaleonis.Win32.Filesystem.Directory.GetDirectories(path, searchPattern, (SearchOption)"͙".Length);
				this.filesCounter = directories.Length;
				bool flag = directories.Length > Convert.ToInt32("0", 16);
				if (flag)
				{
					string[] array2 = directories;
					for (int i = 8 >> 6; i < array2.Length; i += Convert.ToInt32("1", 8))
					{
						string text = array2[i];
						string directoryName = Alphaleonis.Win32.Filesystem.Path.GetDirectoryName(text);
						string fileName = Alphaleonis.Win32.Filesystem.Path.GetFileName(text);
						string text2 = MainWindow.Pars(text, path, fileName, checked((int)0L));
						string text3 = path + text2;
						string strSource = text2;
						string text4 = "";
						<Module>.FamANDAssem(ref text4, new object[]
						{
							false,
							39032,
							24467
						});
						string strStart = text4;
						string strEnd = "㈏";
						<Module>.FamANDAssem(ref strEnd, new object[]
						{
							9033,
							17,
							false,
							'ڞ',
							1823,
							'ļ'
						});
						string text5 = MainWindow.Pars(strSource, strStart, strEnd, -840445 - -840445);
						string text6 = text3;
						string oldValue = text2;
						string str = "뿄";
						<Module>.FamANDAssem(ref str, new object[]
						{
							12751,
							false,
							36297
						});
						string fromDir = text6.Replace(oldValue, str + text5);
						string[] array3 = new string[938637 + -938628];
						array3[checked(-834776 + 834776)] = this.PathToFolderS;
						int num = -677765 - -677766;
						string text7 = "퟼";
						<Module>.FamANDAssem(ref text7, new object[]
						{
							30539,
							'᳷',
							'䍞'
						});
						array3[num] = text7;
						array3[453507 + -453505] = this.datetimeS;
						int num2 = "͓͓̈́".Length;
						string text8 = "侙俢";
						<Module>.FamANDAssem(ref text8, new object[]
						{
							9555,
							4113,
							5408,
							1333
						});
						array3[num2] = text8;
						array3[array[0]] = this.timeS;
						int num3;
						if (-30084 != -30084)
						{
							num3 = 279507;
						}
						else
						{
							num3 = 5;
						}
						int num4 = num3;
						string text9 = "婭娐";
						<Module>.FamANDAssem(ref text9, new object[]
						{
							180,
							'ĉ',
							'ᡒ',
							15403,
							1014
						});
						array3[num4] = text9;
						array3[-357542 + 357548] = this.dircheck;
						int num5 = Convert.ToInt32("111", 2);
						string text10 = "⟐";
						<Module>.FamANDAssem(ref text10, new object[]
						{
							386,
							1551,
							"ࡰ®\v\0\a",
							false,
							339,
							'ᕸ'
						});
						array3[num5] = text10;
						array3[~-9] = text5;
						this.DirectoryCopy(fromDir, string.Concat(array3));
					}
				}
				base.Dispatcher.Invoke(new MethodInvoker(checked(delegate()
				{
					int[] array4 = new int[]
					{
						2
					};
					System.Windows.Controls.TextBox textBox = this.results_log;
					System.Windows.Controls.TextBox textBox2 = textBox;
					string[] array5 = new string[25 % 10];
					array5[ToolsWindow.Utf8SequenceLength] = textBox.Text;
					int num6 = Convert.ToInt32("1", 8);
					DateTime now = DateTime.Now;
					string format = "駕駆駆馴駣駣馴駽駽駓";
					<Module>.FamANDAssem(ref format, new object[]
					{
						22699,
						16611
					});
					array5[num6] = now.ToString(format);
					int num7 = 557995 >> 18;
					string text11 = "ㅉㄯㄆㄜㄇㄍㅉ";
					<Module>.FamANDAssem(ref text11, new object[]
					{
						91,
						1073,
						'⪅',
						600
					});
					array5[num7] = text11;
					array5[<Module>.Cgt[4]] = this.filesCounter.ToString();
					char c = '\u0004';
					int num8 = (int)c;
					string text12 = "䓉䒺䒝䒌䒈䒄䓉䒥䒆䒎䒚䓇䓤䓣";
					<Module>.FamANDAssem(ref text12, new object[]
					{
						6948,
						10693,
						false
					});
					array5[num8] = text12;
					textBox2.Text = string.Concat(array5);
					this.progressBar1.IsIndeterminate = (unchecked((int)0L) != 0);
					int num9;
					if (-98281 < 472696)
					{
						num9 = 7;
					}
					else
					{
						num9 = 519174;
					}
					string[] array6 = new string[num9];
					array6[0 * -43068] = this.PathToFolderS;
					int num10 = unchecked(1 * 1);
					string text13 = "橚";
					<Module>.FamANDAssem(ref text13, new object[]
					{
						21341,
						5801
					});
					array6[num10] = text13;
					array6[0 | 2] = this.datetimeS;
					int num11 = Convert.ToInt32("3", 8);
					string text14 = "䛟䚤";
					<Module>.FamANDAssem(ref text14, new object[]
					{
						"຾ॆΖօي",
						'ͣ',
						'ᚗ',
						"̨\u0014ſá"
					});
					array6[num11] = text14;
					array6[-778597 - -778601] = this.timeS;
					char c2 = '\u0005';
					int num12 = (int)c2;
					string text15 = "ꇑꆬ";
					<Module>.FamANDAssem(ref text15, new object[]
					{
						32336,
						9020,
						false
					});
					array6[num12] = text15;
					int num13 = 6;
					array6[num13] = this.dircheck;
					bool flag2 = Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array6));
					if (flag2)
					{
						string[] array7 = new string[unchecked(13896 + -13889)];
						array7[0 | 0] = this.PathToFolderS;
						int num14 = 281839 + -281838;
						string text16 = "럊";
						<Module>.FamANDAssem(ref text16, new object[]
						{
							false,
							"຿RνŮǾ",
							36740,
							4568
						});
						array7[num14] = text16;
						array7[array4[0]] = this.datetimeS;
						int num15 = ~-4;
						string text17 = "漯潔";
						<Module>.FamANDAssem(ref text17, new object[]
						{
							401,
							"֩Ъ\u0004\"",
							25477
						});
						array7[num15] = text17;
						array7[2 << 1] = this.timeS;
						int num16 = (int)5L;
						string text18 = "㕒㔯";
						<Module>.FamANDAssem(ref text18, new object[]
						{
							965,
							12618
						});
						array7[num16] = text18;
						array7[(-94517 <= -419905) ? 175838 : 6] = this.dircheck;
						Process.Start(string.Concat(array7));
					}
				})), Array.Empty<object>());
			}
			catch
			{
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00018D24 File Offset: 0x00016F24
		private void FindVaultFiles6(string path)
		{
			char[] array = new char[]
			{
				'\u0001'
			};
			int[] array2 = new int[]
			{
				9
			};
			try
			{
				base.Dispatcher.Invoke(new MethodInvoker(delegate()
				{
					System.Windows.Controls.TextBox textBox = this.results_log;
					string text11 = textBox.Text;
					DateTime now = DateTime.Now;
					string format = "뭊뭙뭙묫뭼뭼묫뭢뭢뭌";
					<Module>.FamANDAssem(ref format, new object[]
					{
						37393,
						970,
						'┶'
					});
					string str2 = now.ToString(format);
					string str3 = "埋垸垎垊垙垈垃垎垙埋垿垎垇垎垌垙垊垆埋垧垄垌垘埋垂垘埋垙垞垅埇埋垜垊垂垟垂垅垌埅埅埅埦埡";
					<Module>.FamANDAssem(ref str3, new object[]
					{
						2009,
						false,
						2787,
						"ᙖଃ˜Ȓ\u000eȄ",
						"ᇐϬܚ"
					});
					textBox.Text = text11 + str2 + str3;
					this.folderCheck.Text = this.dircheck;
					this.folderCheck.ToolTip = this.dircheck;
					this.folderIcon.Visibility = (Visibility)(0 * -771058);
				}), Array.Empty<object>());
				string searchPattern = "";
				<Module>.FamANDAssem(ref searchPattern, new object[]
				{
					"ӎ௜ʿї\n\u0010\u000e",
					"˳ᘭႠƊ",
					'鶲',
					'ǻ'
				});
				string[] directories = Alphaleonis.Win32.Filesystem.Directory.GetDirectories(path, searchPattern, (SearchOption)array[0]);
				this.filesCounter = directories.Length;
				bool flag = directories.Length > (-682087 ^ -682087);
				if (flag)
				{
					string[] array3 = directories;
					for (int i = -132991 - -132991; i < array3.Length; i += (1 & 1))
					{
						string text = array3[i];
						string directoryName = Alphaleonis.Win32.Filesystem.Path.GetDirectoryName(text);
						string fileName = Alphaleonis.Win32.Filesystem.Path.GetFileName(text);
						string text2 = MainWindow.Pars(text, path, fileName, ~-1);
						string text3 = path + text2;
						string strSource = text2;
						string text4 = "ﳪ";
						<Module>.FamANDAssem(ref text4, new object[]
						{
							"簦ᜈ",
							2542,
							"}ɤ7",
							22313,
							1369
						});
						string strStart = text4;
						string strEnd = "ҧ";
						<Module>.FamANDAssem(ref strEnd, new object[]
						{
							'ͮ',
							2,
							155,
							240
						});
						string text5 = MainWindow.Pars(strSource, strStart, strEnd, 0 % -418950);
						string text6 = text3;
						string oldValue = text2;
						string str = "貼";
						<Module>.FamANDAssem(ref str, new object[]
						{
							10224,
							17226,
							5148,
							3466
						});
						string fromDir = text6.Replace(oldValue, str + text5);
						string[] array4 = new string[array2[0]];
						checked
						{
							array4[-22425 - -22425] = this.PathToFolderS;
							char c = '\u0001';
							int num = (int)c;
							string text7 = "솞";
							<Module>.FamANDAssem(ref text7, new object[]
							{
								15670,
								"枭᳟",
								false
							});
							array4[num] = text7;
							array4[872836 + -872834] = this.datetimeS;
							int num2 = 1 | 2;
							string text8 = "놮뇕";
							<Module>.FamANDAssem(ref text8, new object[]
							{
								16335,
								18516,
								'⥫'
							});
							array4[num2] = text8;
							array4["̡͍̽́".Length] = this.timeS;
							int num3;
							switch (157426 + -157425)
							{
							case 0:
								num3 = 851494;
								break;
							case 1:
								num3 = 5;
								break;
							case 2:
								num3 = -818296;
								break;
							}
							int num4 = num3;
							string text9 = "Ⲻⳇ";
							<Module>.FamANDAssem(ref text9, new object[]
							{
								2324,
								2692,
								1214,
								'ᒑ',
								false
							});
							array4[num4] = text9;
							array4[Convert.ToInt32("110", 2)] = this.dircheck;
						}
						int num5 = 7 * 1;
						string text10 = "믅";
						<Module>.FamANDAssem(ref text10, new object[]
						{
							'⡊',
							'⛄',
							false,
							27787
						});
						array4[num5] = text10;
						array4[324725 ^ 324733] = text5;
						this.DirectoryCopy(fromDir, string.Concat(array4));
					}
				}
				base.Dispatcher.Invoke(new MethodInvoker(delegate()
				{
					char[] array5 = new char[]
					{
						'\u0004',
						'\u0006'
					};
					System.Windows.Controls.TextBox textBox = this.results_log;
					System.Windows.Controls.TextBox textBox2 = textBox;
					string[] array6 = new string[1 | 4];
					array6[ToolsWindow.Utf8SequenceLength] = textBox.Text;
					int num6 = "ͨ".Length;
					DateTime now = DateTime.Now;
					string format = "윱윢윢읐윇윇읐윙윙윷";
					<Module>.FamANDAssem(ref format, new object[]
					{
						15250,
						"寮գ௲๾\u0083౬",
						"¶ř\n\u0018÷"
					});
					array6[num6] = now.ToString(format);
					char c2 = '\u0002';
					int num7 = checked((int)c2);
					string text11 = "ᤕᥳᥚ᥀ᥛᥑᤕ";
					<Module>.FamANDAssem(ref text11, new object[]
					{
						"ūĉߗǎ\0\a",
						false,
						3349
					});
					array6[num7] = text11;
					int num8;
					if (-99518 < -891057)
					{
						num8 = -9225;
					}
					else
					{
						num8 = 3;
					}
					array6[num8] = this.filesCounter.ToString();
					int num9 = (int)4L;
					string text12 = "뛶뚂뚳뚺뚳뚱뚤뚷뚻뛶뚚뚹뚱뚥뛸뛛뛜";
					<Module>.FamANDAssem(ref text12, new object[]
					{
						18280,
						"ືັ",
						10040,
						10958,
						false
					});
					array6[num9] = text12;
					textBox2.Text = string.Concat(array6);
					this.progressBar1.IsIndeterminate = (0 / 182640754 != 0);
					int num10;
					if (-16446 >= 437547)
					{
						num10 = 770921;
					}
					else
					{
						num10 = 7;
					}
					string[] array7 = new string[num10];
					array7[0 % -273524] = this.PathToFolderS;
					int num11 = 5 % 2;
					string text13 = "壨";
					<Module>.FamANDAssem(ref text13, new object[]
					{
						"ݒ㇯ۊȮ\u0080",
						'ᗻ'
					});
					array7[num11] = text13;
					array7["ͧ͞".Length] = this.datetimeS;
					int num12 = 3 | 0;
					string text14 = "탹킂";
					<Module>.FamANDAssem(ref text14, new object[]
					{
						11621,
						11331,
						false,
						30513
					});
					array7[num12] = text14;
					array7[Convert.ToInt32("4", 16)] = this.timeS;
					int num13 = 5 | 5;
					string text15 = "嘤噙";
					<Module>.FamANDAssem(ref text15, new object[]
					{
						'Ǩ',
						15428,
						5664,
						557
					});
					array7[num13] = text15;
					array7[636613 ^ 636611] = this.dircheck;
					bool flag2 = Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array7));
					if (flag2)
					{
						char c3 = '\a';
						string[] array8 = new string[(int)c3];
						array8[string.Empty.Length] = this.PathToFolderS;
						int num14 = 1 * 1;
						string text16 = "潖";
						<Module>.FamANDAssem(ref text16, new object[]
						{
							false,
							1838,
							289,
							'暰',
							"\t\0\0\0\0\u0002"
						});
						array8[num14] = text16;
						int num15;
						if (-72118 <= 172646)
						{
							num15 = 2;
						}
						else
						{
							num15 = -429408;
						}
						array8[num15] = this.datetimeS;
						int num16 = 3;
						int num17 = num16;
						string text17 = "찵챎";
						<Module>.FamANDAssem(ref text17, new object[]
						{
							false,
							6752,
							45493
						});
						array8[num17] = text17;
						array8[(int)array5[0]] = this.timeS;
						int num18 = 5 & 7;
						string text18 = "ꤒꥯ";
						<Module>.FamANDAssem(ref text18, new object[]
						{
							false,
							13960,
							8492,
							"Ə倌"
						});
						array8[num18] = text18;
						array8[(int)array5[1]] = this.dircheck;
						Process.Start(string.Concat(array8));
					}
				}), Array.Empty<object>());
			}
			catch
			{
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00019130 File Offset: 0x00017330
		private void FindVaultFiles7(string path)
		{
			try
			{
				base.Dispatcher.Invoke(new MethodInvoker(delegate()
				{
					System.Windows.Controls.TextBox textBox = this.results_log;
					string text11 = textBox.Text;
					DateTime now = DateTime.Now;
					string format = "豌豟豟谭豺豺谭豤豤豊";
					<Module>.FamANDAssem(ref format, new object[]
					{
						"݌ϯ݇Ġ",
						"昕੼ͺƟĲƙ"
					});
					string str2 = now.ToString(format);
					string str3 = "닒늡늗늓늀늑늚늗늀닒늴늦늢닒늾늝늕늁닒늛늁닒늀늇늜닞닒늅늓늛늆늛늜늕닜닜닜닿닸";
					<Module>.FamANDAssem(ref str3, new object[]
					{
						8106,
						"䅲⣪ཌྷ͝௝੥"
					});
					textBox.Text = text11 + str2 + str3;
					this.folderCheck.Text = this.dircheck;
					this.folderCheck.ToolTip = this.dircheck;
					this.folderIcon.Visibility = (Visibility.Visible | Visibility.Visible);
				}), Array.Empty<object>());
				string searchPattern = "蓤蒈蒚蒞蓤";
				<Module>.FamANDAssem(ref searchPattern, new object[]
				{
					30770,
					2351,
					'\u0095',
					false,
					728
				});
				string[] directories = Alphaleonis.Win32.Filesystem.Directory.GetDirectories(path, searchPattern, ~(SearchOption)(-2));
				this.filesCounter = directories.Length;
				bool flag = directories.Length > checked((int)0L);
				if (flag)
				{
					string[] array = directories;
					int num6;
					char c;
					for (int i = 0 % 829789; i < array.Length; i = num6 + (int)c)
					{
						string text = array[i];
						string directoryName = Alphaleonis.Win32.Filesystem.Path.GetDirectoryName(text);
						string fileName = Alphaleonis.Win32.Filesystem.Path.GetFileName(text);
						string text2 = MainWindow.Pars(text, path, fileName, (int)0L);
						string text3 = path + text2;
						string strSource = text2;
						string text4 = "䷉";
						<Module>.FamANDAssem(ref text4, new object[]
						{
							11861,
							'ὀ',
							false
						});
						string strStart = text4;
						string strEnd = "㩛";
						<Module>.FamANDAssem(ref strEnd, new object[]
						{
							"ݮm²",
							"ѺϷJ\a\u0003E",
							"ựƂՉ",
							false,
							'ʴ'
						});
						string text5 = MainWindow.Pars(strSource, strStart, strEnd, Convert.ToInt32("0", 8));
						string text6 = text3;
						string oldValue = text2;
						string str = "憪";
						<Module>.FamANDAssem(ref str, new object[]
						{
							15522,
							9556,
							false
						});
						string fromDir = text6.Replace(oldValue, str + text5);
						string[] array2;
						checked
						{
							array2 = new string[953308 + -953299];
							array2[Convert.ToInt32("0", 8)] = this.PathToFolderS;
							int num = 5 % 2;
							string text7 = "ꋏ";
							<Module>.FamANDAssem(ref text7, new object[]
							{
								"磛ᄷèӁ2F\u0016",
								"Șے࠵b",
								false,
								'É'
							});
							array2[num] = text7;
							array2[-690437 + 690439] = this.datetimeS;
							int num2 = -896399 ^ -896398;
							string text8 = "骕髮";
							<Module>.FamANDAssem(ref text8, new object[]
							{
								24667,
								4695,
								1041,
								8937,
								265
							});
							array2[num2] = text8;
							array2[unchecked((int)4L)] = this.timeS;
							int num3 = -5 * -1;
							string text9 = "ꝰ꜍";
							<Module>.FamANDAssem(ref text9, new object[]
							{
								'僑',
								'ж',
								false,
								"ݩڊU\u0095÷ƀ",
								"ᝦ⥬"
							});
							array2[num3] = text9;
							int num4;
							switch (660435988 / 660435988)
							{
							case 0:
								num4 = -178971;
								break;
							case 1:
								num4 = 6;
								break;
							case 2:
								num4 = -116928;
								break;
							}
							array2[num4] = this.dircheck;
						}
						int num5 = (int)7L;
						string text10 = "々";
						<Module>.FamANDAssem(ref text10, new object[]
						{
							9159,
							993,
							768,
							1457
						});
						array2[num5] = text10;
						array2[<Module>.ReciprocalStep[5]] = text5;
						this.DirectoryCopy(fromDir, string.Concat(array2));
						num6 = i;
						c = '\u0001';
					}
				}
				base.Dispatcher.Invoke(new MethodInvoker(delegate()
				{
					char[] array3 = new char[]
					{
						'\u0003'
					};
					int[] array4 = new int[]
					{
						1
					};
					System.Windows.Controls.TextBox textBox = this.results_log;
					System.Windows.Controls.TextBox textBox2 = textBox;
					string[] array5 = new string[5 * 1];
					array5[<Module>.Tag[1]] = textBox.Text;
					int num7 = Convert.ToInt32("1", 2);
					DateTime now = DateTime.Now;
					string format = "壗壄壄墶壡壡墶壿壿壑";
					<Module>.FamANDAssem(ref format, new object[]
					{
						12211,
						1475,
						1455,
						"Qz6\u000f",
						"ᔗѾ\u0086ȼ"
					});
					array5[num7] = now.ToString(format);
					int num8 = -751274 + 751276;
					string text11 = "ୖରଙଃଘ଒ୖ";
					<Module>.FamANDAssem(ref text11, new object[]
					{
						'ـ',
						false,
						1334
					});
					array5[num8] = text11;
					char c2 = '\u0003';
					string[] array6;
					char c4;
					checked
					{
						array5[(int)c2] = this.filesCounter.ToString();
						int num9 = 2124747972 / 531186993;
						string text12 = "큇퀡퀳퀷큇퀫퀈퀀퀔큉큪큭";
						<Module>.FamANDAssem(ref text12, new object[]
						{
							"╨ǳӅ܉Ƶʳ",
							2508,
							'溜',
							'օ',
							'᫩'
						});
						array5[num9] = text12;
						textBox2.Text = string.Concat(array5);
						System.Windows.Controls.ProgressBar progressBar = this.progressBar1;
						char c3 = '\0';
						progressBar.IsIndeterminate = ((int)c3 != 0);
						array6 = new string[2012767988 / 287538284];
						array6[unchecked(510669 - 510669)] = this.PathToFolderS;
						int num10 = array4[0];
						string text13 = "疏";
						<Module>.FamANDAssem(ref text13, new object[]
						{
							'ਧ',
							'殬',
							false
						});
						array6[num10] = text13;
						array6[-940355 + 940357] = this.datetimeS;
						int num11 = ~-4;
						string text14 = "ἣ὘";
						<Module>.FamANDAssem(ref text14, new object[]
						{
							false,
							'Ű',
							356,
							131,
							6159,
							925
						});
						array6[num11] = text14;
						int num12 = 4;
						array6[num12] = this.timeS;
						int num13 = "̺̻͗̀́".Length;
						string text15 = "뚸뛅";
						<Module>.FamANDAssem(ref text15, new object[]
						{
							"Ηø3",
							45603
						});
						array6[num13] = text15;
						c4 = '\u0006';
					}
					array6[(int)c4] = this.dircheck;
					bool flag2 = Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array6));
					if (flag2)
					{
						string[] array7 = new string[7 * 1];
						array7[0 / 1892500140] = this.PathToFolderS;
						int num14 = (26739 == 26739) ? 1 : 579631;
						string text16 = "䗾";
						<Module>.FamANDAssem(ref text16, new object[]
						{
							"਋➦શ",
							2363,
							false
						});
						array7[num14] = text16;
						int num15 = 2;
						array7[num15] = this.datetimeS;
						int num16 = (int)array3[0];
						string text17 = "巆嶽";
						<Module>.FamANDAssem(ref text17, new object[]
						{
							13013,
							"↳Ԅŝ˽",
							false
						});
						array7[num16] = text17;
						array7[checked(90001 + -89997)] = this.timeS;
						int num17 = 630985 - 630980;
						string text18 = "Ⳑⲭ";
						<Module>.FamANDAssem(ref text18, new object[]
						{
							'⅁',
							885,
							false,
							"Ů(\\\u0018'",
							779,
							667
						});
						array7[num17] = text18;
						array7[ToolsWindow.IsSet] = this.dircheck;
						Process.Start(string.Concat(array7));
					}
				}), Array.Empty<object>());
			}
			catch
			{
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00019540 File Offset: 0x00017740
		private void FindVaultFiles8(string path)
		{
			try
			{
				base.Dispatcher.Invoke(new MethodInvoker(delegate()
				{
					System.Windows.Controls.TextBox textBox = this.results_log;
					string text12 = textBox.Text;
					DateTime now = DateTime.Now;
					string format = "ޙފފ߸ޯޯ߸ޱޱޟ";
					<Module>.FamANDAssem(ref format, new object[]
					{
						"\u001e\u001d)\u001c\r\u0017\b",
						"(\t\u0002\u0001\u0002",
						258,
						377,
						1125
					});
					string str2 = now.ToString(format);
					string str3 = "䋺䊉䊿䊻䊨䊹䊲䊿䊨䋺䊍䊻䊶䊶䊿䊮䊩䋺䊖䊵䊽䊩䋺䊳䊩䋺䊨䊯䊴䋶䋺䊭䊻䊳䊮䊳䊴䊽䋴䋴䋴䋗䋐";
					<Module>.FamANDAssem(ref str3, new object[]
					{
						773,
						false,
						16241,
						100
					});
					textBox.Text = text12 + str2 + str3;
					this.folderCheck.Text = this.dircheck;
					this.folderCheck.ToolTip = this.dircheck;
					this.folderIcon.Visibility = (Visibility)(0 << 21);
				}), Array.Empty<object>());
				string searchPattern = "晖昫昝昐昐昙昈晖";
				<Module>.FamANDAssem(ref searchPattern, new object[]
				{
					'࠙',
					4383,
					"㟦ᕞ"
				});
				string[] directories = Alphaleonis.Win32.Filesystem.Directory.GetDirectories(path, searchPattern, (SearchOption)5 % (SearchOption)2);
				string text = "썢쌋쌺쌱쌸쌼쌧썢";
				<Module>.FamANDAssem(ref text, new object[]
				{
					30657,
					19335
				});
				string searchPattern2 = text;
				int searchOption = 1;
				string[] directories2 = Alphaleonis.Win32.Filesystem.Directory.GetDirectories(path, searchPattern2, (SearchOption)searchOption);
				this.filesCounter = directories.Length + directories2.Length;
				bool flag = this.filesCounter > 0 / 22381068;
				if (flag)
				{
					foreach (string text2 in directories.Concat(directories2))
					{
						string directoryName = Alphaleonis.Win32.Filesystem.Path.GetDirectoryName(text2);
						string fileName = Alphaleonis.Win32.Filesystem.Path.GetFileName(text2);
						string text3 = MainWindow.Pars(text2, path, fileName, Convert.ToInt32("0", 2));
						string text4 = path + text3;
						string strSource = text3;
						string text5 = "뙟";
						<Module>.FamANDAssem(ref text5, new object[]
						{
							'⪝',
							'᷽',
							28009
						});
						string strStart = text5;
						string strEnd = "醿";
						<Module>.FamANDAssem(ref strEnd, new object[]
						{
							false,
							1490,
							'ຫ',
							"Ữ䁷ۜᎍ̰A'"
						});
						string text6 = MainWindow.Pars(strSource, strStart, strEnd, 0 / 210531012);
						string text7 = text4;
						string oldValue = text3;
						string str = "ﰾ";
						<Module>.FamANDAssem(ref str, new object[]
						{
							19018,
							16320,
							896,
							2679,
							"偹ĥႠƈ\u0081\u001a"
						});
						string fromDir = text7.Replace(oldValue, str + text6);
						string[] array = new string["̸̡̛͎̮ͮ̄ͭ͏".Length];
						array[(-61681 != -61681) ? 884397 : 0] = this.PathToFolderS;
						int num = ~-2;
						string text8 = "瑳";
						<Module>.FamANDAssem(ref text8, new object[]
						{
							11793,
							17950,
							false
						});
						array[num] = text8;
						array[(int)2L] = this.datetimeS;
						int num2 = (int)3L;
						string text9 = "릦망";
						<Module>.FamANDAssem(ref text9, new object[]
						{
							false,
							27292,
							"ƶĮ",
							19462
						});
						array[num2] = text9;
						array[checked(719466 - 719462)] = this.timeS;
						int num3;
						switch (0 / -246)
						{
						case 0:
							num3 = 5;
							break;
						}
						int num4 = num3;
						string text10 = "ⳟⲢ";
						<Module>.FamANDAssem(ref text10, new object[]
						{
							3663,
							18,
							524,
							328,
							"ᆃॊ"
						});
						array[num4] = text10;
						array[-6 * -1] = this.dircheck;
						int num5 = 7 | 4;
						string text11 = "왗";
						<Module>.FamANDAssem(ref text11, new object[]
						{
							"ܚ䞫ᖸ⌠Ҿ",
							5634,
							false,
							9134
						});
						array[num5] = text11;
						array[4 * 2] = text6;
						this.DirectoryCopy(fromDir, string.Concat(array));
					}
				}
				base.Dispatcher.Invoke(new MethodInvoker(delegate()
				{
					int[] array2 = new int[]
					{
						5,
						7
					};
					System.Windows.Controls.TextBox textBox = this.results_log;
					System.Windows.Controls.TextBox textBox2 = textBox;
					string[] array3 = new string[5 & 7];
					array3[-812139 ^ -812139] = textBox.Text;
					int num6 = 5 % 2;
					DateTime now = DateTime.Now;
					string format = "㮛㮈㮈㯺㮭㮭㯺㮳㮳㮝";
					<Module>.FamANDAssem(ref format, new object[]
					{
						'\b',
						7600,
						30,
						"ݺԜ̼\b\r\v\u0006",
						3570
					});
					array3[num6] = now.ToString(format);
					int num7 = 185550 >> 16;
					string text12 = "헢햄햭햷햬햦헢";
					<Module>.FamANDAssem(ref text12, new object[]
					{
						"耬᢯࣯l,%",
						"\u008eç!{;",
						false,
						"Ԙ\u0010j\u009aĒ",
						10673
					});
					array3[num7] = text12;
					array3[<Module>.Cgt[4]] = this.filesCounter.ToString();
					string[] array4;
					checked
					{
						int num8 = (int)4L;
						string text13 = "䫚䪭䪛䪖䪖䪟䪎䪉䫚䪶䪕䪝䪉䫔䫷䫰";
						<Module>.FamANDAssem(ref text13, new object[]
						{
							2948,
							'೐',
							10377,
							'՜',
							"ʶȋ"
						});
						array3[num8] = text13;
						textBox2.Text = string.Concat(array3);
						this.progressBar1.IsIndeterminate = (true & false);
						array4 = new string[array2[1]];
						array4[7250779 >> 24] = this.PathToFolderS;
						int num9 = (int)1L;
						string text14 = "젖";
						<Module>.FamANDAssem(ref text14, new object[]
						{
							"Ẓ7畸Պᅭšৡ",
							4590,
							"\u0001\u0003",
							26,
							4
						});
						array4[num9] = text14;
						array4[2 * 1] = this.datetimeS;
						int num10 = <Module>.Cgt[4];
						string text15 = "";
						<Module>.FamANDAssem(ref text15, new object[]
						{
							5022,
							6612,
							3148,
							"⑇ήốṂȜনҖ",
							"⁒ၠE̫Û"
						});
						array4[num10] = text15;
						array4[2589827 >> 19] = this.timeS;
					}
					int num11 = 5 * 1;
					string text16 = "夐奭";
					<Module>.FamANDAssem(ref text16, new object[]
					{
						1335,
						14388,
						'ᕜ',
						"΁Ŋƻ"
					});
					array4[num11] = text16;
					array4["̻̯ͯ̌͂̀".Length] = this.dircheck;
					bool flag2 = Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array4));
					if (flag2)
					{
						string[] array5 = new string[7 & 7];
						int num12;
						if (-33882 == -88072)
						{
							num12 = -254482;
						}
						else
						{
							num12 = 0;
						}
						array5[num12] = this.PathToFolderS;
						int num13;
						switch (-846696)
						{
						case -846696:
							num13 = 1;
							break;
						}
						int num14 = num13;
						string text17 = "ᡁ";
						<Module>.FamANDAssem(ref text17, new object[]
						{
							'ߣ',
							"ഔ5ȄQ\u0003\a",
							"\n\u0002\u001e\0\0\0\u0002",
							65,
							"\u0003\u001e\0\u0001\u0003"
						});
						array5[num14] = text17;
						array5["͇̏".Length] = this.datetimeS;
						int num15 = 426398 - 426395;
						string text18 = "";
						<Module>.FamANDAssem(ref text18, new object[]
						{
							50519,
							'০',
							6324
						});
						array5[num15] = text18;
						array5[(7874 < 317125) ? 4 : 182227] = this.timeS;
						int num16 = array2[0];
						string text19 = "땹딄";
						<Module>.FamANDAssem(ref text19, new object[]
						{
							1083,
							5836,
							34741,
							1067,
							3645
						});
						array5[num16] = text19;
						array5[428400 ^ 428406] = this.dircheck;
						Process.Start(string.Concat(array5));
					}
				}), Array.Empty<object>());
			}
			catch
			{
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00019970 File Offset: 0x00017B70
		private void logs_button_Click(object sender, RoutedEventArgs e)
		{
			VistaFolderBrowserDialog vistaFolderBrowserDialog = new VistaFolderBrowserDialog();
			VistaFolderBrowserDialog vistaFolderBrowserDialog2 = vistaFolderBrowserDialog;
			string description = "ẢẴẽẴẲấốạẰấẹốẦẸấẹốẽẾẶẢ";
			<Module>.FamANDAssem(ref description, new object[]
			{
				9,
				5328,
				"\0\u0002",
				false,
				2582
			});
			vistaFolderBrowserDialog2.Description = description;
			vistaFolderBrowserDialog.RootFolder = (Environment.SpecialFolder.Desktop & Environment.SpecialFolder.Desktop);
			bool? flag = vistaFolderBrowserDialog.ShowDialog();
			bool flag3;
			if (flag != null)
			{
				bool? flag2 = flag;
				bool zeroFreeGlobalAllocAnsi = ToolsWindow.ZeroFreeGlobalAllocAnsi != 0;
				flag3 = (flag2.GetValueOrDefault() == zeroFreeGlobalAllocAnsi & flag2 != null);
			}
			else
			{
				int num = 0;
				flag3 = (num != 0);
			}
			bool flag4 = flag3;
			if (flag4)
			{
				System.Windows.Controls.Button button = (System.Windows.Controls.Button)sender;
				this.results_log.Clear();
				System.Windows.Controls.TextBox textBox = this.results_log;
				string text = textBox.Text;
				DateTime now = DateTime.Now;
				string format = "헴헧헧햕헂헂햕헜헜헲";
				<Module>.FamANDAssem(ref format, new object[]
				{
					35432,
					14119,
					5152,
					false
				});
				string str = now.ToString(format);
				string str2 = "҄ӷӁӅӖӇӌӁӖ҄ӂӍӈӁӗ҄Ӎӗ҄Ӗӑӊ҈҄ӓӅӍӐӍӊӃҊҊҊҩҮ";
				<Module>.FamANDAssem(ref str2, new object[]
				{
					865,
					false,
					'Ń'
				});
				textBox.Text = text + str + str2;
				this.start_button.IsEnabled = (Convert.ToInt32("0", 2) != 0);
				this.logs_button.IsEnabled = (checked(-551404 + 551404) != 0);
				this.selpath = vistaFolderBrowserDialog.SelectedPath;
				this.dircheck = new Alphaleonis.Win32.Filesystem.DirectoryInfo(this.selpath).Name;
				this.progressBar1.IsIndeterminate = true * true;
				new Thread(delegate()
				{
					bool flag5 = ToolsWindow.cookies_searcher_c;
					if (flag5)
					{
						this.sourceList = this.FindVaultFiles(this.selpath);
					}
					bool flag6 = ToolsWindow.password_searcher_c;
					if (flag6)
					{
						this.sourceList = this.FindVaultFiles2(this.selpath);
					}
					bool flag7 = ToolsWindow.autofills_searcher_c;
					if (flag7)
					{
						this.sourceList = this.FindVaultFiles3(this.selpath);
					}
					bool flag8 = ToolsWindow.creditcards_searcher_c;
					if (flag8)
					{
						this.sourceList = this.FindVaultFiles4(this.selpath);
					}
				}).Start();
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00019B50 File Offset: 0x00017D50
		private void stop_button_Click(object sender, RoutedEventArgs e)
		{
			int[] array = new int[]
			{
				0
			};
			CancellationTokenSource cancellationTokenSource = this.cts;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
			}
			this.stop_button.IsEnabled = (0 << 11 != 0);
			this.start_button.IsEnabled = (false | false);
			this.logs_button.IsEnabled = (array[0] != 0);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00019BAC File Offset: 0x00017DAC
		private void start_button_Click(object sender, RoutedEventArgs e)
		{
			char[] array = new char[]
			{
				'\0'
			};
			int[] array2 = new int[]
			{
				1,
				0
			};
			bool flag = this.sourceList.Any<string>() == (false & false);
			if (flag)
			{
				string text = "ᥑ᥾᥻ᥲᥤᤷᥙ᥸ᥣᤷᥑ᥸ᥢ᥹ᥳ᤹";
				<Module>.FamANDAssem(ref text, new object[]
				{
					2248,
					false,
					1754,
					2421
				});
				string messageBoxText = text;
				string caption = "藁藶藶藫藶";
				<Module>.FamANDAssem(ref caption, new object[]
				{
					991,
					20196,
					"ჰṳʁ£\r\u0006'"
				});
				System.Windows.MessageBox.Show(messageBoxText, caption, (MessageBoxButton)<Module>.Tag[1], (MessageBoxImage)(1549 >> 5));
			}
			else
			{
				int count = this.sourceList.Count;
				char c = '\0';
				bool flag2 = count > checked((int)c);
				if (flag2)
				{
					bool? isChecked = this.check_CookiesSearcher.IsChecked;
					int num;
					if (-392 == -86401)
					{
						num = 83044;
					}
					else
					{
						num = 1;
					}
					bool flag3 = num != 0;
					bool flag4 = isChecked.GetValueOrDefault() == flag3 & isChecked != null;
					if (flag4)
					{
						ToolsWindow.cookies_searcher_c = (sizeof(sbyte) != 0);
					}
					else
					{
						int num2;
						if (-63703 != -87454)
						{
							num2 = 0;
						}
						else
						{
							num2 = -637586;
						}
						ToolsWindow.cookies_searcher_c = (num2 != 0);
					}
					isChecked = this.check_PasswordSearcher.IsChecked;
					flag3 = ((int)1L != 0);
					bool flag5 = isChecked.GetValueOrDefault() == flag3 & isChecked != null;
					if (flag5)
					{
						ToolsWindow.password_searcher_c = (checked(-420012 + 420013) != 0);
					}
					else
					{
						ToolsWindow.password_searcher_c = (string.Empty.Length != 0);
					}
					isChecked = this.check_AutoFillsSearcher.IsChecked;
					flag3 = (true | false);
					bool flag6 = isChecked.GetValueOrDefault() == flag3 & isChecked != null;
					if (flag6)
					{
						ToolsWindow.autofills_searcher_c = true * true;
					}
					else
					{
						ToolsWindow.autofills_searcher_c = (16932 > 983073);
					}
					isChecked = this.check_ccSearcher.IsChecked;
					char c2 = '\u0001';
					checked
					{
						flag3 = ((int)c2 != 0);
						bool flag7 = isChecked.GetValueOrDefault() == flag3 & isChecked != null;
						if (flag7)
						{
							ToolsWindow.creditcards_searcher_c = (~(-2 != 0) != 0);
						}
						else
						{
							ToolsWindow.creditcards_searcher_c = ((int)0L != 0);
						}
						bool flag8 = this.sourceList.Count < Convert.ToInt32(this.NumThreadsCount.Text);
						if (flag8)
						{
							System.Windows.Controls.TextBox numThreadsCount = this.NumThreadsCount;
							string text2 = "h";
							<Module>.FamANDAssem(ref text2, new object[]
							{
								false,
								false,
								12,
								' ',
								"\b\u0012\u0013"
							});
							numThreadsCount.Text = text2;
						}
						this.remainsCounter = this.sourceList.Count;
						this.filesCounter = this.sourceList.Count;
						this.cookiesCounter = (1 & 0);
						this.allCookiesFiles.Text = this.filesCounter.ToString();
						this.remainsCookiesFiles.Text = this.remainsCounter.ToString();
						this.foundCookies.Text = this.cookiesCounter.ToString();
						this.progressBar1.Maximum = (double)this.sourceList.Count;
						this.progressBar1.Value = 0.0;
						this.results_log.Clear();
						DateTime now = DateTime.Now;
						string format = "ႹႹჟႜႜჟႂႂ";
						<Module>.FamANDAssem(ref format, new object[]
						{
							1547,
							372,
							2418
						});
						this.time = now.ToString(format);
						now = DateTime.Now;
						string format2 = "ꉕꉪꉪꈠꉃꉃꈠꉷꉷꉷꉷꉓ";
						<Module>.FamANDAssem(ref format2, new object[]
						{
							82,
							31274,
							4065,
							6065
						});
						this.datetime = now.ToString(format2);
						char c3 = '\u0005';
						string[] array3 = new string[(int)c3];
						int num3;
						if (45865 != 45865)
						{
							num3 = 436514;
						}
						else
						{
							num3 = 0;
						}
						array3[num3] = this.datetime;
						int num4 = 1 * 1;
						string text3 = "❠✛";
						<Module>.FamANDAssem(ref text3, new object[]
						{
							false,
							'ሡ',
							740,
							2263,
							"ȾϧˣL\b\b"
						});
						array3[num4] = text3;
						array3[sizeof(ushort)] = this.time;
						int num5 = -84702 ^ -84703;
						string text4 = "攅數";
						<Module>.FamANDAssem(ref text4, new object[]
						{
							"᝺༊ɶ",
							false,
							"᜚࠰ލˁ",
							824,
							3982
						});
						array3[num5] = text4;
						array3[2043376044 / 510844011] = this.dircheck;
						this.resfold = string.Concat(array3);
						isChecked = this.check_CookiesSearcher.IsChecked;
					}
					flag3 = ((int)1L != 0);
					bool flag9 = isChecked.GetValueOrDefault() == flag3 & isChecked != null;
					if (flag9)
					{
						isChecked = this.SaveFullCookies.IsChecked;
						flag3 = (~(-2 != 0) != 0);
						bool flag10 = isChecked.GetValueOrDefault() == flag3 & isChecked != null;
						if (flag10)
						{
							ToolsWindow.sfc = (ToolsWindow.ZeroFreeGlobalAllocAnsi != 0);
						}
						isChecked = this.SaveFullCookies.IsChecked;
						flag3 = (string.Empty.Length != 0);
						bool flag11 = isChecked.GetValueOrDefault() == flag3 & isChecked != null;
						if (flag11)
						{
							ToolsWindow.sfc = (0 << 23 != 0);
						}
						string text5 = this.reqsearch.Text;
						string text6 = "蠬蠫";
						<Module>.FamANDAssem(ref text6, new object[]
						{
							14572,
							20277,
							false
						});
						string oldValue = text6;
						string newValue = "㨴";
						<Module>.FamANDAssem(ref newValue, new object[]
						{
							4885,
							5483,
							4495
						});
						this.domainsrc = text5.Replace(oldValue, newValue);
						string currentDirectory = Alphaleonis.Win32.Filesystem.Directory.GetCurrentDirectory();
						string str = "ᬥᬢᬫᬜᬊᬌᬕᬍᬊᬤ᭙ᬺᬖᬖᬒᬐᬜᬊ᭙ᬪᬜᬘᬋᬚᬑᬜᬋ";
						<Module>.FamANDAssem(ref str, new object[]
						{
							"Űńä.\u001a",
							6041
						});
						this.PathToFolder = currentDirectory + str;
						int num6 = Alphaleonis.Win32.Filesystem.Directory.Exists(this.PathToFolder) ? 1 : 0;
						int num7;
						switch (0 / -645)
						{
						case 0:
							num7 = 0;
							break;
						}
						bool flag12 = num6 == num7;
						if (flag12)
						{
							Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(this.PathToFolder);
						}
						string pathToFolder = this.PathToFolder;
						string str2 = "㕝";
						<Module>.FamANDAssem(ref str2, new object[]
						{
							7857,
							815,
							4897,
							false
						});
						bool flag13 = (Alphaleonis.Win32.Filesystem.Directory.Exists(pathToFolder + str2 + this.resfold) ? '\u0001' : '\0') == array[0];
						if (flag13)
						{
							string pathToFolder2 = this.PathToFolder;
							string str3 = "斸";
							<Module>.FamANDAssem(ref str3, new object[]
							{
								12500,
								13584,
								false
							});
							Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo2 = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(pathToFolder2 + str3 + this.resfold);
						}
						string pathCurrent = this.PathCurrent;
						string str4 = "ꌝꌒꌤꌵꌵꌨꌯꌦꌲꍯꌨꌯꌨ";
						<Module>.FamANDAssem(ref str4, new object[]
						{
							4517,
							37276
						});
						this.fileinfo = Alphaleonis.Win32.Filesystem.File.ReadAllText(pathCurrent + str4);
						string text7 = this.fileinfo;
						string value = "楑楽楽楹楻楷楡楁楷楳楠楱楺";
						<Module>.FamANDAssem(ref value, new object[]
						{
							"䐤[ਉ",
							3697,
							3097,
							false
						});
						bool flag14 = text7.Contains(value);
						if (flag14)
						{
							string pathCurrent2 = this.PathCurrent;
							string str5 = "૞૑૧૶૶૫૬૥૱બ૫૬૫";
							<Module>.FamANDAssem(ref str5, new object[]
							{
								'ǭ',
								"ȍف '"
							});
							string path = pathCurrent2 + str5;
							string text8 = this.fileinfo;
							string text9 = "敖敺敺敾敼数敦敆数整敧敶敽攨攷";
							<Module>.FamANDAssem(ref text9, new object[]
							{
								'堌',
								1997,
								false,
								1340
							});
							string str6 = text9;
							string str7 = this.getsms;
							string str8 = "좺";
							<Module>.FamANDAssem(ref str8, new object[]
							{
								14976,
								"ṙf\u000f\u0003\f",
								"捓Ց\u0017­",
								"ŤŸʸ",
								63
							});
							string oldValue2 = str6 + str7 + str8;
							string text10 = "歅歩歩歭歯正歵歕正歧歴步歮欻欤";
							<Module>.FamANDAssem(ref text10, new object[]
							{
								23413,
								3985
							});
							string str9 = text10;
							string str10 = this.domainsrc;
							string str11 = "鑐";
							<Module>.FamANDAssem(ref str11, new object[]
							{
								"㏯ᣖⵡ",
								6732
							});
							Alphaleonis.Win32.Filesystem.File.WriteAllText(path, text8.Replace(oldValue2, str9 + str10 + str11));
						}
					}
					isChecked = this.check_PasswordSearcher.IsChecked;
					flag3 = (-530047 - -530048 != 0);
					bool flag15 = isChecked.GetValueOrDefault() == flag3 & isChecked != null;
					if (flag15)
					{
						isChecked = this.SaveFullCookies.IsChecked;
						flag3 = true * true;
						bool flag16 = isChecked.GetValueOrDefault() == flag3 & isChecked != null;
						if (flag16)
						{
							int num8;
							if (3310 != -48466)
							{
								num8 = 1;
							}
							else
							{
								num8 = -126469;
							}
							ToolsWindow.create_base = (num8 != 0);
						}
						isChecked = this.SaveFullCookies.IsChecked;
						flag3 = (0 % -969242 != 0);
						bool flag17 = isChecked.GetValueOrDefault() == flag3 & isChecked != null;
						if (flag17)
						{
							ToolsWindow.create_base = (array2[1] != 0);
						}
						string text11 = this.reqsearch.Text;
						string text12 = "즬즫";
						<Module>.FamANDAssem(ref text12, new object[]
						{
							50598,
							1019,
							false
						});
						string oldValue3 = text12;
						string newValue2 = "宗";
						<Module>.FamANDAssem(ref newValue2, new object[]
						{
							"൛ྦྷࠐլ͡ĉ",
							1114,
							10346
						});
						this.domainsrc = text11.Replace(oldValue3, newValue2);
						string currentDirectory2 = Alphaleonis.Win32.Filesystem.Directory.GetCurrentDirectory();
						string str12 = "꺢꺥꺬꺛꺍꺋꺒꺊꺍꺣껞꺮꺟꺍꺍꺉꺑꺌꺚껞꺭꺛꺟꺌꺝꺖꺛꺌";
						<Module>.FamANDAssem(ref str12, new object[]
						{
							"ᓨ䉜",
							2157,
							5151,
							'ୈ',
							"ୂ⒒\u0010\0\0\0\u0002",
							false
						});
						this.PathToFolder = currentDirectory2 + str12;
						bool flag18 = (Alphaleonis.Win32.Filesystem.Directory.Exists(this.PathToFolder) ? 1 : 0) == (int)0L;
						if (flag18)
						{
							Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo3 = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(this.PathToFolder);
						}
						string pathToFolder3 = this.PathToFolder;
						string str13 = "骭";
						<Module>.FamANDAssem(ref str13, new object[]
						{
							2420,
							'ঃ',
							30655,
							157,
							'ྞ'
						});
						bool flag19 = (Alphaleonis.Win32.Filesystem.Directory.Exists(pathToFolder3 + str13 + this.resfold) ? 1 : 0) == array2[1];
						if (flag19)
						{
							string pathToFolder4 = this.PathToFolder;
							string str14 = "";
							<Module>.FamANDAssem(ref str14, new object[]
							{
								48467,
								13509
							});
							Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo4 = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(pathToFolder4 + str14 + this.resfold);
						}
						string pathCurrent3 = this.PathCurrent;
						string str15 = "ꝩꝦꝐꝁꝁꝜꝛꝒꝆꜛꝜꝛꝜ";
						<Module>.FamANDAssem(ref str15, new object[]
						{
							false,
							36171,
							'͌',
							'Ի',
							2389,
							2062
						});
						this.fileinfo = Alphaleonis.Win32.Filesystem.File.ReadAllText(pathCurrent3 + str15);
						string text13 = this.fileinfo;
						string value2 = "⸙⸨⸺⸺⸾⸦⸻⸭⸚⸬⸨⸻⸪⸡";
						<Module>.FamANDAssem(ref value2, new object[]
						{
							4442,
							6304,
							901,
							false,
							202
						});
						bool flag20 = text13.Contains(value2);
						if (flag20)
						{
							string pathCurrent4 = this.PathCurrent;
							string str16 = "簲簽簋簚簚簇簀簉簝籀簇簀簇";
							<Module>.FamANDAssem(ref str16, new object[]
							{
								"ïOã\u0015%Ö#",
								11567,
								"䁠ࢗ×Ǚ4\u0002\u000e"
							});
							string path2 = pathCurrent4 + str16;
							string text14 = this.fileinfo;
							string text15 = "౉౸౪౪౮౶౫౽ొ౼౸౫౺౱త఻";
							<Module>.FamANDAssem(ref text15, new object[]
							{
								33,
								'\u0002',
								5,
								3057
							});
							string str17 = text15;
							string str18 = this.getsms;
							string str19 = "麥";
							<Module>.FamANDAssem(ref str19, new object[]
							{
								3965,
								36618
							});
							string oldValue4 = str17 + str18 + str19;
							string text16 = "ꔗꔦꔴꔴꔰꔨꔵꔣꔔꔢꔦꔵꔤꔯꕺꕥ";
							<Module>.FamANDAssem(ref text16, new object[]
							{
								'J',
								678,
								198,
								29580,
								'⸅',
								false
							});
							string str20 = text16;
							string str21 = this.domainsrc;
							string str22 = "㜀";
							<Module>.FamANDAssem(ref str22, new object[]
							{
								1232,
								"ᕬ୐ңೳ"
							});
							Alphaleonis.Win32.Filesystem.File.WriteAllText(path2, text14.Replace(oldValue4, str20 + str21 + str22));
						}
					}
					isChecked = this.check_AutoFillsSearcher.IsChecked;
					flag3 = (Convert.ToInt32("1", 16) != 0);
					bool flag21 = isChecked.GetValueOrDefault() == flag3 & isChecked != null;
					if (flag21)
					{
						string text17 = this.reqsearch.Text;
						string text18 = "㝠㝧";
						<Module>.FamANDAssem(ref text18, new object[]
						{
							"ᆄᄻƱȾ",
							"ˇȊ߆ȄsƱ"
						});
						string oldValue5 = text18;
						string newValue3 = "๋";
						<Module>.FamANDAssem(ref newValue3, new object[]
						{
							'P',
							"ºȀľ\a\0\u0002",
							40,
							74,
							false,
							2477
						});
						this.domainsrc = text17.Replace(oldValue5, newValue3);
						string currentDirectory3 = Alphaleonis.Win32.Filesystem.Directory.GetCurrentDirectory();
						string str23 = "멈멏멆멱멧멡멸멠멧멉먴멕멡멠멻멒멽멸멸멧먴멇멱멵멦멷멼멱멦";
						<Module>.FamANDAssem(ref str23, new object[]
						{
							38548,
							"ෆ̎Ӊ\v\u0002\u0002\u0003",
							2919,
							618
						});
						this.PathToFolder = currentDirectory3 + str23;
						bool flag22 = (Alphaleonis.Win32.Filesystem.Directory.Exists(this.PathToFolder) ? 1 : 0) == 827113 - 827113;
						if (flag22)
						{
							Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo5 = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(this.PathToFolder);
						}
						string pathToFolder5 = this.PathToFolder;
						string str24 = "︭";
						<Module>.FamANDAssem(ref str24, new object[]
						{
							"\u0002\u000e\u0002\u0005\a",
							3619,
							42,
							1804,
							''
						});
						bool flag23 = (Alphaleonis.Win32.Filesystem.Directory.Exists(pathToFolder5 + str24 + this.resfold) ? 1 : 0) == ToolsWindow.Utf8SequenceLength;
						if (flag23)
						{
							string pathToFolder6 = this.PathToFolder;
							string str25 = "Ҧ";
							<Module>.FamANDAssem(ref str25, new object[]
							{
								831,
								94,
								292,
								'9'
							});
							Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo6 = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(pathToFolder6 + str25 + this.resfold);
						}
						string pathCurrent5 = this.PathCurrent;
						string str26 = "为丵七丒丒丏丈丁丕么丏丈丏";
						<Module>.FamANDAssem(ref str26, new object[]
						{
							13728,
							3139,
							"\u0096ټ\u0013ǽ",
							"\u0015ÈcØ",
							'ŉ'
						});
						this.fileinfo = Alphaleonis.Win32.Filesystem.File.ReadAllText(pathCurrent5 + str26);
						string text19 = this.fileinfo;
						string value3 = "㚞㚪㚫㚰㚹㚶㚳㚳㚬㚌㚺㚾㚭㚼㚷";
						<Module>.FamANDAssem(ref value3, new object[]
						{
							13908,
							8,
							"M\u0018\u0003\n\u0003\f\u0002"
						});
						bool flag24 = text19.Contains(value3);
						if (flag24)
						{
							string pathCurrent6 = this.PathCurrent;
							string str27 = "䶐䶟䶩䶸䶸䶥䶢䶫䶿䷢䶥䶢䶥";
							<Module>.FamANDAssem(ref str27, new object[]
							{
								'ҽ',
								12278,
								5389,
								1036
							});
							string path3 = pathCurrent6 + str27;
							string text20 = this.fileinfo;
							string text21 = "\udb51\udb65\udb64\udb7f\udb76\udb79\udb7c\udb7c\udb63\udb43\udb75\udb71\udb62\udb73\udb78\udb2d\udb32";
							<Module>.FamANDAssem(ref text21, new object[]
							{
								14808,
								'糒',
								'⑦'
							});
							string str28 = text21;
							string str29 = this.getsms;
							string str30 = "ἄ";
							<Module>.FamANDAssem(ref str30, new object[]
							{
								1170,
								'᪔'
							});
							string oldValue6 = str28 + str29 + str30;
							string text22 = "聳聇聆聝联聛聞聞聁聡聗聓聀聑聚耏耐";
							<Module>.FamANDAssem(ref text22, new object[]
							{
								401,
								"\0a*\u001c",
								9447,
								false,
								"β\u00a0\"2\t",
								"䘘ԋѶƋ̀"
							});
							string str31 = text22;
							string str32 = this.domainsrc;
							string str33 = "ズ";
							<Module>.FamANDAssem(ref str33, new object[]
							{
								false,
								14,
								12333,
								91,
								"\0\0\0\0\u0002",
								false
							});
							Alphaleonis.Win32.Filesystem.File.WriteAllText(path3, text20.Replace(oldValue6, str31 + str32 + str33));
						}
					}
					isChecked = this.check_ccSearcher.IsChecked;
					flag3 = (Marshal.SizeOf(typeof(TaskAsyncEnumerableExtensions)) != 0);
					bool flag25 = isChecked.GetValueOrDefault() == flag3 & isChecked != null;
					if (flag25)
					{
						string text23 = this.reqsearch.Text;
						string text24 = "";
						<Module>.FamANDAssem(ref text24, new object[]
						{
							false,
							13150,
							"懳ឯ",
							13741
						});
						string oldValue7 = text24;
						string newValue4 = "\ude92";
						<Module>.FamANDAssem(ref newValue4, new object[]
						{
							49999,
							'฿',
							"ُЅÒƀ\u0019\\"
						});
						this.domainsrc = text23.Replace(oldValue7, newValue4);
						string currentDirectory4 = Alphaleonis.Win32.Filesystem.Directory.GetCurrentDirectory();
						string str34 = "㥚㥝㥔㥣㥵㥳㥪㥲㥵㥛㤦㥅㥴㥣㥢㥯㥲㥅㥧㥴㥢㥵㤦㥕㥣㥧㥴㥥㥮㥣㥴";
						<Module>.FamANDAssem(ref str34, new object[]
						{
							268,
							2603,
							"%>%\u0015",
							11450,
							'x',
							false
						});
						this.PathToFolder = currentDirectory4 + str34;
						bool flag26 = (Alphaleonis.Win32.Filesystem.Directory.Exists(this.PathToFolder) ? 1 : 0) == ~-1;
						if (flag26)
						{
							Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo7 = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(this.PathToFolder);
						}
						string pathToFolder7 = this.PathToFolder;
						string str35 = "";
						<Module>.FamANDAssem(ref str35, new object[]
						{
							'װ',
							"ޜࢫᇛ஭",
							'망'
						});
						bool flag27 = (Alphaleonis.Win32.Filesystem.Directory.Exists(pathToFolder7 + str35 + this.resfold) ? 1 : 0) == Convert.ToInt32("0", 16);
						if (flag27)
						{
							string pathToFolder8 = this.PathToFolder;
							string str36 = "뱼";
							<Module>.FamANDAssem(ref str36, new object[]
							{
								12605,
								false,
								20832,
								95,
								14192,
								'ƴ'
							});
							Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo8 = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(pathToFolder8 + str36 + this.resfold);
						}
					}
					isChecked = this.SaveFullLog.IsChecked;
					flag3 = ((962529 ^ 962528) != 0);
					bool flag28 = isChecked.GetValueOrDefault() == flag3 & isChecked != null;
					if (flag28)
					{
						ToolsWindow.sfl = (array2[0] != 0);
					}
					isChecked = this.SaveFullLog.IsChecked;
					flag3 = (-89526 + 89526 != 0);
					bool flag29 = isChecked.GetValueOrDefault() == flag3 & isChecked != null;
					if (flag29)
					{
						ToolsWindow.sfl = (string.Empty.Length != 0);
					}
					this.thrcnt = Convert.ToInt32(this.NumThreadsCount.Text);
					new Thread(delegate()
					{
						this.CheckerDomain();
					}).Start();
					this.stop_button.IsEnabled = (Marshal.SizeOf(typeof(TaskAsyncEnumerableExtensions)) != 0);
					UIElement uielement = this.logs_button;
					char c4 = '\0';
					checked
					{
						uielement.IsEnabled = ((int)c4 != 0);
						this.start_button.IsEnabled = (823852 + -823852 != 0);
						this.check_CookiesSearcher.IsEnabled = (false & true);
						this.check_PasswordSearcher.IsEnabled = (0 % -63510 != 0);
						this.check_AutoFillsSearcher.IsEnabled = (0 / 1906388118 != 0);
					}
					this.check_ccSearcher.IsEnabled = (-384799 - -384799 != 0);
				}
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0001B1D4 File Offset: 0x000193D4
		private void DomainObrabotka(string rez)
		{
			try
			{
				bool flag = -466577 + 466577 != 0;
				bool flag2 = true & false;
				string b = "伛伜休伎优";
				<Module>.FamANDAssem(ref b, new object[]
				{
					'ɯ',
					'⺪',
					421,
					7359,
					false
				});
				bool flag3 = rez == b;
				if (flag3)
				{
					this.remainsCounter -= Convert.ToInt32("1", 8);
				}
				else
				{
					char c = '\u0001';
					flag = (checked((int)c) != 0);
					this.remainsCounter -= 53774 >> 15;
				}
				base.Dispatcher.Invoke(new MethodInvoker(delegate()
				{
					System.Windows.Controls.ProgressBar progressBar = this.progressBar1;
					double value = progressBar.Value;
					progressBar.Value = value + 1.0;
					this.allCookiesFiles.Text = this.filesCounter.ToString();
					this.foundCookies.Text = this.cookiesCounter.ToString();
					this.remainsCookiesFiles.Text = this.remainsCounter.ToString();
				}), Array.Empty<object>());
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0001B2C8 File Offset: 0x000194C8
		[DebuggerStepThrough]
		private void CheckerDomain()
		{
			int[] array = new int[]
			{
				-1
			};
			ToolsWindow.<CheckerDomain>d__49 <CheckerDomain>d__ = new ToolsWindow.<CheckerDomain>d__49();
			<CheckerDomain>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<CheckerDomain>d__.<>4__this = this;
			<CheckerDomain>d__.<>1__state = array[0];
			<CheckerDomain>d__.<>t__builder.Start<ToolsWindow.<CheckerDomain>d__49>(ref <CheckerDomain>d__);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0001B310 File Offset: 0x00019510
		private string CookiesSearcher(string link, string req, string filename, string foldername, string foldercopy, string fld)
		{
			char[] array = new char[]
			{
				'\0',
				'\u0002',
				'\u0004',
				'\t'
			};
			int[] array2 = new int[]
			{
				0,
				9
			};
			string result;
			try
			{
				string text = string.Empty;
				string[] source = Alphaleonis.Win32.Filesystem.File.ReadAllLines(link).Select(delegate(string x)
				{
					string str2 = "狟";
					<Module>.FamANDAssem(ref str2, new object[]
					{
						7012,
						"䌛ʓಳ\u0011č1",
						"ôú&\b\0\u0003",
						419
					});
					return x + str2;
				}).ToArray<string>();
				foreach (string text2 in source.Distinct<string>())
				{
					try
					{
						string text3 = text2;
						string value = "ዉ";
						<Module>.FamANDAssem(ref value, new object[]
						{
							"͸ύ",
							49,
							'\f',
							2857,
							'\u0015'
						});
						bool flag;
						if (text3.Contains(value))
						{
							string text4 = text2;
							string value2 = "杶";
							<Module>.FamANDAssem(ref value2, new object[]
							{
								false,
								13385,
								13071
							});
							if (text4.Contains(value2))
							{
								string text5 = text2;
								string value3 = "붘";
								<Module>.FamANDAssem(ref value3, new object[]
								{
									"ˮ\u0019΀ʟ",
									"¸Qĉ",
									"ᰅ⨮▽৫➕ৼࢁ",
									658,
									false
								});
								flag = text5.Contains(value3);
								goto IL_16C;
							}
						}
						flag = (-815909 - -815909 != 0);
						IL_16C:
						bool flag2 = flag;
						if (flag2)
						{
							string text6 = text2;
							int num;
							switch (1322422992 / 1322422992)
							{
							case 0:
								num = 480905;
								break;
							case 1:
								num = 1;
								break;
							case 2:
								num = 718889;
								break;
							}
							char[] array3 = new char[num];
							array3[checked(0 * 88220)] = (char)((int)9L);
							bool flag3 = text6.Split(array3)[Convert.ToInt32("0", 16)].Contains(req);
							if (flag3)
							{
								string[] array4 = new string[Convert.ToInt32("1111", 2)];
								array4[Convert.ToInt32("0", 16)] = text;
								int num2 = Convert.ToInt32("1", 16);
								string text7 = text2;
								char[] array5 = new char[333795 + -333794];
								array5[0 * -84850] = (char)array2[1];
								array4[num2] = text7.Split(array5)[0 << 6];
								int num3 = (int)array[1];
								string text8 = "菌";
								<Module>.FamANDAssem(ref text8, new object[]
								{
									92,
									"᳦Ÿ",
									'\v',
									"ɃÐŶ©#b",
									24393
								});
								array4[num3] = text8;
								int num4 = -3 * -1;
								string text9 = text2;
								int num5 = 1;
								char[] array6 = new char[num5];
								array6[0 | 0] = '-' % '\u0012';
								array4[num4] = text9.Split(array6)[checked(1 * 1)];
								int num6 = 4 * 1;
								string text10 = "숩";
								<Module>.FamANDAssem(ref text10, new object[]
								{
									46562,
									1298,
									1260,
									576
								});
								array4[num6] = text10;
								int num7 = Marshal.SizeOf(typeof(IsProperSubsetOf));
								string text11 = text2;
								char[] array7 = new char[Marshal.SizeOf(typeof(TaskAsyncEnumerableExtensions))];
								array7[1474237956 >> 31] = (char)(-682955 + 682964);
								array4[num7] = text11.Split(array7)[-2 * -1];
								char c = '\u0006';
								int num8 = (int)c;
								string text12 = "䎨";
								<Module>.FamANDAssem(ref text12, new object[]
								{
									62,
									7528,
									9723
								});
								array4[num8] = text12;
								int num9 = 7 & 7;
								string text13 = text2;
								char c2 = '\u0001';
								checked
								{
									char[] array8 = new char[(int)c2];
									array8[string.Empty.Length] = (char)(-492771 ^ -492780);
									array4[num9] = text13.Split(array8)[Convert.ToInt32("11", 2)];
									int num10 = 8;
									int num11 = num10;
									string text14 = "紑";
									<Module>.FamANDAssem(ref text14, new object[]
									{
										4141,
										'♤',
										"ᥔќѩĈ",
										false,
										'⍦'
									});
									array4[num11] = text14;
									int num12 = (int)array[3];
									string text15 = text2;
									char[] array9 = new char[sizeof(byte)];
									array9[array2[0]] = (char)(881019 + -881010);
									array4[num12] = text15.Split(array9)[unchecked(-4 * -1)];
									int num13 = 572535 + -572525;
									string text16 = "ໜ";
									<Module>.FamANDAssem(ref text16, new object[]
									{
										114,
										584,
										135,
										"̩АƎˍ"
									});
									array4[num13] = text16;
									int num14 = unchecked(-11 * -1);
									string text17 = text2;
									char[] array10 = new char[1644287599 / 1644287599];
									int num15 = 0 % 269173;
									char c3 = '\t';
									array10[num15] = (char)((int)c3);
									array4[num14] = text17.Split(array10)[5 & 7];
									int caselessMatching = ToolsWindow.CaselessMatching;
									string text18 = "ᨅ";
									<Module>.FamANDAssem(ref text18, new object[]
									{
										3053,
										3409,
										206
									});
									array4[caselessMatching] = text18;
									int num16 = 27 >> 1;
									string text19 = text2;
									char[] array11 = new char[1 & 1];
									array11[0 & 0] = (char)array2[1];
									array4[num16] = text19.Split(array11)[(99128 >= 453091) ? 481476 : 6];
									int num17 = -948922 ^ -948920;
									string text20 = "䂠䂧";
									<Module>.FamANDAssem(ref text20, new object[]
									{
										7700,
										'Ĭ',
										42,
										3745,
										'ኢ'
									});
									array4[num17] = text20;
									text = string.Concat(array4);
								}
							}
						}
					}
					catch
					{
					}
				}
				bool flag4 = text.Contains(req);
				if (flag4)
				{
					bool flag5 = ToolsWindow.sfc;
					if (flag5)
					{
						text = Alphaleonis.Win32.Filesystem.File.ReadAllText(link);
					}
					char c4 = '\u0005';
					string[] array12 = new string[(int)c4];
					array12[0 & 0] = this.PathToFolder;
					char c5 = '\u0001';
					int num18 = (int)c5;
					string text21 = "⡔";
					<Module>.FamANDAssem(ref text21, new object[]
					{
						')',
						574,
						false,
						8855,
						"ǊQZc2"
					});
					array12[num18] = text21;
					array12[Convert.ToInt32("2", 8)] = this.resfold;
					int num19 = 2 | 3;
					string text22 = "쯙";
					<Module>.FamANDAssem(ref text22, new object[]
					{
						43932,
						3363,
						"σė˛",
						'଑'
					});
					array12[num19] = text22;
					array12[checked(-2 * -2)] = req;
					bool flag6 = (Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array12)) ? 1 : 0) == 0 * 328758;
					if (flag6)
					{
						string[] array13 = new string[249251 - 249246];
						array13[(int)array[0]] = this.PathToFolder;
						int num20 = 5 % 2;
						string text23 = "㈍";
						<Module>.FamANDAssem(ref text23, new object[]
						{
							"Ꮌڦ¸́C6\t",
							'፴'
						});
						array13[num20] = text23;
						array13[checked((int)2L)] = this.resfold;
						int lf = ToolsWindow.LF;
						string text24 = "〿";
						<Module>.FamANDAssem(ref text24, new object[]
						{
							false,
							"༴Ѯ",
							3668,
							'य',
							1342
						});
						array13[lf] = text24;
						int num21;
						switch (454933 + -454933)
						{
						case 0:
							num21 = 4;
							break;
						}
						array13[num21] = req;
						Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(string.Concat(array13));
					}
					int num33;
					int num34;
					checked
					{
						string[] array14 = new string[929199 + -929194];
						array14[(-1236 < -381004) ? -326433 : 0] = this.PathToFolder;
						int num22 = (int)1L;
						string text25 = "গ";
						<Module>.FamANDAssem(ref text25, new object[]
						{
							false,
							'Ƨ',
							'ނ',
							162
						});
						array14[num22] = text25;
						array14[unchecked(585280 - 585278)] = this.resfold;
						int num23 = 217416 >> 16;
						string text26 = "";
						<Module>.FamANDAssem(ref text26, new object[]
						{
							41312,
							19238
						});
						array14[num23] = text26;
						array14[sizeof(int)] = req;
						bool flag7 = Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array14));
						if (flag7)
						{
							bool flag8 = ToolsWindow.sfl;
							if (flag8)
							{
								string str = "̧";
								<Module>.FamANDAssem(ref str, new object[]
								{
									"\u000f\u0003",
									false,
									766,
									"\u0005\u0003\0\0\0\u0002",
									"\u000e\a\0\u0001\u0004",
									"(\u0013\f"
								});
								string fromDir = foldercopy.Replace(foldername, str + fld);
								char c6 = '\a';
								string[] array15 = new string[(int)c6];
								array15[0 | 0] = this.PathToFolder;
								int num24 = (-11446 <= -827178) ? -405303 : 1;
								string text27 = "";
								<Module>.FamANDAssem(ref text27, new object[]
								{
									'\udac3',
									36,
									5207,
									1382
								});
								array15[num24] = text27;
								array15[1 << 1] = this.resfold;
								int num25 = 28167799 >> 23;
								string text28 = "ᏼ";
								<Module>.FamANDAssem(ref text28, new object[]
								{
									4392,
									"h\u0096T\n",
									false,
									"ę\0\u0001\0\u0002"
								});
								array15[num25] = text28;
								char c7 = '\u0004';
								array15[(int)c7] = req;
								int num26 = Convert.ToInt32("101", 2);
								string text29 = "윲";
								<Module>.FamANDAssem(ref text29, new object[]
								{
									"ൽÊ\u008c)\u0004",
									"Ė\u001c\u0001\0\u0002\0\u0002",
									39764,
									7139
								});
								array15[num26] = text29;
								array15["̙̘̯̊ͧ͡".Length] = fld;
								this.DirectoryCopy(fromDir, string.Concat(array15));
							}
							else
							{
								string[] array16 = new string[Convert.ToInt32("9", 16)];
								array16[unchecked(0 * 42183)] = this.PathToFolder;
								int num27 = 1 & 1;
								string text30 = "ጵ";
								<Module>.FamANDAssem(ref text30, new object[]
								{
									582,
									"ŭ̌ө҈",
									'̹'
								});
								array16[num27] = text30;
								array16[-401467 ^ -401465] = this.resfold;
								char c8 = '\u0003';
								int num28 = (int)c8;
								string text31 = "\udaab";
								<Module>.FamANDAssem(ref text31, new object[]
								{
									false,
									"6\u001f\u0003\u0004\u0004",
									'P',
									159,
									"Ʃű",
									"䞺觻ύ\u0082\u008a"
								});
								array16[num28] = text31;
								array16[(int)array[2]] = req;
								int num29 = 5;
								int num30 = num29;
								string text32 = "ꄗ";
								<Module>.FamANDAssem(ref text32, new object[]
								{
									"ⵊÐⵠੑθƯś",
									"ן٫ྋ",
									6377
								});
								array16[num30] = text32;
								int num31 = 6 & 7;
								string oldValue = "驚";
								<Module>.FamANDAssem(ref oldValue, new object[]
								{
									19651,
									3161,
									'䃪'
								});
								array16[num31] = foldername.Replace(oldValue, "");
								int num32 = 228005 - 227998;
								string text33 = "뤰";
								<Module>.FamANDAssem(ref text33, new object[]
								{
									40989,
									17,
									2007,
									4458
								});
								array16[num32] = text33;
								array16[40 % 16] = filename;
								Alphaleonis.Win32.Filesystem.File.AppendAllText(string.Concat(array16), text);
							}
						}
						num33 = this.cookiesCounter;
						num34 = 1;
					}
					this.cookiesCounter = num33 + num34;
					string text34 = "蛣蛥蛢蛲";
					<Module>.FamANDAssem(ref text34, new object[]
					{
						'Ē',
						10814,
						"ၬ㎪",
						"੥ŭǵ+",
						2367
					});
					result = text34;
				}
				else
				{
					string text35 = "✓✔✙✆✐";
					<Module>.FamANDAssem(ref text35, new object[]
					{
						423,
						695,
						'K',
						52,
						"᧧݌ðG\u001d\u0011"
					});
					result = text35;
				}
			}
			catch (Exception ex)
			{
				string text36 = "";
				<Module>.FamANDAssem(ref text36, new object[]
				{
					336,
					6617,
					"ᶶة໩",
					35263,
					7074
				});
				result = text36;
			}
			return result;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0001C088 File Offset: 0x0001A288
		private string PasswordSearcher(string link, string req, string filename, string foldername, string foldercopy, string fld)
		{
			char[] array = new char[]
			{
				'\0',
				'\u0004',
				'\u0006',
				'\u0003'
			};
			int[] array2 = new int[]
			{
				1,
				0,
				2,
				3,
				5
			};
			string result;
			try
			{
				List<string> list = new List<string>();
				List<string> list2 = new List<string>();
				List<string> list3 = new List<string>();
				string[] array3 = Alphaleonis.Win32.Filesystem.File.ReadAllLines(link);
				int i = 0 | 0;
				while (i < array3.Length)
				{
					string text = array3[i];
					string text2 = "㔔㔔";
					<Module>.FamANDAssem(ref text2, new object[]
					{
						'ࡰ',
						612,
						2064,
						8761
					});
					string oldValue = text2;
					string newValue = "㮎";
					<Module>.FamANDAssem(ref newValue, new object[]
					{
						459,
						1235,
						6623,
						"ൊ̨ɕiȜ",
						1470
					});
					string text3 = text.Replace(oldValue, newValue);
					string text4 = array3[i];
					string[] array4 = array3;
					int num = i;
					string text5 = array3[i];
					string oldValue2 = "\udf55";
					<Module>.FamANDAssem(ref oldValue2, new object[]
					{
						false,
						53866,
						3339
					});
					array4[num] = text5.Replace(oldValue2, "");
					string text6 = text3;
					string value = "";
					<Module>.FamANDAssem(ref value, new object[]
					{
						20,
						false,
						42992,
						5,
						"\u0002\u0002\u0002",
						'䚽'
					});
					bool flag = text6.Contains(value);
					if (flag)
					{
						string text7 = text3;
						char[] array5 = new char[checked(544554 - 544553)];
						array5[-325862 + 325862] = (char)"̺̩̣̦̞̈̆͋͘".Length;
						bool flag2 = text7.Split(array5)[(61798 >= -725292) ? 1 : 480492] != "";
						if (flag2)
						{
							List<string> list4 = list;
							string text8 = text3;
							int num2;
							if (-44125 >= -750817)
							{
								num2 = 1;
							}
							else
							{
								num2 = 347047;
							}
							char[] array6 = new char[num2];
							array6[checked(0 * -81361)] = ('\v' & '\t');
							list4.Add(text8.Split(array6)[-179472 ^ -179471]);
						}
						string text9 = text3;
						char[] array7 = new char[-243870 ^ -243869];
						array7[(73475 != -40103) ? 0 : 273679] = ('\t' | '\b');
						string[] array8 = text9.Split(array7);
						char c = '\u0002';
						bool flag3 = array8[(int)c] != "";
						if (flag3)
						{
							List<string> list5 = list2;
							string text10 = text3;
							char[] array9 = new char[Convert.ToInt32("1", 16)];
							array9[1 & 0] = (char)(-9 * -1);
							list5.Add(text10.Split(array9)[sizeof(ushort)]);
						}
						string text11 = text3;
						char[] array10 = new char[array2[0]];
						array10[checked(276563 - 276563)] = (char)ToolsWindow.get_ElapsedTicks;
						bool flag4 = text11.Split(array10)[(int)array[0]] != "";
						if (flag4)
						{
							List<string> list6 = list3;
							string text12 = text3;
							char[] array11 = new char[(-93782 >= 405741) ? -19219 : 1];
							array11[0 << 14] = (char)(-694240 + 694249);
							list6.Add(text12.Split(array11)[0 | 0]);
						}
					}
					string text13 = text4;
					string value2 = "䬤䭳䭴䭪䬤䬼䬦䬤";
					<Module>.FamANDAssem(ref value2, new object[]
					{
						"Է$\u0006\u0004\a",
						'ᵈ',
						98,
						false,
						"࡚ẓ",
						259
					});
					bool flag5 = text13.Contains(value2);
					if (flag5)
					{
						List<string> list7 = list3;
						string strSource = text4;
						string text14 = "釺醭醪醴釺釢釸釺";
						<Module>.FamANDAssem(ref text14, new object[]
						{
							"ಆ㧢ᆥࣟ£Lı",
							4359,
							"Ʒᩗ±\u0015ñ"
						});
						string strStart = text14;
						string text15 = "︷";
						<Module>.FamANDAssem(ref text15, new object[]
						{
							false,
							"ὼౌಆᩒଋ",
							41066
						});
						string strEnd = text15;
						char c2 = '\0';
						list7.Add(MainWindow.Pars(strSource, strStart, strEnd, (int)c2));
					}
					string text16 = text4;
					string value3 = "巨嶿嶹嶯嶸嶤嶫嶧嶯巨巰巪巨";
					<Module>.FamANDAssem(ref value3, new object[]
					{
						false,
						11565,
						7649,
						4796
					});
					bool flag6 = text16.Contains(value3);
					if (flag6)
					{
						List<string> list8 = list;
						string strSource2 = text4;
						string text17 = "";
						<Module>.FamANDAssem(ref text17, new object[]
						{
							'ᲆ',
							32172,
							20814
						});
						string strStart2 = text17;
						string strEnd2 = "Ⰹ";
						<Module>.FamANDAssem(ref strEnd2, new object[]
						{
							4494,
							"\u0084ª",
							6295,
							216,
							false
						});
						list8.Add(MainWindow.Pars(strSource2, strStart2, strEnd2, 874358 + -874358));
					}
					string text18 = text4;
					string value4 = "\udaa5\udaf7\udae6\udaf4\udaf4\udaf0\udae8\udaf5\udae3\udaa5\udabd\udaa7\udaa5";
					<Module>.FamANDAssem(ref value4, new object[]
					{
						'湵',
						'杨',
						'Ҫ'
					});
					bool flag7 = text18.Contains(value4);
					if (flag7)
					{
						List<string> list9 = list2;
						string strSource3 = text4;
						string text19 = "⺈⻚⻋⻙⻙⻝⻅⻘⻎⺈⺐⺊⺈";
						<Module>.FamANDAssem(ref text19, new object[]
						{
							false,
							11876,
							70
						});
						string strStart3 = text19;
						string text20 = "ࢢ";
						<Module>.FamANDAssem(ref text20, new object[]
						{
							'Ӻ',
							902
						});
						string strEnd3 = text20;
						char c3 = '\0';
						list9.Add(MainWindow.Pars(strSource3, strStart3, strEnd3, (int)c3));
					}
					string text21 = array3[i];
					string value5 = "훐훖훀훗횿";
					<Module>.FamANDAssem(ref value5, new object[]
					{
						22281,
						18998,
						3773,
						'⚉'
					});
					if (text21.Contains(value5))
					{
						goto IL_7A8;
					}
					string text22 = array3[i];
					string value6 = "嚶嚕嚝嚓嚔囀";
					<Module>.FamANDAssem(ref value6, new object[]
					{
						"ṄÖ◱\u0002ŗ׬/",
						2683,
						false
					});
					if (text22.Contains(value6))
					{
						goto IL_7A8;
					}
					string text23 = array3[i];
					string value7 = "룼룚료룛룇룈룄료뢓";
					<Module>.FamANDAssem(ref value7, new object[]
					{
						'Ớ',
						10928,
						1586,
						26626,
						"º\u0006\u0005\u000e\u0004\u0014"
					});
					if (text23.Contains(value7))
					{
						goto IL_7A8;
					}
					string text24 = array3[i];
					string value8 = "⽽⽛⽍⽚⼒";
					<Module>.FamANDAssem(ref value8, new object[]
					{
						"ፆ˷Í\n",
						6164,
						false
					});
					if (text24.Contains(value8))
					{
						goto IL_7A8;
					}
					string text25 = array3[i];
					string value9 = "핍핎핆핈핏픻";
					<Module>.FamANDAssem(ref value9, new object[]
					{
						"ìm\u0017\u001f\0\u0017",
						18384,
						false,
						17779,
						17432,
						"Ƶ\u0005F"
					});
					bool flag8 = text25.Contains(value9);
					IL_7B2:
					bool flag9 = flag8;
					if (flag9)
					{
						List<string> list10 = list;
						string text26 = array3[i];
						string oldValue3 = "뢁뢇뢑뢆룮";
						<Module>.FamANDAssem(ref oldValue3, new object[]
						{
							14753,
							32563,
							false
						});
						string text27 = text26.Replace(oldValue3, "");
						string oldValue4 = "쨦쨅쨍쨃쨄쩐";
						<Module>.FamANDAssem(ref oldValue4, new object[]
						{
							23122,
							false,
							28696
						});
						string text28 = text27.Replace(oldValue4, "");
						string oldValue5 = "⩸⩞⩈⩟⩃⩌⩀⩈⨗";
						<Module>.FamANDAssem(ref oldValue5, new object[]
						{
							"ཁ©Ν\0\u0013\b\u0012",
							"එ؃ʠ#\""
						});
						string text29 = text28.Replace(oldValue5, "");
						string oldValue6 = "甎用甾甩畡";
						<Module>.FamANDAssem(ref oldValue6, new object[]
						{
							6699,
							false,
							20894,
							2450
						});
						string text30 = text29.Replace(oldValue6, "");
						string oldValue7 = "ꚊꚉꚁꚏꚈ꛼";
						<Module>.FamANDAssem(ref oldValue7, new object[]
						{
							37859,
							4835
						});
						string text31 = text30.Replace(oldValue7, "");
						string oldValue8 = "읻읽읫일읠읯읣읫윔";
						<Module>.FamANDAssem(ref oldValue8, new object[]
						{
							false,
							'氈',
							17790,
							'Ꭴ',
							'Ȅ'
						});
						list10.Add(text31.Replace(oldValue8, ""));
					}
					string text32 = array3[i];
					string value10 = "㽧㽶㽤㽤㼍";
					<Module>.FamANDAssem(ref value10, new object[]
					{
						false,
						'㇪',
						3405
					});
					if (text32.Contains(value10))
					{
						goto IL_B38;
					}
					string text33 = array3[i];
					string value11 = "";
					<Module>.FamANDAssem(ref value11, new object[]
					{
						"ꡈї፜",
						'ђ',
						"੗ǭ\\i",
						'ᦨ'
					});
					if (text33.Contains(value11))
					{
						goto IL_B38;
					}
					string text34 = array3[i];
					string value12 = "";
					<Module>.FamANDAssem(ref value12, new object[]
					{
						35057,
						1844,
						false,
						'ル',
						'◖'
					});
					if (text34.Contains(value12))
					{
						goto IL_B38;
					}
					string text35 = array3[i];
					string value13 = "ಣಒಀಀ೉";
					<Module>.FamANDAssem(ref value13, new object[]
					{
						"ڮǝl\u0011\a\u0003",
						'ϡ'
					});
					if (text35.Contains(value13))
					{
						goto IL_B38;
					}
					string text36 = array3[i];
					string value14 = "ᙀᙗᙚᙃᙓᘬ";
					<Module>.FamANDAssem(ref value14, new object[]
					{
						false,
						"ԒȨÕ«",
						"ਘɳÑ"
					});
					if (text36.Contains(value14))
					{
						goto IL_B38;
					}
					string text37 = array3[i];
					string value15 = "䍻䍪䍸䍸䍼䍤䍹䍯䌑";
					<Module>.FamANDAssem(ref value15, new object[]
					{
						'm',
						false,
						1350,
						"š\u0006\0\u0002\u0002",
						"ጎȜ֍ȼ̉&",
						'ᯫ'
					});
					bool flag10 = text37.Contains(value15);
					IL_B44:
					bool flag11 = flag10;
					if (flag11)
					{
						List<string> list11 = list2;
						string text38 = array3[i];
						string oldValue9 = "뿦뿷뿥뿥뾌";
						<Module>.FamANDAssem(ref oldValue9, new object[]
						{
							1671,
							'㷾',
							"㌌ᓁᙲᢗ",
							'Ł',
							794
						});
						string text39 = text38.Replace(oldValue9, "");
						string oldValue10 = "КЭРйЩѶ";
						<Module>.FamANDAssem(ref oldValue10, new object[]
						{
							'ǵ',
							"k\r\u0003",
							62,
							414
						});
						string text40 = text39.Replace(oldValue10, "");
						string oldValue11 = "ꎹꎈꎚꎚꎞꎆꎛꎍꏓ";
						<Module>.FamANDAssem(ref oldValue11, new object[]
						{
							5197,
							3998,
							16527,
							"ځᐫⓃ"
						});
						string text41 = text40.Replace(oldValue11, "");
						string oldValue12 = "掋掺推推握";
						<Module>.FamANDAssem(ref oldValue12, new object[]
						{
							'䟦',
							5590,
							1232,
							false,
							194,
							141
						});
						string text42 = text41.Replace(oldValue12, "");
						string oldValue13 = "遻遬遡選遨逗";
						<Module>.FamANDAssem(ref oldValue13, new object[]
						{
							"៘ॴüˠ­ы",
							"ë䌁∡",
							false
						});
						string text43 = text42.Replace(oldValue13, "");
						string oldValue14 = "䒩䒸䒪䒪䒮䒶䒫䒽䓃";
						<Module>.FamANDAssem(ref oldValue14, new object[]
						{
							"ͺܧથě҂",
							73,
							141,
							10560
						});
						list11.Add(text43.Replace(oldValue14, ""));
					}
					string text44 = array3[i];
					string value16 = "괋괌괒굤";
					<Module>.FamANDAssem(ref value16, new object[]
					{
						10464,
						6274,
						"ヶڢ⽥ĥĩʱ"
					});
					if (text44.Contains(value16))
					{
						goto IL_F84;
					}
					string text45 = array3[i];
					string value17 = "훇훠훾효";
					<Module>.FamANDAssem(ref value17, new object[]
					{
						"룅ǘǭ\u0005\u0006\u001c",
						false,
						2195,
						"֑͓иȿƆ\u0004i"
					});
					if (text45.Contains(value17))
					{
						goto IL_F84;
					}
					string text46 = array3[i];
					string value18 = "뺼뺹뺾뺻뻊";
					<Module>.FamANDAssem(ref value18, new object[]
					{
						16640,
						32240
					});
					if (text46.Contains(value18))
					{
						goto IL_F84;
					}
					string text47 = array3[i];
					string value19 = "찯찊찍찈챙";
					<Module>.FamANDAssem(ref value19, new object[]
					{
						367,
						"ͳ⟃",
						"ࡠˀȝ9Ƙäė",
						7428,
						29105
					});
					if (text47.Contains(value19))
					{
						goto IL_F84;
					}
					string text48 = array3[i];
					string value20 = "皍皪皶皱皫皤皨皠盿";
					<Module>.FamANDAssem(ref value20, new object[]
					{
						"䎩Ӎ",
						"ਵύ¶\n\t\u0002\u001d",
						2888,
						'ᐝ',
						false
					});
					if (text48.Contains(value20))
					{
						goto IL_F84;
					}
					string text49 = array3[i];
					string value21 = "\udd22\udd25\udd39\udd3e\udd50";
					<Module>.FamANDAssem(ref value21, new object[]
					{
						'҆',
						2711,
						'Ϲ',
						'쩔'
					});
					if (text49.Contains(value21))
					{
						goto IL_F84;
					}
					string text50 = array3[i];
					string value22 = "㱢㱅㱙㱞㰐";
					<Module>.FamANDAssem(ref value22, new object[]
					{
						714,
						3031,
						6924,
						4405,
						328
					});
					bool flag12 = text50.Contains(value22);
					IL_F98:
					bool flag13 = flag12;
					if (flag13)
					{
						List<string> list12 = list3;
						string text51 = array3[i];
						string oldValue15 = "헵헲헬햚";
						<Module>.FamANDAssem(ref oldValue15, new object[]
						{
							332,
							3634,
							"\u0001\u0002\u0003\0\0\u0001\u0002",
							'옙'
						});
						string text52 = text51.Replace(oldValue15, "");
						string oldValue16 = "鍏鍨鍶錠";
						<Module>.FamANDAssem(ref oldValue16, new object[]
						{
							29787,
							554,
							2454,
							false,
							4863
						});
						string text53 = text52.Replace(oldValue16, "");
						string oldValue17 = "嗛嗞嗙嗜喭";
						<Module>.FamANDAssem(ref oldValue17, new object[]
						{
							'Ɏ',
							174,
							'力'
						});
						string text54 = text53.Replace(oldValue17, "");
						string oldValue18 = "ใ๦๡๤ี";
						<Module>.FamANDAssem(ref oldValue18, new object[]
						{
							2796,
							'̣'
						});
						string text55 = text54.Replace(oldValue18, "");
						string oldValue19 = "潣潄潘潟潅潊潆潎漑";
						<Module>.FamANDAssem(ref oldValue19, new object[]
						{
							false,
							19769,
							3063,
							5627
						});
						string text56 = text55.Replace(oldValue19, "");
						string oldValue20 = "滬滫滷滰溞";
						<Module>.FamANDAssem(ref oldValue20, new object[]
						{
							25070,
							false,
							3254
						});
						string text57 = text56.Replace(oldValue20, "");
						string oldValue21 = "ੳ੔ੈ੏ਁ";
						<Module>.FamANDAssem(ref oldValue21, new object[]
						{
							402,
							'Ő',
							'ϗ',
							309,
							"ǸU"
						});
						list12.Add(text57.Replace(oldValue21, ""));
					}
					i += sizeof(byte);
					continue;
					IL_F84:
					flag12 = (-97796 >= -906921 || 189113 != 0);
					goto IL_F98;
					IL_B38:
					flag10 = (Convert.ToInt32("1", 16) != 0);
					goto IL_B44;
					IL_7A8:
					flag8 = ((int)1L != 0);
					goto IL_7B2;
				}
				bool flag14 = list.Count > checked(-731641 - -731641);
				if (flag14)
				{
					string text58 = string.Empty;
					string text59 = string.Empty;
					string text60 = string.Empty;
					List<string> list13 = new List<string>();
					List<string> list14 = new List<string>();
					List<string> list15 = new List<string>();
					char c4 = '\0';
					for (int j = (int)c4; j < list.Count; j += 668144 + -668143)
					{
						bool flag15 = ToolsWindow.create_base;
						checked
						{
							if (flag15)
							{
								string text61 = list[j];
								string value23 = "꛼";
								<Module>.FamANDAssem(ref value23, new object[]
								{
									76,
									9212,
									29271,
									"ۍü&\t\u0017",
									false,
									'ࠎ'
								});
								bool flag16 = text61.Contains(value23);
								if (flag16)
								{
									string text62 = list[j];
									string oldValue22 = "ퟃ";
									<Module>.FamANDAssem(ref oldValue22, new object[]
									{
										false,
										721,
										"<\u0015]>\u0011\u0015\t",
										"\u0083ƚ",
										53722
									});
									string text63 = text62.Replace(oldValue22, "");
									string oldValue23 = "曓";
									<Module>.FamANDAssem(ref oldValue23, new object[]
									{
										'傼',
										1244,
										"\u0002\0\0\0\u0002",
										4110,
										261
									});
									bool flag17;
									if (text63.Replace(oldValue23, "").Trim() != "")
									{
										string text64 = list2[j];
										string oldValue24 = "痮";
										<Module>.FamANDAssem(ref oldValue24, new object[]
										{
											25850,
											"Ձ\u0093ð\u001a",
											"˝̨\u0001\0\u0003",
											1005
										});
										string text65 = text64.Replace(oldValue24, "");
										string oldValue25 = "⼣";
										<Module>.FamANDAssem(ref oldValue25, new object[]
										{
											"\u0002\0\0\0\u0002",
											'ण',
											30,
											"\u0002\u0003\u0001\0\0\0\u0002",
											9746
										});
										flag17 = (text65.Replace(oldValue25, "").Trim() != "");
									}
									else
									{
										flag17 = (ToolsWindow.Utf8SequenceLength != 0);
									}
									bool flag18 = flag17;
									if (flag18)
									{
										string[] array12 = new string[365 >> 6];
										array12[ToolsWindow.Utf8SequenceLength] = this.PathToFolder;
										int num3 = 1 * 1;
										string text66 = "";
										<Module>.FamANDAssem(ref text66, new object[]
										{
											8349,
											'荜',
											17142,
											'٪'
										});
										array12[num3] = text66;
										array12[(-38023 != -38023) ? 453108 : 2] = this.resfold;
										int num4 = ~-4;
										string text67 = "ွ";
										<Module>.FamANDAssem(ref text67, new object[]
										{
											2909,
											594,
											'ƞ',
											'\b',
											268
										});
										array12[num4] = text67;
										int num5 = 4 & 6;
										string text68 = "嚁";
										<Module>.FamANDAssem(ref text68, new object[]
										{
											12706,
											6741,
											'ષ'
										});
										string oldValue26 = text68;
										string newValue2 = "蒀";
										<Module>.FamANDAssem(ref newValue2, new object[]
										{
											'惍',
											'Ḥ',
											false,
											821,
											448,
											"\f\u0091\u000f\u0005\u0003\u0014"
										});
										array12[num5] = req.Replace(oldValue26, newValue2);
										bool flag19 = (Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array12)) ? 1 : 0) == unchecked(428782 - 428782);
										if (flag19)
										{
											int num6;
											switch (-62308 - -62308)
											{
											case 0:
												num6 = 5;
												break;
											case 1:
												num6 = 410174;
												break;
											}
											string[] array13 = new string[num6];
											array13[1 & 0] = this.PathToFolder;
											int num7 = 913759 + -913758;
											string text69 = "섅";
											<Module>.FamANDAssem(ref text69, new object[]
											{
												1394,
												"\u0018Ȁ\u0006\f!",
												47516,
												false
											});
											array13[num7] = text69;
											array13[1 << 1] = this.resfold;
											int num8 = (int)array[3];
											string text70 = "姧";
											<Module>.FamANDAssem(ref text70, new object[]
											{
												878,
												'1',
												21581,
												13,
												450
											});
											array13[num8] = text70;
											int num9 = unchecked((int)4L);
											string text71 = "ǚ";
											<Module>.FamANDAssem(ref text71, new object[]
											{
												41,
												8,
												'\u001a',
												367,
												false,
												59
											});
											string oldValue27 = text71;
											string newValue3 = "剆";
											<Module>.FamANDAssem(ref newValue3, new object[]
											{
												165,
												7613,
												'\f',
												9374,
												'ཛྷ',
												false
											});
											array13[num9] = req.Replace(oldValue27, newValue3);
											Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(string.Concat(array13));
										}
										int num10;
										if (-85810 < -658332)
										{
											num10 = -221467;
										}
										else
										{
											num10 = 6;
										}
										string[] array14 = new string[num10];
										array14[-661774 ^ -661774] = this.PathToFolder;
										int num11 = <Module>.Tag[0];
										string text72 = "鱓";
										<Module>.FamANDAssem(ref text72, new object[]
										{
											false,
											7308,
											1974,
											11603,
											689,
											18377
										});
										array14[num11] = text72;
										array14[-67467 + 67469] = this.resfold;
										int num12 = -146623 - -146626;
										string text73 = "屖";
										<Module>.FamANDAssem(ref text73, new object[]
										{
											6897,
											15348,
											"ɤĞäx\u001a-"
										});
										array14[num12] = text73;
										int num13;
										switch (957495 - 957493)
										{
										case 0:
											num13 = 42826;
											break;
										case 1:
											num13 = 312710;
											break;
										case 2:
											num13 = 4;
											break;
										}
										int num14 = num13;
										string text74 = "㸃";
										<Module>.FamANDAssem(ref text74, new object[]
										{
											false,
											"Ԏ˷",
											13579,
											'Ē',
											10
										});
										string oldValue28 = text74;
										string newValue4 = "榚";
										<Module>.FamANDAssem(ref newValue4, new object[]
										{
											'ƿ',
											false,
											1987,
											13633,
											124,
											'⩵'
										});
										array14[num14] = req.Replace(oldValue28, newValue4);
										int num15 = "͓̹̣̤ͬ".Length;
										string text75 = "织绚绷绷组绞绶绺绲绷绋绺绨绨纵绯绣绯";
										<Module>.FamANDAssem(ref text75, new object[]
										{
											false,
											28825,
											'ข'
										});
										array14[num15] = text75;
										string path = string.Concat(array14);
										string text76 = list[j];
										string oldValue29 = "뛧";
										<Module>.FamANDAssem(ref oldValue29, new object[]
										{
											32142,
											"עKG\a\"\u0003\u0006",
											false,
											'㊓'
										});
										string text77 = text76.Replace(oldValue29, "");
										string oldValue30 = "筺";
										<Module>.FamANDAssem(ref oldValue30, new object[]
										{
											false,
											14005,
											"◭ࣿ˂ኣ"
										});
										string str = text77.Replace(oldValue30, "").Trim();
										string text78 = "㷭";
										<Module>.FamANDAssem(ref text78, new object[]
										{
											'ă',
											"ŗN\u0001\0\u0006\u0005\u0006",
											14,
											"ýÓEM\u0016\t%",
											false,
											14441
										});
										string str2 = text78;
										string text79 = list2[j];
										string oldValue31 = "涞";
										<Module>.FamANDAssem(ref oldValue31, new object[]
										{
											"¶4\0\0\u0001\u0002",
											2093,
											19870,
											3357,
											"ˣň˒ŐƜ"
										});
										string text80 = text79.Replace(oldValue31, "");
										string oldValue32 = "펺";
										<Module>.FamANDAssem(ref oldValue32, new object[]
										{
											2515,
											false,
											3191,
											4822,
											43686
										});
										string str3 = text80.Replace(oldValue32, "").Trim();
										string str4 = "坣坤";
										<Module>.FamANDAssem(ref str4, new object[]
										{
											false,
											"፮ࠁȉņ»üǘ",
											'>',
											"៝ีضʲȬ\r=",
											'ͳ'
										});
										Alphaleonis.Win32.Filesystem.File.AppendAllText(path, str + str2 + str3 + str4);
									}
								}
								else
								{
									string text81 = list[j];
									string oldValue33 = "컉";
									<Module>.FamANDAssem(ref oldValue33, new object[]
									{
										'蘴',
										12514,
										6099
									});
									string text82 = text81.Replace(oldValue33, "");
									string oldValue34 = "⬻";
									<Module>.FamANDAssem(ref oldValue34, new object[]
									{
										4956,
										4123,
										2000
									});
									bool flag20;
									if (text82.Replace(oldValue34, "").Trim() != "")
									{
										string text83 = list2[j];
										string oldValue35 = "⸿";
										<Module>.FamANDAssem(ref oldValue35, new object[]
										{
											664,
											174,
											"ክֱ̲",
											"Ó\u0001\u0003\u0003",
											'๯',
											false
										});
										string text84 = text83.Replace(oldValue35, "");
										string oldValue36 = "俎";
										<Module>.FamANDAssem(ref oldValue36, new object[]
										{
											'ᗝ',
											2304,
											4745,
											7756
										});
										flag20 = (text84.Replace(oldValue36, "").Trim() != "");
									}
									else
									{
										flag20 = (false | false);
									}
									bool flag21 = flag20;
									if (flag21)
									{
										string[] array15 = new string[Convert.ToInt32("101", 2)];
										array15[array2[1]] = this.PathToFolder;
										int num16 = -404210 - -404211;
										string text85 = "ڸ";
										<Module>.FamANDAssem(ref text85, new object[]
										{
											200,
											"\r\u0001\0\u0004\u0002",
											1524,
											'\u0014'
										});
										array15[num16] = text85;
										char c5 = '\u0002';
										array15[unchecked((int)c5)] = this.resfold;
										int num17 = -357428 - -357431;
										string text86 = "틬";
										<Module>.FamANDAssem(ref text86, new object[]
										{
											6616,
											false,
											'룘'
										});
										array15[num17] = text86;
										int num18 = 279150 ^ 279146;
										string text87 = "দ";
										<Module>.FamANDAssem(ref text87, new object[]
										{
											1198,
											155,
											82,
											901,
											105,
											false
										});
										string oldValue37 = text87;
										string newValue5 = "锱";
										<Module>.FamANDAssem(ref newValue5, new object[]
										{
											1010,
											'ᝆ',
											"ӜC/\u0090\u001a",
											28936,
											743
										});
										array15[num18] = req.Replace(oldValue37, newValue5);
										bool flag22 = (Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array15)) ? 1 : 0) == (int)0L;
										if (flag22)
										{
											string[] array16 = new string[array2[4]];
											int num19;
											switch (1391931385 / 1391931385)
											{
											case 0:
												num19 = 136402;
												break;
											case 1:
												num19 = 0;
												break;
											}
											array16[num19] = this.PathToFolder;
											int num20 = Convert.ToInt32("1", 2);
											string text88 = "坨";
											<Module>.FamANDAssem(ref text88, new object[]
											{
												11839,
												"Ⱥᔕǯྷ"
											});
											array16[num20] = text88;
											array16[ToolsWindow.Handle] = this.resfold;
											int num21 = 3 & 3;
											string text89 = "\ud95c";
											<Module>.FamANDAssem(ref text89, new object[]
											{
												15958,
												false,
												2662,
												36932
											});
											array16[num21] = text89;
											int num22 = (int)array[1];
											string text90 = "ꌠ";
											<Module>.FamANDAssem(ref text90, new object[]
											{
												"ֽ➆",
												580,
												false,
												"៛ಫ۸Т\u0015\f\f",
												"ݗ଩o",
												12492
											});
											string oldValue38 = text90;
											string newValue6 = "憟";
											<Module>.FamANDAssem(ref newValue6, new object[]
											{
												18213,
												"ৗ෴ĥň/\u001d\b"
											});
											array16[num22] = req.Replace(oldValue38, newValue6);
											Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo2 = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(string.Concat(array16));
										}
										string[] array17 = new string[(10755 >= 47977) ? 179463 : 6];
										array17[11185279 >> 24] = this.PathToFolder;
										int num23 = 1;
										int num24 = num23;
										string text91 = "ᗓ";
										<Module>.FamANDAssem(ref text91, new object[]
										{
											false,
											'࠹',
											3414
										});
										array17[num24] = text91;
										int num25 = 2;
										array17[num25] = this.resfold;
										int num26 = 986213 - 986210;
										string text92 = "帱";
										<Module>.FamANDAssem(ref text92, new object[]
										{
											12432,
											false,
											"\rቱ᩟Ā"
										});
										array17[num26] = text92;
										int num27 = Convert.ToInt32("4", 8);
										string text93 = "͍";
										<Module>.FamANDAssem(ref text93, new object[]
										{
											355,
											false,
											'ǿ'
										});
										string oldValue39 = text93;
										string newValue7 = "Ꮆ";
										<Module>.FamANDAssem(ref newValue7, new object[]
										{
											'ԏ',
											"૷ãƤ\u0001H\u0004\u0003",
											'<',
											127
										});
										array17[num27] = req.Replace(oldValue39, newValue7);
										int num28 = (int)5L;
										string text94 = "⇶⇫⇆⇆⇵⇦⇅⇍⇃⇄⇺⇋⇙⇙ↄ⇞⇒⇞";
										<Module>.FamANDAssem(ref text94, new object[]
										{
											1122,
											1099,
											false,
											1267,
											428,
											4702
										});
										array17[num28] = text94;
										string path2 = string.Concat(array17);
										string text95 = list[j];
										string oldValue40 = "寴";
										<Module>.FamANDAssem(ref oldValue40, new object[]
										{
											"কᰭউ⪾",
											3,
											"Ğ\u0002\f\u0005\u0002",
											68,
											"\f\v:"
										});
										string text96 = text95.Replace(oldValue40, "");
										string oldValue41 = "흮";
										<Module>.FamANDAssem(ref oldValue41, new object[]
										{
											4333,
											1974,
											'ゃ',
											36332
										});
										string str5 = text96.Replace(oldValue41, "").Trim();
										string text97 = "퍪";
										<Module>.FamANDAssem(ref text97, new object[]
										{
											'䤅',
											false,
											33172,
											'ࢷ'
										});
										string str6 = text97;
										string text98 = list2[j];
										string oldValue42 = "考";
										<Module>.FamANDAssem(ref oldValue42, new object[]
										{
											'⼰',
											20723,
											false
										});
										string text99 = text98.Replace(oldValue42, "");
										string oldValue43 = "ሐ";
										<Module>.FamANDAssem(ref oldValue43, new object[]
										{
											'Ɖ',
											4323
										});
										string str7 = text99.Replace(oldValue43, "").Trim();
										string str8 = "ᬠᬧ";
										<Module>.FamANDAssem(ref str8, new object[]
										{
											'"',
											128,
											6671,
											56,
											68
										});
										Alphaleonis.Win32.Filesystem.File.AppendAllText(path2, str5 + str6 + str7 + str8);
									}
								}
							}
							bool flag23 = list3[j].Contains(req);
							if (flag23)
							{
								string text100 = list[j];
								string value24 = "";
								<Module>.FamANDAssem(ref value24, new object[]
								{
									539,
									"ǡŬ£4L\u001e\b",
									56599,
									8,
									300
								});
								bool flag24 = text100.Contains(value24);
								if (flag24)
								{
									List<string> list16 = list13;
									string text101 = list[j];
									string oldValue44 = "Ꮝ";
									<Module>.FamANDAssem(ref oldValue44, new object[]
									{
										"!\u0004",
										false,
										"ጫ'\u001b\u0003\u001c",
										30,
										24,
										6
									});
									string text102 = text101.Replace(oldValue44, "");
									string oldValue45 = "ꭡ";
									<Module>.FamANDAssem(ref oldValue45, new object[]
									{
										'ॷ',
										6934,
										34448
									});
									string str9 = text102.Replace(oldValue45, "").Trim();
									string text103 = "䯼";
									<Module>.FamANDAssem(ref text103, new object[]
									{
										14381,
										'\u000e',
										"\u009e\u0004\u0001\u0001\u0002",
										'¥',
										false,
										'ቀ'
									});
									string str10 = text103;
									string text104 = list2[j];
									string oldValue46 = "䌷";
									<Module>.FamANDAssem(ref oldValue46, new object[]
									{
										5956,
										7497,
										586,
										'ీ'
									});
									string text105 = text104.Replace(oldValue46, "");
									string oldValue47 = "賵";
									<Module>.FamANDAssem(ref oldValue47, new object[]
									{
										22653,
										'ূ',
										"\b$\0\0\0\0\u0002",
										false,
										2047,
										8733
									});
									list16.Add(str9 + str10 + text105.Replace(oldValue47, "").Trim());
								}
								else
								{
									List<string> list17 = list14;
									string text106 = list[j];
									string oldValue48 = "⺾";
									<Module>.FamANDAssem(ref oldValue48, new object[]
									{
										'࿪',
										4060,
										false,
										3800
									});
									string text107 = text106.Replace(oldValue48, "");
									string oldValue49 = "";
									<Module>.FamANDAssem(ref oldValue49, new object[]
									{
										"ಓ⠮ࠈQk",
										'ኼ',
										"ˌub\u001d\u0005\0\u0002",
										"㚉㣲Ј˰Զ3ľ",
										"∢ɿŁƲ"
									});
									string str11 = text107.Replace(oldValue49, "").Trim();
									string text108 = "茆";
									<Module>.FamANDAssem(ref text108, new object[]
									{
										11561,
										5431,
										'䃜'
									});
									string str12 = text108;
									string text109 = list2[j];
									string oldValue50 = "跑";
									<Module>.FamANDAssem(ref oldValue50, new object[]
									{
										19309,
										10516,
										6512
									});
									string text110 = text109.Replace(oldValue50, "");
									string oldValue51 = "ㇸ";
									<Module>.FamANDAssem(ref oldValue51, new object[]
									{
										'ᢾ',
										'Ꮶ',
										1248,
										false
									});
									list17.Add(str11 + str12 + text110.Replace(oldValue51, "").Trim());
								}
								List<string> list18 = list15;
								int num29;
								switch (-169393 + 169393)
								{
								case 0:
									num29 = 5;
									break;
								case 1:
									num29 = -444796;
									break;
								case 2:
									num29 = 4839;
									break;
								}
								string[] array18 = new string[num29];
								int num30 = unchecked(0 * 716237);
								string text111 = list3[j];
								string oldValue52 = "⎹";
								<Module>.FamANDAssem(ref oldValue52, new object[]
								{
									"\u0016\0\u0012",
									false,
									'༞',
									'ᐰ',
									35
								});
								string text112 = text111.Replace(oldValue52, "");
								string oldValue53 = "伮";
								<Module>.FamANDAssem(ref oldValue53, new object[]
								{
									'ཙ',
									"௘ʍࡡ\u009aŮ",
									'ୟ',
									"੕༤ɉ\a\0\u0001\u0002",
									false
								});
								array18[num30] = text112.Replace(oldValue53, "").Trim();
								int zeroFreeGlobalAllocAnsi = ToolsWindow.ZeroFreeGlobalAllocAnsi;
								string text113 = "Ⴒ";
								<Module>.FamANDAssem(ref text113, new object[]
								{
									'୮',
									'Ж',
									260
								});
								array18[zeroFreeGlobalAllocAnsi] = text113;
								char c6 = '\u0002';
								int num31 = (int)c6;
								string text114 = list[j];
								string oldValue54 = "騶";
								<Module>.FamANDAssem(ref oldValue54, new object[]
								{
									542,
									"೾ᇖ.õf!",
									30586
								});
								string text115 = text114.Replace(oldValue54, "");
								string oldValue55 = "其";
								<Module>.FamANDAssem(ref oldValue55, new object[]
								{
									false,
									'ڤ',
									19046
								});
								array18[num31] = text115.Replace(oldValue55, "").Trim();
								int num32 = 3 & 3;
								string text116 = "⦯";
								<Module>.FamANDAssem(ref text116, new object[]
								{
									5140,
									1230,
									2777,
									1498
								});
								array18[num32] = text116;
								int num33 = -548722 + 548726;
								string text117 = list2[j];
								string oldValue56 = "﵊";
								<Module>.FamANDAssem(ref oldValue56, new object[]
								{
									4562,
									1589,
									'쒓',
									"Ꮒı\u0019ªöW\u0005",
									false,
									'ৈ'
								});
								string text118 = text117.Replace(oldValue56, "");
								string oldValue57 = "열";
								<Module>.FamANDAssem(ref oldValue57, new object[]
								{
									'窴',
									'㶂',
									3410
								});
								array18[num33] = text118.Replace(oldValue57, "").Trim();
								list18.Add(string.Concat(array18));
								unchecked
								{
									this.cookiesCounter += (1 | 0);
								}
							}
						}
					}
					HashSet<string> hashSet = new HashSet<string>(list13, StringComparer.OrdinalIgnoreCase);
					bool flag25 = hashSet.Count > 0 % 314040;
					if (flag25)
					{
						string separator = "뛍뛊";
						<Module>.FamANDAssem(ref separator, new object[]
						{
							"ÎǒϘ",
							676,
							'兡',
							false,
							21914,
							'ک'
						});
						string str13 = string.Join(separator, hashSet);
						string str14 = "ܗܐ";
						<Module>.FamANDAssem(ref str14, new object[]
						{
							1376,
							442
						});
						text58 = str13 + str14;
					}
					HashSet<string> hashSet2 = new HashSet<string>(list14, StringComparer.OrdinalIgnoreCase);
					bool flag26 = hashSet2.Count > (int)0L;
					if (flag26)
					{
						string separator2 = "塗塐";
						<Module>.FamANDAssem(ref separator2, new object[]
						{
							'ứ',
							'㥱'
						});
						string str15 = string.Join(separator2, hashSet2);
						string str16 = "䀭䀪";
						<Module>.FamANDAssem(ref str16, new object[]
						{
							12905,
							"ҠܧēÝ"
						});
						text59 = str15 + str16;
					}
					HashSet<string> hashSet3 = new HashSet<string>(list15, StringComparer.OrdinalIgnoreCase);
					bool flag27 = hashSet3.Count > array2[1];
					if (flag27)
					{
						string separator3 = "￩￮";
						<Module>.FamANDAssem(ref separator3, new object[]
						{
							56375,
							'⎭'
						});
						string str17 = string.Join(separator3, hashSet3);
						string str18 = "╤╣";
						<Module>.FamANDAssem(ref str18, new object[]
						{
							6911,
							false,
							"ӻȪ\u0003\u0005\0\u0002",
							827
						});
						text60 = str17 + str18;
					}
					bool flag28 = text58 != "";
					if (flag28)
					{
						int num34;
						switch (0 * -225733)
						{
						case 0:
							num34 = 5;
							break;
						}
						string[] array19 = new string[num34];
						array19[(-92193 > -732532) ? 0 : 119096] = this.PathToFolder;
						int num35 = "͙".Length;
						string text119 = "\udc83";
						<Module>.FamANDAssem(ref text119, new object[]
						{
							1852,
							6648,
							34988,
							7095,
							'ᝈ'
						});
						array19[num35] = text119;
						array19[ToolsWindow.Handle] = this.resfold;
						int num36 = array2[3];
						string text120 = "䔾";
						<Module>.FamANDAssem(ref text120, new object[]
						{
							"ቺ҉QԼə̹Ĝ",
							8740
						});
						array19[num36] = text120;
						int num37 = 263 >> 6;
						string text121 = "⁖";
						<Module>.FamANDAssem(ref text121, new object[]
						{
							false,
							"Ѓ\u001dϑ\u0096",
							6130
						});
						string oldValue58 = text121;
						string newValue8 = "Վ";
						<Module>.FamANDAssem(ref newValue8, new object[]
						{
							46,
							'_',
							1090,
							143,
							"\0\0\0\0\0\0\u0002"
						});
						array19[num37] = req.Replace(oldValue58, newValue8);
						bool flag29 = (Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array19)) ? 1 : 0) == 0 % -876072;
						if (flag29)
						{
							string[] array20 = new string[Convert.ToInt32("5", 16)];
							array20[300087 ^ 300087] = this.PathToFolder;
							int num38 = -780058 + 780059;
							string text122 = "ో";
							<Module>.FamANDAssem(ref text122, new object[]
							{
								"±üɳȴ\u0004\u0004\r",
								905,
								264,
								"j\u001f\u000e3=\u0016"
							});
							array20[num38] = text122;
							array20[checked(12348 + -12346)] = this.resfold;
							int num39;
							if (-94464 <= 807983)
							{
								num39 = 3;
							}
							else
							{
								num39 = -332047;
							}
							int num40 = num39;
							string text123 = "\udefe";
							<Module>.FamANDAssem(ref text123, new object[]
							{
								25914,
								false,
								'票'
							});
							array20[num40] = text123;
							int num41 = (52815 != 52815) ? 609679 : 4;
							string text124 = "੕";
							<Module>.FamANDAssem(ref text124, new object[]
							{
								false,
								1525,
								1157
							});
							string oldValue59 = text124;
							string newValue9 = "츂";
							<Module>.FamANDAssem(ref newValue9, new object[]
							{
								25627,
								"ƣ\u00a0Ȗ",
								")\u0016\v5",
								'兇',
								"।Ɯҭх"
							});
							array20[num41] = req.Replace(oldValue59, newValue9);
							Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo3 = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(string.Concat(array20));
						}
						string[] array21 = new string[30 % 12];
						array21[0 % 523837] = this.PathToFolder;
						int num42 = Convert.ToInt32("1", 2);
						string text125 = "忬";
						<Module>.FamANDAssem(ref text125, new object[]
						{
							429,
							'ɼ',
							21321,
							2110
						});
						array21[num42] = text125;
						array21["̣̃".Length] = this.resfold;
						int num43;
						if (-71481 < -349465)
						{
							num43 = 645797;
						}
						else
						{
							num43 = 3;
						}
						int num44 = num43;
						string text126 = "檓";
						<Module>.FamANDAssem(ref text126, new object[]
						{
							16168,
							9315,
							'݄'
						});
						array21[num44] = text126;
						int num45 = 1211 >> 8;
						string text127 = "ɩ";
						<Module>.FamANDAssem(ref text127, new object[]
						{
							97,
							485
						});
						string oldValue60 = text127;
						string newValue10 = "鲙";
						<Module>.FamANDAssem(ref newValue10, new object[]
						{
							18034,
							5901,
							false,
							2795,
							13389
						});
						array21[num45] = req.Replace(oldValue60, newValue10);
						int num46 = array2[4];
						string text128 = "턓턊턢턮턦턣턟턮턼턼텡턻턷턻";
						<Module>.FamANDAssem(ref text128, new object[]
						{
							11061,
							"㘲༯ƅo",
							'ᄰ',
							false,
							19861
						});
						array21[num46] = text128;
						Alphaleonis.Win32.Filesystem.File.AppendAllText(string.Concat(array21), text58);
						bool flag30 = ToolsWindow.sfl;
						if (flag30)
						{
							string[] array22 = new string[Marshal.SizeOf(typeof(__c__DisplayClass1_9))];
							array22[checked((int)0L)] = this.PathToFolder;
							int num47 = 100337 - 100336;
							string text129 = "㲻";
							<Module>.FamANDAssem(ref text129, new object[]
							{
								9713,
								177,
								5701,
								false
							});
							array22[num47] = text129;
							array22["̦̱".Length] = this.resfold;
							int num48 = Convert.ToInt32("3", 16);
							string text130 = "귕";
							<Module>.FamANDAssem(ref text130, new object[]
							{
								10690,
								10726,
								3227,
								'䵆',
								false
							});
							array22[num48] = text130;
							int num49 = 202083584 / 50520896;
							string text131 = "䙳";
							<Module>.FamANDAssem(ref text131, new object[]
							{
								14842,
								2637,
								533
							});
							string oldValue61 = text131;
							string newValue11 = "傭";
							<Module>.FamANDAssem(ref newValue11, new object[]
							{
								"Ȯຂ৫~",
								3083,
								"Ĉɞą",
								9460
							});
							array22[num49] = req.Replace(oldValue61, newValue11);
							char c7 = '\u0005';
							bool flag32;
							checked
							{
								int num50 = (int)c7;
								string text132 = "첛첂첪첦첮첫첗첦체체";
								<Module>.FamANDAssem(ref text132, new object[]
								{
									11031,
									"巙䏗"
								});
								array22[num50] = text132;
								bool flag31 = (Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array22)) ? 1 : 0) == 16207 - 16207;
								if (flag31)
								{
									string[] array23 = new string[(int)6L];
									array23[752642 - 752642] = this.PathToFolder;
									int num51 = "͘".Length;
									string text133 = "퇭";
									<Module>.FamANDAssem(ref text133, new object[]
									{
										false,
										"᧐㙕ᛠቴЈcª",
										21283
									});
									array23[num51] = text133;
									array23[sizeof(ushort)] = this.resfold;
									int num52 = Convert.ToInt32("3", 16);
									string text134 = "襽";
									<Module>.FamANDAssem(ref text134, new object[]
									{
										32158,
										'ஃ'
									});
									array23[num52] = text134;
									int num53 = "̶̱͊͒".Length;
									string text135 = "";
									<Module>.FamANDAssem(ref text135, new object[]
									{
										"ቨ˱k\u000e\u000e",
										"쭽࠶"
									});
									string oldValue62 = text135;
									string newValue12 = "鬹";
									<Module>.FamANDAssem(ref newValue12, new object[]
									{
										"ࡽ\u0004\u0001\v\u000f\f",
										3177,
										"śF\aG",
										249,
										'茞'
									});
									array23[num53] = req.Replace(oldValue62, newValue12);
									int num54 = Convert.ToInt32("5", 8);
									string text136 = "ꠔꠍꠥ꠩ꠡꠤꠘ꠩꠻꠻";
									<Module>.FamANDAssem(ref text136, new object[]
									{
										38925,
										4155
									});
									array23[num54] = text136;
									Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo4 = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(string.Concat(array23));
								}
								string[] array24 = new string[ToolsWindow.IsSet];
								array24[string.Empty.Length] = this.PathToFolder;
								int num55 = (int)1L;
								string text137 = "㹖";
								<Module>.FamANDAssem(ref text137, new object[]
								{
									15756,
									20,
									'j'
								});
								array24[num55] = text137;
								array24[70 >> 5] = this.resfold;
								int num56 = 3 & 3;
								string text138 = "싺";
								<Module>.FamANDAssem(ref text138, new object[]
								{
									'ꧨ',
									1210,
									4273,
									false,
									'͓'
								});
								array24[num56] = text138;
								int num57 = -51861 + 51865;
								string text139 = "᢫";
								<Module>.FamANDAssem(ref text139, new object[]
								{
									1261,
									"|\r\u0018\v\u001f\"",
									3657,
									"ɬ#Ą)E\u0002\u0011",
									77
								});
								string oldValue63 = text139;
								string newValue13 = "舚";
								<Module>.FamANDAssem(ref newValue13, new object[]
								{
									false,
									"⋃թ㛿૦",
									"Ѓఐיȉ\u001f\u000f"
								});
								array24[num57] = req.Replace(oldValue63, newValue13);
								int num58 = "̞̼̆̾̅".Length;
								string text140 = "ᵎᵗᵿᵳᵻᵾᵂᵳᵡᵡ";
								<Module>.FamANDAssem(ref text140, new object[]
								{
									false,
									1518,
									"ԍıȇ",
									3807
								});
								array24[num58] = text140;
								flag32 = Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array24));
							}
							if (flag32)
							{
								string str19 = "ố";
								<Module>.FamANDAssem(ref str19, new object[]
								{
									7415,
									406
								});
								string fromDir = foldercopy.Replace(foldername, str19 + fld);
								int num59 = 7;
								string[] array25 = new string[num59];
								array25[0 | 0] = this.PathToFolder;
								int num60 = Convert.ToInt32("1", 8);
								string text141 = "㆗";
								<Module>.FamANDAssem(ref text141, new object[]
								{
									"ظË\t\u0013",
									10924
								});
								array25[num60] = text141;
								char c8 = '\u0002';
								array25[(int)c8] = this.resfold;
								char c9 = '\u0003';
								int num61 = (int)c9;
								string text142 = "䣚";
								<Module>.FamANDAssem(ref text142, new object[]
								{
									'Õ',
									false,
									6333,
									'ઉ',
									7433,
									"֘Ǌ"
								});
								array25[num61] = text142;
								int num62 = checked((int)4L);
								string text143 = "砠";
								<Module>.FamANDAssem(ref text143, new object[]
								{
									27348,
									false,
									3387
								});
								string oldValue64 = text143;
								string newValue14 = "";
								<Module>.FamANDAssem(ref newValue14, new object[]
								{
									28201,
									35295
								});
								array25[num62] = req.Replace(oldValue64, newValue14);
								int num63 = array2[4];
								string text144 = "ꅑꅈꅠꅬꅤꅡꅝꅬꅾꅾꅑ";
								<Module>.FamANDAssem(ref text144, new object[]
								{
									false,
									"éȔ",
									"篏୉֕୨׻"
								});
								array25[num63] = text144;
								array25[ToolsWindow.IsSet] = fld;
								this.DirectoryCopy(fromDir, string.Concat(array25));
							}
						}
					}
					bool flag33 = text59 != "";
					if (flag33)
					{
						string[] array26 = new string[(70895 > 816375) ? 798606 : 5];
						array26[1 & 0] = this.PathToFolder;
						int num64 = 1 | 0;
						string text145 = "愻";
						<Module>.FamANDAssem(ref text145, new object[]
						{
							'̏',
							14466,
							false,
							9686
						});
						array26[num64] = text145;
						array26[-317516 - -317518] = this.resfold;
						int num65 = <Module>.Cgt[4];
						string text146 = "읳";
						<Module>.FamANDAssem(ref text146, new object[]
						{
							7286,
							'ꪹ'
						});
						array26[num65] = text146;
						int num66 = (int)4L;
						string text147 = "첂";
						<Module>.FamANDAssem(ref text147, new object[]
						{
							654,
							'ȡ',
							'ߛ',
							"ᬩ⾤ถ晈",
							248
						});
						string oldValue65 = text147;
						string newValue15 = "蒃";
						<Module>.FamANDAssem(ref newValue15, new object[]
						{
							false,
							'ú',
							7661,
							24694,
							"d\u001d5\t\u0005\f",
							"̭.@X\u008d"
						});
						array26[num66] = req.Replace(oldValue65, newValue15);
						bool flag34 = (Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array26)) ? '\u0001' : '\0') == array[0];
						if (flag34)
						{
							char c10 = '\u0005';
							string[] array27 = new string[(int)c10];
							array27[0 % -713561] = this.PathToFolder;
							int num67;
							switch (1427403658 / 1427403658)
							{
							case 0:
								num67 = -538725;
								break;
							case 1:
								num67 = 1;
								break;
							}
							int num68 = num67;
							string text148 = "";
							<Module>.FamANDAssem(ref text148, new object[]
							{
								46007,
								7525,
								7443
							});
							array27[num68] = text148;
							array27[checked(-2 * -1)] = this.resfold;
							int num69 = -894192 ^ -894189;
							string text149 = "郂";
							<Module>.FamANDAssem(ref text149, new object[]
							{
								'ࢹ',
								3118,
								'ங',
								11188,
								17514
							});
							array27[num69] = text149;
							int num70 = sizeof(uint);
							string text150 = "౛";
							<Module>.FamANDAssem(ref text150, new object[]
							{
								2105,
								'͚',
								false,
								225
							});
							string oldValue66 = text150;
							string newValue16 = "懁";
							<Module>.FamANDAssem(ref newValue16, new object[]
							{
								20214,
								"ƦÃܓ",
								213,
								1949,
								267,
								false
							});
							array27[num70] = req.Replace(oldValue66, newValue16);
							Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo5 = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(string.Concat(array27));
						}
						string[] array28 = new string[Convert.ToInt32("110", 2)];
						array28[29 >> 6] = this.PathToFolder;
						bool flag35;
						checked
						{
							int num71 = (int)1L;
							string text151 = "硲";
							<Module>.FamANDAssem(ref text151, new object[]
							{
								25484,
								2341,
								2941
							});
							array28[num71] = text151;
							array28[~-3] = this.resfold;
							int num72 = 758788599 / 252929533;
							string text152 = "㐧";
							<Module>.FamANDAssem(ref text152, new object[]
							{
								"Â%\u001e",
								4151,
								8788,
								'ë',
								false
							});
							array28[num72] = text152;
							int num73 = 7 & 4;
							string text153 = "溽";
							<Module>.FamANDAssem(ref text153, new object[]
							{
								'Ũ',
								9930,
								13417,
								1784,
								2815
							});
							string oldValue67 = text153;
							string newValue17 = "摬";
							<Module>.FamANDAssem(ref newValue17, new object[]
							{
								"Ⓕ๹हᚼ",
								'ѭ',
								'ಬ'
							});
							array28[num73] = req.Replace(oldValue67, newValue17);
							int num74 = -191105 + 191110;
							string text154 = "掙掉措探掬掫掕掤掶掶揫掱掽掱";
							<Module>.FamANDAssem(ref text154, new object[]
							{
								"ၭሱǶn\u0018.\u001a",
								15971
							});
							array28[num74] = text154;
							Alphaleonis.Win32.Filesystem.File.AppendAllText(string.Concat(array28), text59);
							flag35 = ToolsWindow.sfl;
						}
						if (flag35)
						{
							string[] array29 = new string[7 & 6];
							array29[array2[1]] = this.PathToFolder;
							int num75 = 319315 + -319314;
							string text155 = "";
							<Module>.FamANDAssem(ref text155, new object[]
							{
								"ᫀ\u001e",
								false,
								55405
							});
							array29[num75] = text155;
							array29[-171156 - -171158] = this.resfold;
							int num76 = array2[3];
							string text156 = "瞛";
							<Module>.FamANDAssem(ref text156, new object[]
							{
								4036,
								26627
							});
							array29[num76] = text156;
							int num77 = -105563 ^ -105567;
							string text157 = "˘";
							<Module>.FamANDAssem(ref text157, new object[]
							{
								'ƫ',
								58,
								'Ē'
							});
							string oldValue68 = text157;
							string newValue18 = "≝";
							<Module>.FamANDAssem(ref newValue18, new object[]
							{
								5317,
								1476,
								false,
								2026
							});
							array29[num77] = req.Replace(oldValue68, newValue18);
							string[] array31;
							checked
							{
								int num78 = (int)5L;
								string text158 = "诹诩诊诂诌诋诵评诖诖";
								<Module>.FamANDAssem(ref text158, new object[]
								{
									'ൊ',
									1336,
									'ለ',
									"᱙ݭᏻ",
									12122
								});
								array29[num78] = text158;
								bool flag36 = (Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array29)) ? 1 : 0) == ((94856 <= -11666) ? -392921 : 0);
								if (flag36)
								{
									char c11 = '\u0006';
									string[] array30 = new string[(int)c11];
									array30[unchecked(-385535 - -385535)] = this.PathToFolder;
									int num79;
									switch (-639212 + 639213)
									{
									case 0:
										num79 = 478162;
										break;
									case 1:
										num79 = 1;
										break;
									case 2:
										num79 = 70862;
										break;
									}
									int num80 = num79;
									string text159 = "␏";
									<Module>.FamANDAssem(ref text159, new object[]
									{
										94,
										"ሙ٠ࠒª\u001b>",
										false,
										"Ǧ>C"
									});
									array30[num80] = text159;
									array30[1032 >> 9] = this.resfold;
									int num81;
									if (29926 != -35618)
									{
										num81 = 3;
									}
									else
									{
										num81 = 356246;
									}
									int num82 = num81;
									string text160 = "ꙹ";
									<Module>.FamANDAssem(ref text160, new object[]
									{
										"㺱⩯",
										2680,
										'⾜',
										753
									});
									array30[num82] = text160;
									int num83 = (-50967 > 629641) ? -106898 : 4;
									string text161 = "틼";
									<Module>.FamANDAssem(ref text161, new object[]
									{
										1702,
										'ळ',
										"趖ͻᝈ᪡"
									});
									string oldValue69 = text161;
									string newValue19 = "ꔤ";
									<Module>.FamANDAssem(ref newValue19, new object[]
									{
										3184,
										22237,
										16829
									});
									array30[num83] = req.Replace(oldValue69, newValue19);
									int num84 = 681201 + -681196;
									string text162 = "";
									<Module>.FamANDAssem(ref text162, new object[]
									{
										false,
										42219,
										'ܱ',
										'㔂'
									});
									array30[num84] = text162;
									Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo6 = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(string.Concat(array30));
								}
								array31 = new string[unchecked(672520 - 672514)];
								array31[Convert.ToInt32("0", 8)] = this.PathToFolder;
								int num85 = 816112669 >> 29;
								string text163 = "팯";
								<Module>.FamANDAssem(ref text163, new object[]
								{
									9150,
									false,
									'胶',
									"⑕؅Łɞ\u007f\u00116"
								});
								array31[num85] = text163;
								array31[(int)2L] = this.resfold;
								int num86 = ~-4;
								string text164 = "䯫";
								<Module>.FamANDAssem(ref text164, new object[]
								{
									'㓻',
									"࠙Ƽ0",
									'ಷ'
								});
								array31[num86] = text164;
								int num87 = <Module>.ReciprocalStep[2];
								string text165 = "樭";
								<Module>.FamANDAssem(ref text165, new object[]
								{
									7585,
									'䱡'
								});
								string oldValue70 = text165;
								string newValue20 = "㺍";
								<Module>.FamANDAssem(ref newValue20, new object[]
								{
									'ॆ',
									2708,
									3162,
									"ᓒԍȝ",
									'ɳ'
								});
								array31[num87] = req.Replace(oldValue70, newValue20);
							}
							int num88 = 5 * 1;
							string text166 = "";
							<Module>.FamANDAssem(ref text166, new object[]
							{
								18305,
								"燼㣒",
								false
							});
							array31[num88] = text166;
							bool flag37 = Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array31));
							if (flag37)
							{
								string str20 = "✗";
								<Module>.FamANDAssem(ref str20, new object[]
								{
									6186,
									3873
								});
								string fromDir2 = foldercopy.Replace(foldername, str20 + fld);
								string[] array32 = new string[40841 ^ 40846];
								array32[checked(0 * 593069)] = this.PathToFolder;
								int num89 = 1 * 1;
								string text167 = "⻾";
								<Module>.FamANDAssem(ref text167, new object[]
								{
									false,
									'⋢',
									"6\\É\u0004\u0006\\\u000e",
									'ৱ'
								});
								array32[num89] = text167;
								array32[1 << 1] = this.resfold;
								int num90 = 2 | 3;
								string text168 = "⦦";
								<Module>.FamANDAssem(ref text168, new object[]
								{
									5577,
									"ʈ\u001a*",
									'L',
									4377
								});
								array32[num90] = text168;
								int num91 = 4;
								int num92 = num91;
								string text169 = "댭";
								<Module>.FamANDAssem(ref text169, new object[]
								{
									32510,
									'ⶱ',
									752,
									867,
									false
								});
								string oldValue71 = text169;
								string newValue21 = "俁";
								<Module>.FamANDAssem(ref newValue21, new object[]
								{
									"Ƌ\u009a!ő",
									"ᥟΤ\u0018ơ͉ʡ^",
									4324,
									5744
								});
								array32[num92] = req.Replace(oldValue71, newValue21);
								int num93 = "̶̴̦̯͌".Length;
								string text170 = "嬳嬣嬀嬈嬆嬁嬿嬎嬜嬜嬳";
								<Module>.FamANDAssem(ref text170, new object[]
								{
									'৴',
									"ॹࢡ",
									'㽡'
								});
								array32[num93] = text170;
								array32[(int)array[2]] = fld;
								this.DirectoryCopy(fromDir2, string.Concat(array32));
							}
						}
					}
					bool flag38 = text60 != "";
					if (flag38)
					{
						string[] array33 = new string[(97074 <= 178757) ? 5 : 721918];
						array33[0 / 157967485] = this.PathToFolder;
						int num94 = checked(528647 + -528646);
						string text171 = "뮱";
						<Module>.FamANDAssem(ref text171, new object[]
						{
							108,
							1093,
							"ಠᆳಔᦱ",
							false,
							27942,
							1406
						});
						array33[num94] = text171;
						array33[Convert.ToInt32("2", 8)] = this.resfold;
						int num95 = "̥.͈".Length;
						string text172 = "쬑";
						<Module>.FamANDAssem(ref text172, new object[]
						{
							9468,
							'ꙑ',
							false
						});
						array33[num95] = text172;
						char c12 = '\u0004';
						int num96 = (int)c12;
						string text173 = "䉝";
						<Module>.FamANDAssem(ref text173, new object[]
						{
							15401,
							'ى'
						});
						string oldValue72 = text173;
						string newValue22 = "ﴽ";
						<Module>.FamANDAssem(ref newValue22, new object[]
						{
							false,
							16431,
							18011,
							2844,
							25675,
							'ܢ'
						});
						array33[num96] = req.Replace(oldValue72, newValue22);
						bool flag39 = (Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array33)) ? 1 : 0) == checked((int)0L);
						if (flag39)
						{
							string[] array34 = new string["͍͇͍͎ͯ".Length];
							int num97;
							if (-97477 != -98904)
							{
								num97 = 0;
							}
							else
							{
								num97 = -9203;
							}
							array34[num97] = this.PathToFolder;
							int num98 = Convert.ToInt32("1", 2);
							string text174 = "";
							<Module>.FamANDAssem(ref text174, new object[]
							{
								false,
								"ǵ怠",
								"ĘŶ",
								"䶭ᱮᦪÜٟáǪ"
							});
							array34[num98] = text174;
							array34[array2[2]] = this.resfold;
							int num99 = 1253206980 / 417735660;
							string text175 = "宰";
							<Module>.FamANDAssem(ref text175, new object[]
							{
								"˝⊺ෑɼ",
								'☈'
							});
							array34[num99] = text175;
							int num100 = 162718 + -162714;
							string text176 = "珸";
							<Module>.FamANDAssem(ref text176, new object[]
							{
								4461,
								7835,
								"Ӆқਊྸ",
								8365
							});
							string oldValue73 = text176;
							string newValue23 = "垁";
							<Module>.FamANDAssem(ref newValue23, new object[]
							{
								8768,
								'⅔',
								5147
							});
							array34[num100] = req.Replace(oldValue73, newValue23);
							Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo7 = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(string.Concat(array34));
						}
						string[] array35 = new string[Marshal.SizeOf(typeof(__c__DisplayClass1_9))];
						int num101 = 0;
						array35[num101] = this.PathToFolder;
						int num102 = -804929 ^ -804930;
						string text177 = "´";
						<Module>.FamANDAssem(ref text177, new object[]
						{
							')',
							131,
							55,
							5
						});
						array35[num102] = text177;
						array35[Marshal.SizeOf(typeof(GetSafeWaitHandle))] = this.resfold;
						int num103 = checked((int)3L);
						string text178 = "쁟";
						<Module>.FamANDAssem(ref text178, new object[]
						{
							35742,
							"໧᪉ù׃²ç#",
							false,
							637
						});
						array35[num103] = text178;
						int num104 = 1331139744 / 332784936;
						string text179 = "";
						<Module>.FamANDAssem(ref text179, new object[]
						{
							11364,
							12453,
							2369,
							33911
						});
						string oldValue74 = text179;
						string newValue24 = "ퟸ";
						<Module>.FamANDAssem(ref newValue24, new object[]
						{
							50638,
							false,
							"ధΎFǸ\u0005\u0010"
						});
						array35[num104] = req.Replace(oldValue74, newValue24);
						int num105 = array2[4];
						string text180 = "⠾⠷⠐⠎⠮⠍⠅⠋⠌⠲⠃⠑⠑⡌⠖⠚⠖";
						<Module>.FamANDAssem(ref text180, new object[]
						{
							1064,
							2581,
							6072,
							621
						});
						array35[num105] = text180;
						Alphaleonis.Win32.Filesystem.File.AppendAllText(string.Concat(array35), text60);
						bool flag40 = ToolsWindow.sfl;
						if (flag40)
						{
							char c13 = '\u0006';
							string[] array36 = new string[(int)c13];
							array36[0 / 2137466074] = this.PathToFolder;
							int num106 = (-57838 >= -831621) ? 1 : 243956;
							string text181 = "↴";
							<Module>.FamANDAssem(ref text181, new object[]
							{
								645,
								6986,
								1049
							});
							array36[num106] = text181;
							array36[-2 * -1] = this.resfold;
							char c14 = '\u0003';
							int num107 = checked((int)c14);
							string text182 = "䲍";
							<Module>.FamANDAssem(ref text182, new object[]
							{
								13318,
								false,
								"«13\0\u0002\u0003",
								170,
								5901
							});
							array36[num107] = text182;
							int num108 = Convert.ToInt32("4", 16);
							string text183 = "쀨";
							<Module>.FamANDAssem(ref text183, new object[]
							{
								'䑎',
								"Ì\u0094ź\u0085",
								30810
							});
							string oldValue75 = text183;
							string newValue25 = "뭽";
							<Module>.FamANDAssem(ref newValue25, new object[]
							{
								36346,
								3462,
								"଻װїҸ ©L",
								450,
								706
							});
							array36[num108] = req.Replace(oldValue75, newValue25);
							int num109 = -478133 - -478138;
							string text184 = "ﬀ﬉אַאּ﬐דּכּוּגּ﬌﬽אָאָ";
							<Module>.FamANDAssem(ref text184, new object[]
							{
								'',
								122,
								'ౘ'
							});
							array36[num109] = text184;
							int num110 = Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array36)) ? 1 : 0;
							int num111 = 0;
							bool flag41 = num110 == num111;
							if (flag41)
							{
								string[] array37 = new string[<Module>.Tag[3]];
								array37[(int)array[0]] = this.PathToFolder;
								int num112;
								switch (0 * -194408)
								{
								case 0:
									num112 = 1;
									break;
								}
								int num113 = num112;
								string text185 = "୧";
								<Module>.FamANDAssem(ref text185, new object[]
								{
									"ਖ਼\u0014@%\r",
									"\u0002\u0003\u0004\u0004",
									'O'
								});
								array37[num113] = text185;
								array37[(-61425 != -91919) ? 2 : 157015] = this.resfold;
								int num114 = 53975 >> 14;
								string text186 = "ꓲ";
								<Module>.FamANDAssem(ref text186, new object[]
								{
									"鈪lǅĊ",
									'प',
									1567
								});
								array37[num114] = text186;
								int num115 = 4 | 4;
								string text187 = "܌";
								<Module>.FamANDAssem(ref text187, new object[]
								{
									false,
									"\u0005\u0001\u0002",
									'\t',
									'\u0095',
									false,
									1661
								});
								string oldValue76 = text187;
								string newValue26 = "杻";
								<Module>.FamANDAssem(ref newValue26, new object[]
								{
									2368,
									"\u000e,\b\u0005",
									1844,
									"ѱ\u000f.\u0015\u0002\t",
									'凌',
									false
								});
								array37[num115] = req.Replace(oldValue76, newValue26);
								int num116 = array2[4];
								string text188 = "鲔鲝鲺鲤鲄鲧鲯鲡鲦鲘鲩鲻鲻";
								<Module>.FamANDAssem(ref text188, new object[]
								{
									'Ӄ',
									10759,
									'䶔',
									"կݭê\u0003\0\u0006",
									4763
								});
								array37[num116] = text188;
								Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo8 = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(string.Concat(array37));
							}
							string[] array38 = new string[-411366 + 411372];
							int num117 = 0;
							array38[num117] = this.PathToFolder;
							int num118 = Marshal.SizeOf(typeof(TaskAsyncEnumerableExtensions));
							string text189 = "債";
							<Module>.FamANDAssem(ref text189, new object[]
							{
								false,
								1944,
								'䄵',
								2076
							});
							array38[num118] = text189;
							array38[sizeof(short)] = this.resfold;
							int num119 = 33409010 >> 23;
							string text190 = "㿈";
							<Module>.FamANDAssem(ref text190, new object[]
							{
								'㵹',
								33,
								false,
								"\u0095ċ*\u001d\a\u0004",
								8
							});
							array38[num119] = text190;
							int num120 = (int)4L;
							string text191 = "椻";
							<Module>.FamANDAssem(ref text191, new object[]
							{
								8427,
								10477,
								4515,
								'ಿ',
								218
							});
							string oldValue77 = text191;
							string newValue27 = "ꜰ";
							<Module>.FamANDAssem(ref newValue27, new object[]
							{
								false,
								10378,
								32404
							});
							array38[num120] = req.Replace(oldValue77, newValue27);
							int num121 = <Module>.Cgt[5];
							string text192 = "";
							<Module>.FamANDAssem(ref text192, new object[]
							{
								'ꯆ',
								13403
							});
							array38[num121] = text192;
							bool flag42 = Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array38));
							if (flag42)
							{
								string str21 = "";
								<Module>.FamANDAssem(ref str21, new object[]
								{
									"Ⱟ݋\a\u0016G\u0002\u0003",
									false,
									32330,
									'ᛧ',
									"ൺબàʿ"
								});
								string fromDir3 = foldercopy.Replace(foldername, str21 + fld);
								string[] array39 = new string[<Module>.Cgt[6]];
								array39[-55614 ^ -55614] = this.PathToFolder;
								int num122 = "͑".Length;
								string text193 = "㙭";
								<Module>.FamANDAssem(ref text193, new object[]
								{
									3892,
									false,
									9981
								});
								array39[num122] = text193;
								array39[Convert.ToInt32("2", 16)] = this.resfold;
								int num123 = Convert.ToInt32("11", 2);
								string text194 = "୭";
								<Module>.FamANDAssem(ref text194, new object[]
								{
									false,
									"<i\t\a",
									180,
									'S',
									2421
								});
								array39[num123] = text194;
								int num124 = 4;
								int num125 = num124;
								string text195 = "똑";
								<Module>.FamANDAssem(ref text195, new object[]
								{
									10516,
									3512,
									",Ơĺ\u0016\0\u0002",
									5089,
									"ᣫ◱⦗"
								});
								string oldValue78 = text195;
								string newValue28 = "䏥";
								<Module>.FamANDAssem(ref newValue28, new object[]
								{
									"̄Ȼݷ",
									892,
									'༨',
									9329
								});
								array39[num125] = req.Replace(oldValue78, newValue28);
								int num126 = Convert.ToInt32("5", 8);
								string text196 = "";
								<Module>.FamANDAssem(ref text196, new object[]
								{
									499,
									2250,
									'',
									734
								});
								array39[num126] = text196;
								int num127 = 6;
								array39[num127] = fld;
								this.DirectoryCopy(fromDir3, string.Concat(array39));
							}
						}
					}
					string text197 = "蔩蔯蔨蔸";
					<Module>.FamANDAssem(ref text197, new object[]
					{
						29412,
						4729
					});
					result = text197;
				}
				else
				{
					string text198 = "䅫䅬䅡䅾䅨";
					<Module>.FamANDAssem(ref text198, new object[]
					{
						"אϊ",
						'✞',
						'ၕ'
					});
					result = text198;
				}
			}
			catch (Exception ex)
			{
				string text199 = "";
				<Module>.FamANDAssem(ref text199, new object[]
				{
					51775,
					4465,
					1462
				});
				result = text199;
			}
			return result;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00021520 File Offset: 0x0001F720
		private string AutofillsSearcher(string link, string req, string filename, string foldername, string foldercopy, string fld)
		{
			char[] array = new char[]
			{
				'\u0001',
				'\0'
			};
			int[] array2 = new int[]
			{
				1,
				2
			};
			string result;
			try
			{
				List<string> list = new List<string>();
				List<string> list2 = new List<string>();
				string[] array3 = Alphaleonis.Win32.Filesystem.File.ReadAllLines(link);
				int i = checked(789866 - 789866);
				while (i < array3.Length)
				{
					string text = array3[i];
					string value = "";
					<Module>.FamANDAssem(ref value, new object[]
					{
						27033,
						33185
					});
					bool flag = text.Contains(value);
					if (flag)
					{
						string[] array4 = new string[(int)array[0]];
						int num = 0 * 489723;
						string text2 = "膵膵膥膥膦";
						<Module>.FamANDAssem(ref text2, new object[]
						{
							'\u0010',
							false,
							25819,
							200,
							'ᥩ',
							636
						});
						array4[num] = text2;
						string[] separator = array4;
						list.Add(array3[i].Split(separator, StringSplitOptions.None | StringSplitOptions.None)[886538 + -886538].Trim());
						list2.Add(array3[i].Split(separator, (StringSplitOptions)<Module>.Tag[1])[579734 + -579733].Trim());
					}
					string text3 = array3[i];
					string value2 = "륙륶륺륲뤭";
					<Module>.FamANDAssem(ref value2, new object[]
					{
						"\u0091ӓĦū4+\t",
						false,
						"ʡӟ₻௟",
						31904
					});
					if (text3.Contains(value2))
					{
						goto IL_261;
					}
					string text4 = array3[i];
					string value3 = "裣裬裠裨袗";
					<Module>.FamANDAssem(ref value3, new object[]
					{
						14942,
						20047
					});
					if (text4.Contains(value3))
					{
						goto IL_261;
					}
					string text5 = array3[i];
					string value4 = "ߧߎߓߌޛ";
					<Module>.FamANDAssem(ref value4, new object[]
					{
						4,
						49,
						107,
						"b÷ȆĢʀ"
					});
					if (text5.Contains(value4))
					{
						goto IL_261;
					}
					string text6 = array3[i];
					string value5 = "࠻࠲࠯࠰ࡇ";
					<Module>.FamANDAssem(ref value5, new object[]
					{
						1849,
						174,
						150
					});
					bool flag2 = text6.Contains(value5);
					IL_265:
					bool flag3 = flag2;
					if (flag3)
					{
						List<string> list3 = list;
						string text7 = array3[i];
						string oldValue = "聶聙聕聝耂";
						<Module>.FamANDAssem(ref oldValue, new object[]
						{
							354,
							"杝ੌÇ",
							7,
							false,
							'౟'
						});
						string text8 = text7.Replace(oldValue, "");
						string oldValue2 = "";
						<Module>.FamANDAssem(ref oldValue2, new object[]
						{
							42311,
							"૷❩غɍ"
						});
						string text9 = text8.Replace(oldValue2, "");
						string oldValue3 = "㣒㣻㣦㣹㢮";
						<Module>.FamANDAssem(ref oldValue3, new object[]
						{
							"᭷ᇈɫ¯eŗ֪",
							'Õ'
						});
						string text10 = text9.Replace(oldValue3, "");
						string oldValue4 = "螑螘螅螚蟭";
						<Module>.FamANDAssem(ref oldValue4, new object[]
						{
							false,
							21280,
							'㒷'
						});
						list3.Add(text10.Replace(oldValue4, ""));
					}
					string text11 = array3[i];
					string value6 = "잇자잝임잔쟫";
					<Module>.FamANDAssem(ref value6, new object[]
					{
						6405,
						8626,
						25965,
						10157
					});
					if (text11.Contains(value6))
					{
						goto IL_4A4;
					}
					string text12 = array3[i];
					string value7 = "鐮鐙鐔鐍鐝鑂";
					<Module>.FamANDAssem(ref value7, new object[]
					{
						false,
						33485,
						"цؖݏ"
					});
					if (text12.Contains(value7))
					{
						goto IL_4A4;
					}
					string text13 = array3[i];
					string value8 = "㲳㲂㲟㲓㳝";
					<Module>.FamANDAssem(ref value8, new object[]
					{
						'Ờ',
						3194,
						4497,
						false
					});
					if (text13.Contains(value8))
					{
						goto IL_4A4;
					}
					string text14 = array3[i];
					string value9 = "蠦蠷蠪蠦衈";
					<Module>.FamANDAssem(ref value9, new object[]
					{
						"⧵ၞἵ൴ᆒ",
						false,
						"ซ\u0080â\u0006Y\u0016\u0002"
					});
					bool flag4 = text14.Contains(value9);
					IL_4AA:
					bool flag5 = flag4;
					if (flag5)
					{
						List<string> list4 = list2;
						string text15 = array3[i];
						string oldValue5 = "⟵⟢⟯⟶⟦➙";
						<Module>.FamANDAssem(ref oldValue5, new object[]
						{
							false,
							3341,
							'᪖'
						});
						string text16 = text15.Replace(oldValue5, "");
						string oldValue6 = "❽❊❇❞❎✑";
						<Module>.FamANDAssem(ref oldValue6, new object[]
						{
							'ͅ',
							"\u001a\u0002\0\0\0\u0002",
							'᣷',
							'૑'
						});
						string text17 = text16.Replace(oldValue6, "");
						string oldValue7 = "괺괋괖괚굔";
						<Module>.FamANDAssem(ref oldValue7, new object[]
						{
							false,
							1081,
							"⮹˾ŒƵư",
							"ª䶖",
							913,
							9206
						});
						string text18 = text17.Replace(oldValue7, "");
						string oldValue8 = "曁曐曍曁暯";
						<Module>.FamANDAssem(ref oldValue8, new object[]
						{
							5834,
							11470,
							"ෳᔊ"
						});
						list4.Add(text18.Replace(oldValue8, ""));
					}
					i += 5 % 2;
					continue;
					IL_4A4:
					flag4 = (sizeof(sbyte) != 0);
					goto IL_4AA;
					IL_261:
					flag2 = (array2[0] != 0);
					goto IL_265;
				}
				bool flag6 = list.Count > Convert.ToInt32("0", 16);
				if (flag6)
				{
					string text19 = string.Empty;
					List<string> list5 = new List<string>();
					for (int j = 0 << 4; j < list.Count; j += 5 % 2)
					{
						bool flag7 = list[j].Contains(req);
						if (flag7)
						{
							List<string> list6 = list5;
							string text20 = list2[j];
							string oldValue9 = "驩騵";
							<Module>.FamANDAssem(ref oldValue9, new object[]
							{
								'ʗ',
								'靾'
							});
							list6.Add(text20.Replace(oldValue9, "").Trim());
						}
					}
					list5 = list5.Distinct<string>().ToList<string>();
					bool flag8 = list5.Count > Convert.ToInt32("0", 2);
					if (flag8)
					{
						for (int k = 0 | 0; k < list5.Count; k += Convert.ToInt32("1", 16))
						{
							string text21 = list5[k];
							string value10 = "稠稻稾稻稺稢稻";
							<Module>.FamANDAssem(ref value10, new object[]
							{
								"഻₎ᯓড",
								10040
							});
							bool flag9 = (text21.Contains(value10) ? 1 : 0) == string.Empty.Length;
							if (flag9)
							{
								bool flag10 = list5[k] != "";
								if (flag10)
								{
									string str = text19;
									string str2 = list5[k];
									string str3 = "얼얻";
									<Module>.FamANDAssem(ref str3, new object[]
									{
										10854,
										false,
										2725,
										6687,
										30343
									});
									text19 = str + str2 + str3;
									int num2 = this.cookiesCounter;
									char c = '\u0001';
									this.cookiesCounter = num2 + checked((int)c);
								}
							}
						}
						bool flag11 = text19 != "";
						if (flag11)
						{
							int num3;
							switch (-509921)
							{
							case -509921:
								num3 = 5;
								break;
							case -509920:
								num3 = -828162;
								break;
							case -509919:
								num3 = 709684;
								break;
							case -509918:
								num3 = 595932;
								break;
							}
							string[] array5 = new string[num3];
							string[] array7;
							checked
							{
								array5[-723687 + 723687] = this.PathToFolder;
								int num4 = array2[0];
								string text22 = "༌";
								<Module>.FamANDAssem(ref text22, new object[]
								{
									false,
									1059,
									2861
								});
								array5[num4] = text22;
								array5[1 << 1] = this.resfold;
								int num5 = -200376 + 200379;
								string text23 = "큥";
								<Module>.FamANDAssem(ref text23, new object[]
								{
									"౸ݖ",
									23187,
									23020,
									'ؤ',
									false,
									456
								});
								array5[num5] = text23;
								char c2 = '\u0004';
								array5[(int)c2] = req;
								bool flag12 = (Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array5)) ? '\u0001' : '\0') == array[1];
								if (flag12)
								{
									string[] array6 = new string[5 * 1];
									array6[Convert.ToInt32("0", 8)] = this.PathToFolder;
									int num6 = 2190973 >> 21;
									string text24 = "楉";
									<Module>.FamANDAssem(ref text24, new object[]
									{
										7344,
										182,
										19375
									});
									array6[num6] = text24;
									array6[ToolsWindow.Handle] = this.resfold;
									int num7 = -167927 - -167930;
									string text25 = "쟂";
									<Module>.FamANDAssem(ref text25, new object[]
									{
										"⃩䔑፤",
										15740,
										false,
										4292
									});
									array6[num7] = text25;
									array6[Convert.ToInt32("4", 16)] = req;
									Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(string.Concat(array6));
								}
								array7 = new string[Convert.ToInt32("11", 8)];
								array7[(int)array[1]] = this.PathToFolder;
							}
							int num8 = (int)1L;
							string text26 = "毈";
							<Module>.FamANDAssem(ref text26, new object[]
							{
								18852,
								8688
							});
							array7[num8] = text26;
							array7[123719 ^ 123717] = this.resfold;
							int num9 = <Module>.Cgt[4];
							string text27 = "%";
							<Module>.FamANDAssem(ref text27, new object[]
							{
								true,
								"K\f\t\u0005",
								3,
								16
							});
							array7[num9] = text27;
							array7[(-6056 > -753346) ? 4 : 272755] = req;
							int num10 = Convert.ToInt32("5", 8);
							string text28 = "྘";
							<Module>.FamANDAssem(ref text28, new object[]
							{
								679,
								false,
								1638,
								624,
								'ч'
							});
							array7[num10] = text28;
							int num11 = 528304 + -528298;
							string oldValue10 = "毵";
							<Module>.FamANDAssem(ref oldValue10, new object[]
							{
								22788,
								"ȻğÁÍ",
								3517
							});
							array7[num11] = foldername.Replace(oldValue10, "");
							int num12 = <Module>.Cgt[6];
							string text29 = "碃";
							<Module>.FamANDAssem(ref text29, new object[]
							{
								20,
								1461,
								68,
								29232,
								159
							});
							array7[num12] = text29;
							array7[checked(-8 * -1)] = filename;
							Alphaleonis.Win32.Filesystem.File.AppendAllText(string.Concat(array7), text19);
							bool flag13 = ToolsWindow.sfl;
							if (flag13)
							{
								string[] array8 = new string[Convert.ToInt32("101", 2)];
								char c3 = '\0';
								array8[checked((int)c3)] = this.PathToFolder;
								int num13 = 0 | 1;
								string text30 = "슟";
								<Module>.FamANDAssem(ref text30, new object[]
								{
									false,
									24393,
									'捺'
								});
								array8[num13] = text30;
								array8[array2[1]] = this.resfold;
								int num14 = Convert.ToInt32("11", 2);
								string text31 = "춁";
								<Module>.FamANDAssem(ref text31, new object[]
								{
									false,
									6334,
									2291,
									11881,
									32195
								});
								array8[num14] = text31;
								array8[-437026 + 437030] = req;
								bool flag14 = (Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array8)) ? 1 : 0) == (-345014 ^ -345014);
								if (flag14)
								{
									string[] array9 = new string[(-97675 <= -523035) ? -309000 : 5];
									int num15;
									if (34690 == 34690)
									{
										num15 = 0;
									}
									else
									{
										num15 = -256954;
									}
									array9[num15] = this.PathToFolder;
									int num16;
									if (-28928 > 232764)
									{
										num16 = 792197;
									}
									else
									{
										num16 = 1;
									}
									int num17 = num16;
									string text32 = "鯮";
									<Module>.FamANDAssem(ref text32, new object[]
									{
										37602,
										2256
									});
									array9[num17] = text32;
									array9[10 % 4] = this.resfold;
									int num18 = 3 & 3;
									string text33 = "矌";
									<Module>.FamANDAssem(ref text33, new object[]
									{
										15589,
										'ʋ',
										"᛬ঈ૊ೢ"
									});
									array9[num18] = text33;
									array9[~-5] = req;
									Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo2 = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(string.Concat(array9));
								}
								string[] array10 = new string["̼̫ͬ̾ͥ".Length];
								array10[0 % 978069] = this.PathToFolder;
								int num19 = 923505 - 923504;
								string text34 = "Ứ";
								<Module>.FamANDAssem(ref text34, new object[]
								{
									false,
									111,
									1233,
									3506,
									1078,
									'ތ'
								});
								array10[num19] = text34;
								array10[-811236 + 811238] = this.resfold;
								int num20 = "̔̉̕".Length;
								string text35 = "瘳";
								<Module>.FamANDAssem(ref text35, new object[]
								{
									21252,
									7523,
									1544
								});
								array10[num20] = text35;
								array10[Marshal.SizeOf(typeof(RuntimeEventInfo))] = req;
								bool flag15 = Alphaleonis.Win32.Filesystem.Directory.Exists(string.Concat(array10));
								if (flag15)
								{
									string str4 = "㮚";
									<Module>.FamANDAssem(ref str4, new object[]
									{
										32,
										'ⷛ',
										"ധI;\u001d\u0001\0\u0002"
									});
									string fromDir = foldercopy.Replace(foldername, str4 + fld);
									string[] array11 = new string[Convert.ToInt32("7", 8)];
									array11[0 << 30] = this.PathToFolder;
									int num21 = -403678 - -403679;
									string text36 = "ﲇ";
									<Module>.FamANDAssem(ref text36, new object[]
									{
										6594,
										13281,
										876,
										"἞睊೪ТŝÅȶ"
									});
									array11[num21] = text36;
									char c4 = '\u0002';
									array11[checked((int)c4)] = this.resfold;
									int num22 = Convert.ToInt32("3", 16);
									string text37 = "蛦";
									<Module>.FamANDAssem(ref text37, new object[]
									{
										"઴ʠ䁋ǜ৔ǁn",
										false,
										11068
									});
									array11[num22] = text37;
									array11[Marshal.SizeOf(typeof(RuntimeEventInfo))] = req;
									int num23 = (int)5L;
									string text38 = "餬";
									<Module>.FamANDAssem(ref text38, new object[]
									{
										25516,
										"ť⤆ɸϨӹ",
										false
									});
									array11[num23] = text38;
									array11[1399396374 / 233232729] = fld;
									this.DirectoryCopy(fromDir, string.Concat(array11));
								}
							}
						}
					}
					string text39 = "蛬蛪蛭蛽";
					<Module>.FamANDAssem(ref text39, new object[]
					{
						14950,
						'䰲'
					});
					result = text39;
				}
				else
				{
					string text40 = "훁훆훋훔훂";
					<Module>.FamANDAssem(ref text40, new object[]
					{
						26633,
						false,
						'已',
						'Ⴌ'
					});
					result = text40;
				}
			}
			catch (Exception ex)
			{
				string text41 = "럵럲럿럠럶";
				<Module>.FamANDAssem(ref text41, new object[]
				{
					"⛑ņM%J",
					963,
					23595,
					3334,
					8652
				});
				result = text41;
			}
			return result;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000226A4 File Offset: 0x000208A4
		private string CreditCardSearcher(string link, string filename, string foldername, string foldercopy, string fld, string filenamedel)
		{
			char[] array = new char[]
			{
				'\u0001',
				'\0'
			};
			string result;
			try
			{
				string empty = string.Empty;
				List<string> list = new List<string>();
				List<string> list2 = new List<string>();
				List<string> list3 = new List<string>();
				string[] array2 = Alphaleonis.Win32.Filesystem.File.ReadAllLines(link);
				int i = checked(0 * -237929);
				while (i < array2.Length)
				{
					string text = array2[i];
					string value = "";
					<Module>.FamANDAssem(ref value, new object[]
					{
						19302,
						"䜇ޅɻ¯ě",
						16797,
						4992
					});
					bool flag = text.Contains(value);
					if (flag)
					{
						string[] array3 = new string[sizeof(sbyte)];
						int num = Convert.ToInt32("0", 2);
						string text2 = "멷멷멧멧멤";
						<Module>.FamANDAssem(ref text2, new object[]
						{
							'錛',
							6217,
							'໶',
							false
						});
						array3[num] = text2;
						string[] array4 = array3;
						List<string> list4 = list;
						string text3 = array2[i];
						string[] separator = array4;
						char c = '\0';
						list4.Add(text3.Split(separator, checked((StringSplitOptions)c))[Convert.ToInt32("0", 16)].Trim());
						List<string> list5 = list2;
						string[] array5 = array2[i].Split(array4, ~(StringSplitOptions)(-1));
						char c2 = '\u0001';
						list5.Add(array5[(int)c2].Trim());
					}
					string text4 = array2[i];
					string value2 = "臑臶臵臽臼臫膣";
					<Module>.FamANDAssem(ref value2, new object[]
					{
						"̂̀\u0099y",
						"ᥡš?*",
						24086,
						'ń'
					});
					if (text4.Contains(value2))
					{
						goto IL_265;
					}
					string text5 = array2[i];
					string value3 = "߇߀߃ߋߊߝ޵";
					<Module>.FamANDAssem(ref value3, new object[]
					{
						673,
						208,
						1003,
						")\0\u0004\u0006"
					});
					if (text5.Contains(value3))
					{
						goto IL_265;
					}
					string text6 = array2[i];
					string value4 = "谩谆谊谂豝";
					<Module>.FamANDAssem(ref value4, new object[]
					{
						'㟲',
						21621
					});
					if (text6.Contains(value4))
					{
						goto IL_265;
					}
					string text7 = array2[i];
					string value5 = "엤엫엧엯얐";
					<Module>.FamANDAssem(ref value5, new object[]
					{
						2136,
						'뵒'
					});
					bool flag2 = text7.Contains(value5);
					IL_26B:
					bool flag3 = flag2;
					if (flag3)
					{
						List<string> list6 = list;
						string text8 = array2[i];
						string oldValue = "떠떇떄떌떍떚뗒";
						<Module>.FamANDAssem(ref oldValue, new object[]
						{
							5672,
							5572,
							false,
							2368,
							'⼛',
							20897
						});
						string text9 = text8.Replace(oldValue, "");
						string oldValue2 = "뺱뺶뺵뺽뺼뺫뻃";
						<Module>.FamANDAssem(ref oldValue2, new object[]
						{
							9876,
							'ᬵ',
							25584,
							5946,
							false,
							'Ȇ'
						});
						string text10 = text9.Replace(oldValue2, "");
						string oldValue3 = "࿘࿷࿻࿳ྫྷ";
						<Module>.FamANDAssem(ref oldValue3, new object[]
						{
							1692,
							1800,
							191,
							33,
							"Í@\u0003\0\u0002",
							false
						});
						string text11 = text10.Replace(oldValue3, "");
						string oldValue4 = "";
						<Module>.FamANDAssem(ref oldValue4, new object[]
						{
							'ච',
							'ᫍ',
							false,
							'뤯'
						});
						list6.Add(text11.Replace(oldValue4, ""));
					}
					string text12 = array2[i];
					string value6 = "嚧嚅嚖嚀回";
					<Module>.FamANDAssem(ref value6, new object[]
					{
						6528,
						15716
					});
					if (text12.Contains(value6))
					{
						goto IL_552;
					}
					string text13 = array2[i];
					string value7 = "罢罠罳罥缛";
					<Module>.FamANDAssem(ref value7, new object[]
					{
						'᝝',
						4993,
						"ᇤᶪ_>\u0011\u0001\a",
						9215
					});
					if (text13.Contains(value7))
					{
						goto IL_552;
					}
					string text14 = array2[i];
					string value8 = "겧겜겄겋게겛곓";
					<Module>.FamANDAssem(ref value8, new object[]
					{
						6050,
						11697,
						"↼Ģ܊О7ű",
						"‑ഩΈȘǳ\"˹"
					});
					if (text14.Contains(value8))
					{
						goto IL_552;
					}
					string text15 = array2[i];
					string value9 = "";
					<Module>.FamANDAssem(ref value9, new object[]
					{
						'ē',
						'ࣧ',
						19433,
						21717,
						19841
					});
					bool flag4 = text15.Contains(value9);
					IL_557:
					bool flag5 = flag4;
					if (flag5)
					{
						List<string> list7 = list2;
						string text16 = array2[i];
						string oldValue5 = "똓똱똢똴뙪";
						<Module>.FamANDAssem(ref oldValue5, new object[]
						{
							false,
							13628,
							'脔'
						});
						string text17 = text16.Replace(oldValue5, "");
						string oldValue6 = "氉氋氘氎汰";
						<Module>.FamANDAssem(ref oldValue6, new object[]
						{
							9767,
							17955
						});
						string text18 = text17.Replace(oldValue6, "");
						string oldValue7 = "ᗞᗥᗽᗲᗵᗢᖪ";
						<Module>.FamANDAssem(ref oldValue7, new object[]
						{
							'ྍ',
							1539
						});
						string text19 = text18.Replace(oldValue7, "");
						string oldValue8 = "␸␣␻␴␳␤⑌";
						<Module>.FamANDAssem(ref oldValue8, new object[]
						{
							false,
							7320,
							2014
						});
						list7.Add(text19.Replace(oldValue8, ""));
					}
					string text20 = array2[i];
					string value10 = "涜涡涩涰涫涼淣";
					<Module>.FamANDAssem(ref value10, new object[]
					{
						24927,
						905,
						'Ä',
						"֖ȷ;",
						37
					});
					if (text20.Contains(value10))
					{
						goto IL_898;
					}
					string text21 = array2[i];
					string value11 = "炕炈炀炙炂炕烪";
					<Module>.FamANDAssem(ref value11, new object[]
					{
						555,
						'\u0097',
						false,
						3129,
						"つみ",
						242
					});
					if (text21.Contains(value11))
					{
						goto IL_898;
					}
					string text22 = array2[i];
					string value12 = "㷒㷯㷧㶭";
					<Module>.FamANDAssem(ref value12, new object[]
					{
						false,
						670,
						'प',
						4936,
						"្\"ͺ",
						'̙'
					});
					if (text22.Contains(value12))
					{
						goto IL_898;
					}
					string text23 = array2[i];
					string value13 = "厗厊厂叨";
					<Module>.FamANDAssem(ref value13, new object[]
					{
						778,
						2647,
						14704,
						false,
						3304,
						25
					});
					if (text23.Contains(value13))
					{
						goto IL_898;
					}
					string text24 = array2[i];
					string value14 = "顠顠頂顴顴頗";
					<Module>.FamANDAssem(ref value14, new object[]
					{
						38796,
						"/P \0\0\0\u0002",
						false
					});
					if (text24.Contains(value14))
					{
						goto IL_898;
					}
					string text25 = array2[i];
					string value15 = "⧵⧈⧀⧙⧂⧑⧄⧙⧟⧞⦊";
					<Module>.FamANDAssem(ref value15, new object[]
					{
						3308,
						"۱\u0013\u0019\u0001\n",
						"-лӔֳڭ",
						false
					});
					bool flag6 = text25.Contains(value15);
					IL_89C:
					bool flag7 = flag6;
					if (flag7)
					{
						List<string> list8 = list3;
						string text26 = array2[i];
						string oldValue9 = "䑀䑽䑵䑬䑷䑠䐿";
						<Module>.FamANDAssem(ref oldValue9, new object[]
						{
							595,
							866,
							44,
							3606,
							12302
						});
						string text27 = text26.Replace(oldValue9, "");
						string oldValue10 = "㋶㋫㋣㋺㋡㋶㊉";
						<Module>.FamANDAssem(ref oldValue10, new object[]
						{
							1207,
							3417,
							5934,
							'ॵ'
						});
						string text28 = text27.Replace(oldValue10, "");
						string oldValue11 = "ܴ܉܁݋";
						<Module>.FamANDAssem(ref oldValue11, new object[]
						{
							"\u0095F\u007f8",
							709,
							646,
							"j\b\u0018\u0004\u0003\u0003"
						});
						string text29 = text28.Replace(oldValue11, "");
						string oldValue12 = "␍␐␘⑲";
						<Module>.FamANDAssem(ref oldValue12, new object[]
						{
							9052,
							2,
							'\f',
							'Þ'
						});
						string text30 = text29.Replace(oldValue12, "");
						string oldValue13 = "觚觚覸觎觎覭";
						<Module>.FamANDAssem(ref oldValue13, new object[]
						{
							9756,
							false,
							24815,
							652
						});
						string text31 = text30.Replace(oldValue13, "");
						string oldValue14 = "됝될됨됱됪됹됬됱됷됶둢";
						<Module>.FamANDAssem(ref oldValue14, new object[]
						{
							42339,
							28,
							'ǽ',
							"ɉ֙Ӻ",
							false
						});
						list8.Add(text31.Replace(oldValue14, ""));
					}
					i += 623577 + -623576;
					continue;
					IL_898:
					flag6 = (array[0] != '\0');
					goto IL_89C;
					IL_552:
					int num2 = 1;
					flag4 = (num2 != 0);
					goto IL_557;
					IL_265:
					char c3 = '\u0001';
					flag2 = ((int)c3 != 0);
					goto IL_26B;
				}
				bool flag8 = list2.Count > (0 | 0);
				if (flag8)
				{
					string text32 = string.Empty;
					List<string> list9 = new List<string>();
					for (int j = 1 & 0; j < list2.Count; j += checked(1 * 1))
					{
						List<string> list10 = list9;
						string[] array6 = new string[checked(-479619 - -479624)];
						array6[Convert.ToInt32("0", 2)] = list2[j].Trim();
						int zeroFreeGlobalAllocAnsi = ToolsWindow.ZeroFreeGlobalAllocAnsi;
						string text33 = "㇔";
						<Module>.FamANDAssem(ref text33, new object[]
						{
							'✾',
							2391,
							275,
							false
						});
						array6[zeroFreeGlobalAllocAnsi] = text33;
						array6[Convert.ToInt32("2", 16)] = list3[j].Trim();
						int num3 = 1699090 >> 19;
						string text34 = "쏴";
						<Module>.FamANDAssem(ref text34, new object[]
						{
							8443,
							2069,
							22598,
							16946
						});
						array6[num3] = text34;
						int num4;
						if (-75202 < -721458)
						{
							num4 = 363329;
						}
						else
						{
							num4 = 4;
						}
						array6[num4] = list[j].Trim();
						list10.Add(string.Concat(array6));
					}
					list9 = list9.Distinct<string>().ToList<string>();
					bool flag9 = list9.Count > 0 * -632574;
					if (flag9)
					{
						for (int k = 0 / 453808090; k < list9.Count; k += ToolsWindow.ZeroFreeGlobalAllocAnsi)
						{
							bool flag10 = list9[k] != "";
							if (flag10)
							{
								string str = text32;
								string text35 = "甥甥甥";
								<Module>.FamANDAssem(ref text35, new object[]
								{
									448,
									'N',
									29213,
									257,
									false
								});
								string str2 = text35;
								string str3 = list9[k];
								string str4 = "ᮡᮦ";
								<Module>.FamANDAssem(ref str4, new object[]
								{
									false,
									'ᝃ',
									'ѩ'
								});
								text32 = str + str2 + str3 + str4;
								this.cookiesCounter += 3 >> 1;
							}
						}
						string text36 = string.Empty;
						string empty2 = string.Empty;
						string[] array7 = new string[sizeof(bool)];
						int num5 = 0 / 1660210099;
						string text37 = "殄";
						<Module>.FamANDAssem(ref text37, new object[]
						{
							1508,
							26132
						});
						array7[num5] = text37;
						string[] array8 = array7;
						string text38 = "솦솳솳솹솦솳솦솹솆솓솓솹솆솓솆";
						<Module>.FamANDAssem(ref text38, new object[]
						{
							"ෛɾĩ:!",
							"߷čƅXö\t\u0015",
							'駦',
							false,
							2573
						});
						string text39 = text38;
						string text40 = text39;
						string[] separator2 = array8;
						char c4 = '\u0001';
						string[] array9 = text40.Split(separator2, (StringSplitOptions)c4);
						List<string> FormsList = new List<string>();
						string value16 = "濷濩濄濄濷濫濫濷濄濁濛濜澆濜濐濜";
						<Module>.FamANDAssem(ref value16, new object[]
						{
							'㺻',
							'́',
							false,
							11692
						});
						bool flag11 = filename.Contains(value16);
						if (flag11)
						{
							string str5 = "蘚蘙蘇蘪蘪蘀蘩蘴蘫蘵蘙蘪蘯蘵蘲虨蘲蘾蘲";
							<Module>.FamANDAssem(ref str5, new object[]
							{
								4409,
								false,
								28743,
								225,
								459,
								'Ț'
							});
							bool flag12 = Alphaleonis.Win32.Filesystem.File.Exists(filenamedel + str5);
							if (flag12)
							{
								List<string> formsList = FormsList;
								string str6 = "⺩⺪⺴⺙⺙⺳⺚⺇⺘⺆⺪⺙⺜⺆⺁⻛⺁⺍⺁";
								<Module>.FamANDAssem(ref str6, new object[]
								{
									'ⷮ',
									false,
									'Q',
									182
								});
								formsList.Add(filenamedel + str6);
							}
						}
						string value17 = "\udd7d\udd4c\udd5b\udd5a\udd57\udd4a\udd7d\udd5f\udd4c\udd5a\udd4d";
						<Module>.FamANDAssem(ref value17, new object[]
						{
							51605,
							'Ꭹ',
							false
						});
						bool flag13 = filenamedel.Contains(value17);
						if (flag13)
						{
							string text41 = "";
							<Module>.FamANDAssem(ref text41, new object[]
							{
								'䰻',
								"尦ࢩ⥉ʣ࣐"
							});
							string oldValue15 = text41;
							string newValue = "ྼྈྉྒྛྔྑྑྎ";
							<Module>.FamANDAssem(ref newValue, new object[]
							{
								false,
								"\u001a\0\0\u0002",
								2,
								false,
								false,
								4063
							});
							bool flag14 = Alphaleonis.Win32.Filesystem.Directory.Exists(filenamedel.Replace(oldValue15, newValue));
							if (flag14)
							{
								string text42 = "미믉믞믟믒믏미믚믉믟믈";
								<Module>.FamANDAssem(ref text42, new object[]
								{
									4093,
									4975,
									8452,
									15584,
									false,
									14955
								});
								string oldValue16 = text42;
								string newValue2 = "שּﭽﭼﭧﭮﭡﭤﭤﭻ";
								<Module>.FamANDAssem(ref newValue2, new object[]
								{
									58787,
									'Ơ',
									5061
								});
								string path = filenamedel.Replace(oldValue16, newValue2);
								string searchPattern = "⸽⸹⸽";
								<Module>.FamANDAssem(ref searchPattern, new object[]
								{
									false,
									6000,
									"לࠡɐя.Qƌ"
								});
								List<string> list11 = Alphaleonis.Win32.Filesystem.Directory.GetFiles(path, searchPattern, (SearchOption)Convert.ToInt32("1", 8)).Where(delegate(string s)
								{
									string value29 = "㜲㝨㝤㝨";
									<Module>.FamANDAssem(ref value29, new object[]
									{
										1902,
										'⾮'
									});
									return s.EndsWith(value29);
								}).ToList<string>();
								bool flag15 = list11.Count > -300424 + 300424;
								if (flag15)
								{
									list11.ForEach(delegate(string el)
									{
										FormsList.Add(el);
									});
								}
							}
						}
						string value18 = "쌠쌐쌍쌕쌑쌇쌐쌑";
						<Module>.FamANDAssem(ref value18, new object[]
						{
							'隌',
							'࠘',
							"п̹T_\t\a",
							false,
							'ᲃ'
						});
						bool flag16 = filenamedel.Contains(value18);
						if (flag16)
						{
							bool flag17 = Alphaleonis.Win32.Filesystem.Directory.Exists(filenamedel);
							if (flag17)
							{
								string text43 = "宔寸寑富寓寍宔";
								<Module>.FamANDAssem(ref text43, new object[]
								{
									1521,
									174,
									"႑᠞",
									false,
									'⩱',
									"ģ(u\f)\n"
								});
								string searchPattern2 = text43;
								char c5 = '\u0001';
								List<string> list12 = Alphaleonis.Win32.Filesystem.Directory.GetFiles(filenamedel, searchPattern2, (SearchOption)c5).Where(delegate(string s)
								{
									string value29 = "㜬㝶㝺㝶";
									<Module>.FamANDAssem(ref value29, new object[]
									{
										397,
										false,
										4680,
										244,
										7406,
										1355
									});
									return s.EndsWith(value29);
								}).ToList<string>();
								bool flag18 = list12.Count > 0 / 2023922775;
								if (flag18)
								{
									list12.ForEach(delegate(string el)
									{
										FormsList.Add(el);
									});
								}
								string searchPattern3 = "ꆣꇈꇼꇽꇦꇏꇠꇥꇥꆣ";
								<Module>.FamANDAssem(ref searchPattern3, new object[]
								{
									'ᅐ',
									"ᢏޗஔɼ!\0\u0002",
									"㡽ɇɹ",
									5021,
									"\u000eჸ"
								});
								List<string> list13 = Alphaleonis.Win32.Filesystem.Directory.GetFiles(filenamedel, searchPattern3, (SearchOption)ToolsWindow.Utf8SequenceLength).Where(delegate(string s)
								{
									string value29 = "융읯읣읯";
									<Module>.FamANDAssem(ref value29, new object[]
									{
										19254,
										false,
										31717
									});
									return s.EndsWith(value29);
								}).ToList<string>();
								bool flag19 = list13.Count > -759577 + 759577;
								if (flag19)
								{
									list13.ForEach(delegate(string el)
									{
										FormsList.Add(el);
									});
								}
							}
						}
						string[] array10 = FormsList.Distinct<string>().ToArray<string>();
						List<string> list14 = new List<string>();
						List<string> list15 = new List<string>();
						bool flag20 = array10.Length > ToolsWindow.Utf8SequenceLength;
						if (flag20)
						{
							string[] array11 = array10;
							for (int l = (int)array[1]; l < array11.Length; l += <Module>.Tag[0])
							{
								string path2 = array11[l];
								string[] array12 = Alphaleonis.Win32.Filesystem.File.ReadAllLines(path2);
								int m = ToolsWindow.Utf8SequenceLength;
								while (m < array12.Length)
								{
									string text44 = array12[m];
									string value19 = "ૺૺ૪૪૩";
									<Module>.FamANDAssem(ref value19, new object[]
									{
										782,
										1993
									});
									bool flag21 = text44.Contains(value19);
									if (flag21)
									{
										string[] array13 = new string[1 * 1];
										int num6 = ~-1;
										string text45 = "ᐉᐉᐙᐙᐚ";
										<Module>.FamANDAssem(ref text45, new object[]
										{
											'າ',
											66,
											1328
										});
										array13[num6] = text45;
										string[] array14 = array13;
										list14.Add(array12[m].Split(array14, (StringSplitOptions)(-495264) + 495264)[0 % -537533].Trim());
										List<string> list16 = list15;
										string text46 = array12[m];
										string[] separator3 = array14;
										int options;
										if (45448 < 91573)
										{
											options = 0;
										}
										else
										{
											options = -172593;
										}
										list16.Add(text46.Split(separator3, (StringSplitOptions)options)[562427609 / 562427609].Trim());
									}
									string text47 = array12[m];
									string value20 = "청첂첎첆쳙";
									<Module>.FamANDAssem(ref value20, new object[]
									{
										'͉',
										8064,
										8456,
										'蓭',
										1061
									});
									if (text47.Contains(value20))
									{
										goto IL_15DD;
									}
									string text48 = array12[m];
									string value21 = "뜳뜼뜰뜸띇";
									<Module>.FamANDAssem(ref value21, new object[]
									{
										"ᄑƧū⢇",
										'竓'
									});
									if (text48.Contains(value21))
									{
										goto IL_15DD;
									}
									string text49 = array12[m];
									string value22 = "ꞆꞯꞲꞭꟺ";
									<Module>.FamANDAssem(ref value22, new object[]
									{
										40835,
										"<\0\0\u0002",
										2047
									});
									if (text49.Contains(value22))
									{
										goto IL_15DD;
									}
									string text50 = array12[m];
									string value23 = "괉관괝괂굵";
									<Module>.FamANDAssem(ref value23, new object[]
									{
										30089,
										7017,
										7261,
										false
									});
									bool flag22 = text50.Contains(value23);
									IL_15E7:
									bool flag23 = flag22;
									if (flag23)
									{
										List<string> list17 = list14;
										string text51 = array12[m];
										string oldValue17 = "\udcb2\udc9d\udc91\udc99\udcc6";
										<Module>.FamANDAssem(ref oldValue17, new object[]
										{
											44247,
											1035,
											2522,
											false,
											"ʿ\u0090\a\b",
											7906
										});
										string text52 = text51.Replace(oldValue17, "");
										string oldValue18 = "꣐꣟꣓꣛ꢤ";
										<Module>.FamANDAssem(ref oldValue18, new object[]
										{
											3479,
											"᾽৔",
											29046
										});
										string text53 = text52.Replace(oldValue18, "");
										string oldValue19 = "쬞쬷쬪쬵쭢";
										<Module>.FamANDAssem(ref oldValue19, new object[]
										{
											'ደ',
											37082,
											10126
										});
										string text54 = text53.Replace(oldValue19, "");
										string oldValue20 = "輻輲輯輰轇";
										<Module>.FamANDAssem(ref oldValue20, new object[]
										{
											28637,
											8096
										});
										list17.Add(text54.Replace(oldValue20, ""));
									}
									string text55 = array12[m];
									string value24 = "鉐鉇鉊鉓鉃鈼";
									<Module>.FamANDAssem(ref value24, new object[]
									{
										18532,
										18850
									});
									if (text55.Contains(value24))
									{
										goto IL_1834;
									}
									string text56 = array12[m];
									string value25 = "鶯鶘鶕鶌鶜鷃";
									<Module>.FamANDAssem(ref value25, new object[]
									{
										false,
										'帬',
										16333
									});
									if (text56.Contains(value25))
									{
										goto IL_1834;
									}
									string text57 = array12[m];
									string value26 = "ଶଇଚଖ୘";
									<Module>.FamANDAssem(ref value26, new object[]
									{
										12,
										2902
									});
									if (text57.Contains(value26))
									{
										goto IL_1834;
									}
									string text58 = array12[m];
									string value27 = "杆杗杊杆木";
									<Module>.FamANDAssem(ref value27, new object[]
									{
										false,
										'䷇',
										6475
									});
									bool flag24 = text58.Contains(value27);
									IL_183E:
									bool flag25 = flag24;
									if (flag25)
									{
										List<string> list18 = list15;
										string text59 = array12[m];
										string oldValue21 = "\ude04\ude13\ude1e\ude07\ude17\ude68";
										<Module>.FamANDAssem(ref oldValue21, new object[]
										{
											'Ј',
											false,
											38472,
											7768,
											'᥊',
											3168
										});
										string text60 = text59.Replace(oldValue21, "");
										string oldValue22 = "ࡧࡐ࡝ࡄࡔࠋ";
										<Module>.FamANDAssem(ref oldValue22, new object[]
										{
											74,
											'չ',
											28,
											"ĬÈ",
											94
										});
										string text61 = text60.Replace(oldValue22, "");
										string oldValue23 = "홋홺홧홫혥";
										<Module>.FamANDAssem(ref oldValue23, new object[]
										{
											50614,
											false,
											4201
										});
										string text62 = text61.Replace(oldValue23, "");
										string oldValue24 = "Տ՞ՃՏԡ";
										<Module>.FamANDAssem(ref oldValue24, new object[]
										{
											'\u009a',
											1153
										});
										list18.Add(text62.Replace(oldValue24, ""));
									}
									m += checked(1 * 1);
									continue;
									IL_1834:
									checked
									{
										flag24 = ((int)1L != 0);
										goto IL_183E;
										IL_15DD:
										flag22 = ((int)1L != 0);
										goto IL_15E7;
									}
								}
								bool flag26 = list14.Count > 0 * 537423;
								if (flag26)
								{
									List<string> list19 = new List<string>();
									for (int n = 0 * 652078; n < list14.Count; n += Convert.ToInt32("1", 16))
									{
										int num7 = 0;
										for (int num8 = num7; num8 < array9.Length; num8 += "̢".Length)
										{
											bool flag27 = list14[n].Contains(array9[num8]);
											if (flag27)
											{
												List<string> list20 = list19;
												string text63 = list15[n];
												string oldValue25 = "ᡜ᠀";
												<Module>.FamANDAssem(ref oldValue25, new object[]
												{
													"פj(",
													false,
													"ҏŭ\u0003\0\u0001\0\u0002",
													2984
												});
												list20.Add(text63.Replace(oldValue25, "").Trim());
											}
										}
									}
									list19 = list19.Distinct<string>().ToList<string>();
									int count = list19.Count;
									int num9;
									if (-70774 != -82277)
									{
										num9 = 0;
									}
									else
									{
										num9 = 365550;
									}
									bool flag28 = count > num9;
									if (flag28)
									{
										int num11;
										char c6;
										for (int num10 = 0 << 12; num10 < list19.Count; num10 = num11 + (int)c6)
										{
											string text64 = list19[num10];
											string value28 = "";
											<Module>.FamANDAssem(ref value28, new object[]
											{
												'䵅',
												'બ',
												false,
												21011,
												15148,
												"IΧ"
											});
											bool flag29 = (text64.Contains(value28) ? 1 : 0) == checked(0 * -841121);
											if (flag29)
											{
												bool flag30 = list19[num10] != "";
												if (flag30)
												{
													string str7 = text36;
													string text65 = "莆";
													<Module>.FamANDAssem(ref text65, new object[]
													{
														"ම᰸಴",
														6644,
														"੫टÛ{8",
														false,
														7725
													});
													string str8 = text65;
													string str9 = list19[num10];
													string str10 = "䑯䐒䑎䐒";
													<Module>.FamANDAssem(ref str10, new object[]
													{
														2349,
														'㬅',
														false
													});
													text36 = str7 + str8 + str9 + str10;
												}
											}
											num11 = num10;
											c6 = '\u0001';
										}
									}
								}
							}
							bool flag31 = text36 != "";
							checked
							{
								if (flag31)
								{
									string pathToFolder = this.PathToFolder;
									string str11 = "\uda60";
									<Module>.FamANDAssem(ref str11, new object[]
									{
										'ª',
										"ᒓǃʵ=\u0015",
										1236,
										false,
										"䇦ᇁ㯦Ⴂվπ\u0016",
										4574
									});
									bool flag32 = (Alphaleonis.Win32.Filesystem.Directory.Exists(pathToFolder + str11 + this.resfold) ? 1 : 0) == 0 % 734533;
									if (flag32)
									{
										string pathToFolder2 = this.PathToFolder;
										string str12 = "彘";
										<Module>.FamANDAssem(ref str12, new object[]
										{
											"õ]=\0\u0004\u0005",
											false,
											1175,
											'ፃ',
											"ঀõᨮౕࣾஜ"
										});
										Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(pathToFolder2 + str12 + this.resfold);
									}
									string pathToFolder3 = this.PathToFolder;
									string str13 = "鿳";
									<Module>.FamANDAssem(ref str13, new object[]
									{
										3387,
										35918,
										1574
									});
									bool flag33 = Alphaleonis.Win32.Filesystem.Directory.Exists(pathToFolder3 + str13 + this.resfold);
									if (flag33)
									{
										string pathToFolder4 = this.PathToFolder;
										string text66 = "筊";
										<Module>.FamANDAssem(ref text66, new object[]
										{
											816,
											"Ɒᨨӏ͵P± ",
											2750,
											"ቿΉ",
											1827
										});
										string str14 = text66;
										string str15 = this.resfold;
										string str16 = "";
										<Module>.FamANDAssem(ref str16, new object[]
										{
											false,
											"㒏ʻǃ\u001b\a",
											'⪔',
											32839,
											673
										});
										string path3 = pathToFolder4 + str14 + str15 + str16;
										string[] array15 = new string[-6 * -1];
										array15[(int)array[1]] = link;
										int num12 = <Module>.Tag[0];
										string text67 = "\udbf4\udbf3";
										<Module>.FamANDAssem(ref text67, new object[]
										{
											false,
											7342,
											48971
										});
										array15[num12] = text67;
										array15[390147 - 390145] = text32;
										char c7 = '\u0003';
										int num13 = (int)c7;
										string text68 = "崓崓崓嵙嵌嵌崠崺";
										<Module>.FamANDAssem(ref text68, new object[]
										{
											2212,
											false,
											'ĸ',
											'㟡',
											'ᕴ',
											'ש'
										});
										array15[num13] = text68;
										int num14 = 4;
										array15[num14] = text36;
										int num15 = 7 & 5;
										string text69 = "跑跖";
										<Module>.FamANDAssem(ref text69, new object[]
										{
											20254,
											'᳆',
											'⅞',
											154
										});
										array15[num15] = text69;
										Alphaleonis.Win32.Filesystem.File.AppendAllText(path3, string.Concat(array15));
									}
									string pathToFolder5 = this.PathToFolder;
									string text70 = "Ʃ";
									<Module>.FamANDAssem(ref text70, new object[]
									{
										"í\u0096\u0002",
										"\u0002\0\f\u0001\u0002",
										5,
										'Z',
										false
									});
									string str17 = text70;
									string str18 = this.resfold;
									string str19 = "ȈȋȗȗɴȃȝȀȜɴȗȂȂ";
									<Module>.FamANDAssem(ref str19, new object[]
									{
										'Ǟ',
										false,
										11,
										"\u001b\0\0\u0003",
										'J',
										'\u0003'
									});
									bool flag34 = (Alphaleonis.Win32.Filesystem.Directory.Exists(pathToFolder5 + str17 + str18 + str19) ? 1 : 0) == 0 / 1125578932;
									if (flag34)
									{
										string pathToFolder6 = this.PathToFolder;
										string text71 = "";
										<Module>.FamANDAssem(ref text71, new object[]
										{
											51373,
											"ࣁ'ɂ\u0003\a",
											3193,
											1773
										});
										string str20 = text71;
										string str21 = this.resfold;
										string str22 = "ꦎꦍꦑꦑ꧲ꦅꦛꦆꦚ꧲ꦑꦄꦄ";
										<Module>.FamANDAssem(ref str22, new object[]
										{
											'澓',
											false,
											"㈔ࠫ"
										});
										Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo2 = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(pathToFolder6 + str20 + str21 + str22);
									}
									string pathToFolder7 = this.PathToFolder;
									string text72 = "䒢";
									<Module>.FamANDAssem(ref text72, new object[]
									{
										11920,
										false,
										5742
									});
									string str23 = text72;
									string str24 = this.resfold;
									string str25 = "善喇喛喛嗸喏喑喌喐嗸喛喎喎";
									<Module>.FamANDAssem(ref str25, new object[]
									{
										1523,
										5436,
										15017
									});
									bool flag35 = Alphaleonis.Win32.Filesystem.Directory.Exists(pathToFolder7 + str23 + str24 + str25);
									if (flag35)
									{
										string str26 = "הּ";
										<Module>.FamANDAssem(ref str26, new object[]
										{
											18634,
											16644,
											"䡢⑵[Ѧ\0\0\u0002"
										});
										string fromDir = foldercopy.Replace(foldername, str26 + fld);
										string[] array16 = new string[5 & 7];
										array16[(int)array[1]] = this.PathToFolder;
										int num16 = 1 * 1;
										string text73 = "䊢";
										<Module>.FamANDAssem(ref text73, new object[]
										{
											289,
											'ᆘ',
											"ᢙʀѯȃş_",
											'͵',
											"2ڪƉW¡%\u0005",
											false
										});
										array16[num16] = text73;
										int num17;
										switch (1 * 1)
										{
										case 0:
											num17 = -178031;
											break;
										case 1:
											num17 = 2;
											break;
										}
										array16[num17] = this.resfold;
										int num18 = unchecked(3 * 1);
										string text74 = "퐊퐉퐕퐕푶퐁퐟퐂퐞푶퐕퐀퐀퐊";
										<Module>.FamANDAssem(ref text74, new object[]
										{
											3873,
											5221,
											"媡䌬ͼϺ஍",
											false
										});
										array16[num18] = text74;
										array16[Convert.ToInt32("100", 2)] = fld;
										this.DirectoryCopy(fromDir, string.Concat(array16));
										string[] array17 = new string[3 << 1];
										int num19;
										if (87985 > -823794)
										{
											num19 = 0;
										}
										else
										{
											num19 = 913707;
										}
										array17[num19] = this.PathToFolder;
										int num20;
										switch (-132614 + 132614)
										{
										case 0:
											num20 = 1;
											break;
										case 1:
											num20 = -749259;
											break;
										}
										int num21 = num20;
										string text75 = "꾲";
										<Module>.FamANDAssem(ref text75, new object[]
										{
											42526,
											false,
											'৐'
										});
										array17[num21] = text75;
										unchecked
										{
											array17[(int)2L] = this.resfold;
											int num22 = <Module>.Cgt[4];
											string text76 = "";
											<Module>.FamANDAssem(ref text76, new object[]
											{
												false,
												40802,
												20040
											});
											array17[num22] = text76;
											array17[Convert.ToInt32("4", 8)] = fld;
											char c8 = '\u0005';
											int num23 = (int)c8;
											string text77 = "覆要覘視覎覵覵覶覩覇觺覙覙覅覍覓覎覒覅覙覌覌觴覮覢覮";
											<Module>.FamANDAssem(ref text77, new object[]
											{
												8621,
												5781,
												false,
												'ᗞ',
												5254,
												10036
											});
											array17[num23] = text77;
											string path4 = string.Concat(array17);
											string[] array18 = new string[checked(3 * 2)];
											array18[Convert.ToInt32("0", 2)] = link;
											int zeroFreeGlobalAllocAnsi2 = ToolsWindow.ZeroFreeGlobalAllocAnsi;
											string text78 = "怤怣";
											<Module>.FamANDAssem(ref text78, new object[]
											{
												'㽧',
												1838,
												192,
												1719,
												false,
												"\u0095ĵק੬"
											});
											array18[zeroFreeGlobalAllocAnsi2] = text78;
											array18[-153345 + 153347] = text32;
											int num24 = 3;
											int num25 = num24;
											string text79 = "";
											<Module>.FamANDAssem(ref text79, new object[]
											{
												679,
												12746,
												4962,
												18860,
												'偤'
											});
											array18[num25] = text79;
											array18[sizeof(uint)] = text36;
											int num26 = 964421 - 964416;
											string text80 = "䡔䡓";
											<Module>.FamANDAssem(ref text80, new object[]
											{
												13686,
												979,
												false,
												887,
												'ଃ',
												150
											});
											array18[num26] = text80;
											Alphaleonis.Win32.Filesystem.File.AppendAllText(path4, string.Concat(array18));
										}
									}
								}
								else
								{
									string pathToFolder8 = this.PathToFolder;
									string str27 = "ꊳ";
									<Module>.FamANDAssem(ref str27, new object[]
									{
										29604,
										false,
										'࢙',
										5563,
										4343
									});
									bool flag36 = (Alphaleonis.Win32.Filesystem.Directory.Exists(pathToFolder8 + str27 + this.resfold) ? 1 : 0) == (-653764 ^ -653764);
									if (flag36)
									{
										string pathToFolder9 = this.PathToFolder;
										string str28 = "㺌";
										<Module>.FamANDAssem(ref str28, new object[]
										{
											89,
											'̿',
											15057,
											85,
											18,
											false
										});
										Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo3 = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(pathToFolder9 + str28 + this.resfold);
									}
									string pathToFolder10 = this.PathToFolder;
									string str29 = "걣";
									<Module>.FamANDAssem(ref str29, new object[]
									{
										'\u0018',
										")%T\u001e\u0005\b",
										4,
										40767,
										false,
										3095
									});
									bool flag37 = Alphaleonis.Win32.Filesystem.Directory.Exists(pathToFolder10 + str29 + this.resfold);
									if (flag37)
									{
										string pathToFolder11 = this.PathToFolder;
										string text81 = "এ";
										<Module>.FamANDAssem(ref text81, new object[]
										{
											"!)",
											61,
											15,
											5,
											2360
										});
										string str30 = text81;
										string str31 = this.resfold;
										string str32 = "鹖鹉鹉鹕鹝鹃鹞鹂鹅鹟鹞鹕鹉鹜鹜鸤鹾鹲鹾";
										<Module>.FamANDAssem(ref str32, new object[]
										{
											17,
											14012,
											2386,
											'?',
											"冒কɀ%\a\u0019"
										});
										string path5 = pathToFolder11 + str30 + str31 + str32;
										string text82 = "";
										<Module>.FamANDAssem(ref text82, new object[]
										{
											"㎠ǭ\a\u0016\u0003\u0002",
											14402,
											7959,
											'揨'
										});
										string str33 = text82;
										string str34 = text32;
										string str35 = "䮥䮢";
										<Module>.FamANDAssem(ref str35, new object[]
										{
											"ݞ..³",
											'ę',
											3143,
											11032,
											2755
										});
										Alphaleonis.Win32.Filesystem.File.AppendAllText(path5, link + str33 + str34 + str35);
									}
									bool flag38 = ToolsWindow.sfl;
									if (flag38)
									{
										string pathToFolder12 = this.PathToFolder;
										string text83 = "ꅭ";
										<Module>.FamANDAssem(ref text83, new object[]
										{
											"⽡᎞ੴᲛ\u0083Ŗ",
											"ŋ\t\u0006",
											13296
										});
										string str36 = text83;
										string str37 = this.resfold;
										string str38 = "굲굱국국괎굹굧굺굦굡굻굺괎국굸굸";
										<Module>.FamANDAssem(ref str38, new object[]
										{
											1632,
											18652,
											'ᐴ',
											17297,
											'ح'
										});
										bool flag39 = (Alphaleonis.Win32.Filesystem.Directory.Exists(pathToFolder12 + str36 + str37 + str38) ? 1 : 0) == 0 / 259475841;
										if (flag39)
										{
											string pathToFolder13 = this.PathToFolder;
											string text84 = "ρ";
											<Module>.FamANDAssem(ref text84, new object[]
											{
												832,
												20,
												39,
												'\u001a',
												8
											});
											string str39 = text84;
											string str40 = this.resfold;
											string str41 = "찏찌찐찐챳찄찚찇찛찜찆찇챳찐찅찅";
											<Module>.FamANDAssem(ref str41, new object[]
											{
												787,
												1531,
												618,
												21812,
												27559
											});
											Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo4 = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(pathToFolder13 + str39 + str40 + str41);
										}
										string pathToFolder14 = this.PathToFolder;
										string text85 = "饘";
										<Module>.FamANDAssem(ref text85, new object[]
										{
											false,
											31199,
											7973
										});
										string str42 = text85;
										string str43 = this.resfold;
										string str44 = "";
										<Module>.FamANDAssem(ref str44, new object[]
										{
											'℻',
											'ʟ',
											54329
										});
										bool flag40 = Alphaleonis.Win32.Filesystem.Directory.Exists(pathToFolder14 + str42 + str43 + str44);
										if (flag40)
										{
											string str45 = "㽀";
											<Module>.FamANDAssem(ref str45, new object[]
											{
												false,
												8450,
												'ᘬ',
												2030
											});
											string fromDir2 = foldercopy.Replace(foldername, str45 + fld);
											string[] array19 = new string[267176 ^ 267181];
											char c9 = '\0';
											string[] array20;
											unchecked
											{
												array19[(int)c9] = this.PathToFolder;
												int num27 = 26420 ^ 26421;
												string text86 = "㎣";
												<Module>.FamANDAssem(ref text86, new object[]
												{
													2479,
													1097,
													8893,
													842
												});
												array19[num27] = text86;
												array19[715595 + -715593] = this.resfold;
												int num28 = Convert.ToInt32("3", 16);
												string text87 = "﹖﹕﹉﹉︪﹝﹃﹞﹂﹅﹟﹞︪﹉﹜﹜﹖";
												<Module>.FamANDAssem(ref text87, new object[]
												{
													51256,
													"ͅ\u0010\a",
													12918
												});
												array19[num28] = text87;
												array19[4628234 >> 20] = fld;
												this.DirectoryCopy(fromDir2, string.Concat(array19));
												int num29;
												switch (-352220)
												{
												case -352220:
													num29 = 6;
													break;
												case -352219:
													num29 = -345602;
													break;
												case -352218:
													num29 = -603698;
													break;
												}
												array20 = new string[num29];
												array20[(int)0L] = this.PathToFolder;
												int num30;
												if (77231 >= 814368)
												{
													num30 = 639267;
												}
												else
												{
													num30 = 1;
												}
												int num31 = num30;
												string text88 = "繗";
												<Module>.FamANDAssem(ref text88, new object[]
												{
													2455,
													28772,
													false,
													1040
												});
												array20[num31] = text88;
												array20[checked(-367857 - -367859)] = this.resfold;
												int num32 = 498905 - 498902;
												string text89 = "";
												<Module>.FamANDAssem(ref text89, new object[]
												{
													1367,
													56467
												});
												array20[num32] = text89;
											}
											array20[(int)4L] = fld;
											int num33 = 532065 - 532060;
											string text90 = "ୋୌ୕୛ୃ୸୸୻୤୊ଷ୔୔ୈୀ୞ୃୟ୘ୂୃୈ୔ୁୁହୣ୯ୣ";
											<Module>.FamANDAssem(ref text90, new object[]
											{
												631,
												false,
												'̄',
												248,
												'Ҥ'
											});
											array20[num33] = text90;
											string path6 = string.Concat(array20);
											string text91 = "礘礟";
											<Module>.FamANDAssem(ref text91, new object[]
											{
												false,
												26349,
												4648
											});
											string str46 = text91;
											string str47 = text32;
											string str48 = "ꙗꙐ";
											<Module>.FamANDAssem(ref str48, new object[]
											{
												'ߡ',
												false,
												39186,
												313,
												578,
												'Ǭ'
											});
											Alphaleonis.Win32.Filesystem.File.AppendAllText(path6, link + str46 + str47 + str48);
										}
									}
								}
							}
						}
					}
					string text92 = "ຓຕຒຂ";
					<Module>.FamANDAssem(ref text92, new object[]
					{
						false,
						'๨',
						'\u007f'
					});
					result = text92;
				}
				else
				{
					string text93 = "齉齎齃齜齊";
					<Module>.FamANDAssem(ref text93, new object[]
					{
						4695,
						18844,
						17212
					});
					result = text93;
				}
			}
			catch (Exception ex)
			{
				string text94 = "㳍㳊㳇㳘㳎";
				<Module>.FamANDAssem(ref text94, new object[]
				{
					3,
					5434,
					204,
					9890
				});
				result = text94;
			}
			return result;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00025564 File Offset: 0x00023764
		private void folderCheck_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			bool flag = Alphaleonis.Win32.Filesystem.Directory.Exists(this.selpath);
			if (flag)
			{
				Process.Start(this.selpath);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00025590 File Offset: 0x00023790
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			string pathToFolder = this.PathToFolder;
			string str = "臹";
			<Module>.FamANDAssem(ref str, new object[]
			{
				"⻞⯘",
				1382,
				8585
			});
			bool flag = Alphaleonis.Win32.Filesystem.Directory.Exists(pathToFolder + str + this.resfold);
			if (flag)
			{
				string pathToFolder2 = this.PathToFolder;
				string str2 = "";
				<Module>.FamANDAssem(ref str2, new object[]
				{
					"㒿ㇹבႃᕜɆ",
					3852,
					17411
				});
				Process.Start(pathToFolder2 + str2 + this.resfold);
			}
			else
			{
				bool flag2 = Alphaleonis.Win32.Filesystem.Directory.Exists(this.PathToFolder);
				if (flag2)
				{
					Process.Start(this.PathToFolder);
				}
				else
				{
					Process.Start(this.PathCurrent);
				}
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00025670 File Offset: 0x00023870
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			int[] array = new int[]
			{
				1,
				0
			};
			this.SaveFullCookies.Visibility = (Visibility)(0 << 29);
			ContentControl saveFullCookies = this.SaveFullCookies;
			string content = "ᘲᘀᘗᘄᙁᘇᘔᘍᘍᙁᘂᘎᘎᘊᘈᘄᘒ";
			<Module>.FamANDAssem(ref content, new object[]
			{
				2002,
				"\u008fί\a\u0003",
				2631,
				false
			});
			saveFullCookies.Content = content;
			TextBlock searcherText = this.SearcherText;
			string text = "ၾၒၒၖၔၘ၎ဝၮၘၜ၏ၞၕၘ၏";
			<Module>.FamANDAssem(ref text, new object[]
			{
				'භ',
				'ʆ',
				false
			});
			searcherText.Text = text;
			this.check_CookiesSearcher.IsChecked = new bool?(-322332 - -322333 != 0);
			ToggleButton toggleButton = this.check_PasswordSearcher;
			char c = '\0';
			toggleButton.IsChecked = new bool?(checked((int)c) != 0);
			this.check_AutoFillsSearcher.IsChecked = new bool?(true & false);
			ToggleButton toggleButton2 = this.check_ccSearcher;
			int value = 0;
			toggleButton2.IsChecked = new bool?(value != 0);
			this.reqsearch.IsEnabled = (<Module>.Tag[0] != 0);
			this.reqsearch.Clear();
			this.getsms = "";
			string pathCurrent = this.PathCurrent;
			string str = "ꮿꮰꮆꮗꮗꮊꮍꮄꮐꯍꮊꮍꮊ";
			<Module>.FamANDAssem(ref str, new object[]
			{
				"઄\0\u0003\u0002\u0001\0\u0002",
				7935,
				33368
			});
			this.fileinfo = Alphaleonis.Win32.Filesystem.File.ReadAllText(pathCurrent + str);
			string strSource = this.fileinfo;
			string text2 = "舺舖舖舒舐舜舊航舜舘舋舚舑艄艛";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				28585,
				4816
			});
			string strStart = text2;
			string strEnd = "踰";
			<Module>.FamANDAssem(ref strEnd, new object[]
			{
				15874,
				1956,
				18540
			});
			this.getsms = MainWindow.Pars(strSource, strStart, strEnd, ToolsWindow.Utf8SequenceLength);
			string[] array2 = new string[array[0]];
			int num = ~-1;
			string text3 = "헙";
			<Module>.FamANDAssem(ref text3, new object[]
			{
				"ᴗ⨩ˋ",
				28238,
				"ĎČᘺ\u009bҚ"
			});
			array2[num] = text3;
			string[] separator = array2;
			string[] array3 = this.getsms.Split(separator, (StringSplitOptions)Convert.ToInt32("1", 8));
			string[] array4 = array3;
			for (int i = 240618 >> 20; i < array4.Length; i += (1 & 1))
			{
				string text4 = array4[i];
				bool flag = text4 != "";
				if (flag)
				{
					System.Windows.Controls.TextBox textBox = this.reqsearch;
					string text5 = textBox.Text;
					string str2 = text4;
					string str3 = "꒘꒟";
					<Module>.FamANDAssem(ref str3, new object[]
					{
						40083,
						false,
						"ɻ²ŬĻ}",
						"ęt\"\u0002"
					});
					textBox.Text = text5 + str2 + str3;
				}
			}
			this.allCookiesFiles.Text = this.filesCounter.ToString();
			this.foundCookies.Text = this.cookiesCounter.ToString();
			this.remainsCookiesFiles.Text = this.remainsCounter.ToString();
			ToolsWindow.cookies_searcher_c = (checked((int)1L) != 0);
			ToolsWindow.password_searcher_c = (0 << 18 != 0);
			char c2 = '\0';
			ToolsWindow.autofills_searcher_c = ((int)c2 != 0);
			ToolsWindow.creditcards_searcher_c = (array[1] != 0);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000259E4 File Offset: 0x00023BE4
		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			try
			{
				this.results_log.Clear();
				DateTime now = DateTime.Now;
				string format = "⟉⟉➯⟬⟬➯⟲⟲";
				<Module>.FamANDAssem(ref format, new object[]
				{
					7639,
					553,
					1921,
					false
				});
				this.timeS = now.ToString(format);
				now = DateTime.Now;
				string format2 = "鲀鲿鲿鳵鲖鲖鳵鲢鲢鲢鲢鲆";
				<Module>.FamANDAssem(ref format2, new object[]
				{
					'㞢',
					false,
					99,
					25763,
					'3'
				});
				this.datetimeS = now.ToString(format2);
				string currentDirectory = Alphaleonis.Win32.Filesystem.Directory.GetCurrentDirectory();
				string str = "欞欙欐欧欱欷欮欶欱欟止欑欶欧欣欯止欑欧欣欰次欪欧欰";
				<Module>.FamANDAssem(ref str, new object[]
				{
					'㫷',
					7100,
					5263
				});
				this.PathToFolderS = currentDirectory + str;
				VistaFolderBrowserDialog vistaFolderBrowserDialog = new VistaFolderBrowserDialog();
				VistaFolderBrowserDialog vistaFolderBrowserDialog2 = vistaFolderBrowserDialog;
				string description = "鰗鰡鰨鰡鰧鰰鱤鰴鰥鰰鰬鱤鰰鰫鱤鰽鰫鰱鱤鰈鰋鰃鰗";
				<Module>.FamANDAssem(ref description, new object[]
				{
					false,
					1931,
					"揙ôѵࠟ",
					1947,
					875,
					6226
				});
				vistaFolderBrowserDialog2.Description = description;
				vistaFolderBrowserDialog.RootFolder = (Environment.SpecialFolder.Desktop & Environment.SpecialFolder.Desktop);
				bool? flag = vistaFolderBrowserDialog.ShowDialog();
				bool flag3;
				if (flag != null)
				{
					bool? flag2 = flag;
					bool zeroFreeGlobalAllocAnsi = ToolsWindow.ZeroFreeGlobalAllocAnsi != 0;
					flag3 = (flag2.GetValueOrDefault() == zeroFreeGlobalAllocAnsi & flag2 != null);
				}
				else
				{
					flag3 = (checked(0 * -622584) != 0);
				}
				bool flag4 = flag3;
				if (flag4)
				{
					this.selpath = vistaFolderBrowserDialog.SelectedPath;
					this.dircheck = new Alphaleonis.Win32.Filesystem.DirectoryInfo(this.selpath).Name;
					System.Windows.Controls.ProgressBar progressBar = this.progressBar1;
					char c = '\u0001';
					progressBar.IsIndeterminate = ((int)c != 0);
					System.Windows.Controls.Button button = (System.Windows.Controls.Button)sender;
					bool flag5 = (Alphaleonis.Win32.Filesystem.Directory.Exists(this.PathToFolderS) ? 1 : 0) == 0 % 287407;
					if (flag5)
					{
						Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(this.PathToFolderS);
					}
					new Thread(delegate()
					{
						this.FindVaultFiles5(this.selpath);
					}).Start();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00025C58 File Offset: 0x00023E58
		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			try
			{
				this.results_log.Clear();
				DateTime now = DateTime.Now;
				string format = "떾떾뗘떛떛뗘떅떅";
				<Module>.FamANDAssem(ref format, new object[]
				{
					"ⲊיሄȎͼ",
					false,
					14408,
					"઄⤹"
				});
				this.timeS = now.ToString(format);
				now = DateTime.Now;
				string format2 = "쟗쟨쟨잢쟁쟁잢쟵쟵쟵쟵쟑";
				<Module>.FamANDAssem(ref format2, new object[]
				{
					19112,
					false,
					30858,
					1114
				});
				this.datetimeS = now.ToString(format2);
				string currentDirectory = Alphaleonis.Win32.Filesystem.Directory.GetCurrentDirectory();
				string str = "荔荓荚荭荻荽荤荼荻荕茨荜荭荤荭药荺荩荥茨荛荭荩荺荫荠荭荺";
				<Module>.FamANDAssem(ref str, new object[]
				{
					14700,
					'䦜'
				});
				this.PathToFolderS = currentDirectory + str;
				VistaFolderBrowserDialog vistaFolderBrowserDialog = new VistaFolderBrowserDialog();
				VistaFolderBrowserDialog vistaFolderBrowserDialog2 = vistaFolderBrowserDialog;
				string description = "磪磜磕磜磚磍碙磉磘磍磑碙磍磖碙磀磖磌碙磵磶磾磪";
				<Module>.FamANDAssem(ref description, new object[]
				{
					"ˬִ",
					28697
				});
				vistaFolderBrowserDialog2.Description = description;
				vistaFolderBrowserDialog.RootFolder = ((Environment.SpecialFolder)662902 ^ (Environment.SpecialFolder)662902);
				bool? flag = vistaFolderBrowserDialog.ShowDialog();
				bool flag4;
				if (flag != null)
				{
					bool? flag2 = flag;
					bool flag3 = <Module>.Tag[0] != 0;
					flag4 = (flag2.GetValueOrDefault() == flag3 & flag2 != null);
				}
				else
				{
					flag4 = (0 << 2 != 0);
				}
				bool flag5 = flag4;
				if (flag5)
				{
					this.selpath = vistaFolderBrowserDialog.SelectedPath;
					this.dircheck = new Alphaleonis.Win32.Filesystem.DirectoryInfo(this.selpath).Name;
					this.progressBar1.IsIndeterminate = (checked((int)1L) != 0);
					System.Windows.Controls.Button button = (System.Windows.Controls.Button)sender;
					bool flag6 = (Alphaleonis.Win32.Filesystem.Directory.Exists(this.PathToFolderS) ? 1 : 0) == 356552 - 356552;
					if (flag6)
					{
						Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(this.PathToFolderS);
					}
					new Thread(delegate()
					{
						this.FindVaultFiles6(this.selpath);
					}).Start();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00025E90 File Offset: 0x00024090
		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			try
			{
				this.results_log.Clear();
				DateTime now = DateTime.Now;
				string format = "܄܄ݢܡܡݢܿܿ";
				<Module>.FamANDAssem(ref format, new object[]
				{
					"ȍͅs1\u0004-9",
					236
				});
				this.timeS = now.ToString(format);
				now = DateTime.Now;
				string format2 = "椹椆椆楌椯椯楌椛椛椛椛椿";
				<Module>.FamANDAssem(ref format2, new object[]
				{
					false,
					13743,
					2762,
					'ॉ',
					8096
				});
				this.datetimeS = now.ToString(format2);
				string currentDirectory = Alphaleonis.Win32.Filesystem.Directory.GetCurrentDirectory();
				string str = "锨锯锦锑锇锁锘销锇锩镔锲锠锤镔锧锑锕锆锗锜锑锆";
				<Module>.FamANDAssem(ref str, new object[]
				{
					"ᴞ⎎ș¹Р\u001e/",
					8755,
					2846,
					8248,
					false
				});
				this.PathToFolderS = currentDirectory + str;
				VistaFolderBrowserDialog vistaFolderBrowserDialog = new VistaFolderBrowserDialog();
				VistaFolderBrowserDialog vistaFolderBrowserDialog2 = vistaFolderBrowserDialog;
				string description = "";
				<Module>.FamANDAssem(ref description, new object[]
				{
					'ȅ',
					11254,
					40225,
					6548,
					1071
				});
				vistaFolderBrowserDialog2.Description = description;
				vistaFolderBrowserDialog.RootFolder = ~(Environment.SpecialFolder)(-1);
				bool? flag = vistaFolderBrowserDialog.ShowDialog();
				bool flag4;
				if (flag != null)
				{
					bool? flag2 = flag;
					bool flag3 = checked(true * true);
					flag4 = (flag2.GetValueOrDefault() == flag3 & flag2 != null);
				}
				else
				{
					int num;
					if (28210 > 815325)
					{
						num = 342679;
					}
					else
					{
						num = 0;
					}
					flag4 = (num != 0);
				}
				bool flag5 = flag4;
				if (flag5)
				{
					this.selpath = vistaFolderBrowserDialog.SelectedPath;
					this.dircheck = new Alphaleonis.Win32.Filesystem.DirectoryInfo(this.selpath).Name;
					this.progressBar1.IsIndeterminate = (~(-2 != 0) != 0);
					System.Windows.Controls.Button button = (System.Windows.Controls.Button)sender;
					bool flag6 = (Alphaleonis.Win32.Filesystem.Directory.Exists(this.PathToFolderS) ? 1 : 0) == ToolsWindow.Utf8SequenceLength;
					if (flag6)
					{
						Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(this.PathToFolderS);
					}
					new Thread(delegate()
					{
						this.FindVaultFiles7(this.selpath);
					}).Start();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0002610C File Offset: 0x0002430C
		private void Button_Click_4(object sender, RoutedEventArgs e)
		{
			try
			{
				this.results_log.Clear();
				DateTime now = DateTime.Now;
				string format = "\udd9c\udd9c\uddfa\uddb9\uddb9\uddfa\udda7\udda7";
				<Module>.FamANDAssem(ref format, new object[]
				{
					false,
					39654,
					'㣸',
					2550
				});
				this.timeS = now.ToString(format);
				now = DateTime.Now;
				string format2 = "跖跩跩趣跀跀趣跴跴跴跴跐";
				<Module>.FamANDAssem(ref format2, new object[]
				{
					34637,
					131,
					"ĵȁL\u0001\u0002",
					568
				});
				this.datetimeS = now.ToString(format2);
				string currentDirectory = Alphaleonis.Win32.Filesystem.Directory.GetCurrentDirectory();
				string str = "礢礥礬礛礍礋礒礊礍礣神礩礟礒礒礛礊礍神礭礛礟礌礝礖礛礌";
				<Module>.FamANDAssem(ref str, new object[]
				{
					11523,
					"ˬஹ",
					'㷖'
				});
				this.PathToFolderS = currentDirectory + str;
				VistaFolderBrowserDialog vistaFolderBrowserDialog = new VistaFolderBrowserDialog();
				VistaFolderBrowserDialog vistaFolderBrowserDialog2 = vistaFolderBrowserDialog;
				string description = "芀芶芿芶芰芧苳芣芲芧芻苳芧芼苳芪芼芦苳芟芜芔芀";
				<Module>.FamANDAssem(ref description, new object[]
				{
					"⛌ݶ⯻ɴFǿ",
					false,
					"∅ǘ"
				});
				vistaFolderBrowserDialog2.Description = description;
				VistaFolderBrowserDialog vistaFolderBrowserDialog3 = vistaFolderBrowserDialog;
				char c = '\0';
				vistaFolderBrowserDialog3.RootFolder = (Environment.SpecialFolder)c;
				bool? flag = vistaFolderBrowserDialog.ShowDialog();
				bool flag4;
				if (flag != null)
				{
					bool? flag2 = flag;
					bool flag3 = 1921498905 / 1921498905 != 0;
					flag4 = (flag2.GetValueOrDefault() == flag3 & flag2 != null);
				}
				else
				{
					flag4 = (ToolsWindow.Utf8SequenceLength != 0);
				}
				bool flag5 = flag4;
				if (flag5)
				{
					this.selpath = vistaFolderBrowserDialog.SelectedPath;
					this.dircheck = new Alphaleonis.Win32.Filesystem.DirectoryInfo(this.selpath).Name;
					this.progressBar1.IsIndeterminate = true * true;
					System.Windows.Controls.Button button = (System.Windows.Controls.Button)sender;
					bool flag6 = (Alphaleonis.Win32.Filesystem.Directory.Exists(this.PathToFolderS) ? 1 : 0) == checked(327274 - 327274);
					if (flag6)
					{
						Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo = Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(this.PathToFolderS);
					}
					new Thread(delegate()
					{
						this.FindVaultFiles8(this.selpath);
					}).Start();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000267F0 File Offset: 0x000249F0
		// Note: this type is marked as 'beforefieldinit'.
		static ToolsWindow()
		{
			char c = '\0';
			checked
			{
				ToolsWindow.autofills_searcher_c = ((int)c != 0);
				char c2 = '\0';
				ToolsWindow.creditcards_searcher_c = ((int)c2 != 0);
			}
			ToolsWindow.create_base = (588945 - 588945 != 0);
			ToolsWindow.sfl = (897411 - 897411 != 0);
			ToolsWindow.sfc = (0 / 1569776241 != 0);
		}

		// Token: 0x040000AE RID: 174
		private List<string> sourceList = new List<string>();

		// Token: 0x040000AF RID: 175
		private int filesCounter;

		// Token: 0x040000B0 RID: 176
		private int remainsCounter;

		// Token: 0x040000B1 RID: 177
		private int cookiesCounter;

		// Token: 0x040000B2 RID: 178
		private int thrcnt;

		// Token: 0x040000B3 RID: 179
		private string selpath;

		// Token: 0x040000B4 RID: 180
		private string dircheck;

		// Token: 0x040000B5 RID: 181
		private string fileinfo;

		// Token: 0x040000B6 RID: 182
		private static bool cookies_searcher_c = 5 % 2 != 0;

		// Token: 0x040000B7 RID: 183
		private static bool password_searcher_c = 1609476 >> 22 != 0;

		// Token: 0x040000B8 RID: 184
		private static bool autofills_searcher_c;

		// Token: 0x040000B9 RID: 185
		private static bool creditcards_searcher_c;

		// Token: 0x040000BA RID: 186
		private static bool create_base;

		// Token: 0x040000BB RID: 187
		private static bool sfl;

		// Token: 0x040000BC RID: 188
		private static bool sfc;

		// Token: 0x040000BD RID: 189
		private string PathToFolder;

		// Token: 0x040000BE RID: 190
		private string PathToFolderS;

		// Token: 0x040000BF RID: 191
		private string PathCurrent;

		// Token: 0x040000C0 RID: 192
		private string time;

		// Token: 0x040000C1 RID: 193
		private string datetime;

		// Token: 0x040000C2 RID: 194
		private string timeS;

		// Token: 0x040000C3 RID: 195
		private string datetimeS;

		// Token: 0x040000C4 RID: 196
		private string resfold;

		// Token: 0x040000C5 RID: 197
		private string domainsrc;

		// Token: 0x040000C6 RID: 198
		private string getsms;

		// Token: 0x040000C7 RID: 199
		private List<Task> tasks;

		// Token: 0x040000C8 RID: 200
		private CancellationTokenSource cts;

		// Token: 0x040000E7 RID: 231 RVA: 0x00002108 File Offset: 0x00000308
		private static int ZeroFreeGlobalAllocAnsi;

		// Token: 0x040000E8 RID: 232 RVA: 0x00002110 File Offset: 0x00000310
		private static int Utf8SequenceLength;

		// Token: 0x040000E9 RID: 233 RVA: 0x00002118 File Offset: 0x00000318
		private static int Handle;

		// Token: 0x040000EA RID: 234 RVA: 0x00002138 File Offset: 0x00000338
		private static int IsSet;

		// Token: 0x040000EB RID: 235 RVA: 0x00002140 File Offset: 0x00000340
		private static int get_ElapsedTicks;

		// Token: 0x040000EC RID: 236 RVA: 0x00002148 File Offset: 0x00000348
		private static int LF;

		// Token: 0x040000ED RID: 237 RVA: 0x00002150 File Offset: 0x00000350
		private static int CaselessMatching;
	}
}
