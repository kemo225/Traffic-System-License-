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
    public partial class UserCntrlInfoWithFilter : UserControl
    {
       public event Action<int> OnLicenseSelected;  
        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(LicenseID);
            }
        }
    
        private int _LicenseID = -1;
        public ClsLicense License
        { get; set; }
        public int LicenseID
        {
            get { return _LicenseID; }
            set { _LicenseID = value; }
        }
        public UserCntrlInfoWithFilter()
        {
            InitializeComponent();
        }
        public void LoadData(int LicenseID)
        {
            userControlLicenseinfo1.LoadData(LicenseID);    
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(maskedTextBox1.Text != "")
            {
                License = ClsLicense.Find(Convert.ToInt32(maskedTextBox1.Text));
                if (License != null)
                {
                    LicenseID = License.LicenseID;  
             userControlLicenseinfo1.LoadData(LicenseID);  
                    if(OnLicenseSelected!=null)
                    {
                        LicenseSelected(this.LicenseID);
                    }   
                }
                else
                {
                    MessageBox.Show("License not found");
                }
            }
          
        }
        public Control ControlMasked
        {
            get { return maskedTextBox1; }
        }
        public Control Gbfilter
        {
            get { return groupBox1; }
        }
        private void UserCntrlInfoWithFilter_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Focus();
        }
    }
}
