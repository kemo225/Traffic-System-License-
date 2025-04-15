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
    public partial class Form17 : Form
    {
        private int Applicationloaclid;
        private ClsLocalDrivingLicense applocal;
        public Form17(int applicationLocalId)
        {
            InitializeComponent();
            this.Applicationloaclid= applicationLocalId;
            applocal = ClsLocalDrivingLicense.Find(applicationLocalId);
        }
     
        private void Form17_Load(object sender, EventArgs e)
        {
            usercontrolApplicatiioninfo1.LoadData(applocal.LocalDrivinglicenseID);
          
        }
    }
}
