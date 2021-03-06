using System;
using System.Windows.Forms;

namespace CircuitCalculator.Forms
{
    public partial class SpiralInductanceCalculator : Form
    {
        private Form owner;
        private static bool instance = false;

        public SpiralInductanceCalculator(Form mOwner)
        {
            InitializeComponent();
            innerDiameterFactor.Text = "mm";
            wireDiameterFactor.Text = "mm";
            wireSpacingFactor.Text = "mm";
            owner = mOwner;
            //relativePermeabilityMediumTextBox.Text = "4π * 10E-7";//12.56637E-7
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            instance = true;
            sessionValue.Text = (string)AppDomain.CurrentDomain.GetData("SessionID");
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 400;
            toolTip.ReshowDelay = 250;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.circularLoopPictureBox, "This formula is valid for frequencies < 30MHz for enameled copper wire.");
            toolTip.SetToolTip(this.equationBox, "Source: H.A. Wheeler, modified in \"Simple Accurate Expressions for Planar Spiral Inductances\""); 
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return instance; } set { instance = value; } }
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void CloseButtonClick(object sender, EventArgs e)
        {
            instance = false;
            Close();
        }
        /// <summary>
        /// Starts the calculation sequence.
        /// </summary>
        private void CalculateButtonClick(object sender, EventArgs e)
        {
            double wMetric = Convert.ToDouble(wireDiameterValueBox.Text);
            double wImperial = wMetric / 25.4;        
            double sMetric = Convert.ToDouble(wireSpacingValueBox.Text);
            double sImperial = sMetric / 25.4;
            double dinMetric = Convert.ToDouble(innerDiameterValueBox.Text);
            double dinImperial = dinMetric / 25.4;

            CalculateFlatSpiralInductance(wImperial, sImperial, dinImperial);
        }
        protected double CalculateFlatSpiralInductance(double wImperial, double sImperial, double dinImperial)
        {
            double result = 0;
            // Convert the quantities from metric to Imperial (H.A. Wheeler - 1928)
            double a = 0; 
            double Din = dinImperial; // Inner diameter
            double Dout = 0;
            double DoutImperial = 0; // Outer diameter (Imperial)
            double wl = 0;
            double wlImperial = 0; // Wire diameter (Imperial)
            double w = wImperial; 
            double N = Convert.ToDouble(turnsValueBox.Text); // Number of turns
            double s = sImperial; // Distance between turns

            // Calculate inductance
            a = (Din + N * (w + s)) / 2;
            result = (N * N * a * a) / (a * 30 - Din * 11);// L in uH
            resultBox.Text = result.ToString();
            // Calculate outer diameter
            DoutImperial = Din * 1 + 2 * N * (w * 1 + s * 1);
            wlImperial = ((Dout - Din) / 2 + Din * 1) * N * Math.PI;
            Dout = DoutImperial * 25.4;
            wl = (wlImperial * 25.4) / 100;
            outerDiameterValueBox.Text = Dout.ToString();
            outerDiameterFactor.Text = "mm";
            wireLengthValueBox.Text = wl.ToString();
            wireLengthFactor.Text = "m";

            return result;
        }
        protected double ConvertQuantity(string type, double input)
        {
            double value = 0;

            if (type == "wlm")
            {
                //value = input * 
            }

            return value;
        }
    }
}