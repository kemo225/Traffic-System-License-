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
    public partial class FormIssueLicenseFirsttime : Form
    {
        private int LicenseID;
        private int LocalDrivingLicenseID;
        private ClsLocalDrivingLicense LocalLicense;    
        public FormIssueLicenseFirsttime(int LocalDrivingLicenseID)
        {
            InitializeComponent();
            this.LocalDrivingLicenseID = LocalDrivingLicenseID;
            LocalLicense=ClsLocalDrivingLicense.Find(LocalDrivingLicenseID);    
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            usercontrolApplicatiioninfo1.LoadData(LocalDrivingLicenseID); 
        }

        private void buttonissue_Click(object sender, EventArgs e)
        {
            
            if (!ClsDriver.IsDriverExistByPersonID(LocalLicense.ApplicationPersonID))
            {
                ClsDriver driver = new ClsDriver();
                driver.PeopleID = LocalLicense.ApplicationPersonID;
                driver.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
                driver.CreatedDate = DateTime.Now;
               if(   !driver.Save())
                {
                    MessageBox.Show("Driver Creation Failed");
                    return;
                }

            }

            ClsLicense license = new ClsLicense();
            license.ApplicationID = LocalLicense.ApplicationID;
            license.DriverID=ClsDriver.FindByPersonID(LocalLicense.ApplicationPersonID).DriverID;
            license.LicenseClassID=LocalLicense.ClassLicenseID;
            license.IssueDate = DateTime.Now;
            license.Notes=textBoxNotes.Text;
            license.IsActive = true;    
            license.CreatedByUserID= LocalLicense.CreatedByUserId;
            license.ExpiryDate=DateTime.Now.AddYears(LocalLicense.LicenseInfo.DefaultValidityLength);
            license.IssueReason=(int)ClsLicense.enIssueLicenseReason.New;
            license.paidFees = LocalLicense.LicenseInfo.ClassFees;

            if(license.Save())
            {
                LicenseID = license.LicenseID;  
                MessageBox.Show($"License Issued Successfully And The ID = {LicenseID}","Congratulation",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LocalLicense.ComletedAPP();
                this.Close();
            }
            else
            {
                MessageBox.Show("License Issuing Failed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void textBoxNotes_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxNotes.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxNotes, "You Must Enter Notes");
            }  
            else
            {

                errorProvider1.SetError(textBoxNotes, null);    
            }
        }
    }
}
