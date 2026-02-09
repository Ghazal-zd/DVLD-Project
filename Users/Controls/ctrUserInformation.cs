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
    public partial class ctrUserInformation : UserControl
    {
        clsUser _User;
        int _UserID = -1;
        public int UserID
        {
            get { return _UserID; }
        }
        public ctrUserInformation()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            _User = clsUser.Find(UserID);
            if (_User == null)
            {
                ResetDefaultValues();
                MessageBox.Show("No user with id = " + UserID, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillUseInfo();

        }
        private void _FillUseInfo() {
            ctrPersonDetails1.LoadPersonInfo(_User.PersonID);

            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.userName;
            lblIsActive.Text = (_User.isActive) ? "Yes" : "No";
        }
        public void ResetDefaultValues() {

            ctrPersonDetails1.ResetDefaultValues();
            lblUserID.Text = "???";
            lblUserName.Text = "???";
            lblIsActive.Text = "???";
        }

        private void ctrUserInformation_Load(object sender, EventArgs e)
        {
         
        }

        private void ctrUserInfocs1_Load(object sender, EventArgs e)
        {

        }
    }
}
