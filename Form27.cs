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
    public partial class FormReleaseDetainLicense : Form
    {
        private int  DetainID;

        private int LicenseID;
        private ClsLicense License;
        private ClsApplication application;
        private ClsDetainLicense DetainLicense;
        public FormReleaseDetainLicense(int DetainID)
        {
            InitializeComponent();
            this.DetainID = DetainID;   
            DetainLicense=ClsDetainLicense.Find(DetainID);
            if (DetainLicense == null)
            {
                MessageBox.Show("DetainID Is Not Found");
                return;
            }
            userCntrlInfoWithFilter1.ControlMasked.Text = DetainLicense.LicenseID.ToString();
            userCntrlInfoWithFilter1.Gbfilter.Enabled = false;
            License = ClsLicense.Find(DetainLicense.LicenseID);
            userCntrlInfoWithFilter1.LoadData(DetainLicense.LicenseID);
            FillBasicData();
            llShowLicenseHistory.Enabled = true;
            btnDetainLicense.Enabled = true;
        }
        public FormReleaseDetainLicense()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void CreationApp()
        {
            application = new ClsApplication();
            application.ApplicationPersonID = License.DriverInfo.PeopleID;
            application.Applicationstatus = (int)ClsApplication.enApplicationStatus.Completed;
            application.ApplicationTypeID = Convert.ToInt32(ClsApplicationType.enApplicationType.replacementDetainDriving);
            application.ApplicationDate=DateTime.Now;   
            application.Laststatusdate= DateTime.Now;
            application.CreatedByUserId = ClsGlobal.CurrentUser.UserID;
            application.PaidFees = ClsApplicationType.Find(Convert.ToInt32(ClsApplicationType.enApplicationType.replacementDetainDriving)).ApplicationFees;
            if(!application.Save())
            {
                MessageBox.Show($"Application Saved Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void FillBasicData()
        {
            lblCreatedByUser.Text =License.CreatedByUserInfo.UserName;
            lblLicenseID.Text = License.LicenseID.ToString();
            labeldetaindate.Text=DetainLicense.DetainDate.ToString("dd-MM-yyyy") ;
            labelfeesapp.Text=ClsApplicationType.Find(Convert.ToInt32(ClsApplicationType.enApplicationType.replacementDetainDriving)).ApplicationFees.ToString() ;
            labelfinefees.Text = DetainLicense.FineFees.ToString();
            labeltotalfees.Text = (Convert.ToInt32(labelfeesapp.Text) + Convert.ToInt32(labelfinefees.Text)).ToString();
        }
        private void userCntrlInfoWithFilter1_OnLicenseSelected(int obj)
        {
            LicenseID = obj;
            License = ClsLicense.Find(LicenseID);

            if(!License.IsDatain)
            {
                MessageBox.Show($"License Not Detain", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DetainLicense = ClsDetainLicense.FindbyLicenseID(LicenseID);

            FillBasicData();

            llShowLicenseHistory.Enabled = true;
            btnDetainLicense.Enabled = true;


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            CreationApp();

            labelappid.Text = License.ApplicationID.ToString();

            DetainLicense.ReleaseApplicationID = application.ApplicationID;
            DetainLicense.ReleaseDate = DateTime.Now;
            DetainLicense.ReleasedByUserID = ClsGlobal.CurrentUser.UserID;
            DetainLicense.IsReleased = true;
            if (DetainLicense.Save()) {

                MessageBox.Show($"Successfuly Process,Detain License is Released from this Fine", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDetainLicense.Enabled = false;

                if (ClsDetainLicense.FindbyLicenseID(LicenseID) != null)
                {
                    if (MessageBox.Show($"License Still Detained,Do You Want Release Detain License ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    { 
                        this.Close();
                        FormReleaseDetainLicense frm = new FormReleaseDetainLicense(LicenseID);
                        frm.ShowDialog();
                    }
                   
                }
                else
                {
                    MessageBox.Show($"Successfuly Process , License Not Detain License", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            else
            {
                MessageBox.Show("Failed Released Detain License ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormReleaseDetainLicense_Load(object sender, EventArgs e)
        {

        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHistoreyLicense frm = new FormHistoreyLicense(License.DriverID);
            frm.ShowDialog();   
        }

        private void userCntrlInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }
    }
}
