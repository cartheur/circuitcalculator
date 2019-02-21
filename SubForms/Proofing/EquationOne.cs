using System;
using System.Drawing;
using System.Windows.Forms;

namespace CircuitCalculator.SubForms.Proofing
{
    public partial class EquationOne : Form
    {
        private readonly Timer _grow;
        private readonly Form _owner;
        private static bool _instance;

        public EquationOne(Form mOwner)
        {
            InitializeComponent();
            _owner = mOwner;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.Manual;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            this.Size = new Size(400, 400);
            _grow = new Timer {Interval = 30, Enabled = false};
            _grow.Tick += GrowForm;
            GrowForm(this, EventArgs.Empty);
            _owner.LocationChanged += ParentMoved;
            _instance = true;
        }
        private void EquationOneLoad(object sender, EventArgs e)
        {
            yesEquivalencyButton.Visible = false;
            noEquivalencyButton.Visible = false;
            var toolTip = new ToolTip {AutoPopDelay = 10000, InitialDelay = 400, ReshowDelay = 250, ShowAlways = true};
            toolTip.SetToolTip(this.omegaZero, "Input frequency and it will automatically convert to rad/s.");
        }
        /// <summary>
        /// Allows the form to grow.
        /// </summary>
        private void GrowForm(object sender, EventArgs e)
        {
            int w = this.Size.Width;
            if (w >= 200) _grow.Enabled = false;
            this.Bounds = new Rectangle(_owner.Right - w + 410, _owner.Top, w, w);
        }
        /// <summary>
        /// Allows the form to move with its parent.
        /// </summary>
        private void ParentMoved(object sender, EventArgs e)
        {
            if (_grow.Enabled) return;
            int w = this.Size.Width;
            this.Bounds = new Rectangle(_owner.Right - w + 410, _owner.Top, w, w);
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return _instance; } set { _instance = value; } }

        #region Click Events
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void closeButton_Click(object sender, System.EventArgs e)
        {
            _instance = false;
            Close();
        }
        #endregion

        /// <summary>
        /// Calculates the result.
        /// </summary>
        private void CalculateButtonClick(object sender, EventArgs e)
        {
            double lhs = CalculateLhs();
            double rhs = CalculateRhs();

            if (lhs == rhs)
            {
                yesEquivalencyButton.Visible = true;
                yesEquivalencyButton.BackColor = Color.LightGreen;
            }
            else if (lhs != rhs)
            {
                noEquivalencyButton.Visible = true;
                noEquivalencyButton.BackColor = Color.Red;
            }


        }
        protected double CalculateRhs()
        {
            double result = 0;
            double omega = 0;
            double final = 0;
            double inductance = 0;
            double capacitance = 0;

            double tempInductance = Convert.ToDouble(inductanceValueBox.Text);
            double tempCapacitance = Convert.ToDouble(capacitanceValueBox.Text);

            if (inductanceFactor.Text == "H")
            {
                inductance = tempInductance * 1;
            }
            if (inductanceFactor.Text == "mH")
            {
                inductance = tempInductance * 1E-3;
            }
            if (inductanceFactor.Text == "uH")
            {
                inductance = tempInductance * 1E-6;
            }
            if (inductanceFactor.Text == "nH")
            {
                inductance = tempInductance * 1E-9;
            }
            if (inductanceFactor.Text == "pH")
            {
                inductance = tempInductance * 1E-12;
            }
            if (capacitanceFactor.Text == "uF")
            {
                capacitance = tempCapacitance * 1E-6;
            }
            if (capacitanceFactor.Text == "nF")
            {
                capacitance = tempCapacitance * 1E-9;
            }
            if (capacitanceFactor.Text == "pF")
            {
                capacitance = tempCapacitance * 1E-12;
            }
            // Perform the calculation
            double sqrt = Math.Sqrt(inductance * capacitance);
            result = Math.Sqrt(1 / (inductance * capacitance));
            frequencyValueBox.Text = result.ToString();
            omega = result;
            final = Math.PI / (omega * sqrt);
            rhsResultBox.Text = final.ToString();
            return final;
        }

        protected double CalculateLhs()
        {
            double result = 0;


            return result;
        }

    }
}