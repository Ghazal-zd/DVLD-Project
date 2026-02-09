using DVLD.Classes;
using DVLD_BuisnessLayer;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace People_Management
{
    public partial class Form1 : Form
    {
        frmLogin _frmLogin;
        public Form1(frmLogin frmLogin)
        {
            InitializeComponent();
            _frmLogin = frmLogin;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeopleList frmManagePeople = new frmPeopleList();
            frmManagePeople.ShowDialog();
        }
        
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmLogin.Show();
            this.Close();
        }

        private void currentUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUserDetails = new frmUserDetails(clsGlobal.CurrentUser.UserID);
            frmUserDetails.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frmChangePassword.ShowDialog();
        }
        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersList frmManageUsers = new frmUsersList();
            frmManageUsers.ShowDialog();
        }
        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm1 = new frmManageApplicationTypes();
            frm1.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frmManageTestTypes = new frmManageTestTypes();
            frmManageTestTypes.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewLocalLicenseApp frmAddNewLocalLicenseApplication =new frmAddNewLocalLicenseApp();
            frmAddNewLocalLicenseApplication.ShowDialog();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void localDrivinfgLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLocalLicenseApplication frmManageLocalLicenseApplication=new frmManageLocalLicenseApplication();
            frmManageLocalLicenseApplication.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrivers frmDrivers = new frmDrivers();   
            frmDrivers.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueInternationalLicense frm1 = new frmIssueInternationalLicense();
            frm1.ShowDialog();
        }

        private void internationalDrivingLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageInternationalApp frmManageInternationalApp = new frmManageInternationalApp();
            frmManageInternationalApp.ShowDialog(); 
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewDriningLicense frm = new frmRenewDriningLicense();  
            frm.ShowDialog();
        }

        private void replaceForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
        frmReplacementForDamagedLicense frmReplacementForDamagedLicense = new frmReplacementForDamagedLicense();
            frmReplacementForDamagedLicense.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void detainLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense frmDetainLicense= new frmDetainLicense();
            frmDetainLicense.ShowDialog();
        }

        private void releaseDetainLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frmReleaseLicense = new frmReleaseLicense();  
            frmReleaseLicense.ShowDialog();
        }

        private void manageDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDetainedLicenses frmManageDetainedLicenses=new frmManageDetainedLicenses();
            frmManageDetainedLicenses.Show();
        }
    }
}
