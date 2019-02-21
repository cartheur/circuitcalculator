using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CircuitCalculator
{
    public partial class EnergyPowerCalculator : Form
    {
        private Form owner;
        private static bool instance = false;
        double speedOfLight = 2.99792458E8;

        public EnergyPowerCalculator(Form mOwner)
        {
            InitializeComponent();
            degRadSelection.SelectedItem = "deg";
            inductanceFactor.SelectedItem = "uH";
            distanceFactor.SelectedItem = "cm";
            litzWireLengthFactor.SelectedItem = "cm";
            inputCurrentFactor.SelectedItem = "A";
            inputCurrentPowerFactor.SelectedItem = "A";
            frequencyFactor.SelectedItem = "Hz";
            owner = mOwner;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            instance = true;
        }
        private void energyPowerCalculator_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 400;
            toolTip.ReshowDelay = 250;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.distancePictureBox, "The observation distance from the coil.");
            toolTip.SetToolTip(this.thetaPictureBox, "The observation angle from the coil.");
            //toolTip.SetToolTip(this.dipoleDistancePictureBox, "The distance from the dipole, which in the case of a circular loop is the observation distance since the dipole lies in the x-y plane.");
            //toolTip.SetToolTip(this.depthPenetrationPictureBox, "The depth of penetration of the antenna field.");
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return instance; } set { instance = value; } }
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            instance = false;
            Close();
        }
        /// <summary>
        /// Calculates the lambda.
        /// </summary>
        /// <param name="frequency">The frequency.</param>
        protected double CalculateLambda(double frequency)
        {
            double result = 0;
            result = speedOfLight / frequency;
            return result;
        }
        /// <summary>
        /// Calculates the radians from degrees.
        /// </summary>
        /// <param name="degrees">The angle in degrees.</param>
        protected double CalculateRadians(double degrees)
        {
            double result = 0;
            result = degrees * (Math.PI / 180);

            return result;
        }
        /// <summary>
        /// Calculates the electric current on a Litz wire.
        /// </summary>
        protected double CalculateElectricLitz()
        {
            double result = 0;
            double theta = 0;
            double frequency = 0;
            double distance = 0;
            double inputCurrent = 0;
            double numberOfTurns = Convert.ToDouble(turnsTextBox.Text);
            double tempTheta = Convert.ToDouble(thetaValueBox.Text);
            double tempDistance = Convert.ToDouble(distanceValueBox.Text);
            double tempFrequency = Convert.ToDouble(frequencyValueBox.Text);
            double tempCurrent = Convert.ToDouble(inputCurrentValueBox.Text);

            if (degRadSelection.Text == "deg")
            {
                theta = CalculateRadians(tempTheta);
            }
            if (degRadSelection.Text == "rad")
            {
                theta = tempTheta;
            }
            if (distanceFactor.Text == "m")
            {
                distance = tempDistance;
            }
            if (distanceFactor.Text == "cm")
            {
                distance = tempDistance * 1E-2;
            }
            if (distanceFactor.Text == "mm")
            {
                distance = tempDistance * 1E-3;
            }
            if (frequencyFactor.Text == "MHz")
            {
                frequency = tempFrequency * 1E6;
            }
            if (frequencyFactor.Text == "kHz")
            {
                frequency = tempFrequency * 1E3;
            }
            if (frequencyFactor.Text == "Hz")
            {
                frequency = tempFrequency;
            }
            if (inputCurrentFactor.Text == "A")
            {
                inputCurrent = tempCurrent;
            }
            if (inputCurrentFactor.Text == "mA")
            {
                inputCurrent = tempCurrent * 1E-3;
            }
            if (inputCurrentFactor.Text == "uA")
            {
                inputCurrent = tempCurrent * 1E-6;
            }

            double lambda = CalculateLambda(frequency);
            double beta = (Math.PI * Math.Sin(theta)) / lambda;
            double der = (Math.PI * distance * Math.Sin(theta) / theta);
            result = inputCurrent * (Math.Sin((Math.Pow(Math.Sin(beta), 2) / Math.Pow(beta, 2)) * (Math.Pow(Math.Sin((numberOfTurns * der)), 2) / Math.Pow(Math.Sin(der), 2))));
            electricCurrentThetaSolutionBox.Text = result.ToString();

            return result;
        }

        #region Click events
        /// <summary>
        /// Calculates the electric Litz result.
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            CalculateElectricLitz();
        }
        /// <summary>
        /// Calculates the stored energy in the magnetic field.
        /// </summary>
        private void calculateStoredEnergyButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Calculates the dissipated power.
        /// </summary>
        private void calculateDissipatedPowerButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}