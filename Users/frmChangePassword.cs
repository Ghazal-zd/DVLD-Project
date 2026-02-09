using DVLD_BuisnessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace People_Management
{
    public partial class frmChangePassword : Form
    {

        public delegate void SendDataBack(object sender, DataTable dataTable);
        public SendDataBack DataBack;

        int UserID = -1;
        clsUser _User;
        public frmChangePassword(int userID)
        {
            InitializeComponent();

            UserID = userID;
        }
        private void _ResetDefaultValues()
        {
            txtCurrentPassword.Focus();

            txtConfirmPassword.Text = "";
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            ctrUserInformation1.ResetDefaultValues();
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            _User = clsUser.Find(UserID);
            if (_User == null)
            {

                MessageBox.Show("Sorry, No user with id = " + UserID, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            ctrUserInformation1.LoadUserInfo(UserID);
        }
        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {

            if (txtCurrentPassword.Text.Trim() != _User.password)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Incorrect password");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCurrentPassword, "");
            }

            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCurrentPassword, "");
            }

        }
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password confirmation does not match new password!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, "");
            }
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, "");
            }

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Field are not valid!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _User.password = txtNewPassword.Text;
            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Something went wrong!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }
        }
    }
}


