using DVLD.Classes;
using DVLD_BuisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace People_Management
{
    public partial class frmReleaseLicense : Form
    {
        clsLicense license;
        int _SelectedLicenseID = -1;
        public frmReleaseLicense()
        {
            InitializeComponent();
        }
         public frmReleaseLicense(int LicenseID)
        {
            InitializeComponent();
            _SelectedLicenseID = LicenseID;
            ctrLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicenseID);
            ctrLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private void ctrLicenseInfoWithFilter1_OnSearchCompleted(int obj)
        {
            license = clsLicense.Find(obj);
            _SelectedLicenseID = obj;

            lnkLblLicenseHistory.Enabled = (_SelectedLicenseID != -1);
            if (_SelectedLicenseID == -1) return;
            //if (!_license.IsActive)
            //{

            //    MessageBox.Show("Selected _license is not active, choose an active _license.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (!clsDetainLicense.IsDetained(_SelectedLicenseID))
            {
                MessageBox.Show("Selected license is not detained,choose another one.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDetainID.Text = license.DetainedInfo.DetainID.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.userName;
            lblApplicationFees.Text = clsApplicationTypes.FindApplicationType((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicense).ApplicationFees.ToString();
            lblLicenseID.Text = license.LicenseID.ToString();
            lblDetainDate.Text = clsFormat.DateToShort(license.DetainedInfo.DetainDate);
            lblFineFees.Text = license.DetainedInfo.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToDecimal(lblApplicationFees.Text) + Convert.ToDecimal(lblFineFees.Text)).ToString();
            btnDetain.Enabled = true;

        }

        private void frmReleaseLicense_Load(object sender, EventArgs e)
        {
            this.Text = "Release Detained Licenses";
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release selected license? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ApplicationID = -1;

            bool isReleased = license.ReleaseDetainLicense(ref ApplicationID, clsGlobal.CurrentUser.UserID);
            lblApplicationID.Text = ApplicationID.ToString();

            if (!isReleased)
            {
                MessageBox.Show(" Failed to Release selected license ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (!license.DetainedInfo.ReleaseDetainedLicense(clsGlobal.CurrentUser.UserID, ApplicationID)) return;

            MessageBox.Show("Selected license Released successfully ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lnkLicenseInfo.Enabled = true;
            btnDetain.Enabled = false;
            ctrLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private void lnkLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frmLicenseInfo = new frmLicenseInfo(license.LicenseID);
            frmLicenseInfo.ShowDialog();
        }

        private void lnkLblLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frmLicenseHistory = new frmLicenseHistory(license.DriverInfo.PersonID);
            frmLicenseHistory.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
