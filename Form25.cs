using BussinessLayerDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDD
{
    public partial class FormDrivers : Form
    {
        protected DataTable MainDt = ClsDriver.GetallDrivers();
        public FormDrivers()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            MainDt = ClsDriver.GetallDrivers();
            dataGridView1.DataSource = MainDt;
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "Driver ID";
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].HeaderText = "National NO";
                dataGridView1.Columns[1].Width = 80;
                dataGridView1.Columns[2].HeaderText = "Full Name";
                dataGridView1.Columns[2].Width = 210;
                dataGridView1.Columns[3].HeaderText = "Creation Date";
                dataGridView1.Columns[3].Width = 200;
                dataGridView1.Columns[4].HeaderText = "Active L.License";
                dataGridView1.Columns[4].Width = 130;
                dataGridView1.Columns[5].HeaderText = "User Name";
                dataGridView1.Columns[5].Width = 90;

                labelnumberpeople.Text = dataGridView1.Rows.Count.ToString();

            }
            else
            {
                labelnumberpeople.Text = 0.ToString();

            }

        }
        private void FormDrivers_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Driver ID
            //            National NO
            //Creation Date
            //Active Test
            string FilterColumn = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    FilterColumn = "DriverID";
                    break;
                case 1:
                    FilterColumn = "National No";
                    break;
                case 2:
                    FilterColumn = "FullName";
                    break;
                case 3:
                    FilterColumn = "CreatedDate";
                    break;
                case 4:
                    FilterColumn = "UserName";
                    break;
                case 5:
                    FilterColumn = "ActiveLicense";
                    break;
                case 6:
                    FilterColumn = "None";
                    break;
            }
            if (textBox1.Text.Trim() == "" || FilterColumn == "None")
            {
                RefreshData();
                labelnumberpeople.Text = dataGridView1.Rows.Count.ToString();
                return;
            }
            if (comboBox1.Text == "Driver ID" || comboBox1.Text == "Active License")
            {
                MainDt.DefaultView.RowFilter =string.Format("{0}={1}", FilterColumn, textBox1.Text);    
            }
            else
            {
                MainDt.DefaultView.RowFilter = string.Format("{0} like '{1}%'", FilterColumn, textBox1.Text);
            }
            dataGridView1.DataSource = MainDt;
            labelnumberpeople.Text = dataGridView1.Rows.Count.ToString();  
        }

        private void showHistoreyLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistoreyLicense frm = new FormHistoreyLicense(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersonCard frm = new FormPersonCard(ClsDriver.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)).PeopleID);
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormPersonCard frm = new FormPersonCard(ClsDriver.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)).PeopleID);
            frm.ShowDialog();
        }
    }
}
