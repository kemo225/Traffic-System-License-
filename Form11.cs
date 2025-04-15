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
    public partial class Form11 : Form
    {
        private DataTable SubsetDT = ClsApplicationType.GetallApplicationtypes();
        public Form11()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            SubsetDT = ClsApplicationType.GetallApplicationtypes(); ;
        dataGridView1.DataSource = SubsetDT;
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

            RefreshData();

            if (dataGridView1.Rows.Count > 0)
            {

                dataGridView1.Columns[0].HeaderText = "Application ID";
                dataGridView1.Columns[0].Width = 80;
                dataGridView1.Columns[1].HeaderText = "Application Tittle";
                dataGridView1.Columns[1].Width = 400;
                dataGridView1.Columns[2].HeaderText = "Fees";
                dataGridView1.Columns[2].Width = 90;
            }
            labelnumberpeople.Text=dataGridView1.RowCount.ToString();   

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formupdateapp frm = new Formupdateapp(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            RefreshData();
        }
    }
}
