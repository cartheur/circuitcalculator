using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CircuitCalculator.DataForms
{
    public partial class StorePhysicalElectricalMachineData : Form
    {
        private Form owner;
        private static bool instance = false;

        public StorePhysicalElectricalMachineData(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            instance = true;
            sessionValue.Text = (string)AppDomain.CurrentDomain.GetData("SessionID");
            dimensionalUnitsSelection.SelectedItem = "mm";
            RetrieveData();
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return instance; } set { instance = value; } }
        /// <summary>
        /// Maps the path of the executing file.
        /// </summary>
        /// <param name="path">The path to map.</param>
        public virtual string MapPath(string path)
        {
            string location = System.Reflection.Assembly.GetEntryAssembly().Location;
            string zebra = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            string local = Environment.CurrentDirectory;
            var value = local + path;
            return value;
        }

        private void storeDataButton_Click(object sender, EventArgs e)
        {
            double antennaRadius = 0;
            double wireRadius = 0;
            double legLength1 = 0;
            double legLength2 = 0;
            double legLength3 = 0;
            double wireLength = 0;

            if (dimensionalUnitsSelection.SelectedItem.ToString() == "mm")
            {
                antennaRadius = Convert.ToDouble(antennaRadiusTextBox.Text);
                wireRadius = Convert.ToDouble(wireRadiusTextBox.Text);
                legLength1 = Convert.ToDouble(legLengthOneTextBox.Text);
                legLength2 = Convert.ToDouble(legLengthTwoTextBox.Text);
                legLength3 = Convert.ToDouble(legLengthThreeTextBox.Text);
                wireLength = CalculateWireLength(Convert.ToDouble(numberOfTurnsTextBox.Text), antennaRadius, legLength1, legLength2, legLength3);
            }
            if (dimensionalUnitsSelection.SelectedItem.ToString() == "cm")
            {
                antennaRadius = Convert.ToDouble(antennaRadiusTextBox.Text) * 0.01;
                wireRadius = Convert.ToDouble(wireRadiusTextBox.Text) * 0.01;
                legLength1 = Convert.ToDouble(legLengthOneTextBox.Text) * 0.01;
                legLength2 = Convert.ToDouble(legLengthTwoTextBox.Text) * 0.01;
                legLength3 = Convert.ToDouble(legLengthThreeTextBox.Text) * 0.01;
                wireLength = CalculateWireLength(Convert.ToDouble(numberOfTurnsTextBox.Text), antennaRadius, legLength1, legLength2, legLength3);
            }
            if (dimensionalUnitsSelection.SelectedItem.ToString() == "m")
            {
                antennaRadius = Convert.ToDouble(antennaRadiusTextBox.Text) * 0.001;
                wireRadius = Convert.ToDouble(wireRadiusTextBox.Text) * 0.001;
                legLength1 = Convert.ToDouble(legLengthOneTextBox.Text) * 0.001;
                legLength2 = Convert.ToDouble(legLengthTwoTextBox.Text) * 0.001;
                legLength3 = Convert.ToDouble(legLengthThreeTextBox.Text) * 0.001;
                wireLength = CalculateWireLength(Convert.ToDouble(numberOfTurnsTextBox.Text), antennaRadius, legLength1, legLength2, legLength3);
            }
            try
            {
                string path = MapPath(@"\db\machine_parameters.db");
                SQLiteConnection conn = new SQLiteConnection(@"Data Source=" + path);
                SQLiteCommand cmd = new SQLiteCommand();
                DataTable table = new DataTable();
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO PhysicalParameters (Units, Machine, AntennaRadius, NumberOfTurns, WireLength, WireRadius, LegLength1, LegLength2, LegLength3) VALUES ('" + dimensionalUnitsSelection.SelectedItem.ToString() + "', '" + machineNameTextBox.Text + "', '" + antennaRadius + "', '" + numberOfTurnsTextBox.Text + "', '"
                    + wireLength + "', '" + wireRadius + "', '" + legLength1 + "', '" + legLength2 + "', '" + legLength3 + "')";
                conn.Open();
                SQLiteTransaction trans = conn.BeginTransaction();
                cmd.ExecuteNonQuery();
                trans.Commit();
                conn.Close();
                trans.Dispose();
                cmd.Dispose();
                conn.Dispose();
                MessageBox.Show("Data saved successfully!", "Data operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in storing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                antennaRadiusTextBox.Text = "";
                wireRadiusTextBox.Text = "";
                numberOfTurnsTextBox.Text = "";
                legLengthOneTextBox.Text = "";
                legLengthTwoTextBox.Text = "";
                legLengthThreeTextBox.Text = "";
            }
        }
        /// <summary>
        /// Calculates the length of the wire.
        /// </summary>
        /// <param name="numberOfTurns">The number of turns.</param>
        /// <param name="antennaRadius">The antenna radius.</param>
        /// <param name="legLength1">The leg length1.</param>
        /// <param name="legLength2">The leg length2.</param>
        /// <param name="legLength3">The leg length3.</param>
        protected double CalculateWireLength(double numberOfTurns, double antennaRadius, double legLength1, double legLength2, double legLength3)
        {
            var value = (numberOfTurns * (2 * Math.PI * antennaRadius)) + legLength1 + legLength2 + legLength3;
            return value;
        }
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            if (machineNameTextBox.Text != "")
            {
                if (MessageBox.Show("Do you want to close the form with unsaved data?", "Unsaved data present", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    instance = false;
                    Close();
                }
            }
            else if (machineNameTextBox.Text == "")
            {
                instance = false;
                Close();
            }
        }
        /// <summary>
        /// Retrieves the data from the database.
        /// </summary>
        private void retrieveDataButton_Click(object sender, EventArgs e)
        {
            RetrieveData();
        }
        /// <summary>
        /// Retrieves the data.
        /// </summary>
        protected void RetrieveData()
        {
            try
            {
                string path = MapPath(@"\db\machine_parameters.db");
                SQLiteConnection conn = new SQLiteConnection(@"Data Source=" + path);
                SQLiteCommand cmd = new SQLiteCommand();
                DataTable table = new DataTable();
                cmd = conn.CreateCommand();
                cmd.CommandText = "Select Machine, AntennaRadius, NumberOfTurns, WireRadius, LegLength1, LegLength2, LegLength3, WireLength, Units from PhysicalParameters";
                SQLiteDataAdapter adapt = new SQLiteDataAdapter(cmd);
                adapt.Fill(table);
                BindingSource source = new BindingSource();
                source.DataSource = table;
                machineDataGridView.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in storing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
