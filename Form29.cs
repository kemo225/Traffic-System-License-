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
    public partial class FormDetainList : Form
    {
        
       
        private DataTable DtMain = ClsDetainLicense.GetallDetainLicense();  
        public FormDetainList()
        {
            InitializeComponent();
           
        }
        private void RefreshData()
        {
            DtMain = ClsDetainLicense.GetallDetainLicense();
            dataGridView1.DataSource= DtMain;
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "Detain ID";
                dataGridView1.Columns[0].Width = 70;
                dataGridView1.Columns[1].HeaderText = "License ID";
                dataGridView1.Columns[1].Width = 70;
                dataGridView1.Columns[2].HeaderText = "Driver ID";
                dataGridView1.Columns[2].Width = 70;
                dataGridView1.Columns[3].HeaderText = "National No";
                dataGridView1.Columns[3].Width = 80;
                dataGridView1.Columns[4].HeaderText = "Full Name";
                dataGridView1.Columns[4].Width = 210;
                dataGridView1.Columns[5].HeaderText = "Detain Date";
                dataGridView1.Columns[5].Width = 120;
                dataGridView1.Columns[6].HeaderText = "Fine Fees";
                dataGridView1.Columns[6].Width = 120;
                dataGridView1.Columns[7].HeaderText = "Is Released";
                dataGridView1.Columns[7].Width = 60;
                dataGridView1.Columns[8].HeaderText = "Release Date";
                dataGridView1.Columns[8].Width = 120;
                dataGridView1.Columns[9].HeaderText = "R.App ID";
                dataGridView1.Columns[9].Width = 70;

                labelnumberpeople.Text = dataGridView1.Rows.Count.ToString();

            }
        }
        private void FormDetainList_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void personDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsDriver Driver = ClsDriver.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value));
            FormPersonCard frm = new FormPersonCard(Driver.PeopleID);
            frm.ShowDialog();   
        }

        private void showLicenseHistoreyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsDriver Driver = ClsDriver.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value));
            FormHistoreyLicense frm = new FormHistoreyLicense(Driver.DriverID);
            frm.ShowDialog();   
        }

        private void showLicenseDetailssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLicenseInfo frm=new formLicenseInfo(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value));   
            frm.ShowDialog();
            RefreshData();

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClsDriver Driver = ClsDriver.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value));
            FormPersonCard frm = new FormPersonCard(Driver.PeopleID);
            frm.ShowDialog();
            RefreshData();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(Convert.ToBoolean(dataGridView1.CurrentRow.Cells[7].Value)==true)
            {
                contextMenuStrip1.Items[3].Enabled = false; 
            }else
            {
                contextMenuStrip1.Items[3].Enabled = true;

            }
        }

        private void releaseDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReleaseDetainLicense frm = new FormReleaseDetainLicense(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            RefreshData();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttondetainlicense_Click(object sender, EventArgs e)
        {
            FormDetain frm = new FormDetain();
            frm.ShowDialog();
            RefreshData();

        }

        private void buttonRelease_Click(object sender, EventArgs e)
        {
            FormReleaseDetainLicense frm=new FormReleaseDetainLicense();        
            frm.ShowDialog();
            RefreshData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;    
            textBox1.Focus();   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string filterColumn = "";
            switch (comboBox1.Text)
            {
                case "Detain ID":
                    filterColumn = "DetainID";
                    break;
                case "License ID":
                    filterColumn = "LicenseID";
                    break;
                case "Driver ID":
                    filterColumn = "DriverID";
                    break;
                case "Release Date":
                    filterColumn = "ReleaseDate";
                    break;
                case "Fine Fees":
                    filterColumn = "Fine Fees";
                    break;
                case "Full Name":
                    filterColumn = "FullName";
                    break;
                case "National No":
                    filterColumn = "NationalNo";
                    break;
                case "R.App ID":
                    filterColumn = "ReleaseApplicationID";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }
            if (textBox1.Text.Trim() == "" || filterColumn == "None")
            {
                RefreshData();
                labelnumberpeople.Text = dataGridView1.Rows.Count.ToString();
                return;
            }
            if (filterColumn == "DetainID" || filterColumn == "LicenseID" || filterColumn == "DriverID" || filterColumn == "ReleaseApplicationID" || filterColumn == "Fine Fees")
            { DtMain.DefaultView.RowFilter = string.Format("[{0}]={1}", filterColumn, textBox1.Text); }
            else
            { DtMain.DefaultView.RowFilter = string.Format("[{0}] like '{1}%' ", filterColumn, textBox1.Text); }
            labelnumberpeople.Text = dataGridView1.Rows.Count.ToString();
            dataGridView1.DataSource = DtMain;
        }
    }
}
