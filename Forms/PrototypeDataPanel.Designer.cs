namespace CircuitCalculator
{
    partial class PrototypeDataPanel
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
            this.prototypeSelectionBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fourCoilGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fourCoilSelectionBox = new System.Windows.Forms.ComboBox();
            this.updateFourCoilTextBox = new System.Windows.Forms.TextBox();
            this.saveFourCoilButton = new System.Windows.Forms.Button();
            this.updateFourCoilButton = new System.Windows.Forms.Button();
            this.unitsLabel = new System.Windows.Forms.Label();
            this.fourDataDisplayTextBox = new System.Windows.Forms.TextBox();
            this.fourCoilPropertySelectionBox = new System.Windows.Forms.ComboBox();
            this.twoCoilGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.twoCoilSelectionBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.updateTwoCoilTextBox = new System.Windows.Forms.TextBox();
            this.saveTwoCoilButton = new System.Windows.Forms.Button();
            this.updateTwoCoilButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.twoDataDisplayTextBox = new System.Windows.Forms.TextBox();
            this.twoCoilPropertySelectionBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.twoCoilElectricalGroupBox = new System.Windows.Forms.GroupBox();
            this.fourCoilElectricalGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fourCoilElectricalSelectionBox = new System.Windows.Forms.ComboBox();
            this.updateFourCoilElectricalBox = new System.Windows.Forms.TextBox();
            this.saveFourCoilElectricalButton = new System.Windows.Forms.Button();
            this.updateFourCoilElectricalButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.fourElectricalDataDisplayBox = new System.Windows.Forms.TextBox();
            this.fourCoilElectricalPropertyBox = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.fourCoilGroupBox.SuspendLayout();
            this.twoCoilGroupBox.SuspendLayout();
            this.twoCoilElectricalGroupBox.SuspendLayout();
            this.fourCoilElectricalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(15, 775);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(121, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // prototypeSelectionBox
            // 
            this.prototypeSelectionBox.FormattingEnabled = true;
            this.prototypeSelectionBox.Items.AddRange(new object[] {
            "Inductive-Link Coils",
            "Resonant-Link Coils",
            "Model \'F\' Coils",
            "Clear Selection"});
            this.prototypeSelectionBox.Location = new System.Drawing.Point(89, 17);
            this.prototypeSelectionBox.Name = "prototypeSelectionBox";
            this.prototypeSelectionBox.Size = new System.Drawing.Size(250, 21);
            this.prototypeSelectionBox.TabIndex = 1;
            this.prototypeSelectionBox.SelectedIndexChanged += new System.EventHandler(this.prototypeSelectionBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prototype:";
            // 
            // fourCoilGroupBox
            // 
            this.fourCoilGroupBox.Controls.Add(this.label2);
            this.fourCoilGroupBox.Controls.Add(this.label5);
            this.fourCoilGroupBox.Controls.Add(this.fourCoilSelectionBox);
            this.fourCoilGroupBox.Controls.Add(this.updateFourCoilTextBox);
            this.fourCoilGroupBox.Controls.Add(this.saveFourCoilButton);
            this.fourCoilGroupBox.Controls.Add(this.updateFourCoilButton);
            this.fourCoilGroupBox.Controls.Add(this.unitsLabel);
            this.fourCoilGroupBox.Controls.Add(this.fourDataDisplayTextBox);
            this.fourCoilGroupBox.Controls.Add(this.fourCoilPropertySelectionBox);
            this.fourCoilGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourCoilGroupBox.Location = new System.Drawing.Point(15, 54);
            this.fourCoilGroupBox.Name = "fourCoilGroupBox";
            this.fourCoilGroupBox.Size = new System.Drawing.Size(324, 179);
            this.fourCoilGroupBox.TabIndex = 4;
            this.fourCoilGroupBox.TabStop = false;
            this.fourCoilGroupBox.Text = "Physical Specification (RL)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Property:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Coil:";
            // 
            // fourCoilSelectionBox
            // 
            this.fourCoilSelectionBox.FormattingEnabled = true;
            this.fourCoilSelectionBox.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.fourCoilSelectionBox.Location = new System.Drawing.Point(74, 35);
            this.fourCoilSelectionBox.Name = "fourCoilSelectionBox";
            this.fourCoilSelectionBox.Size = new System.Drawing.Size(103, 24);
            this.fourCoilSelectionBox.TabIndex = 8;
            // 
            // updateFourCoilTextBox
            // 
            this.updateFourCoilTextBox.Location = new System.Drawing.Point(23, 139);
            this.updateFourCoilTextBox.Name = "updateFourCoilTextBox";
            this.updateFourCoilTextBox.Size = new System.Drawing.Size(160, 22);
            this.updateFourCoilTextBox.TabIndex = 6;
            // 
            // saveFourCoilButton
            // 
            this.saveFourCoilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFourCoilButton.Location = new System.Drawing.Point(243, 142);
            this.saveFourCoilButton.Name = "saveFourCoilButton";
            this.saveFourCoilButton.Size = new System.Drawing.Size(75, 23);
            this.saveFourCoilButton.TabIndex = 5;
            this.saveFourCoilButton.Text = "Save";
            this.saveFourCoilButton.UseVisualStyleBackColor = true;
            this.saveFourCoilButton.Click += new System.EventHandler(this.saveTwoCoilPhysicalButton_Click);
            // 
            // updateFourCoilButton
            // 
            this.updateFourCoilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateFourCoilButton.Location = new System.Drawing.Point(243, 113);
            this.updateFourCoilButton.Name = "updateFourCoilButton";
            this.updateFourCoilButton.Size = new System.Drawing.Size(75, 23);
            this.updateFourCoilButton.TabIndex = 4;
            this.updateFourCoilButton.Text = "Update";
            this.updateFourCoilButton.UseVisualStyleBackColor = true;
            this.updateFourCoilButton.Click += new System.EventHandler(this.updateFourCoilPhysicalButton_Click);
            // 
            // unitsLabel
            // 
            this.unitsLabel.AutoSize = true;
            this.unitsLabel.Location = new System.Drawing.Point(189, 98);
            this.unitsLabel.Name = "unitsLabel";
            this.unitsLabel.Size = new System.Drawing.Size(30, 16);
            this.unitsLabel.TabIndex = 2;
            this.unitsLabel.Text = "mm";
            // 
            // fourDataDisplayTextBox
            // 
            this.fourDataDisplayTextBox.Location = new System.Drawing.Point(23, 95);
            this.fourDataDisplayTextBox.Name = "fourDataDisplayTextBox";
            this.fourDataDisplayTextBox.Size = new System.Drawing.Size(160, 22);
            this.fourDataDisplayTextBox.TabIndex = 1;
            // 
            // fourCoilPropertySelectionBox
            // 
            this.fourCoilPropertySelectionBox.FormattingEnabled = true;
            this.fourCoilPropertySelectionBox.Items.AddRange(new object[] {
            "Inner Radius",
            "Outer Radius",
            "Wire Radius",
            "Number of turns"});
            this.fourCoilPropertySelectionBox.Location = new System.Drawing.Point(74, 65);
            this.fourCoilPropertySelectionBox.Name = "fourCoilPropertySelectionBox";
            this.fourCoilPropertySelectionBox.Size = new System.Drawing.Size(143, 24);
            this.fourCoilPropertySelectionBox.TabIndex = 0;
            this.fourCoilPropertySelectionBox.SelectedIndexChanged += new System.EventHandler(this.fourCoilPropertySelectionBox_SelectedIndexChanged);
            // 
            // twoCoilGroupBox
            // 
            this.twoCoilGroupBox.Controls.Add(this.label3);
            this.twoCoilGroupBox.Controls.Add(this.label6);
            this.twoCoilGroupBox.Controls.Add(this.twoCoilSelectionBox);
            this.twoCoilGroupBox.Controls.Add(this.label7);
            this.twoCoilGroupBox.Controls.Add(this.updateTwoCoilTextBox);
            this.twoCoilGroupBox.Controls.Add(this.saveTwoCoilButton);
            this.twoCoilGroupBox.Controls.Add(this.updateTwoCoilButton);
            this.twoCoilGroupBox.Controls.Add(this.label8);
            this.twoCoilGroupBox.Controls.Add(this.twoDataDisplayTextBox);
            this.twoCoilGroupBox.Controls.Add(this.twoCoilPropertySelectionBox);
            this.twoCoilGroupBox.Controls.Add(this.groupBox3);
            this.twoCoilGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoCoilGroupBox.Location = new System.Drawing.Point(15, 406);
            this.twoCoilGroupBox.Name = "twoCoilGroupBox";
            this.twoCoilGroupBox.Size = new System.Drawing.Size(324, 181);
            this.twoCoilGroupBox.TabIndex = 5;
            this.twoCoilGroupBox.TabStop = false;
            this.twoCoilGroupBox.Text = "Physical Specification (IL)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Property:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Coil:";
            // 
            // twoCoilSelectionBox
            // 
            this.twoCoilSelectionBox.FormattingEnabled = true;
            this.twoCoilSelectionBox.Items.AddRange(new object[] {
            "a",
            "b"});
            this.twoCoilSelectionBox.Location = new System.Drawing.Point(74, 25);
            this.twoCoilSelectionBox.Name = "twoCoilSelectionBox";
            this.twoCoilSelectionBox.Size = new System.Drawing.Size(103, 24);
            this.twoCoilSelectionBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "mm";
            // 
            // updateTwoCoilTextBox
            // 
            this.updateTwoCoilTextBox.Location = new System.Drawing.Point(23, 129);
            this.updateTwoCoilTextBox.Name = "updateTwoCoilTextBox";
            this.updateTwoCoilTextBox.Size = new System.Drawing.Size(160, 22);
            this.updateTwoCoilTextBox.TabIndex = 17;
            // 
            // saveTwoCoilButton
            // 
            this.saveTwoCoilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTwoCoilButton.Location = new System.Drawing.Point(243, 132);
            this.saveTwoCoilButton.Name = "saveTwoCoilButton";
            this.saveTwoCoilButton.Size = new System.Drawing.Size(75, 23);
            this.saveTwoCoilButton.TabIndex = 16;
            this.saveTwoCoilButton.Text = "Save";
            this.saveTwoCoilButton.UseVisualStyleBackColor = true;
            // 
            // updateTwoCoilButton
            // 
            this.updateTwoCoilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTwoCoilButton.Location = new System.Drawing.Point(243, 103);
            this.updateTwoCoilButton.Name = "updateTwoCoilButton";
            this.updateTwoCoilButton.Size = new System.Drawing.Size(75, 23);
            this.updateTwoCoilButton.TabIndex = 15;
            this.updateTwoCoilButton.Text = "Update";
            this.updateTwoCoilButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "mm";
            // 
            // twoDataDisplayTextBox
            // 
            this.twoDataDisplayTextBox.Location = new System.Drawing.Point(23, 85);
            this.twoDataDisplayTextBox.Name = "twoDataDisplayTextBox";
            this.twoDataDisplayTextBox.Size = new System.Drawing.Size(160, 22);
            this.twoDataDisplayTextBox.TabIndex = 13;
            // 
            // twoCoilPropertySelectionBox
            // 
            this.twoCoilPropertySelectionBox.FormattingEnabled = true;
            this.twoCoilPropertySelectionBox.Items.AddRange(new object[] {
            "Loop Radius",
            "Wire Radius",
            "Number of turns"});
            this.twoCoilPropertySelectionBox.Location = new System.Drawing.Point(74, 55);
            this.twoCoilPropertySelectionBox.Name = "twoCoilPropertySelectionBox";
            this.twoCoilPropertySelectionBox.Size = new System.Drawing.Size(143, 24);
            this.twoCoilPropertySelectionBox.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(80, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 128);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Coil \'b\'";
            // 
            // twoCoilElectricalGroupBox
            // 
            this.twoCoilElectricalGroupBox.Controls.Add(this.label4);
            this.twoCoilElectricalGroupBox.Controls.Add(this.label11);
            this.twoCoilElectricalGroupBox.Controls.Add(this.comboBox1);
            this.twoCoilElectricalGroupBox.Controls.Add(this.label13);
            this.twoCoilElectricalGroupBox.Controls.Add(this.textBox1);
            this.twoCoilElectricalGroupBox.Controls.Add(this.button1);
            this.twoCoilElectricalGroupBox.Controls.Add(this.button2);
            this.twoCoilElectricalGroupBox.Controls.Add(this.label14);
            this.twoCoilElectricalGroupBox.Controls.Add(this.textBox2);
            this.twoCoilElectricalGroupBox.Controls.Add(this.comboBox2);
            this.twoCoilElectricalGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoCoilElectricalGroupBox.Location = new System.Drawing.Point(15, 593);
            this.twoCoilElectricalGroupBox.Name = "twoCoilElectricalGroupBox";
            this.twoCoilElectricalGroupBox.Size = new System.Drawing.Size(324, 167);
            this.twoCoilElectricalGroupBox.TabIndex = 8;
            this.twoCoilElectricalGroupBox.TabStop = false;
            this.twoCoilElectricalGroupBox.Text = "Electrical Specification (IL)";
            // 
            // fourCoilElectricalGroupBox
            // 
            this.fourCoilElectricalGroupBox.Controls.Add(this.label9);
            this.fourCoilElectricalGroupBox.Controls.Add(this.label10);
            this.fourCoilElectricalGroupBox.Controls.Add(this.fourCoilElectricalSelectionBox);
            this.fourCoilElectricalGroupBox.Controls.Add(this.updateFourCoilElectricalBox);
            this.fourCoilElectricalGroupBox.Controls.Add(this.saveFourCoilElectricalButton);
            this.fourCoilElectricalGroupBox.Controls.Add(this.updateFourCoilElectricalButton);
            this.fourCoilElectricalGroupBox.Controls.Add(this.label12);
            this.fourCoilElectricalGroupBox.Controls.Add(this.fourElectricalDataDisplayBox);
            this.fourCoilElectricalGroupBox.Controls.Add(this.fourCoilElectricalPropertyBox);
            this.fourCoilElectricalGroupBox.Controls.Add(this.groupBox6);
            this.fourCoilElectricalGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourCoilElectricalGroupBox.Location = new System.Drawing.Point(15, 239);
            this.fourCoilElectricalGroupBox.Name = "fourCoilElectricalGroupBox";
            this.fourCoilElectricalGroupBox.Size = new System.Drawing.Size(324, 161);
            this.fourCoilElectricalGroupBox.TabIndex = 10;
            this.fourCoilElectricalGroupBox.TabStop = false;
            this.fourCoilElectricalGroupBox.Text = "Electrical Specification (RL)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Property:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Coil:";
            // 
            // fourCoilElectricalSelectionBox
            // 
            this.fourCoilElectricalSelectionBox.FormattingEnabled = true;
            this.fourCoilElectricalSelectionBox.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.fourCoilElectricalSelectionBox.Location = new System.Drawing.Point(74, 23);
            this.fourCoilElectricalSelectionBox.Name = "fourCoilElectricalSelectionBox";
            this.fourCoilElectricalSelectionBox.Size = new System.Drawing.Size(103, 24);
            this.fourCoilElectricalSelectionBox.TabIndex = 19;
            // 
            // updateFourCoilElectricalBox
            // 
            this.updateFourCoilElectricalBox.Location = new System.Drawing.Point(23, 127);
            this.updateFourCoilElectricalBox.Name = "updateFourCoilElectricalBox";
            this.updateFourCoilElectricalBox.Size = new System.Drawing.Size(160, 22);
            this.updateFourCoilElectricalBox.TabIndex = 17;
            // 
            // saveFourCoilElectricalButton
            // 
            this.saveFourCoilElectricalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFourCoilElectricalButton.Location = new System.Drawing.Point(243, 130);
            this.saveFourCoilElectricalButton.Name = "saveFourCoilElectricalButton";
            this.saveFourCoilElectricalButton.Size = new System.Drawing.Size(75, 23);
            this.saveFourCoilElectricalButton.TabIndex = 16;
            this.saveFourCoilElectricalButton.Text = "Save";
            this.saveFourCoilElectricalButton.UseVisualStyleBackColor = true;
            // 
            // updateFourCoilElectricalButton
            // 
            this.updateFourCoilElectricalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateFourCoilElectricalButton.Location = new System.Drawing.Point(243, 101);
            this.updateFourCoilElectricalButton.Name = "updateFourCoilElectricalButton";
            this.updateFourCoilElectricalButton.Size = new System.Drawing.Size(75, 23);
            this.updateFourCoilElectricalButton.TabIndex = 15;
            this.updateFourCoilElectricalButton.Text = "Update";
            this.updateFourCoilElectricalButton.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(189, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "mm";
            // 
            // fourElectricalDataDisplayBox
            // 
            this.fourElectricalDataDisplayBox.Location = new System.Drawing.Point(23, 83);
            this.fourElectricalDataDisplayBox.Name = "fourElectricalDataDisplayBox";
            this.fourElectricalDataDisplayBox.Size = new System.Drawing.Size(160, 22);
            this.fourElectricalDataDisplayBox.TabIndex = 13;
            // 
            // fourCoilElectricalPropertyBox
            // 
            this.fourCoilElectricalPropertyBox.FormattingEnabled = true;
            this.fourCoilElectricalPropertyBox.Items.AddRange(new object[] {
            "Inductance",
            "Self-Resistance",
            "Q-Frequency",
            "Q-Loaded",
            "Q-Unloaded"});
            this.fourCoilElectricalPropertyBox.Location = new System.Drawing.Point(74, 53);
            this.fourCoilElectricalPropertyBox.Name = "fourCoilElectricalPropertyBox";
            this.fourCoilElectricalPropertyBox.Size = new System.Drawing.Size(143, 24);
            this.fourCoilElectricalPropertyBox.TabIndex = 12;
            this.fourCoilElectricalPropertyBox.SelectedIndexChanged += new System.EventHandler(this.fourCoilElectricalPropertyBox_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(80, 245);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(256, 128);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Coil \'b\'";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Property:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Coil:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "a",
            "b"});
            this.comboBox1.Location = new System.Drawing.Point(74, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 24);
            this.comboBox1.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(189, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "mm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(243, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(243, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(189, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "mm";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 22);
            this.textBox2.TabIndex = 23;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Inductance",
            "Self-Resistance",
            "Q-Frequency",
            "Q-Loaded",
            "Q-Unloaded"});
            this.comboBox2.Location = new System.Drawing.Point(74, 56);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(143, 24);
            this.comboBox2.TabIndex = 22;
            // 
            // PrototypeDataPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 807);
            this.Controls.Add(this.fourCoilElectricalGroupBox);
            this.Controls.Add(this.twoCoilElectricalGroupBox);
            this.Controls.Add(this.twoCoilGroupBox);
            this.Controls.Add(this.fourCoilGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prototypeSelectionBox);
            this.Controls.Add(this.closeButton);
            this.Name = "PrototypeDataPanel";
            this.Text = "Prototype Specification Data";
            this.MouseEnter += new System.EventHandler(this.PrototypeDataPanel_MouseEnter);
            this.fourCoilGroupBox.ResumeLayout(false);
            this.fourCoilGroupBox.PerformLayout();
            this.twoCoilGroupBox.ResumeLayout(false);
            this.twoCoilGroupBox.PerformLayout();
            this.twoCoilElectricalGroupBox.ResumeLayout(false);
            this.twoCoilElectricalGroupBox.PerformLayout();
            this.fourCoilElectricalGroupBox.ResumeLayout(false);
            this.fourCoilElectricalGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox prototypeSelectionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox fourCoilGroupBox;
        private System.Windows.Forms.GroupBox twoCoilGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox twoCoilElectricalGroupBox;
        private System.Windows.Forms.GroupBox fourCoilElectricalGroupBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label unitsLabel;
        private System.Windows.Forms.TextBox fourDataDisplayTextBox;
        private System.Windows.Forms.ComboBox fourCoilPropertySelectionBox;
        private System.Windows.Forms.Button saveFourCoilButton;
        private System.Windows.Forms.Button updateFourCoilButton;
        private System.Windows.Forms.TextBox updateFourCoilTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox fourCoilSelectionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox twoCoilSelectionBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox updateTwoCoilTextBox;
        private System.Windows.Forms.Button saveTwoCoilButton;
        private System.Windows.Forms.Button updateTwoCoilButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox twoDataDisplayTextBox;
        private System.Windows.Forms.ComboBox twoCoilPropertySelectionBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox fourCoilElectricalSelectionBox;
        private System.Windows.Forms.TextBox updateFourCoilElectricalBox;
        private System.Windows.Forms.Button saveFourCoilElectricalButton;
        private System.Windows.Forms.Button updateFourCoilElectricalButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox fourElectricalDataDisplayBox;
        private System.Windows.Forms.ComboBox fourCoilElectricalPropertyBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}