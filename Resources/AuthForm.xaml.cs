using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Alphaleonis.Win32.Filesystem;
using CookiesTools;
using MaterialDesignThemes.Wpf;

namespace WPF_login
{
	// Token: 0x02000035 RID: 53
	public partial class AuthForm : Window
	{
		// Token: 0x060001FE RID: 510 RVA: 0x0003C748 File Offset: 0x0003A948
		public AuthForm()
		{
			this.PathCurrent = Directory.GetCurrentDirectory();
			this.fileinfo = string.Empty;
			this.keylic = string.Empty;
			new MainWindow().Show();
			base.Hide();
			if (true)
			{
				this.GetGrayTheme();
			}
			this.HelloUser();
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0003C79C File Offset: 0x0003A99C
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			string pathCurrent = this.PathCurrent;
			string str = "㿽㿭㿈㿂㿄㿏㿒㿄㾏㿅㿍㿍";
			<Module>.FamANDAssem(ref str, new object[]
			{
				false,
				9229,
				7060
			});
			bool flag = File.Exists(pathCurrent + str);
			if (flag)
			{
				string pathCurrent2 = this.PathCurrent;
				string str2 = "签筮筋筁筇筌筑筇笌筆筎筎";
				<Module>.FamANDAssem(ref str2, new object[]
				{
					549,
					4319,
					25655,
					538,
					"ãÅ\u0001\u001c\u0004\u0004"
				});
				this.fileinfo = File.ReadAllText(pathCurrent2 + str2);
				string text = this.fileinfo;
				string value = "⧬⧂⧞⦚";
				<Module>.FamANDAssem(ref value, new object[]
				{
					6140,
					3739,
					784
				});
				bool flag2 = text.Contains(value);
				if (flag2)
				{
					string strSource = this.fileinfo;
					string text2 = "࡮ࡀ࡜࠘";
					<Module>.FamANDAssem(ref text2, new object[]
					{
						385,
						"Ȏ[",
						"\v\u001e",
						'\u000f',
						1027
					});
					string strStart = text2;
					string strEnd = "医";
					<Module>.FamANDAssem(ref strEnd, new object[]
					{
						12351,
						8703,
						194
					});
					this.keylic = MainWindow.Pars(strSource, strStart, strEnd, -585625 + 585625);
				}
				else
				{
					string pathCurrent3 = this.PathCurrent;
					string str3 = "괈괘괽괷괱괺괧괱굺괰괸괸";
					<Module>.FamANDAssem(ref str3, new object[]
					{
						"⭺᩸ξ",
						'掤'
					});
					string path = pathCurrent3 + str3;
					string contents = "᤽ᤓᤏ᥋᥍";
					<Module>.FamANDAssem(ref contents, new object[]
					{
						'ɦ',
						5904
					});
					File.WriteAllText(path, contents);
				}
			}
			else
			{
				string pathCurrent4 = this.PathCurrent;
				string str4 = "館屮神﨓凞羽糖凞艹﨔靖靖";
				<Module>.FamANDAssem(ref str4, new object[]
				{
					27697,
					2414,
					'蓑',
					false
				});
				string path2 = pathCurrent4 + str4;
				string contents2 = "㝯㝁㝝㜙㜟";
				<Module>.FamANDAssem(ref contents2, new object[]
				{
					9585,
					4531
				});
				File.WriteAllText(path2, contents2);
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0003CA5C File Offset: 0x0003AC5C
		private void HelloUser()
		{
			this.HelloText.Text = "";
			TextElementCollection<Inline> inlines = this.HelloText.Inlines;
			string text = "ꖥꖈꖁꖁꖂꗁꗍ";
			<Module>.FamANDAssem(ref text, new object[]
			{
				false,
				39812,
				"߃ĒÇÍ"
			});
			inlines.Add(new Run(text)
			{
				Foreground = Brushes.LightGray
			});
			string accentColor = SplashScreen.accentColor;
			string b = "";
			<Module>.FamANDAssem(ref b, new object[]
			{
				46108,
				1292,
				':',
				"Ώ̠M\u0018",
				11533
			});
			bool flag = accentColor == b;
			if (flag)
			{
				TextElementCollection<Inline> inlines2 = this.HelloText.Inlines;
				Run run = new Run(Environment.UserName);
				int num;
				switch (1319621764 / 1319621764)
				{
				case 0:
					num = -960430;
					break;
				case 1:
					num = 144;
					break;
				}
				byte r = (byte)num;
				char c = 'î';
				run.Foreground = new SolidColorBrush(Color.FromRgb(r, (byte)((int)c), 0 | 144));
				inlines2.Add(new Bold(run));
			}
			string accentColor2 = SplashScreen.accentColor;
			string b2 = "";
			<Module>.FamANDAssem(ref b2, new object[]
			{
				"̙ĂĲ",
				34683,
				25954
			});
			bool flag2 = accentColor2 == b2;
			if (flag2)
			{
				TextElementCollection<Inline> inlines3 = this.HelloText.Inlines;
				Run run2 = new Run(Environment.UserName);
				char c2 = 'd';
				byte r2 = (byte)((int)c2);
				int g;
				if (10450 >= 773873)
				{
					g = -392217;
				}
				else
				{
					g = 150;
				}
				run2.Foreground = new SolidColorBrush(Color.FromRgb(r2, (byte)g, (byte)<Module>.Cgt[0]));
				inlines3.Add(new Bold(run2));
			}
			string accentColor3 = SplashScreen.accentColor;
			string b3 = "羙羯羫羍羸羯羯群";
			<Module>.FamANDAssem(ref b3, new object[]
			{
				14467,
				18247
			});
			bool flag3 = accentColor3 == b3;
			if (flag3)
			{
				this.HelloText.Inlines.Add(new Bold(new Run(Environment.UserName)
				{
					Foreground = new SolidColorBrush(Color.FromRgb((byte)AuthForm.TryGetArray, (byte)(checked((int)178L)), (byte)((17466 != 17466) ? 457050 : 170)))
				}));
			}
			string accentColor4 = SplashScreen.accentColor;
			string b4 = "㫲㫗㫙㫖㫊㫽㫑㫌㫟㫒";
			<Module>.FamANDAssem(ref b4, new object[]
			{
				"Ƅкϩ\u0004\u0004\u0006\u0002",
				"ЍŪÄ",
				10956
			});
			bool flag4 = accentColor4 == b4;
			if (flag4)
			{
				this.HelloText.Inlines.Add(new Bold(new Run(Environment.UserName)
				{
					Foreground = new SolidColorBrush(Color.FromRgb((byte)(564490560 / 2352044), (byte)(-73910 - -74038), (byte)(-707155 + 707283)))
				}));
			}
			string accentColor5 = SplashScreen.accentColor;
			string b5 = "ﮮﮋﮅﮊﮖﮱﮃﮎﮏﮍﮌ";
			<Module>.FamANDAssem(ref b5, new object[]
			{
				3956,
				60526
			});
			bool flag5 = accentColor5 == b5;
			if (flag5)
			{
				this.HelloText.Inlines.Add(new Bold(new Run(Environment.UserName)
				{
					Foreground = new SolidColorBrush(Color.FromRgb((byte)Convert.ToInt32("ff", 16), (byte)(1285 >> 3), (byte)(64101183 >> 19)))
				}));
			}
			string accentColor6 = SplashScreen.accentColor;
			string b6 = "ᐴᐑᐟᐐᐌᐨᐑᐖᐓ";
			<Module>.FamANDAssem(ref b6, new object[]
			{
				4336,
				"Ɂ\u0090·"
			});
			bool flag6 = accentColor6 == b6;
			checked
			{
				if (flag6)
				{
					this.HelloText.Inlines.Add(new Bold(new Run(Environment.UserName)
					{
						Foreground = new SolidColorBrush(Color.FromRgb((byte)Convert.ToInt32("10111110", 2), (byte)(-15 * -7), (byte)Marshal.SizeOf(typeof(Initialized))))
					}));
				}
				string accentColor7 = SplashScreen.accentColor;
				string b7 = "ڭژڏڏڄ";
				<Module>.FamANDAssem(ref b7, new object[]
				{
					1114,
					false,
					216,
					127,
					134,
					"\u009a\u0015\u0001\u0003"
				});
				bool flag7 = accentColor7 == b7;
				if (flag7)
				{
					this.HelloText.Inlines.Add(new Bold(new Run(Environment.UserName)
					{
						Foreground = new SolidColorBrush(Color.FromRgb(25 | 6, (byte)(975 % 390), 17 | 25))
					}));
				}
				string accentColor8 = SplashScreen.accentColor;
				string b8 = "";
				<Module>.FamANDAssem(ref b8, new object[]
				{
					'\udec6',
					false,
					3602,
					861
				});
				bool flag8 = accentColor8 == b8;
				if (flag8)
				{
					TextElementCollection<Inline> inlines4 = this.HelloText.Inlines;
					Run run3 = new Run(Environment.UserName);
					byte r3 = (byte)((int)255L);
					byte g2 = (byte)((int)255L);
					int b9 = 255;
					run3.Foreground = new SolidColorBrush(Color.FromRgb(r3, g2, (byte)b9));
					inlines4.Add(new Bold(run3));
				}
				string accentColor9 = SplashScreen.accentColor;
				string b10 = "ڦڑڐ";
				<Module>.FamANDAssem(ref b10, new object[]
				{
					759,
					"Τ\u0005\u0016\u00051\u0002\u0006"
				});
				bool flag9 = accentColor9 == b10;
				if (flag9)
				{
					this.HelloText.Inlines.Add(new Bold(new Run(Environment.UserName)
					{
						Foreground = new SolidColorBrush(Color.FromRgb((byte)(-710236 - -710411), (byte)(0 % 501596), (byte)(-518720 + 518720)))
					}));
				}
			}
			this.HelloText.TextWrapping = (TextWrapping)5385 - 5383;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0003D084 File Offset: 0x0003B284
		private void GetBlackTheme()
		{
			this.set_ThemeAuth.Background = new SolidColorBrush(Color.FromRgb((byte)Convert.ToInt32("110", 2), (byte)(checked(-285208 + 285214)), (byte)((160 <= 358455) ? 6 : -555800)));
			ITheme theme = this.paletteHelper.GetTheme();
			theme.SetBaseTheme(Theme.Dark);
			this.paletteHelper.SetTheme(theme);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0003D0F8 File Offset: 0x0003B2F8
		private void GetDarkTheme()
		{
			char[] array = new char[]
			{
				'\u0011'
			};
			this.set_ThemeAuth.Background = new SolidColorBrush(Color.FromRgb((byte)(~(byte)-18), (byte)array[0], (byte)array[0]));
			ITheme theme = this.paletteHelper.GetTheme();
			theme.SetBaseTheme(Theme.Dark);
			this.paletteHelper.SetTheme(theme);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0003D158 File Offset: 0x0003B358
		private void GetGrayTheme()
		{
			this.set_ThemeAuth.Background = new SolidColorBrush(Color.FromRgb((byte)Convert.ToInt32("45", 8), 180 % 72, (byte)Marshal.SizeOf(typeof(_WriteAsync_d__36))));
			ITheme theme = this.paletteHelper.GetTheme();
			theme.SetBaseTheme(Theme.Dark);
			this.paletteHelper.SetTheme(theme);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000268C File Offset: 0x0000088C
		protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			base.DragMove();
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0003D1C4 File Offset: 0x0003B3C4
		private void checkLic()
		{
			char[] array = new char[]
			{
				'\u0001'
			};
			try
			{
				Process[] processes = Process.GetProcesses();
				Process[] array2 = processes;
				int i = AuthForm.FormatSignature;
				while (i < array2.Length)
				{
					Process process = array2[i];
					string text = process.MainWindowTitle;
					text = text.ToLower();
					string text2 = text;
					string value = "뗨뗧뗳뗼";
					<Module>.FamANDAssem(ref value, new object[]
					{
						'㛳',
						false,
						"ţ\u0005\u001b\b\0\u0003",
						'確',
						'ы'
					});
					if (text2.Contains(value))
					{
						goto IL_848;
					}
					string text3 = text;
					string value2 = "뭗뭀뭄뭆뭑뭊뭗";
					<Module>.FamANDAssem(ref value2, new object[]
					{
						457,
						30144,
						false,
						"'1\u000f\u0006\u0010\u000e",
						6910,
						10259
					});
					if (text3.Contains(value2))
					{
						goto IL_848;
					}
					string text4 = text;
					string value3 = "墈墏墋墔墀墏";
					<Module>.FamANDAssem(ref value3, new object[]
					{
						"ഏࢃൠ",
						13807
					});
					if (text4.Contains(value3))
					{
						goto IL_848;
					}
					string text5 = text;
					string value4 = "";
					<Module>.FamANDAssem(ref value4, new object[]
					{
						"̼૓",
						10114,
						'䍊',
						false,
						18526,
						"ޱᛇവӞ"
					});
					if (text5.Contains(value4))
					{
						goto IL_848;
					}
					string text6 = text;
					string value5 = "쁮쁴쁶쁫쁢쁭쁨쁡쁶";
					<Module>.FamANDAssem(ref value5, new object[]
					{
						25768,
						2647,
						5956,
						"ጲ◀Q~"
					});
					if (text6.Contains(value5))
					{
						goto IL_848;
					}
					string text7 = text;
					string value6 = "";
					<Module>.FamANDAssem(ref value6, new object[]
					{
						181,
						245,
						18573,
						43364
					});
					if (text7.Contains(value6))
					{
						goto IL_848;
					}
					string text8 = text;
					string value7 = "㽋㽄㽋㽆㽓㽐㽏㽘";
					<Module>.FamANDAssem(ref value7, new object[]
					{
						'⚢',
						"࢒࿶"
					});
					if (text8.Contains(value7))
					{
						goto IL_848;
					}
					string text9 = text;
					string value8 = "쟳쟯쟯쟫잻쟯쟴쟴쟷쟰쟲쟯";
					<Module>.FamANDAssem(ref value8, new object[]
					{
						7094,
						6351,
						'Ⱶ',
						false,
						'暡'
					});
					if (text9.Contains(value8))
					{
						goto IL_848;
					}
					string text10 = text;
					string value9 = "祏祄祍神祀祉祟";
					<Module>.FamANDAssem(ref value9, new object[]
					{
						21124,
						9896
					});
					if (text10.Contains(value9))
					{
						goto IL_848;
					}
					string text11 = text;
					string value10 = "迺迭迮迤迭迫迼迧迺";
					<Module>.FamANDAssem(ref value10, new object[]
					{
						"\u001e\u0016\v\u001a\u0004\u0012",
						false,
						1407,
						'ዲ',
						22074,
						8302
					});
					if (text11.Contains(value10))
					{
						goto IL_848;
					}
					string text12 = text;
					string value11 = "\udc56\udc43\udc06\udc43\udc5e\udc56\udc4a\udc49\udc54\udc43\udc54";
					<Module>.FamANDAssem(ref value11, new object[]
					{
						6674,
						49684
					});
					if (text12.Contains(value11))
					{
						goto IL_848;
					}
					string text13 = text;
					string value12 = "\uda42\uda55\uda56\uda5c\uda55\uda48\uda59\uda5c";
					<Module>.FamANDAssem(ref value12, new object[]
					{
						14271,
						'ꉱ'
					});
					if (text13.Contains(value12))
					{
						goto IL_848;
					}
					string text14 = text;
					string value13 = "≍≟≟≉≁≎≀≕";
					<Module>.FamANDAssem(ref value13, new object[]
					{
						"Ŀఢ",
						false,
						5323
					});
					if (text14.Contains(value13))
					{
						goto IL_848;
					}
					string text15 = text;
					string value14 = "鞈鞕鞈鞄鞃鞋鞂";
					<Module>.FamANDAssem(ref value14, new object[]
					{
						'ପ',
						'፠',
						22171,
						7879,
						1025
					});
					if (text15.Contains(value14))
					{
						goto IL_848;
					}
					string text16 = text;
					string value15 = "妜妝妚妍妟妟妝妊";
					<Module>.FamANDAssem(ref value15, new object[]
					{
						9594,
						false,
						13107,
						"ÍI\u000e\0!\u0004\u0002"
					});
					if (text16.Contains(value15))
					{
						goto IL_848;
					}
					string text17 = text;
					string value16 = "톋톗톗톓퇃톇톆톁톖톄";
					<Module>.FamANDAssem(ref value16, new object[]
					{
						"ઓ⾆㬾૫̘ЂӐ",
						false,
						17847
					});
					if (text17.Contains(value16))
					{
						goto IL_848;
					}
					string mainWindowTitle = process.MainWindowTitle;
					string value17 = "諸諤諤諠諴諕諒諅諗";
					<Module>.FamANDAssem(ref value17, new object[]
					{
						false,
						45,
						15,
						'&',
						"\u000f&\b",
						'訑'
					});
					if (mainWindowTitle.Contains(value17))
					{
						goto IL_848;
					}
					string text18 = text;
					string value18 = "몪몥모모몠목몾";
					<Module>.FamANDAssem(ref value18, new object[]
					{
						4706,
						false,
						27545,
						3016,
						'ㄉ'
					});
					if (text18.Contains(value18))
					{
						goto IL_848;
					}
					string text19 = text;
					string value19 = "뮫뮵뮮뮹뮯뮴뮽뮮뮷";
					<Module>.FamANDAssem(ref value19, new object[]
					{
						'父',
						'䦦'
					});
					if (text19.Contains(value19))
					{
						goto IL_848;
					}
					string text20 = text;
					string value20 = "娨婶婥婧婶";
					<Module>.FamANDAssem(ref value20, new object[]
					{
						2059,
						15830,
						"ᆿŃ+©L\u0003"
					});
					if (text20.Contains(value20))
					{
						goto IL_848;
					}
					string text21 = text;
					string value21 = "鉳鉸鉵鉱鉤鈰鉵鉾鉷鉹鉾鉵";
					<Module>.FamANDAssem(ref value21, new object[]
					{
						639,
						false,
						16079,
						20674
					});
					if (text21.Contains(value21))
					{
						goto IL_848;
					}
					string text22 = text;
					string value22 = "뵡뵮뵿뵩뵹뵪뵢뵥뵸";
					<Module>.FamANDAssem(ref value22, new object[]
					{
						'諌',
						's',
						11930,
						818
					});
					if (text22.Contains(value22))
					{
						goto IL_848;
					}
					string text23 = text;
					string value23 = "㾽㾶㾭㾩㾼㾼㾲";
					<Module>.FamANDAssem(ref value23, new object[]
					{
						5242,
						1688,
						9147,
						"e§"
					});
					if (text23.Contains(value23))
					{
						goto IL_848;
					}
					string text24 = text;
					string value24 = "ႸႻႻႮႳႵႰ";
					<Module>.FamANDAssem(ref value24, new object[]
					{
						79,
						"в=º",
						'Ɏ',
						2321
					});
					if (text24.Contains(value24))
					{
						goto IL_848;
					}
					string text25 = text;
					string value25 = "";
					<Module>.FamANDAssem(ref value25, new object[]
					{
						6277,
						28155,
						'挮'
					});
					if (text25.Contains(value25))
					{
						goto IL_848;
					}
					string text26 = text;
					string value26 = "藕藟藂藁藈";
					<Module>.FamANDAssem(ref value26, new object[]
					{
						5630,
						5168,
						"㈓וóF\u001a\u0016\u0002",
						"\r5⇮"
					});
					bool flag = text26.Contains(value26);
					IL_84B:
					bool flag2 = flag;
					if (flag2)
					{
						process.Kill();
					}
					i += sizeof(sbyte);
					continue;
					IL_848:
					flag = checked(true * true);
					goto IL_84B;
				}
				Process[] array3 = processes;
				int j = Convert.ToInt32("0", 16);
				while (j < array3.Length)
				{
					Process process2 = array3[j];
					string text27 = process2.ProcessName;
					text27 = text27.ToLower();
					string text28 = text27;
					string value27 = "､ｫｿｰ";
					<Module>.FamANDAssem(ref value27, new object[]
					{
						12424,
						18174,
						11279,
						6570,
						'䇋'
					});
					if (text28.Contains(value27))
					{
						goto IL_FA3;
					}
					string text29 = text27;
					string value28 = "쇰쇧쇣쇡쇶쇭쇰";
					<Module>.FamANDAssem(ref value28, new object[]
					{
						'灘',
						18032,
						"ਠg\"\b\u0003\u0006"
					});
					if (text29.Contains(value28))
					{
						goto IL_FA3;
					}
					string text30 = text27;
					string value29 = "薥薧薰薭薲薥薰薫薶";
					<Module>.FamANDAssem(ref value29, new object[]
					{
						14010,
						'ᒔ',
						'ᜃ',
						'⍳'
					});
					if (text30.Contains(value29))
					{
						goto IL_FA3;
					}
					string text31 = text27;
					string value30 = "姚姆姆姂姖姗姐姇姕姕姗姀姇姛";
					<Module>.FamANDAssem(ref value30, new object[]
					{
						3477,
						'࿠',
						'ᴣ',
						'Ἒ'
					});
					if (text31.Contains(value30))
					{
						goto IL_FA3;
					}
					string text32 = text27;
					string value31 = "\ud99e\ud982\ud982\ud986\ud9d6\ud982\ud999\ud999\ud99a\ud99d\ud99f\ud982";
					<Module>.FamANDAssem(ref value31, new object[]
					{
						false,
						6536,
						'֮',
						"̽՘",
						45611
					});
					if (text32.Contains(value31))
					{
						goto IL_FA3;
					}
					string text33 = text27;
					string value32 = "";
					<Module>.FamANDAssem(ref value32, new object[]
					{
						"Ꮾュ᧯͇௷ࠒȘ",
						'❄',
						'ዄ',
						7160,
						8358
					});
					if (text33.Contains(value32))
					{
						goto IL_FA3;
					}
					string text34 = text27;
					string value33 = "핌핏핏핚핇핁필";
					<Module>.FamANDAssem(ref value33, new object[]
					{
						7530,
						8607,
						19199,
						574,
						18653
					});
					if (text34.Contains(value33))
					{
						goto IL_FA3;
					}
					string text35 = text27;
					string value34 = "ⅻⅴⅹⅹⅱⅸⅯ";
					<Module>.FamANDAssem(ref value34, new object[]
					{
						3718,
						'ኗ'
					});
					if (text35.Contains(value34))
					{
						goto IL_FA3;
					}
					string text36 = text27;
					string value35 = "쥟쥔쥙쥝쥈쥙쥒쥛쥕쥒쥙";
					<Module>.FamANDAssem(ref value35, new object[]
					{
						23979,
						9039,
						8145,
						10353
					});
					if (text36.Contains(value35))
					{
						goto IL_FA3;
					}
					string text37 = text27;
					string value36 = "";
					<Module>.FamANDAssem(ref value36, new object[]
					{
						'歆',
						"ؚ᳁ًƽ\u001b\fĀ",
						false,
						"ࣟம",
						17592
					});
					if (text37.Contains(value36))
					{
						goto IL_FA3;
					}
					string text38 = text27;
					string value37 = "㉋㉀㉛㉟㉊㉊㉄";
					<Module>.FamANDAssem(ref value37, new object[]
					{
						494,
						9563,
						1253,
						1012,
						525
					});
					if (text38.Contains(value37))
					{
						goto IL_FA3;
					}
					string text39 = text27;
					string value38 = "㵶㵹㵨㵾㵮㵽㵵㵲㵯";
					<Module>.FamANDAssem(ref value38, new object[]
					{
						'ⱜ',
						4288
					});
					if (text39.Contains(value38))
					{
						goto IL_FA3;
					}
					string text40 = text27;
					string value39 = "鍐鍝鍇鍕鍇鍙";
					<Module>.FamANDAssem(ref value39, new object[]
					{
						'垍',
						15271
					});
					if (text40.Contains(value39))
					{
						goto IL_FA3;
					}
					string text41 = text27;
					string value40 = "\udc34\udc2f\udc20\udc27\udc30\udc20\udc26";
					<Module>.FamANDAssem(ref value40, new object[]
					{
						6092,
						"糺㧦ඩ"
					});
					if (text41.Contains(value40))
					{
						goto IL_FA3;
					}
					string text42 = text27;
					string value41 = "\udde2\uddf5\uddf6\uddfc\uddf5\uddf3\udde4\uddff\udde2";
					<Module>.FamANDAssem(ref value41, new object[]
					{
						1724,
						"溞ዧ",
						"ѵˣ",
						19672,
						287
					});
					if (text42.Contains(value41))
					{
						goto IL_FA3;
					}
					string text43 = text27;
					string value42 = "늫늱늳늮늧늨늭늤늳";
					<Module>.FamANDAssem(ref value42, new object[]
					{
						21900,
						1473,
						'ᛷ',
						false,
						"̤Óȝ\u0083\u0096Ñ",
						"㠏p"
					});
					if (text43.Contains(value42))
					{
						goto IL_FA3;
					}
					string text44 = text27;
					string value43 = "㰖㰃㰃㰞㰖㰊㰉㰔㰃㰔";
					<Module>.FamANDAssem(ref value43, new object[]
					{
						"ା؂\r\v\u0002\0\u0002",
						4530,
						'ᥘ'
					});
					if (text44.Contains(value43))
					{
						goto IL_FA3;
					}
					string text45 = text27;
					string value44 = "鬴鬣鬠鬪鬣鬾鬯鬪";
					<Module>.FamANDAssem(ref value44, new object[]
					{
						11480,
						28270,
						false
					});
					if (text45.Contains(value44))
					{
						goto IL_FA3;
					}
					string text46 = text27;
					string value45 = "᜗ᜅᜅᜓ᜛᜔᜚ᜏ";
					<Module>.FamANDAssem(ref value45, new object[]
					{
						"Ѵஈ",
						1914
					});
					if (text46.Contains(value45))
					{
						goto IL_FA3;
					}
					string text47 = text27;
					string value46 = "ㇽ㇠ㇽㇱㇶㇾㇷ";
					<Module>.FamANDAssem(ref value46, new object[]
					{
						11870,
						false,
						705,
						7,
						113,
						true
					});
					if (text47.Contains(value46))
					{
						goto IL_FA3;
					}
					string text48 = text27;
					string value47 = "එඏඔඃඕඎඇඔඍ";
					<Module>.FamANDAssem(ref value47, new object[]
					{
						2177,
						308,
						'ʔ',
						336,
						false,
						77
					});
					if (text48.Contains(value47))
					{
						goto IL_FA3;
					}
					string text49 = text27;
					string value48 = "ꩮꩤ꩹ꩺꩳ";
					<Module>.FamANDAssem(ref value48, new object[]
					{
						6688,
						'㋁',
						23849
					});
					bool flag3 = text49.Contains(value48);
					IL_FAE:
					bool flag4 = flag3;
					if (flag4)
					{
						process2.Kill();
					}
					j += Marshal.SizeOf(typeof(TaskAsyncEnumerableExtensions));
					continue;
					IL_FA3:
					flag3 = ((16888 ^ 16889) != 0);
					goto IL_FAE;
				}
			}
			catch (Exception ex)
			{
				MainWindow.loadslogs = (Convert.ToInt32("0", 2) != 0);
				this.ld = (string.Empty.Length != 0);
			}
			AuthForm.KeyAuthApp.init();
			bool flag5 = (AuthForm.KeyAuthApp.response.success ? 1 : 0) == AuthForm.FormatSignature;
			if (flag5)
			{
				MainWindow.loadslogs = (checked(-816809 + 816809) != 0);
				int num;
				if (62417 != -67649)
				{
					num = 0;
				}
				else
				{
					num = -156160;
				}
				this.ld = (num != 0);
			}
			AuthForm.KeyAuthApp.check();
			AuthForm.KeyAuthApp.license(this.keylic);
			bool success = AuthForm.KeyAuthApp.response.success;
			if (success)
			{
				MainWindow.keylic = this.keylic;
				MainWindow.loadslogs = (array[0] != '\0');
				this.ld = (5 % 2 != 0);
				string pathCurrent = this.PathCurrent;
				string str = "༌༜༹༳༵༾༣༵ཾ༴༼༼";
				<Module>.FamANDAssem(ref str, new object[]
				{
					"Ŵº\u0001õD\u0004",
					false,
					1795,
					"\u0001\t",
					429,
					810
				});
				string path = pathCurrent + str;
				string text50 = "彾彐彌弈";
				<Module>.FamANDAssem(ref text50, new object[]
				{
					"ྻ˧",
					'L',
					false,
					'䱇'
				});
				string str2 = text50;
				string str3 = this.keylic;
				string str4 = "";
				<Module>.FamANDAssem(ref str4, new object[]
				{
					23681,
					'⇜',
					"岲૑ږǘ"
				});
				File.WriteAllText(path, str2 + str3 + str4);
			}
			else
			{
				MainWindow.loadslogs = (AuthForm.FormatSignature != 0);
				this.ld = (0 % 463170 != 0);
				string message = AuthForm.KeyAuthApp.response.message;
				string caption = "竬竏竇竉竎窀童竒竒竏竒";
				<Module>.FamANDAssem(ref caption, new object[]
				{
					15027,
					"ᆉอॵƏʼ\a",
					"\f\"\v#",
					'Ŀ',
					4309
				});
				MessageBox.Show(message, caption, ~(MessageBoxButton)(-1), (MessageBoxImage)sizeof(Guid));
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0003E418 File Offset: 0x0003C618
		[DebuggerStepThrough]
		private void loginBtn_Click(object sender, RoutedEventArgs e)
		{
			AuthForm.<loginBtn_Click>d__14 <loginBtn_Click>d__ = new AuthForm.<loginBtn_Click>d__14();
			<loginBtn_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<loginBtn_Click>d__.<>4__this = this;
			<loginBtn_Click>d__.sender = sender;
			<loginBtn_Click>d__.e = e;
			<loginBtn_Click>d__.<>1__state = checked(-1 * 1);
			<loginBtn_Click>d__.<>t__builder.Start<AuthForm.<loginBtn_Click>d__14>(ref <loginBtn_Click>d__);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002B17 File Offset: 0x00000D17
		private void CloseBtn_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002B25 File Offset: 0x00000D25
		private void Window_Closed(object sender, EventArgs e)
		{
			MainWindow.process.Kill();
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0003E5F4 File Offset: 0x0003C7F4
		static AuthForm()
		{
			string text = "棃棍棕森森棭棲";
			<Module>.FamANDAssem(ref text, new object[]
			{
				21676,
				5077
			});
			string name = text;
			string text2 = "";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				"ʵǊV;\u0001\0\u0002",
				50469,
				"\u001e|¥Ʀ",
				9488,
				false
			});
			string ownerid = text2;
			string text3 = "筀笔笖笔筈筅筅筅筃筃笕筅筄笒等筁笒筃筄筇笕笔笔筄笕筄筁笒笖筈笖筈笕笒筃笔笔笕筀笕笖笓筅笑笑筈筆笒筂筃筀筈筇筄筆筆筇笑筁笑筇筄筃笔";
			<Module>.FamANDAssem(ref text3, new object[]
			{
				17096,
				"ሔᦶ֘",
				421,
				false,
				'֡'
			});
			string secret = text3;
			string version = "毃毟毆毟毃";
			<Module>.FamANDAssem(ref version, new object[]
			{
				'摅',
				820,
				171,
				341,
				632
			});
			AuthForm.KeyAuthApp = new api(name, ownerid, secret, version);
		}

		// Token: 0x040001C1 RID: 449
		private string fileinfo;

		// Token: 0x040001C2 RID: 450
		private string keylic;

		// Token: 0x040001C3 RID: 451
		private bool ld;

		// Token: 0x040001C4 RID: 452
		private string PathCurrent;

		// Token: 0x040001C5 RID: 453
		public static api KeyAuthApp;

		// Token: 0x040001C6 RID: 454
		private readonly PaletteHelper paletteHelper;

		// Token: 0x040001CF RID: 463 RVA: 0x00002110 File Offset: 0x00000310
		private static int FormatSignature;

		// Token: 0x040001D0 RID: 464 RVA: 0x00002158 File Offset: 0x00000358
		private static int TryGetArray;
	}
}
