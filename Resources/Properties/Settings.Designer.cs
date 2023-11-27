using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace WPF_login.Properties
{
	// Token: 0x02000086 RID: 134
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00181218 File Offset: 0x0017F418
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000621 RID: 1569
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
