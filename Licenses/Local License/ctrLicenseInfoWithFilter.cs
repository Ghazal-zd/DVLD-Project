using DVLD_BuisnessLayer;
using System;
using System.Windows.Forms;

namespace People_Management
{
    public partial class ctrLicenseInfoWithFilter : UserControl
    {
        public event Action<int> OnSearchCompleted;
        protected virtual void SearchCompleted(int result)
        {
            Action<int> handler = OnSearchCompleted;

            if (handler != null)
            {
                handler(result);
            }

        }

        private int _licenseID = -1;
        public int LicenseID { get { return ctrLicenseInfo1.LicenseID; } }

        private bool _FilterEnabled=true;
        public bool FilterEnabled
        {
            set { 
                _FilterEnabled = value;
                pnlFilter.Enabled = _FilterEnabled;
            }
            get { return _FilterEnabled; }
        }
        public clsLicense selectedLicense
        {
            get { return ctrLicenseInfo1.selectedLicenseInfo; }
        }
        public ctrLicenseInfoWithFilter()
        {
            InitializeComponent();
        }
        public void LoadLicenseInfo(int licenseID)
        {
            txtLicenseID.Text = licenseID.ToString();
            ctrLicenseInfo1.LoadLicenseInfo(licenseID);
            licenseID = ctrLicenseInfo1.LicenseID;
            if (OnSearchCompleted != null && FilterEnabled)
            {
                SearchCompleted(licenseID);
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some field are not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _licenseID = int.Parse(txtLicenseID.Text);
            LoadLicenseInfo(_licenseID);
        }
        public void setFocus()
        {
            txtLicenseID.Focus();
        }
        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnFind.PerformClick();
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ctrLicenseInfoWithFilter_Load(object sender, EventArgs e)
        {
        }

        private void txtLicenseID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtLicenseID.Text.Trim()))
            {
                errorProvider1.SetError(txtLicenseID, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtLicenseID, null);
            }
        }

        private void ctrLicenseInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
