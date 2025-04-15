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
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }
     

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || maskedTextBox1.Text == "")
            {
                labelerror.Visible = true;
            }
            else
            {
                ClsGlobal.CurrentUser = ClsUser.FindByUserNameAndPass(textBoxUsername.Text, maskedTextBox1.Text);
                if (ClsGlobal.CurrentUser == null)
                {
                    labelerror.Visible = true;
                    textBoxUsername.Text = "";
                    maskedTextBox1.Text = "";
                    textBoxUsername.Focus();    
                }
                else if (!ClsGlobal.CurrentUser.IsActice)
                {
                    label5erroractive.Visible = true;   
                    textBoxUsername.Text = "";
                    maskedTextBox1.Text = "";
                    textBoxUsername.Focus();
                }
                else
                {                
                    this.Hide();
                    textBoxUsername.Text = "";
                    maskedTextBox1.Text = "";
                    labelerror.Visible = false;
                    label5erroractive.Visible = false;
                    textBoxUsername.Focus();
                    FormMainScreen frm = new FormMainScreen(this);
                    frm.ShowDialog();
               

                }
            }
        }

        private void Formlogin_Load(object sender, EventArgs e)
        {
          
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
