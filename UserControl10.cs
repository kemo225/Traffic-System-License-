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
    public partial class Usercntlhistoretlicense : UserControl
    {

        public int DriverID = -1;
        private ClsDriver Driver;
        private DataTable DtLocalLicenses;
        private DataTable DtinterLicenses;
        public Usercntlhistoretlicense()
        {
            InitializeComponent();
        }
        public void LoadInfoByPersonId(int PersonId)
        {
            Driver = ClsDriver.FindByPersonID(PersonId);
            if (Driver == null)
            {
                MessageBox.Show("Driver Not Found");
                return;
            }

            this.DriverID = DriverID;
            Driver = ClsDriver.Find(DriverID);

            LoadLocalLicense();
            //LoadInterLicense();
        }
        public void LoadInfo(int DriverID)
        {
            if (DriverID == -1)
                return;
            this.DriverID = DriverID;
            Driver = ClsDriver.Find(DriverID);

            LoadLocalLicense();
            LoadInterLicense();
        }
        private void LoadLocalLicense()
        {

            DtLocalLicenses = Driver.GetLocalLicenses();
            dataGridViewlocalllicense.DataSource = DtLocalLicenses;
            if (dataGridViewlocalllicense.Rows.Count > 0)
            {

                dataGridViewlocalllicense.Columns[0].HeaderText = "License ID";
                dataGridViewlocalllicense.Columns[0].Width = 60;
                dataGridViewlocalllicense.Columns[1].HeaderText = "App ID";
                dataGridViewlocalllicense.Columns[1].Width = 60;
                dataGridViewlocalllicense.Columns[2].HeaderText = "Class Name";
                dataGridViewlocalllicense.Columns[2].Width = 180;
                dataGridViewlocalllicense.Columns[3].HeaderText = "Issue Date";
                dataGridViewlocalllicense.Columns[3].Width = 135;
                dataGridViewlocalllicense.Columns[4].HeaderText = "Expiration Date";
                dataGridViewlocalllicense.Columns[4].Width = 135;
                dataGridViewlocalllicense.Columns[5].HeaderText = "Is Active";
                dataGridViewlocalllicense.Columns[5].Width = 85;

                labellocallicense.Text = dataGridViewlocalllicense.Rows.Count.ToString();

            }

        }
        private void LoadInterLicense()
        {

            DtinterLicenses = Driver.GetInterLicenses();
         
            datgridinterlicense.DataSource = DtinterLicenses;
            if (datgridinterlicense.Rows.Count > 0)
            {

                datgridinterlicense.Columns[0].HeaderText = "Int License ID";
                datgridinterlicense.Columns[0].Width = 80;
                datgridinterlicense.Columns[1].HeaderText = "App ID";
                datgridinterlicense.Columns[1].Width = 80;
                datgridinterlicense.Columns[2].HeaderText = "Driver ID";
                datgridinterlicense.Columns[2].Width = 80;
                datgridinterlicense.Columns[3].HeaderText = "L License ID";
                datgridinterlicense.Columns[3].Width = 100;
                datgridinterlicense.Columns[4].HeaderText = "Issue Date";
                datgridinterlicense.Columns[4].Width = 140;
                datgridinterlicense.Columns[5].HeaderText = "Expiration Date";
                datgridinterlicense.Columns[5].Width = 140;
                datgridinterlicense.Columns[6].HeaderText = "Is Active";
                datgridinterlicense.Columns[6].Width = 100;
                datgridinterlicense.Columns[7].HeaderText = "Created By";
                datgridinterlicense.Columns[7].Width = 90;

                labelinterlicense.Text = datgridinterlicense.Rows.Count.ToString();

            }


        }
        private void UserControl10_Load(object sender, EventArgs e)
        {
           labelinterlicense.Text = "0";
            labellocallicense.Text = "0";
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {


        }
    }
}
