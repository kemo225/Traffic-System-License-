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
    public partial class Form19 : Form
    {

        public ClsTestAppoinment.enTestType TestTypeID = ClsTestAppoinment.enTestType.VisionTest;   
        private ClsLocalDrivingLicense Locallicense;
        private int LocalLicenseDrivingID = -1;
        private ClsTestAppoinment TestAppoinment;
        private int TestAppointmentID = -1;
        public Form19(int LocalLicenseDrivingID, ClsTestAppoinment.enTestType testtypeID,int AppointmentID=-1)
        {
            InitializeComponent();
            this.LocalLicenseDrivingID = LocalLicenseDrivingID;
            this.TestAppointmentID = AppointmentID;
            this.TestTypeID = testtypeID;
        }
   

        private void sheduletest1_Load(object sender, EventArgs e)
        {
   
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            sheduletest1.LoadData(LocalLicenseDrivingID, TestTypeID, TestAppointmentID);    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }
    }
}
