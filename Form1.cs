using System;
using System.Resources;
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
      
    public partial class FormMainScreen : Form
    {
        private Form frmlogin;

        public FormMainScreen(Form login)
        {
            InitializeComponent();
            this.frmlogin = login;

        }
       
        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItemAccountSetting_Click(object sender, EventArgs e)
        {
         
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserInfromation frm = new FormUserInfromation(ClsGlobal.CurrentUser.UserID);
            frm.ShowDialog();

        }
        private void FormMainScreen_Load(object sender, EventArgs e)
        {
         
        }
        private void toolStripMenuItemPeople_Click(object sender, EventArgs e)
        {
            FormPeopleInformation form = new FormPeopleInformation();
            form.ShowDialog();
        }

        private void toolStripMenuItemUsers_Click(object sender, EventArgs e)
        {
            FormUsers frm= new FormUsers(); 
            frm.ShowDialog();
          
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formchangepass frm = new Formchangepass();
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            ClsGlobal.CurrentUser= null;
            this.Close(); 
          
            frmlogin.Show();
          

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 frm= new Form11();   
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 frm= new Form13(-1);
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMgTestType frm= new FormMgTestType();   
            frm.ShowDialog();       
        }

        private void localDrivingApplicatioLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocalDrivingApp frm= new FormLocalDrivingApp(); 
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocalDrivingApp frm = new FormLocalDrivingApp();
            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRenewLicense frm = new FormRenewLicense();
            frm.ShowDialog();       
        }

        private void replacementForLostOrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLostLicense frm = new FormLostLicense();
            frm.ShowDialog();
        }

        private void toolStripMenuItem3AccountLicesnse_Click(object sender, EventArgs e)
        {
            FormDrivers frm = new FormDrivers();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDetain frm= new FormDetain();   
            frm.ShowDialog();
        }

        private void retakeDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReleaseDetainLicense frm= new FormReleaseDetainLicense();       
            frm.ShowDialog();   
        }

        private void manageDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDetainList frm= new FormDetainList();   
            frm.ShowDialog();   
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInterNational frm= new FormInterNational();
            frm.ShowDialog();
        }

        private void internationalApplicatioLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListInternational form = new FormListInternational();
            form.ShowDialog();
        }
    }
}
