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
    public partial class frmDrivers : Form
    {
        DataTable _DriversDT;
        public frmDrivers()
        {
            InitializeComponent();
        }

        private void frmDrivers_Load(object sender, EventArgs e)
        {
            cmbFilterDrivers.Text = "None";
            _DriversDT = clsDriver.GetAllDrivers();
            dgvDrivers.DataSource = _DriversDT;
            if (dgvDrivers.Rows.Count > 0)
            {
                dgvDrivers.Columns[0].HeaderText = "Driver ID";
                dgvDrivers.Columns[0].Width = 100;

                dgvDrivers.Columns[1].HeaderText = "Person ID";
                dgvDrivers.Columns[1].Width = 150;

                dgvDrivers.Columns[2].HeaderText = "National No";
                dgvDrivers.Columns[2].Width = 100;

                dgvDrivers.Columns[3].HeaderText = "Full Name";
                dgvDrivers.Columns[3].Width = 170;

                dgvDrivers.Columns[4].HeaderText = "Status";
                dgvDrivers.Columns[4].Width = 100;

                dgvDrivers.Columns[5].HeaderText = "NumberOfActiveLicenses";
                dgvDrivers.Columns[5].Width = 100;
            }
        }

        private void cmbFilterDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterDriversBy.Visible = !(cmbFilterDrivers.Text == "None");
        }

        private void txtFilterDriversBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterDrivers.Text == "DriverID" && cmbFilterDrivers.Text == "PersonID")
            {
                e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
            }
        }

        private void txtFilterDriversBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cmbFilterDrivers.Text)
            {
                case "Driver ID":
                    {

                        FilterColumn = "DriverID";
                        break;
                    } 
                case "Person ID":
                    {

                        FilterColumn = "PersonID";
                        break;
                    }
                case "National No":
                    {
                        FilterColumn = "NationalNo";
                        break;
                    }
                case "Full Name":
                    {

                        FilterColumn = "FullName";
                        break;
                    }
                case "Status":
                    {
                        FilterColumn = "Status";
                        break;
                    }             
                default:
                    {
                        FilterColumn = "None";
                        break;
                    }
            }

            if (FilterColumn == "None" || txtFilterDriversBy.Text == "")
            {
                _DriversDT.DefaultView.RowFilter = "";
                return;
            }

            if (FilterColumn == "DriverID" || FilterColumn == "PersonID")
                _DriversDT.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterDriversBy.Text.Trim());
            else
                _DriversDT.DefaultView.RowFilter = string.Format("[{0}] like '{1}%' ", FilterColumn, txtFilterDriversBy.Text.Trim());

        }

        private void issuwInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frmPersonDetails=new frmPersonDetails((int)dgvDrivers.CurrentRow.Cells[1].Value);
            frmPersonDetails.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frmLicenseHistory=new frmLicenseHistory((int)dgvDrivers.CurrentRow.Cells[1].Value);
            frmLicenseHistory.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}