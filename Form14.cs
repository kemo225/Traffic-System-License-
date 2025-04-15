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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLDD
{
    public partial class FormLocalDrivingApp : Form
    {
        private ClsLocalDrivingLicense LocalDrivingLicense;
        private static DataTable MainDT = ClsLocalDrivingLicense.GetAllDrivingLocalLicense();
        private DataTable Subsetdt = MainDT.DefaultView.ToTable(false);
        public FormLocalDrivingApp()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {

            MainDT = ClsLocalDrivingLicense.GetAllDrivingLocalLicense();
            Subsetdt = MainDT.DefaultView.ToTable(false, "LocalDrivingLicenseApplicationID", "NationalNO", "FullName", "ApplicationDate", "ClassName", "LastStatusDate", "TestPased", "Statuss", "UserName");
            dataGridView1.DataSource = Subsetdt;
        }

        private void FormLocalDrivingApp_Load(object sender, EventArgs e)
        {
            RefreshData();
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "L.D.App ID";
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].HeaderText = "National NO";
                dataGridView1.Columns[1].Width = 80;
                dataGridView1.Columns[2].HeaderText = "Full Name";
                dataGridView1.Columns[2].Width = 210;
                dataGridView1.Columns[3].HeaderText = "Application Date";
                dataGridView1.Columns[3].Width = 120;
                dataGridView1.Columns[4].HeaderText = "Class Name";
                dataGridView1.Columns[4].Width = 180;
                dataGridView1.Columns[5].HeaderText = "Last Date";
                dataGridView1.Columns[5].Width = 120;
                dataGridView1.Columns[6].HeaderText = "Passed Test";
                dataGridView1.Columns[6].Width = 60;
                dataGridView1.Columns[7].HeaderText = "Status";
                dataGridView1.Columns[7].Width = 90;
                dataGridView1.Columns[8].HeaderText = "User Name";
                dataGridView1.Columns[8].Width = 90;

                labelnumberpeople.Text = dataGridView1.Rows.Count.ToString();

            }
            else
            {
                labelnumberpeople.Text = 0.ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                case "App ID":
                    filterColumn = "LocalDrivingLicenseApplicationID";
                    break;
                case "National No":
                    filterColumn = "NationalNO";
                    break;
                case "Full Name":
                    filterColumn = "FullName";
                    break;
                case "Class Name":
                    filterColumn = "ClassName";
                    break;
                case "Test Passed":
                    filterColumn = "TestPassed";
                    break;
                case "User Name":
                    filterColumn = "UserName";
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
            if (filterColumn == "LocalDrivingLicenseApplicationID"|| filterColumn == "TestPased")
            { Subsetdt.DefaultView.RowFilter = string.Format("[{0}]={1}", filterColumn, textBox1.Text); }
            else
            { Subsetdt.DefaultView.RowFilter = string.Format("[{0}] like '{1}%' ", filterColumn, textBox1.Text); }
            labelnumberpeople.Text = dataGridView1.Rows.Count.ToString();
            dataGridView1.DataSource = Subsetdt;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applicationInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 frm = new Form17(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            frm.ShowDialog();   
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form17 frm = new Form17(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            Form13 frm = new Form13(-1);
            frm.ShowDialog();
            RefreshData();
        }

        private void updateAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 frm=new Form13(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            RefreshData();  
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            LocalDrivingLicense = ClsLocalDrivingLicense.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

            if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "New")
            {

                contextMenuStrip1.Items[9].Enabled = false;

                contextMenuStrip1.Items[2].Enabled = true;
                contextMenuStrip1.Items[4].Enabled = true;
                contextMenuStrip1.Items[5].Enabled = false;
                contextMenuStrip1.Items[7].Enabled = true;
                if((int)dataGridView1.CurrentRow.Cells[6].Value==3)
                    {
                    contextMenuStrip1.Items[8].Enabled = true;
                    contextMenuStrip1.Items[7].Enabled = false;
                }
           


                ClsTestAppoinment.enTestType LastTesttype = ClsTestAppoinment.GetLastTestType(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                switch (LastTesttype)
                {
                    case ClsTestAppoinment.enTestType.VisionTest:
                        if (LocalDrivingLicense.IsSuccessInlastExam(ClsTestAppoinment.enTestType.VisionTest))
                        {
                            visionTestToolStripMenuItem.Enabled = false;
                            drivingTestToolStripMenuItem.Enabled = false;
                            writtenTestToolStripMenuItem.Enabled = true;
                        }
                        else
                        {
                            visionTestToolStripMenuItem.Enabled = true;
                            drivingTestToolStripMenuItem.Enabled = false;
                            writtenTestToolStripMenuItem.Enabled = true;
                        }

                        break;
                    case ClsTestAppoinment.enTestType.WrittenTest:
                        if (LocalDrivingLicense.IsSuccessInlastExam(ClsTestAppoinment.enTestType.WrittenTest))
                        {
                            visionTestToolStripMenuItem.Enabled = false;
                            drivingTestToolStripMenuItem.Enabled = true;
                            writtenTestToolStripMenuItem.Enabled = false;
                        }
                        else
                        {
                            visionTestToolStripMenuItem.Enabled = false;
                            drivingTestToolStripMenuItem.Enabled = false;
                            writtenTestToolStripMenuItem.Enabled = true;
                        }
                        break;
                    case ClsTestAppoinment.enTestType.DrivingTest:
                        if (LocalDrivingLicense.IsSuccessInlastExam(ClsTestAppoinment.enTestType.DrivingTest))
                        {
                            visionTestToolStripMenuItem.Enabled = false;
                            drivingTestToolStripMenuItem.Enabled = false;
                            writtenTestToolStripMenuItem.Enabled = false;
                            contextMenuStrip1.Items[7].Enabled = true;
                        }
                        else
                        {
                            visionTestToolStripMenuItem.Enabled = false;
                            drivingTestToolStripMenuItem.Enabled = true;
                            writtenTestToolStripMenuItem.Enabled = false;
                        }
                        break;
                    default:
                        visionTestToolStripMenuItem.Enabled = true;
                        drivingTestToolStripMenuItem.Enabled = false;
                        writtenTestToolStripMenuItem.Enabled = false;
                        break;

                }
            }
            else
            {
                contextMenuStrip1.Items[2].Enabled = false;
                contextMenuStrip1.Items[4].Enabled = false;
                contextMenuStrip1.Items[7].Enabled = false;

                if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "Canceled")
                {    contextMenuStrip1.Items[5].Enabled = true;
                    contextMenuStrip1.Items[8].Enabled = false;
                }

                else
                {
                    contextMenuStrip1.Items[5].Enabled = false;
                    if ((int)dataGridView1.CurrentRow.Cells[6].Value == 3)
                    {
                        contextMenuStrip1.Items[8].Enabled = false;

                        contextMenuStrip1.Items[9].Enabled = true;

                    }
                   
                }

            }
          

        }

        private void addAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 frm=new Form13(-1);  
            frm.ShowDialog();   
        }

        private void cancelAppToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want Cancel Application ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            ClsLocalDrivingLicense localDrivingLicense = ClsLocalDrivingLicense.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            localDrivingLicense.Cancel();
            MessageBox.Show("App Cancel Successfuly", "Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
            RefreshData();  
        }

        private void deleteAppToolStripMenuItem1_Click(object sender, EventArgs e)
       {
            if (MessageBox.Show("Are You Sure You Want Delete Application ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if(ClsLocalDrivingLicense.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("App Deleted Successfuly", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }else
                {
                MessageBox.Show("App Not Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshData();
        }

        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTestType frm = new FormTestType(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), ClsTestAppoinment.enTestType.VisionTest); 
            frm.ShowDialog();
            RefreshData();

        }
        private void writtenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTestType frm = new FormTestType(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), ClsTestAppoinment.enTestType.WrittenTest);
            frm.ShowDialog();
            RefreshData();

        }
        private void drivingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
            FormTestType frm = new FormTestType(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), ClsTestAppoinment.enTestType.DrivingTest);
            frm.ShowDialog();
            RefreshData();

        }
        private void scheduleTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scheduleTestToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            if (contextMenuStrip1.Items[7].Enabled == true)
            {
                if ((int)dataGridView1.CurrentRow.Cells[6].Value==0)
                {
                    visionTestToolStripMenuItem.Enabled = true;
                    writtenTestToolStripMenuItem.Enabled = false;
                    drivingTestToolStripMenuItem.Enabled = false;
                }
                else if((int)dataGridView1.CurrentRow.Cells[6].Value == 1)
                {
                    visionTestToolStripMenuItem.Enabled = false;
                    writtenTestToolStripMenuItem.Enabled = true;
                    drivingTestToolStripMenuItem.Enabled = false;
                }
                else
                {
                    visionTestToolStripMenuItem.Enabled = false;
                    writtenTestToolStripMenuItem.Enabled = false;
                    drivingTestToolStripMenuItem.Enabled = true;
                }
            }
            else
            {
                visionTestToolStripMenuItem.Enabled = false;
                writtenTestToolStripMenuItem.Enabled = false;
                drivingTestToolStripMenuItem.Enabled = false;
            }
     
        }

        private void issueLiecenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIssueLicenseFirsttime frm = new FormIssueLicenseFirsttime((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshData();  

        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsLocalDrivingLicense localDrivingLicense = ClsLocalDrivingLicense.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            ClsLicense License = ClsLicense.FindByApplicationID(localDrivingLicense.ApplicationID);
            if (License != null)
            {
                formLicenseInfo formLicenseInfo = new formLicenseInfo(License.LicenseID);
                formLicenseInfo.ShowDialog();
            }
            else
            {
                MessageBox.Show("License Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
    }
}
