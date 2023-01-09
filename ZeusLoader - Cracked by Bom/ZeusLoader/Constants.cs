using System;
using System.Linq;
using System.Security.Principal;

namespace Auth.GG_Winform_Example
{
	// Token: 0x02000003 RID: 3
	internal class Constants
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000206B File Offset: 0x0000026B
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002072 File Offset: 0x00000272
		public static string Token { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000207A File Offset: 0x0000027A
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002081 File Offset: 0x00000281
		public static string Date { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002089 File Offset: 0x00000289
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002090 File Offset: 0x00000290
		public static string APIENCRYPTKEY { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002098 File Offset: 0x00000298
		// (set) Token: 0x0600000B RID: 11 RVA: 0x0000209F File Offset: 0x0000029F
		public static string APIENCRYPTSALT { get; set; }

		// Token: 0x0600000C RID: 12 RVA: 0x00002460 File Offset: 0x00000660
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", length)
			select s[Constants.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000024AC File Offset: 0x000006AC
		public static string HWID()
		{
			return WindowsIdentity.GetCurrent().User.Value;
		}

		// Token: 0x04000007 RID: 7
		public static bool Breached = false;

		// Token: 0x04000008 RID: 8
		public static bool Started = false;

		// Token: 0x04000009 RID: 9
		public static string IV = null;

		// Token: 0x0400000A RID: 10
		public static string Key = null;

		// Token: 0x0400000B RID: 11
		public static string ApiUrl = "https://api.auth.gg/csharp/";

		// Token: 0x0400000C RID: 12
		public static bool Initialized = false;

		// Token: 0x0400000D RID: 13
		public static Random random = new Random();
	}
}
