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
using System.Windows.Forms;

namespace People_Management
{
    public partial class ctrDriverLicenses : UserControl
    {
        int _DriverID = -1;
        clsDriver _Driver;
        DataTable _InternationalLicensesDT;
        DataTable _LocalDrivingLicensesDT;
        public ctrDriverLicenses()
        {
            InitializeComponent();
        }

        public void LoadDriverLicensesHistory(int personID)
        {
            dgvLocalLicensesHistory.DataSource = clsLicense.GetAllLicenseForPerson(personID);
            dgvInternationalLicenses.DataSource = clsLicense.GetInternationalLicenseForPerson(personID);
        }
        private void _LoadInternationalLicenses()
        {
            _InternationalLicensesDT=clsDriver.GetInternationalLicenses(_DriverID);
            dgvInternationalLicenses.DataSource = _InternationalLicensesDT;
            if (dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
                dgvInternationalLicenses.Columns[0].Width = 100;

                dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicenses.Columns[1].Width = 110;
                
                dgvInternationalLicenses.Columns[2].HeaderText = "L.License ID";
                dgvInternationalLicenses.Columns[2].Width = 100;
                
                dgvInternationalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[3].Width = 150;
                 
                dgvInternationalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[4].Width = 150;
                 
                dgvInternationalLicenses.Columns[5].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[5].Width = 100;
            }
        }
        private void _LoadLocalDrivingLicenses()
        {
            _LocalDrivingLicensesDT = clsDriver.GetLicenses(_DriverID);
            dgvLocalLicensesHistory.DataSource = _LocalDrivingLicensesDT;
            if (dgvLocalLicensesHistory.Rows.Count > 0)
            {
                dgvLocalLicensesHistory.Columns[0].HeaderText = "Lic.ID";
                dgvLocalLicensesHistory.Columns[0].Width = 110;

                dgvLocalLicensesHistory.Columns[1].HeaderText = "App.ID";
                dgvLocalLicensesHistory.Columns[1].Width = 110;

                dgvLocalLicensesHistory.Columns[2].HeaderText = "Class Name";
                dgvLocalLicensesHistory.Columns[2].Width = 270;

                dgvLocalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicensesHistory.Columns[3].Width = 170;

                dgvLocalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicensesHistory.Columns[4].Width = 170;

                dgvLocalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvLocalLicensesHistory.Columns[5].Width = 110;
            }
        }

        public void LoadInfo(int DriverID)
        {
            _Driver = clsDriver.Find(DriverID);
            if (_Driver == null)
            {
                MessageBox.Show("No driver with id = " + DriverID, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _DriverID = DriverID;
            _LoadInternationalLicenses();
            _LoadLocalDrivingLicenses();
        }
        public void LoadInfoByPerson(int PersonID)
        {
            _Driver = clsDriver.FindByPersonID(PersonID);
            if (_Driver == null)
            {
                MessageBox.Show("No driver linked with person id = " + PersonID, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _DriverID = _Driver.DriverID;

            _LoadInternationalLicenses();
            _LoadLocalDrivingLicenses();
        }

        public void Clear()
        {
            _LocalDrivingLicensesDT = null;
            _InternationalLicensesDT = null;

        }
        private void ctrDriverLicenses_Load(object sender, EventArgs e)
        {

        }

        private void showLienseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmLicenseInfo frmLicenseInfo=new frmLicenseInfo(clsLicense.Find((int)dgvLocalLicensesHistory.CurrentRow.Cells[0].Value).LicenseID);
            frmLicenseInfo.ShowDialog();
        }
    }
}
