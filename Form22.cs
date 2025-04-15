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
    public partial class formLicenseInfo : Form
    {
        private int LicenseID;
        private ClsLicense License;
        public formLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            this.LicenseID = LicenseID;
            License = ClsLicense.Find(LicenseID);
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LicenseInfo_Load(object sender, EventArgs e)
        {
            userControlLicenseinfo1.LoadData(LicenseID);
        }
    }
}
