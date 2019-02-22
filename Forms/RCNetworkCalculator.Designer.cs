namespace CircuitCalculator
{
    partial class RCNetworkCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RCNetworkCalculator));
            this.resonanceEquationPictureBox = new System.Windows.Forms.PictureBox();
            this.resistanceValueBox = new System.Windows.Forms.TextBox();
            this.capacitanceValueBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.resistanceFactor = new System.Windows.Forms.ComboBox();
            this.capacitanceFactor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.stagesValueBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resonanceEquationPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // resonanceEquationPictureBox
            // 
            this.resonanceEquationPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("resonanceEquationPictureBox.Image")));
            this.resonanceEquationPictureBox.Location = new System.Drawing.Point(11, 149);
            this.resonanceEquationPictureBox.Name = "resonanceEquationPictureBox";
            this.resonanceEquationPictureBox.Size = new System.Drawing.Size(134, 50);
            this.resonanceEquationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.resonanceEquationPictureBox.TabIndex = 24;
            this.resonanceEquationPictureBox.TabStop = false;
            // 
            // resistanceValueBox
            // 
            this.resistanceValueBox.Location = new System.Drawing.Point(12, 65);
            this.resistanceValueBox.Multiline = true;
            this.resistanceValueBox.Name = "resistanceValueBox";
            this.resistanceValueBox.Size = new System.Drawing.Size(102, 40);
            this.resistanceValueBox.TabIndex = 0;
            // 
            // capacitanceValueBox
            // 
            this.capacitanceValueBox.Location = new System.Drawing.Point(187, 65);
            this.capacitanceValueBox.Multiline = true;
            this.capacitanceValueBox.Name = "capacitanceValueBox";
            this.capacitanceValueBox.Size = new System.Drawing.Size(103, 40);
            this.capacitanceValueBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hz";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(160, 168);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(130, 20);
            this.resultBox.TabIndex = 20;
            // 
            // resistanceFactor
            // 
            this.resistanceFactor.FormattingEnabled = true;
            this.resistanceFactor.Items.AddRange(new object[] {
            "Ω",
            "kΩ",
            "MΩ"});
            this.resistanceFactor.Location = new System.Drawing.Point(120, 65);
            this.resistanceFactor.Name = "resistanceFactor";
            this.resistanceFactor.Size = new System.Drawing.Size(61, 21);
            this.resistanceFactor.TabIndex = 1;
            // 
            // capacitanceFactor
            // 
            this.capacitanceFactor.FormattingEnabled = true;
            this.capacitanceFactor.Items.AddRange(new object[] {
            "uF",
            "nF",
            "pF"});
            this.capacitanceFactor.Location = new System.Drawing.Point(296, 65);
            this.capacitanceFactor.Name = "capacitanceFactor";
            this.capacitanceFactor.Size = new System.Drawing.Size(60, 21);
            this.capacitanceFactor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Resistance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Capacitance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Input the values for resistance and capacitance to find the resonance frequency";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(318, 140);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(80, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // stagesValueBox
            // 
            this.stagesValueBox.Location = new System.Drawing.Point(164, 118);
            this.stagesValueBox.Name = "stagesValueBox";
            this.stagesValueBox.Size = new System.Drawing.Size(126, 20);
            this.stagesValueBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Number of RC stages";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(296, 203);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(102, 23);
            this.closeButton.TabIndex = 27;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // RCNetworkCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 234);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stagesValueBox);
            this.Controls.Add(this.resonanceEquationPictureBox);
            this.Controls.Add(this.resistanceValueBox);
            this.Controls.Add(this.capacitanceValueBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.resistanceFactor);
            this.Controls.Add(this.capacitanceFactor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RCNetworkCalculator";
            this.Text = "RC Network Resonance Calculator";
            this.Load += new System.EventHandler(this.RCNetworkCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resonanceEquationPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox resonanceEquationPictureBox;
        private System.Windows.Forms.TextBox resistanceValueBox;
        private System.Windows.Forms.TextBox capacitanceValueBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.ComboBox resistanceFactor;
        private System.Windows.Forms.ComboBox capacitanceFactor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox stagesValueBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button closeButton;
    }
}