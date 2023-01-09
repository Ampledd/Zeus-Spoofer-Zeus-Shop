using System;
using System.Windows.Forms;

namespace Auth.GG_Winform_Example
{
	// Token: 0x02000012 RID: 18
	internal static class Program
	{
		// Token: 0x06000089 RID: 137 RVA: 0x000023A8 File Offset: 0x000005A8
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}
	}
}
