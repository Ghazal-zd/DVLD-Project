using DVLD_BuisnessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace People_Management
{
    public partial class frmUsersList : Form
    {
        static DataTable _UserDT;
        public frmUsersList()
        {
            InitializeComponent();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _UserDT = clsUser.GetAllUsers();
            dgvUsers.DataSource = _UserDT;

            cmbFilterUsersBy.SelectedIndex = 0;

            if (dgvUsers.Rows.Count > 0)
            {

                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 100;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].Width = 90;

                dgvUsers.Columns[2].HeaderText = "Full Name";
                dgvUsers.Columns[2].Width = 190;
                
                dgvUsers.Columns[3].HeaderText = "User Name";
                dgvUsers.Columns[3].Width = 100;

                dgvUsers.Columns[4].HeaderText = "Is Active";
                dgvUsers.Columns[4].Width = 70;

            }
        }
     

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddNewUser frmAddUser = new frmAddNewUser();
            frmAddUser.ShowDialog();

            frmManageUsers_Load(null,null);
        }
        

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChange = new frmChangePassword((int)dgvUsers.CurrentRow.Cells[0].Value);
   
            frmChange.ShowDialog();
            frmManageUsers_Load(null, null);
        }

        private void cmbFilterUsersBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterUsersBy.Visible = !(cmbFilterUsersBy.Text == "None") && !(cmbFilterUsersBy.Text == "Is Active");
            cmbFilterByIsActive.Visible = (cmbFilterUsersBy.Text == "Is Active") ;
            cmbFilterByIsActive.Text = "All";
        }
        private void txtFilterUsersBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cmbFilterUsersBy.Text)
            {
                case "User ID":

                    FilterColumn = "UserID";
                    break;

                case "Person ID":

                    FilterColumn = "PersonID";
                    break;
                    
                case "User Name":

                    FilterColumn = "UserName";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Is Active":

                    FilterColumn = "IsActive";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }


            if (txtFilterUsersBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _UserDT.DefaultView.RowFilter = "";
                return;
            }
            if (FilterColumn == "PersonID" || FilterColumn == "UserID")
                _UserDT.DefaultView.RowFilter = string.Format("[{0}] = {1} ", FilterColumn, txtFilterUsersBy.Text.Trim());
            else
                _UserDT.DefaultView.RowFilter = string.Format("[{0}] like '{1}%' ", FilterColumn, txtFilterUsersBy.Text.Trim());

        }

        private void txtFilterUsersBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterUsersBy.Text == "User ID" || cmbFilterUsersBy.Text == "Person ID")
            {
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

            }
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewUser frm = new frmAddNewUser();
            frm.ShowDialog();
            frmManageUsers_Load(null, null);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddNewUser frm = new frmAddNewUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManageUsers_Load(null, null);
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUser.Delete((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    DialogResult result = MessageBox.Show("User has been deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmManageUsers_Load(null, null);
                }

                else
                {
                    MessageBox.Show("Sorry, Something went wrong!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUserDetails = new frmUserDetails((int)dgvUsers.CurrentRow.Cells[0].Value);
            frmUserDetails.ShowDialog();
        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void cmbFilterByIsActive_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cmbFilterByIsActive.Text;

            switch (FilterValue)
            {
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
                default:
                    break;
            }

            if (FilterValue == "All")
                _UserDT.DefaultView.RowFilter = "";
            else
                _UserDT.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);


        }
    }
}
