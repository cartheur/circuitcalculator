namespace CircuitCalculator
{
    partial class QualityFactorCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QualityFactorCalculator));
            this.closeButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.lossesCalculatorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.qualityEquationWPC = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.frequencyValueBox = new System.Windows.Forms.TextBox();
            this.resistanceValueBox = new System.Windows.Forms.TextBox();
            this.inductanceValueBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateButtonWPC = new System.Windows.Forms.Button();
            this.resultBoxWPC = new System.Windows.Forms.TextBox();
            this.frequencyFactor = new System.Windows.Forms.ComboBox();
            this.inductanceFactor = new System.Windows.Forms.ComboBox();
            this.parallelCaseQualityWikipediaRyneWang = new System.Windows.Forms.PictureBox();
            this.calculateButtonWiki = new System.Windows.Forms.Button();
            this.capacitanceFactor = new System.Windows.Forms.ComboBox();
            this.inductance2Factor = new System.Windows.Forms.ComboBox();
            this.resistanceFactor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.capacitanceValueBox = new System.Windows.Forms.TextBox();
            this.inductance2ValueBox = new System.Windows.Forms.TextBox();
            this.resistance2ValueBox = new System.Windows.Forms.TextBox();
            this.resultBoxWiki = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.zeirhoferCaseQuality = new System.Windows.Forms.PictureBox();
            this.calculateButtonEquivalent = new System.Windows.Forms.Button();
            this.resultBoxMyneEquivalent = new System.Windows.Forms.TextBox();
            this.capacitance2Factor = new System.Windows.Forms.ComboBox();
            this.inductance3Factor = new System.Windows.Forms.ComboBox();
            this.resistance2Factor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.capacitance2ValueBox = new System.Windows.Forms.TextBox();
            this.inductance3ValueBox = new System.Windows.Forms.TextBox();
            this.resistance3ValueBox = new System.Windows.Forms.TextBox();
            this.resultBoxZeirhoferEquivalent = new System.Windows.Forms.TextBox();
            this.reciprocalsButton = new System.Windows.Forms.Button();
            this.reciprocalsReportingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qualityEquationWPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parallelCaseQualityWikipediaRyneWang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeirhoferCaseQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 555);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(102, 23);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(13, 13);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(123, 13);
            this.infoLabel.TabIndex = 21;
            this.infoLabel.Text = "The Quality of the Circuit";
            // 
            // lossesCalculatorButton
            // 
            this.lossesCalculatorButton.Location = new System.Drawing.Point(124, 555);
            this.lossesCalculatorButton.Name = "lossesCalculatorButton";
            this.lossesCalculatorButton.Size = new System.Drawing.Size(55, 23);
            this.lossesCalculatorButton.TabIndex = 22;
            this.lossesCalculatorButton.Text = "Losses";
            this.lossesCalculatorButton.UseVisualStyleBackColor = true;
            this.lossesCalculatorButton.Click += new System.EventHandler(this.lossesCalculatorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Quality for Ohmic resistance";
            // 
            // qualityEquationWPC
            // 
            this.qualityEquationWPC.Image = ((System.Drawing.Image)(resources.GetObject("qualityEquationWPC.Image")));
            this.qualityEquationWPC.Location = new System.Drawing.Point(16, 99);
            this.qualityEquationWPC.Name = "qualityEquationWPC";
            this.qualityEquationWPC.Size = new System.Drawing.Size(100, 67);
            this.qualityEquationWPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qualityEquationWPC.TabIndex = 25;
            this.qualityEquationWPC.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(148, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(148, 128);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(148, 162);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // frequencyValueBox
            // 
            this.frequencyValueBox.Location = new System.Drawing.Point(183, 99);
            this.frequencyValueBox.Name = "frequencyValueBox";
            this.frequencyValueBox.Size = new System.Drawing.Size(100, 20);
            this.frequencyValueBox.TabIndex = 29;
            // 
            // resistanceValueBox
            // 
            this.resistanceValueBox.Location = new System.Drawing.Point(183, 165);
            this.resistanceValueBox.Name = "resistanceValueBox";
            this.resistanceValueBox.Size = new System.Drawing.Size(100, 20);
            this.resistanceValueBox.TabIndex = 30;
            // 
            // inductanceValueBox
            // 
            this.inductanceValueBox.Location = new System.Drawing.Point(183, 132);
            this.inductanceValueBox.Name = "inductanceValueBox";
            this.inductanceValueBox.Size = new System.Drawing.Size(100, 20);
            this.inductanceValueBox.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ω";
            // 
            // calculateButtonWPC
            // 
            this.calculateButtonWPC.Location = new System.Drawing.Point(366, 128);
            this.calculateButtonWPC.Name = "calculateButtonWPC";
            this.calculateButtonWPC.Size = new System.Drawing.Size(75, 23);
            this.calculateButtonWPC.TabIndex = 35;
            this.calculateButtonWPC.Text = "Calculate";
            this.calculateButtonWPC.UseVisualStyleBackColor = true;
            this.calculateButtonWPC.Click += new System.EventHandler(this.calculateButtonWPC_Click);
            // 
            // resultBoxWPC
            // 
            this.resultBoxWPC.Location = new System.Drawing.Point(366, 162);
            this.resultBoxWPC.Name = "resultBoxWPC";
            this.resultBoxWPC.Size = new System.Drawing.Size(100, 20);
            this.resultBoxWPC.TabIndex = 36;
            // 
            // frequencyFactor
            // 
            this.frequencyFactor.FormattingEnabled = true;
            this.frequencyFactor.Items.AddRange(new object[] {
            "MHz",
            "kHz",
            "Hz"});
            this.frequencyFactor.Location = new System.Drawing.Point(289, 98);
            this.frequencyFactor.Name = "frequencyFactor";
            this.frequencyFactor.Size = new System.Drawing.Size(46, 21);
            this.frequencyFactor.TabIndex = 37;
            // 
            // inductanceFactor
            // 
            this.inductanceFactor.FormattingEnabled = true;
            this.inductanceFactor.Items.AddRange(new object[] {
            "H",
            "mH",
            "uH"});
            this.inductanceFactor.Location = new System.Drawing.Point(289, 132);
            this.inductanceFactor.Name = "inductanceFactor";
            this.inductanceFactor.Size = new System.Drawing.Size(46, 21);
            this.inductanceFactor.TabIndex = 38;
            // 
            // parallelCaseQualityWikipediaRyneWang
            // 
            this.parallelCaseQualityWikipediaRyneWang.Image = ((System.Drawing.Image)(resources.GetObject("parallelCaseQualityWikipediaRyneWang.Image")));
            this.parallelCaseQualityWikipediaRyneWang.Location = new System.Drawing.Point(16, 365);
            this.parallelCaseQualityWikipediaRyneWang.Name = "parallelCaseQualityWikipediaRyneWang";
            this.parallelCaseQualityWikipediaRyneWang.Size = new System.Drawing.Size(100, 69);
            this.parallelCaseQualityWikipediaRyneWang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.parallelCaseQualityWikipediaRyneWang.TabIndex = 39;
            this.parallelCaseQualityWikipediaRyneWang.TabStop = false;
            // 
            // calculateButtonWiki
            // 
            this.calculateButtonWiki.Location = new System.Drawing.Point(366, 250);
            this.calculateButtonWiki.Name = "calculateButtonWiki";
            this.calculateButtonWiki.Size = new System.Drawing.Size(75, 23);
            this.calculateButtonWiki.TabIndex = 49;
            this.calculateButtonWiki.Text = "Calculate";
            this.calculateButtonWiki.UseVisualStyleBackColor = true;
            this.calculateButtonWiki.Click += new System.EventHandler(this.calculateButtonWiki_Click);
            // 
            // capacitanceFactor
            // 
            this.capacitanceFactor.FormattingEnabled = true;
            this.capacitanceFactor.Items.AddRange(new object[] {
            "uF",
            "nF",
            "pF"});
            this.capacitanceFactor.Location = new System.Drawing.Point(256, 293);
            this.capacitanceFactor.Name = "capacitanceFactor";
            this.capacitanceFactor.Size = new System.Drawing.Size(44, 21);
            this.capacitanceFactor.TabIndex = 48;
            // 
            // inductance2Factor
            // 
            this.inductance2Factor.FormattingEnabled = true;
            this.inductance2Factor.Items.AddRange(new object[] {
            "H",
            "mH",
            "uH",
            "nH",
            "pH"});
            this.inductance2Factor.Location = new System.Drawing.Point(256, 270);
            this.inductance2Factor.Name = "inductance2Factor";
            this.inductance2Factor.Size = new System.Drawing.Size(44, 21);
            this.inductance2Factor.TabIndex = 47;
            // 
            // resistanceFactor
            // 
            this.resistanceFactor.FormattingEnabled = true;
            this.resistanceFactor.Items.AddRange(new object[] {
            "Ω",
            "kΩ",
            "MΩ"});
            this.resistanceFactor.Location = new System.Drawing.Point(256, 246);
            this.resistanceFactor.Name = "resistanceFactor";
            this.resistanceFactor.Size = new System.Drawing.Size(44, 21);
            this.resistanceFactor.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "L";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "R";
            // 
            // capacitanceValueBox
            // 
            this.capacitanceValueBox.Location = new System.Drawing.Point(183, 294);
            this.capacitanceValueBox.Name = "capacitanceValueBox";
            this.capacitanceValueBox.Size = new System.Drawing.Size(67, 20);
            this.capacitanceValueBox.TabIndex = 42;
            // 
            // inductance2ValueBox
            // 
            this.inductance2ValueBox.Location = new System.Drawing.Point(183, 270);
            this.inductance2ValueBox.Name = "inductance2ValueBox";
            this.inductance2ValueBox.Size = new System.Drawing.Size(67, 20);
            this.inductance2ValueBox.TabIndex = 41;
            // 
            // resistance2ValueBox
            // 
            this.resistance2ValueBox.Location = new System.Drawing.Point(183, 247);
            this.resistance2ValueBox.Name = "resistance2ValueBox";
            this.resistance2ValueBox.Size = new System.Drawing.Size(67, 20);
            this.resistance2ValueBox.TabIndex = 40;
            // 
            // resultBoxWiki
            // 
            this.resultBoxWiki.Location = new System.Drawing.Point(366, 285);
            this.resultBoxWiki.Name = "resultBoxWiki";
            this.resultBoxWiki.Size = new System.Drawing.Size(100, 20);
            this.resultBoxWiki.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Quality for radiation resistance";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 301);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 54;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Can these be shown to be equivalent?";
            // 
            // zeirhoferCaseQuality
            // 
            this.zeirhoferCaseQuality.Image = ((System.Drawing.Image)(resources.GetObject("zeirhoferCaseQuality.Image")));
            this.zeirhoferCaseQuality.Location = new System.Drawing.Point(16, 440);
            this.zeirhoferCaseQuality.Name = "zeirhoferCaseQuality";
            this.zeirhoferCaseQuality.Size = new System.Drawing.Size(100, 69);
            this.zeirhoferCaseQuality.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zeirhoferCaseQuality.TabIndex = 56;
            this.zeirhoferCaseQuality.TabStop = false;
            // 
            // calculateButtonEquivalent
            // 
            this.calculateButtonEquivalent.Location = new System.Drawing.Point(366, 440);
            this.calculateButtonEquivalent.Name = "calculateButtonEquivalent";
            this.calculateButtonEquivalent.Size = new System.Drawing.Size(75, 23);
            this.calculateButtonEquivalent.TabIndex = 57;
            this.calculateButtonEquivalent.Text = "Calculate";
            this.calculateButtonEquivalent.UseVisualStyleBackColor = true;
            this.calculateButtonEquivalent.Click += new System.EventHandler(this.calculateButtonEquivalent_Click);
            // 
            // resultBoxMyneEquivalent
            // 
            this.resultBoxMyneEquivalent.Location = new System.Drawing.Point(366, 414);
            this.resultBoxMyneEquivalent.Name = "resultBoxMyneEquivalent";
            this.resultBoxMyneEquivalent.Size = new System.Drawing.Size(100, 20);
            this.resultBoxMyneEquivalent.TabIndex = 67;
            // 
            // capacitance2Factor
            // 
            this.capacitance2Factor.FormattingEnabled = true;
            this.capacitance2Factor.Items.AddRange(new object[] {
            "uF",
            "nF",
            "pF"});
            this.capacitance2Factor.Location = new System.Drawing.Point(256, 450);
            this.capacitance2Factor.Name = "capacitance2Factor";
            this.capacitance2Factor.Size = new System.Drawing.Size(44, 21);
            this.capacitance2Factor.TabIndex = 66;
            // 
            // inductance3Factor
            // 
            this.inductance3Factor.FormattingEnabled = true;
            this.inductance3Factor.Items.AddRange(new object[] {
            "H",
            "mH",
            "uH",
            "nH",
            "pH"});
            this.inductance3Factor.Location = new System.Drawing.Point(256, 427);
            this.inductance3Factor.Name = "inductance3Factor";
            this.inductance3Factor.Size = new System.Drawing.Size(44, 21);
            this.inductance3Factor.TabIndex = 65;
            // 
            // resistance2Factor
            // 
            this.resistance2Factor.FormattingEnabled = true;
            this.resistance2Factor.Items.AddRange(new object[] {
            "Ω",
            "kΩ",
            "MΩ"});
            this.resistance2Factor.Location = new System.Drawing.Point(256, 403);
            this.resistance2Factor.Name = "resistance2Factor";
            this.resistance2Factor.Size = new System.Drawing.Size(44, 21);
            this.resistance2Factor.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "L";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(164, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "R";
            // 
            // capacitance2ValueBox
            // 
            this.capacitance2ValueBox.AcceptsReturn = true;
            this.capacitance2ValueBox.Location = new System.Drawing.Point(183, 451);
            this.capacitance2ValueBox.Name = "capacitance2ValueBox";
            this.capacitance2ValueBox.Size = new System.Drawing.Size(67, 20);
            this.capacitance2ValueBox.TabIndex = 60;
            // 
            // inductance3ValueBox
            // 
            this.inductance3ValueBox.Location = new System.Drawing.Point(183, 427);
            this.inductance3ValueBox.Name = "inductance3ValueBox";
            this.inductance3ValueBox.Size = new System.Drawing.Size(67, 20);
            this.inductance3ValueBox.TabIndex = 59;
            // 
            // resistance3ValueBox
            // 
            this.resistance3ValueBox.Location = new System.Drawing.Point(183, 404);
            this.resistance3ValueBox.Name = "resistance3ValueBox";
            this.resistance3ValueBox.Size = new System.Drawing.Size(67, 20);
            this.resistance3ValueBox.TabIndex = 58;
            // 
            // resultBoxZeirhoferEquivalent
            // 
            this.resultBoxZeirhoferEquivalent.Location = new System.Drawing.Point(366, 469);
            this.resultBoxZeirhoferEquivalent.Name = "resultBoxZeirhoferEquivalent";
            this.resultBoxZeirhoferEquivalent.Size = new System.Drawing.Size(100, 20);
            this.resultBoxZeirhoferEquivalent.TabIndex = 68;
            // 
            // reciprocalsButton
            // 
            this.reciprocalsButton.Location = new System.Drawing.Point(366, 495);
            this.reciprocalsButton.Name = "reciprocalsButton";
            this.reciprocalsButton.Size = new System.Drawing.Size(75, 23);
            this.reciprocalsButton.TabIndex = 69;
            this.reciprocalsButton.Text = "Reciprocals";
            this.reciprocalsButton.UseVisualStyleBackColor = true;
            this.reciprocalsButton.Click += new System.EventHandler(this.reciprocalsButton_Click);
            // 
            // reciprocalsReportingLabel
            // 
            this.reciprocalsReportingLabel.AutoSize = true;
            this.reciprocalsReportingLabel.Location = new System.Drawing.Point(292, 521);
            this.reciprocalsReportingLabel.Name = "reciprocalsReportingLabel";
            this.reciprocalsReportingLabel.Size = new System.Drawing.Size(0, 13);
            this.reciprocalsReportingLabel.TabIndex = 70;
            // 
            // QualityFactorCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 590);
            this.Controls.Add(this.reciprocalsReportingLabel);
            this.Controls.Add(this.reciprocalsButton);
            this.Controls.Add(this.resultBoxZeirhoferEquivalent);
            this.Controls.Add(this.resultBoxMyneEquivalent);
            this.Controls.Add(this.capacitance2Factor);
            this.Controls.Add(this.inductance3Factor);
            this.Controls.Add(this.resistance2Factor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.capacitance2ValueBox);
            this.Controls.Add(this.inductance3ValueBox);
            this.Controls.Add(this.resistance3ValueBox);
            this.Controls.Add(this.calculateButtonEquivalent);
            this.Controls.Add(this.zeirhoferCaseQuality);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultBoxWiki);
            this.Controls.Add(this.calculateButtonWiki);
            this.Controls.Add(this.capacitanceFactor);
            this.Controls.Add(this.inductance2Factor);
            this.Controls.Add(this.resistanceFactor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.capacitanceValueBox);
            this.Controls.Add(this.inductance2ValueBox);
            this.Controls.Add(this.resistance2ValueBox);
            this.Controls.Add(this.parallelCaseQualityWikipediaRyneWang);
            this.Controls.Add(this.inductanceFactor);
            this.Controls.Add(this.frequencyFactor);
            this.Controls.Add(this.resultBoxWPC);
            this.Controls.Add(this.calculateButtonWPC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inductanceValueBox);
            this.Controls.Add(this.resistanceValueBox);
            this.Controls.Add(this.frequencyValueBox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.qualityEquationWPC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lossesCalculatorButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.closeButton);
            this.Name = "QualityFactorCalculator";
            this.Text = "Quality Factor Calculator";
            this.Load += new System.EventHandler(this.QualityFactorCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qualityEquationWPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parallelCaseQualityWikipediaRyneWang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeirhoferCaseQuality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button lossesCalculatorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox qualityEquationWPC;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox frequencyValueBox;
        private System.Windows.Forms.TextBox resistanceValueBox;
        private System.Windows.Forms.TextBox inductanceValueBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateButtonWPC;
        private System.Windows.Forms.TextBox resultBoxWPC;
        private System.Windows.Forms.ComboBox frequencyFactor;
        private System.Windows.Forms.ComboBox inductanceFactor;
        private System.Windows.Forms.PictureBox parallelCaseQualityWikipediaRyneWang;
        private System.Windows.Forms.Button calculateButtonWiki;
        private System.Windows.Forms.ComboBox capacitanceFactor;
        private System.Windows.Forms.ComboBox inductance2Factor;
        private System.Windows.Forms.ComboBox resistanceFactor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox capacitanceValueBox;
        private System.Windows.Forms.TextBox inductance2ValueBox;
        private System.Windows.Forms.TextBox resistance2ValueBox;
        private System.Windows.Forms.TextBox resultBoxWiki;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox zeirhoferCaseQuality;
        private System.Windows.Forms.Button calculateButtonEquivalent;
        private System.Windows.Forms.TextBox resultBoxMyneEquivalent;
        private System.Windows.Forms.ComboBox capacitance2Factor;
        private System.Windows.Forms.ComboBox inductance3Factor;
        private System.Windows.Forms.ComboBox resistance2Factor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox capacitance2ValueBox;
        private System.Windows.Forms.TextBox inductance3ValueBox;
        private System.Windows.Forms.TextBox resistance3ValueBox;
        private System.Windows.Forms.TextBox resultBoxZeirhoferEquivalent;
        private System.Windows.Forms.Button reciprocalsButton;
        private System.Windows.Forms.Label reciprocalsReportingLabel;
    }
}