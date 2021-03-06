using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CircuitCalculator
{
    public partial class MagneticFieldCoilRotationCalculator : Form
    {
        private Form owner;
        private static bool instance = false;

        public MagneticFieldCoilRotationCalculator(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            //relativePermeabilityMediumTextBox.Text = "4π * 10E-7";//12.56637E-7
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            instance = true;
            //sessionValue.Text = (string)AppDomain.CurrentDomain.GetData("SessionID");
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 400;
            toolTip.ReshowDelay = 250;
            toolTip.ShowAlways = true;
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
    }
}