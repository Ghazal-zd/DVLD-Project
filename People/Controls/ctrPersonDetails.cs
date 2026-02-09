using DVLD_BuisnessLayer;
using People_Management.Properties;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Classes;

namespace People_Management
{
    public partial class ctrPersonDetails : UserControl
    {
        public int PersonID { get { return (_PersonID); } }
        public clsPerson Person { get { return (_Person); } }

        int _PersonID =-1;
        clsPerson _Person;
        public ctrPersonDetails()
        {           
            InitializeComponent();
        }
        private void _LoadPersonImage()
        {

            if (_Person.Gender == 0) picPersonProfile.Image = Resources.images;
            else picPersonProfile.Image = Resources.FemaleIcon;

            string ImagePath =_Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    picPersonProfile.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Couldn't find this image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _FillPersonInformation()
        {
            llEdit.Enabled = true;
            _PersonID = _Person.PersonID;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblName.Text = _Person.FullName;
            lblNationalNo.Text = _Person.NationalNo;
            lblAddress.Text = _Person.Address;

            if (_Person.Email != "")
                lblEmail.Text = _Person.Email;
            else
            {
                lblEmail.Text = "No Email";
                lblEmail.ForeColor = Color.Red;
            }
            lblDateOfBirth.Text = clsFormat.DateToShort(_Person.DateOfBirth); ;
            lblPhone.Text = _Person.Phone;
            lblCountry.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;
            lblGender.Text = (_Person.Gender == 0) ? "Male" : "Female";
            _LoadPersonImage();
        }
        public void ResetDefaultValues()
        {
            llEdit.Enabled = false;
            picPersonProfile.Image = Resources.images;
            lblPersonID.Text = "???";
            lblName.Text = "???";
            lblNationalNo.Text = "???";
            lblAddress.Text = "???";
            lblEmail.Text = "???";
            lblDateOfBirth.Text = "???";
            lblPhone.Text = "???";
            lblCountry.Text = "???";
            lblGender.Text = "???";
        }
        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            if (_Person == null )
            {
                ResetDefaultValues();
                MessageBox.Show("No person with id = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
            }
            _FillPersonInformation();

           
        }
        public void loadDataByNationalNo(string nationalNo)
        {
            _Person = clsPerson.Find(nationalNo);
            if (_Person == null)
            {
                ResetDefaultValues();
                MessageBox.Show("No person with national number = " + nationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            _FillPersonInformation();

        }
        private void llEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewUpdatePerson frmAddNew1 = new frmAddNewUpdatePerson(_PersonID);
            frmAddNew1.ShowDialog();

            LoadPersonInfo(_PersonID);

        }
    }
}
