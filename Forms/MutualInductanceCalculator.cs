using System;
using System.Windows.Forms;

namespace CircuitCalculator
{
    public partial class MutualInductanceCalculator : Form
    {
        private Form owner;
        private static bool instance = false;

        public MutualInductanceCalculator(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            instance = true;
        }
        private void MutualInductanceCalculator_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Calculates the first result.
        /// </summary>
        public double CalculateFirstResult()
        {
            double result = 0;
            double smallerRadius = Convert.ToDouble(firstRadiiValueBox.Text);
            double largerRadius = Convert.ToDouble(secondRadiiValueBox.Text);
            double distance = Convert.ToDouble(distanceValueBox.Text);
            double parametera = smallerRadius / largerRadius;
            double parameterb = distance / largerRadius;
            // Calculate the variable needed for the table lookup.
            double numerator = Math.Pow((1 - (smallerRadius / largerRadius)),2) + ((Math.Pow(distance, 2)) / Math.Pow(largerRadius, 2));
            double denominator = Math.Pow((1 + (smallerRadius / largerRadius)),2) + ((Math.Pow(distance, 2)) / Math.Pow(largerRadius, 2));
            double u = numerator / denominator;
            uResultBox.Text = u.ToString();
            return result;
        }
        /// <summary>
        /// Calculates the mutual inductance.
        /// </summary>
        public double CalculateMutualInductance()
        {
            double result = 0;
            double smallerRadius = Convert.ToDouble(firstRadiiValueBox.Text);
            double largerRadius = Convert.ToDouble(secondRadiiValueBox.Text);
            double distance = Convert.ToDouble(distanceValueBox.Text);
            double alpha = Convert.ToDouble(alphaFunctionValueBox.Text);
            // Calculate the final result.
            result = (alpha * largerRadius) * Math.Sqrt(smallerRadius / largerRadius);
            resultBox.Text = result.ToString();

            return result;
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
        /// Calculate the final result.
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            CalculateMutualInductance();
        }
        /// <summary>
        /// Calculate the first result.
        /// </summary>
        private void calculateFirstResultButton_Click(object sender, EventArgs e)
        {
            CalculateFirstResult();
        }

        private void alphaTableButton_Click(object sender, EventArgs e)
        {
            if (AlphaReferenceTable.Instance == false)
            {
                AlphaReferenceTable form = new AlphaReferenceTable(this);
                form.Show(this);
                AlphaReferenceTable.Instance = true;
            }
            else if (AlphaReferenceTable.Instance == true)
            {
                // Do nothing.
            }
        }

        
    }
}