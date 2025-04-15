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
    public partial class FormLostLicense : Form
    {
      private  ClsApplication newapp;
        private int oldLicenseId;
        private ClsLicense OldLicense;
        private ClsLicense NewLicense;
        private  int NewLicenseID;
        public FormLostLicense()
        {
            InitializeComponent();
        }
        private void FillBasicData()
        {
            lblApplicationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblCreatedByUser.Text = ClsGlobal.CurrentUser.UserName;
            lblLicenseFees.Text = OldLicense.LicenseInfo.ClassFees.ToString(); 
            txtNotes.Text = OldLicense.Notes;  
            txtNotes.ReadOnly = false;
        }   
        private void userCntrlInfoWithFilter1_OnLicenseSelected(int obj)
        {
            oldLicenseId = obj;
            OldLicense = ClsLicense.Find(obj);
            FillBasicData();
            btnIssueLLicense.Enabled = true;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtondmged.Checked) { 
            lblApplicationFees.Text = ClsApplicationType.Find(Convert.ToInt32(ClsApplicationType.enApplicationType.replacementforDamged)).ApplicationFees.ToString();
            if(lblLicenseFees.Text != "0")
                lblTotalFees.Text = (Convert.ToInt32(lblLicenseFees.Text) + Convert.ToInt32(lblApplicationFees.Text)).ToString();
            }
            else
            {
                lblApplicationFees.Text = ClsApplicationType.Find(Convert.ToInt32(ClsApplicationType.enApplicationType.replacementforlost)).ApplicationFees.ToString();
                if (lblLicenseFees.Text != "0")
                    lblTotalFees.Text = (Convert.ToInt32(lblLicenseFees.Text) + Convert.ToInt32(lblApplicationFees.Text)).ToString();
            }

        }

        private void Form24_Load(object sender, EventArgs e)
        {
            lblLicenseFees.Text = "0";
            lblApplicationFees.Text = "0";
            lblTotalFees.Text = "0";
        }
        private void CreationAppForReplacement()
        {
             newapp = new ClsApplication();
            newapp.ApplicationTypeID = Convert.ToInt32(ClsApplicationType.enApplicationType.replacementforDamged);
            newapp.ApplicationDate = DateTime.Now;
            newapp.CreatedByUserId = ClsGlobal.CurrentUser.UserID;
            newapp.Applicationstatus = Convert.ToInt32(ClsApplication.enApplicationStatus.New);
            if(radioButtondmged.Checked)
                newapp.PaidFees = ClsApplicationType.Find(Convert.ToInt32(ClsApplicationType.enApplicationType.replacementforDamged)).ApplicationFees;
            else
                newapp.PaidFees = ClsApplicationType.Find(Convert.ToInt32(ClsApplicationType.enApplicationType.replacementforlost)).ApplicationFees;
            newapp.ApplicationPersonID = OldLicense.DriverInfo.PeopleID;
            newapp.Laststatusdate = DateTime.Now;
            if (!newapp.Save())
            {
                MessageBox.Show("Application Creation Failed");
                btnIssueLLicense.Enabled = false;   
                return ;
            }
            btnIssueLLicense.Enabled = true;
            radioButtondmged.Enabled = false;
            radioButtonlost.Enabled = false;

        }
        private void CrationNewLicense()
        {
            NewLicense = new ClsLicense();
            NewLicense.ApplicationID = newapp.ApplicationID;
            NewLicense.DriverID = OldLicense.DriverID;
            NewLicense.LicenseClassID = OldLicense.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.Notes = txtNotes.Text;
            NewLicense.IsActive = true;
            NewLicense.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
            NewLicense.ExpiryDate = DateTime.Now.AddYears(OldLicense.LicenseInfo.DefaultValidityLength);
            if (radioButtondmged.Checked)
                NewLicense.IssueReason = Convert.ToInt32(ClsLicense.enIssueLicenseReason.Damaged);
            else
                NewLicense.IssueReason = Convert.ToInt32(ClsLicense.enIssueLicenseReason.Lost);
            NewLicense.paidFees = Convert.ToInt32(lblLicenseFees.Text);
         
        }
   
        private void btnRenewLicense_Click(object sender, EventArgs e)
        {
           

            CreationAppForReplacement();

            CrationNewLicense();
            OldLicense.IsActive = false;
            lblIssueDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtNotes.ReadOnly = true;
            lblApplicationID.Text = newapp.ApplicationID.ToString();

            if (NewLicense.Save()&& OldLicense.Save())
            {
                NewLicenseID = NewLicense.LicenseID;
                MessageBox.Show($"License Issued Successfully And The ID ={NewLicense.LicenseID}");
                btnIssueLLicense.Enabled = false;
                llShowLicenseInfo.Enabled = true;
                llShowLicenseHistory.Enabled = true;
            }
            else
            {
                MessageBox.Show("License Issued Failed");
            }
       

        }

        private void userCntrlInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formLicenseInfo formLicenseInfo = new formLicenseInfo(NewLicenseID);
            formLicenseInfo.ShowDialog();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHistoreyLicense frm = new FormHistoreyLicense(NewLicense.DriverID);
            frm.ShowDialog();   
        }

        private void radioButtonlost_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtondmged.Checked)
            {
                lblApplicationFees.Text = ClsApplicationType.Find(Convert.ToInt32(ClsApplicationType.enApplicationType.replacementforDamged)).ApplicationFees.ToString();
                if (lblLicenseFees.Text != "0")
                    lblTotalFees.Text = (Convert.ToInt32(lblLicenseFees.Text) + Convert.ToInt32(lblApplicationFees.Text)).ToString();
            }
            else
            {
                lblApplicationFees.Text = ClsApplicationType.Find(Convert.ToInt32(ClsApplicationType.enApplicationType.replacementforlost)).ApplicationFees.ToString();
                if (lblLicenseFees.Text != "0")
                    lblTotalFees.Text = (Convert.ToInt32(lblLicenseFees.Text) + Convert.ToInt32(lblApplicationFees.Text)).ToString();
            }
        }
    }
}
