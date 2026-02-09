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
    public partial class frmUserDetails : Form
    {
        int UserID = -1;
        public frmUserDetails(int userID)
        {
            InitializeComponent();
            UserID = userID;
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
             ctrUserInformation1.LoadUserInfo(UserID);
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
