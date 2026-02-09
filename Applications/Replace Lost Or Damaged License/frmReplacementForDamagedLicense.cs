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
    public partial class frmReplacementForDamagedLicense : Form
    {
        clsLicense license;
        int _newLicenseID = -1;

        public frmReplacementForDamagedLicense()
        {
            InitializeComponent();
        }
        private void ctrLicenseInfoWithFilter1_OnSearchCompleted(int obj)
        {
            int LicenseID = obj;
            license = ctrLicenseInfoWithFilter1.selectedLicense;

            lblLocalLicenseID.Text = LicenseID.ToString();
            lnkLblLicenseHistory.Enabled = true;

            if(LicenseID == -1)
            {
                return;
            }
            if (!license.IsActive)
            {

                MessageBox.Show("Selected license is not active, choose an active license.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnReplacement.Enabled = true;
        }
        private void frmReplacementForDamagedLicense_Load(object sender, EventArgs e)
        {
            this.Text = "Replace Damaged Or Lost License";
            ctrLicenseInfoWithFilter1.setFocus();
            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblFees.Text = clsApplicationTypes.FindApplicationType((int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense).ApplicationFees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.userName;
            rdLDamagedLicense.Checked = true;
        }
        private void lnkLblLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frmLicenseHistory = new frmLicenseHistory(license.DriverInfo.PersonID);
            frmLicenseHistory.ShowDialog();
        }
        private int _GetApplicationTypeID()
        {
            if (rblostLicense.Checked)
                return (int)clsApplication.enApplicationType.ReplaceLostDrivingLicense;
            else
                return (int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense;
        }
        private clsLicense.enIssueReason _GetIssueReason()
        {
            if (rblostLicense.Checked)
                return clsLicense.enIssueReason.Lost;
            else
                return clsLicense.enIssueReason.Damaged;
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            clsLicense newLicense = license.Replace(_GetIssueReason(), clsGlobal.CurrentUser.UserID);

            if(newLicense==null)
            {
                MessageBox.Show("Failed to replace this license","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            _newLicenseID = newLicense.LicenseID;
            MessageBox.Show("License Replaced successfully");
            lblApplicationID.Text=newLicense.ApplicationID.ToString();
            lblReplacedApplicationID.Text=_newLicenseID.ToString();
            ctrLicenseInfoWithFilter1.FilterEnabled = false;
            btnReplacement.Enabled = false;
            lnkLicenseInfo.Enabled = true;
        }
        private void rblostLicense_CheckedChanged(object sender, EventArgs e)
        {
            if(rblostLicense.Checked) 
                lblFees.Text= clsApplicationTypes.FindApplicationType(_GetApplicationTypeID()).ApplicationFees.ToString();
        }
        private void rdLDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            if(rdLDamagedLicense.Checked)
                lblFees.Text = clsApplicationTypes.FindApplicationType(_GetApplicationTypeID()).ApplicationFees.ToString();

        }
        private void lnkLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frmLicenseInfo = new frmLicenseInfo(_newLicenseID);
            frmLicenseInfo.ShowDialog();
        }
    }
}
