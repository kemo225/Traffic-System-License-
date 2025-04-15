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
    public partial class FormPersonCard : Form
    {
        public FormPersonCard(int personID)
        {
            InitializeComponent();
            personInfo1.PersonID = personID;
            personInfo1.Person = clspeople.Find(personID);  

        }

        private void FormPersonCard_Load(object sender, EventArgs e)
        {
         personInfo1.LoadData(personInfo1.PersonID);
        }
    }
}
