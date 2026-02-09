using DVLD.Classes;
using DVLD_BuisnessLayer;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace People_Management
{
    public partial class frmIssueInternationalLicense : Form
    {
        clsLicense license;
        int _SelectedLicenseID = -1;
        int internationalLicenseID = -1;
        public frmIssueInternationalLicense()
        {
            InitializeComponent();
        }
        private void frmIssueInternationalLicense_Load(object sender, EventArgs e)
        {
            this.Text = "Issue International License";
           
            ctrLicenseInfoWithFilter1.setFocus();

            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblIssueDate.Text = lblApplicationDate.Text;

            lblFees.Text = clsApplicationTypes.FindApplicationType((int)clsApplication.enApplicationType.NewInternationalLicense).ApplicationFees.ToString();
            lblUserName.Text = clsGlobal.CurrentUser.userName;

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (license.LicenseClassInfo.ClassID != 3 && !license.IsActive)
            {
                return;
            }
            clsInternationalLicense internationalLicense = new clsInternationalLicense();
            internationalLicense.IssuedUsingLocalDrivingLicenseID = license.LicenseID;
            internationalLicense.ApplicantPersonID = license.DriverInfo.PersonID;
            internationalLicense.ApplicationDate = DateTime.Now;
            internationalLicense.LastStatusDate = DateTime.Now;
            internationalLicense.ApplicationTypeID = clsApplicationTypes.FindApplicationType((int)clsApplication.enApplicationType.NewInternationalLicense).ApplicationID;
            internationalLicense.ApplicationFees = clsApplicationTypes.FindApplicationType((int)clsApplication.enApplicationType.NewInternationalLicense).ApplicationFees;
            internationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            internationalLicense.ApplicationStatus = clsApplication.enApplicationStatus.Completed;

            internationalLicense.DriverID = license.DriverID;
            internationalLicense.IssueDate = DateTime.Now;
            internationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            internationalLicense.IsActive = true;

            if (internationalLicense.Save())
            {
                MessageBox.Show("Failed to Issue!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("License with ID [" + internationalLicense.InternationalLicenseID + "] issued Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnIssue.Enabled = false;
            internationalLicenseID = internationalLicense.InternationalLicenseID;
            lblIntLicenseID.Text = internationalLicenseID.ToString();
            lblApplicationID.Text = internationalLicense.ApplicationID.ToString();
            lnkLicenseInfo.Enabled = true;
            ctrLicenseInfoWithFilter1.FilterEnabled = false;
        }

    
        private void lnkLblLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frmLicenseHistory = new frmLicenseHistory(license.DriverInfo.PersonID);
            frmLicenseHistory.ShowDialog();
        }

        private void lnkLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenseInfo frmInternationalLicenseInfo = new frmInternationalLicenseInfo(internationalLicenseID);
            frmInternationalLicenseInfo.ShowDialog();
        }

        private void btnClosee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrLicenseInfoWithFilter1_OnSearchCompleted(int obj)
        {
            _SelectedLicenseID = obj;
            lblLDLLicenseID.Text = _SelectedLicenseID.ToString();
            lnkLblLicenseHistory.Enabled = (_SelectedLicenseID != -1);

            if (ctrLicenseInfoWithFilter1.LicenseID == -1) return;

            license = ctrLicenseInfoWithFilter1.selectedLicense;

            lblExeprationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(license.LicenseClassInfo.DefaultValidityLength));

            if (!license.IsActive)
            {
                MessageBox.Show("This license is not active,choose another one", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (license.LicenseClassID != 3)
            {
                MessageBox.Show("Selected license should bo class 3,choose another one", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int activeInternationalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseByDriverID(license.DriverID);
            if (activeInternationalLicenseID!=-1)
            {
                MessageBox.Show("This person already have an international license.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lnkLicenseInfo.Enabled = true;
                internationalLicenseID = activeInternationalLicenseID;
                return;
            }
            btnIssue.Enabled = true;

        }
    }
}
