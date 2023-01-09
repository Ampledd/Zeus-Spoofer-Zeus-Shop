namespace Auth.GG_Winform_Example
{
	// Token: 0x02000010 RID: 16
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000080 RID: 128 RVA: 0x0000235E File Offset: 0x0000055E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004D08 File Offset: 0x00002F08
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Auth.GG_Winform_Example.Main));
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.userid = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.username = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.email = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.hwid = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.uservariable = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.userrank = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.ip = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.expiry = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.lastlogin = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.registerdate = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneRoundedButton1 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton2 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton3 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton4 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton5 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.openFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
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
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(623, 4);
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
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(578, 4);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox2.TabIndex = 2;
			this.siticoneTransition1.AnimationType = global::Siticone.UI.AnimatorNS.AnimationType.Rotate;
			this.siticoneTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation2.SlideCoeff");
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
			this.label2.Location = new global::System.Drawing.Point(10, 11);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(80, 19);
			this.label2.TabIndex = 27;
			this.label2.Text = "ZeusGay - Cracked by Bom";
			this.userid.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.userid, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.userid.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.userid.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.userid.Location = new global::System.Drawing.Point(11, 303);
			this.userid.Margin = new global::System.Windows.Forms.Padding(2);
			this.userid.Name = "userid";
			this.userid.Size = new global::System.Drawing.Size(69, 14);
			this.userid.TabIndex = 37;
			this.userid.Text = "siticoneLabel1";
			this.username.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.username, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.username.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.username.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.username.Location = new global::System.Drawing.Point(101, 443);
			this.username.Margin = new global::System.Windows.Forms.Padding(2);
			this.username.Name = "username";
			this.username.Size = new global::System.Drawing.Size(69, 14);
			this.username.TabIndex = 38;
			this.username.Text = "siticoneLabel2";
			this.username.Visible = false;
			this.email.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.email, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.email.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.email.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.email.Location = new global::System.Drawing.Point(101, 464);
			this.email.Margin = new global::System.Windows.Forms.Padding(2);
			this.email.Name = "email";
			this.email.Size = new global::System.Drawing.Size(69, 14);
			this.email.TabIndex = 39;
			this.email.Text = "siticoneLabel3";
			this.email.Visible = false;
			this.hwid.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.hwid, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.hwid.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.hwid.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.hwid.Location = new global::System.Drawing.Point(11, 321);
			this.hwid.Margin = new global::System.Windows.Forms.Padding(2);
			this.hwid.Name = "hwid";
			this.hwid.Size = new global::System.Drawing.Size(69, 14);
			this.hwid.TabIndex = 40;
			this.hwid.Text = "siticoneLabel4";
			this.hwid.Click += new global::System.EventHandler(this.hwid_Click);
			this.uservariable.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.uservariable, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.uservariable.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.uservariable.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.uservariable.Location = new global::System.Drawing.Point(11, 341);
			this.uservariable.Margin = new global::System.Windows.Forms.Padding(2);
			this.uservariable.Name = "uservariable";
			this.uservariable.Size = new global::System.Drawing.Size(69, 14);
			this.uservariable.TabIndex = 41;
			this.uservariable.Text = "siticoneLabel4";
			this.userrank.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.userrank, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.userrank.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.userrank.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.userrank.Location = new global::System.Drawing.Point(11, 362);
			this.userrank.Margin = new global::System.Windows.Forms.Padding(2);
			this.userrank.Name = "userrank";
			this.userrank.Size = new global::System.Drawing.Size(69, 14);
			this.userrank.TabIndex = 42;
			this.userrank.Text = "siticoneLabel4";
			this.ip.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.ip, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.ip.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ip.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.ip.Location = new global::System.Drawing.Point(92, 482);
			this.ip.Margin = new global::System.Windows.Forms.Padding(2);
			this.ip.Name = "ip";
			this.ip.Size = new global::System.Drawing.Size(69, 14);
			this.ip.TabIndex = 43;
			this.ip.Text = "siticoneLabel4";
			this.ip.Visible = false;
			this.expiry.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.expiry, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.expiry.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.expiry.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.expiry.Location = new global::System.Drawing.Point(11, 380);
			this.expiry.Margin = new global::System.Windows.Forms.Padding(2);
			this.expiry.Name = "expiry";
			this.expiry.Size = new global::System.Drawing.Size(69, 14);
			this.expiry.TabIndex = 44;
			this.expiry.Text = "siticoneLabel4";
			this.lastlogin.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.lastlogin, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.lastlogin.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lastlogin.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.lastlogin.Location = new global::System.Drawing.Point(11, 401);
			this.lastlogin.Margin = new global::System.Windows.Forms.Padding(2);
			this.lastlogin.Name = "lastlogin";
			this.lastlogin.Size = new global::System.Drawing.Size(69, 14);
			this.lastlogin.TabIndex = 45;
			this.lastlogin.Text = "siticoneLabel4";
			this.registerdate.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.registerdate, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.registerdate.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.registerdate.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.registerdate.Location = new global::System.Drawing.Point(11, 421);
			this.registerdate.Margin = new global::System.Windows.Forms.Padding(2);
			this.registerdate.Name = "registerdate";
			this.registerdate.Size = new global::System.Drawing.Size(69, 14);
			this.registerdate.TabIndex = 46;
			this.registerdate.Text = "siticoneLabel4";
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneTransition1.SetDecoration(this.panel1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(829, 48);
			this.panel1.TabIndex = 53;
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
			this.siticoneRoundedButton1.Location = new global::System.Drawing.Point(222, 141);
			this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
			this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Size = new global::System.Drawing.Size(255, 27);
			this.siticoneRoundedButton1.TabIndex = 54;
			this.siticoneRoundedButton1.Text = "Clean";
			this.siticoneRoundedButton1.Click += new global::System.EventHandler(this.siticoneRoundedButton1_Click);
			this.siticoneRoundedButton2.BackColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneRoundedButton2.BorderColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneRoundedButton2.BorderThickness = 1;
			this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedButton2.FillColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneRoundedButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton2.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton2.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton2.HoveredState.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.Location = new global::System.Drawing.Point(222, 174);
			this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
			this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.Size = new global::System.Drawing.Size(255, 27);
			this.siticoneRoundedButton2.TabIndex = 55;
			this.siticoneRoundedButton2.Text = "Spoof";
			this.siticoneRoundedButton2.Click += new global::System.EventHandler(this.siticoneRoundedButton2_Click);
			this.siticoneRoundedButton3.BackColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneRoundedButton3.BorderColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneRoundedButton3.BorderThickness = 1;
			this.siticoneRoundedButton3.CheckedState.Parent = this.siticoneRoundedButton3;
			this.siticoneRoundedButton3.CustomImages.Parent = this.siticoneRoundedButton3;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedButton3.FillColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneRoundedButton3.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton3.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton3.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton3.HoveredState.Parent = this.siticoneRoundedButton3;
			this.siticoneRoundedButton3.Location = new global::System.Drawing.Point(222, 240);
			this.siticoneRoundedButton3.Name = "siticoneRoundedButton3";
			this.siticoneRoundedButton3.ShadowDecoration.Parent = this.siticoneRoundedButton3;
			this.siticoneRoundedButton3.Size = new global::System.Drawing.Size(255, 27);
			this.siticoneRoundedButton3.TabIndex = 56;
			this.siticoneRoundedButton3.Text = "Inject Cheat";
			this.siticoneRoundedButton3.Click += new global::System.EventHandler(this.siticoneRoundedButton3_Click);
			this.siticoneRoundedButton4.BackColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneRoundedButton4.BorderColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneRoundedButton4.BorderThickness = 1;
			this.siticoneRoundedButton4.CheckedState.Parent = this.siticoneRoundedButton4;
			this.siticoneRoundedButton4.CustomImages.Parent = this.siticoneRoundedButton4;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton4, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedButton4.FillColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneRoundedButton4.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton4.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton4.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton4.HoveredState.Parent = this.siticoneRoundedButton4;
			this.siticoneRoundedButton4.Location = new global::System.Drawing.Point(222, 273);
			this.siticoneRoundedButton4.Name = "siticoneRoundedButton4";
			this.siticoneRoundedButton4.ShadowDecoration.Parent = this.siticoneRoundedButton4;
			this.siticoneRoundedButton4.Size = new global::System.Drawing.Size(255, 27);
			this.siticoneRoundedButton4.TabIndex = 58;
			this.siticoneRoundedButton4.Text = "Official Discord Server";
			this.siticoneRoundedButton4.Click += new global::System.EventHandler(this.siticoneRoundedButton4_Click);
			this.siticoneRoundedButton5.BackColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneRoundedButton5.BorderColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneRoundedButton5.BorderThickness = 1;
			this.siticoneRoundedButton5.CheckedState.Parent = this.siticoneRoundedButton5;
			this.siticoneRoundedButton5.CustomImages.Parent = this.siticoneRoundedButton5;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton5, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedButton5.FillColor = global::System.Drawing.Color.FromArgb(61, 12, 15);
			this.siticoneRoundedButton5.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton5.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton5.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton5.HoveredState.Parent = this.siticoneRoundedButton5;
			this.siticoneRoundedButton5.Location = new global::System.Drawing.Point(222, 207);
			this.siticoneRoundedButton5.Name = "siticoneRoundedButton5";
			this.siticoneRoundedButton5.ShadowDecoration.Parent = this.siticoneRoundedButton5;
			this.siticoneRoundedButton5.Size = new global::System.Drawing.Size(255, 27);
			this.siticoneRoundedButton5.TabIndex = 59;
			this.siticoneRoundedButton5.Text = "HWID Checker";
			this.siticoneRoundedButton5.Click += new global::System.EventHandler(this.siticoneRoundedButton5_Click);
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.label4, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label4.Font = new global::System.Drawing.Font("Candara", 20.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.DodgerBlue;
			this.label4.Location = new global::System.Drawing.Point(270, 51);
			this.label4.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(161, 33);
			this.label4.TabIndex = 60;
			this.label4.Text = "Fortnite TAB";
			this.label5.AutoSize = true;
			this.label5.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.label5, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label5.Font = new global::System.Drawing.Font("Corbel", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.DimGray;
			this.label5.Location = new global::System.Drawing.Point(572, 424);
			this.label5.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(100, 13);
			this.label5.TabIndex = 61;
			this.label5.Text = "More games soon...";
			this.openFileDialog1.FileName = "openFileDialog1";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(18, 17, 16);
			base.ClientSize = new global::System.Drawing.Size(672, 440);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.siticoneRoundedButton5);
			base.Controls.Add(this.siticoneRoundedButton4);
			base.Controls.Add(this.siticoneRoundedButton3);
			base.Controls.Add(this.siticoneRoundedButton2);
			base.Controls.Add(this.siticoneRoundedButton1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.registerdate);
			base.Controls.Add(this.lastlogin);
			base.Controls.Add(this.expiry);
			base.Controls.Add(this.ip);
			base.Controls.Add(this.userrank);
			base.Controls.Add(this.uservariable);
			base.Controls.Add(this.hwid);
			base.Controls.Add(this.email);
			base.Controls.Add(this.username);
			base.Controls.Add(this.userid);
			base.Controls.Add(this.label1);
			this.siticoneTransition1.SetDecoration(this, global::Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Main";
			base.Opacity = 0.85;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Auth.GG WInform";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.Load += new global::System.EventHandler(this.Main_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000038 RID: 56
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000039 RID: 57
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x0400003A RID: 58
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x0400003B RID: 59
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x0400003C RID: 60
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400003F RID: 63
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x04000040 RID: 64
		private global::Siticone.UI.WinForms.SiticoneLabel hwid;

		// Token: 0x04000041 RID: 65
		private global::Siticone.UI.WinForms.SiticoneLabel email;

		// Token: 0x04000042 RID: 66
		private global::Siticone.UI.WinForms.SiticoneLabel username;

		// Token: 0x04000043 RID: 67
		private global::Siticone.UI.WinForms.SiticoneLabel userid;

		// Token: 0x04000044 RID: 68
		private global::Siticone.UI.WinForms.SiticoneLabel registerdate;

		// Token: 0x04000045 RID: 69
		private global::Siticone.UI.WinForms.SiticoneLabel lastlogin;

		// Token: 0x04000046 RID: 70
		private global::Siticone.UI.WinForms.SiticoneLabel expiry;

		// Token: 0x04000047 RID: 71
		private global::Siticone.UI.WinForms.SiticoneLabel ip;

		// Token: 0x04000048 RID: 72
		private global::Siticone.UI.WinForms.SiticoneLabel userrank;

		// Token: 0x04000049 RID: 73
		private global::Siticone.UI.WinForms.SiticoneLabel uservariable;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400004C RID: 76
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;

		// Token: 0x0400004D RID: 77
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton3;

		// Token: 0x0400004E RID: 78
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;

		// Token: 0x0400004F RID: 79
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton4;

		// Token: 0x04000050 RID: 80
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton5;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Label label4;
	}
}
