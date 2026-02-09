using DVLD.Classes;
using DVLD_BuisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People_Management
{
    public partial class frmIssueLicenseFirstTime : Form
    {
        int localDrivingLicenseApplicationID = -1;

        clsLDLApplication localDrivingLicenseApplication;
        clsDriver driver;
        public frmIssueLicenseFirstTime(int applicationID)
        {
            InitializeComponent();
            this.localDrivingLicenseApplicationID = applicationID;
        }
        private void ctrDrivingLicenseInfo1_Load(object sender, EventArgs e)
        {

        }

        private void frmIssueLicenseFirstTime_Load(object sender, EventArgs e)
        {
            localDrivingLicenseApplication=clsLDLApplication.Find(localDrivingLicenseApplicationID);
            if (localDrivingLicenseApplication == null)
            {
                MessageBox.Show("No application with id =" + localDrivingLicenseApplication, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!localDrivingLicenseApplication.PassedAllTests())
            {
                MessageBox.Show("Person should pass all tests first." , "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int licenseID = localDrivingLicenseApplication.GetActiveLicenseID();
            if (licenseID != -1)
            {
                MessageBox.Show("Person already has a license before with license id = " + licenseID, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrDrivingLicenseInfo1.loadLocalDrivingLicenseApplicationInfo(localDrivingLicenseApplicationID);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int licenseID = localDrivingLicenseApplication.IssueLicenseForTheFirstTime(txtNotes.Text.Trim(),clsGlobal.CurrentUser.UserID);
            if (licenseID != -1)
            {
                MessageBox.Show("License issued successfully", "Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("License was not issued!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close  ();
        }
    }
}
