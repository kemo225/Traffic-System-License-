using BussinessLayerDVLD;
using DVLDD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDD
{
    public partial class UserControlLicenseinfo : UserControl
    {
        private int LicenseID;
        private int LocalDrivingLicenseID;
        private ClsLicense License;
        public ClsLicense LicenseInfo
        {
            get { return License; }
        }
        public UserControlLicenseinfo()
        {
            InitializeComponent();
        }
        public void LoadData(int LicenseID)
        {
            this.LicenseID = LicenseID;
            License = ClsLicense.Find(LicenseID);
            lblLicenseID.Text = License.LicenseID.ToString();
           lblClass.Text = License.LicenseInfo.ClassName.ToString();
            lblIssueDate.Text = License.IssueDate.ToString("dd-MM-yyyy");
            lblNotes.Text = License.Notes;
            lblDriverID.Text = License.DriverID.ToString();
            lblIssueReason.Text = License.IssueReason.ToString();
            switch ((ClsLicense.enIssueLicenseReason)License.IssueReason) 
            { 
                case ClsLicense.enIssueLicenseReason.New:
                    lblIssueReason.Text = "New";
                    break;
                case ClsLicense.enIssueLicenseReason.Renewal:
                    lblIssueReason.Text = "Renewal";
                    break;
                case ClsLicense.enIssueLicenseReason.Lost:
                    lblIssueReason.Text = "Lost";
                    break;
                case ClsLicense.enIssueLicenseReason.Detained:
                    lblIssueReason.Text = "Detained";
                    break;
                case ClsLicense.enIssueLicenseReason.Damaged:
                    lblIssueReason.Text = "Damaged";
                    break;

            }
            lblIsActive.Text =( License.IsActive) ? "Yes" : "NO";
            lblFullName.Text=License.DriverInfo.fullname;
            lblNationalNo.Text = License.DriverInfo.NationalNO;
            if (License.DriverInfo.gender == (int)clspeople.enGender.male)
                lblGendor.Text = "Male";
            else
                lblGendor.Text = "Female";

            lblDateOfBirth.Text = License.DriverInfo.DateofBirth.ToString("dd-MM-yyyy");
            lblIsDetained.Text = (License.IsDatain) ? "Yes":"NO" ;
            lblExpirationDate.Text = License.ExpiryDate.ToString("dd-MM-yyyy");
            lblIsDetained.Text=(License.IsDatain)?"Yes" : "NO";
            LoadiMAGE();    
        }   
        private void LoadiMAGE()
        {
            if(License.DriverInfo.imagePath =="")
            {
                if (License.DriverInfo.gender == (int)clspeople.enGender.male)
                    pbPersonImage.Image = Resource2.Male_512;
                else
                    pbPersonImage.Image = Resource2.Female_512;

            }else
            {
                if(File.Exists(License.DriverInfo.imagePath))
                    pbPersonImage.ImageLocation = License.DriverInfo.imagePath;
                else
                    MessageBox.Show("Image not found in Device");
            }


        }   
      
        private void UserControl7_Load(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
