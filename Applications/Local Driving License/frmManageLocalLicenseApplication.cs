using DVLD_BuisnessLayer;
using People_Management.Applications.Local_Driving_License;
using System;
using System.ComponentModel;
using System.Data;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace People_Management
{
    public partial class frmManageLocalLicenseApplication : Form
    {
        DataTable ApplicationsDT;
        clsLDLApplication LocalDrivingLicenseApplication;
        public frmManageLocalLicenseApplication()
        {
            InitializeComponent();
        }
        private void frmManageLocalLicenseApplication_Load(object sender, EventArgs e)
        {
            this.Text = "Local Driving License Application";
            ApplicationsDT = clsLDLApplication.GetAllLocalDrivingLicenseApplications();
            dgvLDLApplications.DataSource = ApplicationsDT;

            if (dgvLDLApplications.Rows.Count > 0)
            {
                dgvLDLApplications.Columns[0].HeaderText = "L.D.L.App ID";
                dgvLDLApplications.Columns[0].Width = 100;

                dgvLDLApplications.Columns[1].HeaderText = "Class Name";
                dgvLDLApplications.Columns[1].Width = 150;

                dgvLDLApplications.Columns[2].HeaderText = "National No";
                dgvLDLApplications.Columns[2].Width = 100;

                dgvLDLApplications.Columns[3].HeaderText = "Full Name";
                dgvLDLApplications.Columns[3].Width = 150;

                dgvLDLApplications.Columns[4].HeaderText = "Status";
                dgvLDLApplications.Columns[4].Width = 100;
            }
            cmbFilterAppsBy.Text = "None";
        }
        private void txtFilterUsersBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cmbFilterAppsBy.Text)
            {
                case "L.D.L.App ID":
                    {

                        FilterColumn = "LocalDrivingLicenseApplicationID";
                        break;
                    }
                case "ClassName":
                    {
                        FilterColumn = "ClassName";
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

            if(FilterColumn == "None" || txtFilterAppsBy.Text == "")
            {
                ApplicationsDT.DefaultView.RowFilter = "";
                return;
            }

            if (FilterColumn == "LocalDrivingLicenseApplicationID")
                ApplicationsDT.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterAppsBy.Text.Trim());
            else
                ApplicationsDT.DefaultView.RowFilter = string.Format("[{0}] like '{1}%' ", FilterColumn, txtFilterAppsBy.Text.Trim());

        }
        private void txtFilterAppsBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterAppsBy.SelectedIndex == 1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        private void cmbFilterAppsBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterAppsBy.Visible = !(cmbFilterAppsBy.Text == "None");
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            frmAddNewLocalLicenseApp frmAddNewLocalLicenseApplication = new frmAddNewLocalLicenseApp();
            frmAddNewLocalLicenseApplication.ShowDialog();
            frmManageLocalLicenseApplication_Load(null, null);
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure you want to cancel this application?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                return;

            int localDrivingLicenseApplicationID = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;

            clsLDLApplication localDrivingLicenseApplication = clsLDLApplication.Find(localDrivingLicenseApplicationID);

            if (localDrivingLicenseApplication != null)
            {
                if (localDrivingLicenseApplication.Cancel())
                {
                    MessageBox.Show("Application cancelled successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmManageLocalLicenseApplication_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Something went wrong!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;
            LocalDrivingLicenseApplication = clsLDLApplication.Find(LocalDrivingLicenseApplicationID);

            int TotalPassedTests = (int)dgvLDLApplications.CurrentRow.Cells[5].Value;

            bool LicenseExists = LocalDrivingLicenseApplication.IsLicenseIssued();

            IssueDrivingToolStripMenuItem.Enabled = (TotalPassedTests == 3) && !LicenseExists;

            ShowLicenseToolStripMenuItem.Enabled = LicenseExists;
            editApplicationToolStripMenuItem.Enabled = !LicenseExists && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
            scheduleTestsToolStripMenuItem.Enabled = !LicenseExists;
 
            cancelApplicationToolStripMenuItem.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);

             
            deleteApplicationToolStripMenuItem.Enabled =
                (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);


            bool PassedVisionTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestTypes.enTestType.VisionTest);
            bool PassedWrittenTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestTypes.enTestType.WrittenTest);
            bool PassedStreetTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestTypes.enTestType.PracticalTest);

            scheduleTestsToolStripMenuItem.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);

            if (scheduleTestsToolStripMenuItem.Enabled)
            {
                visionTestToolStripMenuItem.Enabled = !PassedVisionTest;

                writingTestToolStripMenuItem.Enabled = PassedVisionTest && !PassedWrittenTest;

                practicalTestToolStripMenuItem.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;
            }
        }
        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestTypes.enTestType.VisionTest);
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmIssueLicenseFirstTime frmIssueLicense =new frmIssueLicenseFirstTime((int)dgvLDLApplications.CurrentRow.Cells[0].Value);
            frmIssueLicense.ShowDialog();
            frmManageLocalLicenseApplication_Load(null, null);
        }
        private void writingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestTypes.enTestType.WrittenTest);
        }
        private void practicalTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestTypes.enTestType.PracticalTest);
        }
        private void ShowLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID=  LocalDrivingLicenseApplication.GetActiveLicenseID();
            if (LicenseID != -1)
            {
                frmLicenseInfo frmLicenseInfo = new frmLicenseInfo(LicenseID);
                frmLicenseInfo.ShowDialog();
            }
            else
            {
                MessageBox.Show("License is not exist!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(LocalDrivingLicenseApplication.ApplicantPersonID);
            frm.ShowDialog();
        }
        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this application?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                return;

            int localDrivingLicenseApplicationID = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;

            clsLDLApplication localDrivingLicenseApplication = clsLDLApplication.Find(localDrivingLicenseApplicationID);
            if (localDrivingLicenseApplication != null)
            {
                if (localDrivingLicenseApplication.Delete())
                {
                    MessageBox.Show("Application deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmManageLocalLicenseApplication_Load(null, null);
                    return;
                }
                else
                {
                    MessageBox.Show("Something went wrong!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }      
        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewLocalLicenseApp frmAddNewLocalLicenseApp = new frmAddNewLocalLicenseApp((int)dgvLDLApplications.CurrentRow.Cells[0].Value);
            frmAddNewLocalLicenseApp.ShowDialog();
            frmManageLocalLicenseApplication_Load(null, null);
        }
        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplicationInfo frmLocalDrivingLicenseApplicationInfo = new frmLocalDrivingLicenseApplicationInfo((int)dgvLDLApplications.CurrentRow.Cells[0].Value);
            frmLocalDrivingLicenseApplicationInfo.ShowDialog();
            frmManageLocalLicenseApplication_Load(null, null);
        }
        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }
        private void _ScheduleTest(clsTestTypes.enTestType TestType)
        {
            int ldlApplicationID = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;
            frmTestAppointment frm = new frmTestAppointment(ldlApplicationID, TestType);
            frm.ShowDialog();
            frmManageLocalLicenseApplication_Load(null, null);
        }


    }
}
