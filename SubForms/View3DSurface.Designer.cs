namespace CircuitCalculator
{
    partial class View3DSurface
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
            this.tbHue = new System.Windows.Forms.TrackBar();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.plotButton = new System.Windows.Forms.Button();
            this.plotDataGridView = new System.Windows.Forms.DataGridView();
            this.viewGridButton = new System.Windows.Forms.Button();
            this.hideGridButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHue
            // 
            this.tbHue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbHue.Location = new System.Drawing.Point(0, 517);
            this.tbHue.Maximum = 360;
            this.tbHue.Name = "tbHue";
            this.tbHue.Size = new System.Drawing.Size(962, 45);
            this.tbHue.TabIndex = 1;
            this.tbHue.TickFrequency = 20;
            this.tbHue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbHue.Value = 10;
            this.tbHue.Scroll += new System.EventHandler(this.tbHue_Scroll);
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(814, 517);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(65, 23);
            this.loadDataButton.TabIndex = 14;
            this.loadDataButton.Text = "Load Data";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // plotButton
            // 
            this.plotButton.Location = new System.Drawing.Point(885, 517);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(65, 23);
            this.plotButton.TabIndex = 13;
            this.plotButton.Text = "Plot Data";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // plotDataGridView
            // 
            this.plotDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plotDataGridView.Location = new System.Drawing.Point(575, 7);
            this.plotDataGridView.Name = "plotDataGridView";
            this.plotDataGridView.Size = new System.Drawing.Size(375, 504);
            this.plotDataGridView.TabIndex = 15;
            // 
            // viewGridButton
            // 
            this.viewGridButton.Location = new System.Drawing.Point(743, 517);
            this.viewGridButton.Name = "viewGridButton";
            this.viewGridButton.Size = new System.Drawing.Size(65, 23);
            this.viewGridButton.TabIndex = 16;
            this.viewGridButton.Text = "View Grid";
            this.viewGridButton.UseVisualStyleBackColor = true;
            this.viewGridButton.Click += new System.EventHandler(this.viewGridButton_Click);
            // 
            // hideGridButton
            // 
            this.hideGridButton.Location = new System.Drawing.Point(672, 517);
            this.hideGridButton.Name = "hideGridButton";
            this.hideGridButton.Size = new System.Drawing.Size(65, 23);
            this.hideGridButton.TabIndex = 17;
            this.hideGridButton.Text = "Hide Grid";
            this.hideGridButton.UseVisualStyleBackColor = true;
            this.hideGridButton.Click += new System.EventHandler(this.hideGridButton_Click);
            // 
            // View3DSurface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 562);
            this.Controls.Add(this.hideGridButton);
            this.Controls.Add(this.viewGridButton);
            this.Controls.Add(this.plotDataGridView);
            this.Controls.Add(this.loadDataButton);
            this.Controls.Add(this.plotButton);
            this.Controls.Add(this.tbHue);
            this.Name = "View3DSurface";
            this.ShowIcon = false;
            this.Text = "Plot 3D Surface";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.View3DSurface_Paint);
            this.Resize += new System.EventHandler(this.View3DSurface_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tbHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbHue;
        public System.Windows.Forms.Button loadDataButton;
        public System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.DataGridView plotDataGridView;
        public System.Windows.Forms.Button viewGridButton;
        public System.Windows.Forms.Button hideGridButton;
    }
}