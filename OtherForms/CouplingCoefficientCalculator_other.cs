using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CircuitCalculator
{
    public partial class CouplingCoefficientCalculator_other : Form
    {
        private Form owner;
        private static bool instance = false;

        public CouplingCoefficientCalculator_other(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            instance = true;
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return instance; } set { instance = value; } }

        private void CouplingCoefficientCalculator_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 750;
            toolTip.ReshowDelay = 250;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.mutualInductanceValueBox, "The Calculated value of Mutual Inductance in the Circuit");
            toolTip.SetToolTip(this.mutualInductanceFactor, "The Dimension of the Mutual Inductance");
            toolTip.SetToolTip(this.aInductanceValueBox, "The Self-Inductance of the first Coil in the Circuit");
            toolTip.SetToolTip(this.aInductanceFactor, "The Dimension of the Inductance");
            toolTip.SetToolTip(this.bInductanceValueBox, "The Self-Inductance of the second Coil in the Circuit");
            toolTip.SetToolTip(this.bInductanceFactor, "The Dimension of the Inductance");
            toolTip.SetToolTip(this.angularFrequencyValueBox, "The Excited frequency inherent in the Circuit");
            toolTip.SetToolTip(this.angularFrequencyUnit, "The Unit of Oscillation Used");
            toolTip.SetToolTip(this.k1PictureBox, "The common form of the coupling coefficient");
            toolTip.SetToolTip(this.k1CheckBox, "Check this box if you want to calculate this equation");
            toolTip.SetToolTip(this.saveK1SelectionBox, "Select if you want to calculate for efficiency later.");
            toolTip.SetToolTip(this.k2PictureBox, "A modified form of the coupling coefficient");
            toolTip.SetToolTip(this.k2CheckBox, "Check this box if you want to calculate this equation");
            toolTip.SetToolTip(this.saveK2SelectionBox, "Select if you want to calculate for efficiency later.");
        }
        /// <summary>
        /// Calculates the first instance of the coupling coefficient.
        /// </summary>
        /// <param name="m">The mutual inductance.</param>
        /// <param name="la">The first inductance.</param>
        /// <param name="lb">The second inductance.</param>
        private double CalculateFirstK(string m, string la, string lb)
        {
            double result = 0;
            double mutualInductance = 0;
            double firstInductance = 0;
            double secondInductance = 0;

            double tempMutualInductance = Convert.ToDouble(mutualInductanceValueBox.Text);
            double tempFirstInductance = Convert.ToDouble(aInductanceValueBox.Text);
            double tempSecondInductance = Convert.ToDouble(bInductanceValueBox.Text);

            #region Mutual Inductance Factor
            if (mutualInductanceFactor.Text == "mH")
            {
                mutualInductance = tempMutualInductance * 1E-3;
            }
            if (mutualInductanceFactor.Text == "uH")
            {
                mutualInductance = tempMutualInductance * 1E-6;
            }
            if (mutualInductanceFactor.Text == "nH")
            {
                mutualInductance = tempMutualInductance * 1E-9;
            }
            if (mutualInductanceFactor.Text == "pH")
            {
                mutualInductance = tempMutualInductance * 1E-12;
            }
            #endregion
            #region First Inductance Factor
            if (aInductanceFactor.Text == "mH")
            {
                firstInductance = tempFirstInductance * 1E-3;
            }
            if (aInductanceFactor.Text == "uH")
            {
                firstInductance = tempFirstInductance * 1E-6;
            }
            if (aInductanceFactor.Text == "nH")
            {
                firstInductance = tempFirstInductance * 1E-9;
            }
            if (aInductanceFactor.Text == "pH")
            {
                firstInductance = tempFirstInductance * 1E-12;
            }
            #endregion
            #region Second Inductance Factor
            if (bInductanceFactor.Text == "mH")
            {
                secondInductance = tempSecondInductance * 1E-3;
            }
            if (bInductanceFactor.Text == "uH")
            {
                secondInductance = tempSecondInductance * 1E-6;
            }
            if (bInductanceFactor.Text == "nH")
            {
                secondInductance = tempSecondInductance * 1E-9;
            }
            if (bInductanceFactor.Text == "pH")
            {
                secondInductance = tempSecondInductance * 1E-12;
            }
            #endregion
            
            // Perform the calculation.
            double sqrt = Math.Sqrt(firstInductance * secondInductance);
            result = mutualInductance / sqrt;
            resultBox.Text = result.ToString();

            if (saveK1SelectionBox.Checked == true)
            {
                SaveParameterResult(result, "CouplingCoefficient1");
            }

            return result;
        }
        /// <summary>
        /// Calculates the second instance of the coupling coefficient.
        /// </summary>
        /// <param name="m">The mutual inductance.</param>
        /// <param name="la">The first inductance.</param>
        /// <param name="lb">The second inductance.</param>
        /// <param name="omega">The oscillation frequency.</param>
        private double CalculateSecondK(string m, string la, string lb, string omega)
        {
            double result = 0;
            double mutualInductance = 0;
            double firstInductance = 0;
            double secondInductance = 0;
            double angularFrequency = 0;

            double tempMutualInductance = Convert.ToDouble(mutualInductanceValueBox.Text);
            double tempFirstInductance = Convert.ToDouble(aInductanceValueBox.Text);
            double tempSecondInductance = Convert.ToDouble(bInductanceValueBox.Text);
            double tempAngularFrequency = Convert.ToDouble(angularFrequencyValueBox.Text);

            #region Mutual Inductance Factor
            if (mutualInductanceFactor.Text == "mH")
            {
                mutualInductance = tempMutualInductance * 1E-3;
            }
            if (mutualInductanceFactor.Text == "uH")
            {
                mutualInductance = tempMutualInductance * 1E-6;
            }
            if (mutualInductanceFactor.Text == "nH")
            {
                mutualInductance = tempMutualInductance * 1E-9;
            }
            if (mutualInductanceFactor.Text == "pH")
            {
                mutualInductance = tempMutualInductance * 1E-12;
            }
            #endregion
            #region First Inductance Factor
            if (aInductanceFactor.Text == "mH")
            {
                firstInductance = tempFirstInductance * 1E-3;
            }
            if (aInductanceFactor.Text == "uH")
            {
                firstInductance = tempFirstInductance * 1E-6;
            }
            if (aInductanceFactor.Text == "nH")
            {
                firstInductance = tempFirstInductance * 1E-9;
            }
            if (aInductanceFactor.Text == "pH")
            {
                firstInductance = tempFirstInductance * 1E-12;
            }
            #endregion
            #region Second Inductance Factor
            if (bInductanceFactor.Text == "mH")
            {
                secondInductance = tempSecondInductance * 1E-3;
            }
            if (bInductanceFactor.Text == "uH")
            {
                secondInductance = tempSecondInductance * 1E-6;
            }
            if (bInductanceFactor.Text == "nH")
            {
                secondInductance = tempSecondInductance * 1E-9;
            }
            if (bInductanceFactor.Text == "pH")
            {
                secondInductance = tempSecondInductance * 1E-12;
            }
            #endregion
            #region Angular Frequency Factor
            if (angularFrequencyUnit.Text == "rad/s")
            {
                angularFrequency = tempAngularFrequency;
            }
            if (angularFrequencyUnit.Text == "Hz")
            {
                angularFrequency = tempAngularFrequency / (2 * Math.PI);
            }
            #endregion

            // Perform the calculation.
            double sqrt = 2 * (Math.Sqrt(firstInductance * secondInductance));
            result = (angularFrequency * mutualInductance) / sqrt;
            k2ResultBox.Text = result.ToString();

            if (saveK2SelectionBox.Checked == true)
            {
                SaveParameterResult(result, "CouplingCoefficient2");
            }

            return result;
        }

        #region Save the parameter into the SQLite database.
        /// <summary>
        /// Saves the parameter result into the SQLite database.
        /// </summary>
        /// <param name="result">The returned result.</param>
        /// <param name="table">The table where the value is stored.</param>
        protected void SaveParameterResult(double result, string column)
        {
            string directory = MapPath(@"\db\parameters.db");
            string path = @"c:\Users\ctucker\aeonProjectDirectory\Monkey-Man\thesis\circuits\CircuitCalculator";

            SQLiteConnection conn = new SQLiteConnection(@"Data Source=" + path + directory);
            SQLiteCommand cmd = new SQLiteCommand();
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Parameter (" + column + ") VALUES ('" + result + "')";
            conn.Open();
            SQLiteTransaction trans = conn.BeginTransaction();
            cmd.ExecuteNonQuery();
            trans.Commit();
            conn.Close();
            trans.Dispose();
            cmd.Dispose();
            conn.Dispose();
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
        #endregion

        /// <summary>
        /// Handles the Click event of the calculateButton control.
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (k1CheckBox.Checked)
            {
                CalculateFirstK(mutualInductanceValueBox.Text, aInductanceValueBox.Text, bInductanceValueBox.Text);
            }
            if (k2CheckBox.Checked)
            {
                CalculateSecondK(mutualInductanceValueBox.Text, aInductanceValueBox.Text, bInductanceValueBox.Text, angularFrequencyValueBox.Text);
            }
            else if (k1CheckBox.Checked != true && k2CheckBox.Checked != true)
            {
                MessageBox.Show("Select a 'k' operation to perform.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        /// <summary>
        /// Opens an instance of the Efficiency Calculator.
        /// </summary>
        private void efficiencyCalculatorButton_Click(object sender, EventArgs e)
        {
            if (EfficiencyCalculator.Instance == false)
            {
                EfficiencyCalculator form = new EfficiencyCalculator(this);
                form.Show(this);
                EfficiencyCalculator.Instance = true;
            }
            else if (EfficiencyCalculator.Instance == true)
            {
                // Do nothing.
            }
        }
    }
}
