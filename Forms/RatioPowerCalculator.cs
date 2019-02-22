using System;
using System.Globalization;
using System.Windows.Forms;

namespace CircuitCalculator.Forms
{
    public partial class RatioPowerCalculator : Form
    {
        private Form owner;
        private static bool _instance;

        public RatioPowerCalculator(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            ControlBox = false;
            _instance = true;
            waveVelocityUnit.Text = "m/s";
            // temporary variables for testing accuracy
            frequencyValueBox.Text = "450";
            resonanceFrequencyUnit.Text = "kHz";
            radiusValueBox.Text = "3";
            radiusFactor.Text = "cm";
            distanceValueBox.Text = "3";
            distanceFactor.Text = "cm";
            speedOfLightCheckBox.Checked = true;
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return _instance; } set { _instance = value; } }

        private void RatioPowerCalculator_Load(object sender, EventArgs e)
        {
            var toolTip = new ToolTip {AutoPopDelay = 5000, InitialDelay = 750, ReshowDelay = 250, ShowAlways = true};
            toolTip.SetToolTip(closeButton, "Close this form");
        }
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            _instance = false;
            Close();
        }
        /// <summary>
        /// Calculates the solution.
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (frequencyValueBox.Text == "" | radiusValueBox.Text == "" | distanceValueBox.Text == "" )
            {
                MessageBox.Show("Value boxes are empty. Unless you input real values, zeros will be shown.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                frequencyValueBox.Text = "0";
                radiusValueBox.Text = "0";
                distanceValueBox.Text = "0";
                waveVelocityValueBox.Text = "0";
                ratioResultBox.Text = "0";
                peakEnergyResultBox.Text = "0";
            }
            else
            {
                CalculateOptimalRatio();
            }
        }
        /// <summary>
        /// Calculates the optimal ratio.
        /// </summary>
        public double CalculateOptimalRatio()
        {
            double result = 0;
            double frequency = 0;
            double radius = 0;
            double distance = 0;
            // Format the values as per unit selection.
            // For frequency, values must be in Hertz.
            var tempFrequency = Convert.ToDouble(frequencyValueBox.Text);
            if (resonanceFrequencyUnit.Text == "MHz")
            {
                frequency = tempFrequency * 1E6;
            }
            if (resonanceFrequencyUnit.Text == "kHz")
            {
                frequency = tempFrequency * 1E3;
            }
            if (resonanceFrequencyUnit.Text == "Hz")
            {
                frequency = tempFrequency;
            }
            // For radius, values must be in meters.
            var tempRadius = Convert.ToDouble(radiusValueBox.Text);
            if (radiusFactor.Text == "mm")
            {
                radius = tempRadius * 1E-3;
            }
            if (radiusFactor.Text == "cm")
            {
                radius = tempRadius * 1E-2;
            }
            // For distance, values must be in meters.
            var tempDistance = Convert.ToDouble(distanceValueBox.Text);
            if (distanceFactor.Text == "mm")
            {
                distance = tempDistance * 1E-3;
            }
            if (distanceFactor.Text == "cm")
            {
                distance = tempDistance * 1E-2;
            }
            // Calculate the lambda based on the frequency and wave 
            var lambda = CalculateLambda(frequency);
            var numerator = (2 * Math.PI * radius);
            var denominator = 0.1 * 0.25 * lambda;
            result = numerator / denominator;
            ratioResultBox.Text = result.ToString(CultureInfo.InvariantCulture);
            // Calculate the energy density.
            CalculateEnergyDensity(radius, distance);

            return result;
        }
        /// <summary>
        /// Calculates lambda.
        /// </summary>
        /// <param name="frequency">The frequency.</param>
        /// <returns></returns>
        protected double CalculateLambda(double frequency)
        {
            double velocity = 0;
            double tempVelocity = 0;
            if (speedOfLightCheckBox.Checked)
            {
                velocity = 3E8;
            }
            if (waveVelocityValueBox.Text != "")
            {
                tempVelocity = Convert.ToDouble(waveVelocityValueBox.Text);
            }
            if (waveVelocityUnit.Text == "cm/s")
            {
                if (velocity == 0)
                velocity = tempVelocity * 1E-2;
            }
            if (waveVelocityUnit.Text == "m/s")
            {
                if (velocity == 0)
                velocity = tempVelocity;
            }
            
            var lambda = velocity / frequency;

            return lambda;
        }
        /// <summary>
        /// Calculates the energy density.
        /// </summary>
        /// <param name="radius">The radius.</param>
        /// <param name="distance">The distance.</param>
        public double CalculateEnergyDensity(double radius, double distance)
        {
            double result = 0;
            result = Math.Pow(radius, 2) / Math.Pow(distance, 2);
            peakEnergyResultBox.Text = result.ToString(CultureInfo.InvariantCulture);
            return result;
        }
    }
}
