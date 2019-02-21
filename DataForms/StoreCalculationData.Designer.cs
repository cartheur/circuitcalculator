namespace CircuitCalculator
{
    partial class StoreCalculationData
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calculationDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.storeExperimentalDataButton = new System.Windows.Forms.Button();
            this.experimentalDataGridView = new System.Windows.Forms.DataGridView();
            this.sessionValue = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculationDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.experimentalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 552);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(147, 23);
            this.closeButton.TabIndex = 30;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calculationDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(13, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 215);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculation Data";
            // 
            // calculationDataGridView
            // 
            this.calculationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calculationDataGridView.Location = new System.Drawing.Point(101, 19);
            this.calculationDataGridView.Name = "calculationDataGridView";
            this.calculationDataGridView.Size = new System.Drawing.Size(405, 190);
            this.calculationDataGridView.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.storeExperimentalDataButton);
            this.groupBox2.Controls.Add(this.experimentalDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(13, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 246);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Experimental Data";
            // 
            // storeExperimentalDataButton
            // 
            this.storeExperimentalDataButton.Location = new System.Drawing.Point(355, 215);
            this.storeExperimentalDataButton.Name = "storeExperimentalDataButton";
            this.storeExperimentalDataButton.Size = new System.Drawing.Size(145, 23);
            this.storeExperimentalDataButton.TabIndex = 36;
            this.storeExperimentalDataButton.Text = "Store Experimental Data";
            this.storeExperimentalDataButton.UseVisualStyleBackColor = true;
            this.storeExperimentalDataButton.Click += new System.EventHandler(this.storeExperimentalDataButton_Click);
            // 
            // experimentalDataGridView
            // 
            this.experimentalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.experimentalDataGridView.Location = new System.Drawing.Point(95, 19);
            this.experimentalDataGridView.Name = "experimentalDataGridView";
            this.experimentalDataGridView.Size = new System.Drawing.Size(405, 190);
            this.experimentalDataGridView.TabIndex = 33;
            // 
            // sessionValue
            // 
            this.sessionValue.AutoSize = true;
            this.sessionValue.Location = new System.Drawing.Point(79, 21);
            this.sessionValue.Name = "sessionValue";
            this.sessionValue.Size = new System.Drawing.Size(0, 13);
            this.sessionValue.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Session ID:";
            // 
            // StoreCalculationData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 587);
            this.Controls.Add(this.sessionValue);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeButton);
            this.Name = "StoreCalculationData";
            this.Text = "Stored Calculations & Experiments";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calculationDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.experimentalDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView calculationDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView experimentalDataGridView;
        private System.Windows.Forms.Button storeExperimentalDataButton;
        private System.Windows.Forms.Label sessionValue;
        private System.Windows.Forms.Label label13;
    }
}