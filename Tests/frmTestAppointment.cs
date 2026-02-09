using DVLD_BuisnessLayer;
using People_Management.Properties;
using System;
using System.Reflection;
using System.Security;
using System.Windows.Forms;

namespace People_Management
{
    public partial class frmTestAppointment : Form
    {
        int _localDrivingLicenseApplicationID = -1;
        clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;
        public frmTestAppointment(int applicationID,clsTestTypes.enTestType testID)
        {
            InitializeComponent();
            _localDrivingLicenseApplicationID = applicationID;
            _TestTypeID = testID;
        }

        private void _LoadTestTypeImages()
        {
            switch (_TestTypeID)
            {
                case clsTestTypes.enTestType.VisionTest:
                    {
                        picTestType.Image = Resources.Screenshot_2025_09_04_181224;
                        lblTitle.Text = "Schedule Vision Test";
                        break;
                    }
                case clsTestTypes.enTestType.WrittenTest:
                    {
                        picTestType.Image = Resources.IngWrittenTest;
                        lblTitle.Text = "Schedule Written Test";
                        break;
                    }

                case clsTestTypes.enTestType.PracticalTest:
                    {
                        picTestType.Image = Resources.car1;
                        lblTitle.Text = "Schedule Street Test";
                        break;
                    }
            }
        }
        private void frmTestAppointment_Load(object sender, EventArgs e)
        {
            this.Text = "Test Appointments";
            ctrDrivingLicenseInfo1.loadLocalDrivingLicenseApplicationInfo(_localDrivingLicenseApplicationID);
            dgvAppointments.DataSource = clsTestAppointment.GetApplicationTestAppointmentPerTestType(_localDrivingLicenseApplicationID,_TestTypeID);
            _LoadTestTypeImages();
        }
        private void ctrDrivingLicenseInfo1_Load(object sender, EventArgs e)
        {

        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            clsLDLApplication localDrivingLicenseApplication = clsLDLApplication.Find(_localDrivingLicenseApplicationID);

            if (localDrivingLicenseApplication.IsThereAnActiveScheduledTest(_TestTypeID))
            {
                MessageBox.Show("This person already has an active appointment for this test type", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsTests LastTest = localDrivingLicenseApplication.GetLastTestPerTestType(_TestTypeID);


            if (LastTest == null)
            {
                frmAddNewTestAppointment frm1 = new frmAddNewTestAppointment(_TestTypeID, _localDrivingLicenseApplicationID);
                frm1.ShowDialog();
                frmTestAppointment_Load(null, null);
                return;
            }
            if (LastTest.TestResult == true)
            {
                MessageBox.Show("This person already passed this testType before, you can only retake failed testType", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmAddNewTestAppointment frmAddNewTestAppointment = new frmAddNewTestAppointment(_TestTypeID, LastTest.TestAppointmentInfo.LocalDrivingLicenseApplicationID);
            frmAddNewTestAppointment.ShowDialog();
            frmTestAppointment_Load(null, null);
            return;
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewTestAppointment frmAddNewTestAppointment = new frmAddNewTestAppointment(_TestTypeID, _localDrivingLicenseApplicationID, (int)dgvAppointments.CurrentRow.Cells[0].Value);
            frmAddNewTestAppointment.ShowDialog();
            frmTestAppointment_Load(null, null);
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeTest frmTakeTest = new frmTakeTest(_TestTypeID, (int)dgvAppointments.CurrentRow.Cells[0].Value);
            frmTakeTest.ShowDialog();
            frmTestAppointment_Load(null, null);
        }

        private void guna2ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (clsTestAppointment.Find((int)dgvAppointments.CurrentRow.Cells[0].Value).isLocked)
            {
                takeTestToolStripMenuItem.Enabled = false;
                return;
            }
            takeTestToolStripMenuItem.Enabled = true;

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        //private void guna2ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (clsTestAppointment.Find((int)dgvAppointments.CurrentRow.Cells[0].Value).isLocked)
        //    {
        //        takeTestToolStripMenuItem.Enabled = false;
        //    }
        //}
    }
}
