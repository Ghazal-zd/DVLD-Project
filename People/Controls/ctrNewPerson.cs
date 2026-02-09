using DVLD_BuisnessLayer;
using System;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;
using System.Security;

namespace People_Management
{
    public partial class ctrNewPerson : UserControl
    {
        public event Action OnPersonInfoSaved;
        protected virtual void PersonInfoSaved()
        {
            Action handler = OnPersonInfoSaved;
            if (handler != null)
                handler();
        }
        //clsPerson PersonInfo = new clsPerson();
        public ctrNewPerson()
        {
            InitializeComponent();
        }

        //private void _FillcmbCountries()
        //{
        //    DataTable AllPeopleDT=clsCountry.GetAllCountries();
        //    foreach (DataRow dataRow in AllPeopleDT.Rows)
        //    {
        //        cmbCountries.Items.Add(dataRow["CountryName"]);
        //    }
        //}
        //private void _LoadData()
        //{
        //    dt_DOB.MaxDate = DateTime.Today.AddYears(-18);
        //    rbMale.Checked=true;
        //    _FillcmbCountries();
        //    /*if (rbFemale.Checked)
        //    {
        //        picPersonProfile.ImageLocation = "C:\\Users\\VICTUS\\Downloads\\pa2.png";
        //    }
        //    else if (rbMale.Checked)
        //    {
        //        picPersonProfile.ImageLocation = "C:\\Users\\VICTUS\\source\\repos\\People Management\\Resources\\images.png";
        //    }*/

        //    if (picPersonProfile.ImageLocation != "C:\\Users\\VICTUS\\Downloads\\pa2.png" &&
        //       picPersonProfile.ImageLocation != "C:\\Users\\VICTUS\\source\\repos\\People Management\\Resources\\images.png")
        //        lblRemove.Visible = true;
        //    else lblRemove.Visible = false;
        //}
        private void UserControl1_Load(object sender, EventArgs e)
        {
            //_LoadData();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //private bool IsValidEmail(string email)
        //{
            //try
            //{
            //    var addr = new System.Net.Mail.MailAddress(email);
            //    return addr.Address == email;
            //}
            //catch
            //{
            //    return false;
            //}
        //}
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            //if (!IsValidEmail(txtEmail.Text))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txtEmail, "invalid email");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(txtEmail, "");
            //}
        }

        private void txtNationalNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            //if (clsPerson.isPersonExist(txtNationalNo.Text))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txtNationalNo, "This National Number is already exists");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(txtNationalNo, "");
            //}
        }

        private void lblImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //openFileDialog1.InitialDirectory = @"C:\Users\VICTUS\Pictures\Screenshots";
            //openFileDialog1.DefaultExt = "png";
            //openFileDialog1.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    picPersonProfile.ImageLocation = (openFileDialog1.FileName);
            //}

            //if (picPersonProfile.ImageLocation != "C:\\Users\\VICTUS\\Downloads\\pa2.png" &&
            //   picPersonProfile.ImageLocation != "C:\\Users\\VICTUS\\source\\repos\\People Management\\Resources\\images.png")
            //    lblRemove.Visible = true;
        }

        private void lblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //if (rbFemale.Checked)
            //{
            //    picPersonProfile.ImageLocation = "C:\\Users\\VICTUS\\Downloads\\pa2.png";
            //}
            //else if (rbMale.Checked)
            //{
            //    picPersonProfile.ImageLocation = "C:\\Users\\VICTUS\\source\\repos\\People Management\\Resources\\images.png";

            //}
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            //if(rbMale.Checked) picPersonProfile.ImageLocation = "C:\\Users\\VICTUS\\source\\repos\\People Management\\Resources\\images.png";

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbFemale.Checked) picPersonProfile.ImageLocation = "C:\\Users\\VICTUS\\Downloads\\pa2.png";
            
        }
        private void _Save()
        {
            //PersonInfo.FirstName = txtFirstName.Text;
            //PersonInfo.SecondName = txtSecondName.Text;
            //PersonInfo.ThirdName = txtThirdName.Text;
            //PersonInfo.LastName = txtLastName.Text;

            //PersonInfo.NationalNo = txtNationalNo.Text;
            //PersonInfo.Email = txtEmail.Text;
            //PersonInfo.Phone = txtPhone.Text;
            //PersonInfo.Address = txtAddress.Text;

            //if (rbMale.Checked)
            //    PersonInfo.Gender = 0;
            //else if (rbFemale.Checked)
            //    PersonInfo.Gender = 1;

            //PersonInfo.DateOfBirth = dt_DOB.Value;

            //PersonInfo.NationalityCountryID = clsCountry.FindCountryByName(cmbCountries.Text);
            //if (PersonInfo.Save())
            //{
            //    MessageBox.Show("Data Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //_Save();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Hide();
       
            //Form frm1 = new Form1();
            //frm1.ShowDialog();
        }

        private void cmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dt_DOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtThirdName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtSecondName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
