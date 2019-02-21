namespace CircuitCalculator
{
    partial class EquationValues
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
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.equationOneSelection = new System.Windows.Forms.CheckBox();
            this.equationTwoSelection = new System.Windows.Forms.CheckBox();
            this.plotButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.Location = new System.Drawing.Point(12, 479);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(75, 23);
            this.closeWindowButton.TabIndex = 0;
            this.closeWindowButton.Text = "Close";
            this.closeWindowButton.UseVisualStyleBackColor = true;
            this.closeWindowButton.Click += new System.EventHandler(this.closeWindowButton_Click);
            // 
            // equationOneSelection
            // 
            this.equationOneSelection.AutoSize = true;
            this.equationOneSelection.Location = new System.Drawing.Point(24, 22);
            this.equationOneSelection.Name = "equationOneSelection";
            this.equationOneSelection.Size = new System.Drawing.Size(52, 17);
            this.equationOneSelection.TabIndex = 2;
            this.equationOneSelection.Text = "Fig. 9";
            this.equationOneSelection.UseVisualStyleBackColor = true;
            this.equationOneSelection.CheckedChanged += new System.EventHandler(this.equationOneSelection_CheckedChanged);
            // 
            // equationTwoSelection
            // 
            this.equationTwoSelection.AutoSize = true;
            this.equationTwoSelection.Location = new System.Drawing.Point(24, 45);
            this.equationTwoSelection.Name = "equationTwoSelection";
            this.equationTwoSelection.Size = new System.Drawing.Size(58, 17);
            this.equationTwoSelection.TabIndex = 3;
            this.equationTwoSelection.Text = "Fig. 10";
            this.equationTwoSelection.UseVisualStyleBackColor = true;
            // 
            // plotButton
            // 
            this.plotButton.Location = new System.Drawing.Point(21, 68);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(51, 23);
            this.plotButton.TabIndex = 4;
            this.plotButton.Text = "Plot";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Equations, by number, from papers:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.equationTwoSelection);
            this.groupBox1.Controls.Add(this.equationOneSelection);
            this.groupBox1.Controls.Add(this.plotButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IJ Power and Energy";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(9, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cyber Systems and Man";
            // 
            // EquationValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 514);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeWindowButton);
            this.Name = "EquationValues";
            this.Text = "Equation Values";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeWindowButton;
        private System.Windows.Forms.CheckBox equationOneSelection;
        private System.Windows.Forms.CheckBox equationTwoSelection;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}