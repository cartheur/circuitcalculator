using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CircuitCalculator.OtherForms
{
    public partial class InvestorInteractionForm : Form
    {
        private Form owner;
        private static bool _instance;

        public InvestorInteractionForm(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            ControlBox = false;
            _instance = true;
            docSentBox.SelectedItem = "No";
            receivedReplyBox.SelectedItem = "No";
            recordListView.Columns.Add("Investor ID");
            recordListView.Columns.Add("Investor Location");
            recordListView.Columns.Add("Investor Currency");
            recordListView.Columns.Add("Investor Group Name");
            recordListView.View = View.List;
            recordListView.TileSize = new Size(180, 50);

        }
        private void InvestorInteractionForm_Load(object sender, EventArgs e)
        {

            // Load investor data from the database to the class.
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 750;
            toolTip.ReshowDelay = 250;
            toolTip.ShowAlways = true;
            docNumberLabel.Visible = false;
            docNumberBox.Visible = false;
            docSentCalendar.Visible = false;

        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return _instance; } set { _instance = value; } }
        /// <summary>
        /// Retrieves the investor.
        /// </summary>
        /// <param name="investorID">The investor ID.</param>
        /// <returns>A dataset.</returns>
        protected void RetrieveInvestor(string investorID)
        {
            try
            {
                // Recall the investor data.
                string directory = MapPath(@"\db\investor_summary.db");
                string path = @"c:\Users\ctucker\aeonProjectDirectory\Monkey-Man\thesis\circuits\CircuitCalculator";
                SQLiteConnection conn = new SQLiteConnection(@"Data Source=" + path + directory);
                SQLiteCommand cmd = new SQLiteCommand();
                DataSet ds = new DataSet();
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM InvestorReceivingSummaryRecord WHERE InvestorID=" + investorID;
                SQLiteDataAdapter adapt = new SQLiteDataAdapter(cmd);
                adapt.Fill(ds);
                conn.Close();
                ParseInvestor(ds);
                adapt.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error in recalling investor data: " + ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            //Investor investorProfile = new Investor();

        }
        /// <summary>
        /// Parses the investor.
        /// </summary>
        /// <param name="input">The input.</param>
        protected void ParseInvestor(DataSet input)
        {
            investorLocationBox.Text = input.Tables[0].Rows[0]["InvestorLocation"].ToString();
            investorCurrencyBox.SelectedItem = input.Tables[0].Rows[0]["Currency"];
            skinMarginValueBox.Text = input.Tables[0].Rows[0]["SkinMargin"].ToString();
            groupNameBox.Text = input.Tables[0].Rows[0]["GroupName"].ToString();
            referringNetworkBox.Text = input.Tables[0].Rows[0]["ReferringNetwork"].ToString();
            webAddressBox.Text = input.Tables[0].Rows[0]["WebAddress"].ToString();
            contactEmailBox.Text = input.Tables[0].Rows[0]["ContactEmail"].ToString();
            contactNameBox.Text = input.Tables[0].Rows[0]["ContactNameReply"].ToString();
            docSentBox.SelectedItem = input.Tables[0].Rows[0]["DocSent"];
            docSentCalendar.Value = Convert.ToDateTime(input.Tables[0].Rows[0]["DateDocSent"]);
            docNumberBox.Text = input.Tables[0].Rows[0]["DocNumber"].ToString();
            receivedReplyBox.SelectedItem = input.Tables[0].Rows[0]["Reply"];
            if (docSentBox.SelectedItem.ToString() == "Yes")
            {
                docNumberLabel.Visible = true;
                docNumberBox.Visible = true;
                docSentCalendar.Visible = true;
            }
        }
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            _instance = false;
            Close();
        }
        /// <summary>
        /// Show the reply region..
        /// </summary>
        private void receivedReplyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Fill the data into the form.
        /// </summary>
        private void investorIDBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (investorIDBox.SelectedItem.ToString() != "0")
            RetrieveInvestor(investorIDBox.SelectedItem.ToString());
        }
        /// <summary>
        /// Determines whether other controls will be visible.
        /// </summary>
        private void docSentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            docNumberLabel.Visible = true;
            docNumberBox.Visible = true;
            docSentCalendar.Visible = true;
        }
        /// <summary>
        /// Save the data stored in the boxes.
        /// </summary>
        private void saveInvestorDataButton_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Displays the list of docs and their assigned document numbers.
        /// </summary>
        private void findDocNumberButton_Click(object sender, EventArgs e)
        {
            if (CartheurDocumentsList.Instance == false)
            {
                CartheurDocumentsList form = new CartheurDocumentsList(this);
                form.Show(this);
                CartheurDocumentsList.Instance = true;
            }
            else if (CartheurDocumentsList.Instance == true)
            {
                // Do nothing.
            }
        }
        /// <summary>
        /// Maps the path of the executing file.
        /// </summary>
        /// <param name="path">The path to map.</param>
        public virtual string MapPath(string path)
        {
            string location = Assembly.GetEntryAssembly().Location;
            string zebra = AppDomain.CurrentDomain.BaseDirectory.ToString();
            string local = Environment.CurrentDirectory;
            return Path.Combine(zebra, path);
        }      

    }
}