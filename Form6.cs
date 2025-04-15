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
    public partial class FormUserInfromation : Form
    {
        private int _UserID;
        public FormUserInfromation(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            userCard1.LoadData(_UserID);
        }

        private void userCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
