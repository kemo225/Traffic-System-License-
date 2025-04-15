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
    public partial class Form13 : Form
    {
        private int ApplicationLicenselocalID;
        private enum enMode{ update = 1, add = 2 }
        private enMode mode;
        private bool Converttopage2;
        private ClsLocalDrivingLicense _localDrivingLicense;
        public Form13(int ApplicationLicenselocalID)
        {
            InitializeComponent();
            this.ApplicationLicenselocalID = ApplicationLicenselocalID;
            if (ApplicationLicenselocalID == -1)
            {
                this.mode = enMode.add;
            }
            else
            {
                this.mode = enMode.update;
            }
        }
        private void LoadData()
        {
            _localDrivingLicense=ClsLocalDrivingLicense.Find(ApplicationLicenselocalID);
            userControlpersonwuthfilter1.LoadData(_localDrivingLicense.personinfo.PeopleID);
            labelfees.Text = _localDrivingLicense.PaidFees.ToString();
            comboBox1.Text=_localDrivingLicense.LicenseInfo.ClassName;
            labelappid.Text = _localDrivingLicense.LocalDrivinglicenseID.ToString() ;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void labelappid_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelfees.Text=(ClsLicenseClass.FindByName(comboBox1.Text).ClassFees+ClsApplicationType.Find(1).ApplicationFees).ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxisactif_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            FillComboBox();
            if (mode == enMode.update)
            {
                LoadData();
                labelusername.Text = ClsUser.Find(_localDrivingLicense.CreatedByUserId).UserName;
                Converttopage2 = false;
                labelsetappdate.Text = DateTime.Now.ToString();
                label6.Text = "Update Local License App";
                comboBox1.Enabled = false;  
            }else
            {
                labelusername.Text = ClsGlobal.CurrentUser.UserName;
                Converttopage2 = true;
                labelsetappdate.Text = DateTime.Now.ToString();
                label6.Text = "New Local Driving License";
                _localDrivingLicense=new ClsLocalDrivingLicense();

            }
          
        }
        private void FillComboBox()
        {
            DataTable DT=ClsLicenseClass.GetAllclassLicense();
            foreach (DataRow row in DT.Rows)
            {
                comboBox1.Items.Add(row["ClassName"].ToString());
            }
        }
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (userControlpersonwuthfilter1.Person != null)
            {
                e.Cancel = false;
                return;
            }
            if (e.TabPage == tabPage2)
            {
                e.Cancel = Converttopage2;

            }
        }

        private void buttonnxt_Click(object sender, EventArgs e)
        {
            if (userControlpersonwuthfilter1.Person != null)
            {
                Converttopage2 = false;
                tabControl1.SelectedIndex = 1;
            }else
            {
                MessageBox.Show("Please Select a Person","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error); return;  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            _localDrivingLicense.PaidFees = ClsApplicationType.Find((int)ClsApplicationType.enApplicationType.LocalDrivingLicense).ApplicationFees;
            _localDrivingLicense.Laststatusdate = DateTime.Now;
            _localDrivingLicense.CreatedByUserId = ClsUser.FindByUserName(labelusername.Text).UserID;
            _localDrivingLicense.ClassLicenseID = ClsLicenseClass.FindByName(comboBox1.Text).LicenseClassId;
            _localDrivingLicense.ApplicationDate = DateTime.Now;
            _localDrivingLicense.ApplicationPersonID = userControlpersonwuthfilter1.PersonID;
            _localDrivingLicense.Applicationstatus = (int)ClsApplication.enApplicationStatus.New;

            if (mode == enMode.add)
            {
                if (clspeople.IsPersonhasClassLicense(userControlpersonwuthfilter1.PersonID, ClsLicenseClass.FindByName(comboBox1.Text).LicenseClassId))
                {
                    MessageBox.Show("The Person Has Already This Class License Or Apply NewApp For This Class License", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
                else
                {
                 
                    if (_localDrivingLicense.Save())
                    {
                        MessageBox.Show("The App has Applied Successfuly", "Okay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        labelappid.Text = _localDrivingLicense.LocalDrivinglicenseID.ToString();
                        
                    }
                    else
                    {
                        MessageBox.Show("Application Not Applied", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }
                }
            }
            else
            {
                if (_localDrivingLicense.Save())
                {
                    MessageBox.Show("The App Updated Successfuly", "Okay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelappid.Text = _localDrivingLicense.LocalDrivinglicenseID.ToString();
                }
                else
                {
                    MessageBox.Show("Application Not Success", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }

          

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if(comboBox1.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(comboBox1, "You Must Select Class Name");
            }   else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox1, null); 
            }
        }
    }
}
