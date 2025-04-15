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
    public partial class UserControlpersonwuthfilter : UserControl
    {
        public UserControlpersonwuthfilter()
        {
            InitializeComponent();
        }
        public bool PersonSelected = false;
        public int PersonID
        { get { return personInfo1.PersonID; }
            set { personInfo1.PersonID = value; }
        }
        public clspeople Person
        { get { return personInfo1.Person; }
            set { personInfo1.Person = value; }
        }
        private void CheckValuesforButtonfindforpersonid()
        {
            if (maskedTextBox1.Text != "")
            {
                
                this.Person = clspeople.Find(Convert.ToInt32(maskedTextBox1.Text));
                if (Person != null)
                {
                    if (personInfo1.LoadData(Person.PeopleID))
                        {
                        PersonSelected = true;
                        return;
                    }
                        else
                    {
                        MessageBox.Show("Error in Loading");
                    }
                }
                else
                {
                    MessageBox.Show("PersonID Not Exist");

                }
            }
        }
        private void CheckValuesforButtonfindfornationalno()
        {
            if (maskedTextBox1.Text != "")
            {
                this.Person = clspeople.FindBYNationalNO(maskedTextBox1.Text);
                if (Person != null)
                {
                    if (personInfo1.LoadData(Person.NationalNO))
                        {
                        PersonSelected = true;

                        return;
                    }
                        else
                    {
                        MessageBox.Show("Error in Loading");
                    }
                }
                else
                {
                    MessageBox.Show("National NO Not Exist");

                }
            }
        }
        private void buttonfind_Click(object sender, EventArgs e)
        {
            if (comboBoxfilter.Text == "Person ID")
            {
                CheckValuesforButtonfindforpersonid();
            }
            else if (comboBoxfilter.Text == "National No")
            {
             

                CheckValuesforButtonfindfornationalno();    
            }
           
        }
        private void comboBoxfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxfilter.SelectedIndex == 0)
                maskedTextBox1.Mask = "999999999999999999999999999999999999999";

            else
                maskedTextBox1.Mask = "";
            maskedTextBox1.Enabled = true;
            maskedTextBox1.Focus();  

        }
        private void Imlementafterformaddeditperson(object sender, int personid)
        {
            PersonSelected = true;
            personInfo1.LoadData(personid);
        }
        private void buttonadd_Click(object sender, EventArgs e)
        {
            FormAddEditPerson form = new FormAddEditPerson(-1);
            form.databack += Imlementafterformaddeditperson;
            form.ShowDialog();  

        }
        private void UserControlpersonwuthfilter_Load(object sender, EventArgs e)
        {

        }
        public void LoadData(int personid)
        {
            PersonSelected = true;
          groupBoxfilter.Visible= false;  
            personInfo1.LoadData(personid);
        }
        public void LoadData(string NationalNO)
        {
            PersonSelected = true;
            groupBoxfilter.Visible = false;
            personInfo1.LoadData(NationalNO);
        }

        private void groupBoxfilter_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
