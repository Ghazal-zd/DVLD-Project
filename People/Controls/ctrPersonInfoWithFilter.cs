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
    public partial class ctrPersonInfoWithFilter : UserControl
    {

        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            
            if (handler != null)
            {
                handler(PersonID);
            }
        }

        private bool _showAddPerson = true;
        public bool showAddPerson
        {
            get { return _showAddPerson; }

            set
            {
                _showAddPerson = value;
                btnAddNewUser.Enabled = _showAddPerson;
            }
        }

        private bool _filterEnabled = true;
        public bool filterEnabled
        {
            get { return _filterEnabled; }
            set
            {
                _filterEnabled = value;
                pnlFilter.Enabled = _filterEnabled;
            }
        }

        public int PersonID { get{ return (ctrPersonDetails1.PersonID); } }
        public clsPerson Person { get{ return (ctrPersonDetails1.Person); } }
        public ctrPersonInfoWithFilter()
        {
            InitializeComponent();
        }

        private void ctrPersonInfoWithFilter_Load(object sender, EventArgs e)
        {
            cmbFilterBy.SelectedIndex =1;
            FilterFocus();
        }
        public void FilterFocus()
        {
            txtFindBy.Focus();
        }
        public void LoadPersonInfo(int personID)
        {
            cmbFilterBy.SelectedIndex = 0;
            txtFindBy.Text = personID.ToString();
            FindPerson();
        }
        private void FindPerson()
        {
            switch (cmbFilterBy.Text)
            {
                case "Person ID":
                    {
                        ctrPersonDetails1.LoadPersonInfo(int.Parse(txtFindBy.Text));
                        break;
                    }
                case "National No":
                    {
                         ctrPersonDetails1.loadDataByNationalNo(txtFindBy.Text);
                        break;
                    }
            }

            if (OnPersonSelected != null && filterEnabled)
            {
                OnPersonSelected(ctrPersonDetails1.PersonID);
            }
        }
        private void DataBackFun(object sender, int personID)
        {
            cmbFilterBy.SelectedIndex = 0;
            txtFindBy.Text = personID.ToString();
            ctrPersonDetails1.LoadPersonInfo(personID);

        }
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddNewUpdatePerson frmAddNew = new frmAddNewUpdatePerson();
            frmAddNew.DataBack += DataBackFun;
            frmAddNew.ShowDialog();
        }
        private void txtFindBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                btnFind.PerformClick();
            }
            if (cmbFilterBy.Text == "Person ID")
            {
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields are required", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FindPerson();
        }
    }
}
