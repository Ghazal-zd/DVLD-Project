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
    public partial class ctrInternationalLicenseInfo : UserControl
    {
        public ctrInternationalLicenseInfo()
        {
            InitializeComponent();
        }
        public void LoadLicenseDataByID(int InternationalLicenseID)
        {
            clsInternationalLicense internationalLicense=clsInternationalLicense.Find(InternationalLicenseID);

            lblName.Text = internationalLicense.PersonInfo.FullName;
            lblIntLicenseID.Text = internationalLicense.InternationalLicenseID.ToString();
            lblLicenseID.Text = internationalLicense.IssuedUsingLocalDrivingLicenseID.ToString();
            lblNationalNo.Text = internationalLicense.PersonInfo.NationalNo;
            lblGender.Text = internationalLicense.PersonInfo.Gender.ToString();
            lblIssueDate.Text = internationalLicense.IssueDate.ToString().Split(' ')[0];
            lblExeprationDate.Text = internationalLicense.ExpirationDate.ToString().Split(' ')[0];
            lblIsActive.Text = internationalLicense.IsActive.ToString();
            lblDriverID.Text = internationalLicense.DriverID.ToString();
            lblDOB.Text = internationalLicense.PersonInfo.DateOfBirth.ToString().Split(' ')[0];
            lblApplicationID.Text = internationalLicense.ApplicationID.ToString();

            if (internationalLicense.PersonInfo.ImagePath != "")
                picPerson.ImageLocation = internationalLicense.PersonInfo.ImagePath;
            else
                picPerson.ImageLocation = "C:\\Users\\VICTUS\\source\\repos\\People Management\\Resources\\images.png";
        }
        private void ctrInternationalLicenseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
