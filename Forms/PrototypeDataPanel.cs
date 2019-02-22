using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CircuitCalculator
{
    public partial class PrototypeDataPanel : Form
    {
        private Form owner;
        private static bool instance = false;

        public PrototypeDataPanel(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            instance = true;
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 400;
            toolTip.ReshowDelay = 250;
            toolTip.ShowAlways = true;
            updateFourCoilTextBox.Visible = false;
            fourCoilGroupBox.Visible = false;
            fourCoilElectricalGroupBox.Visible = false;
            twoCoilGroupBox.Visible = false;
            twoCoilElectricalGroupBox.Visible = false;
        }
        /// <summary>
        /// Resets the text on changed buttons.
        /// </summary>
        private void PrototypeDataPanel_MouseEnter(object sender, EventArgs e)
        {
            saveFourCoilButton.Text = "Save";
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
        /// Relays the selected prototype to add data to.
        /// </summary>
        private void prototypeSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = prototypeSelectionBox.SelectedItem.ToString();

            // Show the parts of the form relevant to each prototype schema.
            if (value == "Inductive-Link Coils")
            {
                twoCoilGroupBox.Visible = true;
                twoCoilElectricalGroupBox.Visible = true;
            }
            else if (value == "Resonant-Link Coils")
            {
                fourCoilGroupBox.Visible = true;
                fourCoilElectricalGroupBox.Visible = true;
            }
            else if (value == "Model 'F' Coils")
            {
                fourCoilGroupBox.Visible = true;
                fourCoilElectricalGroupBox.Visible = true;
            }
            else if (value == "Clear Selection")
            {
                fourCoilGroupBox.Visible = false;
                fourCoilElectricalGroupBox.Visible = false;
                twoCoilGroupBox.Visible = false;
                twoCoilElectricalGroupBox.Visible = false;
            }
        }
        /// <summary>
        /// Opens the data for editing.
        /// </summary>
        private void updateFourCoilPhysicalButton_Click(object sender, EventArgs e)
        {
            updateFourCoilTextBox.Visible = true;
        }
        /// <summary>
        /// Saves the input data.
        /// </summary>
        private void saveTwoCoilPhysicalButton_Click(object sender, EventArgs e)
        {
            if (updateFourCoilTextBox.Text != "")
            {
                //StorePrototypePhysicalData(updateFourCoilTextBox.Text); WRONG
            }
            saveFourCoilButton.Text = "OK";
        }
        /// <summary>
        /// Stores the data from the experiment into the database.
        /// </summary>
        /// <param name="data">The data to be stored.</param>
        protected void StorePrototypePhysicalData(string data)
        {
            string type;
            if (prototypeSelectionBox.SelectedItem.ToString() == "Inductive-Link Coils")
            {
                type = "Inductive-Link Coils";
            }
            else if (prototypeSelectionBox.SelectedItem.ToString() == "Resonant-Link Coils")
            {
                type = "Resonant-Link Coils";
            }
            else if (prototypeSelectionBox.SelectedItem.ToString() == "Model 'F' Coils")
            {
                type = "Model 'F' Coils";
            }
            string property;
            if (fourCoilSelectionBox.SelectedItem.ToString() == "Inner Radius")
            {
                property = fourDataDisplayTextBox.Text;
            }
            else if (fourCoilSelectionBox.SelectedItem.ToString() == "Outer Radius")
            {
                property = fourDataDisplayTextBox.Text;
            }
            else if (fourCoilSelectionBox.SelectedItem.ToString() == "Number of Turns")
            {
                property = fourDataDisplayTextBox.Text;
            }
            try
            {
                // Store the specification.
                string directory = MapPath(@"\db\prototype_data.db");
                string path = @"c:\Users\ctucker\aeonProjectDirectory\Monkey-Man\thesis\circuits\CircuitCalculator";

                SQLiteConnection conn = new SQLiteConnection(@"Data Source=" + path + directory);
                SQLiteCommand cmd = new SQLiteCommand();
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO PhysicalSpecification (Type, CoilDesignation, InnerRadius) VALUES ('" + prototypeSelectionBox.SelectedItem.ToString() + "', '" + fourCoilSelectionBox.SelectedItem.ToString() + "', '" + fourDataDisplayTextBox.Text + "')";
                conn.Open();
                SQLiteTransaction trans = conn.BeginTransaction();
                cmd.ExecuteNonQuery();
                trans.Commit();
                conn.Close();
                trans.Dispose();
                cmd.Dispose();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                MessageBox.Show("Experiment saved succesfully.", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
        /// Fill the selection to the textbox.
        /// </summary>
        private void fourCoilPropertySelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string coil = fourCoilSelectionBox.SelectedItem.ToString();

            if (fourCoilPropertySelectionBox.SelectedItem.ToString() == "Inner Radius")
            {
                // retrieve data: if empty, write "empty"
            }
            if (fourCoilPropertySelectionBox.SelectedItem.ToString() == "Outer Radius")
            {

            }
            if (fourCoilPropertySelectionBox.SelectedItem.ToString() == "Wire Radius")
            {

            }
            if (fourCoilPropertySelectionBox.SelectedItem.ToString() == "Number of turns")
            {
                unitsLabel.Text = "";

            }
        }
        /// <summary>
        /// Fill the selection to the textbox.
        /// </summary>
        private void fourCoilElectricalPropertyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string coil = fourCoilSelectionBox.SelectedItem.ToString();

            

        }
    }
}