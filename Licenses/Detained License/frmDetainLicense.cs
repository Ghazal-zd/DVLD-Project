using DVLD.Classes;
using DVLD_BuisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People_Management
{
    public partial class frmDetainLicense : Form
    {
        clsLicense license;
        int DetainedLicenseID = -1;
        public frmDetainLicense()
        {
            InitializeComponent();
        }
        private void ctrLicenseInfoWithFilter1_OnSearchCompleted(int obj)
        {
            int SelectedLicenseID = obj;
            license = clsLicense.Find(obj);

            lblLicenseID.Text = SelectedLicenseID.ToString();
            lnkLblLicenseHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)
            {
                return;
            }

            if (clsDetainLicense.IsDetained(SelectedLicenseID))
            {
                MessageBox.Show("Selected license is already detained.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnDetain.Enabled = true;
            txtFineFees.Enabled = true;
            txtFineFees.Focus();
        }

        private void lnkLblLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frmLicenseHistory = new frmLicenseHistory(license.DriverInfo.PersonID);
            frmLicenseHistory.ShowDialog();
        }

        private void lnkLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frmLicenseInfo = new frmLicenseInfo(DetainedLicenseID);
            frmLicenseInfo.ShowDialog();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Are you sure you want to detain selected license? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DetainedLicenseID = license.Detain(Convert.ToDecimal(txtFineFees.Text.Trim()), clsGlobal.CurrentUser.UserID);

            if (DetainedLicenseID == -1)
            {
                return;
            }

            MessageBox.Show("Selected license detained successfully ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblDetainID.Text = DetainedLicenseID.ToString();
            btnDetain.Enabled = false;
            txtFineFees.Enabled = false;
            lnkLicenseInfo.Enabled = true;
            ctrLicenseInfoWithFilter1.Enabled = false;

        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            this.Text = "Detain License";
            ctrLicenseInfoWithFilter1.setFocus();
            lblCreatedBy.Text = clsGlobal.CurrentUser.userName;            
            lblDetainDate.Text = DateTime.Today.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Fine fees is required");
            }
            else
            {
                errorProvider1.SetError(txtFineFees, null);
            }
        }

        private void ctrLicenseInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }
    }
}
