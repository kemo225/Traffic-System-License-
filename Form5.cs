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
    public partial class FormUsers : Form
    {
        private int CountUser;
        private static DataTable DTMain=ClsUser.GetAllUsers();
        public FormUsers()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            DTMain = ClsUser.GetAllUsers();
            dataGridView1.DataSource = DTMain;  

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "User ID";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].HeaderText = "Person ID";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Full Name";
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[3].HeaderText = "User Name";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].HeaderText = "Is Active";
                dataGridView1.Columns[4].Width = 80;
                labelnumberpeople.Text = dataGridView1.Rows.Count.ToString();
            }
            else

            { labelnumberpeople.Text = "Zero"; }

        }
        private void FormUsers_Load(object sender, EventArgs e)
        {
            RefreshData();
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void userInfromationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserInfromation form = new FormUserInfromation( Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            form.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormUserInfromation form = new FormUserInfromation(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            form.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdateoradduser frm = new FormUpdateoradduser(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            RefreshData();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdateoradduser frm = new FormUpdateoradduser();
            frm.ShowDialog();
            RefreshData();

        }

        private void buttonAdduser_Click(object sender, EventArgs e)
        {
            FormUpdateoradduser frm = new FormUpdateoradduser();
            frm.ShowDialog();
            RefreshData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want Delete this User ?", "Sure", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
               if( ClsUser.DeleteUser(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)))
                {
                    CountUser--;
                    MessageBox.Show("User Deleted Successfuly");
                    RefreshData();

                }
                else
                {
                    MessageBox.Show("User Deletion Failed Because Link With Data In System","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }   
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    FilterColumn = "UserID";
                    break;
                case 1:
                    FilterColumn = "PersonID";
                    break;
                case 2:
                    FilterColumn = "FullName";
                    break;
                case 3:
                    FilterColumn = "UserName";
                    break;
                case 4:
                    FilterColumn = "IsActive";
                    break;
                case 5:
                    FilterColumn = "None";
                    break;
            }
            if (textBox1.Text.Trim() == "" || FilterColumn == "None")
            {
                RefreshData();
                labelnumberpeople.Text = dataGridView1.Rows.Count.ToString();
                return;
            }

            if (comboBox1.Text == "User ID" || comboBox1.Text == "Person ID")
            {
                DTMain.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, textBox1.Text);
            }
            else 
            {
                DTMain.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", FilterColumn, textBox1.Text); 

            }
          

            dataGridView1.DataSource = DTMain;
            labelnumberpeople.Text = dataGridView1.Rows.Count.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled=true;
        }
    }
}
