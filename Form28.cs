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
    public partial class FormDetain : Form
    {
        private ClsDetainLicense detainlicense;
        private int LicenseID;
        private ClsLicense License;
        public FormDetain()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
           if(maskedTextBox1.Text=="")
            {
                errorProvider1.SetError(maskedTextBox1, "You Have to Put Fine");
                e.Cancel = true;
            }
           else
                e.Cancel = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHistoreyLicense frm = new FormHistoreyLicense(License.DriverID);
            frm.ShowDialog();
        }
        private void fillbasicdata()
        {
            lblCreatedByUser.Text=License.CreatedByUserInfo.UserName;
            lblLicenseID.Text = License.LicenseID.ToString();
            labeldetaindate.Text=DateTime.Now.ToString();   

        }
        private void DetainLicense()
        {
             detainlicense=new ClsDetainLicense();
            detainlicense.FineFees = Convert.ToInt32(maskedTextBox1.Text);
            detainlicense.LicenseID = LicenseID;
            detainlicense.DetainDate = DateTime.Now;
            detainlicense.CreatedByUserId = ClsGlobal.CurrentUser.UserID;
            detainlicense.IsReleased = false;
            if (detainlicense.Save())
            {
                MessageBox.Show($"License Detain Successfult", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDetainLicense.Enabled= false;    
            }
            else
            {
                MessageBox.Show($"Faild In Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void userCntrlInfoWithFilter1_OnLicenseSelected(int obj)
        {
            this.LicenseID= obj;    
            License=ClsLicense.Find(this.LicenseID);

            if (License != null)
            {
                if(License.IsDatain)
                {
                  if(MessageBox.Show($"License Already Detain By Name {License.CreatedByUserInfo.UserName} , Do You Want Put Another Fine ? ","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error)==DialogResult.Cancel)
                    return;
                }
            }

            fillbasicdata();
            maskedTextBox1.Text = "";
            maskedTextBox1.Focus();
            btnDetainLicense.Enabled = true;
            llShowLicenseHistory.Enabled = true;
        }
        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            DetainLicense();
        }

        private void FormDetain_Load(object sender, EventArgs e)
        {

        }
    }
}
