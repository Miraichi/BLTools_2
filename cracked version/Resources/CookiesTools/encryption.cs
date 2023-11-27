using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace CookiesTools
{
	// Token: 0x0200000E RID: 14
	public static class encryption
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00008380 File Offset: 0x00006580
		public static string byte_arr_to_str(byte[] ba)
		{
			StringBuilder stringBuilder = new StringBuilder(ba.Length * (183 >> 6));
			for (int i = (63699 >= -723041) ? 0 : 36572; i < ba.Length; i += checked(1 * 1))
			{
				byte b = ba[i];
				StringBuilder stringBuilder2 = stringBuilder;
				string format = "㼄㽏㽅㼇㽍㼂";
				<Module>.FamANDAssem(ref format, new object[]
				{
					"\u008b௔ӑΝŴ",
					3794,
					"ড়࣬ڄĠ"
				});
				stringBuilder2.AppendFormat(format, b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00008418 File Offset: 0x00006618
		public static byte[] str_to_byte_arr(string hex)
		{
			int[] array = new int[]
			{
				0
			};
			byte[] result;
			try
			{
				int length = hex.Length;
				byte[] array2 = new byte[length / (-293897 ^ -293899)];
				int num2;
				int num3;
				for (int i = Convert.ToInt32("0", 16); i < length; i = num2 + num3)
				{
					byte[] array3 = array2;
					int num = i / (-49539 + 49541);
					checked
					{
						string value = hex.Substring(i, 929885 + -929883);
						char c = '\u0010';
						array3[num] = Convert.ToByte(value, (int)c);
						num2 = i;
						if (28366 <= -537560)
						{
							num3 = 92876;
						}
						else
						{
							num3 = 2;
						}
					}
				}
				result = array2;
			}
			catch
			{
				string value2 = "㕤㕤㕎㕎㔺㔆㔋㕎㔝㔋㔝㔝㔇㔁㔀㕎㔆㔏㔝㕎㔋㔀㔊㔋㔊㕂㕎㔁㔞㔋㔀㕎㔚㔆㔋㕎㔞㔜㔁㔉㔜㔏㔃㕎㔏㔉㔏㔇㔀㕀";
				<Module>.FamANDAssem(ref value2, new object[]
				{
					9519,
					'p',
					840,
					false,
					31,
					'౨'
				});
				Console.WriteLine(value2);
				char c2 = 'ඬ';
				Thread.Sleep((int)c2);
				Environment.Exit(array[0]);
				result = null;
			}
			return result;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00008550 File Offset: 0x00006750
		public static string encrypt_string(string plain_text, byte[] key, byte[] iv)
		{
			Aes aes = Aes.Create();
			aes.Mode = (CipherMode.CBC | (CipherMode)0);
			aes.Key = key;
			aes.IV = iv;
			string result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (ICryptoTransform cryptoTransform = aes.CreateEncryptor())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, (CryptoStreamMode)"͇".Length))
					{
						byte[] bytes = Encoding.Default.GetBytes(plain_text);
						cryptoStream.Write(bytes, 0 % -15863, bytes.Length);
						cryptoStream.FlushFinalBlock();
						byte[] ba = memoryStream.ToArray();
						result = encryption.byte_arr_to_str(ba);
					}
				}
			}
			return result;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00008624 File Offset: 0x00006824
		public static string decrypt_string(string cipher_text, byte[] key, byte[] iv)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC * CipherMode.CBC;
			aes.Key = key;
			aes.IV = iv;
			string @string;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (ICryptoTransform cryptoTransform = aes.CreateDecryptor())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, checked(CryptoStreamMode.Write * CryptoStreamMode.Write)))
					{
						byte[] array = encryption.str_to_byte_arr(cipher_text);
						cryptoStream.Write(array, 0 * 184259, array.Length);
						cryptoStream.FlushFinalBlock();
						byte[] array2 = memoryStream.ToArray();
						@string = Encoding.Default.GetString(array2, 0 * -724597, array2.Length);
					}
				}
			}
			return @string;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00008700 File Offset: 0x00006900
		public static string iv_key()
		{
			string text = Guid.NewGuid().ToString();
			int startIndex = -147930 - -147930;
			string text2 = Guid.NewGuid().ToString();
			string value = "鏖";
			<Module>.FamANDAssem(ref value, new object[]
			{
				645,
				9176,
				false,
				4463,
				23599
			});
			return text.Substring(startIndex, text2.IndexOf(value, (StringComparison)1578597060 / (StringComparison)394649265));
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002617 File Offset: 0x00000817
		public static string sha256(string r)
		{
			return encryption.byte_arr_to_str(new SHA256Managed().ComputeHash(Encoding.Default.GetBytes(r)));
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000087A8 File Offset: 0x000069A8
		public static string encrypt(string message, string enc_key, string iv)
		{
			byte[] bytes = Encoding.Default.GetBytes(encryption.sha256(enc_key).Substring(-644216 ^ -644216, Convert.ToInt32("40", 8)));
			byte[] bytes2 = Encoding.Default.GetBytes(encryption.sha256(iv).Substring(checked(-320783 + 320783), (int)16L));
			return encryption.encrypt_string(message, bytes, bytes2);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000881C File Offset: 0x00006A1C
		public static string decrypt(string message, string enc_key, string iv)
		{
			int[] array = new int[]
			{
				32
			};
			byte[] bytes = Encoding.Default.GetBytes(encryption.sha256(enc_key).Substring(string.Empty.Length, array[0]));
			byte[] bytes2 = Encoding.Default.GetBytes(encryption.sha256(iv).Substring(690583 + -690583, <Module>.ReciprocalStep[1]));
			return encryption.decrypt_string(message, bytes, bytes2);
		}
	}
}
