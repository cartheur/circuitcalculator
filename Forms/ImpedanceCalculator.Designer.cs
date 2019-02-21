namespace CircuitCalculator
{
    partial class ImpedanceCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImpedanceCalculator));
            this.closeButton = new System.Windows.Forms.Button();
            this.calculateButtonEquivalent = new System.Windows.Forms.Button();
            this.calculateButtonWiki = new System.Windows.Forms.Button();
            this.calculateButtonFreeSpace = new System.Windows.Forms.Button();
            this.resultBoxFreeSpace = new System.Windows.Forms.TextBox();
            this.inductanceValueBox = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.qualityEquationWPC = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.relativePermeabilityMediumTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityEquationWPC)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 558);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(102, 23);
            this.closeButton.TabIndex = 19;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // calculateButtonEquivalent
            // 
            this.calculateButtonEquivalent.Location = new System.Drawing.Point(427, 395);
            this.calculateButtonEquivalent.Name = "calculateButtonEquivalent";
            this.calculateButtonEquivalent.Size = new System.Drawing.Size(75, 23);
            this.calculateButtonEquivalent.TabIndex = 60;
            this.calculateButtonEquivalent.Text = "Calculate";
            this.calculateButtonEquivalent.UseVisualStyleBackColor = true;
            // 
            // calculateButtonWiki
            // 
            this.calculateButtonWiki.Location = new System.Drawing.Point(427, 366);
            this.calculateButtonWiki.Name = "calculateButtonWiki";
            this.calculateButtonWiki.Size = new System.Drawing.Size(75, 23);
            this.calculateButtonWiki.TabIndex = 59;
            this.calculateButtonWiki.Text = "Calculate";
            this.calculateButtonWiki.UseVisualStyleBackColor = true;
            // 
            // calculateButtonFreeSpace
            // 
            this.calculateButtonFreeSpace.Location = new System.Drawing.Point(427, 90);
            this.calculateButtonFreeSpace.Name = "calculateButtonFreeSpace";
            this.calculateButtonFreeSpace.Size = new System.Drawing.Size(75, 23);
            this.calculateButtonFreeSpace.TabIndex = 58;
            this.calculateButtonFreeSpace.Text = "Calculate";
            this.calculateButtonFreeSpace.UseVisualStyleBackColor = true;
            this.calculateButtonFreeSpace.Click += new System.EventHandler(this.calculateButtonFreeSpace_Click);
            // 
            // resultBoxFreeSpace
            // 
            this.resultBoxFreeSpace.Location = new System.Drawing.Point(402, 142);
            this.resultBoxFreeSpace.Name = "resultBoxFreeSpace";
            this.resultBoxFreeSpace.Size = new System.Drawing.Size(100, 20);
            this.resultBoxFreeSpace.TabIndex = 68;
            // 
            // inductanceValueBox
            // 
            this.inductanceValueBox.Location = new System.Drawing.Point(182, 128);
            this.inductanceValueBox.Name = "inductanceValueBox";
            this.inductanceValueBox.Size = new System.Drawing.Size(100, 20);
            this.inductanceValueBox.TabIndex = 67;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(147, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 65;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(147, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // qualityEquationWPC
            // 
            this.qualityEquationWPC.Image = ((System.Drawing.Image)(resources.GetObject("qualityEquationWPC.Image")));
            this.qualityEquationWPC.Location = new System.Drawing.Point(15, 95);
            this.qualityEquationWPC.Name = "qualityEquationWPC";
            this.qualityEquationWPC.Size = new System.Drawing.Size(100, 67);
            this.qualityEquationWPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qualityEquationWPC.TabIndex = 63;
            this.qualityEquationWPC.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Impedence of free-space";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(129, 13);
            this.infoLabel.TabIndex = 61;
            this.infoLabel.Text = "The Nature of Impedence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "H/m";
            // 
            // relativePermeabilityMediumTextBox
            // 
            this.relativePermeabilityMediumTextBox.Location = new System.Drawing.Point(182, 92);
            this.relativePermeabilityMediumTextBox.Name = "relativePermeabilityMediumTextBox";
            this.relativePermeabilityMediumTextBox.Size = new System.Drawing.Size(100, 20);
            this.relativePermeabilityMediumTextBox.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "H/m";
            // 
            // ImpedanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.relativePermeabilityMediumTextBox);
            this.Controls.Add(this.resultBoxFreeSpace);
            this.Controls.Add(this.inductanceValueBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.qualityEquationWPC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.calculateButtonEquivalent);
            this.Controls.Add(this.calculateButtonWiki);
            this.Controls.Add(this.calculateButtonFreeSpace);
            this.Controls.Add(this.closeButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImpedanceCalculator";
            this.Text = "Impedence Calculator";
            this.Load += new System.EventHandler(this.impedanceCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityEquationWPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button calculateButtonEquivalent;
        private System.Windows.Forms.Button calculateButtonWiki;
        private System.Windows.Forms.Button calculateButtonFreeSpace;
        private System.Windows.Forms.TextBox resultBoxFreeSpace;
        private System.Windows.Forms.TextBox inductanceValueBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox qualityEquationWPC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox relativePermeabilityMediumTextBox;
        private System.Windows.Forms.Label label1;
    }
}