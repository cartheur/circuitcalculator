using System;
using System.Globalization;
using System.Windows.Forms;

namespace CircuitCalculator.SubForms
{
    public partial class PythagoreanCalculator : Form
    {
        /// <summary>
        /// The permeability constant.
        /// </summary>
        const double Permeability = (4 * Math.PI) * 1E-7;
        /// <summary>
        /// Initializes a new instance of the <see cref="PythagoreanCalculator"/> class.
        /// </summary>
        /// <param name="mOwner">The form owner.</param>
        public PythagoreanCalculator(Form mOwner)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            ControlBox = false;
            Instance = true;
            radiusInputBox.Text = "3";
            distanceInputBox.Text = "2";
            alphaInputBox.Text = "0.5";
            currentInputBox.Text = "1.1";
            propagationAngleInputBox.Text = "30";
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get; set; }
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void CloseButtonClick(object sender, EventArgs e)
        {
            Instance = false;
            Close();
        }
        /// <summary>
        /// Calculates the hypotenuse button click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CalculateHypotenuseButtonClick(object sender, EventArgs e)
        {
            CalculateHypotenuse();
        }
        /// <summary>
        /// Calculates the peak power position button click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CalculatePeakPowerPositionButtonClick(object sender, EventArgs e)
        {
            CalculatePeakPowerPosition();
        }
        /// <summary>
        /// Calculates the field button click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CalculateFieldButtonClick(object sender, EventArgs e)
        {
            CalculateFieldEmittedByLoop();
        }
        /// <summary>
        /// Calculates the hypotenuse of the right-triangle.
        /// </summary>
        protected void CalculateHypotenuse()
        {
            double radius = Convert.ToDouble(radiusInputBox.Text);
            double distance = Convert.ToDouble(distanceInputBox.Text);
            double hypotenuse = Math.Pow(radius, 2) + Math.Pow(distance, 2);
            hypotenuseSolution.Text = Math.Sqrt(hypotenuse).ToString(CultureInfo.InvariantCulture);
        }
        /// <summary>
        /// Calculates the peak power position.
        /// </summary>
        protected void CalculatePeakPowerPosition()
        {
            double radius = Convert.ToDouble(radiusInputBox.Text);
            double distance = Convert.ToDouble(distanceInputBox.Text);
            double hypotenuse = Math.Pow(radius, 2) + Math.Pow(distance, 2);
            double alpha = Convert.ToDouble(alphaInputBox.Text);
            double result = alpha * (hypotenuse - Math.Pow(radius, 2));
            peakPowerPositionSolutionBox.Text = Math.Sqrt(result).ToString(CultureInfo.InvariantCulture);
        }
        /// <summary>
        /// Calculates the field emitted by loop.
        /// </summary>
        protected void CalculateFieldEmittedByLoop()
        {
            double current = Convert.ToDouble(currentInputBox.Text);
            double theta = Convert.ToDouble(propagationAngleInputBox.Text);
            double radius = Convert.ToDouble(radiusInputBox.Text);
            double radiusMeter = radius * 1E-2;
            double field = ((Permeability * current) / (2 * radiusMeter)) * Math.Cos(theta);
            emittedFieldSolutionBox.Text = field.ToString(CultureInfo.InvariantCulture);
        }
    }
}
