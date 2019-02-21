using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CircuitCalculator
{
    public partial class MatrixViewer : Form
    {
        private Timer grow;
        private Form owner;
        private static bool instance = false;
        OpenFileDialog openDataFile = new OpenFileDialog();

        public MatrixViewer(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.Manual;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            this.Size = new Size(150, 374);
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
            this.Bounds = new Rectangle(owner.Left - w + 300, owner.Left, w, h);
        }
        /// <summary>
        /// Allows the form to move with its parent.
        /// </summary>
        private void ParentMoved(object sender, EventArgs e)
        {
            if (grow.Enabled) return;
            int w = this.Size.Width;
            int h = this.Size.Height;
            this.Bounds = new Rectangle(owner.Left - w + 300, owner.Top, w, h);
        }
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            Instance = false;
            this.Close();
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            if (openDataFile.ShowDialog(this) == DialogResult.OK)
            {
                string filename = openDataFile.FileName;
                string extension = Path.GetExtension(filename);
                if (extension == ".xls" || extension == ".xlsx")
                {
                    ExcelReader db = new ExcelReader(filename, true, false);
                    TableSelectDialog t = new TableSelectDialog(db.GetWorksheetList());

                    if (t.ShowDialog(this) == DialogResult.OK)
                    {
                        DataTable tableSource = db.GetWorksheet(t.Selection);
                        this.plotDataGridView.DataSource = tableSource;
                        //this.dgvProjectionSource.DataSource = tableSource.Copy();

                        //double[,] graph = tableSource.ToMatrix(out sourceColumns); FIX ME HERE
                        //CreateScatterplot(graphInput, graph);
                    }
                }
            }
        }
    }
}