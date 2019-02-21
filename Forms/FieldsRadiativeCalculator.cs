using System;
using System.Globalization;
using System.Windows.Forms;

namespace CircuitCalculator
{
    public partial class FieldsRadiativeCalculator : Form
    {
        private Form owner;
        private static bool instance;
        private const double SpeedOfLight = 2.99792458E8;
        private const double PoyntingSolution = 1E-15*0.8249;
        private const double MagneticPermeability = 4 * Math.PI * 1E-7;

        public FieldsRadiativeCalculator(Form mOwner)
        {
            InitializeComponent();
            inputCurrentFactor.Text = "A";
            radiusFactor.Text = "cm";
            //axialLengthFactor.Text = "cm";
            resistiveLossesValueBox.Text = "0";
            dipoleDistanceFactor.Text = "cm";
            frequencyFactor.Text = "Hz";
            conductivityMaterialSelection.Text = "Air";
            owner = mOwner;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            ControlBox = false;
            instance = true;
        }
        private void RadiationResistanceCalculatorLoad(object sender, EventArgs e)
        {
            var toolTip = new ToolTip {AutoPopDelay = 10000, InitialDelay = 400, ReshowDelay = 250, ShowAlways = true};
            toolTip.SetToolTip(calculateFieldsButton, "Calculate energy in the fields.");
            toolTip.SetToolTip(resonanceFrequencyPictureBox, "The resonance frequency of the circuit.");
            toolTip.SetToolTip(dipoleDistancePictureBox, "The distance from the dipole, which in the case of a circular loop is the observation distance since the dipole lies in the x-y plane.");
            toolTip.SetToolTip(depthPenetrationPictureBox, "The depth of penetration of the antenna field.");
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
        /// Calculates the electric field.
        /// </summary>
        protected double CalculateElectricField()
        {
            double result = 0;
            double inputCurrent = 0;
            double frequency = 0;
            double loopRadius = 0;
            double lambda = 0;
            double loopArea = 0;
            double area = 0;
            double dipoleDistance = 0;

            double tempFrequency = Convert.ToDouble(frequencyValueBox.Text);
            double tempCurrent = Convert.ToDouble(inputCurrentValueBox.Text);
            double tempLoopRadius = Convert.ToDouble(radiusValueBox.Text);
            double tempdipoleDistance = Convert.ToDouble(dipoleDistanceValueBox.Text);

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
            if (radiusFactor.Text == "cm")
            {
                loopRadius = tempLoopRadius * 1E-2;
            }
            if (radiusFactor.Text == "mm")
            {
                loopRadius = tempLoopRadius * 1E-3;
            }
            if (dipoleDistanceFactor.Text == "m")
            {
                dipoleDistance = tempdipoleDistance;
            }
            if (dipoleDistanceFactor.Text == "cm")
            {
                dipoleDistance = tempdipoleDistance * 1E-2;
            }
            if (dipoleDistanceFactor.Text == "mm")
            {
                dipoleDistance = tempdipoleDistance * 1E-3;
            }
            // Calculate the result.
            lambda = CalculateLambda(frequency);
            loopArea = Math.PI * Math.Pow(loopRadius, 2);
            // Using Kraus d^2 = Pi*r^2 for an approximation of a square loop as equal for small loops, pp.197-8.
            area = loopArea;
            var firstNumerator = (120 * Math.Pow(Math.PI, 2)) * inputCurrent;
            var firstResult = firstNumerator / dipoleDistance;
            var secondResult = area / (Math.Pow(lambda, 2));

            result = firstResult * secondResult;
            electricFieldSolutionBox.Text = result.ToString(CultureInfo.InvariantCulture);

            CalculateMagneticField(result);
            var radiationResistance = CalculateRadiationResistance(area, lambda);
            CalculateRadiatedPower(inputCurrent, radiationResistance);
            var circumference = 2 * Math.PI * loopRadius;
            var circumferenceCm = circumference * 1E2;
            circumferenceSolutionBox.Text = circumferenceCm.ToString(CultureInfo.InvariantCulture);
            CalculateDirectivity(circumference);
            var radiationEfficiencyFactor = CalculateRadiationEfficiencyFactor(radiationResistance);
            CalculateGain(radiationEfficiencyFactor, area, lambda);
            CalculateDepthPenetration();

            return result;
        }
        /// <summary>
        /// Calculates the magnetic field.
        /// </summary>
        protected double CalculateMagneticField(double electricField)
        {
            double result = 0;
            result = electricField / (120 * Math.PI);
            magneticFieldSolutionBox.Text = result.ToString(CultureInfo.InvariantCulture);

            return result;
        }
        /// <summary>
        /// Calculates the radiated power.
        /// </summary>
        protected double CalculateRadiatedPower(double inputCurrent, double radiationResistance)
        {
            double result = 0;
            poyntingSolutionBox.Text = PoyntingSolution.ToString(CultureInfo.InvariantCulture);
            result = (Math.Pow(inputCurrent, 2) / 2) * radiationResistance;
            radiatedPowerSolutionBox.Text = result.ToString(CultureInfo.InvariantCulture);

            return result;
        }
        /// <summary>
        /// Calculates the radiation resistance.
        /// </summary>
        /// <param name="area">The area of the loop.</param>
        /// <param name="lambda">The wavelength.</param>
        /// <returns>The radiation resistance.</returns>
        protected double CalculateRadiationResistance(double area, double lambda)
        {
            double result = 0;
            double turns = Convert.ToDouble(turnsTextBox.Text);
            const double poyntingLoopConstant = 31200;
            double term = Math.Pow(turns * (area / Math.Pow(lambda, 2)), 2);
            result = poyntingLoopConstant * term;

            radiationResistanceSolutionBox.Text = result.ToString(CultureInfo.InvariantCulture);

            return result;
        }
        /// <summary>
        /// Calculates the directivity.
        /// </summary>
        /// <param name="circumference">The circumference.</param>
        protected double CalculateDirectivity(double circumference)
        {
            double result = 1.76;
            directivitySolutionBox.Text = result.ToString(CultureInfo.InvariantCulture);
            
            return result;
        }
        /// <summary>
        /// Calculates the radiation efficiency factor.
        /// </summary>
        /// <param name="radiationResistance">The radiation resistance.</param>
        protected double CalculateRadiationEfficiencyFactor(double radiationResistance)
        {
            double result = 0;
            double ohmicResistance = Convert.ToDouble(resistiveLossesValueBox.Text);
            double denominator = radiationResistance + ohmicResistance;
            result = radiationResistance / denominator;
            radiationEfficiencySolutionBox.Text = result.ToString(CultureInfo.InvariantCulture);

            return result;
        }
        /// <summary>
        /// Calculates the gain.
        /// </summary>
        /// <param name="radiationEfficiencyFactor">The radiation efficiency factor.</param>
        /// <param name="area">The area.</param>
        /// <param name="lambda">The lambda.</param>
        protected double CalculateGain(double radiationEfficiencyFactor, double area, double lambda)
        {
            double result = 0;
            double term = ((4 * Math.PI) * area) / Math.Pow(lambda, 2);
            result = radiationEfficiencyFactor * term;
            gainSolutionBox.Text = result.ToString(CultureInfo.InvariantCulture);

            return result;
        }
        /// <summary>
        /// Calculates the depth penetration.
        /// </summary>
        protected double CalculateDepthPenetration()
        {
            double result = 0;
            double frequency = Convert.ToDouble(frequencyValueBox.Text);
            double conductivity = Convert.ToDouble(conductivityMaterialValue.Text);
            double denominator = Math.Sqrt(frequency * MagneticPermeability * conductivity * Math.PI);
            result = (1 / denominator) * 1E2;
            depthPenetrationSolutionBox.Text = result.ToString(CultureInfo.InvariantCulture);

            return result;
        }
        /// <summary>
        /// Calculates the lambda.
        /// </summary>
        /// <param name="frequency">The frequency.</param>
        protected double CalculateLambda(double frequency)
        {
            double result = 0;
            result = SpeedOfLight / frequency;
            return result;
        }
        /// <summary>
        /// Calculates the power in the fields.
        /// </summary>
        /// <returns></returns>
        protected double CalculateFieldsPower()
        {
            double result = 0;

            return result;
        }
        /// <summary>
        /// Calculates radiation properties.
        /// </summary>
        /// <returns></returns>
        protected double CalculateRadiationProperties()
        {
            double result = 0;

            return result;
        }
        /// <summary>
        /// Inputs the conductivity based on the material selection.
        /// </summary>
        private void ConductivityMaterialSelectionSelectedIndexChanged(object sender, EventArgs e)
        {
            if (conductivityMaterialSelection.SelectedItem.ToString() == "Copper")
            {
                conductivityMaterialValue.Text = "5.96E7";
            }
            if (conductivityMaterialSelection.SelectedItem.ToString() == "Aluminum")
            {
                conductivityMaterialValue.Text = "3.50E7";
            }
            if (conductivityMaterialSelection.SelectedItem.ToString() == "Silver")
            {
                conductivityMaterialValue.Text = "6.30E7";
            }
            if (conductivityMaterialSelection.SelectedItem.ToString() == "Gold")
            {
                conductivityMaterialValue.Text = "4.52E7";
            }
            if (conductivityMaterialSelection.SelectedItem.ToString() == "Air")
            {
                conductivityMaterialValue.Text = "3.8E-15";
            }
        }
        /// <summary>
        /// Calculates the field and energy phenomenon.
        /// </summary>
        private void CalculateFieldsButtonClick(object sender, EventArgs e)
        {
            CalculateElectricField();
        }
        private void ResistiveLossesButtonClick(object sender, EventArgs e)
        {
            if (ResistiveRadiativeLossesCalculator.Instance == false)
            {
                var form = new ResistiveRadiativeLossesCalculator(this);
                form.Show(this);
                ResistiveRadiativeLossesCalculator.Instance = true;
            }
            else if (ResistiveRadiativeLossesCalculator.Instance == true)
            {
                // Do nothing.
            }
        }

    }
}
