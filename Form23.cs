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
    public partial class FormRenewLicense : Form
    {
        private ClsDriver driver;   
        private ClsLicense OldLicense;
        private int oldLicenseID;
        private ClsApplication applicationNewel;
        private ClsLicense NewLicense;
        private int NewLicenseID;   
        public FormRenewLicense()
        {
            InitializeComponent();
        }
        private void FillBasicData()
        {
            txtNotes.ReadOnly = false;
            lblApplicationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblIssueDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblApplicationFees.Text = ClsApplicationType.Find(Convert.ToInt32(ClsApplicationType.enApplicationType.RenewDrivingLicense)).ApplicationFees.ToString();
            lblCreatedByUser.Text = ClsGlobal.CurrentUser.UserName;
            txtNotes.Text = OldLicense.Notes;
            lblLicenseFees.Text = OldLicense.LicenseInfo.ClassFees.ToString();
            lblExpirationDate.Text = DateTime.Now.AddYears(OldLicense.LicenseInfo.DefaultValidityLength).ToString("dd/MM/yyyy");
            lblTotalFees.Text = (Convert.ToInt32(lblLicenseFees.Text) + Convert.ToInt32(lblApplicationFees.Text)).ToString();
        }
        private void Form23_Load(object sender, EventArgs e)
        {
        }
        private void CreationNewApp()
        {
             applicationNewel = new ClsApplication();
            applicationNewel.ApplicationTypeID = Convert.ToInt32(ClsApplicationType.enApplicationType.RenewDrivingLicense);
            applicationNewel.ApplicationDate = DateTime.Now;
            applicationNewel.CreatedByUserId = ClsGlobal.CurrentUser.UserID;
            applicationNewel.Applicationstatus = Convert.ToInt32(ClsApplication.enApplicationStatus.New);
            applicationNewel.PaidFees = ClsApplicationType.Find(Convert.ToInt32(ClsApplicationType.enApplicationType.RenewDrivingLicense)).ApplicationFees;
            applicationNewel.ApplicationPersonID = OldLicense.DriverInfo.PeopleID;
            applicationNewel.Laststatusdate = DateTime.Now;

            if (!applicationNewel.Save())
            {
                MessageBox.Show("Application Creation Failed");
                return;
            }
        }
        private void CreationNewellicense()
        {
            NewLicense = new ClsLicense();
            NewLicense.ApplicationID = applicationNewel.ApplicationID;
            NewLicense.DriverID = OldLicense.DriverID;
            NewLicense.LicenseClassID = OldLicense.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.Notes = txtNotes.Text;
            NewLicense.IsActive = true;
            NewLicense.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
            NewLicense.ExpiryDate = DateTime.Now.AddYears(OldLicense.LicenseInfo.DefaultValidityLength);
            NewLicense.IssueReason = Convert.ToInt32(ClsLicense.enIssueLicenseReason.Renewal);
            NewLicense.paidFees = Convert.ToInt32(lblLicenseFees.Text);

        }
        private void btnRenewLicense_Click(object sender, EventArgs e)
        {//Full Data  Original
            if (OldLicense.IsActive)
            {
                MessageBox.Show("License is not expired yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (driver.IsdriverHssActiveLicense(OldLicense.LicenseClassID)!=-1)
            {
                MessageBox.Show($"The Driver {driver.FirstName} Has Already Active License And ID = {driver.IsdriverHssActiveLicense(OldLicense.LicenseClassID)}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                OldLicense.HandleOldlecenseBeDisActive();
                CreationNewApp();

                CreationNewellicense();

                txtNotes.ReadOnly = true;
                lblApplicationID.Text = applicationNewel.ApplicationID.ToString();

                if (NewLicense.Save() && OldLicense.Save())
                {     

                    NewLicenseID = NewLicense.LicenseID;    
                    MessageBox.Show($"License Issued Successfully And The ID = {NewLicenseID}", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRenewLicense.Enabled = false;
                    llShowLicenseHistory.Enabled = true;
                    llShowLicenseInfo.Enabled = true;

                }
            }

        }

        private void userCntrlInfoWithFilter1_OnLicenseSelected(int obj)
        {
            oldLicenseID = obj;
            OldLicense = ClsLicense.Find(oldLicenseID);
            driver=ClsDriver.Find(OldLicense.DriverInfo.DriverID);    

            lblOldLicenseID.Text = OldLicense.LicenseID.ToString();

            btnRenewLicense.Enabled = true;

            FillBasicData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formLicenseInfo frm = new formLicenseInfo(NewLicenseID);
            frm.ShowDialog();   
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHistoreyLicense frm = new FormHistoreyLicense(NewLicense.DriverID);
            frm.ShowDialog();
        }

        private void userCntrlInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }
    }
}
