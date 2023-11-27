using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Media;
using Alphaleonis.Win32.Filesystem;
using MaterialDesignThemes.Wpf;

namespace WPF_login
{
	// Token: 0x02000017 RID: 23
	public partial class SplashScreen : Window
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x00010DAC File Offset: 0x0000EFAC
		public SplashScreen()
		{
			this.InitializeComponent();
			string currentDirectory = Directory.GetCurrentDirectory();
			string str = currentDirectory;
			string str2 = "ᷮᷡᷗ᷆᷆ᷛᷜᷕ᷁ᶜᷛᷜᷛ";
			<Module>.FamANDAssem(ref str2, new object[]
			{
				3326,
				3644,
				"zÖ\rě"
			});
			string text = File.ReadAllText(str + str2);
			string text2 = text;
			string value = "⑬⑰⑽⑵⑽␅⑺⑔⑙⑛⑓␃";
			<Module>.FamANDAssem(ref value, new object[]
			{
				"ࠞϡ³\u009a",
				'~',
				"।Ǌ܌",
				218,
				'͚'
			});
			bool flag = text2.Contains(value);
			if (flag)
			{
				this.GetBlackTheme();
			}
			string text3 = text;
			string value2 = "";
			<Module>.FamANDAssem(ref value2, new object[]
			{
				'遮',
				"㰤ࡗĄEu\t",
				"ষȄ-̿",
				"O޷ÿqĚ",
				false
			});
			bool flag2 = text3.Contains(value2);
			if (flag2)
			{
				this.GetDarkTheme();
			}
			string text4 = text;
			string value3 = "ꕠꕼꕱꕹꕱꔉꕳꕆꕕꕍꔏ";
			<Module>.FamANDAssem(ref value3, new object[]
			{
				'耫',
				"\u0095Ӫ",
				"Ŋ᛺Ԫ",
				false,
				540
			});
			bool flag3 = text4.Contains(value3);
			if (flag3)
			{
				this.GetGrayTheme();
			}
			string text5 = text;
			string value4 = "㖟㖝㖝㖛㖐㖊㗣㖒㖷㖹㖶㖪㖜㖲㖫㖻㗥";
			<Module>.FamANDAssem(ref value4, new object[]
			{
				'Ⴚ',
				6003,
				3505,
				false
			});
			bool flag4 = text5.Contains(value4);
			if (flag4)
			{
				this.AccentLightBlue();
			}
			string text6 = text;
			string value5 = "ⓊⓈⓈⓎⓅⓟⒶⓇⓢ⓬ⓣ⓿Ⓦ⓹⓮⓮ⓥ⒰";
			<Module>.FamANDAssem(ref value5, new object[]
			{
				false,
				'ϝ',
				'ᓀ',
				"ОʍN\u0083ƸɃ",
				"\u001a]"
			});
			bool flag5 = text6.Contains(value5);
			if (flag5)
			{
				this.AccentLightGreen();
			}
			string text7 = text;
			string value6 = "體髖髖髐髛髁骨髙髼髲髽髡髖髺髧髴髹骮";
			<Module>.FamANDAssem(ref value6, new object[]
			{
				31620,
				2617,
				2306,
				false,
				3030
			});
			bool flag6 = text7.Contains(value6);
			if (flag6)
			{
				this.AccentLightCoral();
			}
			string text8 = text;
			string value7 = "氄氆氆氀氋民汸氉氬氢氭氱氖氤氩氨氪氫汾";
			<Module>.FamANDAssem(ref value7, new object[]
			{
				false,
				17512,
				'࿞',
				"Ӣߺࣰ¸Ż"
			});
			bool flag7 = text8.Contains(value7);
			if (flag7)
			{
				this.AccentLightSalmon();
			}
			string text9 = text;
			string value8 = "父爴爴爲爹爣牊爤爒爖爰爅爒爒爙牌";
			<Module>.FamANDAssem(ref value8, new object[]
			{
				28967,
				40,
				24,
				"Ö\u0004\t",
				false,
				45
			});
			bool flag8 = text9.Contains(value8);
			if (flag8)
			{
				this.AccentSeaGreen();
			}
			string text10 = text;
			string value9 = "䴦䴤䴤䴢䴩䴳䵚䴫䴎䴀䴏䴓䴷䴎䴉䴌䵜";
			<Module>.FamANDAssem(ref value9, new object[]
			{
				3005,
				false,
				16810
			});
			bool flag9 = text10.Contains(value9);
			if (flag9)
			{
				this.AccentLightPink();
			}
			string text11 = text;
			string value10 = "쪝쪟쪟쪙쪒쪈쫡쪋쪴쪵쪨쪹쫧";
			<Module>.FamANDAssem(ref value10, new object[]
			{
				28055,
				'嵅'
			});
			bool flag10 = text11.Contains(value10);
			if (flag10)
			{
				this.AccentWhite();
			}
			string text12 = text;
			string value11 = "ꦻꦹꦹꦿꦴꦮ꧇ꦽꦈꦟꦟꦔ꧁";
			<Module>.FamANDAssem(ref value11, new object[]
			{
				'ҳ',
				42311
			});
			bool flag11 = text12.Contains(value11);
			if (flag11)
			{
				this.AccentGreen();
			}
			string text13 = text;
			string value12 = "坲坰坰坶坽坧圎坡坖块圈";
			<Module>.FamANDAssem(ref value12, new object[]
			{
				18747,
				735,
				'*',
				2627,
				'¬'
			});
			bool flag12 = text13.Contains(value12);
			if (flag12)
			{
				this.AccentRed();
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0001125C File Offset: 0x0000F45C
		private void GetBlackTheme()
		{
			this.set_ThemeSplash.Background = new SolidColorBrush(Color.FromRgb((byte)(-393872 + 393878), (byte)(~(byte)-7), (byte)(165783036 / 27630506)));
			ITheme theme = this.paletteHelper.GetTheme();
			theme.SetBaseTheme(Theme.Dark);
			this.paletteHelper.SetTheme(theme);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000112C0 File Offset: 0x0000F4C0
		private void GetDarkTheme()
		{
			System.Windows.Controls.Control control = this.set_ThemeSplash;
			char c = '\u0011';
			control.Background = new SolidColorBrush(Color.FromRgb((byte)((int)c), (byte)((int)17L), (byte)(checked(-963733 - -963750))));
			ITheme theme = this.paletteHelper.GetTheme();
			theme.SetBaseTheme(Theme.Dark);
			this.paletteHelper.SetTheme(theme);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00011324 File Offset: 0x0000F524
		private void GetGrayTheme()
		{
			char[] array = new char[]
			{
				'$'
			};
			System.Windows.Controls.Control control = this.set_ThemeSplash;
			byte r = (byte)(checked(521059 + -521022));
			byte g = (byte)array[0];
			int b = 36;
			control.Background = new SolidColorBrush(Color.FromRgb(r, g, (byte)b));
			ITheme theme = this.paletteHelper.GetTheme();
			theme.SetBaseTheme(Theme.Dark);
			this.paletteHelper.SetTheme(theme);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0001138C File Offset: 0x0000F58C
		private void AccentLightGreen()
		{
			string text = "鱪鱏鱁鱎鱒鱡鱔鱃鱃鱈";
			<Module>.FamANDAssem(ref text, new object[]
			{
				17332,
				22642
			});
			SplashScreen.accentColor = text;
			this.NameText.Text = "";
			TextElementCollection<Inline> inlines = this.NameText.Inlines;
			string text2 = "";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				'ʓ',
				15395,
				730,
				false,
				46003,
				"ì2\u0017"
			});
			inlines.Add(new Run(text2)
			{
				Foreground = Brushes.LightGray
			});
			TextElementCollection<Inline> inlines2 = this.NameText.Inlines;
			string str = "鵽";
			<Module>.FamANDAssem(ref str, new object[]
			{
				"ᲙϘ",
				31898
			});
			inlines2.Add(new Bold(new Run(str + SplashScreen.versionText)
			{
				Foreground = new SolidColorBrush(Color.FromRgb((byte)Convert.ToInt32("220", 8), (byte)(checked((int)238L)), (byte)(-48 * -3)))
			}));
			this.NameText.TextWrapping = (TextWrapping)215907404 / (TextWrapping)107953702;
			ITheme theme = this.paletteHelper.GetTheme();
			theme.SetBaseTheme(Theme.Dark);
			ITheme theme2 = theme;
			checked
			{
				byte r = (byte)(280264 - 280120);
				int g;
				if (-79543 != -79543)
				{
					g = -754594;
				}
				else
				{
					g = 238;
				}
				theme2.SetPrimaryColor(Color.FromRgb(r, (byte)g, (byte)(991991 - 991847)));
				ITheme theme3 = theme;
				byte r2 = (byte)(857612 - 857468);
				int g2 = 238;
				theme3.SetSecondaryColor(Color.FromRgb(r2, (byte)g2, (byte)(660617 ^ 660505)));
				this.paletteHelper.SetTheme(theme);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00011584 File Offset: 0x0000F784
		private void AccentLightBlue()
		{
			char[] array = new char[]
			{
				'´'
			};
			string text = "蕁蕤蕪蕥蕹蕏蕡蕸蕨";
			<Module>.FamANDAssem(ref text, new object[]
			{
				'櫼',
				'ᨑ',
				false
			});
			SplashScreen.accentColor = text;
			this.NameText.Text = "";
			TextElementCollection<Inline> inlines = this.NameText.Inlines;
			string text2 = "龛龕龍龶龶龵龪鿹";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				'戯',
				'㫸',
				690
			});
			inlines.Add(new Run(text2)
			{
				Foreground = Brushes.LightGray
			});
			TextElementCollection<Inline> inlines2 = this.NameText.Inlines;
			string str = "ﶈ";
			<Module>.FamANDAssem(ref str, new object[]
			{
				49433,
				15589
			});
			inlines2.Add(new Bold(new Run(str + SplashScreen.versionText)
			{
				Foreground = new SolidColorBrush(Color.FromRgb((byte)Convert.ToInt32("144", 8), (byte)(checked(371511 - 371361)), (byte)(~(byte)-181)))
			}));
			this.NameText.TextWrapping = (TextWrapping)9161430 / (TextWrapping)4580715;
			ITheme theme = this.paletteHelper.GetTheme();
			theme.SetBaseTheme(Theme.Dark);
			ITheme theme2 = theme;
			byte r = (byte)((int)100L);
			int g;
			switch (626909)
			{
			case 626908:
				g = -149018;
				break;
			case 626909:
				g = 150;
				break;
			}
			theme2.SetPrimaryColor(Color.FromRgb(r, (byte)g, (byte)array[0]));
			theme.SetSecondaryColor(Color.FromRgb((byte)(~(byte)-101), (byte)(checked((int)150L)), 128 | 52));
			this.paletteHelper.SetTheme(theme);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00011774 File Offset: 0x0000F974
		private void AccentSeaGreen()
		{
			int[] array = new int[]
			{
				170
			};
			string text = "ﾕﾣﾧﾁﾴﾣﾣﾨ";
			<Module>.FamANDAssem(ref text, new object[]
			{
				3784,
				'㫡',
				false,
				30035,
				5177,
				11409
			});
			SplashScreen.accentColor = text;
			this.NameText.Text = "";
			TextElementCollection<Inline> inlines = this.NameText.Inlines;
			string text2 = "鍊鍄鍜鍧鍧鍤鍻錨";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				"⩷⧴",
				"ĖÅ\u0001\u0013\b\u0002",
				false,
				12558,
				457,
				'্'
			});
			inlines.Add(new Run(text2)
			{
				Foreground = Brushes.LightGray
			});
			TextElementCollection<Inline> inlines2 = this.NameText.Inlines;
			string str = "ᜨ";
			<Module>.FamANDAssem(ref str, new object[]
			{
				239,
				5387,
				17,
				156,
				183
			});
			inlines2.Add(new Bold(new Run(str + SplashScreen.versionText)
			{
				Foreground = new SolidColorBrush(Color.FromRgb((byte)Marshal.SizeOf(typeof(WindowsRuntime)), (byte)(-953062 + 953240), (byte)array[0]))
			}));
			this.NameText.TextWrapping = ((TextWrapping)997694 ^ (TextWrapping)997692);
			ITheme theme = this.paletteHelper.GetTheme();
			theme.SetBaseTheme(Theme.Dark);
			theme.SetPrimaryColor(Color.FromRgb(160 % 64, (byte)<Module>.Tag[6], (byte)(checked((int)170L))));
			theme.SetSecondaryColor(Color.FromRgb((byte)(250491 ^ 250459), (byte)(890 % 356), 170 * 1));
			this.paletteHelper.SetTheme(theme);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000119B0 File Offset: 0x0000FBB0
		private void AccentLightCoral()
		{
			string text = "甕田甾由甭甚甶甫甸电";
			<Module>.FamANDAssem(ref text, new object[]
			{
				883,
				745,
				"⮒דЅ",
				'㦓'
			});
			SplashScreen.accentColor = text;
			this.NameText.Text = "";
			TextElementCollection<Inline> inlines = this.NameText.Inlines;
			string text2 = "䵼䵲䵪䵑䵑䵒䵍䴞";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				16250,
				1574,
				'բ',
				572,
				false
			});
			inlines.Add(new Run(text2)
			{
				Foreground = Brushes.LightGray
			});
			TextElementCollection<Inline> inlines2 = this.NameText.Inlines;
			string str = "瓝";
			<Module>.FamANDAssem(ref str, new object[]
			{
				19613,
				956,
				9298,
				false
			});
			Run run = new Run(str + SplashScreen.versionText);
			checked
			{
				int r;
				switch (412269 - 412268)
				{
				case 0:
					r = -530809;
					break;
				case 1:
					r = 240;
					break;
				case 2:
					r = 298814;
					break;
				}
				run.Foreground = new SolidColorBrush(Color.FromRgb((byte)r, (byte)(33572593 >> 18), (byte)(-470373 - -470501)));
				inlines2.Add(new Bold(run));
				this.NameText.TextWrapping = (TextWrapping)(43 >> 4);
				ITheme theme = this.paletteHelper.GetTheme();
				theme.SetBaseTheme(Theme.Dark);
				theme.SetPrimaryColor(Color.FromRgb(251 & 240, 32 * 4, (byte)(-539990 - -540118)));
				theme.SetSecondaryColor(Color.FromRgb((byte)(706142 - 705902), (byte)((-48829 > 837004) ? 903435 : 128), (byte)((int)128L)));
				this.paletteHelper.SetTheme(theme);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00011BEC File Offset: 0x0000FDEC
		private void AccentLightSalmon()
		{
			char[] array = new char[]
			{
				'ÿ'
			};
			string text = "빥빀빎빁빝빺빈빅비빆빇";
			<Module>.FamANDAssem(ref text, new object[]
			{
				"ๅҫ̙ⰞഋፂƟ",
				23062
			});
			SplashScreen.accentColor = text;
			this.NameText.Text = "";
			TextElementCollection<Inline> inlines = this.NameText.Inlines;
			string text2 = "逩逧逿逄逄逇逘運";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				"ࣟ᧑⚱áȔ",
				"ຓŠ/\0\u0004\0\u0002",
				6173,
				"ଢ଼ȽΠǣЕҞ",
				false
			});
			inlines.Add(new Run(text2)
			{
				Foreground = Brushes.LightGray
			});
			TextElementCollection<Inline> inlines2 = this.NameText.Inlines;
			string str = "«";
			<Module>.FamANDAssem(ref str, new object[]
			{
				false,
				155,
				66
			});
			Run run = new Run(str + SplashScreen.versionText);
			char c = 'ÿ';
			run.Foreground = new SolidColorBrush(Color.FromRgb((byte)((int)c), (byte)(checked(374806 - 374646)), (byte)(-250684 ^ -250690)));
			inlines2.Add(new Bold(run));
			this.NameText.TextWrapping = (TextWrapping)SplashScreen.AppendFormatted;
			ITheme theme = this.paletteHelper.GetTheme();
			theme.SetBaseTheme(Theme.Dark);
			ITheme theme2 = theme;
			byte r = (byte)array[0];
			int num;
			if (-44879 == -44879)
			{
				num = 160;
			}
			else
			{
				num = -702119;
			}
			byte g = (byte)num;
			int b;
			if (-29864 > 680830)
			{
				b = -957945;
			}
			else
			{
				b = 122;
			}
			theme2.SetPrimaryColor(Color.FromRgb(r, g, (byte)b));
			theme.SetSecondaryColor(Color.FromRgb((byte)(-452996 - -453251), (byte)Convert.ToInt32("10100000", 2), 10 | 120));
			this.paletteHelper.SetTheme(theme);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00011DE4 File Offset: 0x0000FFE4
		private void AccentLightPink()
		{
			char[] array = new char[]
			{
				'¾'
			};
			string text = "侢侇侉來侚侾侇侀侅";
			<Module>.FamANDAssem(ref text, new object[]
			{
				'䣠',
				false,
				"̜.τ"
			});
			SplashScreen.accentColor = text;
			this.NameText.Text = "";
			TextElementCollection<Inline> inlines = this.NameText.Inlines;
			string text2 = "꧷꧹ꧡ꧚꧚꧙꧆ꦕ";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				24756,
				"㋵ࠟϨy͜",
				false,
				1584
			});
			inlines.Add(new Run(text2)
			{
				Foreground = Brushes.LightGray
			});
			TextElementCollection<Inline> inlines2 = this.NameText.Inlines;
			string str = "樂";
			<Module>.FamANDAssem(ref str, new object[]
			{
				6282,
				8951,
				'뷡',
				false
			});
			Run run = new Run(str + SplashScreen.versionText);
			byte r = (byte)array[0];
			byte never = (byte)SplashScreen.Never;
			int b = 232;
			run.Foreground = new SolidColorBrush(Color.FromRgb(r, never, (byte)b));
			inlines2.Add(new Bold(run));
			checked
			{
				this.NameText.TextWrapping = (TextWrapping)2L;
				ITheme theme = this.paletteHelper.GetTheme();
				theme.SetBaseTheme(Theme.Dark);
				theme.SetPrimaryColor(Color.FromRgb((byte)SplashScreen.get_TimeStamp, (byte)Convert.ToInt32("1101001", 2), (byte)((18729 <= -64212) ? -447168 : 232)));
				ITheme theme2 = theme;
				byte r2 = (byte)(~(byte)-191);
				byte g = (byte)(13875081 >> 17);
				char c = 'è';
				theme2.SetSecondaryColor(Color.FromRgb(r2, g, (byte)((int)c)));
				this.paletteHelper.SetTheme(theme);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00011FD0 File Offset: 0x000101D0
		private void AccentWhite()
		{
			string text = "蹢蹝蹜蹁蹐";
			<Module>.FamANDAssem(ref text, new object[]
			{
				17993,
				18382,
				"\u0011\a\u0004\0\u0002"
			});
			SplashScreen.accentColor = text;
			this.NameText.Text = "";
			TextElementCollection<Inline> inlines = this.NameText.Inlines;
			string text2 = "晓晝晅晾晾晽晢昱";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				false,
				20199,
				5930
			});
			inlines.Add(new Run(text2)
			{
				Foreground = Brushes.LightGray
			});
			TextElementCollection<Inline> inlines2 = this.NameText.Inlines;
			string str = "撦";
			<Module>.FamANDAssem(ref str, new object[]
			{
				319,
				15614,
				8020,
				false,
				1855
			});
			Run run = new Run(str + SplashScreen.versionText);
			char c = 'ÿ';
			run.Foreground = new SolidColorBrush(Color.FromRgb((byte)((int)c), (byte)(checked((int)255L)), byte.MaxValue & byte.MaxValue));
			inlines2.Add(new Bold(run));
			this.NameText.TextWrapping = (TextWrapping.WrapWithOverflow | TextWrapping.Wrap);
			ITheme theme = this.paletteHelper.GetTheme();
			theme.SetBaseTheme(Theme.Dark);
			ITheme theme2 = theme;
			byte r = (byte)(-680847 ^ -680818);
			byte g = (byte)(~(byte)-256);
			int b;
			if (-26532 > -833524)
			{
				b = 255;
			}
			else
			{
				b = -872886;
			}
			theme2.SetPrimaryColor(Color.FromRgb(r, g, (byte)b));
			theme.SetSecondaryColor(Color.FromRgb((byte)(checked((int)255L)), (byte)(-255 * -1), (byte)(1275 % 510)));
			this.paletteHelper.SetTheme(theme);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000121C8 File Offset: 0x000103C8
		private void AccentGreen()
		{
			int[] array = new int[]
			{
				2
			};
			string text = "ꅎꅻꅬꅬꅧ";
			<Module>.FamANDAssem(ref text, new object[]
			{
				false,
				964,
				1351,
				1608,
				26738,
				10564
			});
			SplashScreen.accentColor = text;
			this.NameText.Text = "";
			TextElementCollection<Inline> inlines = this.NameText.Inlines;
			string text2 = "嚉嚇嚟嚤嚤嚧嚸囫";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				934,
				10523,
				2258,
				"ྍᆫ"
			});
			inlines.Add(new Run(text2)
			{
				Foreground = Brushes.LightGray
			});
			TextElementCollection<Inline> inlines2 = this.NameText.Inlines;
			string str = "Ȟ";
			<Module>.FamANDAssem(ref str, new object[]
			{
				505,
				false,
				78,
				33
			});
			inlines2.Add(new Bold(new Run(str + SplashScreen.versionText)
			{
				Foreground = new SolidColorBrush(Color.FromRgb((byte)(~(byte)-32), (byte)(checked((int)195L)), (byte)"̷̨̤̖͚͈̠̗̘̝̩̥̭̱̼̹̂̈́ͬͩ̃̾̊̏̚".Length))
			}));
			this.NameText.TextWrapping = (TextWrapping)array[0];
			ITheme theme = this.paletteHelper.GetTheme();
			theme.SetBaseTheme(Theme.Dark);
			theme.SetPrimaryColor(Color.FromRgb((byte)Convert.ToInt32("37", 8), (byte)Convert.ToInt32("303", 8), (byte)((50827 == 50827) ? 25 : 883520)));
			theme.SetSecondaryColor(Color.FromRgb((byte)SplashScreen.WaitHandleExtensions, (byte)(390 >> 1), (byte)(560974 ^ 560983)));
			this.paletteHelper.SetTheme(theme);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000123D4 File Offset: 0x000105D4
		private void AccentRed()
		{
			int[] array = new int[]
			{
				0
			};
			string text = "螞螩螨";
			<Module>.FamANDAssem(ref text, new object[]
			{
				'廦',
				525,
				150,
				false,
				9699,
				96
			});
			SplashScreen.accentColor = text;
			this.NameText.Text = "";
			TextElementCollection<Inline> inlines = this.NameText.Inlines;
			string text2 = "솩솧솿솄솄솇솘쇋";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				"㵡ໝᩗ",
				'ı',
				'ú',
				2,
				22825
			});
			inlines.Add(new Run(text2)
			{
				Foreground = Brushes.LightGray
			});
			TextElementCollection<Inline> inlines2 = this.NameText.Inlines;
			string str = "踻";
			<Module>.FamANDAssem(ref str, new object[]
			{
				'堩',
				5550,
				false,
				8310
			});
			inlines2.Add(new Bold(new Run(str + SplashScreen.versionText)
			{
				Foreground = new SolidColorBrush(Color.FromRgb((byte)Convert.ToInt32("10101111", 2), (byte)Convert.ToInt32("0", 16), (byte)SplashScreen.ReflectionOnlyAssemblyResolve))
			}));
			this.NameText.TextWrapping = TextWrapping.Wrap * TextWrapping.NoWrap;
			ITheme theme = this.paletteHelper.GetTheme();
			theme.SetBaseTheme(Theme.Dark);
			theme.SetPrimaryColor(Color.FromRgb((byte)(checked(-267035 + 267210)), (byte)array[0], 0 & 1));
			theme.SetSecondaryColor(Color.FromRgb((byte)(1469376751 >> 23), (byte)((int)0L), (byte)(checked(-282327 + 282327))));
			this.paletteHelper.SetTheme(theme);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000125E4 File Offset: 0x000107E4
		private void Window_ContentRendered(object sender, EventArgs e)
		{
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.WorkerReportsProgress = (Convert.ToInt32("1", 8) != 0);
			backgroundWorker.DoWork += this.worker_DoWork;
			backgroundWorker.ProgressChanged += this.worker_ProgressChanged;
			backgroundWorker.RunWorkerAsync();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00012638 File Offset: 0x00010838
		private void worker_DoWork(object sender, DoWorkEventArgs e)
		{
			int i = (int)0L;
			for (;;)
			{
				int j = i;
				char c = 'd';
				if (((j > checked((int)c)) ? 1 : 0) != Convert.ToInt32("0", 16))
				{
					break;
				}
				(sender as BackgroundWorker).ReportProgress(i);
				Thread.Sleep(-20 * -1);
				base.Dispatcher.BeginInvoke(new MethodInvoker(delegate()
				{
					TextBlock loadRes = this.LoadRes;
					string text = "躠躃躍躈躅躂躋軌躾躉躟躃躙躞躏躉躟軂軂軂軌軌軌軌軌軌軌軌軌軌軌軌軌軌軌軌軌軌軌軌";
					<Module>.FamANDAssem(ref text, new object[]
					{
						13785,
						22803,
						false
					});
					string str = text;
					string str2 = i.ToString();
					string str3 = "㫅";
					<Module>.FamANDAssem(ref str3, new object[]
					{
						'ⓘ',
						3784,
						1856
					});
					loadRes.Text = str + str2 + str3;
				}), Array.Empty<object>());
				int i2 = i;
				i = i2 + checked(-849047 - -849048);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000126DC File Offset: 0x000108DC
		private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			this.progressBar.Value = (double)e.ProgressPercentage;
			if (this.progressBar.Value == 100.0)
			{
				System.Windows.Forms.MessageBox.Show("[ Telegram Channel : @clean_tools_net ]", "BLTools v2.7.2", MessageBoxButtons.OK);
				Window window = new MainWindow();
				base.Close();
				window.ShowDialog();
			}
		}

		// Token: 0x04000083 RID: 131
		public static string versionText = " DZ";

		// Token: 0x04000084 RID: 132
		public static string accentColor = "LightBlue";

		// Token: 0x04000085 RID: 133
		private readonly PaletteHelper paletteHelper = new PaletteHelper();

		// Token: 0x0400008B RID: 139 RVA: 0x00002110 File Offset: 0x00000310
		private static int ReflectionOnlyAssemblyResolve;

		// Token: 0x0400008C RID: 140 RVA: 0x00002118 File Offset: 0x00000318
		private static int AppendFormatted;

		// Token: 0x0400008D RID: 141 RVA: 0x00002120 File Offset: 0x00000320
		private static int get_TimeStamp;

		// Token: 0x0400008E RID: 142 RVA: 0x00002128 File Offset: 0x00000328
		private static int Never;

		// Token: 0x0400008F RID: 143 RVA: 0x00002130 File Offset: 0x00000330
		private static int WaitHandleExtensions;
	}
}
