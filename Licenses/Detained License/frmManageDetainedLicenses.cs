using DVLD_BuisnessLayer;
using System;
using System.ComponentModel; 
using System.Data;
using System.Windows.Forms;

namespace People_Management
{
    public partial class frmManageDetainedLicenses : Form
    {
        clsLicense _License;
        DataTable _DetainedLicensesDT;
        public frmManageDetainedLicenses()
        {
            InitializeComponent();
        }
    
        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            _DetainedLicensesDT = clsDetainLicense.GetDetainedLicenses();
            dgvDetainedLicenses.DataSource = _DetainedLicensesDT;
            cmbFilterDLicensesBy.SelectedIndex = 0;
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm2 = new frmPersonDetails(_License.DriverInfo.PersonID);
            frm2.ShowDialog();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseInfo frmLicenseInfo = new frmLicenseInfo(_License.LicenseID);

            frmLicenseInfo.ShowDialog();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            _License = clsLicense.Find((int)dgvDetainedLicenses.CurrentRow.Cells[1].Value);
            if(_License == null)
            {
                this.Close();
                return;
            }

            if (_License.DetainedInfo.IsReleased == true)
            {
                releaseDetainedLicenseToolStripMenuItem1.Enabled = false;
            }
            else
                releaseDetainedLicenseToolStripMenuItem1.Enabled = true;
        }
        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(_License.DriverInfo.PersonID);
            frm.ShowDialog();
            frmManageDetainedLicenses_Load(null, null);
        }

        private void releaseDetainedLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frm = new frmReleaseLicense(_License.LicenseID);
            frm.ShowDialog();
            frmManageDetainedLicenses_Load(null, null);
        }
        private void cmbFilterAppsBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterDLicensesBy.Text == "Is Released")
            {
                txtFilterDLicenseBy.Visible = false;
                cmbIsReleased.Visible = true;
                cmbIsReleased.Text = "All";
                cmbIsReleased.Focus();
            }

            else
            {

                txtFilterDLicenseBy.Visible = (cmbFilterDLicensesBy.Text != "None");
                cmbIsReleased.Visible = false;

                if (cmbFilterDLicensesBy.Text == "None")
                {
                    txtFilterDLicenseBy.Enabled = false;
                    //_dtDetainedLicenses.DefaultView.RowFilter = "";
                    //lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();
                }
                else
                    txtFilterDLicenseBy.Enabled = true;

                txtFilterDLicenseBy.Text = "";
                txtFilterDLicenseBy.Focus();
            }
        }
        private void txtFilterDLicenseBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = txtFilterDLicenseBy.Text.Trim();

            switch (cmbFilterDLicensesBy.Text)
            {
                case "Detain ID":

                    FilterColumn = "DetainID";
                    break;

                case "Is Released":

                    FilterColumn = "IsReleased";
                    break;


                case "National No.":
                    FilterColumn = "NationalNo";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Release Application ID":
                    FilterColumn = "ReleaseApplicationID";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }



            if (txtFilterDLicenseBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _DetainedLicensesDT.DefaultView.RowFilter = "";
                return;
            }


            if (FilterColumn == "DetainID" || FilterColumn == "ReleaseApplicationID")

                _DetainedLicensesDT.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterDLicenseBy.Text.Trim());
            else
                _DetainedLicensesDT.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterDLicenseBy.Text.Trim());


        }
        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense frmDetainLicense = new frmDetainLicense(); 
            frmDetainLicense.ShowDialog();
            frmManageDetainedLicenses_Load(null, null);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frmReleaseLicense = new frmReleaseLicense();
            frmReleaseLicense.ShowDialog();
            frmManageDetainedLicenses_Load(null, null);
        }
        private void cmbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsReleased";
            string FilterValue = cmbIsReleased.Text;

            switch (FilterValue)
            {
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
                default:
                    break;
            }


            if (FilterValue == "All")
                _DetainedLicensesDT.DefaultView.RowFilter = "";
            else
                _DetainedLicensesDT.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

        }

        private void txtFilterDLicenseBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterDLicensesBy.Text == "Detain ID" || cmbFilterDLicensesBy.Text == "Release Application ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
