using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
//using MathNet.Numerics;
using CircuitCalculator.Numbers;

namespace CircuitCalculator
{
    /// <summary>
    /// For help on understanding where to start the computational art: http://www.codeproject.com/Articles/17425/A-Vector-Type-for-C
    /// </summary>
    public partial class VectorPotentialCalculator : Form
    {
        private Form owner;
        double result = 0;

        public VectorPotentialCalculator(Form mOwner)
        {
            InitializeComponent();
            fcCurrentValueBox.Text = "1.1";
            fcRadiusValueBox.Text = "2.5";
            fcCurrentFactor.Text = "A";
            fcRadiusFactor.Text = "cm";
            //differentialLineValueBox.Text = "-1.6023844";// this is for Pi/2. For Pi = -3.2047687. For 2*Pi = -6.4095374.
            differentialLineUnits.Text = "Pi/2";
            resultUnit.Text = "V·s/m";
            owner = mOwner;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            ControlBox = false;
            Instance = true;
            var toolTip = new ToolTip { AutoPopDelay = 10000, InitialDelay = 400, ReshowDelay = 250, ShowAlways = true };
            toolTip.SetToolTip(magPotCurrentSourcePictureBox, "The vector potential is defined to be consistent with Ampere's Law and can be expressed in terms of either current i or current density j (the sources of magnetic field). In the SI system, the units of A are V·s·m−1 and are the same as that of momentum per unit charge.");
            toolTip.SetToolTip(magPotCurrentDensityPictureBox, "One rationale for the vector potential is that it may be easier to calculate the vector potential than to calculate the magnetic field directly from a given source current geometry. Its most common application is to antenna theory and the description of electromagnetic waves.");
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get; set; }
        /// <summary>
        /// Calculates the result.
        /// </summary>
        /// <returns></returns>
        public double CalculateResult()
        {
            double current = 0;
            double radius = 0;
            double diffLine = 1;

            double tempCurrent = Convert.ToDouble(fcCurrentValueBox.Text);
            double tempRadius = Convert.ToDouble(fcRadiusValueBox.Text);

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
            if (differentialLineUnits.Text == "Pi/2")
            {
                diffLine = -1.6023844;
            }
            if (differentialLineUnits.Text == "Pi")
            {
                diffLine = -3.2047687;
            }
            if (differentialLineUnits.Text == "2*Pi")
            {
                diffLine = -6.4095374;
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
            result = ((Constants.RelativePermeability * current) / (4 * Math.PI)) * (diffLine / radius);// * 1E4;
            resultBox.Text = result.ToString(CultureInfo.InvariantCulture);

            return result;
        }
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            Instance = false;
            Close();
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

        private void calculateButton_Click(object sender, EventArgs e)
        {
            CalculateResult();
        }
    }
}