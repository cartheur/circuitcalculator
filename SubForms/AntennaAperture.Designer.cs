namespace CircuitCalculator
{
    partial class AntennaAperture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AntennaAperture));
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.apertureEquation = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lengthFactor = new System.Windows.Forms.ComboBox();
            this.wavelengthEntryBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultFactor = new System.Windows.Forms.ComboBox();
            this.apertureResultBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.apertureEquation)).BeginInit();
            this.SuspendLayout();
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.Location = new System.Drawing.Point(294, 258);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(96, 23);
            this.closeWindowButton.TabIndex = 0;
            this.closeWindowButton.Text = "Close Window";
            this.closeWindowButton.UseVisualStyleBackColor = true;
            this.closeWindowButton.Click += new System.EventHandler(this.closeWindowButton_Click);
            // 
            // apertureEquation
            // 
            this.apertureEquation.Image = ((System.Drawing.Image)(resources.GetObject("apertureEquation.Image")));
            this.apertureEquation.Location = new System.Drawing.Point(12, 12);
            this.apertureEquation.Name = "apertureEquation";
            this.apertureEquation.Size = new System.Drawing.Size(98, 74);
            this.apertureEquation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.apertureEquation.TabIndex = 1;
            this.apertureEquation.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wavelength";
            // 
            // lengthFactor
            // 
            this.lengthFactor.FormattingEnabled = true;
            this.lengthFactor.Items.AddRange(new object[] {
            "cm",
            "m"});
            this.lengthFactor.Location = new System.Drawing.Point(236, 28);
            this.lengthFactor.Name = "lengthFactor";
            this.lengthFactor.Size = new System.Drawing.Size(40, 21);
            this.lengthFactor.TabIndex = 28;
            // 
            // wavelengthEntryBox
            // 
            this.wavelengthEntryBox.Location = new System.Drawing.Point(130, 28);
            this.wavelengthEntryBox.Name = "wavelengthEntryBox";
            this.wavelengthEntryBox.Size = new System.Drawing.Size(100, 20);
            this.wavelengthEntryBox.TabIndex = 29;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(294, 66);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 30;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultFactor
            // 
            this.resultFactor.FormattingEnabled = true;
            this.resultFactor.Items.AddRange(new object[] {
            "cm",
            "m"});
            this.resultFactor.Location = new System.Drawing.Point(236, 65);
            this.resultFactor.Name = "resultFactor";
            this.resultFactor.Size = new System.Drawing.Size(40, 21);
            this.resultFactor.TabIndex = 31;
            // 
            // apertureResultBox
            // 
            this.apertureResultBox.Location = new System.Drawing.Point(130, 66);
            this.apertureResultBox.Name = "apertureResultBox";
            this.apertureResultBox.Size = new System.Drawing.Size(100, 20);
            this.apertureResultBox.TabIndex = 32;
            // 
            // AntennaAperture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 293);
            this.Controls.Add(this.apertureResultBox);
            this.Controls.Add(this.resultFactor);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.wavelengthEntryBox);
            this.Controls.Add(this.lengthFactor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apertureEquation);
            this.Controls.Add(this.closeWindowButton);
            this.Name = "AntennaAperture";
            this.Text = "Antenna Aperture";
            ((System.ComponentModel.ISupportInitialize)(this.apertureEquation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeWindowButton;
        private System.Windows.Forms.PictureBox apertureEquation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lengthFactor;
        private System.Windows.Forms.TextBox wavelengthEntryBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox resultFactor;
        private System.Windows.Forms.TextBox apertureResultBox;
    }
}