using BussinessLayerDVLD;
using DVLDD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDD
{
    public partial class PersonInfo : System.Windows.Forms.UserControl
    {
        public bool personselected
        { get; set; }

        public string NationalNO { get; set; }

        private int _PersonID = -1;
        private clspeople _Person;
        public int PersonID
        {
            get { return _PersonID; }
            set { _PersonID = value; }        
        }
        public clspeople Person
        {
            get { return _Person; }
            set { _Person = value; }
        }
        private void LoadImage()
        {
            if (_Person.gender == (int)clspeople.enGender.male)
         { pictureBoxPhoto.Image = Resource2.Male_512;
            radioButton1.Checked = true;
            }
            else
              { pictureBoxPhoto.Image = Resource2.Female_512; 
            radioButton2.Checked = true;    
            }

            string ImagePath = _Person.imagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
               { pictureBoxPhoto.ImageLocation = ImagePath; }
                else
                    { MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
      
        public bool LoadData(int personID)
        {
            bool result = false;
            _PersonID = personID;
            _Person = clspeople.Find(_PersonID);
            if (_Person != null)
            {
                result = true;
                personselected = true;
                this.NationalNO = _Person.NationalNO;
                lblID.Text = _Person.PeopleID.ToString();
                labelsetnational.Text = _Person.NationalNO;
                labelsetname.Text = _Person.FirstName+" "+_Person.FourthName;
                labelsetphone.Text = _Person.phone;
                labelsetemail.Text = _Person.email;
                textBoxaddress.Text = _Person.Address;
                labelsetdatebirth.Text = _Person.DateofBirth.ToString();
                labelsetCountry.Text = ClsCountry.FindByID(Person.NatioanalCountryID).CountryName;
                LoadImage();   

            }
            else
            {
                result= false;  
                personselected= false;  
            }
            return result;  
        }
        public bool LoadData(string NationalNO)
        {
            bool result = false;
            this.NationalNO = NationalNO;
            _Person = clspeople.FindBYNationalNO(NationalNO);
            if (_Person != null)
            {
                result = true;
                personselected = true;
                this._PersonID = _Person.PeopleID;  
                lblID.Text = _Person.PeopleID.ToString();
                labelsetnational.Text = _Person.NationalNO;
                labelsetname.Text = _Person.FirstName + " " + _Person.FourthName;
                labelsetphone.Text = _Person.phone;
                labelsetemail.Text = _Person.email;
                textBoxaddress.Text = _Person.Address;
                labelsetdatebirth.Text = _Person.DateofBirth.ToString();
                labelsetCountry.Text = ClsCountry.FindByID(Person.NatioanalCountryID).CountryName;
                LoadImage();

            }
            else
            {
                result = false;
                personselected = false;
            }
            return result;
        }
        public PersonInfo()
        {
            InitializeComponent();
        }
        // define event
        public event Action<PersonInfo> Onlinklableclicked;
        protected virtual void linklableclicked()
        {
            Action<PersonInfo> Handler = Onlinklableclicked;
            if (Handler != null)
            {
                Handler(this);
            }

         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labeleditpersoninfoo_Click(object sender, EventArgs e)
        {
            FormAddEditPerson frm = new FormAddEditPerson(_PersonID);
            frm.ShowDialog();
            //refresh data
            LoadData(_PersonID);
        }
    }
}
