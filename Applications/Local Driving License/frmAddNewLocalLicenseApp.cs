using DVLD.Classes;
using DVLD_BuisnessLayer;
using Guna.UI2.Designer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace People_Management
{
    public partial class frmAddNewLocalLicenseApp : Form
    {
        enum enMode { AddNew =0,Update=1};
        enMode mode;

        int _LocalDrivingLicenseApplicationID = -1;
        clsLDLApplication _localDrivingLicenseApplication;
        int _selectedPerson = -1;
        public frmAddNewLocalLicenseApp(int localDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            mode = enMode.Update;
        }
        public frmAddNewLocalLicenseApp()
        {
            InitializeComponent();
            mode=enMode.AddNew;
        }

        private void _FillcmbClasses()
        {
            DataTable dt = clsLicenseClasses.GetAllLicenseClasses();
            foreach (DataRow dataRow in dt.Rows)
            {
                cmbLicenseClasses.Items.Add(dataRow["ClassName"]);
            }
        }
        private void _LoadData()
        {
            ctrUserInfoWithFilter1.filterEnabled = false;
            _localDrivingLicenseApplication = clsLDLApplication.Find(_LocalDrivingLicenseApplicationID);

            if(_localDrivingLicenseApplication == null)
            {
                MessageBox.Show("No Application with id = " + _LocalDrivingLicenseApplicationID, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrUserInfoWithFilter1.LoadPersonInfo(_localDrivingLicenseApplication.ApplicantPersonID);
            lblApplicationID.Text = _localDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationFees.Text = _localDrivingLicenseApplication.ApplicationFees.ToString();
            lblApplicationDate.Text = clsFormat.DateToShort(_localDrivingLicenseApplication.ApplicationDate);
            lblCreatedBy.Text=_localDrivingLicenseApplication.CreatedByUserInfo.userName;
            cmbLicenseClasses.Text = _localDrivingLicenseApplication.LicenseClassInfo.ClassName;
        }
        private void _ResetDefaultValue()
        {

            _FillcmbClasses();

            if (mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Local Driving License Application";
                this.Text = "Add New Local Driving License Application";
                ctrUserInfoWithFilter1.filterEnabled = true;
                tabApplicationInfo.Enabled = false;
                _localDrivingLicenseApplication = new clsLDLApplication();

                cmbLicenseClasses.SelectedIndex = 2;
                lblApplicationDate.Text = DateTime.Now.ToShortDateString();
                lblApplicationFees.Text = clsApplicationTypes.FindApplicationType((int)clsApplication.enApplicationType.NewDrivingLicense).ApplicationFees.ToString();
                lblCreatedBy.Text = clsGlobal.CurrentUser.userName;
            }

            else
            {
                lblTitle.Text = "Update Application";
                this.Text = "Update Application";
                ctrUserInfoWithFilter1.filterEnabled = false;
                tabApplicationInfo.Enabled = true;
            }

        }
        private void frmAddNewLocalLicenseApp_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();

            if(mode==enMode.Update)
            _LoadData();  
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrUserInfoWithFilter1.PersonID == -1)
            {
                MessageBox.Show("Please select a person first","Not found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            tabCtrLDLApp.SelectedIndex = 1;
            tabCtrLDLApp.SelectedTab = tabApplicationInfo;
            tabApplicationInfo.Enabled = true;
        }

        private bool _SaveLDLApplication()
        {
            int LicenseClassID = clsLicenseClasses.Find(cmbLicenseClasses.Text).ClassID;
            int ActiveApplicationID = clsApplication.GetActiveApplicationIDForLicenseClass(_selectedPerson, clsApplication.enApplicationType.NewDrivingLicense, LicenseClassID);

            if (ActiveApplicationID != -1)
            {
                MessageBox.Show("Choose another class, this person already has an active application for this class", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            if (clsLicense.IsLicenseExistByPersonID(_selectedPerson, LicenseClassID))
            {
                MessageBox.Show("Person already have a license with the same applied class,Choose a different class", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            _localDrivingLicenseApplication.ApplicantPersonID = ctrUserInfoWithFilter1.PersonID;
            _localDrivingLicenseApplication.ApplicationDate = DateTime.Today;
            _localDrivingLicenseApplication.ApplicationStatus = clsApplication.enApplicationStatus.New;
            _localDrivingLicenseApplication.LastStatusDate = DateTime.Today;
            _localDrivingLicenseApplication.LicenseClassID = LicenseClassID;
            _localDrivingLicenseApplication.ApplicationTypeID = 1;
            _localDrivingLicenseApplication.ApplicationFees = Convert.ToDecimal(lblApplicationFees.Text);
            _localDrivingLicenseApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_localDrivingLicenseApplication.Save())
            {
                MessageBox.Show("Data Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTitle.Text = "Update Application";
                this.Text = "Update Application";
                mode = enMode.Update;
                lblApplicationID.Text = _localDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                return true;
            }
            else
                MessageBox.Show("Failed to save your application", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveLDLApplication();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrUserInfoWithFilter1_OnPersonSelected(int obj)
        {
            _selectedPerson = obj;
        }

        private void frmAddNewLocalLicenseApp_Activated(object sender, EventArgs e)
        {
            ctrUserInfoWithFilter1.FilterFocus();
        }
    }
}
