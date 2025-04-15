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
    public partial class usercontrolApplicatiioninfo : UserControl
    {
        private enum enStatus { New=1,canceled=2,Completed=3}
       
        private ClsLocalDrivingLicense app;
        public usercontrolApplicatiioninfo()
        {
            InitializeComponent();
        }
        public int ApplicationID
            { get { return app.ApplicationID; } }   
        private void groupBoxApplicaionInfo_Enter(object sender, EventArgs e)
        {

        }
        public void LoadData(int LocalDrivingLicenseApp)
        {
             app = ClsLocalDrivingLicense.Find(LocalDrivingLicenseApp);
            if (app != null)
            {
                lblID.Text=app.ApplicationID.ToString();    
                labelsetname.Text=ClsApplicationType.Find(app.ApplicationTypeID).Applicationtittle;
                labeldatestart.Text=app.ApplicationDate.ToString();
                labelsetdateend.Text=app.Laststatusdate.ToString();
                labelstatus.Text=app.Applicationstatus.ToString();
                switch((enStatus)app.Applicationstatus)
                {
                    case enStatus.New:
                        labelstatus.Text = "New";
                        break;
                    case enStatus.canceled:
                        labelstatus.Text = "Canceled";
                        break;
                    case enStatus.Completed:
                        labelstatus.Text = "Completed";
                        break;
                }
                labelsetusername.Text=ClsUser.Find(app.CreatedByUserId).UserName.ToString();   
                labelsetfees.Text=app.PaidFees.ToString();  
                labelIDD.Text=app.LocalDrivinglicenseID.ToString();  
                labelpassedtest.Text=app.passedTest.ToString();
                labelclsname.Text = app.LicenseInfo.ClassName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPersonCard frm =new FormPersonCard(app.ApplicationPersonID);
            frm.ShowDialog();   
        }

        private void usercontrolApplicatiioninfo_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClsLicense license=ClsLicense.FindByApplicationID(app.ApplicationID);  
            if (app.Applicationstatus == Convert.ToInt32(enStatus.Completed)&&license!=null)
            {
                formLicenseInfo frm = new formLicenseInfo(license.LicenseID);
                frm.ShowDialog();
            }
           
        }
    }
}
