namespace CircuitCalculator
{
    partial class VectorPotentialCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VectorPotentialCalculator));
            this.closeButton = new System.Windows.Forms.Button();
            this.calculateButtonEquivalent = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.calculateButtonWPC = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.magPotCurrentSourcePictureBox = new System.Windows.Forms.PictureBox();
            this.magPotCurrentDensityPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.differentialLineUnits = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultUnit = new System.Windows.Forms.ComboBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fcRadiusFactor = new System.Windows.Forms.ComboBox();
            this.fcCurrentFactor = new System.Windows.Forms.ComboBox();
            this.fcRadiusValueBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fcCurrentValueBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.magPotCurrentSourcePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magPotCurrentDensityPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 561);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(102, 23);
            this.closeButton.TabIndex = 20;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // calculateButtonEquivalent
            // 
            this.calculateButtonEquivalent.Location = new System.Drawing.Point(170, 244);
            this.calculateButtonEquivalent.Name = "calculateButtonEquivalent";
            this.calculateButtonEquivalent.Size = new System.Drawing.Size(75, 23);
            this.calculateButtonEquivalent.TabIndex = 63;
            this.calculateButtonEquivalent.Text = "Calculate";
            this.calculateButtonEquivalent.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(147, 226);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 62;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // calculateButtonWPC
            // 
            this.calculateButtonWPC.Location = new System.Drawing.Point(173, 415);
            this.calculateButtonWPC.Name = "calculateButtonWPC";
            this.calculateButtonWPC.Size = new System.Drawing.Size(75, 23);
            this.calculateButtonWPC.TabIndex = 61;
            this.calculateButtonWPC.Text = "Calculate";
            this.calculateButtonWPC.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 453);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(487, 102);
            this.richTextBox1.TabIndex = 64;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Calculate the vector potential with vector calculus.";
            // 
            // magPotCurrentSourcePictureBox
            // 
            this.magPotCurrentSourcePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("magPotCurrentSourcePictureBox.Image")));
            this.magPotCurrentSourcePictureBox.Location = new System.Drawing.Point(6, 19);
            this.magPotCurrentSourcePictureBox.Name = "magPotCurrentSourcePictureBox";
            this.magPotCurrentSourcePictureBox.Size = new System.Drawing.Size(157, 80);
            this.magPotCurrentSourcePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.magPotCurrentSourcePictureBox.TabIndex = 67;
            this.magPotCurrentSourcePictureBox.TabStop = false;
            // 
            // magPotCurrentDensityPictureBox
            // 
            this.magPotCurrentDensityPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("magPotCurrentDensityPictureBox.Image")));
            this.magPotCurrentDensityPictureBox.Location = new System.Drawing.Point(6, 19);
            this.magPotCurrentDensityPictureBox.Name = "magPotCurrentDensityPictureBox";
            this.magPotCurrentDensityPictureBox.Size = new System.Drawing.Size(157, 80);
            this.magPotCurrentDensityPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.magPotCurrentDensityPictureBox.TabIndex = 68;
            this.magPotCurrentDensityPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.differentialLineUnits);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.resultUnit);
            this.groupBox1.Controls.Add(this.resultBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.fcRadiusFactor);
            this.groupBox1.Controls.Add(this.fcCurrentFactor);
            this.groupBox1.Controls.Add(this.fcRadiusValueBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.fcCurrentValueBox);
            this.groupBox1.Controls.Add(this.magPotCurrentSourcePictureBox);
            this.groupBox1.Controls.Add(this.calculateButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 339);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Potential field from current source";
            // 
            // differentialLineUnits
            // 
            this.differentialLineUnits.FormattingEnabled = true;
            this.differentialLineUnits.Items.AddRange(new object[] {
            "Pi/2",
            "Pi",
            "2*Pi"});
            this.differentialLineUnits.Location = new System.Drawing.Point(60, 174);
            this.differentialLineUnits.Name = "differentialLineUnits";
            this.differentialLineUnits.Size = new System.Drawing.Size(94, 21);
            this.differentialLineUnits.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "dl";
            // 
            // resultUnit
            // 
            this.resultUnit.FormattingEnabled = true;
            this.resultUnit.Location = new System.Drawing.Point(158, 255);
            this.resultUnit.Name = "resultUnit";
            this.resultUnit.Size = new System.Drawing.Size(58, 21);
            this.resultUnit.TabIndex = 87;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(35, 255);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(117, 20);
            this.resultBox.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 90;
            this.label8.Text = "A =";
            // 
            // fcRadiusFactor
            // 
            this.fcRadiusFactor.FormattingEnabled = true;
            this.fcRadiusFactor.Items.AddRange(new object[] {
            "mm",
            "cm",
            "m"});
            this.fcRadiusFactor.Location = new System.Drawing.Point(108, 147);
            this.fcRadiusFactor.Name = "fcRadiusFactor";
            this.fcRadiusFactor.Size = new System.Drawing.Size(46, 21);
            this.fcRadiusFactor.TabIndex = 86;
            // 
            // fcCurrentFactor
            // 
            this.fcCurrentFactor.FormattingEnabled = true;
            this.fcCurrentFactor.Items.AddRange(new object[] {
            "uA",
            "mA",
            "A"});
            this.fcCurrentFactor.Location = new System.Drawing.Point(108, 122);
            this.fcCurrentFactor.Name = "fcCurrentFactor";
            this.fcCurrentFactor.Size = new System.Drawing.Size(46, 21);
            this.fcCurrentFactor.TabIndex = 84;
            // 
            // fcRadiusValueBox
            // 
            this.fcRadiusValueBox.Location = new System.Drawing.Point(55, 148);
            this.fcRadiusValueBox.Name = "fcRadiusValueBox";
            this.fcRadiusValueBox.Size = new System.Drawing.Size(47, 20);
            this.fcRadiusValueBox.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(9, 13);
            this.label6.TabIndex = 88;
            this.label6.Text = "i";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "r";
            // 
            // fcCurrentValueBox
            // 
            this.fcCurrentValueBox.Location = new System.Drawing.Point(55, 122);
            this.fcCurrentValueBox.Name = "fcCurrentValueBox";
            this.fcCurrentValueBox.Size = new System.Drawing.Size(47, 20);
            this.fcCurrentValueBox.TabIndex = 83;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.magPotCurrentDensityPictureBox);
            this.groupBox2.Controls.Add(this.calculateButtonEquivalent);
            this.groupBox2.Location = new System.Drawing.Point(240, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 339);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Potential field from current density";
            // 
            // VectorPotentialCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 596);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.calculateButtonWPC);
            this.Controls.Add(this.closeButton);
            this.Name = "VectorPotentialCalculator";
            this.Text = "Vector Potential";
            ((System.ComponentModel.ISupportInitialize)(this.magPotCurrentSourcePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magPotCurrentDensityPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button calculateButtonEquivalent;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button calculateButtonWPC;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox magPotCurrentSourcePictureBox;
        private System.Windows.Forms.PictureBox magPotCurrentDensityPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox resultUnit;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox fcRadiusFactor;
        private System.Windows.Forms.ComboBox fcCurrentFactor;
        private System.Windows.Forms.TextBox fcRadiusValueBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fcCurrentValueBox;
        private System.Windows.Forms.ComboBox differentialLineUnits;
        private System.Windows.Forms.Label label2;
    }
}