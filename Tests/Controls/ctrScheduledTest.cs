using DVLD.Classes;
using DVLD_BuisnessLayer;
using People_Management.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People_Management.Tests
{
    public partial class ctrScheduledTest : UserControl
    {
        int _TestID = -1;
        int _TestAppointmentID = -1;
        public int TestAppointmentID
        {
            get { return _TestAppointmentID; } set { _TestAppointmentID = value; }
        }
        clsTestAppointment _testAppointment;
        int _LocalDrivingLicenseApplicationID = -1;
        clsLDLApplication _localDrivingLicenseApplication;
        public int TestID
        {
            set { _TestID = value; }
            get { return _TestID; }
        }
        private clsTestTypes.enTestType _TestTypeID=clsTestTypes.enTestType.VisionTest;
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
                            break;
                        }
                    case clsTestTypes.enTestType.WrittenTest:
                        {
                            guna2PictureBox1.Image = Resources.car1;
                            break;
                        }
                    case clsTestTypes.enTestType.PracticalTest:
                        {
                            guna2PictureBox1.Image = Resources.Screenshot_2025_09_04_181224;
                            break;
                        }
                }
            }
            get
            {
                return _TestTypeID;
            }
        }

        public ctrScheduledTest()
        {
            InitializeComponent();
        }


        public void LoadTestAppointmentDetails(int TestAppointmentID)
        {
            _TestAppointmentID = TestAppointmentID;
            _testAppointment = clsTestAppointment.Find(TestAppointmentID);

            if (_testAppointment == null)
            {
                MessageBox.Show("No appointment with ID = " + _TestAppointmentID, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LocalDrivingLicenseApplicationID =_testAppointment.LocalDrivingLicenseApplicationID;
            _localDrivingLicenseApplication = clsLDLApplication.Find(_LocalDrivingLicenseApplicationID);
            if (_localDrivingLicenseApplication == null)
            {
                MessageBox.Show("No application with ID = " + _LocalDrivingLicenseApplicationID, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblDLApplicationID.Text = _LocalDrivingLicenseApplicationID.ToString();
            lblClass.Text=_localDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lblDate.Text = clsFormat.DateToShort(_testAppointment.AppointmentDate);
            lblPersonName.Text = _localDrivingLicenseApplication.FullName;
            lblTerial.Text = _localDrivingLicenseApplication.TotalTrialsPerTest(_TestTypeID).ToString();
            lblFees.Text =_testAppointment.PaidFees.ToString();
            lblTestID.Text =(_testAppointment.TestID==-1) ? "Not Taken Yet" : _testAppointment.TestID.ToString();
           
        }
        private void ctrScheduledTest_Load(object sender, EventArgs e)
        {

        }

        private void lblDLApplicationID_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
