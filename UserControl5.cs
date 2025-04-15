using BussinessLayerDVLD;
using DVLDD.Properties;
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
    public partial class Sheduletest : UserControl
    {
        public Control DateTimePicker
        {
            get { return dateTimePicker1; }
        }
        private static ClsTestAppoinment.enTestType _TestTypeID = ClsTestAppoinment.enTestType.VisionTest;  

        private ClsLocalDrivingLicense _LocalDrivingLicenseApplication;
        private int _LocalDrivingLicenseApplicationID=-1;

        private ClsTestAppoinment _TestAppoinment;
        private int _TestAppointmentID = -1;
        
        private enum enMode { Update = 1, Add = 2 }
        private enMode _Mode = enMode.Add;  

        private enum enCreationMode { FirstTimeSchedule = 1, RetakeTestSchedule = 2 }
        private enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;    

        public void LoadData(int LocalDrivingLicenseApplicationID, ClsTestAppoinment.enTestType TestTypeID, int AppointmentID=-1)
        {
         

            this.TestTypeID = TestTypeID;

            if (AppointmentID == -1)
              { _Mode = enMode.Add; }
            else
             { _Mode = enMode.Update; }


            _TestAppointmentID = AppointmentID;
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplication = ClsLocalDrivingLicense.Find(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenseApplicationID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //btnSave.Enabled = false;
                return;
            }

            //decide if the createion mode is retake test or not based if the person attended this test before
            if (_LocalDrivingLicenseApplication.DoesAttendTestType((int)_TestTypeID))
                _CreationMode = enCreationMode.RetakeTestSchedule;
            else
                _CreationMode = enCreationMode.FirstTimeSchedule;

    //////////////////
            lblLocalDrivingLicenseAppID.Text = _LocalDrivingLicenseApplication.LocalDrivinglicenseID.ToString();
            lblDrivingClass.Text = _LocalDrivingLicenseApplication.LicenseInfo.ClassName;
            lblFullName.Text = _LocalDrivingLicenseApplication.personinfo.fullname;

            //this will show the trials for this test before
            lblTrial.Text = _LocalDrivingLicenseApplication.TotalTrialsPerTest((int)_TestTypeID).ToString();

            if (_CreationMode == enCreationMode.RetakeTestSchedule)
            {
       
                groupBox1.Enabled = true;
                lblTitle.Text = "Schedule Retake Test";
                lblRetakeAppFees.Text = ClsApplicationType.Find((int)ClsApplication.enApplicationType.Retaketest).ApplicationFees.ToString();

            }
            else
            {
                groupBox1.Enabled = false;
                lblTitle.Text = "Schedule Test";
                lblRetakeAppFees.Text = "0";
                LblretakeID.Text = "N/A";
            }
            //
         


            if (_Mode == enMode.Add)
            {
                lblFees.Text = ClsTestTypes.Find((int)_TestTypeID).TestTypefees.ToString();
                dateTimePicker1.MinDate = DateTime.Now;
                LblretakeID.Text = "N/A";

                _TestAppoinment = new ClsTestAppoinment();
            }
            else
            {

                if (!_LoadTestAppointmentData())
                    return;
            }


            lblTotalFees.Text = (Convert.ToInt32(lblFees.Text) + Convert.ToInt32(lblRetakeAppFees.Text)).ToString();

            if (!_HandleActiveTestAppointmentConstraint())
                return;

            if (!_HandleAppointmentLockedConstraint())
                return;

         

        }
        public Control Retaketest
        {
            get { return groupBox1; }
          
        }
        private bool _HandleAppointmentLockedConstraint()
        {
            //if appointment is locked that means the person already sat for this test
            //we cannot update locked appointment
            if (_TestAppoinment.Isloced&&_Mode==enMode.Update)
            {
                labeluser.Visible = true;
                labeluser.Text = "This appointment is locked, you cannot update it";
                dateTimePicker1.Enabled = false;
                button1.Enabled = false;
                return false;

            }
          

            return true;
        }
        private bool _HandleActiveTestAppointmentConstraint()
        {
            if (_Mode == enMode.Add && ClsLocalDrivingLicense.IsThereAnActiveScheduledTest(_LocalDrivingLicenseApplicationID, _TestTypeID))
            {
                labeluser.Visible = true;   
                labeluser.Text= "There is an active test appointment for this person";
                button1.Enabled = false;
                dateTimePicker1.Enabled = false;
                return false;
            }

            return true;
        }
   
        private bool _HandleRetakeApplication()
        {
            //this will decide to create a seperate application for retake test or not.
            // and will create it if needed , then it will linkit to the appoinment.
            if (_Mode == enMode.Add && _CreationMode == enCreationMode.RetakeTestSchedule)
            {
                //incase the mode is add new and creation mode is retake test we should create a seperate application for it.
                //then we linke it with the appointment.

                //First Create Applicaiton 
                ClsApplication Application = new ClsApplication();

                Application.ApplicationPersonID = _LocalDrivingLicenseApplication.ApplicationPersonID;
                Application.ApplicationDate = DateTime.Now;
                Application.ApplicationTypeID = (int)ClsApplication.enApplicationType.Retaketest;
   
                Application.Laststatusdate = DateTime.Now;
                Application.PaidFees = ClsApplicationType.Find((int)ClsApplication.enApplicationType.Retaketest).ApplicationFees;
                Application.CreatedByUserId = ClsGlobal.CurrentUser.UserID;

                if (!Application.Save())
                {
                    _TestAppoinment.RetakeTestAppointmentID = -1;
                    MessageBox.Show("Faild to Create application", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _TestAppoinment.RetakeTestAppointmentID = Application.ApplicationID;
                LblretakeID.Text = _TestAppoinment.RetakeTestAppointmentID.ToString();

            }
            return true;
        }
        private bool HandleLocedAppointment()
        {
            
            if (_TestAppoinment.Isloced == true)
            {
                button1.Enabled = false;    
                dateTimePicker1.Enabled = false;
                MessageBox.Show("Error: Test Become Loced You Can Change it " ,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        private bool _LoadTestAppointmentData()
        {
            _TestAppoinment = ClsTestAppoinment.Find(_TestAppointmentID);

            if (_TestAppoinment == null)
            {
                MessageBox.Show("Error: No Appointment with ID = " + _TestAppointmentID.ToString(),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //btnSave.Enabled = false;
                return false;
            }

            lblFees.Text = _TestAppoinment.PaidFees.ToString();

            //we compare the current date with the appointment date to set the min date.
            if (DateTime.Compare(DateTime.Now, _TestAppoinment.AppointmentDate) < 0)
                dateTimePicker1.MinDate = DateTime.Now;
            else
                dateTimePicker1.MinDate = _TestAppoinment.AppointmentDate;

            dateTimePicker1.Text = Convert.ToString(_TestAppoinment.AppointmentDate);

            if (_TestAppoinment.RetakeTestAppointmentID == -1)
            {
                lblRetakeAppFees.Text = "0";
                LblretakeID.Text = "N/A";
            }
            else
            {
                groupBox1.Enabled = true;
                lblRetakeAppFees.Text = _TestAppoinment.RetakeTestAppointmentAppInfo.PaidFees.ToString();
                lblTitle.Text = "Schedule Retake Test";
                LblretakeID.Text = _TestAppoinment.RetakeTestAppointmentID.ToString();

            }
            return true;
        }
        public Sheduletest()
        {
            InitializeComponent();
        }
      
        public ClsTestAppoinment.enTestType TestTypeID 
        {
            get {  return _TestTypeID; }  

            set {
                _TestTypeID = value;
                switch (_TestTypeID)
                {
                    case ClsTestAppoinment.enTestType.VisionTest:
                        lblTitle.Text = "Vision Test";
                        pbTestTypeImage.Image = Resource2.Vision_512;
                        break;
                    case ClsTestAppoinment.enTestType.WrittenTest:
                        lblTitle.Text = "Written Test";
                        pbTestTypeImage.Image = Resource2.Written_Test_512;
                        break;
                    case ClsTestAppoinment.enTestType.DrivingTest:
                        lblTitle.Text = "Driving Test";
                        pbTestTypeImage.Image = Resource2.driving_test_512;
                        break;
                }
            
            } }    
        private void gbTestType_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!_HandleRetakeApplication())
                return;
            _TestAppoinment.LocalDriverLicenseID = _LocalDrivingLicenseApplicationID;
            _TestAppoinment.TestTypeID = (int)_TestTypeID;
            _TestAppoinment.AppointmentDate = Convert.ToDateTime(dateTimePicker1.Text);
            _TestAppoinment.PaidFees = Convert.ToInt32(lblFees.Text);
            _TestAppoinment.CreatedByUserId=ClsGlobal.CurrentUser.UserID;
         
            if(_TestAppoinment.Save())
            {
                MessageBox.Show("Test Scheduled is determined Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //btnSave.Enabled = false;

                _Mode= enMode.Update;   

            }
            else
            {
                MessageBox.Show("Error: Test Scheduling Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UserControl5_Load(object sender, EventArgs e)
        {

        }
    }
}
