using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WPF_login.Properties
{
	// Token: 0x02000085 RID: 133
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000413 RID: 1043 RVA: 0x00002E5A File Offset: 0x0000105A
		internal Resources()
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00181188 File Offset: 0x0017F388
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					string baseName = "ᅿᅸᅮᅷᅄᅇᅏᅁᅆᄆᅸᅚᅇᅘᅍᅚᅜᅁᅍᅛᄆᅺᅍᅛᅇᅝᅚᅋᅍᅛ";
					<Module>.FamANDAssem(ref baseName, new object[]
					{
						false,
						4302,
						90
					});
					ResourceManager resourceManager = new ResourceManager(baseName, typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x00181200 File Offset: 0x0017F400
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x00002E64 File Offset: 0x00001064
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x0400061F RID: 1567
		private static ResourceManager resourceMan;

		// Token: 0x04000620 RID: 1568
		private static CultureInfo resourceCulture;
	}
}
