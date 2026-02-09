using DVLD_BuisnessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace People_Management
{
    public partial class frmManageApplicationTypes : Form
    {
         DataTable _ApplicationTypes;
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            this.Text = "Application Types";
            _ApplicationTypes = clsApplicationTypes.getAllApplicationTypes();
            dgvApplicationTypes.DataSource = _ApplicationTypes;
        }
     
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditApplicationType frmEdit= new frmEditApplicationType((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);
            frmEdit.ShowDialog();
            frmManageApplicationTypes_Load(null, null);
        }
    }
}
