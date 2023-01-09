namespace Auth.GG_Winform_Example
{
	// Token: 0x02000011 RID: 17
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x06000087 RID: 135 RVA: 0x00006638 File Offset: 0x00004838
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			bool flag2 = flag;
			if (flag2)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00006674 File Offset: 0x00004874
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Auth.GG_Winform_Example.Login));
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.siticoneRoundedButton1 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.key = new global::System.Windows.Forms.TextBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label3 = new global::System.Windows.Forms.Label();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.label4 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BackColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(18, 17, 16);
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(491, 4);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox1.TabIndex = 1;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BackColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.FromArgb(18, 17, 16);
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(445, 4);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox2.TabIndex = 2;
			this.siticoneTransition1.AnimationType = global::Siticone.UI.AnimatorNS.AnimationType.Rotate;
			this.siticoneTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.siticoneTransition1.DefaultAnimation = animation;
			this.label1.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Light", 10f);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(-1, 136);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 19);
			this.label1.TabIndex = 22;
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneTransition1.SetDecoration(this.label2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10.2f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label2.ImageAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.label2.Location = new global::System.Drawing.Point(10, 11);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(80, 19);
			this.label2.TabIndex = 27;
			this.label2.Text = "ZeusLoader";
			this.siticoneRoundedButton1.BackColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneRoundedButton1.BorderColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneRoundedButton1.BorderThickness = 1;
			this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedButton1.FillColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneRoundedButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton1.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton1.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Location = new global::System.Drawing.Point(140, 144);
			this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
			this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Size = new global::System.Drawing.Size(255, 27);
			this.siticoneRoundedButton1.TabIndex = 26;
			this.siticoneRoundedButton1.Text = "Activate";
			this.siticoneRoundedButton1.Click += new global::System.EventHandler(this.siticoneRoundedButton1_Click);
			this.key.BackColor = global::System.Drawing.Color.FromArgb(41, 41, 41);
			this.key.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.siticoneTransition1.SetDecoration(this.key, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.key.Location = new global::System.Drawing.Point(123, 113);
			this.key.Name = "key";
			this.key.Size = new global::System.Drawing.Size(282, 13);
			this.key.TabIndex = 34;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneTransition1.SetDecoration(this.panel1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel1.Location = new global::System.Drawing.Point(1, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(545, 42);
			this.panel1.TabIndex = 35;
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.label3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label3.ForeColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.label3.Location = new global::System.Drawing.Point(86, 113);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(31, 13);
			this.label3.TabIndex = 36;
			this.label3.Text = "KEY:";
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.label4, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label4.Font = new global::System.Drawing.Font("Cascadia Code", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.label4.Location = new global::System.Drawing.Point(409, 218);
			this.label4.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(127, 15);
			this.label4.TabIndex = 58;
			this.label4.Text = "Made By SofMain#4238";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(18, 17, 16);
			base.ClientSize = new global::System.Drawing.Size(540, 233);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.key);
			base.Controls.Add(this.siticoneRoundedButton1);
			base.Controls.Add(this.label1);
			this.siticoneTransition1.SetDecoration(this, global::Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Login";
			base.Opacity = 0.85;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Auth.GG Winform";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.Load += new global::System.EventHandler(this.Login_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000053 RID: 83
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000054 RID: 84
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000055 RID: 85
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000056 RID: 86
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x04000057 RID: 87
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400005A RID: 90
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;

		// Token: 0x0400005B RID: 91
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.TextBox key;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.Label label4;
	}
}
