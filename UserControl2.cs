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
    public partial class UserCard : UserControl
    {
        private int _UserID;
        private ClsUser _user; 
        
        public ClsUser User
            { get { return _user; }
            set {  _user = value; } 
                }
        public int UserID
        {
            get { return _UserID; }
            set { _UserID = Convert.ToInt32(value); }
        }

        public UserCard()
        {
            InitializeComponent();
        }
        private void LoadUserinfo()
        {
            ClsUser User = ClsUser.Find(UserID);
            labelsetUsername.Text = User.UserName;
            checkBoxisactive.Checked = User.IsActice;
        }
        public void LoadData(int UserID)
        {
            this.UserID = UserID;
            personInfo1.LoadData(ClsUser.Find(UserID).PeopleID);
           LoadUserinfo();  
        }
        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void personInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
