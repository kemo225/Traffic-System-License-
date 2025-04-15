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
    public partial class Form20 : Form
    {
        int testappointmentid;
        int localDrivinglicenseid;
        ClsTestAppoinment testAppoinment;
        ClsLocalDrivingLicense localDrivingLicense;
        ClsTestAppoinment.enTestType testtypeID;
        Clstest Test;
        public Form20(int testappointmentid,int localDrivinglicenseid, ClsTestAppoinment.enTestType testtypeID)
        {
            InitializeComponent();
            this.testappointmentid = testappointmentid;
            this.localDrivinglicenseid = localDrivinglicenseid;
        this.testtypeID = testtypeID;
        }
        private void CheckLocked()
        {
            if (testAppoinment.Isloced == true)
            {
                groupBox1.Enabled = false;
                buttonsave.Enabled = false;
            }
        }
        private void Form20_Load(object sender, EventArgs e)
        {
            sheduletest1.DateTimePicker.Enabled = false;    
            sheduletest1.Retaketest.Visible = false;

            testAppoinment = ClsTestAppoinment.Find(testappointmentid);
            if(testAppoinment==null)
            {
                MessageBox.Show("Test Appointment not found");
                this.Close();
            }
            CheckLocked();
            localDrivingLicense = ClsLocalDrivingLicense.Find(localDrivinglicenseid);
            if(localDrivingLicense == null)
            {
                MessageBox.Show("Local Driving License not found");
                this.Close();
            }
            sheduletest1.LoadData(localDrivinglicenseid, testtypeID, testappointmentid);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            testAppoinment.Isloced = true;
            Test = new Clstest();
            if(radiosuccess.Checked)
            Test.TestResult = true;
            else
                Test.TestResult = false;
            Test.TestAppointmentID = testappointmentid;
            Test.Notes = textBox1.Text;      
            Test.CreatedByUserId=ClsGlobal.CurrentUser.UserID;  
            if(Test.Save()&&testAppoinment.Save())
            {
                MessageBox.Show("Successfuly Test Saved","Congratulation",MessageBoxButtons.OK,MessageBoxIcon.Information);


                this.Close();
            }
            else
            {
                MessageBox.Show("Failure Test not Saved","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }   

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(textBox1.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox1, "You Must Enter Notes");
                e.Cancel = true;
            }else
            {
                errorProvider1.SetError(textBox1, null);    
            }
        }

        private void radiosuccess_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
