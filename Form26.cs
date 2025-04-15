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
    public partial class FormHistoreyLicense : Form
    {
        private int DriverId;
        private ClsDriver Driver;
        public FormHistoreyLicense(int DriverID)
        {
            InitializeComponent();
            DriverId = DriverID;
            Driver=ClsDriver.Find(DriverID);    
        }

        private void Form26_Load(object sender, EventArgs e)
        {
            userControlpersonwuthfilter1.LoadData(Driver.PeopleID);
            usercntlhistoretlicense1.LoadInfo(DriverId);    
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usercntlhistoretlicense1_Load(object sender, EventArgs e)
        {

        }
    }
}
