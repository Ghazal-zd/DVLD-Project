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
    public partial class frmPersonDetails : Form
    {
        //public delegate void SendDataBack(object sender, DataTable dataTable);
        //public SendDataBack DataBack;

        int _PersonID = -1;
        public frmPersonDetails(int PersonID)
        {
            InitializeComponent();
            ctrPersonDetails1.LoadPersonInfo(PersonID);
        }
        public frmPersonDetails(string nationalNo)
        {
            InitializeComponent();
            ctrPersonDetails1.loadDataByNationalNo(nationalNo);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
