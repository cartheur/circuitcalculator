namespace CircuitCalculator.SubForms
{
    partial class CircularLoopGeometry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CircularLoopGeometry));
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.calculateVectorButton = new System.Windows.Forms.Button();
            this.geometryPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.geometryPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.Location = new System.Drawing.Point(232, 324);
            this.closeWindowButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(106, 24);
            this.closeWindowButton.TabIndex = 10;
            this.closeWindowButton.Text = "Close window";
            this.closeWindowButton.UseVisualStyleBackColor = true;
            this.closeWindowButton.Click += new System.EventHandler(this.closeWindowButton_Click);
            // 
            // calculateVectorButton
            // 
            this.calculateVectorButton.Location = new System.Drawing.Point(343, 325);
            this.calculateVectorButton.Name = "calculateVectorButton";
            this.calculateVectorButton.Size = new System.Drawing.Size(152, 23);
            this.calculateVectorButton.TabIndex = 9;
            this.calculateVectorButton.Text = "Calculate Vector Potential";
            this.calculateVectorButton.UseVisualStyleBackColor = true;
            this.calculateVectorButton.Click += new System.EventHandler(this.calculateVectorButton_Click);
            // 
            // geometryPictureBox
            // 
            this.geometryPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("geometryPictureBox.Image")));
            this.geometryPictureBox.Location = new System.Drawing.Point(5, 3);
            this.geometryPictureBox.Name = "geometryPictureBox";
            this.geometryPictureBox.Size = new System.Drawing.Size(490, 316);
            this.geometryPictureBox.TabIndex = 8;
            this.geometryPictureBox.TabStop = false;
            // 
            // CircularLoopGeometry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 356);
            this.Controls.Add(this.closeWindowButton);
            this.Controls.Add(this.calculateVectorButton);
            this.Controls.Add(this.geometryPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(522, 394);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(522, 394);
            this.Name = "CircularLoopGeometry";
            this.Text = "B-field on a loop";
            ((System.ComponentModel.ISupportInitialize)(this.geometryPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeWindowButton;
        private System.Windows.Forms.Button calculateVectorButton;
        private System.Windows.Forms.PictureBox geometryPictureBox;
    }
}