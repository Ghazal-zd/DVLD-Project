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
    public partial class frmRenewDriningLicense : Form
    {
        clsLicense license;
        int _newLicenseID;
        public frmRenewDriningLicense()
        {
            InitializeComponent();
        }
        private void lnkLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frmLicenseInfo = new frmLicenseInfo(_newLicenseID);
            frmLicenseInfo.ShowDialog();
        }
        private void frmRenewDriningLicense_Load(object sender, EventArgs e)
        {
            this.Text = "Renew Licenses";
            ctrLicenseInfoWithFilter1.setFocus();

            lblApplicationDate.Text=clsFormat.DateToShort(DateTime.Now);
            lblIssueDate.Text = lblApplicationDate.Text;
            lblExeprationDate.Text= DateTime.Today.AddYears(1).ToString();

            lblFees.Text = clsApplicationTypes.FindApplicationType((int)clsApplication.enApplicationType.RenewDrivingLicense).ApplicationFees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.userName;
        }
        private void lnkLblLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frmLicenseHistory = new frmLicenseHistory(license.DriverInfo.PersonID);
            frmLicenseHistory.ShowDialog();
        }
        private void btnRenew_Click(object sender, EventArgs e)
        {
            clsLicense newLicense = license.RenewLicense(txtNotes.Text.Trim(),clsGlobal.CurrentUser.UserID);
            if (newLicense == null)
            {
                MessageBox.Show("Faild to renew the license","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            lblRenewAppID.Text = newLicense.ApplicationID.ToString();
            _newLicenseID = newLicense.LicenseID;
            lblRenewLicenseID.Text = _newLicenseID.ToString();

            MessageBox.Show("License Renewed Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRenew.Enabled = false;
            lnkLicenseInfo.Enabled = true;
            ctrLicenseInfoWithFilter1.FilterEnabled = false;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ctrLicenseInfoWithFilter1_OnSearchCompleted(int obj)
        {
            int LicenseID = obj;

            lblOldLicenseID.Text = LicenseID.ToString();
            lnkLblLicenseHistory.Enabled = (LicenseID != -1);

            if (LicenseID == -1)
            {
                return;
            }

            license = ctrLicenseInfoWithFilter1.selectedLicense;
            lblExeprationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(license.LicenseClassInfo.DefaultValidityLength));
            lblLicenseFees.Text = license.LicenseClassInfo.ClassFees.ToString();
            lblTotalFees.Text = (Convert.ToDecimal(lblFees.Text) + Convert.ToDecimal(lblLicenseFees.Text)).ToString();
            txtNotes.Text = license.Notes.ToString();

            if (!license.IsLicenseExpired())
            {
                MessageBox.Show("Selected license is not expired yet,it will expire on " + license.ExpirationDate.ToString().Split(' ')[0] + ".", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!license.IsActive)
            {
                MessageBox.Show("Selected license is non active , you cannot renew it.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnRenew.Enabled = true;

        }
    }
}