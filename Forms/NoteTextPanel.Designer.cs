namespace CircuitCalculator
{
    partial class NoteTextPanel
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
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.saveNotesButton = new System.Windows.Forms.Button();
            this.notifyLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(12, 32);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(328, 376);
            this.notesTextBox.TabIndex = 0;
            // 
            // saveNotesButton
            // 
            this.saveNotesButton.Location = new System.Drawing.Point(265, 3);
            this.saveNotesButton.Name = "saveNotesButton";
            this.saveNotesButton.Size = new System.Drawing.Size(75, 23);
            this.saveNotesButton.TabIndex = 1;
            this.saveNotesButton.Text = "Save Notes";
            this.saveNotesButton.UseVisualStyleBackColor = true;
            this.saveNotesButton.Click += new System.EventHandler(this.saveNotesButton_Click);
            // 
            // notifyLabel
            // 
            this.notifyLabel.AutoSize = true;
            this.notifyLabel.Location = new System.Drawing.Point(12, 8);
            this.notifyLabel.Name = "notifyLabel";
            this.notifyLabel.Size = new System.Drawing.Size(0, 13);
            this.notifyLabel.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(15, 416);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(62, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // NoteTextPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 451);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.notifyLabel);
            this.Controls.Add(this.saveNotesButton);
            this.Controls.Add(this.notesTextBox);
            this.Name = "NoteTextPanel";
            this.Text = "Notepad - Experimenter\'s Station";
            this.Load += new System.EventHandler(this.NoteTextPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Button saveNotesButton;
        private System.Windows.Forms.Label notifyLabel;
        private System.Windows.Forms.Button closeButton;

    }
}