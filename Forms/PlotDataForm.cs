using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ZedGraph;
using CircuitCalculator.Plot3D;

namespace CircuitCalculator
{
    public partial class PlotDataForm : Form
    {
        private Form owner;
        private static bool instance = false;
        OpenFileDialog openDataFile = new OpenFileDialog();
        public Surface3DRenderer render;

        public PlotDataForm(Form mOwner)
        {
            InitializeComponent();
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlotDataForm_Closing);
        }
        /// <summary>
        /// Performs tasks when the form is loading.
        /// </summary>
        private void PlotDataForm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            //threeDimSurfacePanel.Visible = false;
            //CreateACModeGraph(zedGraphControl);
            //CreateEfficiencyGraph(zedGraphControl);
            //plotOneSelection.Checked = true;
            SetSize();
            EquationValues.Instance = false;
            //OpenChildWindow();
            // For help on this module, see: http://www.codeproject.com/KB/graphics/zedgraph.aspx
            // to tighten axes, see: http://stackoverflow.com/questions/2681414/lock-axis-in-zedgraph
        }
        private void threeDimSurfacePanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            render.RenderSurface(e.Graphics);
        }
        private void Paint3D(PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            render.RenderSurface(e.Graphics);
        }
        private void threeDimSurfacePanel_Resize(object sender, EventArgs e)
        {
            render.ReCalculateTransformationCoefficients(70, 35, 40, 0, 0, ClientRectangle.Width, ClientRectangle.Height, 0.5, 0, 0);
        }
        private void tbHue_Scroll(object sender, EventArgs e)
        {
            //render.ColorSchema = new ColorSchema(tbHue.Value);
            Invalidate();
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return instance; } set { instance = value; } }

        #region Calculate the data for the plots for IJ paper
        /// <summary>
        /// The efficiency of an oscillator projecting currents at a distance.
        /// </summary>
        protected double CalculateEfficiency()
        {
            // Circuit characteristics
            double voltage = 1.0;
            double current = 0.01;
            double power = voltage * current;
            double inductanceT = 62.40E-6;
            double inductanceR = 61.68E-6;

            double mutualInductance = 61.04E-6; // Needs to be further researched.

            double sqrt = Math.Sqrt(inductanceT * inductanceR);
            double k = mutualInductance / sqrt;

            double ohmicResistance = 1.88;
            double radiationResistance = power / (current * current) * 3.5;
            double gamma = (ohmicResistance + radiationResistance) / 4 * (inductanceT + inductanceR);
            double result = k / gamma;

            return result;
        }
        /// <summary>
        /// Creates the comparative graph.
        /// </summary>
        /// <param name="zgc">The plot control.</param>
        private void CreateComparativeGraph(ZedGraphControl zgc)
        {
            GraphPane myPane = zgc.GraphPane;

            // Set titles and axis labels
            myPane.Title.Text = "efficiency of a resonator with distant elements";
            myPane.XAxis.Title.Text = "distance (cm)";
            myPane.YAxis.Title.Text = "efficiency | η";

            // Build data points from the function
            PointPairList listMyne = new PointPairList();
            PointPairList listComparative = new PointPairList();

            #region Data points myne
            double x1 = 0;
            double d1 = (CalculateEfficiency() + 4.5) / 100;
            listMyne.Add(x1, d1);
            double x2 = 25;
            double d2 = (CalculateEfficiency() + 1.5 / 1.01) / 100;
            listMyne.Add(x2, d2);
            double x3 = 50;
            double d3 = (CalculateEfficiency() / 1.03) / 100;
            listMyne.Add(x3, d3);
            double x4 = 75;
            double d4 = (CalculateEfficiency() / 1.07) / 100;
            listMyne.Add(x4, d4);
            double x5 = 100;
            double d5 = (CalculateEfficiency() / 1.12) / 100;
            listMyne.Add(x5, d5);
            double x6 = 125;
            double d6 = (CalculateEfficiency() / 1.19) / 100;
            listMyne.Add(x6, d6);
            double x7 = 150;
            double d7 = (CalculateEfficiency() / 1.25) / 100;
            listMyne.Add(x7, d7);
            double x8 = 175;
            double d8 = (CalculateEfficiency() / 1.35) / 100;
            listMyne.Add(x8, d8);
            double x9 = 200;
            double d9 = (CalculateEfficiency() / 1.45) / 100;
            listMyne.Add(x9, d9);
            double x10 = 225;
            double d10 = (CalculateEfficiency() / 1.6) / 100;
            listMyne.Add(x10, d10);
            double x11 = 250;
            double d11 = (CalculateEfficiency() / 1.75) / 100;
            listMyne.Add(x11, d11);
            double x12 = 275;
            double d12 = (CalculateEfficiency() / 1.94) / 100;
            listMyne.Add(x12, d12);
            #endregion
            #region Comparative data points
            double k1 = 0.96;
            listComparative.Add(x1, k1);
            double k2 = 0.93;
            listComparative.Add(x2, k2);
            double k3 = 0.9;
            listComparative.Add(x3, k3);
            double k4 = 0.86;
            listComparative.Add(x4, k4);
            double k5 = 0.8;
            listComparative.Add(x5, k5);
            double k6 = 0.74;
            listComparative.Add(x6, k6);
            double k7 = 0.68;
            listComparative.Add(x7, k7);
            double k8 = 0.61;
            listComparative.Add(x8, k8);
            double k9 = 0.56;
            listComparative.Add(x9, k9);
            double k10 = 0.50;
            listComparative.Add(x10, k10);
            double k11 = 0.44;
            listComparative.Add(x11, k11);
            double k12 = 0.38;
            listComparative.Add(x12, k12);
            //double kr = [k1 k2 k3 k4 k5 k6 k7 k8 k9 k10 k11 k12];
            #endregion
            //for (double x = 0; x < 48; x++)
            //{
            //    double y = Math.Sin(x * Math.PI / 15.0);

            //    list.Add(x, y);
            //}

            // Generate a blue curve with circle symbols, and "My Curve 2" in the legend
            LineItem myCurve = myPane.AddCurve("effective power over distance (myne)", listMyne, Color.Black, SymbolType.None);
            LineItem curveComparative = myPane.AddCurve("Kurs scheme", listComparative, Color.Blue, SymbolType.None);
            // Fill the area under the curve with a white-red gradient at 45 degrees
            //myCurve.Line.Fill = new Fill(Color.White, Color.Red, 45F);
            // Make the symbols opaque by filling them with white
            myCurve.Symbol.Fill = new Fill(Color.White);

            // Fill the axis background with a color gradient
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);

            // Fill the pane background with a color gradient
            myPane.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);

            // Calculate the Axis Scale Ranges
            zgc.AxisChange();
        }
        /// <summary>
        /// Creates the efficiency graph.
        /// </summary>
        /// <param name="zgc">The plot control.</param>
        private void CreateEfficiencyGraph(ZedGraphControl zgc)
        {
            GraphPane myPane = zgc.GraphPane;

            // Set titles and axis labels
            myPane.Title.Text = "theoretical verses experimental k (efficiency)";
            myPane.XAxis.Title.Text = "distance (cm)";
            myPane.YAxis.Title.Text = "k |or| η";

            // Build data points from the function
            PointPairList list = new PointPairList();
            PointPairList listMyne = new PointPairList();
            PointPairList listComparative = new PointPairList();

            #region Data points myne
            double x1 = 0;
            double d1 = (CalculateEfficiency() + 4.5) / 100;
            listMyne.Add(x1, d1);
            double x2 = 25;
            double d2 = (CalculateEfficiency() + 1.5 / 1.01) / 100;
            listMyne.Add(x2, d2);
            double x3 = 50;
            double d3 = (CalculateEfficiency() / 1.03) / 100;
            listMyne.Add(x3, d3);
            double x4 = 75;
            double d4 = (CalculateEfficiency() / 1.07) / 100;
            listMyne.Add(x4, d4);
            double x5 = 100;
            double d5 = (CalculateEfficiency() / 1.12) / 100;
            listMyne.Add(x5, d5);
            double x6 = 125;
            double d6 = (CalculateEfficiency() / 1.19) / 100;
            listMyne.Add(x6, d6);
            double x7 = 150;
            double d7 = (CalculateEfficiency() / 1.25) / 100;
            listMyne.Add(x7, d7);
            double x8 = 175;
            double d8 = (CalculateEfficiency() / 1.35) / 100;
            listMyne.Add(x8, d8);
            double x9 = 200;
            double d9 = (CalculateEfficiency() / 1.45) / 100;
            listMyne.Add(x9, d9);
            double x10 = 225;
            double d10 = (CalculateEfficiency() / 1.6) / 100;
            listMyne.Add(x10, d10);
            double x11 = 250;
            double d11 = (CalculateEfficiency() / 1.75) / 100;
            listMyne.Add(x11, d11);
            double x12 = 275;
            double d12 = (CalculateEfficiency() / 1.94) / 100;
            listMyne.Add(x12, d12);
            #endregion

            for (double x = 0; x < 48; x++)
            {
                double y = Math.Sin(x * Math.PI / 15.0);

                list.Add(x, y);
            }

            // Generate a blue curve with circle symbols, and "My Curve 2" in the legend
            LineItem myCurve = myPane.AddCurve("__", list, Color.BlueViolet, SymbolType.None);
            //LineItem curveComparative = myPane.AddCurve("Kurs scheme", listComparative, Color.Blue, SymbolType.None);
            // Fill the area under the curve with a white-red gradient at 45 degrees
            //myCurve.Line.Fill = new Fill(Color.White, Color.Red, 45F);
            // Make the symbols opaque by filling them with white
            myCurve.Symbol.Fill = new Fill(Color.White);

            // Fill the axis background with a color gradient
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);

            // Fill the pane background with a color gradient
            myPane.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);

            // Calculate the Axis Scale Ranges
            zgc.AxisChange();
        }

        #endregion

        #region Calculate the experimental data for the plots for CS&M paper

        double[] d = { 0.2, 0.5, 0.9, 1.5, 1.7, 1.8, 1.9, 1.95, 1.996, 1.998, 2.0, 2.003, 2.03, 2.05, 2.1, 2.2, 2.5, 3.0, 3.5, 4.0, 4.5, 5.0, 5.8, 5.85 };
        double[] x = { 5.1,  5.0, 4.8, 4.7,  5.0, 5.4,  5.5,  5.6,  5.78, 5.8,  5.8,  5.8,  5.78, 5.6,  5.5,  5.4, 4.58, 3.6, 3.0, 2.5, 2.0,  1.65, 1.35, 1.33 };
        double[] t = { 5.15, 4.9, 4.8, 4.67, 5.3, 5.65, 5.85, 5.85, 5.85, 5.85, 5.86, 5.86, 5.86, 5.85, 5.85, 5.75, 5.34, 4.0, 3.2, 2.7, 2.1, 1.75, 1.35, 1.33 };

        //double[] v = { 0.200, 0.500, 0.900, 1.500, 1.700, 1.800, 1.900, 1.950, 1.996, 1.998, 2.000, 2.003, 2.030, 2.050, 2.100, 2.200, 2.500, 3.000, 3.500, 4.000, 4.500, 5.000, 5.800, 5.850 };
        //double[] w = { 5.15, 4.9, 4.8, 4.67, 5.3, 5.65, 5.85, 5.85, 5.85, 5.85, 5.86, 5.86, 5.86, 5.85, 5.85, 5.75, 5.34, 4, 3.2, 2.7, 2.1, 1.75, 1.35, 1.33 };

        private void CreateACModeGraph(ZedGraphControl zgc)
        {
            GraphPane myPane = zgc.GraphPane;

            // Set titles and axis labels
            myPane.Title.Text = "Power intensity over a distance"; //k or η theoretical verses experimental η
            myPane.XAxis.Title.Text = "distance (cm)";
            myPane.YAxis.Title.Text = "intensity - VAC";

            // Build data points from the function
            PointPairList list = new PointPairList();
            PointPairList list2 = new PointPairList();
            list.Add(d, x);
            list2.Add(d, t);
            LineItem myCurve = myPane.AddCurve("measured value (x)", list, Color.Black, SymbolType.None);
            //myCurve.Line.Width = 2.0f;
            LineItem curve2 = myPane.AddCurve("theoretical value (t)", list2, Color.Blue, SymbolType.Diamond);
            //curve2.Line.Width = 2.0f;
            curve2.Line.DashOn = 1.0f;
            zgc.AxisChange();
        }
        /// <summary>
        /// Creates the AC mode graph.
        /// </summary>
        /// <param name="zgc">The graphics control.</param>
        /// <param name="list">The point-pair list.</param>
        private void CreateACModeGraph(ZedGraphControl zgc, PointPairList list)
        {
            GraphPane myPane = zgc.GraphPane;

            // Set titles and axis labels
            myPane.Title.Text = "Power intensity over a distance"; //k or η theoretical verses experimental η
            myPane.XAxis.Title.Text = "distance (cm)";
            myPane.YAxis.Title.Text = "intensity - VAC";

            LineItem myCurve = myPane.AddCurve("measured value", list, Color.Black, SymbolType.None);
            //myCurve.Line.Width = 2.0f;
            //LineItem curve2 = myPane.AddCurve("theoretical value (t)", list2, Color.Blue, SymbolType.Diamond);
            //curve2.Line.Width = 2.0f;
            //curve2.Line.DashOn = 1.0f;
            zgc.AxisChange();
            this.zedGraphControl.Refresh();
        }

        #endregion

        /// <summary>
        /// Performs tasks when the form is closing.
        /// </summary>
        private void PlotDataForm_Closing(object sender, EventArgs e)
        {
            Instance = false;
        }
        /// <summary>
        /// Performs tasks when the form is resized.
        /// </summary>
        private void PlotDataForm_Resize(object sender, EventArgs e)
        {
            SetSize();
        }
        /// <summary>
        /// Sets the size of the plot object.
        /// </summary>
        private void SetSize()
        {
            zedGraphControl.Location = new Point(10, 10);
            // Leave a small margin around the outside of the control
            //zedGraphControl.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 20);
            zedGraphControl.Size = new Size(800, 550);
        }
        /// <summary>
        /// Checks a calculation.
        /// </summary>
        private void testCalcButton_Click(object sender, EventArgs e)
        {
            double result = CalculateEfficiency();
            resultLabel.Text = "Efficiency: " + result.ToString();
        }
        /// <summary>
        /// Sends the data grid values to the plot window.
        /// </summary>
        private void plotButton_Click(object sender, EventArgs e)
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
                        CreateACModeGraph(zedGraphControl, CreateList(tableSource));
                    }
                }
            }
        }
        /// <summary>
        /// Creates the point-pair list for the plot window.
        /// </summary>
        /// <param name="source">The data source.</param>
        private PointPairList CreateList(DataTable source)
        {
            PointPairList plotList = new PointPairList();
            //PointPair4 more = new PointPair4();

            foreach (DataRow row in source.Rows)
            {
                double x = (double)row["X"];
                double y = (double)row["Y"];
                //double z = (double)row["Z"];
                plotList.Add(x, y);
            }

            return plotList;
        }
        /// <summary>
        /// Loads meausred data from an excel document.
        /// </summary>
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
        /// <summary>
        /// Refreshes the graphical component.
        /// </summary>
        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.zedGraphControl.Refresh();
        }
        /// <summary>
        /// Calls the three-dimensional plot window.
        /// </summary>
        private void threeDimPlotButton_Click(object sender, EventArgs e)
        {
            if (View3DSurface.Instance == false)
            {
                View3DSurface form = new View3DSurface(this);
                form.Show(this);
                View3DSurface.Instance = true;
            }
            else if (View3DSurface.Instance)
            {
                // Do nothing.
            }

            //resultLabel.Text = "Offline";
            //threeDimSurfacePanel.Visible = true;
            //Refresh();
            //Paint3D();
            //render = new Surface3DRenderer(70, 35, 40, 0, 0, ClientRectangle.Width, ClientRectangle.Height, 0.5, 0, 0);
            //render.ColorSchema = new ColorSchema(tbHue.Value);
            //render.SetFunction("sin(x1)*cos(x2)/(sqrt(sqrt(x1*x1+x2*x2))+1)*10");
            //render.SetFunction("sin(x1)*cos(x2)");
            //threeDimSurfacePanel_Resize(null, null);
            //ResizeRedraw = true;
            //DoubleBuffered = true;
        }

        #region Subcontrols
        /// <summary>
        /// Opens the child window.
        /// </summary>
        protected void OpenChildWindow()
        {
            if (EquationValues.Instance == false)
            {
                EquationValues form = new EquationValues(this);
                form.Show(this);
                EquationValues.Instance = true;
            }
            else if (EquationValues.Instance == true)
            {
                //Do nothing.
            }
        }
        private void plotOneSelection_CheckedChanged(object sender, EventArgs e)
        {
            //Do nothing.
            CreateComparativeGraph(zedGraphControl);
        }

        private void plotTwoSelection_CheckedChanged(object sender, EventArgs e)
        {
            CreateEfficiencyGraph(zedGraphControl);
        }

        private void plotButton_Click_1(object sender, EventArgs e)
        {
            
            if (plotOneSelection.Checked == true)
                CreateComparativeGraph(zedGraphControl);
            else if (plotTwoSelection.Checked == true)
                CreateEfficiencyGraph(zedGraphControl);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            SetSize();
        }

        private void newPlotButton_Click(object sender, EventArgs e)
        {
            ZedGraphControl zedGraphControl = new ZedGraphControl();
        }
        #endregion

    }
}