using BussinessLayerDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDD
{
    public partial class Form16 : Form
    {
        private int TestTypeID;
        private ClsTestTypes testtype;
        public Form16(int TestTypeId)
        {
            InitializeComponent();
            this.TestTypeID = TestTypeId;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadData()
        {
            testtype = ClsTestTypes.Find(TestTypeID);
            if (testtype != null)
            {
                 
                labelID.Text = testtype.TestTypeID.ToString();
                labeltittle.Text = testtype.TestTittle;
                textBox1.Text = testtype.TestDecription;
                maskedTextBoxfees.Text = testtype.TestTypefees.ToString();
            }
        }
        private void Form16_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            testtype.TestDecription = textBox1.Text;    
            testtype.TestTypefees = Convert.ToInt32(maskedTextBoxfees.Text);
            if (testtype.Save())
            {
                MessageBox.Show("Saved Successfuly", "Successfuly");
            }
            else
            {
                MessageBox.Show("Saved Failure", "Error");
            }
            this.Close();

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox1, "You Must Fill the Description");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox1, null);

            }
        }
        private void maskedTextBoxfees_Validating(object sender, CancelEventArgs e)
        {
            if(maskedTextBoxfees.Text.Trim() == "")
            {
                errorProvider1.SetError(maskedTextBoxfees, "You Must Enter Fees");
                e.Cancel = true;
            }else
            {
                errorProvider1.SetError(maskedTextBoxfees, null);   
            }
        }
    }
}
