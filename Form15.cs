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
    public partial class FormMgTestType : Form
    {
        private DataTable MainDt = ClsTestTypes.GetAllTestTypes();
        public FormMgTestType()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            MainDt = ClsTestTypes.GetAllTestTypes();
            dataGridView1.DataSource=MainDt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMgTestType_Load(object sender, EventArgs e)
        {
            RefreshData();
            if (dataGridView1.Rows.Count > 0)
            {

                dataGridView1.Columns[0].HeaderText = "Test ID";
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].HeaderText = "Test Type Tittle";
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].HeaderText = "Test Type Description";
                dataGridView1.Columns[2].Width = 400;
                dataGridView1.Columns[3].HeaderText = "Fees";
                dataGridView1.Columns[3].Width = 78;

            }
            labelnumberpeople.Text = dataGridView1.Rows.Count.ToString();

        }

        private void updateTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 frm = new Form16(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
