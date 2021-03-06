using System;
using System.Windows.Forms;

namespace CircuitCalculator.Forms
{
    /// <summary>
    ///  Do you need an air coil?
    ///
    ///  What are the advantages of an air core coil?
    /// 
    ///    Its inductance is unaffected by the current it carries. This contrasts with the situation with coils using ferromagnetic cores whose inductance tends 
    ///  to reach a peak at moderate field strengths before dropping towards zero as saturation approaches. Sometimes non-linearity in the magnetization curve can be tolerated; 
    ///  for example in switching converters. In circuits such as audio cross over networks in hi-fi speaker systems you must avoid distortion; then you need an air coil. 
    ///  Most radio transmitters rely on air coils to prevent the production of harmonics.
    ///    Air coils are also free of the 'iron losses' which affect ferromagnetic cores. As frequency is increased this advantage becomes progressively more important. 
    ///  You obtain better Q-factor, greater efficiency, greater power handling, and less distortion.
    ///    Lastly, air coils can be designed to perform at frequencies as high as 1 Ghz. Most ferromagnetic cores tend to be rather lossy above 100 MHz.
    ///
    ///  And the 'downside'?
    ///
    ///    Without a high permeability core you must have more and/or larger turns to achieve a given inductance value. More turns means larger coils, lower self-resonance 
    ///  and higher copper loss. At higher frequencies you generally don't need high inductance, so this is then less of a problem.
    ///    Greater stray field radiation and pickup. With the closed magnetic paths used in cored inductors radiation is much less serious. As the diameter increases towards 
    ///  a wavelength (lambda = c / f), loss due to electromagnetic radiation will become significant. Balanis has the gory details. You may be able to reduce this problem by 
    ///  enclosing the coil in a screen, or by mounting it at right angles to other coils it may be coupling with.
    ///
    ///    You may be using an air cored coil not because you require a circuit element with a specific inductance per se but because your coil is used as a proximity sensor, 
    ///  loop antenna, induction heater, Tesla coil, electromagnet, magnetometer head or deflection yoke etc. Then an external field may be what you want.
    /// </summary>
    public partial class AirCoreInductanceCalculator : Form
    {
        private Form owner;
        private static bool instance = false;

        public AirCoreInductanceCalculator(Form mOwner)
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
            var toolTip = new ToolTip {AutoPopDelay = 10000, InitialDelay = 400, ReshowDelay = 250, ShowAlways = true};
            toolTip.SetToolTip(circularLoopPictureBox, "This formula is valid for frequencies < 30MHz for enameled copper wire.");
            toolTip.SetToolTip(equationBox, "Source: H.A. Wheeler, modified in \"Simple Accurate Expressions for Planar Spiral Inductances\""); 
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
            wl = (wlImperial * 25.4) / 1000;
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