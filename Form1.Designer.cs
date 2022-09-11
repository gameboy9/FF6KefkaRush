
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
			this.label17 = new System.Windows.Forms.Label();
			this.encounterRate = new System.Windows.Forms.ComboBox();
			this.magicPointMulti = new System.Windows.Forms.ComboBox();
			this.xpMultiplier = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.monsterAreaAppropriate = new System.Windows.Forms.CheckBox();
			this.treasureTypes = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.settingHero = new System.Windows.Forms.TabPage();
			this.exYang = new System.Windows.Forms.CheckBox();
			this.firstHero = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.exPaladinCecil = new System.Windows.Forms.CheckBox();
			this.exFusoya = new System.Windows.Forms.CheckBox();
			this.exRosa = new System.Windows.Forms.CheckBox();
			this.exPorom = new System.Windows.Forms.CheckBox();
			this.exCid = new System.Windows.Forms.CheckBox();
			this.exRydia = new System.Windows.Forms.CheckBox();
			this.exKain = new System.Windows.Forms.CheckBox();
			this.exTellah = new System.Windows.Forms.CheckBox();
			this.exEdward = new System.Windows.Forms.CheckBox();
			this.exEdge = new System.Windows.Forms.CheckBox();
			this.exPalom = new System.Windows.Forms.CheckBox();
			this.exCecil = new System.Windows.Forms.CheckBox();
			this.numHeroes = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dupCharactersAllowed = new System.Windows.Forms.CheckBox();
			this.hpAdjustTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.tabControl1.SuspendLayout();
			this.settingGeneral.SuspendLayout();
			this.settingHero.SuspendLayout();
			this.SuspendLayout();
			// 
			// Randomize
			// 
			this.Randomize.Location = new System.Drawing.Point(668, 488);
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
			this.NewChecksum.Location = new System.Drawing.Point(12, 535);
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
			this.button1.Location = new System.Drawing.Point(478, 488);
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
			this.tabControl1.Location = new System.Drawing.Point(12, 133);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(776, 349);
			this.tabControl1.TabIndex = 50;
			// 
			// settingGeneral
			// 
			this.settingGeneral.Controls.Add(this.label17);
			this.settingGeneral.Controls.Add(this.encounterRate);
			this.settingGeneral.Controls.Add(this.magicPointMulti);
			this.settingGeneral.Controls.Add(this.xpMultiplier);
			this.settingGeneral.Controls.Add(this.label11);
			this.settingGeneral.Controls.Add(this.label8);
			this.settingGeneral.Controls.Add(this.monsterAreaAppropriate);
			this.settingGeneral.Controls.Add(this.treasureTypes);
			this.settingGeneral.Controls.Add(this.label14);
			this.settingGeneral.Location = new System.Drawing.Point(4, 29);
			this.settingGeneral.Name = "settingGeneral";
			this.settingGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.settingGeneral.Size = new System.Drawing.Size(768, 316);
			this.settingGeneral.TabIndex = 0;
			this.settingGeneral.Text = "General";
			this.settingGeneral.UseVisualStyleBackColor = true;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(16, 158);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(109, 20);
			this.label17.TabIndex = 70;
			this.label17.Text = "Encounter Rate";
			// 
			// encounterRate
			// 
			this.encounterRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.encounterRate.FormattingEnabled = true;
			this.encounterRate.Items.AddRange(new object[] {
            "2x",
            "1.5x",
            "1.0x",
            "0.75x",
            "0.5x",
            "0.25x",
            "0.125x",
            "1/10000"});
			this.encounterRate.Location = new System.Drawing.Point(166, 154);
			this.encounterRate.Name = "encounterRate";
			this.encounterRate.Size = new System.Drawing.Size(148, 28);
			this.encounterRate.TabIndex = 69;
			this.encounterRate.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
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
			this.magicPointMulti.Location = new System.Drawing.Point(166, 120);
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
            "3x",
            "5x",
            "10x",
            "20x",
            "50x",
            "100x"});
			this.xpMultiplier.Location = new System.Drawing.Point(166, 87);
			this.xpMultiplier.Name = "xpMultiplier";
			this.xpMultiplier.Size = new System.Drawing.Size(148, 28);
			this.xpMultiplier.TabIndex = 65;
			this.xpMultiplier.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(16, 123);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(135, 20);
			this.label11.TabIndex = 64;
			this.label11.Text = "Magic Pt Multiplier";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(16, 91);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 20);
			this.label8.TabIndex = 61;
			this.label8.Text = "XP Multiplier";
			// 
			// monsterAreaAppropriate
			// 
			this.monsterAreaAppropriate.AutoSize = true;
			this.monsterAreaAppropriate.Location = new System.Drawing.Point(16, 47);
			this.monsterAreaAppropriate.Name = "monsterAreaAppropriate";
			this.monsterAreaAppropriate.Size = new System.Drawing.Size(338, 24);
			this.monsterAreaAppropriate.TabIndex = 60;
			this.monsterAreaAppropriate.Text = "Involve only monsters associated with the area";
			this.monsterAreaAppropriate.UseVisualStyleBackColor = true;
			this.monsterAreaAppropriate.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// treasureTypes
			// 
			this.treasureTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.treasureTypes.FormattingEnabled = true;
			this.treasureTypes.Items.AddRange(new object[] {
            "Standard",
            "Pro",
            "Wild"});
			this.treasureTypes.Location = new System.Drawing.Point(166, 9);
			this.treasureTypes.Name = "treasureTypes";
			this.treasureTypes.Size = new System.Drawing.Size(148, 28);
			this.treasureTypes.TabIndex = 59;
			this.treasureTypes.SelectedIndexChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(6, 17);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(105, 20);
			this.label14.TabIndex = 57;
			this.label14.Text = "Treasure Types";
			// 
			// settingHero
			// 
			this.settingHero.Controls.Add(this.exYang);
			this.settingHero.Controls.Add(this.firstHero);
			this.settingHero.Controls.Add(this.label16);
			this.settingHero.Controls.Add(this.exPaladinCecil);
			this.settingHero.Controls.Add(this.exFusoya);
			this.settingHero.Controls.Add(this.exRosa);
			this.settingHero.Controls.Add(this.exPorom);
			this.settingHero.Controls.Add(this.exCid);
			this.settingHero.Controls.Add(this.exRydia);
			this.settingHero.Controls.Add(this.exKain);
			this.settingHero.Controls.Add(this.exTellah);
			this.settingHero.Controls.Add(this.exEdward);
			this.settingHero.Controls.Add(this.exEdge);
			this.settingHero.Controls.Add(this.exPalom);
			this.settingHero.Controls.Add(this.exCecil);
			this.settingHero.Controls.Add(this.numHeroes);
			this.settingHero.Controls.Add(this.label6);
			this.settingHero.Controls.Add(this.dupCharactersAllowed);
			this.settingHero.Location = new System.Drawing.Point(4, 29);
			this.settingHero.Name = "settingHero";
			this.settingHero.Padding = new System.Windows.Forms.Padding(3);
			this.settingHero.Size = new System.Drawing.Size(768, 316);
			this.settingHero.TabIndex = 1;
			this.settingHero.Text = "Heroes";
			this.settingHero.UseVisualStyleBackColor = true;
			// 
			// exYang
			// 
			this.exYang.AutoSize = true;
			this.exYang.Location = new System.Drawing.Point(201, 136);
			this.exYang.Name = "exYang";
			this.exYang.Size = new System.Drawing.Size(118, 24);
			this.exYang.TabIndex = 73;
			this.exYang.Text = "Exclude Yang";
			this.exYang.UseVisualStyleBackColor = true;
			this.exYang.Visible = false;
			this.exYang.CheckedChanged += new System.EventHandler(this.DetermineFlags);
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
			// exPaladinCecil
			// 
			this.exPaladinCecil.AutoSize = true;
			this.exPaladinCecil.Location = new System.Drawing.Point(6, 196);
			this.exPaladinCecil.Name = "exPaladinCecil";
			this.exPaladinCecil.Size = new System.Drawing.Size(170, 24);
			this.exPaladinCecil.TabIndex = 69;
			this.exPaladinCecil.Text = "Exclude Paladin Cecil";
			this.exPaladinCecil.UseVisualStyleBackColor = true;
			this.exPaladinCecil.Visible = false;
			this.exPaladinCecil.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exFusoya
			// 
			this.exFusoya.AutoSize = true;
			this.exFusoya.Location = new System.Drawing.Point(412, 166);
			this.exFusoya.Name = "exFusoya";
			this.exFusoya.Size = new System.Drawing.Size(131, 24);
			this.exFusoya.TabIndex = 68;
			this.exFusoya.Text = "Exclude Fusoya";
			this.exFusoya.UseVisualStyleBackColor = true;
			this.exFusoya.Visible = false;
			this.exFusoya.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exRosa
			// 
			this.exRosa.AutoSize = true;
			this.exRosa.Location = new System.Drawing.Point(201, 106);
			this.exRosa.Name = "exRosa";
			this.exRosa.Size = new System.Drawing.Size(118, 24);
			this.exRosa.TabIndex = 67;
			this.exRosa.Text = "Exclude Rosa";
			this.exRosa.UseVisualStyleBackColor = true;
			this.exRosa.Visible = false;
			this.exRosa.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exPorom
			// 
			this.exPorom.AutoSize = true;
			this.exPorom.Location = new System.Drawing.Point(412, 104);
			this.exPorom.Name = "exPorom";
			this.exPorom.Size = new System.Drawing.Size(129, 24);
			this.exPorom.TabIndex = 66;
			this.exPorom.Text = "Exclude Porom";
			this.exPorom.UseVisualStyleBackColor = true;
			this.exPorom.Visible = false;
			this.exPorom.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exCid
			// 
			this.exCid.AutoSize = true;
			this.exCid.Location = new System.Drawing.Point(201, 166);
			this.exCid.Name = "exCid";
			this.exCid.Size = new System.Drawing.Size(108, 24);
			this.exCid.TabIndex = 65;
			this.exCid.Text = "Exclude Cid";
			this.exCid.UseVisualStyleBackColor = true;
			this.exCid.Visible = false;
			this.exCid.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exRydia
			// 
			this.exRydia.AutoSize = true;
			this.exRydia.Location = new System.Drawing.Point(6, 166);
			this.exRydia.Name = "exRydia";
			this.exRydia.Size = new System.Drawing.Size(123, 24);
			this.exRydia.TabIndex = 64;
			this.exRydia.Text = "Exclude Rydia";
			this.exRydia.UseVisualStyleBackColor = true;
			this.exRydia.Visible = false;
			this.exRydia.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exKain
			// 
			this.exKain.AutoSize = true;
			this.exKain.Location = new System.Drawing.Point(6, 106);
			this.exKain.Name = "exKain";
			this.exKain.Size = new System.Drawing.Size(115, 24);
			this.exKain.TabIndex = 63;
			this.exKain.Text = "Exclude Kain";
			this.exKain.UseVisualStyleBackColor = true;
			this.exKain.Visible = false;
			this.exKain.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exTellah
			// 
			this.exTellah.AutoSize = true;
			this.exTellah.Location = new System.Drawing.Point(6, 136);
			this.exTellah.Name = "exTellah";
			this.exTellah.Size = new System.Drawing.Size(125, 24);
			this.exTellah.TabIndex = 62;
			this.exTellah.Text = "Exclude Tellah";
			this.exTellah.UseVisualStyleBackColor = true;
			this.exTellah.Visible = false;
			this.exTellah.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exEdward
			// 
			this.exEdward.AutoSize = true;
			this.exEdward.Location = new System.Drawing.Point(201, 76);
			this.exEdward.Name = "exEdward";
			this.exEdward.Size = new System.Drawing.Size(136, 24);
			this.exEdward.TabIndex = 61;
			this.exEdward.Text = "Exclude Edward";
			this.exEdward.UseVisualStyleBackColor = true;
			this.exEdward.Visible = false;
			this.exEdward.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exEdge
			// 
			this.exEdge.AutoSize = true;
			this.exEdge.Location = new System.Drawing.Point(412, 134);
			this.exEdge.Name = "exEdge";
			this.exEdge.Size = new System.Drawing.Size(120, 24);
			this.exEdge.TabIndex = 60;
			this.exEdge.Text = "Exclude Edge";
			this.exEdge.UseVisualStyleBackColor = true;
			this.exEdge.Visible = false;
			this.exEdge.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exPalom
			// 
			this.exPalom.AutoSize = true;
			this.exPalom.Location = new System.Drawing.Point(412, 76);
			this.exPalom.Name = "exPalom";
			this.exPalom.Size = new System.Drawing.Size(127, 24);
			this.exPalom.TabIndex = 59;
			this.exPalom.Text = "Exclude Palom";
			this.exPalom.UseVisualStyleBackColor = true;
			this.exPalom.Visible = false;
			this.exPalom.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// exCecil
			// 
			this.exCecil.AutoSize = true;
			this.exCecil.Location = new System.Drawing.Point(6, 78);
			this.exCecil.Name = "exCecil";
			this.exCecil.Size = new System.Drawing.Size(187, 24);
			this.exCecil.TabIndex = 58;
			this.exCecil.Text = "Exclude Dk Knight Cecil";
			this.exCecil.UseVisualStyleBackColor = true;
			this.exCecil.Visible = false;
			this.exCecil.CheckedChanged += new System.EventHandler(this.DetermineFlags);
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
			this.dupCharactersAllowed.Visible = false;
			this.dupCharactersAllowed.CheckedChanged += new System.EventHandler(this.DetermineFlags);
			// 
			// FF4FabulGauntlet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 566);
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
        private System.Windows.Forms.ComboBox treasureTypes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage settingHero;
        private System.Windows.Forms.CheckBox dupCharactersAllowed;
        private System.Windows.Forms.CheckBox exPaladinCecil;
        private System.Windows.Forms.CheckBox exFusoya;
        private System.Windows.Forms.CheckBox exRosa;
        private System.Windows.Forms.CheckBox exPorom;
        private System.Windows.Forms.CheckBox exCid;
        private System.Windows.Forms.CheckBox exRydia;
        private System.Windows.Forms.CheckBox exKain;
        private System.Windows.Forms.CheckBox exTellah;
        private System.Windows.Forms.CheckBox exEdward;
        private System.Windows.Forms.CheckBox exEdge;
        private System.Windows.Forms.CheckBox exPalom;
        private System.Windows.Forms.CheckBox exCecil;
        private System.Windows.Forms.ComboBox numHeroes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox firstHero;
        private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ToolTip hpAdjustTooltip;
        private System.Windows.Forms.CheckBox exYang;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.ComboBox encounterRate;
		private System.Windows.Forms.ComboBox magicPointMulti;
		private System.Windows.Forms.ComboBox xpMultiplier;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox monsterAreaAppropriate;
	}
}

