using DVLD.Classes;
using DVLD_BuisnessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace People_Management
{
    public partial class frmEditTestTypecs : Form
    {
        int _testTypeID = -1;
        clsTestTypes testType;
        public frmEditTestTypecs(int testTypeID)
        {
            InitializeComponent();
            _testTypeID = testTypeID;
        }

      
        private void frmEditTestTypecs_Load(object sender, EventArgs e)
        {
            testType = clsTestTypes.FindTestType((clsTestTypes.enTestType)_testTypeID);
            if (testType != null)
            {
                lblTypeID.Text =  ((int)testType.TestTypeID).ToString();
                txtTestTypeTitle.Text = testType.TestTypeTitle;
                txtTestTypeDescription.Text = testType.TestTypeDescription;
                txtTestTypeFees.Text = testType.TestTypeFees.ToString();
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            testType.TestTypeTitle = txtTestTypeTitle.Text;
            testType.TestTypeDescription = txtTestTypeDescription.Text;
            testType.TestTypeFees=decimal.Parse(txtTestTypeFees.Text);
            if (testType.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void txtTestTypeTitle_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtTestTypeTitle.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTestTypeTitle, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtTestTypeTitle, "");
            }
        }

        private void txtTestTypeDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTestTypeDescription.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTestTypeDescription, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtTestTypeDescription, "");
            }
        }

        private void txtTestTypeFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTestTypeFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTestTypeFees, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtTestTypeFees, "");
            }

            if (!clsValidatoin.IsNumber(txtTestTypeFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTestTypeFees, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtTestTypeFees, "");
            }
        }
    }
}
