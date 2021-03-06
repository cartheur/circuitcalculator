using System;
using System.Globalization;
using System.Windows.Forms;
using CircuitCalculator.SubForms;

namespace CircuitCalculator.Forms
{
    public partial class MagneticFieldCalculator : Form
    {
        private Form owner;
        private static bool instance = false;
        double result = 0;
        double axialLengthResult = 0;

        public MagneticFieldCalculator(Form mOwner)
        {
            InitializeComponent();
            fcCurrentFactor.Text = "A";
            fcRadiusFactor.Text = "cm";
            axialLengthFactor.Text = "cm";
            resultUnit.Text = "Gauss";
            axialLengthUnit.Text = "Gauss";
            owner = mOwner;
            //relativePermeabilityMediumTextBox.Text = "4π * 10E-7";//12.56637E-7
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            ControlBox = false;
            instance = true;
            //sessionValue.Text = (string)AppDomain.CurrentDomain.GetData("SessionID");
            var toolTip = new ToolTip {AutoPopDelay = 10000, InitialDelay = 400, ReshowDelay = 250, ShowAlways = true};
            toolTip.SetToolTip(hLoopCenterPictureBox, "In this special case the symmetry is such that the field contributions " +
                "of all the current elements around the circumference add directly at the center. The line integral of the length is " +
                "just the circumference of the circle.");
            toolTip.SetToolTip(currentElementEquationBox, "The form of the magnetic field from a current element in the Biot-Savart law " +
                "in this case simplifies greatly because the angle equals 90 degrees for all points along the path and the distance to the field " +
                "point is constant. As such, it can be transposed into its integral form.");
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
        /// Calculate the Field at Center Current Loop equation.
        /// </summary>
        private void CalculateButtonClick(object sender, EventArgs e)
        {
            CalculateResult();
            // Check for null entry.
        }
        /// <summary>
        /// Calculate the field at center of current loop.
        /// </summary>
        protected double CalculateResult()
        {
            //double result = 0;
            //double axialLengthResult = 0;
            double current = 0;
            double radius = 0;
            double axialLength = 0;

            double tempCurrent = Convert.ToDouble(fcCurrentValueBox.Text);
            double tempRadius = Convert.ToDouble(fcRadiusValueBox.Text);
            double tempAxialLength = Convert.ToDouble(axialLengthValueBox.Text);
            double theta = Convert.ToDouble(thetaValueBox.Text);

            if (fcCurrentFactor.Text == "A")
            {
                current = tempCurrent * 1;
            }
            if (fcCurrentFactor.Text == "mA")
            {
                current = tempCurrent * 1E-3;
            }
            if (fcCurrentFactor.Text == "uA")
            {
                current = tempCurrent * 1E-6;
            }
            if (fcRadiusFactor.Text == "m")
            {
                radius = tempRadius * 1;
            }
            if (fcRadiusFactor.Text == "cm")
            {
                radius = tempRadius * 1E-2;
            }
            if (fcRadiusFactor.Text == "mm")
            {
                radius = tempRadius * 1E-3;
            }
            if (axialLengthFactor.Text == "m")
            {
                axialLength = tempAxialLength * 1;
            }
            if (axialLengthFactor.Text == "cm")
            {
                axialLength = tempAxialLength * 1E-2;
            }
            if (axialLengthFactor.Text == "mm")
            {
                axialLength = tempAxialLength * 1E-3;
            }
            // Calcualte the result
            double mu = 12.56637E-7;
            result = ((mu*current)/(2*radius));// * 1E4;
            resultBox.Text = result.ToString(CultureInfo.InvariantCulture);
            resultUnit.Text = "Gauss";
            // Calculate the axial length result
            axialLengthResult = Math.Cos(theta) * (((mu / (4 * Math.PI)) * ((2 * Math.PI) * (radius * radius) * current) / Math.Pow(((axialLength * axialLength) + (radius * radius)), 1.5)) * 1E4);
            axialLengthResultBox.Text = axialLengthResult.ToString(CultureInfo.InvariantCulture);
            axialLengthUnit.Text = "Gauss";

            return result;
            
        }
        /// <summary>
        /// Shows the geometry of the model.
        /// </summary>
        private void ViewGeometryButtonClick(object sender, EventArgs e)
        {
            if (GeometryCircularLoop.Instance == false)
            {
                var form = new GeometryCircularLoop(this);
                form.Show(this);
                GeometryCircularLoop.Instance = true;
            }
            else if (GeometryCircularLoop.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Sets the unit for the result box.
        /// </summary>
        private void ResultUnitSelectedIndexChanged(object sender, EventArgs e)
        {
            if (resultUnit.Text == "Gauss")
            {
                double gaussResult = result * 1E4;
                resultBox.Text = gaussResult.ToString(CultureInfo.InvariantCulture);
            }
            if (resultUnit.Text == "T")
            {
                var gaussResult = result * 1e-4;
                resultBox.Text = gaussResult.ToString(CultureInfo.InvariantCulture);
            }
        }
        /// <summary>
        /// Sets the unit for the axial length result box.
        /// </summary>
        private void AxialLengthUnitSelectedIndexChanged(object sender, EventArgs e)
        {
            if (axialLengthUnit.Text == "Gauss")
            {
                double axialLengthGaussResult = axialLengthResult * 1E4;
                axialLengthResultBox.Text = axialLengthGaussResult.ToString(CultureInfo.InvariantCulture);
            }
            if (axialLengthUnit.Text == "T")
            {
                var axialLengthGaussResult = axialLengthResult * 1E-4;
                axialLengthResultBox.Text = axialLengthGaussResult.ToString(CultureInfo.InvariantCulture);
            }
        }
        /// <summary>
        /// Opens the coil rotation calculator.
        /// </summary>
        private void RotationButtonClick(object sender, EventArgs e)
        {
            if (MagneticFieldCoilRotationCalculator.Instance == false)
            {
                var form = new MagneticFieldCoilRotationCalculator(this);
                form.Show(this);
                MagneticFieldCoilRotationCalculator.Instance = true;
            }
            else if (MagneticFieldCoilRotationCalculator.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Opens the Pythagorean calculator.
        /// </summary>
        private void PythagoreanCalculatorButtonClick(object sender, EventArgs e)
        {
            if (PythagoreanCalculator.Instance == false)
            {
                var form = new PythagoreanCalculator(this);
                form.Show(this);
                PythagoreanCalculator.Instance = true;
            }
            else if (PythagoreanCalculator.Instance)
            {
                // Do nothing.
            }
        }
    }
}
