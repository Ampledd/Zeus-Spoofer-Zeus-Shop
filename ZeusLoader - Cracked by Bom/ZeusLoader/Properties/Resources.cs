using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Auth.GG_Winform_Example.Properties
{
	// Token: 0x02000013 RID: 19
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600008A RID: 138 RVA: 0x000023BF File Offset: 0x000005BF
		internal Resources()
		{
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00007170 File Offset: 0x00005370
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("Auth.GG_Winform_Example.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000071B8 File Offset: 0x000053B8
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000023C9 File Offset: 0x000005C9
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

		// Token: 0x04000060 RID: 96
		private static ResourceManager resourceMan;

		// Token: 0x04000061 RID: 97
		private static CultureInfo resourceCulture;
	}
}
