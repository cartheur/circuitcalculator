namespace CircuitCalculator
{
    partial class MatrixViewer
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
            this.closeButton = new System.Windows.Forms.Button();
            this.plotDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshDataButton = new System.Windows.Forms.Button();
            this.loadDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.plotDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 376);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(51, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // plotDataGridView
            // 
            this.plotDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plotDataGridView.Location = new System.Drawing.Point(12, 12);
            this.plotDataGridView.Name = "plotDataGridView";
            this.plotDataGridView.Size = new System.Drawing.Size(193, 358);
            this.plotDataGridView.TabIndex = 1;
            // 
            // refreshDataButton
            // 
            this.refreshDataButton.Location = new System.Drawing.Point(151, 376);
            this.refreshDataButton.Name = "refreshDataButton";
            this.refreshDataButton.Size = new System.Drawing.Size(54, 23);
            this.refreshDataButton.TabIndex = 2;
            this.refreshDataButton.Text = "Refresh";
            this.refreshDataButton.UseVisualStyleBackColor = true;
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(80, 376);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(51, 23);
            this.loadDataButton.TabIndex = 3;
            this.loadDataButton.Text = "Load";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // MatrixViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 407);
            this.Controls.Add(this.loadDataButton);
            this.Controls.Add(this.refreshDataButton);
            this.Controls.Add(this.plotDataGridView);
            this.Controls.Add(this.closeButton);
            this.Name = "MatrixViewer";
            this.Text = "Plot Data";
            ((System.ComponentModel.ISupportInitialize)(this.plotDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView plotDataGridView;
        private System.Windows.Forms.Button refreshDataButton;
        private System.Windows.Forms.Button loadDataButton;
    }
}