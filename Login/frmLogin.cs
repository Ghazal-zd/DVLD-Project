using DVLD.Classes;
using DVLD_BuisnessLayer;
using System;
using System.IO;
using System.Windows.Forms;

namespace People_Management
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void CheckRememberMe()
        {
            string path = "UserInfoFile.txt";

            if (chxRememberMe.Checked)
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(txtUserName.Text.Trim());
                    writer.WriteLine(txtPassword.Text.Trim());
                }
            }
            else
            {
                File.WriteAllText(path, string.Empty);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.FindUserByUsernameAndPassword(txtUserName.Text, txtPassword.Text);

            if (user != null)
            {
                if (chxRememberMe.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                if (user.isActive)
                {
                    clsGlobal.CurrentUser = user;
                    Form frm1 = new Form1(this);
                    frm1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your account is deactivate, please contact the admin", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("invalid Username or password ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private bool LoadInformation()
        {
            string path = "UserInfoFile.txt";
            if (File.Exists(path))
            {
                FileInfo fileInfo = new FileInfo(path);
                if (fileInfo.Length != 0)
                {
                    string[] Lines = File.ReadAllLines(path);

                    txtUserName.Text = Lines[0];
                    txtPassword.Text = Lines[1];
                    chxRememberMe.Checked = true;

                    return true;
                }
            }
            return false;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Login";
            string userName = "", password = "";
            if (clsGlobal.GetStoredCredential(ref userName, ref password))
            {
                txtUserName.Text = userName;
                txtPassword.Text = password;
                chxRememberMe.Checked = true;
            }
            else
            {
                chxRememberMe.Checked = false;
            }
        }

        private void chxRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
