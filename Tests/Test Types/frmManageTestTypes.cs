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
    public partial class frmManageTestTypes : Form
    {
        DataTable TestTypesDT;
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            TestTypesDT=clsTestTypes.getAllTestTypes();
            dgvTestTypes.DataSource = TestTypesDT;
        }

        private void editTestTypeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTestTypecs frmEditTestTypes = new frmEditTestTypecs((int)dgvTestTypes.CurrentRow.Cells[0].Value);
            frmEditTestTypes.ShowDialog();
            frmManageTestTypes_Load(null,null);

        }
    }
}
