using BussinessLayerDVLD;
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
    public partial class UserControlInternational : UserControl
    {
        public int internationalID {  get; set; }   
        public ClsInterNationalLicense InterNationalLicense    { get; set; }    
        public UserControlInternational()
        {
            InitializeComponent();
        }
        public void LoadData(int  internationalID)
        {
            this.internationalID= internationalID;
            InterNationalLicense=ClsInterNationalLicense.Find(internationalID);
            labelInternationalID.Text = InterNationalLicense.InternationalLicenseID.ToString();
            lblClass.Text = InterNationalLicense.LinkedLicenseLocalInfo.LicenseInfo.ClassName;
            lblFullName.Text=InterNationalLicense.DriverInfo.fullname;
            lblLicenseID.Text = InterNationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblNationalNo.Text = InterNationalLicense.DriverInfo.NationalNO;
            lblGendor.Text = InterNationalLicense.DriverInfo.gender == Convert.ToInt32(clspeople.enGender.male) ? "Male" : "Female";
            lblIssueDate.Text = InterNationalLicense.IssueDate.ToString("dd-mm-yyyy");
            lblDriverID.Text = InterNationalLicense.DriverID.ToString();
            lblIsActive.Text = InterNationalLicense.IsActive ? "Yes" : "NO";
            lblDateOfBirth.Text=InterNationalLicense.DriverInfo.DateofBirth.ToString("dd-mm-yyyy");
            lblExpirationDate.Text=InterNationalLicense.ExpiryDate.ToString("dd-mm-yyyy");
            loadImage();
        }
        private void loadImage()
        {
            if(InterNationalLicense.DriverInfo.imagePath == null)
            {
if(InterNationalLicense.DriverInfo.gender==Convert.ToInt32(clspeople.enGender.male))
                    pbPersonImage.Image=Resource2.Male_512;
else
                    pbPersonImage.Image = Resource2.Female_512;
            }
            if(File.Exists(InterNationalLicense.DriverInfo.imagePath))
            {
                pbPersonImage.ImageLocation = InterNationalLicense.DriverInfo.imagePath;
            }
        }
        private void UserControl11_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
