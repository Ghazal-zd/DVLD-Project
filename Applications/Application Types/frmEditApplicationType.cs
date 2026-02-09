using DVLD.Classes;
using DVLD_BuisnessLayer;
using System;
using System.Windows.Forms;

namespace People_Management
{
    public partial class frmEditApplicationType : Form
    {
        int _applicationTypeID = -1;
        clsApplicationTypes appType;
        public frmEditApplicationType(int applicationTypeID)
        {
            InitializeComponent();
            _applicationTypeID = applicationTypeID;
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            appType = clsApplicationTypes.FindApplicationType(_applicationTypeID);
            if (appType != null)
            {
                txtApplicationFees.Text = appType.ApplicationFees.ToString();
                txtApplicationTypeTitle.Text = appType.ApplicationTitle;
                lblTypeID.Text=appType.ApplicationID.ToString();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            appType.ApplicationTitle = txtApplicationTypeTitle.Text;
            appType.ApplicationFees = decimal.Parse(txtApplicationFees.Text);
            if (!appType.Save())
            {
                MessageBox.Show("Something went wrong!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Data Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtApplicationFees_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtApplicationFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtApplicationFees, "This field id required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtApplicationFees, "");
            }

            if(!clsValidatoin.IsNumber(txtApplicationFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtApplicationFees, "Invalid number");
                return;
            }
            else
            {
                errorProvider1.SetError(txtApplicationFees, "");
            }
        }
        private void txtApplicationTypeTitle_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtApplicationTypeTitle.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtApplicationTypeTitle, "This field id required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtApplicationTypeTitle, "");
            }
        }
    }
}
