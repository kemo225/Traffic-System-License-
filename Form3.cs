using BussinessLayerDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLDD
{
  
    public partial class FormPeopleInformation : Form
    {
       private static DataTable MainDT = clspeople.GetAllpeople();
      private DataTable SubsetDT = MainDT.DefaultView.ToTable(false, "PersonID", "NationalNO", "FirstName", "secondName", "ThirdName", "LastName", "GendorCaption", "email", "phone", "Address", "DateofBirth", "Nationality");
        private int CountPeople;

        public FormPeopleInformation()
        {
            InitializeComponent();
         
           

        }
        private void RefreshData()
        {
            MainDT = clspeople.GetAllpeople();
       SubsetDT = MainDT.DefaultView.ToTable(false, "PersonID", "NationalNO", "FirstName", "secondName", "ThirdName", "LastName", "GendorCaption", "email", "phone", "Address", "DateofBirth", "Nationality");
            CountPeople=MainDT.Rows.Count;

        dataGridView1.DataSource = SubsetDT;

        }   
        private void FormPeopleInformation_Load(object sender, EventArgs e)
        {
            RefreshData();
            labelnumberpeople.Text = dataGridView1.Rows.Count.ToString();

            if (dataGridView1.Rows.Count > 0)
            {

                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[0].Width = 80;
                dataGridView1.Columns[1].HeaderText = "National NO";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].HeaderText = "First Name";
                dataGridView1.Columns[2].Width = 110;
                dataGridView1.Columns[3].HeaderText = "Second Name";
                dataGridView1.Columns[3].Width = 110;
                dataGridView1.Columns[4].HeaderText = "Third Name";
                dataGridView1.Columns[4].Width = 110;
                dataGridView1.Columns[5].HeaderText = "Last Name";
                dataGridView1.Columns[5].Width = 110;
                dataGridView1.Columns[6].HeaderText = "Gender";
                dataGridView1.Columns[6].Width = 70;
                dataGridView1.Columns[7].HeaderText = "Email";
                dataGridView1.Columns[7].Width = 120;
                dataGridView1.Columns[8].HeaderText = "Phone";
                dataGridView1.Columns[8].Width = 110;
                dataGridView1.Columns[9].HeaderText = "Address";
                dataGridView1.Columns[9].Width = 110;
                dataGridView1.Columns[10].HeaderText = "Date of Birth";
                dataGridView1.Columns[10].Width = 150;
                dataGridView1.Columns[11].HeaderText = "Nationality";
                dataGridView1.Columns[11].Width = 110;

            }
            labelnumberpeople.Text = CountPeople.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

                string filterColumn = "";
                switch (comboBox1.Text)
                {

                    case "Person ID":
                        filterColumn = "PersonID";
                        break;
                    case "National No":
                        filterColumn = "NationalNO";
                        break;
                    case "First Name":
                        filterColumn = "FirstName";
                        break;
                    case "Second Name":
                        filterColumn = "secondName";
                        break;
                    case "Third Name":
                        filterColumn = "ThirdName";
                        break;
                    case "Last Name":
                        filterColumn = "LastName";
                        break;
                    case "Address":
                        filterColumn = "Address";
                        break;
                    case "Nationality":
                        filterColumn = "Nationality";
                        break;
                    case "Email":
                        filterColumn = "email";
                        break;
                    case "Date Of Birth":
                        filterColumn = "DateofBirth";
                        break;
                    case "Gender":
                        filterColumn = "GendorCaption";
                        break;
                        default:
                        filterColumn = "None";
                        break;
                }
              if(textBox1.Text.Trim()==""||filterColumn=="None")
            {
        RefreshData();  
                labelnumberpeople.Text = "0";
                return;
            }
               if(filterColumn == "PersonID")
            { SubsetDT.DefaultView.RowFilter =  string.Format("[{0}]={1}",filterColumn,textBox1.Text) ; }
               else
            { SubsetDT.DefaultView.RowFilter = string.Format("[{0}] like '{1}%' ", filterColumn, textBox1.Text); }
            labelnumberpeople.Text = dataGridView1.Rows.Count.ToString();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddEditPerson frm = new FormAddEditPerson(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            RefreshData();
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddEditPerson frm = new FormAddEditPerson(-1);
            frm.ShowDialog();
            RefreshData();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            FormAddEditPerson frm = new FormAddEditPerson(-1);
            frm.ShowDialog();
            RefreshData();
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this person?", "Delete Person", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            if(clspeople.DeletePerson(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Person Deleted Successfully", "Delete Person", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Person Not Deleted", "Delete Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   

            }

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersonCard frm = new FormPersonCard(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            frm.ShowDialog();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormPersonCard frm = new FormPersonCard(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddEditPerson frm = new FormAddEditPerson(-1);
            frm.ShowDialog();
        }

        private void labelnumberpeople_Click(object sender, EventArgs e)
        {

        }
    }
}
