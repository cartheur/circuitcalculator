namespace CircuitCalculator
{
    partial class StoreExperimentalData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreExperimentalData));
            this.closeButton = new System.Windows.Forms.Button();
            this.sessionValue = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frequencyUnit = new System.Windows.Forms.ComboBox();
            this.storeOscillatorData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.experimentBatchSelection = new System.Windows.Forms.ComboBox();
            this.measuredResonanceFrequencyInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oscillatorPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.antennaPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oscillatorPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.antennaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 411);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(147, 23);
            this.closeButton.TabIndex = 31;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // sessionValue
            // 
            this.sessionValue.AutoSize = true;
            this.sessionValue.Location = new System.Drawing.Point(80, 9);
            this.sessionValue.Name = "sessionValue";
            this.sessionValue.Size = new System.Drawing.Size(0, 13);
            this.sessionValue.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Session ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frequencyUnit);
            this.groupBox1.Controls.Add(this.storeOscillatorData);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.experimentBatchSelection);
            this.groupBox1.Controls.Add(this.measuredResonanceFrequencyInputBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.oscillatorPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 162);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Push-Pull Oscillator";
            // 
            // frequencyUnit
            // 
            this.frequencyUnit.FormattingEnabled = true;
            this.frequencyUnit.Items.AddRange(new object[] {
            "MHz",
            "kHz",
            "Hz"});
            this.frequencyUnit.Location = new System.Drawing.Point(240, 104);
            this.frequencyUnit.Name = "frequencyUnit";
            this.frequencyUnit.Size = new System.Drawing.Size(52, 21);
            this.frequencyUnit.TabIndex = 7;
            // 
            // storeOscillatorData
            // 
            this.storeOscillatorData.Location = new System.Drawing.Point(335, 133);
            this.storeOscillatorData.Name = "storeOscillatorData";
            this.storeOscillatorData.Size = new System.Drawing.Size(75, 23);
            this.storeOscillatorData.TabIndex = 6;
            this.storeOscillatorData.Text = "Store";
            this.storeOscillatorData.UseVisualStyleBackColor = true;
            this.storeOscillatorData.Click += new System.EventHandler(this.storeOscillatorData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Experiment Batch Number";
            // 
            // experimentBatchSelection
            // 
            this.experimentBatchSelection.FormattingEnabled = true;
            this.experimentBatchSelection.Items.AddRange(new object[] {
            "A01",
            "A02",
            "A03",
            "A04",
            "A05",
            "A06",
            "A07",
            "More..."});
            this.experimentBatchSelection.Location = new System.Drawing.Point(139, 51);
            this.experimentBatchSelection.Name = "experimentBatchSelection";
            this.experimentBatchSelection.Size = new System.Drawing.Size(74, 21);
            this.experimentBatchSelection.TabIndex = 4;
            // 
            // measuredResonanceFrequencyInputBox
            // 
            this.measuredResonanceFrequencyInputBox.Location = new System.Drawing.Point(139, 104);
            this.measuredResonanceFrequencyInputBox.Name = "measuredResonanceFrequencyInputBox";
            this.measuredResonanceFrequencyInputBox.Size = new System.Drawing.Size(88, 20);
            this.measuredResonanceFrequencyInputBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Measured Resonant Frequency";
            // 
            // oscillatorPictureBox
            // 
            this.oscillatorPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("oscillatorPictureBox.Image")));
            this.oscillatorPictureBox.Location = new System.Drawing.Point(6, 31);
            this.oscillatorPictureBox.Name = "oscillatorPictureBox";
            this.oscillatorPictureBox.Size = new System.Drawing.Size(96, 72);
            this.oscillatorPictureBox.TabIndex = 0;
            this.oscillatorPictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.antennaPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 165);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Antenna";
            // 
            // antennaPictureBox
            // 
            this.antennaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("antennaPictureBox.Image")));
            this.antennaPictureBox.Location = new System.Drawing.Point(6, 23);
            this.antennaPictureBox.Name = "antennaPictureBox";
            this.antennaPictureBox.Size = new System.Drawing.Size(65, 113);
            this.antennaPictureBox.TabIndex = 0;
            this.antennaPictureBox.TabStop = false;
            // 
            // StoreExperimentalData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 444);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sessionValue);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.closeButton);
            this.Name = "StoreExperimentalData";
            this.Text = "Store Experimental Data";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oscillatorPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.antennaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label sessionValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox oscillatorPictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox antennaPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox measuredResonanceFrequencyInputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox experimentBatchSelection;
        private System.Windows.Forms.Button storeOscillatorData;
        private System.Windows.Forms.ComboBox frequencyUnit;
    }
}