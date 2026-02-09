using DVLD.Classes;
using DVLD_BuisnessLayer;
using Guna.UI2.WinForms;
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

namespace People_Management
{
    public partial class frmTakeTest : Form
    {
        clsTestTypes.enTestType _TestTypeID =clsTestTypes.enTestType.VisionTest;
        int _TestAppointmentID = -1;
        clsTestAppointment appointment;
        clsTests _Test;
        public frmTakeTest(clsTestTypes.enTestType testID, int appointmentID)
        {
            InitializeComponent();
            _TestTypeID = testID;
            _TestAppointmentID = appointmentID;
        }
        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            
            appointment = clsTestAppointment.Find(_TestAppointmentID);

            ctrScheduledTest1.TestTypeID = _TestTypeID;
            ctrScheduledTest1.LoadTestAppointmentDetails(_TestAppointmentID);

            if (ctrScheduledTest1.TestAppointmentID == -1)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;


            int _TestID = ctrScheduledTest1.TestID;
            if (_TestID != -1)
            {
                _Test = clsTests.Find(_TestID);

                if (_Test.TestResult)
                    rbPass.Checked = true;
                else
                    rdFail.Checked = true;
                txtNotes.Text = _Test.Notes;

                //lblUserMessage.Visible = true;
                rdFail.Enabled = false;
                rbPass.Enabled = false;
            }

            else
                _Test = new clsTests();
            rbPass.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _Test.TestAppointmentID = _TestAppointmentID;

            if (rdFail.Checked) _Test.TestResult = false;
            else _Test.TestResult = true;

            _Test.Notes=txtNotes.Text;
            _Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Test.Save())
            {
                MessageBox.Show("Data Saved Successfully","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }

                //appointment.isLocked = true;
                //appointment.Save(); 
                
        }

        private void lblFees_Click(object sender, EventArgs e)
        {

        }

        private void lblTestID_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }
    }
}
