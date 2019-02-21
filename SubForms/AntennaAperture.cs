using System;
using System.Drawing;
using System.Windows.Forms;

namespace CircuitCalculator
{
    public partial class AntennaAperture : Form
    {
        private Form owner;
        private static bool instance = false;

        public AntennaAperture(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.ControlBox = true;
            instance = true;
            this.StartPosition = FormStartPosition.CenterParent;
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 400;
            toolTip.ReshowDelay = 200;
            toolTip.ShowAlways = true;
            lengthFactor.Text = "cm";
            resultFactor.Text = "cm";
            toolTip.SetToolTip(this.apertureEquation, "Calculated on a 1/4 wave.");
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return instance; } set { instance = value; } }
        /// <summary>
        /// Closes the window.
        /// </summary>
        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            instance = false;
            Close();
        }
        /// <summary>
        /// Calculates the result.
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (wavelengthEntryBox.Text != "")
                CalculateAperture(wavelengthEntryBox.Text);
            else
                MessageBox.Show("Wavelength cannot be null.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); 
        }
        protected double CalculateAperture(string value)
        {
            double result = Convert.ToDouble(value);
            double quarter = 0.25 * result;
            double square = quarter * quarter;
            result = (3 * square) / 8 * Math.PI;
            apertureResultBox.Text = result.ToString();

            return result;
        }
    }
}