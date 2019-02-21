namespace CircuitCalculator.CalculusForms
{
    partial class IntegrationCalculator
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.functionBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.stepFactor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lowerLimitBox = new System.Windows.Forms.TextBox();
            this.upperLimitBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.powersComboBox = new System.Windows.Forms.ComboBox();
            this.firstVariableValueBox = new System.Windows.Forms.TextBox();
            this.trigFunctionSelectionBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(273, 324);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Visible = false;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButtonClick);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(72, 150);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(184, 20);
            this.resultBox.TabIndex = 1;
            // 
            // functionBox
            // 
            this.functionBox.Location = new System.Drawing.Point(126, 97);
            this.functionBox.Name = "functionBox";
            this.functionBox.Size = new System.Drawing.Size(130, 20);
            this.functionBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // stepFactor
            // 
            this.stepFactor.FormattingEnabled = true;
            this.stepFactor.Items.AddRange(new object[] {
            "20",
            "200",
            "2000",
            "20000",
            "200000",
            "2000000"});
            this.stepFactor.Location = new System.Drawing.Point(72, 123);
            this.stepFactor.Name = "stepFactor";
            this.stepFactor.Size = new System.Drawing.Size(86, 21);
            this.stepFactor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Function:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Result:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lower limit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Steps:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Upper limit:";
            // 
            // lowerLimitBox
            // 
            this.lowerLimitBox.Location = new System.Drawing.Point(134, 176);
            this.lowerLimitBox.Name = "lowerLimitBox";
            this.lowerLimitBox.Size = new System.Drawing.Size(62, 20);
            this.lowerLimitBox.TabIndex = 10;
            // 
            // upperLimitBox
            // 
            this.upperLimitBox.Location = new System.Drawing.Point(134, 203);
            this.upperLimitBox.Name = "upperLimitBox";
            this.upperLimitBox.Size = new System.Drawing.Size(62, 20);
            this.upperLimitBox.TabIndex = 11;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 327);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(60, 23);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // powersComboBox
            // 
            this.powersComboBox.FormattingEnabled = true;
            this.powersComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.powersComboBox.Location = new System.Drawing.Point(296, 82);
            this.powersComboBox.Name = "powersComboBox";
            this.powersComboBox.Size = new System.Drawing.Size(41, 21);
            this.powersComboBox.TabIndex = 13;
            // 
            // firstVariableValueBox
            // 
            this.firstVariableValueBox.Location = new System.Drawing.Point(262, 96);
            this.firstVariableValueBox.Name = "firstVariableValueBox";
            this.firstVariableValueBox.Size = new System.Drawing.Size(28, 20);
            this.firstVariableValueBox.TabIndex = 14;
            // 
            // trigFunctionSelectionBox
            // 
            this.trigFunctionSelectionBox.FormattingEnabled = true;
            this.trigFunctionSelectionBox.Items.AddRange(new object[] {
            "Sin",
            "Cos",
            "Exp",
            "Sinh",
            "Cosh"});
            this.trigFunctionSelectionBox.Location = new System.Drawing.Point(72, 96);
            this.trigFunctionSelectionBox.Name = "trigFunctionSelectionBox";
            this.trigFunctionSelectionBox.Size = new System.Drawing.Size(48, 21);
            this.trigFunctionSelectionBox.TabIndex = 15;
            // 
            // IntegrationCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 362);
            this.Controls.Add(this.trigFunctionSelectionBox);
            this.Controls.Add(this.firstVariableValueBox);
            this.Controls.Add(this.powersComboBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.upperLimitBox);
            this.Controls.Add(this.lowerLimitBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stepFactor);
            this.Controls.Add(this.functionBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.calculateButton);
            this.Name = "IntegrationCalculator";
            this.Text = "Integration Calculator";
            this.Load += new System.EventHandler(this.IntegrationCalculatorLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox functionBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox stepFactor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lowerLimitBox;
        private System.Windows.Forms.TextBox upperLimitBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox powersComboBox;
        private System.Windows.Forms.TextBox firstVariableValueBox;
        private System.Windows.Forms.ComboBox trigFunctionSelectionBox;
    }
}

