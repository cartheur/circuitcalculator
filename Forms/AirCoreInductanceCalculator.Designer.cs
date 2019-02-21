namespace CircuitCalculator.Forms
{
    partial class AirCoreInductanceCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirCoreInductanceCalculator));
            this.closeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.wireDiameterFactor = new System.Windows.Forms.ComboBox();
            this.wireDiameterValueBox = new System.Windows.Forms.TextBox();
            this.innerDiameterFactor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.innerDiameterValueBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.turnsValueBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.circularLoopPictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.wireSpacingFactor = new System.Windows.Forms.ComboBox();
            this.wireSpacingValueBox = new System.Windows.Forms.TextBox();
            this.outerDiameterFactor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.outerDiameterValueBox = new System.Windows.Forms.TextBox();
            this.wireLengthFactor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.wireLengthValueBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.equationBox = new System.Windows.Forms.PictureBox();
            this.sessionValue = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.circularLoopPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 421);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(118, 23);
            this.closeButton.TabIndex = 30;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "w";
            // 
            // wireDiameterFactor
            // 
            this.wireDiameterFactor.FormattingEnabled = true;
            this.wireDiameterFactor.Items.AddRange(new object[] {
            "mm"});
            this.wireDiameterFactor.Location = new System.Drawing.Point(282, 209);
            this.wireDiameterFactor.Name = "wireDiameterFactor";
            this.wireDiameterFactor.Size = new System.Drawing.Size(58, 21);
            this.wireDiameterFactor.TabIndex = 38;
            // 
            // wireDiameterValueBox
            // 
            this.wireDiameterValueBox.Location = new System.Drawing.Point(222, 209);
            this.wireDiameterValueBox.Name = "wireDiameterValueBox";
            this.wireDiameterValueBox.Size = new System.Drawing.Size(53, 20);
            this.wireDiameterValueBox.TabIndex = 3;
            // 
            // innerDiameterFactor
            // 
            this.innerDiameterFactor.FormattingEnabled = true;
            this.innerDiameterFactor.Items.AddRange(new object[] {
            "mm"});
            this.innerDiameterFactor.Location = new System.Drawing.Point(282, 183);
            this.innerDiameterFactor.Name = "innerDiameterFactor";
            this.innerDiameterFactor.Size = new System.Drawing.Size(58, 21);
            this.innerDiameterFactor.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Din";
            // 
            // innerDiameterValueBox
            // 
            this.innerDiameterValueBox.Location = new System.Drawing.Point(222, 183);
            this.innerDiameterValueBox.Name = "innerDiameterValueBox";
            this.innerDiameterValueBox.Size = new System.Drawing.Size(53, 20);
            this.innerDiameterValueBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "N";
            // 
            // turnsValueBox
            // 
            this.turnsValueBox.Location = new System.Drawing.Point(222, 156);
            this.turnsValueBox.Name = "turnsValueBox";
            this.turnsValueBox.Size = new System.Drawing.Size(53, 20);
            this.turnsValueBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Air-core coil";
            // 
            // circularLoopPictureBox
            // 
            this.circularLoopPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("circularLoopPictureBox.Image")));
            this.circularLoopPictureBox.Location = new System.Drawing.Point(15, 32);
            this.circularLoopPictureBox.Name = "circularLoopPictureBox";
            this.circularLoopPictureBox.Size = new System.Drawing.Size(143, 109);
            this.circularLoopPictureBox.TabIndex = 32;
            this.circularLoopPictureBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "uH";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(77, 381);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(136, 20);
            this.resultBox.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(282, 273);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(97, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButtonClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "s";
            // 
            // wireSpacingFactor
            // 
            this.wireSpacingFactor.FormattingEnabled = true;
            this.wireSpacingFactor.Items.AddRange(new object[] {
            "mm"});
            this.wireSpacingFactor.Location = new System.Drawing.Point(282, 235);
            this.wireSpacingFactor.Name = "wireSpacingFactor";
            this.wireSpacingFactor.Size = new System.Drawing.Size(58, 21);
            this.wireSpacingFactor.TabIndex = 53;
            // 
            // wireSpacingValueBox
            // 
            this.wireSpacingValueBox.Location = new System.Drawing.Point(222, 235);
            this.wireSpacingValueBox.Name = "wireSpacingValueBox";
            this.wireSpacingValueBox.Size = new System.Drawing.Size(53, 20);
            this.wireSpacingValueBox.TabIndex = 4;
            // 
            // outerDiameterFactor
            // 
            this.outerDiameterFactor.FormattingEnabled = true;
            this.outerDiameterFactor.Items.AddRange(new object[] {
            "mm"});
            this.outerDiameterFactor.Location = new System.Drawing.Point(159, 22);
            this.outerDiameterFactor.Name = "outerDiameterFactor";
            this.outerDiameterFactor.Size = new System.Drawing.Size(58, 21);
            this.outerDiameterFactor.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Dout";
            // 
            // outerDiameterValueBox
            // 
            this.outerDiameterValueBox.Location = new System.Drawing.Point(55, 23);
            this.outerDiameterValueBox.Name = "outerDiameterValueBox";
            this.outerDiameterValueBox.Size = new System.Drawing.Size(98, 20);
            this.outerDiameterValueBox.TabIndex = 2;
            // 
            // wireLengthFactor
            // 
            this.wireLengthFactor.FormattingEnabled = true;
            this.wireLengthFactor.Items.AddRange(new object[] {
            "m",
            "mm"});
            this.wireLengthFactor.Location = new System.Drawing.Point(159, 48);
            this.wireLengthFactor.Name = "wireLengthFactor";
            this.wireLengthFactor.Size = new System.Drawing.Size(58, 21);
            this.wireLengthFactor.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "wl";
            // 
            // wireLengthValueBox
            // 
            this.wireLengthValueBox.Location = new System.Drawing.Point(55, 49);
            this.wireLengthValueBox.Name = "wireLengthValueBox";
            this.wireLengthValueBox.Size = new System.Drawing.Size(98, 20);
            this.wireLengthValueBox.TabIndex = 58;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.wireLengthFactor);
            this.groupBox1.Controls.Add(this.outerDiameterValueBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.outerDiameterFactor);
            this.groupBox1.Controls.Add(this.wireLengthValueBox);
            this.groupBox1.Location = new System.Drawing.Point(23, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 82);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "L";
            // 
            // equationBox
            // 
            this.equationBox.Image = ((System.Drawing.Image)(resources.GetObject("equationBox.Image")));
            this.equationBox.Location = new System.Drawing.Point(21, 153);
            this.equationBox.Name = "equationBox";
            this.equationBox.Size = new System.Drawing.Size(137, 98);
            this.equationBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equationBox.TabIndex = 63;
            this.equationBox.TabStop = false;
            // 
            // sessionValue
            // 
            this.sessionValue.AutoSize = true;
            this.sessionValue.Location = new System.Drawing.Point(80, 9);
            this.sessionValue.Name = "sessionValue";
            this.sessionValue.Size = new System.Drawing.Size(0, 13);
            this.sessionValue.TabIndex = 66;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "Session ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 109);
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // AirCoreInductanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 454);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sessionValue);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.equationBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wireSpacingFactor);
            this.Controls.Add(this.wireSpacingValueBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wireDiameterFactor);
            this.Controls.Add(this.wireDiameterValueBox);
            this.Controls.Add(this.innerDiameterFactor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.innerDiameterValueBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.turnsValueBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circularLoopPictureBox);
            this.Controls.Add(this.closeButton);
            this.Name = "AirCoreInductanceCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spiral Inductance Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.circularLoopPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox wireDiameterFactor;
        private System.Windows.Forms.TextBox wireDiameterValueBox;
        private System.Windows.Forms.ComboBox innerDiameterFactor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox innerDiameterValueBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox turnsValueBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox circularLoopPictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox wireSpacingFactor;
        private System.Windows.Forms.TextBox wireSpacingValueBox;
        private System.Windows.Forms.ComboBox outerDiameterFactor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox outerDiameterValueBox;
        private System.Windows.Forms.ComboBox wireLengthFactor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox wireLengthValueBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox equationBox;
        private System.Windows.Forms.Label sessionValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}