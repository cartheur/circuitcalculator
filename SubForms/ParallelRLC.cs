using System;
using System.Drawing;
using System.Windows.Forms;

namespace CircuitCalculator
{
    public partial class ParallelRLC : Form
    {
        private Timer grow;
        private Form owner;
        private static bool instance = false;

        public ParallelRLC(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.Manual;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            this.Size = new Size(20, 20);
            grow = new Timer();
            grow.Interval = 30;
            grow.Enabled = true;
            grow.Tick += GrowForm;
            GrowForm(this, EventArgs.Empty);
            owner.LocationChanged += ParentMoved;
            instance = true;
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return instance; } set { instance = value; } }
        /// <summary>
        /// Allows the form to grow.
        /// </summary>
        private void GrowForm(object sender, EventArgs e)
        {
            int w = this.Size.Width + 40;
            if (w >= 200) grow.Enabled = false;
            this.Bounds = new Rectangle(owner.Right - w + 220, owner.Top, w, w);
        }
        /// <summary>
        /// Allows the form to move with its parent.
        /// </summary>
        private void ParentMoved(object sender, EventArgs e)
        {
            if (grow.Enabled) return;
            int w = this.Size.Width;
            this.Bounds = new Rectangle(owner.Right - w + 220, owner.Top, w, w);
        }
        /// <summary>
        /// Closes the window.
        /// </summary>
        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            instance = false;
            Close();
        }
    }
}