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
    public partial class frmInternationalLicenseInfo : Form
    {
        int internationalLicenseID = -1;
        public frmInternationalLicenseInfo(int internationalLicenseID)
        {
            InitializeComponent();
            this.internationalLicenseID = internationalLicenseID;
        }
        private void frmInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrInternationalLicenseInfo1.LoadLicenseDataByID(internationalLicenseID);
        }
    }
}
