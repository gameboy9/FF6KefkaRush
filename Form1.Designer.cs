
namespace FF6KefkaRush
{
	partial class FF4FabulGauntlet
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Randomize = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.FF6PRFolder = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.RandoFlags = new System.Windows.Forms.TextBox();
			this.NewChecksum = new System.Windows.Forms.Label();
			this.RandoSeed = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.NewSeed = new System.Windows.Forms.Button();
			this.BrowseForFolder = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.settingGeneral = new System.Windows.Forms.TabPage();
			this.magiciteRoundDown = new System.Windows.Forms.CheckBox();
			this.magiciteMultiplier = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.magicPointMulti = new System.Windows.Forms.ComboBox();
			this.xpMultiplier = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.settingHero = new System.Windows.Forms.TabPage();
			this.exBiggs = new System.Windows.Forms.CheckBox();
			this.exWedge = new System.Windows.Forms.CheckBox();
			this.exGau = new System.Windows.Forms.CheckBox();
			this.exMog = new System.Windows.Forms.CheckBox();
			this.exSabin = new System.Windows.Forms.CheckBox();
			this.exRelm = new System.Windows.Forms.CheckBox();
			this.firstHero = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.exEdgar = new System.Windows.Forms.CheckBox();
			this.exLeo = new System.Windows.Forms.CheckBox();
			this.exStrago = new System.Windows.Forms.CheckBox();
			this.exUmaro = new System.Windows.Forms.CheckBox();
			this.exSetzer = new System.Windows.Forms.CheckBox();
			this.exShadow = new System.Windows.Forms.CheckBox();
			this.exLocke = new System.Windows.Forms.CheckBox();
			this.exCyan = new System.Windows.Forms.CheckBox();
			this.exCeles = new System.Windows.Forms.CheckBox();
			this.exBanon = new System.Windows.Forms.CheckBox();
			this.exGogo = new System.Windows.Forms.CheckBox();
			this.exTerra = new System.Windows.Forms.CheckBox();
			this.numHeroes = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dupCharactersAllowed = new System.Windows.Forms.CheckBox();
			this.hpAdjustTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.btnDefaultFlags = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.settingGeneral.SuspendLayout();
			this.settingHero.SuspendLayout();
			this.SuspendLayout();
			// 
			// Randomize
			// 
			this.Randomize.Location = new System.Drawing.Point(668, 418);
			this.Randomize.Name = "Randomize";
			this.Randomize.Size = new System.Drawing.Size(120, 29);
			this.Randomize.TabIndex = 0;
			this.Randomize.Text = "Randomize!";
			this.Randomize.UseVisualStyleBackColor = true;
			this.Randomize.Click += new System.EventHandler(this.Randomize_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "FF6 PR Folder";
			// 
			// FF6PRFolder
			// 
			this.FF6PRFolder.Location = new System.Drawing.Point(138, 6);
			this.FF6PRFolder.Name = "FF6PRFolder";
			this.FF6PRFolder.Size = new System.Drawing.Size(502, 27);
			this.FF6PRFolder.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Rando Flags";
			// 
			// RandoFlags
			// 
			this.RandoFlags.Location = new System.Drawing.Point(138, 47);
			this.RandoFlags.Name = "RandoFlags";
			this.RandoFlags.Size = new System.Drawing.Size(346, 27);
			this.RandoFlags.TabIndex = 7;
			this.RandoFlags.Leave += new System.EventHandler(this.determineChecks);
			// 
			// NewChecksum
			// 
			this.NewChecksum.AutoSize = true;
			this.NewChecksum.Location = new System.Drawing.Point(12, 465);
			this.NewChecksum.Name = "NewChecksum";
			this.NewChecksum.Size = new System.Drawing.Size(267, 20);
			this.NewChecksum.TabIndex = 8;
			this.NewChecksum.Text = "New Checksum:  (Not Randomized Yet)";
			// 
			// RandoSeed
			// 
			this.RandoSeed.Location = new System.Drawing.Point(554, 44);
			this.RandoSeed.Name = "RandoSeed";
			this.RandoSeed.Size = new System.Drawing.Size(160, 27);
			this.RandoSeed.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(506, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Seed";
			// 
			// NewSeed
			// 
			this.NewSeed.Location = new System.Drawing.Point(729, 43);
			this.NewSeed.Name = "NewSeed";
			this.NewSeed.Size = new System.Drawing.Size(59, 29);
			this.NewSeed.TabIndex = 11;
			this.NewSeed.Text = "New";
			this.NewSeed.UseVisualStyleBackColor = true;
			this.NewSeed.Click += new System.EventHandler(this.NewSeed_Click);
			// 
			// BrowseForFolder
			// 
			this.BrowseForFolder.Location = new System.Drawing.Point(693, 6);
			this.BrowseForFolder.Name = "BrowseForFolder";
			this.BrowseForFolder.Size = new System.Drawing.Size(95, 28);
			this.BrowseForFolder.TabIndex = 14;
			this.BrowseForFolder.Text = "Browse";
			this.BrowseForFolder.UseVisualStyleBackColor = true;
			this.BrowseForFolder.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(478, 418);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(140, 29);
			this.button1.TabIndex = 42;
			this.button1.Text = "Revert to vanilla";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.revertToDefault_click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.settingGeneral);
			this.tabControl1.Controls.Add(this.settingHero);
			this.tabControl1.Location = new System.Drawing.Point(12, 92);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(776, 320);
			this.tabControl1.TabIndex = 50;
			// 
			// settingGeneral
			// 
			this.settingGeneral.Controls.Add(this.magiciteRoundDown);
			this.settingGeneral.Controls.Add(this.magiciteMultiplier);
			this.settingGeneral.Controls.Add(this.label4);
			this.settingGeneral.Controls.Add(this.magicPointMulti);
			this.settingGeneral.Controls.Add(this.xpMultiplier);
			this.settingGeneral.Controls.Add(this.label11);
			this.settingGeneral.Controls.Add(this.label8);
			this.settingGeneral.Location = new System.Drawing.Point(4, 29);
			this.settingGeneral.Name = "settingGeneral";
			this.settingGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.settingGeneral.Size = new System.Drawing.Size(768, 287);
			this.settingGeneral.TabIndex = 0;
			this.settingGeneral.Text = "General";
			this.settingGeneral.UseVisualStyleBackColor = true;
			// 
			// magiciteRoundDown
			// 
			this.magiciteRoundDown.AutoSize = true;
			this.magiciteRoundDown.Location = new System.Drawing.Point(367, 79);
			this.magiciteRoundDown.Name = "magiciteRoundDown";
			this.magiciteRoundDown.Size = new System.Drawing.Size(117, 24);
			this.magiciteRoundDown.TabIndex = 70;
			this.magiciteRoundDown.Text = "Round Down";
			this.magiciteRoundDown.UseVisualStyleBackColor = true;
			this.magiciteRoundDown.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// magiciteMultiplier
			// 
			this.magiciteMultiplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.magiciteMultiplier.FormattingEnabled = true;
			this.magiciteMultiplier.Items.AddRange(new object[] {
            "1.0x",
            "1.5x",
            "2.0x",
            "2.5x",
            "3.0x",
            "4.0x",
            "5.0x",
            "10.0x"});
			this.magiciteMultiplier.Location = new System.Drawing.Point(196, 77);
			this.magiciteMultiplier.Name = "magiciteMultiplier";
			this.magiciteMultiplier.Size = new System.Drawing.Size(148, 28);
			this.magiciteMultiplier.TabIndex = 69;
			this.magiciteMultiplier.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 79);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(179, 20);
			this.label4.TabIndex = 68;
			this.label4.Text = "Magicite Bonus Multiplier";
			// 
			// magicPointMulti
			// 
			this.magicPointMulti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.magicPointMulti.FormattingEnabled = true;
			this.magicPointMulti.Items.AddRange(new object[] {
            "1.0x",
            "1.5x",
            "2.0x",
            "2.5x",
            "3.0x",
            "4.0x",
            "5.0x",
            "10.0x"});
			this.magicPointMulti.Location = new System.Drawing.Point(196, 44);
			this.magicPointMulti.Name = "magicPointMulti";
			this.magicPointMulti.Size = new System.Drawing.Size(148, 28);
			this.magicPointMulti.TabIndex = 67;
			this.magicPointMulti.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// xpMultiplier
			// 
			this.xpMultiplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.xpMultiplier.FormattingEnabled = true;
			this.xpMultiplier.Items.AddRange(new object[] {
            "1x",
            "2x",
            "5x",
            "8x",
            "10x",
            "15x",
            "20x",
            "25x",
            "30x",
            "40x",
            "50x",
            "75x",
            "100x",
            "200x",
            "300x",
            "500x"});
			this.xpMultiplier.Location = new System.Drawing.Point(196, 11);
			this.xpMultiplier.Name = "xpMultiplier";
			this.xpMultiplier.Size = new System.Drawing.Size(148, 28);
			this.xpMultiplier.TabIndex = 65;
			this.xpMultiplier.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 46);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(135, 20);
			this.label11.TabIndex = 64;
			this.label11.Text = "Magic Pt Multiplier";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 14);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 20);
			this.label8.TabIndex = 61;
			this.label8.Text = "XP Multiplier";
			// 
			// settingHero
			// 
			this.settingHero.Controls.Add(this.exBiggs);
			this.settingHero.Controls.Add(this.exWedge);
			this.settingHero.Controls.Add(this.exGau);
			this.settingHero.Controls.Add(this.exMog);
			this.settingHero.Controls.Add(this.exSabin);
			this.settingHero.Controls.Add(this.exRelm);
			this.settingHero.Controls.Add(this.firstHero);
			this.settingHero.Controls.Add(this.label16);
			this.settingHero.Controls.Add(this.exEdgar);
			this.settingHero.Controls.Add(this.exLeo);
			this.settingHero.Controls.Add(this.exStrago);
			this.settingHero.Controls.Add(this.exUmaro);
			this.settingHero.Controls.Add(this.exSetzer);
			this.settingHero.Controls.Add(this.exShadow);
			this.settingHero.Controls.Add(this.exLocke);
			this.settingHero.Controls.Add(this.exCyan);
			this.settingHero.Controls.Add(this.exCeles);
			this.settingHero.Controls.Add(this.exBanon);
			this.settingHero.Controls.Add(this.exGogo);
			this.settingHero.Controls.Add(this.exTerra);
			this.settingHero.Controls.Add(this.numHeroes);
			this.settingHero.Controls.Add(this.label6);
			this.settingHero.Controls.Add(this.dupCharactersAllowed);
			this.settingHero.Location = new System.Drawing.Point(4, 29);
			this.settingHero.Name = "settingHero";
			this.settingHero.Padding = new System.Windows.Forms.Padding(3);
			this.settingHero.Size = new System.Drawing.Size(768, 287);
			this.settingHero.TabIndex = 1;
			this.settingHero.Text = "Heroes";
			this.settingHero.UseVisualStyleBackColor = true;
			// 
			// exBiggs
			// 
			this.exBiggs.AutoSize = true;
			this.exBiggs.Location = new System.Drawing.Point(412, 243);
			this.exBiggs.Name = "exBiggs";
			this.exBiggs.Size = new System.Drawing.Size(123, 24);
			this.exBiggs.TabIndex = 78;
			this.exBiggs.Text = "Exclude Biggs";
			this.exBiggs.UseVisualStyleBackColor = true;
			this.exBiggs.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exWedge
			// 
			this.exWedge.AutoSize = true;
			this.exWedge.Location = new System.Drawing.Point(412, 213);
			this.exWedge.Name = "exWedge";
			this.exWedge.Size = new System.Drawing.Size(133, 24);
			this.exWedge.TabIndex = 77;
			this.exWedge.Text = "Exclude Wedge";
			this.exWedge.UseVisualStyleBackColor = true;
			this.exWedge.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exGau
			// 
			this.exGau.AutoSize = true;
			this.exGau.Location = new System.Drawing.Point(201, 243);
			this.exGau.Name = "exGau";
			this.exGau.Size = new System.Drawing.Size(112, 24);
			this.exGau.TabIndex = 76;
			this.exGau.Text = "Exclude Gau";
			this.exGau.UseVisualStyleBackColor = true;
			this.exGau.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exMog
			// 
			this.exMog.AutoSize = true;
			this.exMog.Location = new System.Drawing.Point(201, 213);
			this.exMog.Name = "exMog";
			this.exMog.Size = new System.Drawing.Size(117, 24);
			this.exMog.TabIndex = 75;
			this.exMog.Text = "Exclude Mog";
			this.exMog.UseVisualStyleBackColor = true;
			this.exMog.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exSabin
			// 
			this.exSabin.AutoSize = true;
			this.exSabin.Location = new System.Drawing.Point(6, 243);
			this.exSabin.Name = "exSabin";
			this.exSabin.Size = new System.Drawing.Size(123, 24);
			this.exSabin.TabIndex = 74;
			this.exSabin.Text = "Exclude Sabin";
			this.exSabin.UseVisualStyleBackColor = true;
			this.exSabin.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exRelm
			// 
			this.exRelm.AutoSize = true;
			this.exRelm.Location = new System.Drawing.Point(201, 153);
			this.exRelm.Name = "exRelm";
			this.exRelm.Size = new System.Drawing.Size(120, 24);
			this.exRelm.TabIndex = 73;
			this.exRelm.Text = "Exclude Relm";
			this.exRelm.UseVisualStyleBackColor = true;
			this.exRelm.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// firstHero
			// 
			this.firstHero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.firstHero.FormattingEnabled = true;
			this.firstHero.Items.AddRange(new object[] {
            "No Pref.",
            "Cecil",
            "Kain",
            "Tellah",
            "Rydia",
            "Edward",
            "Rosa",
            "Palom",
            "Porom",
            "Cid",
            "Edge",
            "Fusoya"});
			this.firstHero.Location = new System.Drawing.Point(412, 13);
			this.firstHero.Name = "firstHero";
			this.firstHero.Size = new System.Drawing.Size(148, 28);
			this.firstHero.TabIndex = 72;
			this.firstHero.Visible = false;
			this.firstHero.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(310, 16);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(73, 20);
			this.label16.TabIndex = 71;
			this.label16.Text = "First Hero";
			this.label16.Visible = false;
			// 
			// exEdgar
			// 
			this.exEdgar.AutoSize = true;
			this.exEdgar.Location = new System.Drawing.Point(6, 213);
			this.exEdgar.Name = "exEdgar";
			this.exEdgar.Size = new System.Drawing.Size(125, 24);
			this.exEdgar.TabIndex = 69;
			this.exEdgar.Text = "Exclude Edgar";
			this.exEdgar.UseVisualStyleBackColor = true;
			this.exEdgar.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exLeo
			// 
			this.exLeo.AutoSize = true;
			this.exLeo.Location = new System.Drawing.Point(412, 183);
			this.exLeo.Name = "exLeo";
			this.exLeo.Size = new System.Drawing.Size(110, 24);
			this.exLeo.TabIndex = 68;
			this.exLeo.Text = "Exclude Leo";
			this.exLeo.UseVisualStyleBackColor = true;
			this.exLeo.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exStrago
			// 
			this.exStrago.AutoSize = true;
			this.exStrago.Location = new System.Drawing.Point(201, 123);
			this.exStrago.Name = "exStrago";
			this.exStrago.Size = new System.Drawing.Size(130, 24);
			this.exStrago.TabIndex = 67;
			this.exStrago.Text = "Exclude Strago";
			this.exStrago.UseVisualStyleBackColor = true;
			this.exStrago.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exUmaro
			// 
			this.exUmaro.AutoSize = true;
			this.exUmaro.Location = new System.Drawing.Point(412, 123);
			this.exUmaro.Name = "exUmaro";
			this.exUmaro.Size = new System.Drawing.Size(131, 24);
			this.exUmaro.TabIndex = 66;
			this.exUmaro.Text = "Exclude Umaro";
			this.exUmaro.UseVisualStyleBackColor = true;
			this.exUmaro.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exSetzer
			// 
			this.exSetzer.AutoSize = true;
			this.exSetzer.Location = new System.Drawing.Point(201, 183);
			this.exSetzer.Name = "exSetzer";
			this.exSetzer.Size = new System.Drawing.Size(127, 24);
			this.exSetzer.TabIndex = 65;
			this.exSetzer.Text = "Exclude Setzer";
			this.exSetzer.UseVisualStyleBackColor = true;
			this.exSetzer.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exShadow
			// 
			this.exShadow.AutoSize = true;
			this.exShadow.Location = new System.Drawing.Point(6, 183);
			this.exShadow.Name = "exShadow";
			this.exShadow.Size = new System.Drawing.Size(139, 24);
			this.exShadow.TabIndex = 64;
			this.exShadow.Text = "Exclude Shadow";
			this.exShadow.UseVisualStyleBackColor = true;
			this.exShadow.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exLocke
			// 
			this.exLocke.AutoSize = true;
			this.exLocke.Location = new System.Drawing.Point(6, 123);
			this.exLocke.Name = "exLocke";
			this.exLocke.Size = new System.Drawing.Size(124, 24);
			this.exLocke.TabIndex = 63;
			this.exLocke.Text = "Exclude Locke";
			this.exLocke.UseVisualStyleBackColor = true;
			this.exLocke.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exCyan
			// 
			this.exCyan.AutoSize = true;
			this.exCyan.Location = new System.Drawing.Point(6, 153);
			this.exCyan.Name = "exCyan";
			this.exCyan.Size = new System.Drawing.Size(118, 24);
			this.exCyan.TabIndex = 62;
			this.exCyan.Text = "Exclude Cyan";
			this.exCyan.UseVisualStyleBackColor = true;
			this.exCyan.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exCeles
			// 
			this.exCeles.AutoSize = true;
			this.exCeles.Location = new System.Drawing.Point(201, 93);
			this.exCeles.Name = "exCeles";
			this.exCeles.Size = new System.Drawing.Size(121, 24);
			this.exCeles.TabIndex = 61;
			this.exCeles.Text = "Exclude Celes";
			this.exCeles.UseVisualStyleBackColor = true;
			this.exCeles.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exBanon
			// 
			this.exBanon.AutoSize = true;
			this.exBanon.Location = new System.Drawing.Point(412, 153);
			this.exBanon.Name = "exBanon";
			this.exBanon.Size = new System.Drawing.Size(128, 24);
			this.exBanon.TabIndex = 60;
			this.exBanon.Text = "Exclude Banon";
			this.exBanon.UseVisualStyleBackColor = true;
			this.exBanon.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exGogo
			// 
			this.exGogo.AutoSize = true;
			this.exGogo.Location = new System.Drawing.Point(412, 93);
			this.exGogo.Name = "exGogo";
			this.exGogo.Size = new System.Drawing.Size(123, 24);
			this.exGogo.TabIndex = 59;
			this.exGogo.Text = "Exclude Gogo";
			this.exGogo.UseVisualStyleBackColor = true;
			this.exGogo.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exTerra
			// 
			this.exTerra.AutoSize = true;
			this.exTerra.Location = new System.Drawing.Point(6, 93);
			this.exTerra.Name = "exTerra";
			this.exTerra.Size = new System.Drawing.Size(119, 24);
			this.exTerra.TabIndex = 58;
			this.exTerra.Text = "Exclude Terra";
			this.exTerra.UseVisualStyleBackColor = true;
			this.exTerra.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// numHeroes
			// 
			this.numHeroes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.numHeroes.FormattingEnabled = true;
			this.numHeroes.Items.AddRange(new object[] {
            "4",
            "3",
            "2",
            "1"});
			this.numHeroes.Location = new System.Drawing.Point(122, 13);
			this.numHeroes.Name = "numHeroes";
			this.numHeroes.Size = new System.Drawing.Size(148, 28);
			this.numHeroes.TabIndex = 57;
			this.numHeroes.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 20);
			this.label6.TabIndex = 56;
			this.label6.Text = "# of Heroes";
			// 
			// dupCharactersAllowed
			// 
			this.dupCharactersAllowed.AutoSize = true;
			this.dupCharactersAllowed.Location = new System.Drawing.Point(6, 48);
			this.dupCharactersAllowed.Name = "dupCharactersAllowed";
			this.dupCharactersAllowed.Size = new System.Drawing.Size(223, 24);
			this.dupCharactersAllowed.TabIndex = 49;
			this.dupCharactersAllowed.Text = "Duplicate characters allowed";
			this.dupCharactersAllowed.UseVisualStyleBackColor = true;
			this.dupCharactersAllowed.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// btnDefaultFlags
			// 
			this.btnDefaultFlags.Location = new System.Drawing.Point(282, 418);
			this.btnDefaultFlags.Name = "btnDefaultFlags";
			this.btnDefaultFlags.Size = new System.Drawing.Size(140, 29);
			this.btnDefaultFlags.TabIndex = 51;
			this.btnDefaultFlags.Text = "Default Flags";
			this.btnDefaultFlags.UseVisualStyleBackColor = true;
			this.btnDefaultFlags.Click += new System.EventHandler(this.btnDefaultFlags_Click);
			// 
			// FF4FabulGauntlet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 500);
			this.Controls.Add(this.btnDefaultFlags);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.BrowseForFolder);
			this.Controls.Add(this.NewSeed);
			this.Controls.Add(this.RandoSeed);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.NewChecksum);
			this.Controls.Add(this.RandoFlags);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.FF6PRFolder);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Randomize);
			this.Name = "FF4FabulGauntlet";
			this.Text = "Final Fantasy 6 Kefka Rush";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FF4FabulGauntlet_FormClosing);
			this.Load += new System.EventHandler(this.FF4FabulGauntlet_Load);
			this.tabControl1.ResumeLayout(false);
			this.settingGeneral.ResumeLayout(false);
			this.settingGeneral.PerformLayout();
			this.settingHero.ResumeLayout(false);
			this.settingHero.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Randomize;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox FF6PRFolder;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox RandoFlags;
		private System.Windows.Forms.Label NewChecksum;
		private System.Windows.Forms.TextBox RandoSeed;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button NewSeed;
		private System.Windows.Forms.Button BrowseForFolder;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage settingGeneral;
        private System.Windows.Forms.TabPage settingHero;
        private System.Windows.Forms.CheckBox dupCharactersAllowed;
        private System.Windows.Forms.CheckBox exEdgar;
        private System.Windows.Forms.CheckBox exLeo;
        private System.Windows.Forms.CheckBox exStrago;
        private System.Windows.Forms.CheckBox exUmaro;
        private System.Windows.Forms.CheckBox exSetzer;
        private System.Windows.Forms.CheckBox exShadow;
        private System.Windows.Forms.CheckBox exLocke;
        private System.Windows.Forms.CheckBox exCyan;
        private System.Windows.Forms.CheckBox exCeles;
        private System.Windows.Forms.CheckBox exBanon;
        private System.Windows.Forms.CheckBox exGogo;
        private System.Windows.Forms.CheckBox exTerra;
        private System.Windows.Forms.ComboBox numHeroes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox firstHero;
        private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ToolTip hpAdjustTooltip;
        private System.Windows.Forms.CheckBox exRelm;
		private System.Windows.Forms.ComboBox magicPointMulti;
		private System.Windows.Forms.ComboBox xpMultiplier;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox exBiggs;
		private System.Windows.Forms.CheckBox exWedge;
		private System.Windows.Forms.CheckBox exGau;
		private System.Windows.Forms.CheckBox exMog;
		private System.Windows.Forms.CheckBox exSabin;
		private System.Windows.Forms.CheckBox magiciteRoundDown;
		private System.Windows.Forms.ComboBox magiciteMultiplier;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnDefaultFlags;
	}
}

