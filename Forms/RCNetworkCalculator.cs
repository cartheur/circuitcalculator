using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CircuitCalculator
{
    public partial class RCNetworkCalculator : Form
    {
        private Form owner;
        private static bool instance = false;

        public RCNetworkCalculator(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            instance = true;
            this.StartPosition = FormStartPosition.CenterParent;
        }
        /// <summary>
        /// The load event for the RC Network Resonance Calculator.
        /// </summary>
        private void RCNetworkCalculator_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 750;
            toolTip.ReshowDelay = 250;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.resonanceEquationPictureBox, "The Equation of the Resonance of a RC Network Circuit");
            toolTip.SetToolTip(this.capacitanceValueBox, "The Value of the Capacitor(s) in the Circuit");
            toolTip.SetToolTip(this.capacitanceFactor, "The Dimension of the Capacitance");
            toolTip.SetToolTip(this.resistanceValueBox, "The Value of the Resistor(s) in the Circuit");
            toolTip.SetToolTip(this.resistanceFactor, "The Dimension of the Resistance");
            toolTip.SetToolTip(this.calculateButton, "Calculate the Result");
            toolTip.SetToolTip(this.resultBox, "The Resonance Frequency of the Circuit");
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return instance; } set { instance = value; } }
        /// <summary>
        /// Calculates the resonance.
        /// </summary>
        /// <param name="res">The resistance.</param>
        /// <param name="cap">The capacitance.</param>
        /// <param name="stages">The number of stages.</param>
        public double CalculateResonance(string res, string cap, string st)
        {
            double result = 0;
            double resistance = 0;
            double capacitance = 0;
            double stages = 0;

            double tempResistance = Convert.ToDouble(resistanceValueBox.Text);
            double tempCapacitance = Convert.ToDouble(capacitanceValueBox.Text);
            double tempStages = Convert.ToDouble(stagesValueBox.Text);

            if (resistanceFactor.Text == "Ω")
            {
                resistance = tempResistance;
            }
            if (resistanceFactor.Text == "kΩ")
            {
                resistance = tempResistance * 1E3;
            }
            if (resistanceFactor.Text == "MΩ")
            {
                resistance = tempResistance * 1E6;
            }
            if (capacitanceFactor.Text == "uF")
            {
                capacitance = tempCapacitance * 1E-6;
            }
            if (capacitanceFactor.Text == "nF")
            {
                capacitance = tempCapacitance * 1E-9;
            }
            if (capacitanceFactor.Text == "pF")
            {
                capacitance = tempCapacitance * 1E-12;
            }
            stages = tempStages;
            //Perform the calculation.
            double sqrt = Math.Sqrt(2 * stages);
            result = 1 / (2 * Math.PI * resistance * capacitance * sqrt);
            //Output the result to the form.
            resultBox.Text = result.ToString();

            return result;
        }
        /// <summary>
        /// Handles the Click event of the calculateButton control.
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (capacitanceValueBox.Text == "" | resistanceValueBox.Text == "" | stagesValueBox.Text == "")
            {
                MessageBox.Show("Value boxes cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                CalculateResonance(resistanceValueBox.Text, capacitanceValueBox.Text, stagesValueBox.Text);
            }
        }
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            instance = false;
            Close();
        }
    }
}
