namespace CircuitCalculator.SubForms
{
    partial class PythagoreanCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PythagoreanCalculator));
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radiusInputBox = new System.Windows.Forms.TextBox();
            this.distanceInputBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hypotenuseSolution = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.calculateHypotenuseButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.currentInputBox = new System.Windows.Forms.TextBox();
            this.propagationAngleInputBox = new System.Windows.Forms.TextBox();
            this.calculateFieldButton = new System.Windows.Forms.Button();
            this.emittedFieldSolutionBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.alphaInputBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.calculatePeakPowerPositionButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.peakPowerPositionSolutionBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 496);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(99, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Field emitted by a loop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Solve for d";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Radius of coils";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Distance between coils";
            // 
            // radiusInputBox
            // 
            this.radiusInputBox.Location = new System.Drawing.Point(354, 46);
            this.radiusInputBox.Name = "radiusInputBox";
            this.radiusInputBox.Size = new System.Drawing.Size(65, 20);
            this.radiusInputBox.TabIndex = 17;
            // 
            // distanceInputBox
            // 
            this.distanceInputBox.Location = new System.Drawing.Point(354, 70);
            this.distanceInputBox.Name = "distanceInputBox";
            this.distanceInputBox.Size = new System.Drawing.Size(65, 20);
            this.distanceInputBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "cm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "cm";
            // 
            // hypotenuseSolution
            // 
            this.hypotenuseSolution.Location = new System.Drawing.Point(313, 94);
            this.hypotenuseSolution.Name = "hypotenuseSolution";
            this.hypotenuseSolution.Size = new System.Drawing.Size(106, 20);
            this.hypotenuseSolution.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "cm";
            // 
            // calculateHypotenuseButton
            // 
            this.calculateHypotenuseButton.Location = new System.Drawing.Point(354, 121);
            this.calculateHypotenuseButton.Name = "calculateHypotenuseButton";
            this.calculateHypotenuseButton.Size = new System.Drawing.Size(65, 23);
            this.calculateHypotenuseButton.TabIndex = 23;
            this.calculateHypotenuseButton.Text = "Calculate";
            this.calculateHypotenuseButton.UseVisualStyleBackColor = true;
            this.calculateHypotenuseButton.Click += new System.EventHandler(this.CalculateHypotenuseButtonClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Current";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Propagation angle";
            // 
            // currentInputBox
            // 
            this.currentInputBox.Location = new System.Drawing.Point(149, 380);
            this.currentInputBox.Name = "currentInputBox";
            this.currentInputBox.Size = new System.Drawing.Size(65, 20);
            this.currentInputBox.TabIndex = 26;
            // 
            // propagationAngleInputBox
            // 
            this.propagationAngleInputBox.Location = new System.Drawing.Point(149, 402);
            this.propagationAngleInputBox.Name = "propagationAngleInputBox";
            this.propagationAngleInputBox.Size = new System.Drawing.Size(65, 20);
            this.propagationAngleInputBox.TabIndex = 27;
            // 
            // calculateFieldButton
            // 
            this.calculateFieldButton.Location = new System.Drawing.Point(132, 456);
            this.calculateFieldButton.Name = "calculateFieldButton";
            this.calculateFieldButton.Size = new System.Drawing.Size(65, 23);
            this.calculateFieldButton.TabIndex = 28;
            this.calculateFieldButton.Text = "Calculate";
            this.calculateFieldButton.UseVisualStyleBackColor = true;
            this.calculateFieldButton.Click += new System.EventHandler(this.CalculateFieldButtonClick);
            // 
            // emittedFieldSolutionBox
            // 
            this.emittedFieldSolutionBox.Location = new System.Drawing.Point(44, 427);
            this.emittedFieldSolutionBox.Name = "emittedFieldSolutionBox";
            this.emittedFieldSolutionBox.Size = new System.Drawing.Size(170, 20);
            this.emittedFieldSolutionBox.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Field";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(220, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Gauss";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(220, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "deg";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(220, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "A";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(329, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(234, 184);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(90, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(364, 240);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(231, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Peak power position";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(233, 256);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Symmetric circuit when";
            // 
            // alphaInputBox
            // 
            this.alphaInputBox.Location = new System.Drawing.Point(354, 306);
            this.alphaInputBox.Name = "alphaInputBox";
            this.alphaInputBox.Size = new System.Drawing.Size(65, 20);
            this.alphaInputBox.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(310, 309);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Alpha";
            // 
            // calculatePeakPowerPositionButton
            // 
            this.calculatePeakPowerPositionButton.Location = new System.Drawing.Point(354, 332);
            this.calculatePeakPowerPositionButton.Name = "calculatePeakPowerPositionButton";
            this.calculatePeakPowerPositionButton.Size = new System.Drawing.Size(65, 23);
            this.calculatePeakPowerPositionButton.TabIndex = 41;
            this.calculatePeakPowerPositionButton.Text = "Calculate";
            this.calculatePeakPowerPositionButton.UseVisualStyleBackColor = true;
            this.calculatePeakPowerPositionButton.Click += new System.EventHandler(this.CalculatePeakPowerPositionButtonClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(426, 366);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "cm";
            // 
            // peakPowerPositionSolutionBox
            // 
            this.peakPowerPositionSolutionBox.Location = new System.Drawing.Point(313, 361);
            this.peakPowerPositionSolutionBox.Name = "peakPowerPositionSolutionBox";
            this.peakPowerPositionSolutionBox.Size = new System.Drawing.Size(106, 20);
            this.peakPowerPositionSolutionBox.TabIndex = 42;
            // 
            // PythagoreanCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 522);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.peakPowerPositionSolutionBox);
            this.Controls.Add(this.calculatePeakPowerPositionButton);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.alphaInputBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.emittedFieldSolutionBox);
            this.Controls.Add(this.calculateFieldButton);
            this.Controls.Add(this.propagationAngleInputBox);
            this.Controls.Add(this.currentInputBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.calculateHypotenuseButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hypotenuseSolution);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.distanceInputBox);
            this.Controls.Add(this.radiusInputBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeButton);
            this.Name = "PythagoreanCalculator";
            this.Text = "Pythagorean Flux Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox radiusInputBox;
        private System.Windows.Forms.TextBox distanceInputBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hypotenuseSolution;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calculateHypotenuseButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox currentInputBox;
        private System.Windows.Forms.TextBox propagationAngleInputBox;
        private System.Windows.Forms.Button calculateFieldButton;
        private System.Windows.Forms.TextBox emittedFieldSolutionBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox alphaInputBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button calculatePeakPowerPositionButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox peakPowerPositionSolutionBox;
    }
}