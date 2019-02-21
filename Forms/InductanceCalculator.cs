using System;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace CircuitCalculator.Forms
{
    public partial class InductanceCalculator : Form
    {
        private Form _owner;
        private static bool _instance;

        public InductanceCalculator(Form mOwner)
        {
            InitializeComponent();
            _owner = mOwner;
            relativePermeabilityMediumTextBox.Text = "4π * 10E-7";//12.56637E-7
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            ControlBox = false;
            _instance = true;
            sessionValue.Text = (string)AppDomain.CurrentDomain.GetData("SessionID");
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return _instance; } set { _instance = value; } }
        /// <summary>
        /// The load event for the inductance calculator form.
        /// </summary>
        private void InductanceCalculatorLoad(object sender, EventArgs e)
        {
            wireRadiusFactor.SelectedItem = "mm";
            radiusFactor.SelectedItem = "cm";
            litzWireLengthFactor.SelectedItem = "cm";
            var toolTip = new ToolTip {AutoPopDelay = 10000, InitialDelay = 400, ReshowDelay = 200, ShowAlways = true};
            toolTip.SetToolTip(circularLoopPictureBox, "A depiction of the circular loop");
            toolTip.SetToolTip(turnsTextBox, "Number of Turns");
            toolTip.SetToolTip(radiusTextBox, "Radius of the Circle");
            toolTip.SetToolTip(radiusFactor, "Dimension of the Radius");
            toolTip.SetToolTip(wireRadiusTextBox, "Radius of the Wire");
            toolTip.SetToolTip(wireRadiusFactor, "Dimension of the Wire Radius");
            toolTip.SetToolTip(relativePermeabilityMediumTextBox, "Relative Permeability of the Medium");
            toolTip.SetToolTip(relativePermeabilityMaterialTextBox, "Relative Permeability of the Material. For magnetic levitation a permeability below 1 is needed.");
            toolTip.SetToolTip(permeabilityMaterialComboBox, "The Material Consisting the Wire");
            toolTip.SetToolTip(flowConstantTextBox, "The Flow Contant");
            toolTip.SetToolTip(flowConstantComboBox, "Is either homogenous or due to the skin effect.");
            toolTip.SetToolTip(inductanceEquationPictureBox, "The Equation of the Inductance of a Circular Loop");
            toolTip.SetToolTip(calculateButton, "Calculate the Result");
            toolTip.SetToolTip(resultBox, "The inducatnce of the wire loop");
            toolTip.SetToolTip(linzWindingSelectionBox, "Is the circular loop a linz wire? If so, check this box.");
            toolTip.SetToolTip(litzWireLengthTextBox1, "The length of the wire legs leading to the circular loop");
            toolTip.SetToolTip(litzWireLengthFactor, "Dimension of the Wire Length");
            toolTip.SetToolTip(calculateLitzLegsButton, "Calculate the contribution of the Litz wire legs.");
            toolTip.SetToolTip(linzWIrePictureBox, "A depiction of the loop with legs");
            toolTip.SetToolTip(wireLegsResultBox, "The inductance of the legs plus the loop");
            toolTip.SetToolTip(closeButton, "Close the Inductance Calculator form");
            toolTip.SetToolTip(spiralCalculatorButton, "Spiral Loop Inductance Calculator");
            toolTip.SetToolTip(numberOfLegsPictureBox, "The number of legs in the Litz winding.");
        }
        /// <summary>
        /// Inputs the permability based on the material selection.
        /// </summary>
        private void PermeabilityMaterialComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (permeabilityMaterialComboBox.SelectedItem.ToString() == "Cu")
            {
                relativePermeabilityMaterialTextBox.Text = "0.999994";
            }
            if (permeabilityMaterialComboBox.SelectedItem.ToString() == "Al")
            {
                relativePermeabilityMaterialTextBox.Text = "1.000022";
            }
            if (permeabilityMaterialComboBox.SelectedItem.ToString() == "Air")
            {
                relativePermeabilityMaterialTextBox.Text = "1.00000037";
            }
            if (permeabilityMaterialComboBox.SelectedItem.ToString() == "E. Steel")
            {
                relativePermeabilityMaterialTextBox.Text = "4000";
            }
        }

        private void FlowConstantComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (flowConstantComboBox.SelectedItem.ToString() == "homogenous")
            {
                flowConstantTextBox.Text = "0";
            }
            if (flowConstantComboBox.SelectedItem.ToString() == "skin effect")
            {
                flowConstantTextBox.Text = "0.25";
            }
        }

        private void CalculateButtonClick(object sender, EventArgs e)
        {
            CalculateInductance(turnsTextBox.Text, radiusTextBox.Text, wireRadiusTextBox.Text);
        }
        /// <summary>
        /// Calculates the inductance.
        /// </summary>
        /// <param name="number">The number of turns.</param>
        /// <param name="cRadius">The circle radius.</param>
        /// <param name="wRadius">The wire radius.</param>
        public double CalculateInductance(string number, string cRadius, string wRadius)
        {
            double circleRadius = 0;
            double wireRadius = 0;

            double numberOfTurns = Convert.ToDouble(turnsTextBox.Text);
            double tempCircleRadius = Convert.ToDouble(radiusTextBox.Text);
            double tempWireRadius = Convert.ToDouble(wireRadiusTextBox.Text);
            const double relativePermeability = 12.56637E-7;
            double relativePermeabilityMaterial = Convert.ToDouble(relativePermeabilityMaterialTextBox.Text);
            double flowConstant = Convert.ToDouble(flowConstantTextBox.Text);

            if (radiusFactor.Text == "cm")
            {
                circleRadius = tempCircleRadius * 1E-2;
            }
            if (radiusFactor.Text == "mm")
            {
                circleRadius = tempCircleRadius * 1E-3;
            }
            if (wireRadiusFactor.Text == "cm")
            {
                wireRadius = tempWireRadius * 1E-2;
            }
            if (wireRadiusFactor.Text == "mm")
            {
                wireRadius = tempWireRadius * 1E-3;
            }
            // Perform the calculation.
            double first = (numberOfTurns * numberOfTurns) * circleRadius * relativePermeability * relativePermeabilityMaterial;
            double last = ((8 * circleRadius) / wireRadius);
            //double tempp = Math.Log(last) - 2;
            double result = first * ((Math.Log(last) - 2) + flowConstant);
            //result = first * tempp + flowConstant;

            resultBox.Text = result.ToString();
            return result;
        }
        /// <summary>
        /// Calculates the addition of the Litz leg inductance.
        /// </summary>
        /// <param name="numberOfLegs">The number of legs supporting the loop.</param>
        /// <param name="wDiameter">The wire diameter.</param>
        /// <param name="wLength">Length of the wire.</param>
        public double CalculateLitzInductance()
        {
            double wireLength = 0;
            //double numberOfLegs = Convert.ToDouble(litzWireNumberLegsTextBox.Text);
            double wireDiameter = 1E-1 * (2 * (Convert.ToDouble(wireRadiusTextBox.Text)));
            double legWireLength1 = Convert.ToDouble(litzWireLengthTextBox1.Text);
            double legWireLength2 = Convert.ToDouble(litzWireLengthTextBox2.Text);
            double legWireLength3 = Convert.ToDouble(litzWireLengthTextBox3.Text);
            double materialPermeability = Convert.ToDouble(relativePermeabilityMaterialTextBox.Text);
            double previousResult = Convert.ToDouble(resultBox.Text);

            if (litzWireLengthFactor.Text == "cm")
            {
                wireLength = legWireLength1 + legWireLength2 + legWireLength3; /* * 1E-2*/
            }
            if (litzWireLengthFactor.Text == "mm")
            {
                wireLength = (legWireLength1 + legWireLength2 + legWireLength3) * 1E-1;
            }
            // Calculate the result.
            // http://www.consultrsr.com/resources/eis/induct5.htm
            // Simple
            var result = (2 * wireLength) * (2.303 * Math.Log(((4 * wireLength) / wireDiameter) - 1 + (materialPermeability / 4) + (wireDiameter / (2 * wireLength)), 10)); // in cm.
            //
            var totalResult = (result * 1E-9) + previousResult;
            wireLegsResultBox.Text = result.ToString(CultureInfo.InvariantCulture);
            totalResultBox.Text = totalResult.ToString(CultureInfo.InvariantCulture);

            return result;
        }

        private void LinzWindingSelectionBoxClick(object sender, EventArgs e)
        {
            if (resultBox.Text == "")
            {
                MessageBox.Show("Input the values for the circular loop before trying to calculate the legs", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                linzWindingSelectionBox.Checked = false;
            }
            else if (resultBox.Text != "")
                calculateLitzLegsButton.Enabled = true;
        }
        /// <summary>
        /// Cleans up resources and closes the form.
        /// </summary>
        private void CloseButtonClick(object sender, EventArgs e)
        {
            _instance = false;
            Close();
            SpiralInductanceCalculator.Instance = false;
        }
        /// <summary>
        /// Stores the calculation to the database.
        /// </summary>
        private void ViewCalculationButtonClick(object sender, EventArgs e)
        {
            if (StoreCalculationData.Instance == false)
            {
                var form = new StoreCalculationData(this);
                form.Show(this);
                StoreCalculationData.Instance = true;
            }
            else if (StoreCalculationData.Instance == true)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Opens an instance of the spiral calculator form.
        /// </summary>
        private void SpiralCalculatorButtonClick(object sender, EventArgs e)
        {
            if (SpiralInductanceCalculator.Instance == false)
            {
                var form = new SpiralInductanceCalculator(this);
                form.Show(this);
                SpiralInductanceCalculator.Instance = true;
            }
            else if (SpiralInductanceCalculator.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Calculates the Litz legs inducatance contribution.
        /// </summary>
        private void CalculateLitzLegsButtonClick(object sender, EventArgs e)
        {
            CalculateLitzInductance();
        }
        /// <summary>
        /// Stores the calculation.
        /// </summary>
        private void StoreCalculationButtonClick(object sender, EventArgs e)
        {
            // CONTINUE HERE ------------------>
            StoreData(turnsTextBox.Text, radiusTextBox.Text, radiusFactor.SelectedItem.ToString(), wireRadiusTextBox.Text, relativePermeabilityMaterialTextBox.Text, flowConstantTextBox.Text);
        }
        /// <summary>
        /// Opens an instance of the solenoid calculator form.
        /// </summary>
        private void SolenoidCalculatorButtonClick(object sender, EventArgs e)
        {
            if (AirCoreInductanceCalculator.Instance == false)
            {
                var form = new AirCoreInductanceCalculator(this);
                form.Show(this);
                AirCoreInductanceCalculator.Instance = true;
            }
            else if (AirCoreInductanceCalculator.Instance)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Stores the inductance data.
        /// </summary>
        /// <param name="numberOfTurns">The number of turns.</param>
        /// <param name="loopRadius">The loop radius.</param>
        /// <param name="radiusFactor">The loop radius factor.</param>
        /// <param name="wireRadius">The wire radius.</param>
        /// <param name="permeabilityMaterial">The permeability of the material.</param>
        /// <param name="flowConstant">The flow constant.</param>
        protected void StoreData(string numberOfTurns, string loopRadius, string radiusFactor, string wireRadius, string permeabilityMaterial, string flowConstant)
        {
            try
            {
                // Store the session ID, batch, and frequency.
                string directory = MapPath(@"\db\sessions.db");
                string path = @"c:\Users\ctucker\aeonProjectDirectory\Monkey-Man\thesis\circuits\CircuitCalculator";

                SQLiteConnection conn = new SQLiteConnection(@"Data Source=" + path + directory);
                SQLiteCommand cmd = new SQLiteCommand();
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO InductanceData (SessionID, NumberOfTurns, LoopRadius, LoopRadiusFactor, WireRadius, PermeabilityOfMaterial, FlowConstant) VALUES ('" + sessionValue.Text + "', '" + numberOfTurns + "', '" + loopRadius + "', '" + radiusFactor + "', '" + wireRadius + "', '" + permeabilityMaterial + "', '" + flowConstant + "')";
                conn.Open();
                SQLiteTransaction trans = conn.BeginTransaction();
                cmd.ExecuteNonQuery();
                trans.Commit();
                conn.Close();
                trans.Dispose();
                cmd.Dispose();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                MessageBox.Show("Inductance calculation saved succesfully.", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
        /// <summary>
        /// Maps the path of the executing file.
        /// </summary>
        /// <param name="path">The path to map.</param>
        public virtual string MapPath(string path)
        {
            string location = System.Reflection.Assembly.GetEntryAssembly().Location;
            string zebra = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            string local = Environment.CurrentDirectory;
            return Path.Combine(zebra, path);
        }

        

    }
}
