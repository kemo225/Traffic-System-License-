using BussinessLayerDVLD;
using DVLDD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDD
{
    public partial class FormTestType : Form
    {
        private static DataTable MainDt;
        public ClsLocalDrivingLicense LocalLicense;
        int _LocalLicenseID;    
        private ClsTestAppoinment.enTestType TesttypeID = ClsTestAppoinment.enTestType.VisionTest;  
        public FormTestType(int LocalLicenseID,ClsTestAppoinment.enTestType mode)
        {
            LocalLicense = ClsLocalDrivingLicense.Find(LocalLicenseID);
            InitializeComponent();
            this.TesttypeID = mode;   
            this._LocalLicenseID = LocalLicenseID;
            switch (mode)
            {
                case ClsTestAppoinment.enTestType.VisionTest:
                    this.Text= "Vision Test Info";
                    lblTitle.Text = "Vision Test";
                    pbTestTypeImage.Image = Resource2.Vision_512;
                    break;
                case ClsTestAppoinment.enTestType.WrittenTest:
                    this.Text = "Written Test Info";
                    lblTitle.Text = "Written Test";
                    pbTestTypeImage.Image = Resource2.Written_Test_512;
                    break;
                case ClsTestAppoinment.enTestType.DrivingTest:
                    this.Text = "Driving Test Info";
                    lblTitle.Text = "Driving Test";
                    pbTestTypeImage.Image = Resource2.driving_test_512;
                    break;
            }
        }
        private void RefreshData()
        {
            usercontrolApplicatiioninfo1.LoadData(_LocalLicenseID);
            switch (TesttypeID)
            {
                case ClsTestAppoinment.enTestType.VisionTest:
                    lblTitle.Text = "Vision Test";
                    MainDt = ClsTestAppoinment.GetAlltestAppointTestbyLocallicenseID(this._LocalLicenseID,ClsTestAppoinment.enTestType.VisionTest); 
                    break;
                case ClsTestAppoinment.enTestType.WrittenTest:
                    lblTitle.Text = "Written Test";
                    MainDt = ClsTestAppoinment.GetAlltestAppointTestbyLocallicenseID(this._LocalLicenseID, ClsTestAppoinment.enTestType.WrittenTest);
                    break;
                case ClsTestAppoinment.enTestType.DrivingTest:
                    lblTitle.Text = "Driving Test";
                    MainDt = ClsTestAppoinment.GetAlltestAppointTestbyLocallicenseID(this._LocalLicenseID, ClsTestAppoinment.enTestType.DrivingTest);
                    break;
            }
            dataGridView1.DataSource = MainDt;

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "Appointment ID";
                dataGridView1.Columns[0].Width = 90;
                dataGridView1.Columns[1].HeaderText = "Appointment Date";
                dataGridView1.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";
                dataGridView1.Columns[1].Width = 120;
                dataGridView1.Columns[2].HeaderText = "Paid Fees";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].HeaderText = "Is Loaced";
                dataGridView1.Columns[3].Width = 80;
              
            }
        }
        private void Form18_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddaapoint_Click(object sender, EventArgs e)
        {
                 if( dataGridView1.Rows.Count > 0)
            {
                if (LocalLicense.IsFailureInlastExam(TesttypeID))
                {
                    Form19 frm = new Form19(_LocalLicenseID, TesttypeID);
                    frm.ShowDialog();
                    RefreshData();
                }
                else
                {
                 
                        MessageBox.Show("You Already Success In this Test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                
                }
            }else
            {
                Form19 frm = new Form19(_LocalLicenseID, TesttypeID);
                frm.ShowDialog();
                RefreshData();
            }   
        }
          

        private void editAppointentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form19 frm = new Form19(_LocalLicenseID, TesttypeID, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            RefreshData();
        }

        private void usercontrolApplicatiioninfo1_Load(object sender, EventArgs e)
        {

        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form20 frm = new Form20((int)(dataGridView1.CurrentRow.Cells[0].Value), _LocalLicenseID, TesttypeID);
            frm.ShowDialog();
            RefreshData();
        }
    }
}
