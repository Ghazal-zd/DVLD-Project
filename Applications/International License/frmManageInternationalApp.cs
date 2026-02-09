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
    public partial class frmManageInternationalApp : Form
    {
        DataTable _InternationalLicensesDT;
        public frmManageInternationalApp()
        {
            InitializeComponent();
        }

        private void frmManageInternationalApp_Load(object sender, EventArgs e)
        {
            _InternationalLicensesDT = clsInternationalLicense.GetAllInternationalLicenses();
            dgvInternationalLicenses.DataSource = _InternationalLicensesDT;

            cmbFilterAppsBy.SelectedIndex = 0;

            if (dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
                dgvInternationalLicenses.Columns[0].Width = 100;

                dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicenses.Columns[1].Width = 100;

                dgvInternationalLicenses.Columns[2].HeaderText = "Driver ID";
                dgvInternationalLicenses.Columns[2].Width = 100;

                dgvInternationalLicenses.Columns[3].HeaderText = "L.License ID";
                dgvInternationalLicenses.Columns[3].Width = 100;

                dgvInternationalLicenses.Columns[4].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[4].Width = 120;

                dgvInternationalLicenses.Columns[5].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[5].Width = 120;

                dgvInternationalLicenses.Columns[6].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[6].Width = 80;

                dgvInternationalLicenses.Columns[7].HeaderText = "Created By User_ID";
                dgvInternationalLicenses.Columns[7].Width = 100;
            }
        }

        private void licenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseInfo frmInternationalLicenseInfo = new frmInternationalLicenseInfo((int)dgvInternationalLicenses.CurrentRow.Cells[0].Value);
            frmInternationalLicenseInfo.ShowDialog();
        }

        private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDriver driver = clsDriver.Find((int)dgvInternationalLicenses.CurrentRow.Cells[0].Value);
            int personID = driver.PersonID;
            frmLicenseHistory frmLicenseHistory = new frmLicenseHistory(personID);
            frmLicenseHistory.ShowDialog();
        }

        private void btnIssueInternationalLicense_Click(object sender, EventArgs e)
        {
            frmIssueInternationalLicense frmIssueInternationalLicense=new frmIssueInternationalLicense();
            frmIssueInternationalLicense.ShowDialog();
        }

        private void cmbFilterAppsBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterAppsBy.Text == "Is Active")
            {
                txtFilterAppsBy.Visible = false;
                cmbIsActive.Visible = true;
                cmbIsActive.Focus();
                cmbIsActive.SelectedIndex = 0;
            }

            else
            {
                txtFilterAppsBy.Visible = (cmbFilterAppsBy.Text != "None");
                cmbIsActive.Visible = false;

                if (cmbIsActive.Text == "None")
                {
                    txtFilterAppsBy.Enabled = false;
                    //_InternationalLicensesDT.DefaultView.RowFilter = "";
                }
                else
                    txtFilterAppsBy.Enabled = true;

                txtFilterAppsBy.Text = "";
                txtFilterAppsBy.Focus();
            }
        }

        private void txtFilterAppsBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cmbFilterAppsBy.Text)
            {
                case "International License ID":
                    FilterColumn = "InternationalLicenseID";
                    break;
                case "Application ID":
                    {
                        FilterColumn = "ApplicationID";
                        break;
                    }
                    ;

                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Local License ID":
                    FilterColumn = "IssuedUsingLocalLicenseID";
                    break;

                case "Is Active":
                    FilterColumn = "IsActive";
                    break;


                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterAppsBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _InternationalLicensesDT.DefaultView.RowFilter = "";
                return;
            }



            _InternationalLicensesDT.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterAppsBy.Text.Trim());

        }

        private void cmbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cmbIsActive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _InternationalLicensesDT.DefaultView.RowFilter = "";
            else
                _InternationalLicensesDT.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDriver driver = clsDriver.Find((int)dgvInternationalLicenses.CurrentRow.Cells[0].Value);
            int personID = driver.PersonID;
            frmPersonDetails frmPersonDetails = new frmPersonDetails(personID);
            frmPersonDetails.ShowDialog();
        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void txtFilterAppsBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cmbFilterAppsBy.Text!="None" && cmbFilterAppsBy.Text != "Is Active")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
