using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Auth.GG_Winform_Example
{
	// Token: 0x02000010 RID: 16
	public partial class Main : Form
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00002315 File Offset: 0x00000515
		public Main()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002323 File Offset: 0x00000523
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004B0C File Offset: 0x00002D0C
		private void Main_Load(object sender, EventArgs e)
		{
			this.userid.Text = "ID: Cracked by Bom";
			this.username.Text = "Username: Cracked by Bom";
			this.email.Text = "Email: Cracked by Bom";
			this.hwid.Text = "HWID: Cracked by Bom";
			this.uservariable.Text = "User Variable: Cracked by Bom";
			this.userrank.Text = "Rank: Cracked by Bom";
			this.ip.Text = "IP: Cracked by Bom";
			this.expiry.Text = "Expiry: Cracked by Bom";
			this.lastlogin.Text = "Last Login: Cracked by Bom";
			this.registerdate.Text = "Register Date: Cracked by Bom";
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000232B File Offset: 0x0000052B
		private void hwid_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000232B File Offset: 0x0000052B
		private void welcome_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004BBC File Offset: 0x00002DBC
		private void siticoneRoundedButton1_Click_1(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp)";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string path = Convert.ToBase64String(File.ReadAllBytes(openFileDialog.FileName));
				API.UploadPic(User.Username, path);
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000232B File Offset: 0x0000052B
		private void siticonePictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000232D File Offset: 0x0000052D
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
			this.panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000232B File Offset: 0x0000052B
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002344 File Offset: 0x00000544
		private void siticoneRoundedButton4_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/vexRA2b7En");
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002351 File Offset: 0x00000551
		private void siticoneRoundedButton3_Click(object sender, EventArgs e)
		{
			Process.Start("C:\\Users\\fq35q\\Desktop\\New folder\\Fortnite.exe");
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004C04 File Offset: 0x00002E04
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string fileName = "C:\\Windows\\System32\\ZeusDeepFNCleaner.bat";
			string fileName2 = "C:\\Windows\\System32\\applecleaner.exe";
			string fileName3 = "C:\\Windows\\System32\\Registry.bat";
			string fileName4 = "C:\\Windows\\System32\\Reset_ip.bat";
			string fileName5 = "C:\\Windows\\System32\\regedit_change.bat";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1016183185039695975/1054423734242521098/ZeusDeepFNCleaner.bat", fileName);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/971012799419519019/1009633506403561553/applecleaner.exe", fileName2);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1016183185039695975/1054426009950228611/Registry.bat", fileName3);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1016183185039695975/1054426010277396480/Reset_ip.bat", fileName4);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1016183185039695975/1054426010638098512/regedit_change.bat", fileName5);
			Process.Start("C:\\Windows\\System32\\ZeusDeepFNCleaner.bat");
			Process.Start("C:\\Windows\\System32\\applecleaner.exe");
			Process.Start("C:\\Windows\\System32\\Registry.bat");
			Process.Start("C:\\Windows\\System32\\Reset_ip.bat");
			Process.Start("C:\\Windows\\System32\\regedit_change.bat");
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004CA8 File Offset: 0x00002EA8
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string fileName = "C:\\Windows\\System32\\eacbespoof.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1016183185039695975/1054505220287246457/eacbespoof.exe", fileName);
			Process.Start("C:\\Windows\\System32\\eacbespoof.exe");
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004CD8 File Offset: 0x00002ED8
		private void siticoneRoundedButton5_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string fileName = "C:\\Windows\\System32\\Serials_Checker.bat";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1016183185039695975/1054424667009593415/Serials_Checker.bat", fileName);
			Process.Start("C:\\Windows\\System32\\Serials_Checker.bat");
		}
	}
}
