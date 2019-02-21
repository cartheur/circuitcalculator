using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CircuitCalculator
{
    public partial class StoreCalculationData : Form
    {
        private Form owner;
        private static bool instance = false;

        public StoreCalculationData(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            instance = true;
            sessionValue.Text = (string)AppDomain.CurrentDomain.GetData("SessionID");
            calculationDataGridView_Load();
            experimentalDataGridView_Load();
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return instance; } set { instance = value; } }
        /// <summary>
        /// Closes the instance of the form.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            instance = false;
            Close();
        }
        /// <summary>
        /// Loads the calculations from the database.
        /// </summary>
        protected void calculationDataGridView_Load()
        {
            try
            {
                // Recall the calculation data.
                string directory = MapPath(@"\db\sessions.db");
                string path = @"c:\Users\ctucker\aeonProjectDirectory\Monkey-Man\thesis\circuits\CircuitCalculator";

                SQLiteConnection conn = new SQLiteConnection(@"Data Source=" + path + directory);
                SQLiteCommand cmd = new SQLiteCommand();
                DataTable table = new DataTable();
                cmd = conn.CreateCommand();
                cmd.CommandText = "Select CalculatedLoopInductance, CalculatedTotalLinzInductance from InductanceResults";
                SQLiteDataAdapter adapt = new SQLiteDataAdapter(cmd);
                adapt.Fill(table);
                BindingSource source = new BindingSource();
                source.DataSource = table;
                calculationDataGridView.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in recalling calculation data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        /// <summary>
        /// Loads the experiment data from the database.
        /// </summary>
        protected void experimentalDataGridView_Load()
        {
            try
            {
                // Recall the calculation data.
                string directory = MapPath(@"\db\sessions.db");
                string path = @"c:\Users\ctucker\aeonProjectDirectory\Monkey-Man\thesis\circuits\CircuitCalculator";

                SQLiteConnection conn = new SQLiteConnection(@"Data Source=" + path + directory);
                SQLiteCommand cmd = new SQLiteCommand();
                DataTable table = new DataTable();
                cmd = conn.CreateCommand();
                cmd.CommandText = "Select ExperimentBatch, MeasuredResonanceFrequency, DifferenceBetweenCalculationAndExperiment from ExperimentalResonanceData";
                SQLiteDataAdapter adapt = new SQLiteDataAdapter(cmd);
                adapt.Fill(table);
                BindingSource source = new BindingSource();
                source.DataSource = table;
                experimentalDataGridView.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in recalling experimental data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        /// <summary>
        /// Maps the path of the executing file.
        /// </summary>
        /// <param name="path">The path to map.</param>
        public virtual string MapPath(string path)
        {
            string location = System.Reflection.Assembly.GetEntryAssembly().Location;
            string zebra = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            string local = Environment.CurrentDirectory;
            return Path.Combine(zebra, path);
        }
        /// <summary>
        /// Calls the store experimental data form.
        /// </summary>
        private void storeExperimentalDataButton_Click(object sender, EventArgs e)
        {
            if (StoreExperimentalData.Instance == false)
            {
                StoreExperimentalData form = new StoreExperimentalData(this);
                form.Show(this);
                StoreExperimentalData.Instance = true;
            }
            else if (StoreExperimentalData.Instance == true)
            {
                // Do nothing.
            }
        }
    }
}
