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
    public partial class Formchangepass : Form
    {
        public Formchangepass()
        {
            InitializeComponent();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            labelmatcchpass.Visible = false;
            if (maskedTextBoxoldpass.Text != "" || maskedTextBoxnewpass.Text != "" || maskedTextBoxconfirmnewpass.Text != "")
            {
                if (ClsGlobal.CurrentUser.Password == maskedTextBoxoldpass.Text)
                {
                    if (maskedTextBoxnewpass.Text == maskedTextBoxconfirmnewpass.Text)
                    {
                        ClsGlobal.CurrentUser.Password = maskedTextBoxnewpass.Text;
                        ClsGlobal.CurrentUser.Save();

                        MessageBox.Show("Successfuly Password Changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                    else
                    {
                        labelmatcchpass.Visible = true;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Password is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
            else
            {
                labelmatcchpass.Text = "Error : You Must Fill the Fields";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formchangepass_Load(object sender, EventArgs e)
        {
            userCard1.LoadData(ClsGlobal.CurrentUser.UserID);
        }

        private void userCard1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxoldpass_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBoxoldpass.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(maskedTextBoxoldpass, "You Must Enter Old Password");
            }
            else
            {
                errorProvider1.SetError(maskedTextBoxoldpass, null);
            }   

        }

        private void maskedTextBoxnewpass_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBoxnewpass.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(maskedTextBoxnewpass, "You Must Enter Old Password");
            }
            else
            {
                errorProvider1.SetError(maskedTextBoxnewpass, null);
            }

        }

        private void maskedTextBoxconfirmnewpass_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBoxconfirmnewpass.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(maskedTextBoxconfirmnewpass, "You Must Enter Old Password");
            }
            else
            {
                errorProvider1.SetError(maskedTextBoxconfirmnewpass, null);
            }
        }
    }
}
