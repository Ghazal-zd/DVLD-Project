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
    public partial class ctrUserInfocs : UserControl
    {
        public ctrUserInfocs()
        {
            InitializeComponent();
        }

        ///////////////IMPROVE////////////////
       
       /*  public void LoadGlobalUserInfo()
        {
            lblUserID.Text = clsGlobalUser.User.UserID.ToString();
            lblUserName.Text = clsGlobalUser.User.userName;
            if (clsGlobalUser.User.isActive)
            {
                lblIsActive.Text = "true";
            }
            else
                lblIsActive.Text = "false";
        }*/
        public void LoadUserInfo(clsUser User)
        {
            lblUserID.Text =User.UserID.ToString();
            lblUserName.Text = User.userName;

            if (User.isActive)
            {
                lblIsActive.Text = "true";
            }
            else
                lblIsActive.Text = "false";
        }

    
        ///////////////IMPROVE////////////////

        private void ctrUserInfocs_Load(object sender, EventArgs e)
        {

        }
    }
}
