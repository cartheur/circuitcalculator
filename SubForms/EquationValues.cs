using System;
using System.Drawing;
using System.Windows.Forms;

namespace CircuitCalculator
{
    public partial class EquationValues : Form
    {
        private Timer grow;
        private Form owner;
        private static bool instance = false;

        public EquationValues(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.Manual;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            this.Size = new Size(150, 474);
            grow = new Timer();
            grow.Interval = 60;
            grow.Enabled = true;
            grow.Tick += GrowForm;
            GrowForm(this, EventArgs.Empty);
            owner.LocationChanged += ParentMoved;
            instance = true;
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 400;
            toolTip.ReshowDelay = 200;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.equationOneSelection, "Inductive-link axial distance (AC mode)");
            toolTip.SetToolTip(this.equationTwoSelection, "Inductive-link axial distance (DC mode)");
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
            int h = this.Size.Height + 40;
            if (w >= 200) grow.Enabled = false;
            this.Bounds = new Rectangle(owner.Left - w + 1314, owner.Left, w, h);
        }
        /// <summary>
        /// Allows the form to move with its parent.
        /// </summary>
        private void ParentMoved(object sender, EventArgs e)
        {
            if (grow.Enabled) return;
            int w = this.Size.Width;
            int h = this.Size.Height;
            this.Bounds = new Rectangle(owner.Left - w + 1314, owner.Top, w, h);
        }
        /// <summary>
        /// Closes the window.
        /// </summary>
        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            instance = false;
            Close();
        }

        private void plotButton_Click(object sender, EventArgs e)
        {
            if (equationOneSelection.Checked == true & equationTwoSelection.Checked == true)
            {
                MessageBox.Show("You cannot use more than one selection for plotting", "Equation error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (equationOneSelection.Checked == true)
                {
                    // One matlab compiled equation.
                }
                else if (equationTwoSelection.Checked == true)
                {
                    // One matlab compiled equation.
                }
            }
        }

        private void equationOneSelection_CheckedChanged(object sender, EventArgs e)
        {
            //PlotDataForm.zed

            //if (matrixviewer.instance == false)
            //{
            //    matrixviewer form = new matrixviewer(this);
            //    form.show(this);
            //    matrixviewer.instance = true;
            //}
            //else if (matrixviewer.instance == true)
            //{
            //    //do nothing.
            //}
        }

        
    }
}