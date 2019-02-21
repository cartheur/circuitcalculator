namespace CircuitCalculator.OtherForms
{
    partial class CartheurDocumentsList
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
            this.listDisplayBox = new System.Windows.Forms.RichTextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listDisplayBox
            // 
            this.listDisplayBox.Location = new System.Drawing.Point(12, 12);
            this.listDisplayBox.Name = "listDisplayBox";
            this.listDisplayBox.Size = new System.Drawing.Size(599, 202);
            this.listDisplayBox.TabIndex = 0;
            this.listDisplayBox.Text = "";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 220);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(91, 23);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // CartheurDocumentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 251);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.listDisplayBox);
            this.Name = "CartheurDocumentsList";
            this.Text = "Cartheur Documents";
            this.Load += new System.EventHandler(this.CartheurDocumentsList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox listDisplayBox;
        private System.Windows.Forms.Button closeButton;
    }
}