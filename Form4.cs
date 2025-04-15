using BussinessLayerDVLD;
using DVLDD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLDD
{
    public partial class FormAddEditPerson : Form
    {
        clspeople people;
        // define delegate  
        public delegate void datahandler(object sender, int personid);
        public event datahandler databack;

        private enum enMode
        {
            Add = 1,
            Update = 2
        }
        private enMode Mode;
        private void HandlePhoto()
        {
            if (people.imagePath != pictureBoxphoto.ImageLocation && people.imagePath != "")
            {
                // kda elsora at8yert
                if (people.imagePath != "")
                {
                    try
                    {
                        File.Delete(people.imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            if (pictureBoxphoto.ImageLocation != "")
            {
                // elsora elgdeda // mafesh sora asln
                string PathPhoto = pictureBoxphoto.ImageLocation;
                if (PathPhoto == "" || PathPhoto == null)
                {
                    return;
                }
                if (clsUtil.CopyImageToProjectImagesFolder(ref PathPhoto))
                {
                    pictureBoxphoto.ImageLocation = PathPhoto;
                }
                else
                {
                    MessageBox.Show("Error Copying Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void fillComboBox()
        {
            DataTable dt = ClsCountry.GetAllCountries();
            foreach (DataRow row in dt.Rows)
            {
                comboBoxcountry.Items.Add(row["CountryName"]);
            }
        }
        public FormAddEditPerson(int personid)
        {
            InitializeComponent();
            people = clspeople.Find(personid);

        }
        private void Loading()
        {
            fillComboBox();
            if (people != null)
            {
                labeltitle.Text = "Update Person";

                Mode = enMode.Update;
                maskedTextBoxFirstname.Text = people.FirstName;
                maskedTextBoxlastname.Text = people.FourthName;
                textBoxaddress.Text = people.Address;
                maskedTextBoxphone.Text = people.phone;
                maskedTextBoxEmail.Text = people.email;
                maskedTextBoxthirdname.Text = people.ThirdName;
                maskedTextBoxsecondname.Text = people.SecendName;
                maskedTextBoxDate.Text = people.DateofBirth.ToString("dd/MM/yyyy HH:mm:ss");
                maskedTextBoxnationalnum.Text = people.NationalNO;
                labelID.Text = people.PeopleID.ToString();

                if (people.gender == (int)clspeople.enGender.male)
                {
                    radioButtonmale.Checked = true;
                    pictureBoxphoto.Image = Resource2.Male_512;
                }
                else
                {
                    radioButtonfemale.Checked = true;
                    pictureBoxphoto.Image = Resource2.Female_512;

                }
                if (people.imagePath != null)
                {
                    pictureBoxphoto.ImageLocation = people.imagePath;
                }
                comboBoxcountry.SelectedItem = ClsCountry.FindByID(people.NatioanalCountryID).CountryName;

            }
            else
            {
                Mode = enMode.Add;
                people = new clspeople();
                labeltitle.Text = "Add New Person";
            }
        }
        private void FormAddEditPerson_Load(object sender, EventArgs e)
        {
            if (pictureBoxphoto.ImageLocation != "" && pictureBoxphoto.ImageLocation != null)
            {
                linkLabelRemove.Visible = true;
            }
            Loading();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxphoto_Click(object sender, EventArgs e)
        {

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            HandlePhoto();
            people.FirstName = maskedTextBoxFirstname.Text;
            people.FourthName = maskedTextBoxlastname.Text;
            people.Address = textBoxaddress.Text;
            people.phone = maskedTextBoxphone.Text;
            people.email = maskedTextBoxEmail.Text;
            people.SecendName = maskedTextBoxsecondname.Text;
            people.ThirdName = maskedTextBoxthirdname.Text;
            if (DateTime.TryParseExact(maskedTextBoxDate.Text, "MM/dd/yyyy HH:mm::ss",
                           System.Globalization.CultureInfo.InvariantCulture,
                           System.Globalization.DateTimeStyles.None, out DateTime result))
                people.DateofBirth = Convert.ToDateTime(maskedTextBoxDate.Text);
            people.NationalNO = maskedTextBoxnationalnum.Text;
            people.NatioanalCountryID = ClsCountry.FindByName(comboBoxcountry.SelectedItem.ToString()).CountryID;
            if (radioButtonmale.Checked)
            {
                people.gender = (int)clspeople.enGender.male;
            }
            else
            {
                people.gender = (int)clspeople.enGender.female;

            }
            people.imagePath = pictureBoxphoto.ImageLocation;

            people.Save();
            if (Mode == enMode.Add)
            {
                MessageBox.Show($"Saved Successfuly And The ID Is = {people.PeopleID}");
                Mode = enMode.Update;
            }
            else
            {
                MessageBox.Show("تم التعديل بنجاح");
            }
            if (databack != null)
            { databack?.Invoke(this, people.PeopleID); }
            this.Close();


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonmale_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxphoto.Image = Resource2.Male_512;
        }

        private void linkLabelSETphoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Select Image";
            openFileDialog1.InitialDirectory = "C:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxphoto.ImageLocation = openFileDialog1.FileName;
                linkLabelRemove.Visible = true;
            }

        }

        private void radioButtonfemale_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxphoto.Image = Resource2.Female_512;

        }

        private void linkLabelRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBoxphoto.ImageLocation = "";
        }

        private void maskedTextBoxFirstname_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBoxFirstname.Text.Trim() == "")
            {
                errorProvider1.SetError(maskedTextBoxFirstname, "You Must Enter First Name");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(maskedTextBoxFirstname, null);
            }
        }

        private void maskedTextBoxsecondname_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBoxsecondname.Text.Trim() == "")
            {
                errorProvider1.SetError(maskedTextBoxsecondname, "You Must Enter Second Name");
                e.Cancel = true;
            } else
            {
                errorProvider1.SetError(maskedTextBoxsecondname, null);
            }
        }

        private void maskedTextBoxthirdname_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBoxthirdname.Text.Trim() == "")
            {
                errorProvider1.SetError(maskedTextBoxthirdname, "You Must Enter Third Name");
                e.Cancel = true;
            } else
            {
                errorProvider1.SetError(maskedTextBoxthirdname, null);
            }
        }

        private void maskedTextBoxlastname_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBoxlastname.Text.Trim() == "")
            {
                errorProvider1.SetError(maskedTextBoxlastname, "You Must Enter Last Name");
                e.Cancel = true;
            } else
            {
                errorProvider1.SetError(maskedTextBoxlastname, null);
            }
        }

        private void maskedTextBoxnationalnum_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBoxnationalnum.Text.Trim() == "")
            {
                errorProvider1.SetError(maskedTextBoxnationalnum, "You Must Enter National Number");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(maskedTextBoxnationalnum, null);
            }
        }

        private void maskedTextBoxphone_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBoxphone.Text.Trim() == "")
            {
                errorProvider1.SetError(maskedTextBoxphone, "You Must Enter Phone Number");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(maskedTextBoxphone, null);
        
        }
        
        


        private void comboBoxcountry_Validating(object sender, CancelEventArgs e)
        {
            if(comboBoxcountry.Text.Trim() =="")
            {
                errorProvider1.SetError(comboBoxcountry, "You Must Enter Country");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(comboBoxcountry, null);
            }
        }

        private void maskedTextBoxDate_Validating(object sender, CancelEventArgs e)
        {
            if(maskedTextBoxDate.Text.Trim()=="")
            {
                errorProvider1.SetError(maskedTextBoxDate, "You Must Enter Date");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(maskedTextBoxDate, null);
            }
        }

        private void maskedTextBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBoxEmail.Text.Trim() == "")
            {
                errorProvider1.SetError(maskedTextBoxEmail, "You Must Enter Email");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(maskedTextBoxEmail, null);
            }
        }

        private void textBoxaddress_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxaddress.Text.Trim() == "")
            {
                errorProvider1.SetError(textBoxaddress, "You Must Enter Address");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBoxaddress, null);
            }
        }
    }
}
