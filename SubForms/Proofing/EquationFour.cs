using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CircuitCalculator
{
    public partial class EquationFour : Form
    {
        private Timer grow;
        private Form owner;
        private static bool instance = false;

        public EquationFour(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.Manual;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            this.Size = new Size(400, 400);
            grow = new Timer();
            grow.Interval = 30;
            grow.Enabled = false;
            grow.Tick += GrowForm;
            GrowForm(this, EventArgs.Empty);
            owner.LocationChanged += ParentMoved;
            instance = true;
        }
        private void equationFour_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 400;
            toolTip.ReshowDelay = 250;
            toolTip.ShowAlways = true;
        }
        /// <summary>
        /// Allows the form to grow.
        /// </summary>
        private void GrowForm(object sender, EventArgs e)
        {
            int w = this.Size.Width;
            if (w >= 200) grow.Enabled = false;
            this.Bounds = new Rectangle(owner.Right - w + 410, owner.Top, w, w);
        }
        /// <summary>
        /// Allows the form to move with its parent.
        /// </summary>
        private void ParentMoved(object sender, EventArgs e)
        {
            if (grow.Enabled) return;
            int w = this.Size.Width;
            this.Bounds = new Rectangle(owner.Right - w + 410, owner.Top, w, w);
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return instance; } set { instance = value; } }

        #region Click Events
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void closeButton_Click(object sender, System.EventArgs e)
        {
            instance = false;
            Close();
        }
        #endregion
    }
}