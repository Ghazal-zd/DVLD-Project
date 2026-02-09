using DVLD.Classes;
using DVLD_BuisnessLayer;
using People_Management.Properties;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace People_Management.Tests
{
    public partial class ctrScheduleTest : UserControl
    {
        enum enMode { AddNew = 1, Update = 2 }
        private enMode _mode;
        public enum enCreationMode { FirstTime = 1, RetakeTest = 2 }
        private enCreationMode _creationMode;

        clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;
        clsLDLApplication localDrivingLicenseApplication;
        int _localDrivingLicenseApplicationID = -1;
        clsTestAppointment _TestAppointment;
        int _AppointmentID;
        public clsTestTypes.enTestType TestTypeID
        {
            set
            {
                _TestTypeID = value;
                switch (_TestTypeID)
                {
                    case clsTestTypes.enTestType.VisionTest:
                        {
                            guna2PictureBox1.Image = Resources.Screenshot_2025_09_04_181224;
                            lblTitle.Text = "Schedule Vision Test";
                            break;
                        }
                    case clsTestTypes.enTestType.WrittenTest:
                        {
                            guna2PictureBox1.Image = Resources.IngWrittenTest;
                            lblTitle.Text = "Schedule Written Test";
                            break;
                        }
                    case clsTestTypes.enTestType.PracticalTest:
                        {
                            guna2PictureBox1.Image = Resources.Screenshot_2025_09_04_181224;
                            lblTitle.Text = "Schedule Practical Test";
                            break;
                        }
                }
            }
            get
            {
                return _TestTypeID;

            }
        }

        private bool _RetakeTestEnabled;
        public bool RetakeTestEnabled
        {
            set
            {
                _RetakeTestEnabled = value;
                pnlRetakeInfo.Enabled = _RetakeTestEnabled;
            }
            get
            {
                return _RetakeTestEnabled;
            }
        }
        public ctrScheduleTest()
        {
            InitializeComponent();
        }
        public void ResetDefaultValues()
        {
            lblDLApplicationID.Text = "???";
            lblClass.Text = "???";
            lblFees.Text = "0";
            lblPersonName.Text = "???";
            lblTerial.Text = "0";
            dtAppointment.Value = DateTime.Now;
            lblTotalFees.Text = "0";
            lblRTakeAppID.Text = "???";
            lblRAppFees.Text = "0";
        }
        public bool _LoadTestAppointmentInfo()
        {
            _TestAppointment = clsTestAppointment.Find(_AppointmentID);
            if (_TestAppointment == null)
            {
                MessageBox.Show("No test appointment with id = " + _localDrivingLicenseApplicationID, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSaveAppointment.Enabled = false;
                return false;
            }

            lblFees.Text = _TestAppointment.PaidFees.ToString();

            if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
                dtAppointment.MinDate = DateTime.Now;
            else
                dtAppointment.MinDate = _TestAppointment.AppointmentDate;

            dtAppointment.Value = _TestAppointment.AppointmentDate;

            if (_TestAppointment.RetakeTestApplicationID == -1)
            {
                lblRAppFees.Text = "0";
                lblRTakeAppID.Text = "N/A";
            }

            else
            {
                lblRAppFees.Text = _TestAppointment.RetakeTestApplicationInfo.ApplicationFees.ToString();
                pnlRetakeInfo.Enabled = true;
                lblTitle.Text = "Schedule Retake Test";
                lblRTakeAppID.Text = _TestAppointment.RetakeTestApplicationID.ToString();
            }
            return true;

        }
        private bool _HandleActiveTestAppointmentConstraint()
        {
            if (_mode == enMode.AddNew && clsLDLApplication.IsThereAnActiveScheduledTest(_localDrivingLicenseApplicationID, _TestTypeID))
            {
                btnSaveAppointment.Enabled = false;
                dtAppointment.Enabled = false;
                return false;
            }

            return true;
        }
        private bool _HandleAppointmentLockedConstraint()
        {
          
            if (_TestAppointment.isLocked)
            {
                dtAppointment.Enabled = false;
                btnSaveAppointment.Enabled = false;
                return false;

            }
            else
                return true;
        }
        private bool _HandlePreviousTestConstraint()
        {

            switch (TestTypeID)
            {
                case clsTestTypes.enTestType.VisionTest:
                    return true;

                case clsTestTypes.enTestType.WrittenTest:
                    if (!localDrivingLicenseApplication.DoesPassTestType(clsTestTypes.enTestType.VisionTest))
                    {

                        btnSaveAppointment.Enabled = false;
                        dtAppointment.Enabled = false;
                        return false;
                    }
                    else
                    {
                        btnSaveAppointment.Enabled = true;
                        dtAppointment.Enabled = true;
                    }
                    return true;

                case clsTestTypes.enTestType.PracticalTest:


                    if (!localDrivingLicenseApplication.DoesPassTestType(clsTestTypes.enTestType.WrittenTest))
                    {
                        btnSaveAppointment.Enabled = false;
                        dtAppointment.Enabled = false;
                        return false;
                    }
                    else
                    {
                        btnSaveAppointment.Enabled = true;
                        dtAppointment.Enabled = true;
                    }


                    return true;

            }
            return true;

        }
        public void LoadInfo(int localDrivingLicenseApplicationID, int appointmentID)
        {
            if (appointmentID == -1)
            {
                _mode = enMode.AddNew;
            }
            else
            {
                _mode = enMode.Update;
            }

            _localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            _AppointmentID = appointmentID;
            localDrivingLicenseApplication = clsLDLApplication.Find(_localDrivingLicenseApplicationID);

            if (localDrivingLicenseApplication == null)
            {
                MessageBox.Show("No application with id = " + _localDrivingLicenseApplicationID, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSaveAppointment.Enabled = false;
                return;
            }

            if (localDrivingLicenseApplication.DoesAttendTestType(_TestTypeID))
                _creationMode = enCreationMode.RetakeTest;
            else
                _creationMode = enCreationMode.FirstTime;

            if (_creationMode == enCreationMode.RetakeTest)
            {
                lblTitle.Text = "Schedule Retake Test";
                pnlRetakeInfo.Enabled = true;
                lblRAppFees.Text = clsApplicationTypes.FindApplicationType((int)clsApplication.enApplicationType.RetakeTest).ApplicationFees.ToString();
                lblRTakeAppID.Text = "0";
            }
            else
            {
                lblTitle.Text = "Schedule Test";
                pnlRetakeInfo.Enabled = false;
                lblRAppFees.Text = "0";
                lblRTakeAppID.Text = "N/A";
            }
            lblDLApplicationID.Text = _localDrivingLicenseApplicationID.ToString();
            lblClass.Text = localDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lblFees.Text = clsTestTypes.FindTestType(_TestTypeID).ToString();
            lblPersonName.Text = localDrivingLicenseApplication.PersonInfo.FullName;
            lblTerial.Text = localDrivingLicenseApplication.TotalTrialsPerTest(TestTypeID).ToString();

            if (_mode == enMode.AddNew)
            {
                lblFees.Text = clsTestTypes.FindTestType(_TestTypeID).TestTypeFees.ToString();
                _TestAppointment = new clsTestAppointment();
                lblRAppFees.Text = "0";
                lblRTakeAppID.Text = "N/A";
            }
            else
            {
                if (!_LoadTestAppointmentInfo())
                    return;
            }
            dtAppointment.MinDate = DateTime.Now;
            dtAppointment.Value = DateTime.Now;

            lblTotalFees.Text = (Convert.ToSingle(lblFees.Text) + Convert.ToSingle(lblRAppFees.Text)).ToString();

            if (!_HandleActiveTestAppointmentConstraint())
                return;

            if (!_HandleAppointmentLockedConstraint())
                return;

            if (!_HandlePreviousTestConstraint())
                return;

        }
        private bool HandleRetakeTest()
        {
            if (_creationMode == enCreationMode.RetakeTest)
            {
                clsApplication application = new clsApplication();

                application.ApplicantPersonID = localDrivingLicenseApplication.ApplicantPersonID;
                application.ApplicationDate = DateTime.Now;
                application.ApplicationTypeID = (int)clsApplication.enApplicationType.RetakeTest;
                application.ApplicationFees = clsApplicationTypes.FindApplicationType((int)clsApplication.enApplicationType.RetakeTest).ApplicationFees;
                application.ApplicationStatus = clsApplication.enApplicationStatus.New;
                application.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                application.LastStatusDate = DateTime.Now;

                if (!application.Save())
                {
                    _TestAppointment.RetakeTestApplicationID = -1;
                    MessageBox.Show("Something went wrong!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _TestAppointment.RetakeTestApplicationID = application.ApplicationID;
                lblRTakeAppID.Text = _TestAppointment.RetakeTestApplicationID.ToString();
            }
            else _TestAppointment.RetakeTestApplicationID = -1;
            return true;
        }
        private void btnSaveAppointment_Click(object sender, EventArgs e)
        {
            if (!HandleRetakeTest())
                return;

            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.LocalDrivingLicenseApplicationID = localDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
            _TestAppointment.AppointmentDate = dtAppointment.Value;
            _TestAppointment.PaidFees = Convert.ToDecimal(lblFees.Text);
            _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (_TestAppointment.Save())
            {
                _mode = enMode.Update;
                MessageBox.Show("Appointment Created Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSaveAppointment.Enabled = false;
            }

        }

        private void ctrScheduleTest_Load(object sender, EventArgs e)
        {

        }
    }
}
