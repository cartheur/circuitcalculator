using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CircuitCalculator
{
    public partial class NoteTextPanel : Form
    {
        private Form owner;
        private static bool instance = false;
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        public NoteTextPanel(Form mOwner)
        { 
            InitializeComponent();
            owner = mOwner;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            instance = true;
            this.StartPosition = FormStartPosition.CenterParent;
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return instance; } set { instance = value; } }
        /// <summary>
        /// The load event for the inductance calculator form.
        /// </summary>
        private void NoteTextPanel_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 400;
            toolTip.ReshowDelay = 200;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.saveNotesButton, "This pad is designed to append if you save to the same file name. It will not replace the file.");
        }
        /// <summary>
        /// Saves the notes on the pad.
        /// </summary>
        protected void SaveNotes()
        {
            if (notesTextBox.Text == "")
            {
                MessageBox.Show("You must input text in order to save.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else if (notesTextBox.Text != "")
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter myStream = new StreamWriter(saveFileDialog.FileName, true);
                    myStream.Write(notesTextBox.Text);
                    myStream.Close();
                }
                notifyLabel.Text = "File successfully saved.";
            }
        }
        /// <summary>
        /// Saves the notes on the form into a text file.
        /// </summary>
        private void saveNotesButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter myStream = new StreamWriter(saveFileDialog.FileName, true);
                myStream.Write(notesTextBox.Text);
                myStream.Close();
            }
            notifyLabel.Text = "File successfully saved.";
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
        /// Closes the Notepad form.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            if (notesTextBox.Text == "")
            {
                instance = false;
                Close();
            }
            else if (notesTextBox.Text != "")
            {
                if (MessageBox.Show("You have text on the pad, do you want to save it?", "Query", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    SaveNotes();
                }
                else
                {
                    instance = false;
                    Close();
                }
            }
        }
    }
}