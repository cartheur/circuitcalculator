using System;
using System.Windows.Forms;
using CircuitCalculator.SubForms.Proofing;

namespace CircuitCalculator.OtherForms
{
    public partial class ProjectDataForm : Form
    {
        private Form _owner;
        private static bool _instance;

        public ProjectDataForm(Form mOwner)
        {
            InitializeComponent();
            _owner = mOwner;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            ControlBox = false;
            _instance = true;
        }
        private void ProjectDataFormLoad(object sender, EventArgs e)
        {
            label1.Text = "ESA - Mathematical proof guide.";
            label2.Text = "Follows from document, equation numbers.";
            var toolTip = new ToolTip {AutoPopDelay = 10000, InitialDelay = 400, ReshowDelay = 250, ShowAlways = true};
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return _instance; } set { _instance = value; } }

        #region Click Events
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void CloseButtonClick(object sender, System.EventArgs e)
        {
            _instance = false;
            Close();
        }

        private void OpenEquationOneButtonClick(object sender, EventArgs e)
        {
            if (EquationOne.Instance == false)
            {
                var form = new EquationOne(this);
                form.Show(this);
                EquationOne.Instance = true;
            }
            else if (EquationOne.Instance == true)
            {
                //Do nothing.
            }
        }

        private void OpenEquationTwoThreeButtonClick(object sender, EventArgs e)
        {
            if (EquationTwoThree.Instance == false)
            {
                var form = new EquationTwoThree(this);
                form.Show(this);
                EquationTwoThree.Instance = true;
            }
            else if (EquationTwoThree.Instance == true)
            {
                //Do nothing.
            }
        }

        private void OpenEquationFourButtonClick(object sender, EventArgs e)
        {
            if (EquationFour.Instance == false)
            {
                var form = new EquationFour(this);
                form.Show(this);
                EquationFour.Instance = true;
            }
            else if (EquationFour.Instance == true)
            {
                //Do nothing.
            }
        }

        private void OpenEquationFiveButtonClick(object sender, EventArgs e)
        {
            if (EquationFive.Instance == false)
            {
                var form = new EquationFive(this);
                form.Show(this);
                EquationFive.Instance = true;
            }
            else if (EquationFive.Instance == true)
            {
                //Do nothing.
            }
        }
        #endregion
    }
}
