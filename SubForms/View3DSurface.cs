using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CircuitCalculator.Plot3D;

namespace CircuitCalculator
{
    public partial class View3DSurface : Form
    {
        private Form owner;
        private static bool instance = false;
        Surface3DRenderer render;
        OpenFileDialog openDataFile = new OpenFileDialog();
        // for help on this module: http://www.codeproject.com/KB/graphics/surfacePloter.aspx

        public View3DSurface(Form mOwner)
        {
            InitializeComponent();
            render = new Surface3DRenderer(70, 35, 40, 0, 0, ClientRectangle.Width, ClientRectangle.Height, 0.5, 0, 0);
            render.ColorSchema = new ColorSchema(tbHue.Value);
            View3DSurface_Resize(null, null);
            ResizeRedraw = true;
            DoubleBuffered = true;
            owner = mOwner;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.ControlBox = true;
            instance = true;
            this.StartPosition = FormStartPosition.CenterParent;
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 400;
            toolTip.ReshowDelay = 200;
            toolTip.ShowAlways = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View3DSurface_Closing);
            plotDataGridView.Visible = false;
            //render.SetFunction("sin(x1)*cos(x2)/(sqrt(sqrt(x1*x1+x2*x2))+1)*10");
            render.SetFunction("sin(x1)*cos(x2)");
            
        }

        private void View3DSurface_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            render.RenderSurface(e.Graphics);
        }

        private void View3DSurface_Resize(object sender, EventArgs e)
        {
            render.ReCalculateTransformationCoefficients(70, 35, 40, 0, 0, ClientRectangle.Width, ClientRectangle.Height, 0.5, 0, 0);
        }
        /// <summary>
        /// Performs tasks when the form is closing.
        /// </summary>
        private void View3DSurface_Closing(object sender, EventArgs e)
        {
            Instance = false;
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return instance; } set { instance = value; } }

        private void tbHue_Scroll(object sender, EventArgs e)
        {
            render.ColorSchema = new ColorSchema(tbHue.Value);
            Invalidate();
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            plotDataGridView.Visible = true;
            Refresh();
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

        private void plotButton_Click(object sender, EventArgs e)
        {
            plotDataGridView.Visible = true;
            Refresh();
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
                        //CreateACModeGraph(zedGraphControl, CreateList(tableSource));
                    }
                }
            }
        }
        /// <summary>
        /// Shows the data grid from the form.
        /// </summary>
        private void viewGridButton_Click(object sender, EventArgs e)
        {
            if (plotDataGridView.Visible == false)
            {
                plotDataGridView.Visible = true;
                Refresh();
            }
        }
        /// <summary>
        /// Hides the data grid from the form.
        /// </summary>
        private void hideGridButton_Click(object sender, EventArgs e)
        {
            plotDataGridView.Visible = false;
            Refresh();
        }
    }
}