using System;
using System.Data;
using System.Windows.Forms;

namespace CircuitCalculator
{
    public partial class TableSelectDialog : Form
    {

        public TableSelectDialog(string[] tables)
        {
            InitializeComponent();

            this.listBox1.DataSource = tables;
        }

        public string Selection
        {
            get { return this.listBox1.SelectedItem as string; }
        }
    }
}