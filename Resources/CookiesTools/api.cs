using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace CookiesTools
{
	// Token: 0x02000004 RID: 4
	public class api
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00003000 File Offset: 0x00001200
		public api(string name, string ownerid, string secret, string version)
		{
			bool flag = ((string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret)) ? Convert.ToInt32("1", 2) : (string.IsNullOrWhiteSpace(version) ? 1 : 0)) != 0;
			if (flag)
			{
				string message = "盷盆盆盚盟盕盗盂盟盙盘皖盘盙盂皖盅盓盂盃盆皖盕盙盄盄盓盕盂盚盏皘";
				<Module>.FamANDAssem(ref message, new object[]
				{
					"࣭ȭٓఁ",
					10674,
					"⟿֧ǰ",
					false
				});
				api.error(message);
				Environment.Exit(0 * -411738);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000030E4 File Offset: 0x000012E4
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			string text2 = "ࠉࠄࠍ࠘";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				false,
				'ϱ',
				'g',
				1061
			});
			string text3 = text2;
			Encoding @default = Encoding.Default;
			string s = "伙伞伙伄";
			<Module>.FamANDAssem(ref s, new object[]
			{
				"ಏ໸",
				'㏩'
			});
			nameValueCollection[text3] = encryption.byte_arr_to_str(@default.GetBytes(s));
			string text4 = "ဋဘဏ";
			<Module>.FamANDAssem(ref text4, new object[]
			{
				'ઙ',
				"Ԫ~\u0013\u001c\u0001\u0006\u0006"
			});
			nameValueCollection[text4] = encryption.encrypt(this.version, this.secret, text);
			string text5 = "鄌鄅鄗鄌";
			<Module>.FamANDAssem(ref text5, new object[]
			{
				30609,
				false,
				'᧓'
			});
			nameValueCollection[text5] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			string text6 = "楎楅楈楀楎楒";
			<Module>.FamANDAssem(ref text6, new object[]
			{
				2207,
				5623,
				"ᰊሇјᗭȿ"
			});
			nameValueCollection[text6] = encryption.encrypt(this.enckey, this.secret, text);
			string text7 = "쭪쭥쭩쭡";
			<Module>.FamANDAssem(ref text7, new object[]
			{
				40688,
				'Ⱄ'
			});
			nameValueCollection[text7] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			string text8 = "敖愈晴漢揄殺瀞";
			<Module>.FamANDAssem(ref text8, new object[]
			{
				"ź⟅⋔",
				false,
				14353,
				30427
			});
			nameValueCollection[text8] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			string text9 = "᎙᎞᎙ᎄᎯ᎙ᎆ";
			<Module>.FamANDAssem(ref text9, new object[]
			{
				2448,
				1750,
				906,
				false
			});
			nameValueCollection[text9] = text;
			NameValueCollection post_data = nameValueCollection;
			string text10 = api.req(post_data);
			string a = text10;
			string b = "혮혀혜혤혐협혍혺혬혋혓현혉혌혁";
			<Module>.FamANDAssem(ref b, new object[]
			{
				'ബ',
				21729,
				'䳆',
				false,
				'ᄷ',
				5723
			});
			bool flag = a == b;
			if (flag)
			{
				string message = "ᚱ\u1680\u1680᚜ᚙᚓᚑᚄᚙ᚟᚞ᛐ᚞᚟ᚄᛐᚖ᚟ᚅ᚞ᚔᛞᛐᚠ᚜ᚕᚑᚃᚕᛐᚓᚘᚕᚓ᚛ᛐᚉ᚟ᚅᚂᛐᚑ\u1680\u1680᚜ᚙᚓᚑᚄᚙ᚟᚞ᛐ᚞ᚑ᚝ᚕᛜᛐᚃᚕᚓᚂᚕᚄᛜᛐ᚟ᚇ᚞ᚕᚂᚹᚴᛜᛐᚑ᚞ᚔᛐᚆᚕᚂᚃᚙ᚟᚞ᛞ";
				<Module>.FamANDAssem(ref message, new object[]
				{
					'೾',
					2546
				});
				api.error(message);
				Environment.Exit(checked((int)0L));
			}
			text10 = encryption.decrypt(text10, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text10);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_app_data(response_structure.appinfo);
				this.sessionid = response_structure.sessionid;
				this.initialized = (-763031 + 763032 != 0);
			}
			else
			{
				string message2 = response_structure.message;
				string b2 = "㱩㱮㱶㱡㱬㱩㱤㱶㱥㱲";
				<Module>.FamANDAssem(ref b2, new object[]
				{
					7311,
					'ᑃ',
					'ମ'
				});
				bool flag2 = message2 == b2;
				if (flag2)
				{
					this.app_data.downloadLink = response_structure.download;
				}
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000034FC File Offset: 0x000016FC
		public void register(string username, string pass, string key)
		{
			bool flag = (this.initialized ? 1 : 0) == checked(-560081 - -560081);
			if (flag)
			{
				string message = "☛☧☮☪☸☮♫☢☥☢☿☢☪☧☢☱☮♫☭☢☹☸☿♥♫☊☯☯♫☀☮☲☊☾☿☣☊☻☻♥☢☥☢☿♣♢♰♫☤☥♫☧☤☪☯♥";
				<Module>.FamANDAssem(ref message, new object[]
				{
					"ࡁ৾࠳",
					1172,
					1861
				});
				api.error(message);
				int exitCode = 0;
				Environment.Exit(exitCode);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			string text2 = "漏弄壘寧";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				15683,
				694,
				47425,
				false
			});
			string text3 = text2;
			Encoding @default = Encoding.Default;
			string s = "蹢蹵蹷蹹蹣蹤蹵蹢";
			<Module>.FamANDAssem(ref s, new object[]
			{
				3332,
				6390,
				26646
			});
			nameValueCollection[text3] = encryption.byte_arr_to_str(@default.GetBytes(s));
			string text4 = "ॿॹ९ॸ।५१९";
			<Module>.FamANDAssem(ref text4, new object[]
			{
				"$\t\u0014\u0005\0\0\u0002",
				"ĂX!",
				"\u0001\b\n\u000e",
				"2&\u0004\u0001\u0001\u0003",
				false,
				1733
			});
			nameValueCollection[text4] = encryption.encrypt(username, this.enckey, text);
			string text5 = "源溁溓溓";
			<Module>.FamANDAssem(ref text5, new object[]
			{
				false,
				21800,
				'Β',
				'ᘦ'
			});
			nameValueCollection[text5] = encryption.encrypt(pass, this.enckey, text);
			string text6 = "";
			<Module>.FamANDAssem(ref text6, new object[]
			{
				false,
				'┮',
				44224,
				"ݒݏʜ\u0083Ì×1"
			});
			nameValueCollection[text6] = encryption.encrypt(key, this.enckey, text);
			string text7 = "\uda28\uda37\uda29\uda24";
			<Module>.FamANDAssem(ref text7, new object[]
			{
				'診',
				20486
			});
			nameValueCollection[text7] = encryption.encrypt(value, this.enckey, text);
			string text8 = "ª¼ªª°¶·°½";
			<Module>.FamANDAssem(ref text8, new object[]
			{
				't',
				101
			});
			nameValueCollection[text8] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			string text9 = "";
			<Module>.FamANDAssem(ref text9, new object[]
			{
				24690,
				32848
			});
			nameValueCollection[text9] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			string text10 = "♉♑♈♃♔♏♂";
			<Module>.FamANDAssem(ref text10, new object[]
			{
				'⊇',
				551,
				127,
				249
			});
			nameValueCollection[text10] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			string text11 = "怠性怠怽怖怠怿";
			<Module>.FamANDAssem(ref text11, new object[]
			{
				21,
				'\r',
				'í',
				false,
				'吶',
				2820
			});
			nameValueCollection[text11] = text;
			NameValueCollection post_data = nameValueCollection;
			string text12 = api.req(post_data);
			text12 = encryption.decrypt(text12, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text12);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003924 File Offset: 0x00001B24
		public void login(string username, string pass)
		{
			bool flag = this.initialized == (true & false);
			if (flag)
			{
				string message = "ϴψρυϗρ΄ύϊύϐύυψύϞρ΄ςύϖϗϐΊ΄ϥππ΄ϯρϝϥϑϐόϥϔϔΊύϊύϐΌ΍Ο΄ϋϊ΄ψϋυπΊ";
				<Module>.FamANDAssem(ref message, new object[]
				{
					34,
					"\b2\b\0\a\u0002\u0004",
					810,
					'\u0002',
					'\a'
				});
				api.error(message);
				Environment.Exit(api.get_DefaultBinder);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			string text2 = "햄행햀햕";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				1868,
				'㇠',
				40132
			});
			string text3 = text2;
			Encoding @default = Encoding.Default;
			string s = "韝韞韖韘韟";
			<Module>.FamANDAssem(ref s, new object[]
			{
				21379,
				5413,
				false,
				10319,
				"ɫϔ+I\u0002\u0001\u0004"
			});
			nameValueCollection[text3] = encryption.byte_arr_to_str(@default.GetBytes(s));
			string text4 = "颠颦颰颧颻颴颸颰";
			<Module>.FamANDAssem(ref text4, new object[]
			{
				"ú㮤ᓥർހ͈",
				'⼎'
			});
			nameValueCollection[text4] = encryption.encrypt(username, this.enckey, text);
			string text5 = "ﰣﰲﰠﰠ";
			<Module>.FamANDAssem(ref text5, new object[]
			{
				"׼",
				"ļۑ",
				822,
				2721
			});
			nameValueCollection[text5] = encryption.encrypt(pass, this.enckey, text);
			string text6 = "봔봋봕봘";
			<Module>.FamANDAssem(ref text6, new object[]
			{
				false,
				'▘',
				'韤'
			});
			nameValueCollection[text6] = encryption.encrypt(value, this.enckey, text);
			string text7 = "₆ₐ₆₆ₜₚₛₜₑ";
			<Module>.FamANDAssem(ref text7, new object[]
			{
				4,
				1464,
				6967,
				false,
				2
			});
			nameValueCollection[text7] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			string text8 = "趾趱趽趵";
			<Module>.FamANDAssem(ref text8, new object[]
			{
				475,
				35829
			});
			nameValueCollection[text8] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			string text9 = "她奡奸女奤奿奲";
			<Module>.FamANDAssem(ref text9, new object[]
			{
				"۲ۓሉ",
				false,
				467,
				14197
			});
			nameValueCollection[text9] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			string text10 = "獊獍獊獗獼獊獕";
			<Module>.FamANDAssem(ref text10, new object[]
			{
				'㱪',
				"јȖå\u00a0Ò",
				1354,
				6819,
				false,
				3591
			});
			nameValueCollection[text10] = text;
			NameValueCollection post_data = nameValueCollection;
			string text11 = api.req(post_data);
			text11 = encryption.decrypt(text11, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text11);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003D04 File Offset: 0x00001F04
		public void web_login()
		{
			char[] array = new char[]
			{
				'Ӣ'
			};
			int[] array2 = new int[]
			{
				0
			};
			string value;
			HttpListener httpListener;
			HttpListenerRequest request;
			HttpListenerResponse httpListenerResponse;
			checked
			{
				bool flag = (this.initialized ? 1 : 0) == (int)0L;
				if (flag)
				{
					string message = "瑌瑰瑹瑽瑯瑹琼瑵瑲瑵瑨瑵瑽瑰瑵瑦瑹琼瑺瑵瑮瑯瑨琲琼瑝瑸瑸琼瑗瑹瑥瑝瑩瑨瑴瑝瑬瑬琲瑵瑲瑵瑨琴琵琧琼瑳瑲琼瑰瑳瑽瑸琲";
					<Module>.FamANDAssem(ref message, new object[]
					{
						163,
						'ݣ',
						85,
						9616,
						17969
					});
					api.error(message);
					Environment.Exit(0 * 66898);
				}
				value = WindowsIdentity.GetCurrent().User.Value;
				httpListener = new HttpListener();
				string text = "";
				<Module>.FamANDAssem(ref text, new object[]
				{
					11039,
					21554,
					'獜'
				});
				string text2 = text;
				string text3 = "曌曐曐曔暞暋暋曈曋曇曅曈曌曋曗曐暞暕暗暗暓暋";
				<Module>.FamANDAssem(ref text3, new object[]
				{
					24281,
					"M8\u0012",
					'ƽ',
					1338,
					61
				});
				string str = text3;
				string str2 = text2;
				string str3 = "";
				<Module>.FamANDAssem(ref str3, new object[]
				{
					"㽽訍᳭ƥ\u00819W",
					208,
					139
				});
				text2 = str + str2 + str3;
				httpListener.Prefixes.Add(text2);
				httpListener.Start();
				HttpListenerContext context = httpListener.GetContext();
				request = context.Request;
				httpListenerResponse = context.Response;
				HttpListenerResponse httpListenerResponse2 = httpListenerResponse;
				string text4 = "衐衲衲衴衢衢蠼衒衾衿补衣衾衽蠼衐衽衽衾衦蠼衜衴补衹衾衵衢";
				<Module>.FamANDAssem(ref text4, new object[]
				{
					20976,
					'㘡'
				});
				string text5 = text4;
				string value2 = "俦俤俵侍侁俱修俲俵";
				<Module>.FamANDAssem(ref value2, new object[]
				{
					3414,
					16971
				});
				httpListenerResponse2.AddHeader(text5, value2);
				HttpListenerResponse httpListenerResponse3 = httpListenerResponse;
				string text6 = "뢛뢹뢹뢿뢩뢩룷뢙뢵뢴뢮뢨뢵뢶룷뢛뢶뢶뢵뢭룷뢕뢨뢳뢽뢳뢴";
				<Module>.FamANDAssem(ref text6, new object[]
				{
					"\u000e\u0015\t\u0004\u0006",
					"⌜኱\u008b\0\0\u000f\u0006",
					'A',
					33270
				});
				string text7 = text6;
				string value3 = "⡘";
				<Module>.FamANDAssem(ref value3, new object[]
				{
					10145,
					209
				});
				httpListenerResponse3.AddHeader(text7, value3);
				HttpListenerResponse httpListenerResponse4 = httpListenerResponse;
				string text8 = "㰏㰰㰸";
				<Module>.FamANDAssem(ref text8, new object[]
				{
					1048,
					'&',
					987,
					false,
					13376
				});
				string text9 = text8;
				string value4 = "핈핷핿";
				<Module>.FamANDAssem(ref value4, new object[]
				{
					48908,
					3099,
					1655,
					896
				});
				httpListenerResponse4.AddHeader(text9, value4);
				HttpListenerResponse httpListenerResponse5 = httpListenerResponse;
				string text10 = "呱呒呞呜呉呔呒呓";
				<Module>.FamANDAssem(ref text10, new object[]
				{
					17140,
					false,
					2309,
					2116
				});
				string text11 = text10;
				string value5 = "勼募勓勑勄務募勞";
				<Module>.FamANDAssem(ref value5, new object[]
				{
					13574,
					112,
					2102,
					"቎ɊC\u0011\u0002\u0016"
				});
				httpListenerResponse5.AddHeader(text11, value5);
				HttpListenerResponse httpListenerResponse6 = httpListenerResponse;
				string text12 = "࿰࿇࿖࿐࿛ྏ࿣࿄࿖࿇࿐";
				<Module>.FamANDAssem(ref text12, new object[]
				{
					3504,
					'ǲ'
				});
				string text13 = text12;
				string value6 = "踍踺踫踭踦";
				<Module>.FamANDAssem(ref value6, new object[]
				{
					89,
					8338,
					23040,
					'፴'
				});
				httpListenerResponse6.AddHeader(text13, value6);
				NameValueCollection headers = httpListenerResponse.Headers;
				string text14 = "鮠鮖鮁鮅鮖鮁";
				<Module>.FamANDAssem(ref text14, new object[]
				{
					33016,
					"Әᘣ",
					false
				});
				string text15 = text14;
				string value7 = "ﹹﹾﹹﹾ";
				<Module>.FamANDAssem(ref value7, new object[]
				{
					'Ƥ',
					'驧',
					1850,
					'嬯',
					false
				});
				headers.Add(text15, value7);
				httpListener.AuthenticationSchemes = (AuthenticationSchemes)220783128 / (AuthenticationSchemes)110391564;
			}
			httpListener.UnsafeConnectionNtlmAuthentication = (719347 - 719346 != 0);
			httpListener.IgnoreWriteExceptions = (~(-2 != 0) != 0);
			string rawUrl = request.RawUrl;
			string text16 = rawUrl;
			string oldValue = "鼢齥齬齣齩齾齥齬齦齨鼲齸齾齨齿鼰";
			<Module>.FamANDAssem(ref oldValue, new object[]
			{
				5371,
				'棨',
				8490
			});
			string text17 = text16.Replace(oldValue, "");
			string text18 = text17;
			string text19 = "䯬䮾䮥䮡䮯䮤䯷";
			<Module>.FamANDAssem(ref text19, new object[]
			{
				5956,
				13446,
				false
			});
			string oldValue2 = text19;
			string newValue = "殊";
			<Module>.FamANDAssem(ref newValue, new object[]
			{
				5838,
				21724
			});
			text17 = text18.Replace(oldValue2, newValue);
			string text20 = text17;
			string value8 = text20.Split(Array.Empty<char>())[(-15308 > 182884) ? 406468 : 0];
			string text21 = text20;
			char[] array3 = new char[85450 + -85449];
			int num = array2[0];
			int num2;
			if (-7970 == -32686)
			{
				num2 = 396144;
			}
			else
			{
				num2 = 32;
			}
			array3[num] = (char)num2;
			string value9 = text21.Split(array3)[Convert.ToInt32("1", 2)];
			NameValueCollection nameValueCollection = new NameValueCollection();
			string text22 = "椑検椕椀";
			<Module>.FamANDAssem(ref text22, new object[]
			{
				'䴣',
				7234
			});
			string text23 = text22;
			string value10 = "ꁐꁓꁛꁕꁒ";
			<Module>.FamANDAssem(ref value10, new object[]
			{
				'ⶌ',
				29360
			});
			nameValueCollection[text23] = value10;
			string text24 = "懣懥懳懤懸懷懻懳";
			<Module>.FamANDAssem(ref text24, new object[]
			{
				"મвல",
				"〦ᛞ"
			});
			nameValueCollection[text24] = value8;
			string text25 = "춗춌춈춆춍";
			<Module>.FamANDAssem(ref text25, new object[]
			{
				'㒲',
				39217,
				false
			});
			nameValueCollection[text25] = value9;
			string text26 = "剒前剓剞";
			<Module>.FamANDAssem(ref text26, new object[]
			{
				218,
				"\a\u0001\u0004",
				4119,
				"ɡ\u001d&Ć˦ƀ",
				14637
			});
			nameValueCollection[text26] = value;
			string text27 = "氯氹氯氯氵氳氲氵永";
			<Module>.FamANDAssem(ref text27, new object[]
			{
				3,
				1862,
				false,
				"ž̷\u0001\u0006\u0003",
				24655,
				'\u0005'
			});
			nameValueCollection[text27] = this.sessionid;
			string text28 = "덹덶덺덲";
			<Module>.FamANDAssem(ref text28, new object[]
			{
				16709,
				29138
			});
			nameValueCollection[text28] = this.name;
			string text29 = "";
			<Module>.FamANDAssem(ref text29, new object[]
			{
				533,
				'๢',
				10125,
				6819,
				37498
			});
			nameValueCollection[text29] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req_unenc(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			bool flag2 = -15674 >= -150621 || -93739 != 0;
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
				HttpListenerResponse httpListenerResponse7 = httpListenerResponse;
				int statusCode;
				if (-87546 >= -305936)
				{
					statusCode = 420;
				}
				else
				{
					statusCode = -243015;
				}
				httpListenerResponse7.StatusCode = statusCode;
				HttpListenerResponse httpListenerResponse8 = httpListenerResponse;
				string statusDescription = "軱軪軧軧軱軪";
				<Module>.FamANDAssem(ref statusDescription, new object[]
				{
					519,
					false,
					27431,
					"\u0001\r\u0002\v\v\u0005",
					450,
					'ᾇ'
				});
				httpListenerResponse8.StatusDescription = statusDescription;
			}
			else
			{
				Console.WriteLine(response_structure.message);
				httpListenerResponse.StatusCode = checked(-25 * -8);
				httpListenerResponse.StatusDescription = response_structure.message;
				flag2 = (api.get_DefaultBinder != 0);
			}
			Encoding utf = Encoding.UTF8;
			string s = "㓣㓜㓕㓀㓇㒔㓁㓄㒋";
			<Module>.FamANDAssem(ref s, new object[]
			{
				8663,
				4829
			});
			byte[] bytes = utf.GetBytes(s);
			httpListenerResponse.ContentLength64 = (long)bytes.Length;
			Stream outputStream = httpListenerResponse.OutputStream;
			Stream stream = outputStream;
			byte[] buffer = bytes;
			int offset;
			if (10617 != 10617)
			{
				offset = -250663;
			}
			else
			{
				offset = 0;
			}
			stream.Write(buffer, offset, bytes.Length);
			Thread.Sleep((int)array[0]);
			httpListener.Stop();
			bool flag3 = (flag2 ? 1 : 0) == Convert.ToInt32("0", 8);
			if (flag3)
			{
				Environment.Exit(api.get_DefaultBinder);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00004760 File Offset: 0x00002960
		public void button(string button)
		{
			char[] array = new char[]
			{
				'\u0001'
			};
			int[] array2 = new int[]
			{
				0
			};
			bool flag = (this.initialized ? 1 : 0) == array2[0];
			if (flag)
			{
				string message = "蠇蠻蠲蠶蠤蠲衷蠾蠹蠾蠣蠾蠶蠻蠾蠭蠲衷蠱蠾蠥蠤蠣";
				<Module>.FamANDAssem(ref message, new object[]
				{
					990,
					'ખ',
					"ňȂ\b\u0001\u0002",
					false,
					'皎'
				});
				api.error(message);
				Environment.Exit(api.get_DefaultBinder);
			}
			HttpListener httpListener = new HttpListener();
			string text = "⑏⑓⑓⑗␝␈␈⑋⑈⑄⑆⑋⑏⑈⑔⑓␝␖␔␔␐␈";
			<Module>.FamANDAssem(ref text, new object[]
			{
				5626,
				false,
				3629
			});
			string str = text;
			string str2 = "훑";
			<Module>.FamANDAssem(ref str2, new object[]
			{
				12532,
				'ꘊ',
				false
			});
			string uriPrefix = str + button + str2;
			httpListener.Prefixes.Add(uriPrefix);
			httpListener.Start();
			HttpListenerContext context = httpListener.GetContext();
			HttpListenerRequest request = context.Request;
			HttpListenerResponse httpListenerResponse = context.Response;
			HttpListenerResponse httpListenerResponse2 = httpListenerResponse;
			string text2 = "韮韌韌韊韜韜鞂韬韀韁韛韝韀韃鞂韮韃韃韀韘鞂韢韊韛韇韀韋韜";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				1279,
				false,
				2491,
				1695,
				9459,
				'嵣'
			});
			string text3 = text2;
			string value = "䲴䲶䲧䳟䳓䲣䲼䲠䲧";
			<Module>.FamANDAssem(ref value, new object[]
			{
				19603,
				18,
				28,
				'2',
				false
			});
			httpListenerResponse2.AddHeader(text3, value);
			HttpListenerResponse httpListenerResponse3 = httpListenerResponse;
			string text4 = "唝唿唿唹唯唯啱唟唳唲唨售唳唰啱唝唰唰唳唫啱唓售唵唻唵唲";
			<Module>.FamANDAssem(ref text4, new object[]
			{
				8436,
				"ፀࡿઔೢĳ",
				false
			});
			string text5 = text4;
			string value2 = "览";
			<Module>.FamANDAssem(ref value2, new object[]
			{
				269,
				35029
			});
			httpListenerResponse3.AddHeader(text5, value2);
			HttpListenerResponse httpListenerResponse4 = httpListenerResponse;
			string text6 = "ꗩꗖꗞ";
			<Module>.FamANDAssem(ref text6, new object[]
			{
				'㧿',
				'❑',
				17519
			});
			string text7 = text6;
			string value3 = "";
			<Module>.FamANDAssem(ref value3, new object[]
			{
				6579,
				"欠ᙿ⌄",
				9369
			});
			httpListenerResponse4.AddHeader(text7, value3);
			HttpListenerResponse httpListenerResponse5 = httpListenerResponse;
			string text8 = "渜渿渳渱渤渹渿渾";
			<Module>.FamANDAssem(ref text8, new object[]
			{
				4659,
				3463,
				"᧤ݩᄈ",
				4329,
				2904
			});
			string text9 = text8;
			string value4 = "䲶䲕䲙䲛䲎䲓䲕䲔";
			<Module>.FamANDAssem(ref value4, new object[]
			{
				'ㄈ',
				'᯲'
			});
			httpListenerResponse5.AddHeader(text9, value4);
			HttpListenerResponse httpListenerResponse6 = httpListenerResponse;
			string text10 = "鋋鋼鋭鋫鋠銴鋘鋿鋭鋼鋫";
			<Module>.FamANDAssem(ref text10, new object[]
			{
				33023,
				993,
				3513,
				false
			});
			string text11 = text10;
			string value5 = "᨝ᨪᨻᨶ";
			<Module>.FamANDAssem(ref value5, new object[]
			{
				'ኰ',
				1951
			});
			httpListenerResponse6.AddHeader(text11, value5);
			NameValueCollection headers = httpListenerResponse.Headers;
			string text12 = "䫋䫽䫪䫮䫽䫪";
			<Module>.FamANDAssem(ref text12, new object[]
			{
				false,
				'̑',
				'ܤ',
				16483
			});
			string text13 = text12;
			string value6 = "㸻㸼㸻㸼";
			<Module>.FamANDAssem(ref value6, new object[]
			{
				"\u0095ń",
				false,
				"ັ੝ࣖڐǌɤ",
				4025
			});
			headers.Add(text13, value6);
			HttpListenerResponse httpListenerResponse7 = httpListenerResponse;
			int statusCode = 420;
			httpListenerResponse7.StatusCode = statusCode;
			HttpListenerResponse httpListenerResponse8 = httpListenerResponse;
			string statusDescription = "臼臧自自臼臧";
			<Module>.FamANDAssem(ref statusDescription, new object[]
			{
				23269,
				3183,
				false,
				3967,
				2780
			});
			httpListenerResponse8.StatusDescription = statusDescription;
			HttpListener httpListener2 = httpListener;
			int authenticationSchemes;
			switch (0 / -131)
			{
			case 0:
				authenticationSchemes = 2;
				break;
			}
			httpListener2.AuthenticationSchemes = (AuthenticationSchemes)authenticationSchemes;
			httpListener.UnsafeConnectionNtlmAuthentication = (array[0] != '\0');
			HttpListener httpListener3 = httpListener;
			int ignoreWriteExceptions;
			switch (1 * 1)
			{
			case 0:
				ignoreWriteExceptions = 62041;
				break;
			case 1:
				ignoreWriteExceptions = 1;
				break;
			case 2:
				ignoreWriteExceptions = -579014;
				break;
			}
			httpListener3.IgnoreWriteExceptions = (ignoreWriteExceptions != 0);
			httpListener.Stop();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00004CBC File Offset: 0x00002EBC
		public void upgrade(string username, string key)
		{
			bool flag = (this.initialized ? 1 : 0) == (int)0L;
			checked
			{
				if (flag)
				{
					string message = "脭脑脘脜脎脘腝脔脓脔脉脔脜脑脔脇脘腝脛脔脏脎脉腓腝脼脙脙腝脶脘脄脼脈脉脕脼脍脍腓脔脓脔脉腕腔腆腝脒脓腝脑脒脜脙腓";
					<Module>.FamANDAssem(ref message, new object[]
					{
						"㗋Ꭽ৶ڄÑ",
						549,
						"ᗉटƫũƇĒ",
						false
					});
					api.error(message);
					int exitCode;
					switch (147538 - 147536)
					{
					case 0:
						exitCode = -454129;
						break;
					case 1:
						exitCode = 614721;
						break;
					case 2:
						exitCode = 0;
						break;
					case 3:
						exitCode = -821860;
						break;
					}
					Environment.Exit(exitCode);
				}
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				string text2 = "廳廾廷廢";
				<Module>.FamANDAssem(ref text2, new object[]
				{
					8908,
					"ũ\u0018\u0010\u0002",
					'ū',
					"\v\u0006\u0001\0\0\0\u0002",
					14505
				});
				string text3 = text2;
				Encoding @default = Encoding.Default;
				string s = "腒腗腀腕腆腃腂";
				<Module>.FamANDAssem(ref s, new object[]
				{
					8302,
					18576,
					4170,
					2015
				});
				nameValueCollection[text3] = encryption.byte_arr_to_str(@default.GetBytes(s));
				string text4 = "忮忨忾忩念忺忶忾";
				<Module>.FamANDAssem(ref text4, new object[]
				{
					'宣',
					1016
				});
				nameValueCollection[text4] = encryption.encrypt(username, this.enckey, text);
				string text5 = "";
				<Module>.FamANDAssem(ref text5, new object[]
				{
					"ᒑ`7¶\a",
					"㱟ṿ",
					'熧'
				});
				nameValueCollection[text5] = encryption.encrypt(key, this.enckey, text);
				string text6 = "ﵐ﵆ﵐﵐ﵊﵌﵍﵊﵇";
				<Module>.FamANDAssem(ref text6, new object[]
				{
					12488,
					27488,
					16824,
					false,
					'ὃ'
				});
				nameValueCollection[text6] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				string text7 = "";
				<Module>.FamANDAssem(ref text7, new object[]
				{
					'쭨',
					false,
					8904,
					'੝'
				});
				nameValueCollection[text7] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				string text8 = "잰잨잱잺잭잶잻";
				<Module>.FamANDAssem(ref text8, new object[]
				{
					47592,
					"϶JÂ",
					87,
					100,
					2106
				});
				nameValueCollection[text8] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				string text9 = "";
				<Module>.FamANDAssem(ref text9, new object[]
				{
					736,
					'\udfe3',
					false
				});
				nameValueCollection[text9] = text;
				NameValueCollection post_data = nameValueCollection;
				string text10 = api.req(post_data);
				text10 = encryption.decrypt(text10, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text10);
				response_structure.success = ((int)0L != 0);
				this.load_response_struct(response_structure);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00005090 File Offset: 0x00003290
		public void license(string key)
		{
			bool flag = (this.initialized ? 1 : 0) == 581700 + -581700;
			if (flag)
			{
				string message = "ホョヮリヸヮカモュモヿモリョモヱヮカロモヹヸヿゥカナワワカダヮヲナヾヿャナ・・ゥモュモヿィアグカヤュカョヤリワゥ";
				<Module>.FamANDAssem(ref message, new object[]
				{
					"ᛙྭƨΞ×¡\u009f",
					false,
					"đŖ7\u0006\u0001\u0003"
				});
				api.error(message);
				int exitCode = 0;
				Environment.Exit(exitCode);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			string text2 = "ꡕꡘꡑꡄ";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				34196,
				false,
				'ə',
				'‴'
			});
			string text3 = text2;
			Encoding @default = Encoding.Default;
			string s = "\udddf\uddda\uddd0\uddd6\udddd\uddc0\uddd6";
			<Module>.FamANDAssem(ref s, new object[]
			{
				50303,
				3055,
				3247,
				'\u0096'
			});
			nameValueCollection[text3] = encryption.byte_arr_to_str(@default.GetBytes(s));
			string text4 = "辿辱辭";
			<Module>.FamANDAssem(ref text4, new object[]
			{
				17449,
				"㰌լਲ਼"
			});
			nameValueCollection[text4] = encryption.encrypt(key, this.enckey, text);
			string text5 = "瑤瑻瑥瑨";
			<Module>.FamANDAssem(ref text5, new object[]
			{
				85,
				3130,
				6569,
				19924,
				false
			});
			nameValueCollection[text5] = encryption.encrypt(value, this.enckey, text);
			string text6 = "ᯍᯛᯍᯍᯗᯑᯐᯗᯚ";
			<Module>.FamANDAssem(ref text6, new object[]
			{
				'\u000e',
				false,
				237,
				'\u0016',
				6351,
				")wÔ\u000f["
			});
			nameValueCollection[text6] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			string text7 = "늭늢늮늦";
			<Module>.FamANDAssem(ref text7, new object[]
			{
				'8',
				3584,
				'縼',
				9350,
				457
			});
			nameValueCollection[text7] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			string text8 = "籵籭籴籿籨米籾";
			<Module>.FamANDAssem(ref text8, new object[]
			{
				false,
				3411,
				"ᜢ\u00126౾",
				"ʽ୭Ǵ¤\u0011ƍд",
				13387
			});
			nameValueCollection[text8] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			string text9 = "ꤻꤼꤻꤦꤍꤻꤤ";
			<Module>.FamANDAssem(ref text9, new object[]
			{
				12306,
				1677,
				16229,
				'ͱ',
				'⿝'
			});
			nameValueCollection[text9] = text;
			NameValueCollection post_data = nameValueCollection;
			string text10 = api.req(post_data);
			text10 = encryption.decrypt(text10, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text10);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00005458 File Offset: 0x00003658
		public void check()
		{
			checked
			{
				bool flag = (this.initialized ? 1 : 0) == (int)0L;
				if (flag)
				{
					string message = "灰灌灅灁灓灅瀀灉灎灉灔灉灁灌灉灚灅瀀灆灉灒灓灔瀎瀀灡灄灄瀀火灅灙灡灕灔灈灡灐灐瀎灉灎灉灔瀈瀉瀛瀀灏灎瀀灌灏灁灄瀎";
					<Module>.FamANDAssem(ref message, new object[]
					{
						416,
						19258,
						462,
						false,
						8568
					});
					api.error(message);
					Environment.Exit((int)0L);
				}
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				string text2 = "摃摎摇摒";
				<Module>.FamANDAssem(ref text2, new object[]
				{
					'ㄧ',
					"ԉफ़\u0097",
					9234
				});
				string text3 = text2;
				Encoding @default = Encoding.Default;
				string s = "∓∘∕∓∛";
				<Module>.FamANDAssem(ref s, new object[]
				{
					5447,
					'͚',
					2511
				});
				nameValueCollection[text3] = encryption.byte_arr_to_str(@default.GetBytes(s));
				string text4 = "঻ভ঻঻ডধদডব";
				<Module>.FamANDAssem(ref text4, new object[]
				{
					"!%\0\u0001\0\u0001\u0005",
					524,
					'ʜ',
					'9',
					"ώÌ"
				});
				nameValueCollection[text4] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				string text5 = "౼౳౿౷";
				<Module>.FamANDAssem(ref text5, new object[]
				{
					"ʅŎŴ\r\u000f\a",
					1105,
					'ɀ',
					23
				});
				nameValueCollection[text5] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				string text6 = "\u008e\u0096\u008f\u0084\u0093\u0088\u0085";
				<Module>.FamANDAssem(ref text6, new object[]
				{
					71,
					154
				});
				nameValueCollection[text6] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				string text7 = "♜♛♜♁♪♜♃";
				<Module>.FamANDAssem(ref text7, new object[]
				{
					4025,
					313,
					'ຄ',
					1727
				});
				nameValueCollection[text7] = text;
				NameValueCollection post_data = nameValueCollection;
				string text8 = api.req(post_data);
				text8 = encryption.decrypt(text8, this.enckey, text);
				api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(text8);
				this.load_response_struct(data);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00005718 File Offset: 0x00003918
		public void setvar(string var, string data)
		{
			int num = this.initialized ? 1 : 0;
			int num2;
			if (-16922 <= -884084)
			{
				num2 = 12665;
			}
			else
			{
				num2 = 0;
			}
			bool flag = num == num2;
			if (flag)
			{
				string message = "බඊඃඇඕඃෆඏඈඏඒඏඇඊඏගඃෆ඀ඏඔඕඒ෈ෆටංංෆතඃඟටඓඒඎටඖඖ෈ඏඈඏඒ෎ාෝෆඉඈෆඊඉඇං෈";
				<Module>.FamANDAssem(ref message, new object[]
				{
					"г٩\0ê\u0005\0\u0003",
					194,
					173,
					false,
					7,
					'â'
				});
				api.error(message);
				Environment.Exit(checked(855633 + -855633));
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			string text2 = "럃럎럇럒";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				30073,
				'ѩ',
				'֌',
				1173,
				false,
				13236
			});
			string text3 = text2;
			Encoding @default = Encoding.Default;
			string s = "缷缡缰缲缥缶";
			<Module>.FamANDAssem(ref s, new object[]
			{
				24387,
				"0Ȋǒ",
				2418,
				4739,
				false
			});
			nameValueCollection[text3] = encryption.byte_arr_to_str(@default.GetBytes(s));
			string text4 = "安实宍";
			<Module>.FamANDAssem(ref text4, new object[]
			{
				'خ',
				"ҨȡࡱW>\b%",
				'Ù',
				"4᫷ྡ᛺",
				false,
				'̶'
			});
			nameValueCollection[text4] = encryption.encrypt(var, this.enckey, text);
			string text5 = "嬛嬞嬋嬞";
			<Module>.FamANDAssem(ref text5, new object[]
			{
				796,
				12696,
				97,
				9834
			});
			nameValueCollection[text5] = encryption.encrypt(data, this.enckey, text);
			string text6 = "럶럠럶럶러럪럫러럡";
			<Module>.FamANDAssem(ref text6, new object[]
			{
				'h',
				46877
			});
			nameValueCollection[text6] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			string text7 = "藺刺麟炙";
			<Module>.FamANDAssem(ref text7, new object[]
			{
				"圶渔گ\t\u0004\u0001\u0004",
				"nh\u0006\0\u0006",
				"ĚᓘԌƏɁͱ",
				2674
			});
			nameValueCollection[text7] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			string text8 = "ሀመሁሊምሆላ";
			<Module>.FamANDAssem(ref text8, new object[]
			{
				171,
				false,
				'ᇄ'
			});
			nameValueCollection[text8] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			string text9 = "曥曢曥書曓曥曺";
			<Module>.FamANDAssem(ref text9, new object[]
			{
				398,
				14462,
				1538,
				2,
				'♼'
			});
			nameValueCollection[text9] = text;
			NameValueCollection post_data = nameValueCollection;
			string text10 = api.req(post_data);
			text10 = encryption.decrypt(text10, this.enckey, text);
			api.response_structure data2 = this.response_decoder.string_to_generic<api.response_structure>(text10);
			this.load_response_struct(data2);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00005AE0 File Offset: 0x00003CE0
		public string getvar(string var)
		{
			bool flag = (this.initialized ? 1 : 0) == ~-1;
			if (flag)
			{
				string message = "멕멩멠멤멶멠먥멬멫멬멱멬멤멩멬멿멠먥멣멬멷멶멱먫먥멄멡멡먥멎멠멼멄며멱멭멄멵멵먫멬멫멬멱먭먬먾먥멪멫먥멩멪멤멡먫";
				<Module>.FamANDAssem(ref message, new object[]
				{
					7270,
					false,
					21304,
					"࿶㩱"
				});
				api.error(message);
				int exitCode = 0;
				Environment.Exit(exitCode);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			string text2 = "材杝杔杁";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				18961,
				false,
				"ࣲĿ\u000f~\u00031",
				2524,
				'ࡅ'
			});
			string text3 = text2;
			Encoding @default = Encoding.Default;
			string s = "竜竞竏竍竚竉";
			<Module>.FamANDAssem(ref s, new object[]
			{
				'ҹ',
				'׳',
				27487,
				false,
				"ɮƽz\v"
			});
			nameValueCollection[text3] = encryption.byte_arr_to_str(@default.GetBytes(s));
			string text4 = "옲옥옶";
			<Module>.FamANDAssem(ref text4, new object[]
			{
				50153,
				603
			});
			nameValueCollection[text4] = encryption.encrypt(var, this.enckey, text);
			string text5 = "쑨쑾쑨쑨쑲쑴쑵쑲쑿";
			<Module>.FamANDAssem(ref text5, new object[]
			{
				41893,
				1267,
				"˨\u0015Ģ¥",
				"Ę়ļØ48",
				false,
				2411
			});
			nameValueCollection[text5] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			string text6 = "\udeaf\udea0\udeac\udea4";
			<Module>.FamANDAssem(ref text6, new object[]
			{
				'땁',
				'⃣',
				false,
				"ٞȿ"
			});
			nameValueCollection[text6] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			string text7 = "⽄⽜⽅⽎⽙⽂⽏";
			<Module>.FamANDAssem(ref text7, new object[]
			{
				false,
				3048,
				9027
			});
			nameValueCollection[text7] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			string text8 = "͛͛͆ͭ͛̈́͜";
			<Module>.FamANDAssem(ref text8, new object[]
			{
				91,
				362,
				"ê\u000fj",
				10
			});
			nameValueCollection[text8] = text;
			NameValueCollection post_data = nameValueCollection;
			string text9 = api.req(post_data);
			text9 = encryption.decrypt(text9, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text9);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			string result;
			if (success)
			{
				result = response_structure.response;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00005E14 File Offset: 0x00004014
		public void ban(string reason = null)
		{
			bool flag = (this.initialized ? 1 : 0) == api.get_DefaultBinder;
			if (flag)
			{
				string message = "摗摫摢摦摴摢搧摮摩摮摳摮摦摫摮摽摢搧摡摮摵摴摳搩搧摆摣摣搧摌摢摾摆摲摳摯摆摷摷搩摮摩摮摳搯搮搼搧摨摩搧摫摨摦摣搩";
				<Module>.FamANDAssem(ref message, new object[]
				{
					false,
					24965,
					'\u001f',
					"ƢYT",
					"\f\u0006\u0002"
				});
				api.error(message);
				Environment.Exit(~-1);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			string text2 = "\udd93\udd9e\udd97\udd82";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				false,
				2668,
				7583,
				41926,
				1302,
				"҇ࡹ"
			});
			string text3 = text2;
			Encoding @default = Encoding.Default;
			string s = "隧隤隫";
			<Module>.FamANDAssem(ref s, new object[]
			{
				9316,
				false,
				18423,
				10858
			});
			nameValueCollection[text3] = encryption.byte_arr_to_str(@default.GetBytes(s));
			string text4 = "礮礹礽礯礳礲";
			<Module>.FamANDAssem(ref text4, new object[]
			{
				"ዀጨ׽òo",
				'䰖'
			});
			nameValueCollection[text4] = reason;
			string text5 = "ⰠⰶⰠⰠⰺⰼⰽⰺⰷ";
			<Module>.FamANDAssem(ref text5, new object[]
			{
				356,
				10991
			});
			nameValueCollection[text5] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			string text6 = "圁圎圂圊";
			<Module>.FamANDAssem(ref text6, new object[]
			{
				5444,
				'٘',
				12762,
				2553
			});
			nameValueCollection[text6] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			string text7 = "얎얖얏얄얓얈얅";
			<Module>.FamANDAssem(ref text7, new object[]
			{
				49967,
				690
			});
			nameValueCollection[text7] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			string text8 = "";
			<Module>.FamANDAssem(ref text8, new object[]
			{
				'颷',
				666,
				17598,
				706
			});
			nameValueCollection[text8] = text;
			NameValueCollection post_data = nameValueCollection;
			string text9 = api.req(post_data);
			text9 = encryption.decrypt(text9, this.enckey, text);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(text9);
			this.load_response_struct(data);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00006108 File Offset: 0x00004308
		public string var(string varid)
		{
			bool flag = (this.initialized ? 1 : 0) == 736441 - 736441;
			if (flag)
			{
				string message = "ﾁﾽﾴﾰﾢﾴ￱ﾸ﾿ﾸﾥﾸﾰﾽﾸﾫﾴ￱ﾷﾸﾣﾢﾥ￿￱ﾐﾵﾵ￱ﾚﾴﾨﾐﾤﾥﾹﾐﾡﾡ￿ﾸ﾿ﾸﾥ￹￸￪￱ﾾ﾿￱ﾽﾾﾰﾵ￿";
				<Module>.FamANDAssem(ref message, new object[]
				{
					18509,
					"姟⎹Ͷ⸸ʓEզ",
					false
				});
				api.error(message);
				Environment.Exit(705008 ^ 705008);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			string text2 = "";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				35087,
				"㠯ɒ\u0093P\u0002\a",
				9843
			});
			string text3 = text2;
			Encoding @default = Encoding.Default;
			string s = "䷇䷐䷃";
			<Module>.FamANDAssem(ref s, new object[]
			{
				"ඖôጰឞ",
				1040,
				false,
				4169
			});
			nameValueCollection[text3] = encryption.byte_arr_to_str(@default.GetBytes(s));
			string text4 = "딳딤딷딬딡";
			<Module>.FamANDAssem(ref text4, new object[]
			{
				'韦',
				5234,
				2285,
				false
			});
			nameValueCollection[text4] = encryption.encrypt(varid, this.enckey, text);
			string text5 = "枑枇枑枑枋枍枌枋枆";
			<Module>.FamANDAssem(ref text5, new object[]
			{
				24465,
				"ŭ,E\u0004\0\u0005",
				382,
				"Ѧ'_"
			});
			nameValueCollection[text5] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			string text6 = "颁颎颂颊";
			<Module>.FamANDAssem(ref text6, new object[]
			{
				7935,
				31048,
				168
			});
			nameValueCollection[text6] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			string text7 = "⽲⽪⽳⽸⽯⽴⽹";
			<Module>.FamANDAssem(ref text7, new object[]
			{
				85,
				943,
				false,
				42,
				310,
				"⁊ːڟ"
			});
			nameValueCollection[text7] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			string text8 = "";
			<Module>.FamANDAssem(ref text8, new object[]
			{
				21790,
				'ᄺ',
				false,
				34487
			});
			nameValueCollection[text8] = text;
			NameValueCollection post_data = nameValueCollection;
			string text9 = api.req(post_data);
			text9 = encryption.decrypt(text9, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text9);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			string result;
			if (success)
			{
				result = response_structure.message;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00006450 File Offset: 0x00004650
		public List<api.users> fetchOnline()
		{
			int[] array = new int[]
			{
				0
			};
			bool flag = (this.initialized ? 1 : 0) == Convert.ToInt32("0", 2);
			if (flag)
			{
				string message = "〧〛〒〖〄〒し〞〙〞〃〞〖〛〞」〒し】〞々〄〃すし〶〓〓し〼〒『〶。〃〟〶〇〇す〞〙〞〃たぞがし〘〙し〛〘〖〓す";
				<Module>.FamANDAssem(ref message, new object[]
				{
					false,
					2213,
					10194
				});
				api.error(message);
				Environment.Exit(array[0]);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			string text2 = "길긵긼긩";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				28527,
				15907,
				false,
				186
			});
			string text3 = text2;
			Encoding @default = Encoding.Default;
			string s = "";
			<Module>.FamANDAssem(ref s, new object[]
			{
				"㦜穆♮ڰӍ",
				'ᄵ'
			});
			nameValueCollection[text3] = encryption.byte_arr_to_str(@default.GetBytes(s));
			string text4 = "紿紩紿紿紥紣索紥紨";
			<Module>.FamANDAssem(ref text4, new object[]
			{
				28275,
				"Ȧø",
				"ť΁",
				1749
			});
			nameValueCollection[text4] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			string text5 = "砰砿砳砻";
			<Module>.FamANDAssem(ref text5, new object[]
			{
				20784,
				3662,
				5754,
				"\f'\u0012",
				"\u0086ĵf"
			});
			nameValueCollection[text5] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			string text6 = "☧☿☦☭☺☡☬";
			<Module>.FamANDAssem(ref text6, new object[]
			{
				37,
				3960,
				"ࣛ֐",
				"ؼÖvF\u0019\u0019@"
			});
			nameValueCollection[text6] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			string text7 = "㓅㓂㓅㓘㓳㓅㓚";
			<Module>.FamANDAssem(ref text7, new object[]
			{
				6641,
				3348,
				3495
			});
			nameValueCollection[text7] = text;
			NameValueCollection post_data = nameValueCollection;
			string text8 = api.req(post_data);
			text8 = encryption.decrypt(text8, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text8);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			List<api.users> result;
			if (success)
			{
				result = response_structure.users;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00006718 File Offset: 0x00004918
		public List<api.msg> chatget(string channelname)
		{
			bool flag = (this.initialized ? 1 : 0) == (-816247 ^ -816247);
			if (flag)
			{
				string message = "䮕䮩䮠䮤䮶䮠䯥䮬䮫䮬䮱䮬䮤䮩䮬䮿䮠䯥䮣䮬䮷䮶䮱䯫䯥䮄䮡䮡䯥䮎䮠䮼䮄䮰䮱䮭䮄䮵䮵䯫䮬䮫䮬䮱䯭䯬䯾䯥䮪䮫䯥䮩䮪䮤䮡䯫";
				<Module>.FamANDAssem(ref message, new object[]
				{
					'࿧',
					85,
					"\u0004\b\0\u0002\u0004",
					10869,
					'ᄂ'
				});
				api.error(message);
				Environment.Exit(checked(0 * 493103));
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			string text2 = "";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				10085,
				43893,
				"ÞᐌŐ\u0005I\u0012\u001b",
				"ɯʵ"
			});
			string text3 = text2;
			Encoding @default = Encoding.Default;
			string s = "ჿჴჽშ჻ჹშ";
			<Module>.FamANDAssem(ref s, new object[]
			{
				" \a\u0002\u0004\0\0\u0002",
				false,
				'Ǿ',
				2658,
				'Ѝ'
			});
			nameValueCollection[text3] = encryption.byte_arr_to_str(@default.GetBytes(s));
			string text4 = "ᤏᤄᤍᤂᤂᤉᤀ";
			<Module>.FamANDAssem(ref text4, new object[]
			{
				'ፏ',
				'ɧ',
				950
			});
			nameValueCollection[text4] = encryption.encrypt(channelname, this.enckey, text);
			string text5 = "㞞㞈㞞㞞㞄㞂㞃㞄㞉";
			<Module>.FamANDAssem(ref text5, new object[]
			{
				"ī\u0095#",
				false,
				"\u0096NC\u0003\0\u000e",
				11620,
				'ݮ'
			});
			nameValueCollection[text5] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			string text6 = "ᬁᬎᬂᬊ";
			<Module>.FamANDAssem(ref text6, new object[]
			{
				'ᣠ',
				433,
				222
			});
			nameValueCollection[text6] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			string text7 = "﨑降塚福兀益祥";
			<Module>.FamANDAssem(ref text7, new object[]
			{
				'\uda43',
				'࠱',
				368,
				5549,
				'í'
			});
			nameValueCollection[text7] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			string text8 = "๭๪๭๰๛๭๲";
			<Module>.FamANDAssem(ref text8, new object[]
			{
				"k\u000f\u0002\n",
				3454
			});
			nameValueCollection[text8] = text;
			NameValueCollection post_data = nameValueCollection;
			string text9 = api.req(post_data);
			text9 = encryption.decrypt(text9, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text9);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			List<api.msg> result;
			if (success)
			{
				result = response_structure.messages;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00006A60 File Offset: 0x00004C60
		public bool chatsend(string msg, string channelname)
		{
			bool flag = this.initialized == (false | false);
			if (flag)
			{
				string message = "⊴⊈⊁⊅⊗⊁⋄⊍⊊⊍⊐⊍⊅⊈⊍⊞⊁⋄⊂⊍⊖⊗⊐⋊⋄⊥⊀⊀⋄⊯⊁⊝⊥⊑⊐⊌⊥⊔⊔⋊⊍⊊⊍⊐⋌⋍⋟⋄⊋⊊⋄⊈⊋⊅⊀⋊";
				<Module>.FamANDAssem(ref message, new object[]
				{
					'Á',
					"ዸ2ߺɍĥ\u0010\v",
					'Ͳ'
				});
				api.error(message);
				int exitCode = 0;
				Environment.Exit(exitCode);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			string text2 = "斑斜斕斀";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				"\u0011\u0003\u0005\0\0\u0002",
				";äѬ;\a\u0003",
				747,
				'宅',
				false,
				"ſ\u0001\b\u0002"
			});
			string text3 = text2;
			Encoding @default = Encoding.Default;
			string s = "䀄䀏䀆䀓䀔䀂䀉䀃";
			<Module>.FamANDAssem(ref s, new object[]
			{
				2044,
				6956,
				"ታ͋\u008cûˋ!",
				782,
				false
			});
			nameValueCollection[text3] = encryption.byte_arr_to_str(@default.GetBytes(s));
			string text4 = "﬷﬿﬩﬩כּ﬽﬿";
			<Module>.FamANDAssem(ref text4, new object[]
			{
				'ᣏ',
				'磕',
				'宻',
				3579
			});
			nameValueCollection[text4] = encryption.encrypt(msg, this.enckey, text);
			string text5 = "灭灦灯灠灠火灢";
			<Module>.FamANDAssem(ref text5, new object[]
			{
				false,
				212,
				26843,
				1407,
				35,
				"\f±"
			});
			nameValueCollection[text5] = encryption.encrypt(channelname, this.enckey, text);
			string text6 = "";
			<Module>.FamANDAssem(ref text6, new object[]
			{
				'ᦂ',
				"ỡ઀Cě",
				'ꅾ',
				false
			});
			nameValueCollection[text6] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			string text7 = "갛갔갘감";
			<Module>.FamANDAssem(ref text7, new object[]
			{
				687,
				17,
				false,
				43445
			});
			nameValueCollection[text7] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			string text8 = "茬茴茭茦茱茪茧";
			<Module>.FamANDAssem(ref text8, new object[]
			{
				"㩳ᴽऒ̑ןƯJ",
				6040
			});
			nameValueCollection[text8] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			string text9 = "έὴέὮὅέὬ";
			<Module>.FamANDAssem(ref text9, new object[]
			{
				false,
				6242,
				'B',
				86,
				"գ½"
			});
			nameValueCollection[text9] = text;
			NameValueCollection post_data = nameValueCollection;
			string text10 = api.req(post_data);
			text10 = encryption.decrypt(text10, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text10);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			bool result;
			if (success)
			{
				result = (5 % 2 != 0);
			}
			else
			{
				result = (Convert.ToInt32("0", 2) != 0);
			}
			return result;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00006E04 File Offset: 0x00005004
		public bool checkblack()
		{
			char[] array = new char[]
			{
				'\u0001'
			};
			bool flag = (this.initialized ? 1 : 0) == checked((int)0L);
			if (flag)
			{
				string message = "㽣㽟㽖㽒㽀㽖㼓㽚㽝㽚㽇㽚㽒㽟㽚㽉㽖㼓㽕㽚㽁㽀㽇㼝㼓㽲㽗㽗㼓㽸㽖㽊㽲㽆㽇㽛㽲㽃㽃㼝㽚㽝㽚㽇㼛㼚㼈㼓㽜㽝㼓㽟㽜㽒㽗㼝";
				<Module>.FamANDAssem(ref message, new object[]
				{
					6415,
					9764
				});
				api.error(message);
				Environment.Exit(846 >> 12);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			string text2 = "";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				14176,
				false,
				"⤂ᐷ͢঻ǺÖJ",
				"ᅬᬘ",
				"┄ஏѫ"
			});
			string text3 = text2;
			Encoding @default = Encoding.Default;
			string s = "㶔㶟㶒㶔㶜㶕㶛㶖㶔㶜㶛㶞㶄㶃";
			<Module>.FamANDAssem(ref s, new object[]
			{
				'\u008a',
				"ᘼછ෫",
				436,
				3228,
				91
			});
			nameValueCollection[text3] = encryption.byte_arr_to_str(@default.GetBytes(s));
			string text4 = "띝띂띜띑";
			<Module>.FamANDAssem(ref text4, new object[]
			{
				42940,
				'૊',
				'ү',
				false
			});
			nameValueCollection[text4] = encryption.encrypt(value, this.enckey, text);
			string text5 = "ᕿᕩᕿᕿᕥᕣᕢᕥᕨ";
			<Module>.FamANDAssem(ref text5, new object[]
			{
				3435,
				'j',
				349,
				1498
			});
			nameValueCollection[text5] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			string text6 = "蚶蚹蚵蚽";
			<Module>.FamANDAssem(ref text6, new object[]
			{
				'掸',
				8992
			});
			nameValueCollection[text6] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			string text7 = "᪎᪖᪏᪄᪓᪈᪅";
			<Module>.FamANDAssem(ref text7, new object[]
			{
				'δ',
				false,
				'၆',
				1767
			});
			nameValueCollection[text7] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			string text8 = "軌軋軌軑軺軌軓";
			<Module>.FamANDAssem(ref text8, new object[]
			{
				'ࡡ',
				false,
				23956,
				3980,
				'ᤤ'
			});
			nameValueCollection[text8] = text;
			NameValueCollection post_data = nameValueCollection;
			string text9 = api.req(post_data);
			text9 = encryption.decrypt(text9, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text9);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			bool result;
			if (success)
			{
				result = (array[0] != '\0');
			}
			else
			{
				result = (Convert.ToInt32("0", 16) != 0);
			}
			return result;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00007168 File Offset: 0x00005368
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			bool flag = (this.initialized ? 1 : 0) == 727393 - 727393;
			string result;
			if (flag)
			{
				string message = "竺竆竏立站竏窊竃竄竃竞竃立竆竃竐竏窊竌竃竘站竞窄窊竫竎竎窊竡竏竓竫竟竞竂竫竚竚窄竃竄竃竞窂窃窑窊竅竄窊竆竅立竎窄";
				<Module>.FamANDAssem(ref message, new object[]
				{
					"ኗॆ޼ٵభ´ɭ",
					"ន⦻"
				});
				api.error(message);
				int exitCode = 0;
				Environment.Exit(exitCode);
				result = null;
			}
			else
			{
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				string text2 = "";
				<Module>.FamANDAssem(ref text2, new object[]
				{
					'뻓',
					false,
					"ۯ׈Łࣁ",
					7738
				});
				string text3 = text2;
				Encoding @default = Encoding.Default;
				string s = "ﯠﯲﯵﯿﯸﯸﯼ";
				<Module>.FamANDAssem(ref s, new object[]
				{
					11697,
					2354,
					1007,
					49349
				});
				nameValueCollection[text3] = encryption.byte_arr_to_str(@default.GetBytes(s));
				string text4 = "꾘꾊꾍꾆꾋";
				<Module>.FamANDAssem(ref text4, new object[]
				{
					36084,
					3438,
					"ćɻ\u0018n",
					4485
				});
				nameValueCollection[text4] = encryption.encrypt(webid, this.enckey, text);
				string text5 = "즸즩즺즩즥즻";
				<Module>.FamANDAssem(ref text5, new object[]
				{
					'锣',
					13477
				});
				nameValueCollection[text5] = encryption.encrypt(param, this.enckey, text);
				string text6 = "䥍䥀䥋䥖";
				<Module>.FamANDAssem(ref text6, new object[]
				{
					17954,
					696,
					false,
					85
				});
				nameValueCollection[text6] = encryption.encrypt(body, this.enckey, text);
				string text7 = "瑒瑞瑟瑅瑅瑈瑁瑔";
				<Module>.FamANDAssem(ref text7, new object[]
				{
					17739,
					9353,
					2653
				});
				nameValueCollection[text7] = encryption.encrypt(conttype, this.enckey, text);
				string text8 = "莏莙莏莏莕莓莒莕莘";
				<Module>.FamANDAssem(ref text8, new object[]
				{
					3964,
					29824
				});
				nameValueCollection[text8] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				string text9 = "죥죪죦죮";
				<Module>.FamANDAssem(ref text9, new object[]
				{
					'句',
					29862
				});
				nameValueCollection[text9] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				string text10 = "㒚㒂㒛㒐㒇㒜㒑";
				<Module>.FamANDAssem(ref text10, new object[]
				{
					'\u0085',
					'օ',
					'⻫'
				});
				nameValueCollection[text10] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				string text11 = "얎얉얎얓언얎양";
				<Module>.FamANDAssem(ref text11, new object[]
				{
					470,
					'೹',
					"ƪª\u000f\u0006\0\u0002",
					29181,
					17072
				});
				nameValueCollection[text11] = text;
				NameValueCollection post_data = nameValueCollection;
				string text12 = api.req(post_data);
				text12 = encryption.decrypt(text12, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text12);
				this.load_response_struct(response_structure);
				bool success = response_structure.success;
				if (success)
				{
					result = response_structure.response;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00007564 File Offset: 0x00005764
		public byte[] download(string fileid)
		{
			char[] array = new char[]
			{
				'\0'
			};
			bool flag = (this.initialized ? '\u0001' : '\0') == array[0];
			if (flag)
			{
				string message = "ｓｯｦ｢ｰｦＣｪｭｪｷｪ｢ｯｪｹｦＣ･ｪｱｰｷＭＣｂｧｧＣｈｦｺｂｶｷｫｂｳｳＭｪｭｪｷＫＪＸＣｬｭＣｯｬ｢ｧＭＣｅｪｯｦＣｪｰＣｦｮｳｷｺＣｰｪｭ｠ｦＣｭｬＣｱｦｲｶｦｰｷＣ｠ｬｶｯｧＣ｡ｦＣｮ｢ｧｦＭ";
				<Module>.FamANDAssem(ref message, new object[]
				{
					24361,
					40922
				});
				api.error(message);
				Environment.Exit(0 % 476013);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			string text2 = "㣹㣴㣽㣨";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				5982,
				'Ь',
				'ᴃ'
			});
			string text3 = text2;
			Encoding @default = Encoding.Default;
			string s = "绝绒绗绞";
			<Module>.FamANDAssem(ref s, new object[]
			{
				'଒',
				"⥛ψˈ",
				333,
				2698,
				14311
			});
			nameValueCollection[text3] = encryption.byte_arr_to_str(@default.GetBytes(s));
			string text4 = "孡孮孫孢孮季";
			<Module>.FamANDAssem(ref text4, new object[]
			{
				13553,
				526,
				"Ð*$",
				1671,
				7267
			});
			nameValueCollection[text4] = encryption.encrypt(fileid, this.enckey, text);
			string text5 = "ꂼꂪꂼꂼꂦꂠꂡꂦꂫ";
			<Module>.FamANDAssem(ref text5, new object[]
			{
				12948,
				1475,
				16582,
				"༣ي෢·w̵"
			});
			nameValueCollection[text5] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			string text6 = "䣫䣤䣨䣠";
			<Module>.FamANDAssem(ref text6, new object[]
			{
				"઴\u009eòतᲢ",
				false,
				1928,
				3827
			});
			nameValueCollection[text6] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			string text7 = "";
			<Module>.FamANDAssem(ref text7, new object[]
			{
				"㸴߭+\u0019\u007f\u001f\u0014",
				41919,
				"Ƿ\u0006:\u001b\u001e\u0010\u001c"
			});
			nameValueCollection[text7] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			string text8 = "귽귺귽균귋귽귢";
			<Module>.FamANDAssem(ref text8, new object[]
			{
				"でጛშ࠵",
				false,
				20725
			});
			nameValueCollection[text8] = text;
			NameValueCollection post_data = nameValueCollection;
			string text9 = api.req(post_data);
			text9 = encryption.decrypt(text9, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text9);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			byte[] result;
			if (success)
			{
				result = encryption.str_to_byte_arr(response_structure.contents);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00007890 File Offset: 0x00005A90
		public void log(string message)
		{
			bool flag = (this.initialized ? 1 : 0) == -206974 + 206974;
			if (flag)
			{
				string message2 = "㑮㑒㑛㑟㑍㑛㐞㑗㑐㑗㑊㑗㑟㑒㑗㑄㑛㐞㑘㑗㑌㑍㑊㐐㐞㑿㑚㑚㐞㑵㑛㑇㑿㑋㑊㑖㑿㑎㑎㐐㑗㑐㑗㑊㐖㐗㐅㐞㑑㑐㐞㑒㑑㑟㑚㐐";
				<Module>.FamANDAssem(ref message2, new object[]
				{
					'゠',
					208,
					549,
					169
				});
				api.error(message2);
				Environment.Exit(0 & 0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			string text2 = "쯃쯎쯇쯒";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				"尩඄ኟ",
				20331
			});
			string text3 = text2;
			Encoding @default = Encoding.Default;
			string s = "䭀䭃䭋";
			<Module>.FamANDAssem(ref s, new object[]
			{
				"⌰İŞ\u0010z\u0015",
				'Ⓩ'
			});
			nameValueCollection[text3] = encryption.byte_arr_to_str(@default.GetBytes(s));
			string text4 = "ᓐᓃᓕᓓᓅᓒ";
			<Module>.FamANDAssem(ref text4, new object[]
			{
				false,
				"ďC߰",
				"lA\u0003\u0001\t\u0002",
				2107,
				615
			});
			nameValueCollection[text4] = encryption.encrypt(Environment.UserName, this.enckey, text);
			string text5 = "畫畣畵畵畧畡畣";
			<Module>.FamANDAssem(ref text5, new object[]
			{
				"vM\aq%~",
				11174,
				408,
				'ŀ',
				false,
				"ѣช⩼˷їo\u0004"
			});
			nameValueCollection[text5] = encryption.encrypt(message, this.enckey, text);
			string text6 = "滺滬滺滺滠滦滧滠滭";
			<Module>.FamANDAssem(ref text6, new object[]
			{
				true,
				4421,
				"倘ֆ`݃",
				2,
				false
			});
			nameValueCollection[text6] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			string text7 = "綗綘綔綜";
			<Module>.FamANDAssem(ref text7, new object[]
			{
				false,
				'₄',
				23925
			});
			nameValueCollection[text7] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			string text8 = "蜢蜺蜣蜨蜿蜤蜩";
			<Module>.FamANDAssem(ref text8, new object[]
			{
				10608,
				'川'
			});
			nameValueCollection[text8] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			string text9 = "밀밇밀밝밶밀밟";
			<Module>.FamANDAssem(ref text9, new object[]
			{
				'ꎌ',
				6365,
				false
			});
			nameValueCollection[text9] = text;
			NameValueCollection post_data = nameValueCollection;
			api.req(post_data);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00007BAC File Offset: 0x00005DAC
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					string text = BitConverter.ToString(value);
					string oldValue = "﯐";
					<Module>.FamANDAssem(ref oldValue, new object[]
					{
						"⧮븵",
						'Ꮪ'
					});
					result = text.Replace(oldValue, "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00007C54 File Offset: 0x00005E54
		public static void error(string message)
		{
			int[] array = new int[]
			{
				1
			};
			string text = "";
			<Module>.FamANDAssem(ref text, new object[]
			{
				19658,
				224,
				25431,
				14889
			});
			string fileName = text;
			string text2 = "䄒䅞䄝䅎䅉䅜䅏䅉䄝䅞䅐䅙䄝䄒䅾䄝䄟䅞䅒䅑䅒䅏䄝䅟䄝䄛䄛䄝䅉䅔䅉䅑䅘䄝䅸䅏䅏䅒䅏䄝䄛䄛䄝䅘䅞䅕䅒䄝";
			<Module>.FamANDAssem(ref text2, new object[]
			{
				6104,
				"Უૢ\u0005\u0091Ñy"
			});
			string str = text2;
			string str2 = "湡湧湧湡渵渨測渤渮渴渵湡湮渵湡湴湣";
			<Module>.FamANDAssem(ref str2, new object[]
			{
				'ও',
				5909,
				"ངᾩᜬ˚Ҧ",
				false
			});
			Process.Start(new ProcessStartInfo(fileName, str + message + str2)
			{
				CreateNoWindow = (api.IsValidToken != 0),
				RedirectStandardOutput = (array[0] != 0),
				RedirectStandardError = (5 % 2 != 0),
				UseShellExecute = (132249 + -132249 != 0)
			});
			Environment.Exit(Convert.ToInt32("0", 8));
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00007D74 File Offset: 0x00005F74
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					WebClient webClient2 = webClient;
					string address = "";
					<Module>.FamANDAssem(ref address, new object[]
					{
						3490,
						"ჭ\b&\u0005\r\u0006",
						46596,
						"ዷ\u000e/"
					});
					byte[] bytes = webClient2.UploadValues(address, post_data);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				int num = (int)httpStatusCode;
				int num2;
				if (-97027 >= -856203)
				{
					num2 = 429;
				}
				else
				{
					num2 = 316000;
				}
				if (num != num2)
				{
					string message = "㹳㹟㹞㹞㹕㹓㹄㹙㹟㹞㸐㹖㹑㹙㹜㹅㹂㹕㸞㸐㹠㹜㹕㹑㹃㹕㸐㹄㹂㹉㸐㹑㹗㹑㹙㹞㸜㸐㹟㹂㸐㹓㹟㹞㹄㹑㹓㹄㸐㹅㹃㸐㹖㹟㹂㸐㹘㹕㹜㹀㸞";
					<Module>.FamANDAssem(ref message, new object[]
					{
						11142,
						630,
						false,
						"\v£",
						'྆'
					});
					api.error(message);
					Environment.Exit(Convert.ToInt32("0", 2));
					result = "";
				}
				else
				{
					string message2 = "ꖗꖡꖻꗩꖼꖫꗮꖭꖡꖠꖠꖫꖭꖺꖧꖠꖩꗮꖺꖡꖡꗮꖨꖯꖽꖺꗮꖺꖡꗮꖢꖡꖯꖪꖫꖼꗢꗮꖽꖢꖡꖹꗮꖪꖡꖹꖠꗠ";
					<Module>.FamANDAssem(ref message2, new object[]
					{
						20359,
						5691,
						11847,
						'ᇅ'
					});
					api.error(message2);
					Environment.Exit(0 % 994078);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00007F40 File Offset: 0x00006140
		private static string req_unenc(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					WebClient webClient2 = webClient;
					string address = "踤踸踸踼踿蹶蹣蹣踧踩踵踭踹踸踤蹢踻踥踢蹣踭踼踥蹣蹽蹢蹽蹣";
					<Module>.FamANDAssem(ref address, new object[]
					{
						"t\u0091",
						17,
						"Ѧ̳Ѫ",
						'惾',
						"̺ᠪӑ",
						false
					});
					byte[] bytes = webClient2.UploadValues(address, post_data);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				if (httpStatusCode != (HttpStatusCode)(-156085) + 156514)
				{
					string message = "혛혷혶혶혽혻혬혱혷혶홸혾혹혱혴혭혪혽홶홸혈혴혽혹혫혽홸혬혪혡홸혹혿혹혱혶홴홸혷혪홸혻혷혶혬혹혻혬홸혭혫홸혾혷혪홸혰혽혴혨홶";
					<Module>.FamANDAssem(ref message, new object[]
					{
						9927,
						'溦',
						'㛑',
						2586
					});
					api.error(message);
					Environment.Exit(api.get_DefaultBinder);
					result = "";
				}
				else
				{
					int millisecondsTimeout;
					switch (1 * 1)
					{
					case 0:
						millisecondsTimeout = 774;
						break;
					case 1:
						millisecondsTimeout = 1000;
						break;
					}
					Thread.Sleep(millisecondsTimeout);
					result = api.req(post_data);
				}
			}
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000080AC File Offset: 0x000062AC
		private void load_app_data(api.app_data_structure data)
		{
			this.app_data.numUsers = data.numUsers;
			this.app_data.numOnlineUsers = data.numOnlineUsers;
			this.app_data.numKeys = data.numKeys;
			this.app_data.version = data.version;
			this.app_data.customerPanelLink = data.customerPanelLink;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00008114 File Offset: 0x00006314
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00008190 File Offset: 0x00006390
		public string expirydaysleft()
		{
			char[] array = new char[]
			{
				'\0'
			};
			bool flag = (this.initialized ? 1 : 0) == api.get_DefaultBinder;
			if (flag)
			{
				string message = "ﻋﻷ﻾ﻺﻨ﻾ﺻﻲﻵﻲﻯﻲﻺﻷﻲﻡ﻾ﺻ﻽ﻲﻩﻨﻯﺵﺻﻚ﻿﻿ﺻﻐ﻾ﻢﻚﻮﻯﻳﻚﻫﻫﺵﻲﻵﻲﻯﺳﺲﺠﺻﻴﻵﺻﻷﻴﻺ﻿ﺵ";
				<Module>.FamANDAssem(ref message, new object[]
				{
					9308,
					'ཨ',
					20750,
					30732,
					445
				});
				api.error(message);
				Environment.Exit((int)array[0]);
			}
			int year = 567802 - 565832;
			char c = '\u0001';
			checked
			{
				int month = (int)c;
				int day = Convert.ToInt32("1", 2);
				int hour = 0 % -88153;
				int minute = 0;
				DateTime d = new DateTime(year, month, day, hour, minute, 0 * -336923, unchecked(942365 - 942365), (DateTimeKind)(20722215 >> 23));
				d = d.AddSeconds((double)long.Parse(this.user_data.subscriptions[43552 + -43552].expiry)).ToLocalTime();
				TimeSpan timeSpan = d - DateTime.Now;
				string str = timeSpan.Days.ToString();
				string text = "赃货贂贚贐赃";
				<Module>.FamANDAssem(ref text, new object[]
				{
					3514,
					629,
					108,
					26776,
					5168
				});
				string str2 = text;
				string str3 = timeSpan.Hours.ToString();
				string str4 = "묱뭙뭾뭤뭣뭢묱뭝뭴뭷뭥";
				<Module>.FamANDAssem(ref str4, new object[]
				{
					17272,
					5046,
					14381,
					11190
				});
				return Convert.ToString(str + str2 + str3 + str4);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002311 File Offset: 0x00000511
		private void load_response_struct(api.response_structure data)
		{
			this.response.success = data.success;
			this.response.message = data.message;
		}

		// Token: 0x0400000A RID: 10
		public string name;

		// Token: 0x0400000B RID: 11
		public string ownerid;

		// Token: 0x0400000C RID: 12
		public string secret;

		// Token: 0x0400000D RID: 13
		public string version;

		// Token: 0x0400000E RID: 14
		private string sessionid;

		// Token: 0x0400000F RID: 15
		private string enckey;

		// Token: 0x04000010 RID: 16
		private bool initialized;

		// Token: 0x04000011 RID: 17
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x04000012 RID: 18
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x04000013 RID: 19
		public api.response_class response = new api.response_class();

		// Token: 0x04000014 RID: 20
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x04000015 RID: 21 RVA: 0x00002108 File Offset: 0x00000308
		private static int IsValidToken;

		// Token: 0x04000016 RID: 22 RVA: 0x00002110 File Offset: 0x00000310
		private static int get_DefaultBinder;

		// Token: 0x02000005 RID: 5
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x06000024 RID: 36 RVA: 0x00002338 File Offset: 0x00000538
			// (set) Token: 0x06000025 RID: 37 RVA: 0x00002340 File Offset: 0x00000540
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000026 RID: 38 RVA: 0x00002349 File Offset: 0x00000549
			// (set) Token: 0x06000027 RID: 39 RVA: 0x00002351 File Offset: 0x00000551
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000028 RID: 40 RVA: 0x0000235A File Offset: 0x0000055A
			// (set) Token: 0x06000029 RID: 41 RVA: 0x00002362 File Offset: 0x00000562
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x0600002A RID: 42 RVA: 0x0000236B File Offset: 0x0000056B
			// (set) Token: 0x0600002B RID: 43 RVA: 0x00002373 File Offset: 0x00000573
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x0600002C RID: 44 RVA: 0x0000237C File Offset: 0x0000057C
			// (set) Token: 0x0600002D RID: 45 RVA: 0x00002384 File Offset: 0x00000584
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600002E RID: 46 RVA: 0x0000238D File Offset: 0x0000058D
			// (set) Token: 0x0600002F RID: 47 RVA: 0x00002395 File Offset: 0x00000595
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000030 RID: 48 RVA: 0x0000239E File Offset: 0x0000059E
			// (set) Token: 0x06000031 RID: 49 RVA: 0x000023A6 File Offset: 0x000005A6
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000032 RID: 50 RVA: 0x000023AF File Offset: 0x000005AF
			// (set) Token: 0x06000033 RID: 51 RVA: 0x000023B7 File Offset: 0x000005B7
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000034 RID: 52 RVA: 0x000023C0 File Offset: 0x000005C0
			// (set) Token: 0x06000035 RID: 53 RVA: 0x000023C8 File Offset: 0x000005C8
			[DataMember]
			public List<api.msg> messages { get; set; }

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000036 RID: 54 RVA: 0x000023D1 File Offset: 0x000005D1
			// (set) Token: 0x06000037 RID: 55 RVA: 0x000023D9 File Offset: 0x000005D9
			[DataMember]
			public List<api.users> users { get; set; }
		}

		// Token: 0x02000006 RID: 6
		public class msg
		{
			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000039 RID: 57 RVA: 0x000023EB File Offset: 0x000005EB
			// (set) Token: 0x0600003A RID: 58 RVA: 0x000023F3 File Offset: 0x000005F3
			public string message { get; set; }

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600003B RID: 59 RVA: 0x000023FC File Offset: 0x000005FC
			// (set) Token: 0x0600003C RID: 60 RVA: 0x00002404 File Offset: 0x00000604
			public string author { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x0600003D RID: 61 RVA: 0x0000240D File Offset: 0x0000060D
			// (set) Token: 0x0600003E RID: 62 RVA: 0x00002415 File Offset: 0x00000615
			public string timestamp { get; set; }
		}

		// Token: 0x02000007 RID: 7
		public class users
		{
			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000040 RID: 64 RVA: 0x0000241E File Offset: 0x0000061E
			// (set) Token: 0x06000041 RID: 65 RVA: 0x00002426 File Offset: 0x00000626
			public string credential { get; set; }
		}

		// Token: 0x02000008 RID: 8
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000043 RID: 67 RVA: 0x0000242F File Offset: 0x0000062F
			// (set) Token: 0x06000044 RID: 68 RVA: 0x00002437 File Offset: 0x00000637
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000045 RID: 69 RVA: 0x00002440 File Offset: 0x00000640
			// (set) Token: 0x06000046 RID: 70 RVA: 0x00002448 File Offset: 0x00000648
			[DataMember]
			public string ip { get; set; }

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000047 RID: 71 RVA: 0x00002451 File Offset: 0x00000651
			// (set) Token: 0x06000048 RID: 72 RVA: 0x00002459 File Offset: 0x00000659
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000049 RID: 73 RVA: 0x00002462 File Offset: 0x00000662
			// (set) Token: 0x0600004A RID: 74 RVA: 0x0000246A File Offset: 0x0000066A
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600004B RID: 75 RVA: 0x00002473 File Offset: 0x00000673
			// (set) Token: 0x0600004C RID: 76 RVA: 0x0000247B File Offset: 0x0000067B
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x0600004D RID: 77 RVA: 0x00002484 File Offset: 0x00000684
			// (set) Token: 0x0600004E RID: 78 RVA: 0x0000248C File Offset: 0x0000068C
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000009 RID: 9
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000050 RID: 80 RVA: 0x00002495 File Offset: 0x00000695
			// (set) Token: 0x06000051 RID: 81 RVA: 0x0000249D File Offset: 0x0000069D
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000052 RID: 82 RVA: 0x000024A6 File Offset: 0x000006A6
			// (set) Token: 0x06000053 RID: 83 RVA: 0x000024AE File Offset: 0x000006AE
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000054 RID: 84 RVA: 0x000024B7 File Offset: 0x000006B7
			// (set) Token: 0x06000055 RID: 85 RVA: 0x000024BF File Offset: 0x000006BF
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000056 RID: 86 RVA: 0x000024C8 File Offset: 0x000006C8
			// (set) Token: 0x06000057 RID: 87 RVA: 0x000024D0 File Offset: 0x000006D0
			[DataMember]
			public string version { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000058 RID: 88 RVA: 0x000024D9 File Offset: 0x000006D9
			// (set) Token: 0x06000059 RID: 89 RVA: 0x000024E1 File Offset: 0x000006E1
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600005A RID: 90 RVA: 0x000024EA File Offset: 0x000006EA
			// (set) Token: 0x0600005B RID: 91 RVA: 0x000024F2 File Offset: 0x000006F2
			[DataMember]
			public string downloadLink { get; set; }
		}

		// Token: 0x0200000A RID: 10
		public class app_data_class
		{
			// Token: 0x1700001B RID: 27
			// (get) Token: 0x0600005D RID: 93 RVA: 0x000024FB File Offset: 0x000006FB
			// (set) Token: 0x0600005E RID: 94 RVA: 0x00002503 File Offset: 0x00000703
			public string numUsers { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x0600005F RID: 95 RVA: 0x0000250C File Offset: 0x0000070C
			// (set) Token: 0x06000060 RID: 96 RVA: 0x00002514 File Offset: 0x00000714
			public string numOnlineUsers { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000061 RID: 97 RVA: 0x0000251D File Offset: 0x0000071D
			// (set) Token: 0x06000062 RID: 98 RVA: 0x00002525 File Offset: 0x00000725
			public string numKeys { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000063 RID: 99 RVA: 0x0000252E File Offset: 0x0000072E
			// (set) Token: 0x06000064 RID: 100 RVA: 0x00002536 File Offset: 0x00000736
			public string version { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000065 RID: 101 RVA: 0x0000253F File Offset: 0x0000073F
			// (set) Token: 0x06000066 RID: 102 RVA: 0x00002547 File Offset: 0x00000747
			public string customerPanelLink { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000067 RID: 103 RVA: 0x00002550 File Offset: 0x00000750
			// (set) Token: 0x06000068 RID: 104 RVA: 0x00002558 File Offset: 0x00000758
			public string downloadLink { get; set; }
		}

		// Token: 0x0200000B RID: 11
		public class user_data_class
		{
			// Token: 0x17000021 RID: 33
			// (get) Token: 0x0600006A RID: 106 RVA: 0x00002561 File Offset: 0x00000761
			// (set) Token: 0x0600006B RID: 107 RVA: 0x00002569 File Offset: 0x00000769
			public string username { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x0600006C RID: 108 RVA: 0x00002572 File Offset: 0x00000772
			// (set) Token: 0x0600006D RID: 109 RVA: 0x0000257A File Offset: 0x0000077A
			public string ip { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x0600006E RID: 110 RVA: 0x00002583 File Offset: 0x00000783
			// (set) Token: 0x0600006F RID: 111 RVA: 0x0000258B File Offset: 0x0000078B
			public string hwid { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000070 RID: 112 RVA: 0x00002594 File Offset: 0x00000794
			// (set) Token: 0x06000071 RID: 113 RVA: 0x0000259C File Offset: 0x0000079C
			public string createdate { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000072 RID: 114 RVA: 0x000025A5 File Offset: 0x000007A5
			// (set) Token: 0x06000073 RID: 115 RVA: 0x000025AD File Offset: 0x000007AD
			public string lastlogin { get; set; }

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x06000074 RID: 116 RVA: 0x000025B6 File Offset: 0x000007B6
			// (set) Token: 0x06000075 RID: 117 RVA: 0x000025BE File Offset: 0x000007BE
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200000C RID: 12
		public class Data
		{
			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000077 RID: 119 RVA: 0x000025C7 File Offset: 0x000007C7
			// (set) Token: 0x06000078 RID: 120 RVA: 0x000025CF File Offset: 0x000007CF
			public string subscription { get; set; }

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x06000079 RID: 121 RVA: 0x000025D8 File Offset: 0x000007D8
			// (set) Token: 0x0600007A RID: 122 RVA: 0x000025E0 File Offset: 0x000007E0
			public string expiry { get; set; }

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x0600007B RID: 123 RVA: 0x000025E9 File Offset: 0x000007E9
			// (set) Token: 0x0600007C RID: 124 RVA: 0x000025F1 File Offset: 0x000007F1
			public string timeleft { get; set; }
		}

		// Token: 0x0200000D RID: 13
		public class response_class
		{
			// Token: 0x1700002A RID: 42
			// (get) Token: 0x0600007E RID: 126 RVA: 0x000025FA File Offset: 0x000007FA
			// (set) Token: 0x0600007F RID: 127 RVA: 0x000025FD File Offset: 0x000007FD
			public bool success
			{
				[CompilerGenerated]
				get
				{
					return true;
				}
				[CompilerGenerated]
				set
				{
					this.<success>k__BackingField = true;
				}
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x06000080 RID: 128 RVA: 0x00002606 File Offset: 0x00000806
			// (set) Token: 0x06000081 RID: 129 RVA: 0x0000260E File Offset: 0x0000080E
			public string message { get; set; }
		}
	}
}
