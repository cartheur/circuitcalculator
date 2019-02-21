using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CircuitCalculator
{
    public partial class EfficiencyCalculator : Form
    {
        private Form owner;
        private static bool instance = false;

        public EfficiencyCalculator(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            instance = true;
        }

        private void EfficiencyCalculator_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 750;
            toolTip.ReshowDelay = 250;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.firstQualityValueBox, "The value for Qi of the first loop.");
            toolTip.SetToolTip(this.secondQualityValueBox, "The value for Qj of the second loop.");
            toolTip.SetToolTip(this.saveEfficiencySelectionBox, "Save the efficiency to the database.");
            toolTip.SetToolTip(this.loadValuesSelectionBox, "Load the values from the database if they have already been calculated previously.");
            toolTip.SetToolTip(this.resultBox, "The efficiency of the scheme.");

        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return instance; } set { instance = value; } }
        /// <summary>
        /// Calculates the two-coil efficiency.
        /// </summary>
        /// <param name="k">The k.</param>
        /// <param name="firstQuality">The first quality.</param>
        /// <param name="secondQuality">The second quality.</param>
        /// <returns>Calculated result.</returns>
        public double CalculateTwoCoilEfficiency(string k, string firstQuality, string secondQuality)
        {
            double result = 0;
            double percentage = 0;
            double kab = Convert.ToDouble(k);
            double qa = Convert.ToDouble(firstQuality);
            double qb = Convert.ToDouble(secondQuality);

            #region Commented

            //if (k1SelectionBox.Checked == true && k2SelectionBox.Checked == true | k1SelectionBox.Checked == false && k2SelectionBox.Checked == false)
            //{
            //    MessageBox.Show("One value for k is necessary for the calculation.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //}
            //if (k1SelectionBox.Checked == true)
            //{
            //    //Get the data from the table.
            //}
            //else if (k2SelectionBox.Checked == true)
            //{
            //    //Get the data from the table.
            //}

            // Calculate the result


            //SaveParameterResult(result, "Efficiency");
            #endregion

            double numerator = ((kab * kab) * qa * qb);
            double denominator = (1 + ((kab * kab) * qa * qb));
            result = numerator / denominator;
            percentage = result * 100;
            resultBox.Text = result.ToString();
            firstPercentageBox.Text = percentage.ToString();

            return result;
        }
        #region Save the parameter into the SQLite database.
        /// <summary>
        /// Saves the parameter result.
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
        /// Calculates the efficiency for two coils.
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (couplingCoefficientValueBox.Text == "" | firstQualityValueBox.Text == "" | secondQualityValueBox.Text == "")
            {
                MessageBox.Show("Value boxes are empty. Unless you have checked to load from the database and there are values stored, zeros will be shown.", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                //Check into how to use the OK-Cancel buttons here.
                couplingCoefficientValueBox.Text = "0";
                firstQualityValueBox.Text = "0";
                secondQualityValueBox.Text = "0";

                CalculateTwoCoilEfficiency(couplingCoefficientValueBox.Text, firstQualityValueBox.Text, secondQualityValueBox.Text);
            }
            else
            {
                CalculateTwoCoilEfficiency(couplingCoefficientValueBox.Text, firstQualityValueBox.Text, secondQualityValueBox.Text);
            }
        }
        /// <summary>
        ///  Calculates the efficiency for four coils.
        /// </summary>
        private void calculateFourCoilButton_Click(object sender, EventArgs e)
        {
            if (kabValueBox.Text == "" | kbcValueBox.Text == "" | kcdValueBox.Text == "" | qaValueBox.Text == "" | qbValueBox.Text == "" | qcValueBox.Text == "" | qdValueBox.Text == "")
            {
                MessageBox.Show("Value boxes are empty. Unless you have checked to load from the database and there are values stored, zeros will be shown.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                kabValueBox.Text = "0";
                kbcValueBox.Text = "0";
                kcdValueBox.Text = "0";
                qaValueBox.Text = "0";
                qbValueBox.Text = "0";
                qcValueBox.Text = "0";
                qdValueBox.Text = "0";

                CalculateFourCoilEfficiency(kabValueBox.Text, kbcValueBox.Text, kcdValueBox.Text, qaValueBox.Text, qbValueBox.Text, qcValueBox.Text, qdValueBox.Text);
            }
            else
            {
                CalculateFourCoilEfficiency(kabValueBox.Text, kbcValueBox.Text, kcdValueBox.Text, qaValueBox.Text, qbValueBox.Text, qcValueBox.Text, qdValueBox.Text);
            }
        }
        /// <summary>
        /// Calculates the four-coil efficiency.
        /// </summary>
        /// <param name="kab">The coupling coefficient of the first significant pair of coils.</param>
        /// <param name="kbc">The coupling coefficient of the second significant pair of coils.</param>
        /// <param name="kcd">The coupling coefficient of the third significant pair of coils.</param>
        /// <param name="qa">The quality factor of the first coil.</param>
        /// <param name="qb">The quality factor of the second coil.</param>
        /// <param name="qc">The quality factor of the third coil.</param>
        /// <param name="qd">The quality factor of the fourth coil.</param>
        /// <returns></returns>
        public double CalculateFourCoilEfficiency(string kabCoupling, string kbcCoupling, string kcdCoupling, string qaFactor, string qbFactor, string qcFactor, string qdFactor)
        {
            double result = 0;
            double percentage = 0;
            double kab = Convert.ToDouble(kabCoupling);
            double kbc = Convert.ToDouble(kbcCoupling);
            double kcd = Convert.ToDouble(kcdCoupling);
            double qa = Convert.ToDouble(qaFactor);
            double qb = Convert.ToDouble(qbFactor);
            double qc = Convert.ToDouble(qcFactor);
            double qd = Convert.ToDouble(qdFactor);

            double numerator = ((kab *kab) * qa * qb) * ((kbc * kbc) * qb * qc) * ((kcd *kcd) * qc * qd);
            double denominator = ((1 + (kab * kab) * qa * qb) * (1 + (kcd * kcd) * qc * qd) + (kbc * kbc) * qb * qc) * (1 + ((kbc * kbc) * qb * qc) + ((kcd * kcd) * qc * qd));
            result = numerator / denominator;
            percentage = result * 100;
            fourCoilResultBox.Text = result.ToString();
            percentageBox.Text = percentage.ToString();

            return result;
        }
        /// <summary>
        /// Calculates the additive Q equation.
        /// </summary>
        private void calculateAdditiveQualityButton_Click(object sender, EventArgs e)
        {
            if (kijValueBox.Text == "" | qiValueBox.Text == "" | qjValueBox.Text == "" | qkValueBox.Text == "" | riValueBox.Text == "" | rjValueBox.Text == "" | rkValueBox.Text == "")
            {
                MessageBox.Show("Value boxes are empty. Unless you have checked to load from the database and there are values stored, zeros will be shown.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                kijValueBox.Text = "0";
                qiValueBox.Text = "0";
                qjValueBox.Text = "0";
                qkValueBox.Text = "0";
                riValueBox.Text = "0";
                rjValueBox.Text = "0";
                rkValueBox.Text = "0";

                CalculateAdditiveQuality(kijValueBox.Text, qiValueBox.Text, qjValueBox.Text, qkValueBox.Text, riValueBox.Text, rjValueBox.Text, rkValueBox.Text);
            }
            else
            {
                CalculateAdditiveQuality(kijValueBox.Text, qiValueBox.Text, qjValueBox.Text, qkValueBox.Text, riValueBox.Text, rjValueBox.Text, rkValueBox.Text);
            }
        }
        /// <summary>
        /// Calculates the additive quality.
        /// </summary>
        /// <param name="kijCoupling">The kij coupling.</param>
        /// <param name="qiFactor">The qi factor.</param>
        /// <param name="qjFactor">The qj factor.</param>
        /// <param name="qkFactor">The qk factor.</param>
        /// <param name="riValue">The ri value.</param>
        /// <param name="rjValue">The rj value.</param>
        /// <param name="rkValue">The rk value.</param>
        public double CalculateAdditiveQuality(string kijCoupling, string qiFactor, string qjFactor, string qkFactor, string riValue, string rjValue, string rkValue)
        {
            double result = 0;
            double percentage = 0;
            double kij = Convert.ToDouble(kijCoupling);
            double qi = Convert.ToDouble(qiFactor);
            double qj = Convert.ToDouble(qjFactor);
            double qk = Convert.ToDouble(qkFactor);
            double ri = Convert.ToDouble(riValue);
            double rj = Convert.ToDouble(rjValue);
            double rk = Convert.ToDouble(rkValue);

            double numerator = 1;
            double denominator = (1 + (1/(Math.Pow(kij, 2))) * ((1 / qi) + (1 / ri)) * ((1 / qj) + (1 / rj)) * ((1 / qk) + (1 / rk)) * ((1 + (rj / qj)) * (1 + (rk / qk))));
            result = numerator / denominator;
            percentage = result * 100;
            additiveQualityResultBox.Text = result.ToString();
            thirdPercentageBox.Text = percentage.ToString();

            return result;
        }
        /// <summary>
        /// Closes the instance of the form.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            instance = false;
            Close();
        }
        /// <summary>
        /// Calls the instance of the Coupling Coefficient Calculator form.
        /// </summary>
        private void couplingCoefficentCacluatorButton_Click(object sender, EventArgs e)
        {
            if (CouplingCoefficientCalculator.Instance == false)
            {
                CouplingCoefficientCalculator form = new CouplingCoefficientCalculator(this);
                form.Show(this);
                CouplingCoefficientCalculator.Instance = true;
            }
            else if (CouplingCoefficientCalculator.Instance == true)
            {
                // Do nothing.
            }
        }
    }
}