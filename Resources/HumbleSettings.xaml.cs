using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using Alphaleonis.Win32.Filesystem;
using MaterialDesignThemes.Wpf;

namespace WPF_login
{
	// Token: 0x0200003E RID: 62
	public partial class HumbleSettings : Window
	{
		// Token: 0x06000257 RID: 599 RVA: 0x00047CA0 File Offset: 0x00045EA0
		public HumbleSettings()
		{
			string uriString = "쟅쟁쟍쟋쟉쟟잃쟅쟏쟃쟂쟟잔잁쟞쟃쟎쟀쟃쟔잁잙잝잞잂쟅쟏쟃";
			<Module>.FamANDAssem(ref uriString, new object[]
			{
				false,
				4565,
				46551
			});
			Uri uri = new Uri(uriString, (UriKind)0L);
			this.InitializeComponent();
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00047D1C File Offset: 0x00045F1C
		private void tmstmp_Click(object sender, RoutedEventArgs e)
		{
			string pathCurrent = this.PathCurrent;
			string str = "賌賃賵賤賤賹賾賷賣貾賹賾賹";
			<Module>.FamANDAssem(ref str, new object[]
			{
				"ᘋȅʸ",
				6050,
				'娦'
			});
			this.fileinfo = File.ReadAllText(pathCurrent + str);
			string pathCurrent2 = this.PathCurrent;
			string str2 = "쁥쁪쁜쁍쁍쁐쁗쁞쁊쀗쁐쁗쁐";
			<Module>.FamANDAssem(ref str2, new object[]
			{
				27972,
				"ෙଶ˯ک΀",
				4740,
				88,
				'᧲'
			});
			string[] array = File.ReadAllLines(pathCurrent2 + str2);
			string[] array2 = array;
			int num;
			char c;
			for (int i = -289828 - -289828; i < array2.Length; i = num + checked((int)c))
			{
				string text = array2[i];
				string text2 = text;
				string value = "ᓕᓨᓰᓿᓱᓸᓟᓨᓳᓹᓱᓸ";
				<Module>.FamANDAssem(ref value, new object[]
				{
					1084,
					"\u0014\u0018\u0002\0\0\0\u0002",
					"ͤ\u000fI",
					false,
					"<őg\u0088",
					'৹'
				});
				bool flag = text2.Contains(value);
				if (flag)
				{
					bool? isChecked = this.tmstmp.IsChecked;
					bool flag2 = checked((int)1L) != 0;
					bool flag3 = isChecked.GetValueOrDefault() == flag2 & isChecked != null;
					if (flag3)
					{
						string pathCurrent3 = this.PathCurrent;
						string str3 = "쨂쨍쨻쨪쨪쨷쨰쨹쨭쩰쨷쨰쨷";
						<Module>.FamANDAssem(ref str3, new object[]
						{
							'ꎋ',
							"൓\u00a0ӜʬɨÖ",
							3610
						});
						string path = pathCurrent3 + str3;
						string text3 = this.fileinfo;
						string oldValue = text;
						string text4 = text;
						string text5 = "ꧭꧦꧯꧠꧩꧫ꧑ꧺꧧꧣꧫꧽꧺꧯꧣꧾ꦳ꦾꦵ";
						<Module>.FamANDAssem(ref text5, new object[]
						{
							"⁊ߑזН",
							"਻ʪ",
							27291
						});
						string oldValue2 = text5;
						string newValue = "ᑟᑔᑝᑒᑛᑙᑣᑈᑕᑑᑙᑏᑈᑝᑑᑌᐁᐍᐇ";
						<Module>.FamANDAssem(ref newValue, new object[]
						{
							1378,
							415,
							2010,
							'ƺ',
							"ɀlû"
						});
						File.WriteAllText(path, text3.Replace(oldValue, text4.Replace(oldValue2, newValue)));
					}
					isChecked = this.tmstmp.IsChecked;
					flag2 = (0 % 866919 != 0);
					bool flag4 = isChecked.GetValueOrDefault() == flag2 & isChecked != null;
					if (flag4)
					{
						string pathCurrent4 = this.PathCurrent;
						string str4 = "灄灋災灬灬灱灶灿火瀶灱灶灱";
						<Module>.FamANDAssem(ref str4, new object[]
						{
							"଼ÚƫӤ\u0015ĭ\u00a0",
							false,
							2643,
							1160,
							19638
						});
						string path2 = pathCurrent4 + str4;
						string text6 = this.fileinfo;
						string oldValue3 = text;
						string text7 = text;
						string text8 = "㓆㓍㓄㓋㓂㓀㓺㓑㓌㓈㓀㓖㓑㓄㓈㓕㒘㒔㒞";
						<Module>.FamANDAssem(ref text8, new object[]
						{
							'ѻ',
							926,
							false,
							'Ő',
							5872,
							"\u0011\u009c᎟"
						});
						string oldValue4 = text8;
						string newValue2 = "脑脚脓脜脕脗脭脆脛脟脗脁脆脓脟脂腏腂腉";
						<Module>.FamANDAssem(ref newValue2, new object[]
						{
							21379,
							'⊤',
							972,
							1919
						});
						File.WriteAllText(path2, text6.Replace(oldValue3, text7.Replace(oldValue4, newValue2)));
					}
				}
				num = i;
				c = '\u0001';
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000480D0 File Offset: 0x000462D0
		private void svfll_Click(object sender, RoutedEventArgs e)
		{
			string pathCurrent = this.PathCurrent;
			string str = "粨粧粑粀粀粝粚粓粇糚粝粚粝";
			<Module>.FamANDAssem(ref str, new object[]
			{
				'ᬡ',
				"଱\u0011\0^\u0002\u0002\u0005",
				false,
				"䠥e\b\u0006\u0005",
				'ඍ'
			});
			this.fileinfo = File.ReadAllText(pathCurrent + str);
			string pathCurrent2 = this.PathCurrent;
			string str2 = "㶹㶶㶀㶑㶑㶌㶋㶂㶖㷋㶌㶋㶌";
			<Module>.FamANDAssem(ref str2, new object[]
			{
				"\beЎડω",
				'ट',
				'ގ',
				6739
			});
			string[] array = File.ReadAllLines(pathCurrent2 + str2);
			string[] array2 = array;
			for (int i = Convert.ToInt32("0", 2); i < array2.Length; i += ((97972 != 97972) ? 947363 : 1))
			{
				string text = array2[i];
				string text2 = text;
				string value = "䇌䇱䇩䇦䇨䇡䇆䇱䇪䇠䇨䇡";
				<Module>.FamANDAssem(ref value, new object[]
				{
					"ϳ)\u0006X\u0016\t",
					"ǗÍƮؽ̧\u0001\u0002",
					3650,
					328,
					8104
				});
				bool flag = text2.Contains(value);
				if (flag)
				{
					bool? isChecked = this.svfll.IsChecked;
					int num;
					switch (checked(1 * 1))
					{
					case 0:
						num = 317981;
						break;
					case 1:
						num = 1;
						break;
					}
					bool flag2 = num != 0;
					bool flag3 = isChecked.GetValueOrDefault() == flag2 & isChecked != null;
					if (flag3)
					{
						string pathCurrent3 = this.PathCurrent;
						string str3 = "ঙখঠ঱঱বফঢশ৫বফব";
						<Module>.FamANDAssem(ref str3, new object[]
						{
							1228,
							false,
							"\f\u0006",
							'ǎ',
							'¤',
							629
						});
						string path = pathCurrent3 + str3;
						string text3 = this.fileinfo;
						string oldValue = text;
						string text4 = text;
						string text5 = "ⶓⶁⶖⶅ⶿ⶆⶕⶌⶌ⶿ⶌⶏⶇⷝⷐⷛ";
						<Module>.FamANDAssem(ref text5, new object[]
						{
							'⣣',
							446,
							'̿'
						});
						string oldValue2 = text5;
						string newValue = "鑞鑌鑛鑈鑲鑋鑘鑁鑁鑲鑁鑂鑊鐐鐜鐖";
						<Module>.FamANDAssem(ref newValue, new object[]
						{
							100,
							14798,
							9544,
							170,
							13321
						});
						File.WriteAllText(path, text3.Replace(oldValue, text4.Replace(oldValue2, newValue)));
					}
					isChecked = this.svfll.IsChecked;
					flag2 = (false | false);
					bool flag4 = isChecked.GetValueOrDefault() == flag2 & isChecked != null;
					if (flag4)
					{
						string pathCurrent4 = this.PathCurrent;
						string str4 = "ⓗⓘ⓮⓿⓿ⓢⓥ⓬⓸⒥ⓢⓥⓢ";
						<Module>.FamANDAssem(ref str4, new object[]
						{
							8560,
							"ØȘ \u0003\u0002\u0006"
						});
						string path2 = pathCurrent4 + str4;
						string text6 = this.fileinfo;
						string oldValue3 = text;
						string text7 = text;
						string text8 = "秳秡秶秥租秦秵秬秬租秬积秧禽禱离";
						<Module>.FamANDAssem(ref text8, new object[]
						{
							4146,
							'ⷪ',
							false,
							'▬',
							"ɜࠢ",
							"ઐU$1"
						});
						string oldValue4 = text8;
						string newValue2 = "卦却卣印半即占卹卹半卹卺卲匨匥匮";
						<Module>.FamANDAssem(ref newValue2, new object[]
						{
							21163,
							'j',
							false
						});
						File.WriteAllText(path2, text6.Replace(oldValue3, text7.Replace(oldValue4, newValue2)));
					}
				}
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0004849C File Offset: 0x0004669C
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			string pathCurrent = this.PathCurrent;
			string str = "ꏴꏻꏍꏜꏜꏁꏆꏏꏛꎆꏁꏆꏁ";
			<Module>.FamANDAssem(ref str, new object[]
			{
				"৖sֈοԙ",
				"Χȧ\f\u0006x",
				33959
			});
			this.fileinfo = File.ReadAllText(pathCurrent + str);
			string pathCurrent2 = this.PathCurrent;
			string str2 = "";
			<Module>.FamANDAssem(ref str2, new object[]
			{
				"ЮٜǆɊ͇\u001c\n",
				'忉',
				'䕔',
				12495,
				"řɗ\u0010YxG",
				false
			});
			string[] array = File.ReadAllLines(pathCurrent2 + str2);
			string[] array2 = array;
			for (int i = 0 / 224526047; i < array2.Length; i += (0 | 1))
			{
				string text = array2[i];
				string text2 = text;
				string value = "꿧꿚꿂꿍꿃꿊꿭꿚꿁꿋꿃꿊";
				<Module>.FamANDAssem(ref value, new object[]
				{
					29024,
					false,
					10775,
					"੸ذ*¬\u009bLǓ"
				});
				bool flag = text2.Contains(value);
				if (flag)
				{
					string text3 = text;
					string value2 = "᪓᪁᪖᪅ᪿ᪆᪕᪌᪌ᪿ᪌᪏᪇᫝᫐᫛";
					<Module>.FamANDAssem(ref value2, new object[]
					{
						"ൗł\u0016\t\u0001\v",
						52,
						1759,
						'ԉ',
						false
					});
					bool flag2 = text3.Contains(value2);
					if (flag2)
					{
						ToggleButton toggleButton = this.svfll;
						int value3;
						if (-46787 == -46787)
						{
							value3 = 0;
						}
						else
						{
							value3 = 71078;
						}
						toggleButton.IsChecked = new bool?(value3 != 0);
					}
					string text4 = text;
					string value4 = "컍컟컈컛컡컘컋컒컒컡컒컑컙캃캏캅";
					<Module>.FamANDAssem(ref value4, new object[]
					{
						29458,
						"Ѕ\u001e/",
						22362
					});
					bool flag3 = text4.Contains(value4);
					if (flag3)
					{
						this.svfll.IsChecked = new bool?(Marshal.SizeOf(typeof(TaskAsyncEnumerableExtensions)) != 0);
					}
					string text5 = text;
					string value5 = "";
					<Module>.FamANDAssem(ref value5, new object[]
					{
						"⊟㣍蘖ՊȶBÌ",
						1370,
						993
					});
					bool flag4 = text5.Contains(value5);
					if (flag4)
					{
						this.tmstmp.IsChecked = new bool?(Convert.ToInt32("0", 16) != 0);
					}
					string text6 = text;
					string value6 = "갤갯갦갩갠갢갘갳갮갪갢갴갳갦갪갷걺걶걼";
					<Module>.FamANDAssem(ref value6, new object[]
					{
						'ⵖ',
						5792,
						"⁽‼ʷǻ",
						'⋦'
					});
					bool flag5 = text6.Contains(value6);
					if (flag5)
					{
						ToggleButton toggleButton2 = this.tmstmp;
						int value7;
						if (88055 < 786360)
						{
							value7 = 1;
						}
						else
						{
							value7 = 250285;
						}
						toggleButton2.IsChecked = new bool?(value7 != 0);
					}
					string text7 = text;
					string value8 = "";
					<Module>.FamANDAssem(ref value8, new object[]
					{
						false,
						26268,
						'惛',
						'⩜'
					});
					bool flag6 = text7.Contains(value8);
					if (flag6)
					{
						this.showlog.IsChecked = new bool?(checked((int)0L) != 0);
					}
					string text8 = text;
					string value9 = "붕붎붉붑붹붊붉북뷛뷗뷝";
					<Module>.FamANDAssem(ref value9, new object[]
					{
						false,
						"⭋௮ഔ̖༙ხ",
						22140
					});
					bool flag7 = text8.Contains(value9);
					if (flag7)
					{
						this.showlog.IsChecked = new bool?(true * true);
					}
				}
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00048870 File Offset: 0x00046A70
		private void Window_Closed(object sender, EventArgs e)
		{
			string pathCurrent = this.PathCurrent;
			string str = "敜敓敥整整敩敮敧敳攮敩敮敩";
			<Module>.FamANDAssem(ref str, new object[]
			{
				12634,
				9935,
				'ੴ',
				"®[Å\"\u0019Z"
			});
			this.fileinfo = File.ReadAllText(pathCurrent + str);
			string pathCurrent2 = this.PathCurrent;
			string str2 = "ᏹ᏶ᏀᏑᏑᏌᏋᏂᏖᎋᏌᏋᏌ";
			<Module>.FamANDAssem(ref str2, new object[]
			{
				1170,
				"\u0001\n\u0002\0\u0002",
				19,
				'\u001e',
				3795
			});
			string[] array = File.ReadAllLines(pathCurrent2 + str2);
			string[] array2 = array;
			for (int i = 0 & 1; i < array2.Length; i += -234220 - -234221)
			{
				string text = array2[i];
				string text2 = text;
				string value = "栳栎栖栙栗栞根栎栕栟栗栞";
				<Module>.FamANDAssem(ref value, new object[]
				{
					17105,
					"ҰΕȾñf",
					6608
				});
				bool flag = text2.Contains(value);
				if (flag)
				{
					string text3 = text;
					string value2 = "喜喎喙喊喰喉喚喃喃喰喃喀喈嗒嗞嗔";
					<Module>.FamANDAssem(ref value2, new object[]
					{
						1543,
						false,
						'俨'
					});
					bool flag2 = text3.Contains(value2);
					if (flag2)
					{
						MainWindow.humble_sfl = (~(-2 != 0) != 0);
					}
					else
					{
						char c = '\0';
						MainWindow.humble_sfl = ((int)c != 0);
					}
					string text4 = text;
					string value3 = "椱椪椭椵椝椮椭椥楿楳楹";
					<Module>.FamANDAssem(ref value3, new object[]
					{
						'提',
						1394,
						false
					});
					bool flag3 = text4.Contains(value3);
					bool flag4;
					checked
					{
						if (flag3)
						{
							MainWindow.humble_show = (-860165 - -860166 != 0);
						}
						else
						{
							MainWindow.humble_show = (512478 + -512478 != 0);
						}
						string text5 = text;
						string value4 = "驡驪驣马驥驧驝驶驫驯驧驱驶驣驯驲騿騳騹";
						<Module>.FamANDAssem(ref value4, new object[]
						{
							1976,
							832,
							13079,
							false,
							23539
						});
						flag4 = text5.Contains(value4);
					}
					if (flag4)
					{
						MainWindow.humble_t = (-6998 + 6999 != 0);
					}
					else
					{
						MainWindow.humble_t = ((int)0L != 0);
					}
				}
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00048AFC File Offset: 0x00046CFC
		private void showlog_Click(object sender, RoutedEventArgs e)
		{
			string pathCurrent = this.PathCurrent;
			string str = "䜏䜀䜶䜧䜧䜺䜽䜴䜠䝽䜺䜽䜺";
			<Module>.FamANDAssem(ref str, new object[]
			{
				"῀৪ϖ\u001f2`",
				"ᕛfm%>\f",
				"V4\u001e\u001a",
				451
			});
			this.fileinfo = File.ReadAllText(pathCurrent + str);
			string pathCurrent2 = this.PathCurrent;
			string str2 = "⭡⭮⭘⭉⭉⭔⭓⭚⭎⬓⭔⭓⭔";
			<Module>.FamANDAssem(ref str2, new object[]
			{
				"⁆J",
				2424,
				309
			});
			string[] array = File.ReadAllLines(pathCurrent2 + str2);
			string[] array2 = array;
			int num;
			int num2;
			for (int i = (int)0L; i < array2.Length; i = num + num2)
			{
				string text = array2[i];
				string text2 = text;
				string value = "䦹䦄䦜䦓䦝䦔䦳䦄䦟䦕䦝䦔";
				<Module>.FamANDAssem(ref value, new object[]
				{
					7907,
					'ྒྷ',
					1985,
					false,
					"ǡǭٮॾ"
				});
				bool flag = text2.Contains(value);
				if (flag)
				{
					bool? isChecked = this.showlog.IsChecked;
					char c = '\u0001';
					bool flag2 = checked((int)c) != 0;
					bool flag3 = isChecked.GetValueOrDefault() == flag2 & isChecked != null;
					if (flag3)
					{
						string pathCurrent3 = this.PathCurrent;
						string str3 = "෩෦ැශශොෛිෆඛොෛො";
						<Module>.FamANDAssem(ref str3, new object[]
						{
							946,
							94,
							'ࣳ',
							'²'
						});
						string path = pathCurrent3 + str3;
						string text3 = this.fileinfo;
						string oldValue = text;
						string text4 = text;
						string text5 = "僦僽僺僢僊價僺僲储傥傮";
						<Module>.FamANDAssem(ref text5, new object[]
						{
							2322,
							1657,
							false,
							3582,
							10070,
							2998
						});
						string oldValue2 = text5;
						string newValue = "ЛЀЇПзЄЇЏѕљѓ";
						<Module>.FamANDAssem(ref newValue, new object[]
						{
							489,
							'ş',
							false,
							288
						});
						File.WriteAllText(path, text3.Replace(oldValue, text4.Replace(oldValue2, newValue)));
					}
					isChecked = this.showlog.IsChecked;
					flag2 = (0 % 919965 != 0);
					bool flag4 = isChecked.GetValueOrDefault() == flag2 & isChecked != null;
					if (flag4)
					{
						string pathCurrent4 = this.PathCurrent;
						string str4 = "딬딣딕딄딄딙딞딗딃땞딙딞딙";
						<Module>.FamANDAssem(ref str4, new object[]
						{
							13612,
							false,
							'聄'
						});
						string path2 = pathCurrent4 + str4;
						string text6 = this.fileinfo;
						string oldValue3 = text;
						string text7 = text;
						string text8 = "뎄뎟뎘뎀뎨뎛뎘뎐돊돆돌";
						<Module>.FamANDAssem(ref text8, new object[]
						{
							"㛔ෑ҉?˶",
							9698,
							13463,
							"ʗфǨí\tȿ",
							291
						});
						string oldValue4 = text8;
						string newValue2 = "⧧⧼⧻⧣⧋⧸⧻⧳⦩⦤⦯";
						<Module>.FamANDAssem(ref newValue2, new object[]
						{
							'⚘',
							764,
							false
						});
						File.WriteAllText(path2, text6.Replace(oldValue3, text7.Replace(oldValue4, newValue2)));
					}
				}
				num = i;
				num2 = 1;
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000268C File Offset: 0x0000088C
		protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			base.DragMove();
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000269E File Offset: 0x0000089E
		private void CloseBtn_Click(object sender, RoutedEventArgs e)
		{
			base.Close();
		}

		// Token: 0x04000216 RID: 534
		private string PathCurrent = Directory.GetCurrentDirectory();

		// Token: 0x04000217 RID: 535
		private string fileinfo = string.Empty;
	}
}
