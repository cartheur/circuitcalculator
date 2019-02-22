namespace CircuitCalculator
{
    partial class PlotDataForm
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
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl = new ZedGraph.ZedGraphControl();
            this.testCalcButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newPlotButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.plotTwoSelection = new System.Windows.Forms.CheckBox();
            this.plotOneSelection = new System.Windows.Forms.CheckBox();
            this.plotButton2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.plotButton = new System.Windows.Forms.Button();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.plotDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.threeDimPlotButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // zedGraphControl
            // 
            this.zedGraphControl.Location = new System.Drawing.Point(12, 12);
            this.zedGraphControl.Name = "zedGraphControl";
            this.zedGraphControl.ScrollGrace = 0;
            this.zedGraphControl.ScrollMaxX = 0;
            this.zedGraphControl.ScrollMaxY = 0;
            this.zedGraphControl.ScrollMaxY2 = 0;
            this.zedGraphControl.ScrollMinX = 0;
            this.zedGraphControl.ScrollMinY = 0;
            this.zedGraphControl.ScrollMinY2 = 0;
            this.zedGraphControl.Size = new System.Drawing.Size(800, 550);
            this.zedGraphControl.TabIndex = 0;
            // 
            // testCalcButton
            // 
            this.testCalcButton.Location = new System.Drawing.Point(12, 568);
            this.testCalcButton.Name = "testCalcButton";
            this.testCalcButton.Size = new System.Drawing.Size(75, 23);
            this.testCalcButton.TabIndex = 1;
            this.testCalcButton.Text = "Test Calc";
            this.testCalcButton.UseVisualStyleBackColor = true;
            this.testCalcButton.Click += new System.EventHandler(this.testCalcButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(93, 573);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(19, 13);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "----";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.newPlotButton);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.plotTwoSelection);
            this.groupBox1.Controls.Add(this.plotOneSelection);
            this.groupBox1.Controls.Add(this.plotButton2);
            this.groupBox1.Location = new System.Drawing.Point(134, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IJ Power and Energy";
            // 
            // newPlotButton
            // 
            this.newPlotButton.Location = new System.Drawing.Point(76, 68);
            this.newPlotButton.Name = "newPlotButton";
            this.newPlotButton.Size = new System.Drawing.Size(40, 23);
            this.newPlotButton.TabIndex = 6;
            this.newPlotButton.Text = "New";
            this.newPlotButton.UseVisualStyleBackColor = true;
            this.newPlotButton.Click += new System.EventHandler(this.newPlotButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(38, 68);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(39, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // plotTwoSelection
            // 
            this.plotTwoSelection.AutoSize = true;
            this.plotTwoSelection.Location = new System.Drawing.Point(24, 45);
            this.plotTwoSelection.Name = "plotTwoSelection";
            this.plotTwoSelection.Size = new System.Drawing.Size(58, 17);
            this.plotTwoSelection.TabIndex = 3;
            this.plotTwoSelection.Text = "Fig. 10";
            this.plotTwoSelection.UseVisualStyleBackColor = true;
            this.plotTwoSelection.CheckedChanged += new System.EventHandler(this.plotTwoSelection_CheckedChanged);
            // 
            // plotOneSelection
            // 
            this.plotOneSelection.AutoSize = true;
            this.plotOneSelection.Location = new System.Drawing.Point(24, 22);
            this.plotOneSelection.Name = "plotOneSelection";
            this.plotOneSelection.Size = new System.Drawing.Size(52, 17);
            this.plotOneSelection.TabIndex = 2;
            this.plotOneSelection.Text = "Fig. 9";
            this.plotOneSelection.UseVisualStyleBackColor = true;
            this.plotOneSelection.CheckedChanged += new System.EventHandler(this.plotOneSelection_CheckedChanged);
            // 
            // plotButton2
            // 
            this.plotButton2.Location = new System.Drawing.Point(5, 68);
            this.plotButton2.Name = "plotButton2";
            this.plotButton2.Size = new System.Drawing.Size(33, 23);
            this.plotButton2.TabIndex = 4;
            this.plotButton2.Text = "Plot";
            this.plotButton2.UseVisualStyleBackColor = true;
            this.plotButton2.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(929, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 99);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cyber Systems and Man";
            // 
            // plotButton
            // 
            this.plotButton.Location = new System.Drawing.Point(953, 573);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(65, 23);
            this.plotButton.TabIndex = 11;
            this.plotButton.Text = "Plot 2D";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(877, 573);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(70, 23);
            this.loadDataButton.TabIndex = 12;
            this.loadDataButton.Text = "Load Data";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // plotDataGridView
            // 
            this.plotDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plotDataGridView.Location = new System.Drawing.Point(818, 12);
            this.plotDataGridView.Name = "plotDataGridView";
            this.plotDataGridView.Size = new System.Drawing.Size(375, 548);
            this.plotDataGridView.TabIndex = 10;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(1128, 573);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(65, 23);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // threeDimPlotButton
            // 
            this.threeDimPlotButton.Location = new System.Drawing.Point(1024, 573);
            this.threeDimPlotButton.Name = "threeDimPlotButton";
            this.threeDimPlotButton.Size = new System.Drawing.Size(65, 23);
            this.threeDimPlotButton.TabIndex = 15;
            this.threeDimPlotButton.Text = "Plot 3D";
            this.threeDimPlotButton.UseVisualStyleBackColor = true;
            this.threeDimPlotButton.Click += new System.EventHandler(this.threeDimPlotButton_Click);
            // 
            // PlotDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 615);
            this.Controls.Add(this.threeDimPlotButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.loadDataButton);
            this.Controls.Add(this.plotButton);
            this.Controls.Add(this.plotDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.testCalcButton);
            this.Controls.Add(this.zedGraphControl);
            this.Name = "PlotDataForm";
            this.Text = "Plot 2D Expression - Experimenter\'s Station";
            this.Load += new System.EventHandler(this.PlotDataForm_Load);
            this.Resize += new System.EventHandler(this.PlotDataForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plotDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ZedGraph.ZedGraphControl zedGraphControl;
        public System.Windows.Forms.Button testCalcButton;
        public System.Windows.Forms.Label resultLabel;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox plotTwoSelection;
        public System.Windows.Forms.CheckBox plotOneSelection;
        public System.Windows.Forms.Button plotButton2;
        public System.Windows.Forms.Button clearButton;
        public System.Windows.Forms.Button newPlotButton;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button plotButton;
        public System.Windows.Forms.Button loadDataButton;
        private System.Windows.Forms.DataGridView plotDataGridView;
        public System.Windows.Forms.Button refreshButton;
        public System.Windows.Forms.Button threeDimPlotButton;
    }
}