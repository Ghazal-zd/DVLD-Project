using DVLD.Classes;
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
    public partial class ctrApplicationInfo : UserControl
    {

        clsApplication _Application;
        int _ApplicationID = -1;

        public int basicApplicationID
        {
            get { return _ApplicationID; }
        }
        public ctrApplicationInfo()
        {
            InitializeComponent();
        }

        public void ResetDefaultValues()
        {
            lblBasicApplicationID.Text = "???";
            lblStatus.Text = "???";
            lblFees.Text = "???";
            lblDate.Text = "???";
            lblApplicant.Text = "???";
            lblType.Text = "???";
            lblStatusDate.Text = "???";
            lblCreatedBy.Text = "???";
            lnkLblPersonInfo.Enabled= false;    

        }
        private void LoadBasicApplicationInfo()
        {
            lnkLblPersonInfo.Enabled = true;
            lblBasicApplicationID.Text = _Application.ApplicationID.ToString();
            lblStatus.Text=_Application.StatusText;
            lblFees.Text = _Application.ApplicationFees.ToString();
            lblType.Text = _Application.ApplicationTypeInfo.ApplicationTitle;
            lblApplicant.Text = _Application.PersonInfo.FullName;
            lblDate.Text = clsFormat.DateToShort(_Application.ApplicationDate);
            lblStatusDate.Text = clsFormat.DateToShort(_Application.LastStatusDate);
            lblCreatedBy.Text = _Application.CreatedByUserInfo.userName;
        }
        public void LoadBasicApplicationInfo(int ApplicationID)
        {
            _ApplicationID = ApplicationID;
            _Application= clsApplication.FindApplicationByID(ApplicationID);

            if (_Application == null)
            {
                ResetDefaultValues();
                MessageBox.Show("No Application with id = " + _ApplicationID, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadBasicApplicationInfo();
        }
        private void ctrApplicationInfo_Load(object sender, EventArgs e)
        {       
        }
        private void lnkLblPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails frmPersonDetails = new frmPersonDetails(_Application.ApplicantPersonID);
            frmPersonDetails.ShowDialog();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
