using System;
using System.Windows.Forms;
using CircuitCalculator.Classes.Calculus;

namespace CircuitCalculator.CalculusForms
{
    public partial class IntegrationCalculator : Form
    {
        private Form owner;
        private static bool instance = false;

        public IntegrationCalculator(Form mOwner)
        {
            InitializeComponent();
            stepFactor.Text = "20";
            lowerLimitBox.Text = "1";
            upperLimitBox.Text = "10";
            owner = mOwner;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            ControlBox = false;
            instance = true;
        }
        private void IntegrationCalculatorLoad(object sender, EventArgs e)
        {
            var toolTip = new ToolTip {AutoPopDelay = 10000, InitialDelay = 400, ReshowDelay = 250, ShowAlways = true};
            toolTip.SetToolTip(firstVariableValueBox, "The root value to integrate with.");
            toolTip.SetToolTip(trigFunctionSelectionBox, "Select the trigonmetric expression to integrate with.");
            toolTip.SetToolTip(functionBox, "Write out the function, in ASCII.");
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return instance; } set { instance = value; } }

        public static double F1(double x)
        {
            return x * x;
        }
        public double F2(double x)
        {
            double func = x * x * x;
            functionBox.Text = "x^3";
            return func;
        }
        public double F3(double x)
        {
            double func = Math.Exp(x) * Math.Sin(x * x * x);
            functionBox.Text = "Math.Exp(x) * Math.Sin(x * x * x)";
            return func;
        }
        public double F4(double x)
        {
            double func = Math.Exp(x);
            functionBox.Text = "exp(x)";
            return func;
        }
        public double D1(double t, double y)
        {
            double func = -y + t + 1;
            functionBox.Text = "diff(-y + t + 1)";
            return func;//Stopped here.
        }
        /// <summary>
        /// Builds the integrator function to be calculated.
        /// </summary>
        public static double BuildIntegratorFunction(double x)
        {
            double function = x;


            return function;
        }
        
        private void CalculateButtonClick(object sender, EventArgs e)
        {
            double result = 0;

            // The simplest numerical integration algorithm is Simpson's rule. 
            SimpsonIntegrator simpson = new SimpsonIntegrator();
            // You can set the relative or absolute tolerance to which to evaluate the integral.
            //simpson.RelativeTolerance = 1e-5;
             //You can select the type of tolerance using the ConvergenceCriterion property:
            //simpson.ConvergenceCriterion = ConvergenceCriterion.WithinRelativeTolerance;
             //The Integrate method performs the actual integration:
            //result = simpson.Integrate(Math.Sin, 0, 2);
            resultBox.Text = result.ToString();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            double result = 0;
            var numberOfSteps = Convert.ToInt32(stepFactor.SelectedItem);
            var lowerLimit = Convert.ToDouble(lowerLimitBox.Text);
            var upperLimit = Convert.ToDouble(upperLimitBox.Text);
            Cursor.Current = Cursors.WaitCursor;
            result = SimpsonIntegrator.Integrate(F1, lowerLimit, upperLimit, numberOfSteps);
            Cursor.Current = Cursors.Default;
            resultBox.Text = result.ToString();

        }
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void CloseButtonClick(object sender, EventArgs e)
        {
            instance = false;
            Close();
        } 
    }
}