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
    public partial class FormListInternational : Form
    {
        private DataTable MainDt=ClsInterNationalLicense.GetAllInterNationalLicense();
        public FormListInternational()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            MainDt = ClsInterNationalLicense.GetAllInterNationalLicense();  

            dataGridView1.DataSource = MainDt;
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "International License ID";
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].HeaderText = "Application ID";
                dataGridView1.Columns[1].Width = 80;
                dataGridView1.Columns[2].HeaderText = "Driver ID";
                dataGridView1.Columns[2].Width = 80;
                dataGridView1.Columns[3].HeaderText = "Issued Using Local License ID";
                dataGridView1.Columns[3].Width = 210;
                dataGridView1.Columns[4].HeaderText = "Issue Date";
                dataGridView1.Columns[4].Width = 200;
                dataGridView1.Columns[5].HeaderText = "Expiration Date";
                dataGridView1.Columns[5].Width = 130;
                dataGridView1.Columns[6].HeaderText = "Is Active";
                dataGridView1.Columns[6].Width = 90;
                dataGridView1.Columns[7].HeaderText = "User Name";
                dataGridView1.Columns[7].Width = 90;
                labelnumberlicense.Text = dataGridView1.Rows.Count.ToString();
            }
            else
            {
                labelnumberlicense.Text = 0.ToString();
            }   
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            FormInterNational fr = new FormInterNational(); 
                
            fr.ShowDialog();    
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forminternationalinfo frm = new Forminternationalinfo(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    FilterColumn = "InternationalLicenseID";
                    break;
                case 1:
                    FilterColumn = "ApplicationID";
                    break;
                case 2:
                    FilterColumn = "DriverID";
                    break;
                case 3:
                    FilterColumn = "IssuedUsingLocalLicenseID";
                    break;
                case 4:
                    FilterColumn = "IssueDate";
                    break;
                case 5:
                    FilterColumn = "ExpirationDate";
                    break;
                case 6:
                    FilterColumn = "IsActive";
                    break;
                case 7:
                    FilterColumn = "None";
                    break;
            }
            if (textBox1.Text.Trim() == "" || FilterColumn == "None")
            {
                RefreshData();
                labelnumberlicense.Text = dataGridView1.Rows.Count.ToString();
                return;
            }
            if (comboBox1.Text == "Driver ID" || comboBox1.Text == "ApplicationID" )
            {
                MainDt.DefaultView.RowFilter =string.Format("[{0}]={1}", FilterColumn, textBox1.Text);
            }
            else
            {
                MainDt.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", FilterColumn, textBox1.Text); 
            }
            dataGridView1.DataSource = MainDt;
            labelnumberlicense.Text = dataGridView1.Rows.Count.ToString();
        }

        private void FormListInternational_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void personDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersonCard fr = new FormPersonCard(ClsLicense.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value)).ApplicationInfo.ApplicationPersonID);
            fr.ShowDialog();
        }

        private void showLicenseHistoreyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistoreyLicense frm = new FormHistoreyLicense(ClsLicense.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value)).DriverID);
            frm.ShowDialog();
        }
    }
}
