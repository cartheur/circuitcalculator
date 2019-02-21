namespace CircuitCalculator
{
    partial class GeometryCircularLoop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeometryCircularLoop));
            this.geometryPictureBox = new System.Windows.Forms.PictureBox();
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.calculateVectorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.geometryPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // geometryPictureBox
            // 
            this.geometryPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("geometryPictureBox.Image")));
            this.geometryPictureBox.Location = new System.Drawing.Point(12, 12);
            this.geometryPictureBox.Name = "geometryPictureBox";
            this.geometryPictureBox.Size = new System.Drawing.Size(485, 382);
            this.geometryPictureBox.TabIndex = 0;
            this.geometryPictureBox.TabStop = false;
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.closeWindowButton.Location = new System.Drawing.Point(12, 453);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(111, 22);
            this.closeWindowButton.TabIndex = 5;
            this.closeWindowButton.Text = "Close Window";
            this.closeWindowButton.UseVisualStyleBackColor = true;
            this.closeWindowButton.Click += new System.EventHandler(this.closeWindowButton_Click);
            // 
            // calculateVectorButton
            // 
            this.calculateVectorButton.Location = new System.Drawing.Point(129, 453);
            this.calculateVectorButton.Name = "calculateVectorButton";
            this.calculateVectorButton.Size = new System.Drawing.Size(152, 23);
            this.calculateVectorButton.TabIndex = 6;
            this.calculateVectorButton.Text = "Calculate Vector Potential";
            this.calculateVectorButton.UseVisualStyleBackColor = true;
            this.calculateVectorButton.Click += new System.EventHandler(this.calculateVectorButton_Click);
            // 
            // GeometryCircularLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 487);
            this.Controls.Add(this.calculateVectorButton);
            this.Controls.Add(this.closeWindowButton);
            this.Controls.Add(this.geometryPictureBox);
            this.Name = "GeometryCircularLoop";
            this.Text = "Geometry of a circular loop";
            ((System.ComponentModel.ISupportInitialize)(this.geometryPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox geometryPictureBox;
        private System.Windows.Forms.Button closeWindowButton;
        private System.Windows.Forms.Button calculateVectorButton;

    }
}