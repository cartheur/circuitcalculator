namespace CircuitCalculator
{
    partial class MutualInductanceCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MutualInductanceCalculator));
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstRadiiValueBox = new System.Windows.Forms.TextBox();
            this.distanceValueBox = new System.Windows.Forms.TextBox();
            this.secondRadiiValueBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.alphaFunctionValueBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uResultBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.calculateFirstResultButton = new System.Windows.Forms.Button();
            this.alphaTableButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 302);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 23);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mutual inductance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Variable";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(355, 287);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(82, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "NOTE: All values are in cm.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "ri";
            // 
            // firstRadiiValueBox
            // 
            this.firstRadiiValueBox.Location = new System.Drawing.Point(284, 56);
            this.firstRadiiValueBox.Name = "firstRadiiValueBox";
            this.firstRadiiValueBox.Size = new System.Drawing.Size(47, 20);
            this.firstRadiiValueBox.TabIndex = 0;
            // 
            // distanceValueBox
            // 
            this.distanceValueBox.Location = new System.Drawing.Point(284, 110);
            this.distanceValueBox.Name = "distanceValueBox";
            this.distanceValueBox.Size = new System.Drawing.Size(47, 20);
            this.distanceValueBox.TabIndex = 2;
            // 
            // secondRadiiValueBox
            // 
            this.secondRadiiValueBox.Location = new System.Drawing.Point(284, 84);
            this.secondRadiiValueBox.Name = "secondRadiiValueBox";
            this.secondRadiiValueBox.Size = new System.Drawing.Size(47, 20);
            this.secondRadiiValueBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "rj";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "d";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "uH";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(268, 260);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(136, 20);
            this.resultBox.TabIndex = 7;
            // 
            // alphaFunctionValueBox
            // 
            this.alphaFunctionValueBox.Location = new System.Drawing.Point(337, 208);
            this.alphaFunctionValueBox.Name = "alphaFunctionValueBox";
            this.alphaFunctionValueBox.Size = new System.Drawing.Size(91, 20);
            this.alphaFunctionValueBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "alpha from table";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "this is the largest";
            // 
            // uResultBox
            // 
            this.uResultBox.Location = new System.Drawing.Point(284, 136);
            this.uResultBox.Name = "uResultBox";
            this.uResultBox.Size = new System.Drawing.Size(153, 20);
            this.uResultBox.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(259, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "u2";
            // 
            // calculateFirstResultButton
            // 
            this.calculateFirstResultButton.Location = new System.Drawing.Point(355, 162);
            this.calculateFirstResultButton.Name = "calculateFirstResultButton";
            this.calculateFirstResultButton.Size = new System.Drawing.Size(82, 23);
            this.calculateFirstResultButton.TabIndex = 3;
            this.calculateFirstResultButton.Text = "Calculate";
            this.calculateFirstResultButton.UseVisualStyleBackColor = true;
            this.calculateFirstResultButton.Click += new System.EventHandler(this.calculateFirstResultButton_Click);
            // 
            // alphaTableButton
            // 
            this.alphaTableButton.Location = new System.Drawing.Point(284, 185);
            this.alphaTableButton.Name = "alphaTableButton";
            this.alphaTableButton.Size = new System.Drawing.Size(43, 23);
            this.alphaTableButton.TabIndex = 38;
            this.alphaTableButton.Text = "Table";
            this.alphaTableButton.UseVisualStyleBackColor = true;
            this.alphaTableButton.Click += new System.EventHandler(this.alphaTableButton_Click);
            // 
            // MutualInductanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 336);
            this.Controls.Add(this.alphaTableButton);
            this.Controls.Add(this.calculateFirstResultButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.uResultBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.alphaFunctionValueBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.secondRadiiValueBox);
            this.Controls.Add(this.distanceValueBox);
            this.Controls.Add(this.firstRadiiValueBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeButton);
            this.Name = "MutualInductanceCalculator";
            this.Text = "Mutual Inductance Calculator";
            this.Load += new System.EventHandler(this.MutualInductanceCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstRadiiValueBox;
        private System.Windows.Forms.TextBox distanceValueBox;
        private System.Windows.Forms.TextBox secondRadiiValueBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox alphaFunctionValueBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox uResultBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button calculateFirstResultButton;
        private System.Windows.Forms.Button alphaTableButton;
    }
}