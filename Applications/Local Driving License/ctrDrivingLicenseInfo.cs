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
    public partial class ctrDrivingLicenseInfo : UserControl
    {
        int _localDrivingApplicationID = -1;
        clsLDLApplication application;
        int _LicenseID = -1;
        public int localDrivingLicenseApplicationID
        {
            get { return _localDrivingApplicationID; }
        }

        public int basicApplicationID
        {
            get  { return ctrApplicationInfo1.basicApplicationID; }
        }

        public ctrDrivingLicenseInfo()
        {
            InitializeComponent();
        }

        private void _ResetDefaultValues()
        {
            _localDrivingApplicationID = -1;
            lblAppClass.Text = "???";
            lblDrivingLicenseID.Text = "???";
            lblPassedTest.Text = "???"; 
            ctrApplicationInfo1.ResetDefaultValues();
            llShowLicenseInfo.Enabled = false;
        }

        private void _FillLocalDrivingLicenseInfo()
        {
            _LicenseID =clsLicense.GetActiveLicenseIDByPersonID(application.ApplicantPersonID,application.LicenseClassID);
            llShowLicenseInfo.Enabled = (_LicenseID != -1);

            _localDrivingApplicationID = application.LocalDrivingLicenseApplicationID;
            lblDrivingLicenseID.Text = _localDrivingApplicationID.ToString();
            lblAppClass.Text = application.LicenseClassInfo.ClassName;
            lblPassedTest.Text = clsTests.GetPassedTestCount(_localDrivingApplicationID).ToString() + "/3";
            ctrApplicationInfo1.LoadBasicApplicationInfo(application.ApplicationID);
        }
        public void loadLocalDrivingLicenseApplicationInfo(int localDrivingApplicationID)
        {
            application = clsLDLApplication.Find(localDrivingApplicationID);
            if(application == null)
            {
                _ResetDefaultValues();
                return;
            }
            _FillLocalDrivingLicenseInfo();
            
        }
        public void loadLocalDrivingLicenseApplicationInfoByApplicationID(int applicationID)
        {
            application = clsLDLApplication.FindLDLApplicationByApplicationID(applicationID);
            if (application == null)
            {
                _ResetDefaultValues();
                return;
            }
            _FillLocalDrivingLicenseInfo();
        }

        private void lnkLblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frmLicenseInfo = new frmLicenseInfo(_LicenseID);
            frmLicenseInfo.ShowDialog();
        }

        private void ctrDrivingLicenseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
