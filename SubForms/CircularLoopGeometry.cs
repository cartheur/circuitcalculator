using System;
using System.Windows.Forms;

namespace CircuitCalculator.SubForms
{
    public partial class CircularLoopGeometry : Form
    {
        private Form owner;
        private static bool instance;

        public CircularLoopGeometry(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            ControlBox = false;
            instance = true;
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return instance; } set { instance = value; } }
        /// <summary>
        /// Closes the window.
        /// </summary>
        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            instance = false;
            Close();
        }

        private void calculateVectorButton_Click(object sender, EventArgs e)
        {
            switch (VectorPotentialCalculator.Instance)
            {
                case false:
                    {
                        var form = new VectorPotentialCalculator(this);
                        form.Show(this);
                        VectorPotentialCalculator.Instance = true;
                    }
                    break;
                case true:
                    break;
            }
        }
    }
}
