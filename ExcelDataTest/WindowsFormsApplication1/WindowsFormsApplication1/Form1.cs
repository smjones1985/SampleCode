using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private string fName, lName;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'namesDataSet.tblNames' table. You can move, or remove it, as needed.
            this.tblNamesTableAdapter.Fill(this.namesDataSet.tblNames);

        }

        private void btnAddToExcel_Click(object sender, EventArgs e)
        {
            fName = txtFirstName.Text;
            lName = txtLastName.Text;

            this.tblNamesTableAdapter.Update(this.namesDataSet.tblNames);

        }
    }
}
