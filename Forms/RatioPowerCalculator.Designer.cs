namespace CircuitCalculator.Forms
{
    partial class RatioPowerCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatioPowerCalculator));
            this.closeButton = new System.Windows.Forms.Button();
            this.saveK1SelectionBox = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.ratioPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radiusPictureBox = new System.Windows.Forms.PictureBox();
            this.radiusFactor = new System.Windows.Forms.ComboBox();
            this.radiusValueBox = new System.Windows.Forms.TextBox();
            this.lambdaPictureBox = new System.Windows.Forms.PictureBox();
            this.distancePictureBox = new System.Windows.Forms.PictureBox();
            this.distanceFactor = new System.Windows.Forms.ComboBox();
            this.distanceValueBox = new System.Windows.Forms.TextBox();
            this.frequencyValueBox = new System.Windows.Forms.TextBox();
            this.omega_zeroPictureBox = new System.Windows.Forms.PictureBox();
            this.resonanceFrequencyUnit = new System.Windows.Forms.ComboBox();
            this.lambdaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lambdaUnits = new System.Windows.Forms.TextBox();
            this.waveVelocityUnit = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.waveVelocityValueBox = new System.Windows.Forms.TextBox();
            this.speedOfLightCheckBox = new System.Windows.Forms.CheckBox();
            this.ratioResultBox = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.peakEnergyResultBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ratioPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambdaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distancePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.omega_zeroPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(9, 444);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(143, 28);
            this.closeButton.TabIndex = 34;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveK1SelectionBox
            // 
            this.saveK1SelectionBox.AutoSize = true;
            this.saveK1SelectionBox.Location = new System.Drawing.Point(101, 228);
            this.saveK1SelectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.saveK1SelectionBox.Name = "saveK1SelectionBox";
            this.saveK1SelectionBox.Size = new System.Drawing.Size(102, 21);
            this.saveK1SelectionBox.TabIndex = 46;
            this.saveK1SelectionBox.Text = "Save Value";
            this.saveK1SelectionBox.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(450, 373);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 28);
            this.calculateButton.TabIndex = 45;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // ratioPictureBox
            // 
            this.ratioPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ratioPictureBox.Image")));
            this.ratioPictureBox.Location = new System.Drawing.Point(13, 44);
            this.ratioPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.ratioPictureBox.Name = "ratioPictureBox";
            this.ratioPictureBox.Size = new System.Drawing.Size(143, 69);
            this.ratioPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ratioPictureBox.TabIndex = 39;
            this.ratioPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Optimal power given a ratio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 297);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Peak energy density";
            // 
            // radiusPictureBox
            // 
            this.radiusPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("radiusPictureBox.Image")));
            this.radiusPictureBox.Location = new System.Drawing.Point(13, 132);
            this.radiusPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.radiusPictureBox.Name = "radiusPictureBox";
            this.radiusPictureBox.Size = new System.Drawing.Size(33, 38);
            this.radiusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.radiusPictureBox.TabIndex = 49;
            this.radiusPictureBox.TabStop = false;
            // 
            // radiusFactor
            // 
            this.radiusFactor.FormattingEnabled = true;
            this.radiusFactor.Items.AddRange(new object[] {
            "cm",
            "mm"});
            this.radiusFactor.Location = new System.Drawing.Point(197, 140);
            this.radiusFactor.Margin = new System.Windows.Forms.Padding(4);
            this.radiusFactor.Name = "radiusFactor";
            this.radiusFactor.Size = new System.Drawing.Size(76, 24);
            this.radiusFactor.TabIndex = 56;
            // 
            // radiusValueBox
            // 
            this.radiusValueBox.Location = new System.Drawing.Point(65, 140);
            this.radiusValueBox.Margin = new System.Windows.Forms.Padding(4);
            this.radiusValueBox.Name = "radiusValueBox";
            this.radiusValueBox.Size = new System.Drawing.Size(124, 22);
            this.radiusValueBox.TabIndex = 55;
            // 
            // lambdaPictureBox
            // 
            this.lambdaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("lambdaPictureBox.Image")));
            this.lambdaPictureBox.Location = new System.Drawing.Point(13, 178);
            this.lambdaPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.lambdaPictureBox.Name = "lambdaPictureBox";
            this.lambdaPictureBox.Size = new System.Drawing.Size(33, 38);
            this.lambdaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lambdaPictureBox.TabIndex = 57;
            this.lambdaPictureBox.TabStop = false;
            // 
            // distancePictureBox
            // 
            this.distancePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("distancePictureBox.Image")));
            this.distancePictureBox.Location = new System.Drawing.Point(13, 374);
            this.distancePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.distancePictureBox.Name = "distancePictureBox";
            this.distancePictureBox.Size = new System.Drawing.Size(33, 38);
            this.distancePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.distancePictureBox.TabIndex = 58;
            this.distancePictureBox.TabStop = false;
            // 
            // distanceFactor
            // 
            this.distanceFactor.FormattingEnabled = true;
            this.distanceFactor.Items.AddRange(new object[] {
            "cm",
            "mm"});
            this.distanceFactor.Location = new System.Drawing.Point(161, 381);
            this.distanceFactor.Margin = new System.Windows.Forms.Padding(4);
            this.distanceFactor.Name = "distanceFactor";
            this.distanceFactor.Size = new System.Drawing.Size(76, 24);
            this.distanceFactor.TabIndex = 60;
            // 
            // distanceValueBox
            // 
            this.distanceValueBox.Location = new System.Drawing.Point(65, 382);
            this.distanceValueBox.Margin = new System.Windows.Forms.Padding(4);
            this.distanceValueBox.Name = "distanceValueBox";
            this.distanceValueBox.Size = new System.Drawing.Size(87, 22);
            this.distanceValueBox.TabIndex = 59;
            // 
            // frequencyValueBox
            // 
            this.frequencyValueBox.Location = new System.Drawing.Point(306, 51);
            this.frequencyValueBox.Margin = new System.Windows.Forms.Padding(4);
            this.frequencyValueBox.Name = "frequencyValueBox";
            this.frequencyValueBox.Size = new System.Drawing.Size(136, 22);
            this.frequencyValueBox.TabIndex = 61;
            // 
            // omega_zeroPictureBox
            // 
            this.omega_zeroPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("omega_zeroPictureBox.Image")));
            this.omega_zeroPictureBox.Location = new System.Drawing.Point(257, 42);
            this.omega_zeroPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.omega_zeroPictureBox.Name = "omega_zeroPictureBox";
            this.omega_zeroPictureBox.Size = new System.Drawing.Size(40, 38);
            this.omega_zeroPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.omega_zeroPictureBox.TabIndex = 63;
            this.omega_zeroPictureBox.TabStop = false;
            // 
            // resonanceFrequencyUnit
            // 
            this.resonanceFrequencyUnit.FormattingEnabled = true;
            this.resonanceFrequencyUnit.Items.AddRange(new object[] {
            "MHz",
            "kHz",
            "Hz"});
            this.resonanceFrequencyUnit.Location = new System.Drawing.Point(450, 51);
            this.resonanceFrequencyUnit.Margin = new System.Windows.Forms.Padding(4);
            this.resonanceFrequencyUnit.Name = "resonanceFrequencyUnit";
            this.resonanceFrequencyUnit.Size = new System.Drawing.Size(68, 24);
            this.resonanceFrequencyUnit.TabIndex = 64;
            // 
            // lambdaTextBox
            // 
            this.lambdaTextBox.Location = new System.Drawing.Point(66, 186);
            this.lambdaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lambdaTextBox.Name = "lambdaTextBox";
            this.lambdaTextBox.ReadOnly = true;
            this.lambdaTextBox.Size = new System.Drawing.Size(123, 22);
            this.lambdaTextBox.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Input frequency and wave speed to derive lambda";
            // 
            // lambdaUnits
            // 
            this.lambdaUnits.Location = new System.Drawing.Point(197, 186);
            this.lambdaUnits.Margin = new System.Windows.Forms.Padding(4);
            this.lambdaUnits.Name = "lambdaUnits";
            this.lambdaUnits.ReadOnly = true;
            this.lambdaUnits.Size = new System.Drawing.Size(76, 22);
            this.lambdaUnits.TabIndex = 68;
            // 
            // waveVelocityUnit
            // 
            this.waveVelocityUnit.FormattingEnabled = true;
            this.waveVelocityUnit.Items.AddRange(new object[] {
            "m/s",
            "cm/s"});
            this.waveVelocityUnit.Location = new System.Drawing.Point(450, 97);
            this.waveVelocityUnit.Margin = new System.Windows.Forms.Padding(4);
            this.waveVelocityUnit.Name = "waveVelocityUnit";
            this.waveVelocityUnit.Size = new System.Drawing.Size(68, 24);
            this.waveVelocityUnit.TabIndex = 71;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(257, 88);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // waveVelocityValueBox
            // 
            this.waveVelocityValueBox.Location = new System.Drawing.Point(306, 97);
            this.waveVelocityValueBox.Margin = new System.Windows.Forms.Padding(4);
            this.waveVelocityValueBox.Name = "waveVelocityValueBox";
            this.waveVelocityValueBox.Size = new System.Drawing.Size(136, 22);
            this.waveVelocityValueBox.TabIndex = 69;
            // 
            // speedOfLightCheckBox
            // 
            this.speedOfLightCheckBox.AutoSize = true;
            this.speedOfLightCheckBox.Location = new System.Drawing.Point(306, 132);
            this.speedOfLightCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.speedOfLightCheckBox.Name = "speedOfLightCheckBox";
            this.speedOfLightCheckBox.Size = new System.Drawing.Size(117, 21);
            this.speedOfLightCheckBox.TabIndex = 72;
            this.speedOfLightCheckBox.Text = "Speed of light";
            this.speedOfLightCheckBox.UseVisualStyleBackColor = true;
            // 
            // ratioResultBox
            // 
            this.ratioResultBox.Location = new System.Drawing.Point(384, 226);
            this.ratioResultBox.Name = "ratioResultBox";
            this.ratioResultBox.Size = new System.Drawing.Size(134, 22);
            this.ratioResultBox.TabIndex = 73;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(323, 217);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // peakEnergyResultBox
            // 
            this.peakEnergyResultBox.Location = new System.Drawing.Point(384, 291);
            this.peakEnergyResultBox.Name = "peakEnergyResultBox";
            this.peakEnergyResultBox.Size = new System.Drawing.Size(134, 22);
            this.peakEnergyResultBox.TabIndex = 75;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(323, 281);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 76;
            this.pictureBox4.TabStop = false;
            // 
            // RatioPowerCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 494);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.peakEnergyResultBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ratioResultBox);
            this.Controls.Add(this.speedOfLightCheckBox);
            this.Controls.Add(this.waveVelocityUnit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.waveVelocityValueBox);
            this.Controls.Add(this.lambdaUnits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lambdaTextBox);
            this.Controls.Add(this.resonanceFrequencyUnit);
            this.Controls.Add(this.omega_zeroPictureBox);
            this.Controls.Add(this.frequencyValueBox);
            this.Controls.Add(this.distanceFactor);
            this.Controls.Add(this.distanceValueBox);
            this.Controls.Add(this.distancePictureBox);
            this.Controls.Add(this.lambdaPictureBox);
            this.Controls.Add(this.radiusFactor);
            this.Controls.Add(this.radiusValueBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radiusPictureBox);
            this.Controls.Add(this.saveK1SelectionBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.ratioPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(590, 539);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(590, 539);
            this.Name = "RatioPowerCalculator";
            this.Text = "Ratio-Power Calculator";
            this.Load += new System.EventHandler(this.RatioPowerCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ratioPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambdaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distancePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.omega_zeroPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.CheckBox saveK1SelectionBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.PictureBox ratioPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox radiusPictureBox;
        private System.Windows.Forms.ComboBox radiusFactor;
        private System.Windows.Forms.TextBox radiusValueBox;
        private System.Windows.Forms.PictureBox lambdaPictureBox;
        private System.Windows.Forms.PictureBox distancePictureBox;
        private System.Windows.Forms.ComboBox distanceFactor;
        private System.Windows.Forms.TextBox distanceValueBox;
        private System.Windows.Forms.TextBox frequencyValueBox;
        private System.Windows.Forms.PictureBox omega_zeroPictureBox;
        private System.Windows.Forms.ComboBox resonanceFrequencyUnit;
        private System.Windows.Forms.TextBox lambdaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lambdaUnits;
        private System.Windows.Forms.ComboBox waveVelocityUnit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox waveVelocityValueBox;
        private System.Windows.Forms.CheckBox speedOfLightCheckBox;
        private System.Windows.Forms.TextBox ratioResultBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox peakEnergyResultBox;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}