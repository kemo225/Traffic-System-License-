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
    public partial class Formupdateapp : Form
    {
        private int ApplicationID
        {  get; set; }
        private ClsApplicationType applicationtype;
        public Formupdateapp(int ApplicationID)
        {
            InitializeComponent();
            this.ApplicationID = ApplicationID;
            applicationtype = ClsApplicationType.Find(ApplicationID);
        }
        private void LoadData()
        {
            labelID.Text = ApplicationID.ToString();
            textBoxTittle.Text = applicationtype.Applicationtittle;
            maskedTextBoxfees.Text = applicationtype.ApplicationFees.ToString();
        }
        private void Formupdateapp_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            applicationtype.ApplicationTypeID = Convert.ToInt32(labelID.Text);
            applicationtype.Applicationtittle = textBoxTittle.Text;
            applicationtype.ApplicationFees = Convert.ToInt32(maskedTextBoxfees.Text);
            if(applicationtype.Save())
            {
                MessageBox.Show("Saved Successfuly","Successfuly");
            }
            else
            {
                MessageBox.Show("Saved Failure","Error");
            }
            this.Close();

        }

        private void Formupdateapp_Validating(object sender, CancelEventArgs e)
        {
         
         
        }

        private void textBoxTittle_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxTittle.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxTittle, "You Must Enter Application Tittle");
            }
            else
            {
                errorProvider1.SetError(textBoxTittle, null);
            }

        }

        private void maskedTextBoxfees_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBoxfees.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(maskedTextBoxfees, "You Must Enter Application Fees");
            }
            else
            {
                errorProvider1.SetError(maskedTextBoxfees, null);
            }
        }
    }
}
