using DVLD_BuisnessLayer;
using System;
using System.IO;
using System.Data;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics.Eventing.Reader;
using People_Management.Properties;
using DVLD.Classes;

namespace People_Management
{
    public partial class frmAddNewUpdatePerson : Form
    {
       

        public delegate void SendDataBack(object sender, int personID);
        public SendDataBack DataBack;
        private enum enMode { AddNew = 1, Update = 2 };
        enMode _mode;
         private enum enGender { Male = 0, Female = 1 };

        int _PersonID = -1;
        clsPerson _person;
        public frmAddNewUpdatePerson()
        {
            InitializeComponent();
            _mode = enMode.AddNew;
        }
        public frmAddNewUpdatePerson(int personID)
        {
            InitializeComponent();

            _PersonID = personID;
            _mode = enMode.Update;
        }

        private void _FillcmbCountries()
        {
            DataTable dt = clsCountry.GetAllCountries();
            foreach (DataRow dataRow in dt.Rows)
            {
                cmbCountries.Items.Add(dataRow["CountryName"]);
            }
        }
        private void _LoadData()
        { 
            _person = clsPerson.Find(_PersonID);
            if (_person == null)
            {
                MessageBox.Show("No person with ID = " + _PersonID, "Person not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lblPersonID.Text = _person.PersonID.ToString();
            txtFirstName.Text = _person.FirstName;
            txtSecondName.Text = _person.SecondName;
            txtThirdName.Text = _person.ThirdName;
            txtLastName.Text = _person.LastName;
            txtNationalNo.Text = _person.NationalNo;

            if (_person.Gender == 0) rbMale.Checked = true;
            else rbFemale.Checked = false;

            txtEmail.Text = _person.Email;
            dt_DOB.Value = _person.DateOfBirth;
            txtPhone.Text = _person.Phone;

            cmbCountries.SelectedItem = cmbCountries.FindString(_person.CountryInfo.CountryName);
           
            txtAddress.Text = _person.Address;

            if (_person.ImagePath != "")
                picPersonProfile.ImageLocation = _person.ImagePath;

            lblRemove.Visible = (_person.ImagePath != "");
        }
        private void _ResetDefaultValues()
        {
            _FillcmbCountries();
            cmbCountries.SelectedIndex = cmbCountries.FindString("Syria");

            dt_DOB.MaxDate = DateTime.Today.AddYears(-18);
            dt_DOB.Value=dt_DOB.MaxDate;

            dt_DOB.MinDate=DateTime.Today.AddYears(-100);

            rbMale.Checked = true;

            if (_mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _person = new clsPerson();
            }
            else
            {
                lblTitle.Text = "Update Person";
            }

            if (rbMale.Checked) picPersonProfile.Image = Resources.images;
            else picPersonProfile.Image = Resources.FemaleIcon;

            lblRemove.Visible=(picPersonProfile.ImageLocation != null);

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            rbMale.Checked = true;
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }
        private void frmAddNew_Load(object sender, System.EventArgs e)
        {
            _ResetDefaultValues();

            if(_mode==enMode.Update)
            _LoadData();
        }

        private void txtNationalNo_TextChanged(object sender, System.EventArgs e)
        {
          
        }

        private void txtNationalNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This field is required");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalNo, "");
            }


            bool isValid = (_mode == enMode.Update ?
              txtNationalNo.Text.Trim() != _person.NationalNo && clsPerson.isPersonExist(txtNationalNo.Text)
              : clsPerson.isPersonExist(txtNationalNo.Text));
            if(isValid) 
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This National Number is already exists");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }

           
        }
        
        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
                if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtEmail, "This field is required!");
                    return;
                }
                else
                {
                    e.Cancel = false;
                   errorProvider1.SetError(txtEmail, null);
                }
 
                if (!clsValidatoin.ValidateEmail(txtEmail.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtEmail, "invalid email");
                }
                else
                {
                    //e.Cancel = false;
                    errorProvider1.SetError(txtEmail, null);
                }
            
        }
        private void rbMale_CheckedChanged(object sender, System.EventArgs e)
        {
            if (picPersonProfile.ImageLocation == null)
                picPersonProfile.Image = Resources.images; 
        }

        private void rbFemale_CheckedChanged(object sender, System.EventArgs e)
        {
            if (picPersonProfile.ImageLocation == null)
                picPersonProfile.Image = Resources.FemaleIcon;
        }

        private void lblImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                picPersonProfile.ImageLocation = selectedFilePath;
                lblRemove.Visible = true;
            }
        }

        private void lblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picPersonProfile.ImageLocation = null;
            if (rbMale.Checked)
            {
                picPersonProfile.Image = Resources.images;
            }
            else
                picPersonProfile.Image = Resources.FemaleIcon;

            lblRemove.Visible=false;
   
        }
        private string _NewImagePath(string sourcePath)
        {
            Guid guid = Guid.NewGuid();

            string destFolder = @"C:\DVLDProfiles";
            string fileName = Path.GetFileName(sourcePath);
            fileName = guid.ToString() + Path.GetExtension(sourcePath);

            string destPath = Path.Combine(destFolder, fileName);

            if (!Directory.Exists(destFolder))
            {
                Directory.CreateDirectory(destFolder);
            }

            File.Copy(sourcePath, destPath, true);
            return destPath;
        }
        private bool HandlePersonImage()
        {
            if (picPersonProfile.ImageLocation != _person.ImagePath)
            {
                if (_person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_person.ImagePath);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            if (picPersonProfile.ImageLocation != null)
            {
                string sourceImageFile = picPersonProfile.ImageLocation.ToString();

                if (clsUtil.CopyImageToProjectImagesFolder(ref sourceImageFile))
                {
                    picPersonProfile.ImageLocation = sourceImageFile;
                    return true;
                }
                else
                {
                    MessageBox.Show("Error copying image file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private void _Save()
        {
            if (!HandlePersonImage())
            {
                return;
            }
            int NationalityCountryID = clsCountry.Find(cmbCountries.Text).CountryID;

            _person.FirstName = txtFirstName.Text.Trim();
            _person.SecondName = txtSecondName.Text.Trim();
            _person.ThirdName = txtThirdName.Text.Trim();
            _person.LastName = txtLastName.Text.Trim();
            _person.NationalNo = txtNationalNo.Text.Trim();
            _person.Email = txtEmail.Text.Trim();
            _person.Phone = txtPhone.Text.Trim();
            _person.Address = txtAddress.Text.Trim();

            if (rbMale.Checked)
                _person.Gender = (short) enGender.Male;
            else 
                _person.Gender = (short) enGender.Female;

            _person.DateOfBirth = dt_DOB.Value;

            _person.NationalityCountryID = NationalityCountryID;

            if (picPersonProfile.ImageLocation != null)
            {
                _person.ImagePath = picPersonProfile.ImageLocation;
            }
            else _person.ImagePath = "";


            if (_person.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblPersonID.Text=_person.PersonID.ToString();    
                _mode =enMode.Update;
                lblTitle.Text = "Update Person";
                DataBack?.Invoke(this,_person.PersonID);
                this.Close();
            }
            else MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fill the required data", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Save();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
              e.Cancel = true;
              errorProvider1.SetError(txtFirstName, "This field is required"); 
            }
            else
                errorProvider1.SetError(txtFirstName, null);
        }
        private void txtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "This field is required");
            }
            else
                errorProvider1.SetError(txtLastName, null);
        }
        private void txtSecondName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSecondName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSecondName, "This field is required");
            }
            else
                errorProvider1.SetError(txtSecondName, null);
        }
        private void txtAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAddress, "This field is required");
            }
            else
                errorProvider1.SetError(txtAddress, null);
        }
        private void txtPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
      
        }
    }
}
