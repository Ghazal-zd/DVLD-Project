using DVLD.Classes;
using DVLD_BuisnessLayer;
using People_Management.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace People_Management
{
    public partial class ctrLicenseInfo : UserControl
    {
        private int _licenseID;
        clsLicense _license;
        public int LicenseID
        {   
            get { return _licenseID; } 
        }
        public clsLicense selectedLicenseInfo
        {
          get { return _license; }
        }
        public ctrLicenseInfo()
        {
            InitializeComponent();
        }
        private void _LoadPersonImage()
        {
            if (_license.DriverInfo.PersonInfo.Gender == 0)
            {
                picPerson.Image = Resources.images;
            }
            else
            {
                picPerson.Image=Resources.FemaleIcon;
            }

            string ImagePath = _license.DriverInfo.PersonInfo.ImagePath;
            if (ImagePath != "")
            {
                if(File.Exists(ImagePath))
                picPerson.ImageLocation = ImagePath;
                else
                    MessageBox.Show("This image is not exist!","",MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
        }
        public void LoadLicenseInfo(int licenseID)
        {
            _licenseID = licenseID;
            _license = clsLicense.Find(licenseID);

            if (_license == null)
            {
                MessageBox.Show("This License is not exist!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _licenseID = -1;
                return;
            }

            lblClass.Text = _license.LicenseClassInfo.ClassName;
            lblName.Text = _license.DriverInfo.PersonInfo.FullName;
            lblLicenseID.Text = _license.LicenseID.ToString();
            lblNationalNo.Text = _license.DriverInfo.PersonInfo.NationalNo;
            lblGender.Text = _license.DriverInfo.PersonInfo.Gender == 0 ? "Male" : "Female";
            lblIssueDate.Text = clsFormat.DateToShort(_license.IssueDate);
            lblIssueReason.Text = _license.IssueReasonText;
            lblNotes.Text = _license.Notes == "" ? "No Notes" : _license.Notes;
            lblIsActive.Text = _license.IsActive ? "Yes" : "No";
            lblDateOfBirth.Text = clsFormat.DateToShort(_license.DriverInfo.PersonInfo.DateOfBirth);
            lblExeprationDate.Text = clsFormat.DateToShort(_license.ExpirationDate);
            lblDriverID.Text = _license.DriverInfo.DriverID.ToString();
            lblIsDetained.Text = clsDetainLicense.IsDetained(licenseID) ? "Yes" : "No";
            _LoadPersonImage();
        }

        private void ctrLicenseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
