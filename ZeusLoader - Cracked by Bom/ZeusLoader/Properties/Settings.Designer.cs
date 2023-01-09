using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Auth.GG_Winform_Example.Properties
{
	// Token: 0x02000014 RID: 20
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000071D0 File Offset: 0x000053D0
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000062 RID: 98
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
