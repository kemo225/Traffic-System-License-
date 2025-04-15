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
    public partial class Forminternationalinfo : Form
    {
        private int InternationalId;
        private ClsInterNationalLicense InterNationalLicense;
        public Forminternationalinfo(int InterNationalID)
        {
            InitializeComponent();
            this.InternationalId = InterNationalID;
            this.InterNationalLicense=ClsInterNationalLicense.Find(InterNationalID);    
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Forminternationalinfo_Load(object sender, EventArgs e)
        {
            userControlInternational1.LoadData(this.InternationalId);     
        }
    }
}
