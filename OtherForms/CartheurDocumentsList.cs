using System;
using System.Windows.Forms;

namespace CircuitCalculator.OtherForms
{
    public partial class CartheurDocumentsList : Form
    {
        private Form owner;
        private static bool _instance;

        public CartheurDocumentsList(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            ControlBox = false;
            _instance = true;
        }
        private void CartheurDocumentsList_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 750;
            toolTip.ReshowDelay = 250;
            toolTip.ShowAlways = true;
            // Load the full list
            listDisplayBox.Text = @"1. Magnetic Resonant Storage for Energy Transmission: Doc # car001 \n" +
                                  @"2. A Brief Description and Summary of Cartheur Technology Research: Doc # car002";

        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return _instance; } set { _instance = value; } }
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            _instance = false;
            Close();
        }
    }
}
