using DVLD_BuisnessLayer;
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
    public partial class frmLicenseHistory : Form
    {
        int _personID = -1;
        public frmLicenseHistory(int personID)
        {
            InitializeComponent();
            _personID = personID;
        }
        public frmLicenseHistory()
        {
            InitializeComponent();
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            if (_personID != -1)
            {
                ctrPersonDetails1.LoadPersonInfo(_personID);
                ctrDriverLicenses1.LoadInfoByPerson(_personID);
            }
            else
            {
                MessageBox.Show("Sorry, Person is not exist!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ctrUserInfoWithFilter1_OnPersonSelected(int obj)
        {
            _personID = obj;
            if (_personID != -1)
            {
                ctrDriverLicenses1.Clear();
            }
            else
            {
                ctrDriverLicenses1.LoadInfoByPerson(_personID);
            }
        }
    }
}
