using System;
using System.Drawing;
using System.Windows.Forms;

namespace CircuitCalculator.SubForms.Proofing
{
    public partial class EquationTwoThree : Form
    {
        private readonly Timer _grow;
        private readonly Form _owner;
        private static bool _instance;

        public EquationTwoThree(Form mOwner)
        {
            InitializeComponent();
            _owner = mOwner;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.Manual;
            ShowInTaskbar = false;
            ControlBox = false;
            Size = new Size(400, 400);
            _grow = new Timer {Interval = 30, Enabled = false};
            _grow.Tick += GrowForm;
            GrowForm(this, EventArgs.Empty);
            _owner.LocationChanged += ParentMoved;
            _instance = true;
        }
        private void EquationTwoThreeLoad(object sender, EventArgs e)
        {
            var toolTip = new ToolTip {AutoPopDelay = 10000, InitialDelay = 400, ReshowDelay = 250, ShowAlways = true};
        }
        /// <summary>
        /// Allows the form to grow.
        /// </summary>
        private void GrowForm(object sender, EventArgs e)
        {
            var w = Size.Width;
            if (w >= 200) _grow.Enabled = false;
            Bounds = new Rectangle(_owner.Right - w + 410, _owner.Top, w, w);
        }
        /// <summary>
        /// Allows the form to move with its parent.
        /// </summary>
        private void ParentMoved(object sender, EventArgs e)
        {
            if (_grow.Enabled) return;
            var w = Size.Width;
            Bounds = new Rectangle(_owner.Right - w + 410, _owner.Top, w, w);
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return _instance; } set { _instance = value; } }

        #region Click Events
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void CloseButtonClick(object sender, EventArgs e)
        {
            _instance = false;
            Close();
        }
        #endregion

        private void CalculateButtonClick(object sender, EventArgs e)
        {

        }
    }
}