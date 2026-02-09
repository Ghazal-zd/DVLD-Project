using DVLD_BuisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace People_Management
{
    public partial class frmAddNewUser : Form
    {
        private enum enMode { Update = 0, AddNew = 1 }
        enMode mode;

        clsUser _User;
        int UserID = -1;
        public frmAddNewUser()
        {
            InitializeComponent();
            mode = enMode.AddNew;
        }
        public frmAddNewUser(int userID)
        {
            InitializeComponent();
            UserID = userID;
            mode = enMode.Update;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields are not valid!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.PersonID = ctrPersonInfoWithFilter1.PersonID;
            _User.userName = txtUserName.Text;
            _User.password = txtPassword.Text;
            _User.isActive = chxIsActive.Checked ? true : false;

            if (_User.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblUserID.Text = _User.UserID.ToString();
                lblTitle.Text = "Update User";
                this.Text = "Update User";
                return;
            }
            else
            {
                MessageBox.Show("Data did not Save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "User name is required");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, "");
            }


            bool isValid = (mode == enMode.Update ?
              txtUserName.Text.Trim() != _User.userName && clsUser.isUserExist(txtUserName.Text)
              : clsPerson.isPersonExist(txtUserName.Text));
            if (isValid)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "This user name used by another one");
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
            }


        }
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "This Field is required");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, "");
            } 
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "password does not match");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tabUserInfo.Enabled = true;
                tabCtrAddNewUser.SelectedTab = tabCtrAddNewUser.TabPages["tabUserInfo"];
                return;
            }
            if (ctrPersonInfoWithFilter1.PersonID != -1)
            {
                if (clsUser.isUserExistForPersonID(ctrPersonInfoWithFilter1.PersonID))
                {
                    MessageBox.Show("this person already has a user", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    tabUserInfo.Enabled = true;
                    tabCtrAddNewUser.SelectedTab = tabCtrAddNewUser.TabPages["tabUserInfo"];
                }
            }
            else
            {
                MessageBox.Show("Please Select a Person", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ResetDefaultValues()
        {
            if (mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();
                ctrPersonInfoWithFilter1.filterEnabled = true;
                tabUserInfo.Enabled = false;
            }
            else
            {
                lblTitle.Text = "Update User";
                ctrPersonInfoWithFilter1.filterEnabled = false;
                tabUserInfo.Enabled = true;

            }
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chxIsActive.Checked = true;
        } 
        private void _LoadUserInfo()
        {

            _User = clsUser.Find(UserID);
            if (_User == null)
            {
                MessageBox.Show("No User With ID = " + UserID, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.userName;
            txtPassword.Text = _User.password;
            txtConfirmPassword.Text = _User.password;
            chxIsActive.Checked = _User.isActive;
            ctrPersonInfoWithFilter1.LoadPersonInfo(_User.PersonID);
        }
        private void frmAddNewUsercs_Load(object sender, EventArgs e)
        { 
            _ResetDefaultValues();

            if (mode == enMode.Update)
            {
                _LoadUserInfo();
            }
        }

     
    }
}
