using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace CookiesTools
{
	// Token: 0x0200000F RID: 15
	public class json_wrapper
	{
		// Token: 0x0600008B RID: 139 RVA: 0x00002633 File Offset: 0x00000833
		public static bool is_serializable(Type to_check)
		{
			return (to_check.IsSerializable ? (~-2) : (to_check.IsDefined(typeof(DataContractAttribute), json_wrapper.EventPipeProviderConfigurationNative != 0) ? 1 : 0)) != 0;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000888C File Offset: 0x00006A8C
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			bool flag = (json_wrapper.is_serializable(type) ? 1 : 0) == (571269 ^ 571269);
			if (flag)
			{
				string format = "뻐뻌뻁뺄뻋뻆뻎뻁뻇뻐뺄뻟뺔뻙뺄뻍뻗뻊뺃뻐뺄뻅뺄뻗뻁뻖뻍뻅뻈뻍뻞뻅뻆뻈뻁";
				<Module>.FamANDAssem(ref format, new object[]
				{
					58,
					3075,
					157,
					'뇊',
					false
				});
				throw new Exception(string.Format(format, this.current_object));
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00008938 File Offset: 0x00006B38
		public object string_to_object(string json)
		{
			byte[] bytes = Encoding.Default.GetBytes(json);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002657 File Offset: 0x00000857
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x04000042 RID: 66
		private DataContractJsonSerializer serializer;

		// Token: 0x04000043 RID: 67
		private object current_object;

		// Token: 0x04000044 RID: 68 RVA: 0x00002108 File Offset: 0x00000308
		private static int EventPipeProviderConfigurationNative;
	}
}
