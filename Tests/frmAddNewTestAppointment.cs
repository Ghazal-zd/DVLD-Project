using DVLD.Classes;
using DVLD_BuisnessLayer;
using Guna.UI2.WinForms;
using People_Management.Properties;
using System;
using System.Windows.Forms;

namespace People_Management
{
    public partial class frmAddNewTestAppointment : Form
    {
        clsTestAppointment testAppointment;
        enum enMode { AddNew = 1, Update = 2 }
        private enMode _mode;
        
        clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;
        clsLDLApplication localDrivingLicenseApplication;
        int _localDrivingLicenseApplicationID = -1;
        clsTestAppointment _TestAppointment;
        int _AppointmentID = -1;
        //int testTypeID = -1;
        //int LicenseID = -1;
        public clsTestTypes.enTestType TestTypeID
        {
            get { return _TestTypeID; }
            set
            {
                _TestTypeID = value;
            }
        }
        public frmAddNewTestAppointment(clsTestTypes.enTestType testTypeID,int localDrivingLicenseApplicationID,int appointmentID =-1)
        {
            InitializeComponent();

            this.TestTypeID = testTypeID;
            this._localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this._AppointmentID = appointmentID;
        }
        private void frmAddNewTestAppointment_Load(object sender, EventArgs e)
        {
            ctrScheduleTest1.TestTypeID = TestTypeID;
            ctrScheduleTest1.LoadInfo(_localDrivingLicenseApplicationID, _AppointmentID);
        }
  
        private void ctrScheduleTest1_Load(object sender, EventArgs e)
        {
        }
    }
}
