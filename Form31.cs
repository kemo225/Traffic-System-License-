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
  
    public partial class FormInterNational : Form
    {
        private ClsInterNationalLicense _InternationalLicense;
        private ClsApplication applicationLicenseinternational;
        private int LicenseID;
        private ClsLicense License;
        public FormInterNational()
        {
            InitializeComponent();

        }
        private void FillBasicData()
        {
            lblLicenseID.Text=License.LicenseID.ToString(); 
            lblCreatedByUser.Text=ClsGlobal.CurrentUser.UserName;
            labelissuedate.Text=DateTime.Now.ToString("dd-MM-yyyy");    
            labelexpirationdate.Text=DateTime.Now.AddYears(1).ToString("dd-MM-yyyy");
            labelfees.Text = ClsApplicationType.Find(Convert.ToInt32(ClsApplicationType.enApplicationType.InternationalLicenseReplacement)).ApplicationFees.ToString();
        }
        private void userCntrlInfoWithFilter1_OnLicenseSelected(int obj)
        {
            this.LicenseID = obj;
            License = ClsLicense.Find(LicenseID);

           if(License.IsDatain)
            {
                MessageBox.Show("License Is Detain");
                return;
            }
            else if (!License.IsActive)
            {
                MessageBox.Show("License Is Not Active");return;
              
            }

            ClsInterNationalLicense InterNationalLicense = ClsInterNationalLicense.FindByLicenseID(LicenseID);
            if (InterNationalLicense != null)
            {
                if (InterNationalLicense.IsActive)
                {
                    MessageBox.Show($"License Has InterNational License And Is Already Active and ID = {InterNationalLicense.InternationalLicenseID}");
                    return;
                }
                else
                 if (MessageBox.Show("License Has InterNational License But Is Not Active,Do You Want Renewel It ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    this.Close();
            }
            llShowLicenseHistory.Enabled = true;
            btnIssueLicense.Enabled= true;
            FillBasicData();


        }

        private void FormInterNational_Load(object sender, EventArgs e)
        {

        }
        private void CreationApp()
        {
            applicationLicenseinternational = new ClsApplication();
            applicationLicenseinternational.ApplicationPersonID = License.DriverInfo.PeopleID;
            applicationLicenseinternational.ApplicationDate = DateTime.Now;
            applicationLicenseinternational.Applicationstatus = Convert.ToInt32(ClsApplication.enApplicationStatus.Completed);
            applicationLicenseinternational.CreatedByUserId=ClsGlobal.CurrentUser.UserID;
            applicationLicenseinternational.ApplicationTypeID = ClsApplicationType.Find(Convert.ToInt32(ClsApplication.enApplicationType.InternationalLicenseReplacement)).ApplicationTypeID;
            applicationLicenseinternational.PaidFees = ClsApplicationType.Find(Convert.ToInt32(ClsApplication.enApplicationType.InternationalLicenseReplacement)).ApplicationFees;
            if(!applicationLicenseinternational.Save())
            {
                MessageBox.Show("Application Creation Failed"); return; 
            }
        }
        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            CreationApp();
            labelappid.Text = applicationLicenseinternational.ApplicationID.ToString();
            _InternationalLicense = new ClsInterNationalLicense();
            _InternationalLicense.ApplicationID = applicationLicenseinternational.ApplicationID;
            _InternationalLicense.IssueDate= DateTime.Now;  
            _InternationalLicense.ExpiryDate = DateTime.Now.AddYears(1);
            _InternationalLicense.CreatedByUserID =ClsGlobal.CurrentUser.UserID;
            _InternationalLicense.DriverID = License.DriverID;
            _InternationalLicense.IssuedUsingLocalLicenseID=License.LicenseID;
            _InternationalLicense.IsActive = true;
            if (_InternationalLicense.Save())
            {
                MessageBox.Show($"Successfuly Issued License And The Id ={_InternationalLicense.InternationalLicenseID}");
            }
            labelID.Text=_InternationalLicense.InternationalLicenseID.ToString();        

        } 
    }
}
