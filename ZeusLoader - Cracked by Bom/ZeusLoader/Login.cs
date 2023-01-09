using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Auth.GG_Winform_Example
{
	// Token: 0x02000011 RID: 17
	public partial class Login : Form
	{
		// Token: 0x06000082 RID: 130 RVA: 0x00002383 File Offset: 0x00000583
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000239B File Offset: 0x0000059B
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00006600 File Offset: 0x00004800
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			bool flag = API.AIO(this.key.Text);
			if (flag)
			{
				Main main = new Main();
				main.Show();
				base.Hide();
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000023A5 File Offset: 0x000005A5
		private void Login_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000023A5 File Offset: 0x000005A5
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}
	}
}
