using DVLD_BuisnessLayer;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace People_Management
{
    public partial class frmPeopleList : Form
    {
        static DataTable AllPeopleDT = clsPerson.GetAllPeople();
        static DataTable _PeopleDT = AllPeopleDT.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                                     "FirstName", "SecondName", "ThirdName", "LastName",
                                                                     "Gender", "DateOfBirth", "Nationality",
                                                                     "Phone", "Email");
        public frmPeopleList()
        {
            InitializeComponent();
        }
        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            dgvAllPeople.DataSource = _PeopleDT;
            cmbFilterBy.SelectedIndex = 0;

            if (dgvAllPeople.Rows.Count > 0)
            {

                dgvAllPeople.Columns[0].HeaderText = "Person ID";
                dgvAllPeople.Columns[0].Width = 100;

                dgvAllPeople.Columns[1].HeaderText = "National No";
                dgvAllPeople.Columns[1].Width = 90;

                dgvAllPeople.Columns[2].HeaderText = "First Name";
                dgvAllPeople.Columns[2].Width = 110;

                dgvAllPeople.Columns[3].HeaderText = "Second Name";
                dgvAllPeople.Columns[3].Width = 120;

                dgvAllPeople.Columns[4].HeaderText = "Third Name";
                dgvAllPeople.Columns[4].Width = 110;

                dgvAllPeople.Columns[5].HeaderText = "Last Name";
                dgvAllPeople.Columns[5].Width = 120;

                dgvAllPeople.Columns[6].HeaderText = "Gender";
                dgvAllPeople.Columns[6].Width = 90;

                dgvAllPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvAllPeople.Columns[7].Width = 140;

                dgvAllPeople.Columns[8].HeaderText = "Nationality";
                dgvAllPeople.Columns[8].Width = 120;

                dgvAllPeople.Columns[9].HeaderText = "Phone";
                dgvAllPeople.Columns[9].Width = 120;

                dgvAllPeople.Columns[10].HeaderText = "Email";
                dgvAllPeople.Columns[10].Width = 120;

            }
        }
        private void _RefreshDgvPeople()
        {
            dgvAllPeople.DataSource = clsPerson.GetAllPeople();
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            frmAddNewUpdatePerson frmAddNew1 = new frmAddNewUpdatePerson();
            frmAddNew1.ShowDialog();
            _RefreshDgvPeople();
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frmDetails = new frmPersonDetails((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            frmDetails.ShowDialog();
            _RefreshDgvPeople();
        }
        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Visible = !(cmbFilterBy.Text == "None");

            if (txtFilterBy.Visible)
            {
                txtFilterBy.Focus();
                txtFilterBy.Text = "";
            }
        }
        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterBy.Text == "Person ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewUpdatePerson frmAddNew = new frmAddNewUpdatePerson();
            frmAddNew.ShowDialog();
            _RefreshDgvPeople();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewUpdatePerson frmUpdate = new frmAddNewUpdatePerson((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            frmUpdate.ShowDialog();
            _RefreshDgvPeople();
        }
        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cmbFilterBy.Text)
            {
                case "Person ID":

                    FilterColumn = "PersonID";
                    break;

                case "National No":

                    FilterColumn = "NationalNo";
                    break;

                case "First Name":

                    FilterColumn = "FirstName";
                    break;

                case "Second Name":

                    FilterColumn = "SecondName";
                    break;

                case "Third Name":

                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":

                    FilterColumn = "LastName";
                    break;

                case "Gender":

                    FilterColumn = "Gender";
                    break;

                case "Nationality":

                    FilterColumn = "Nationality";
                    break;

                case "Email":

                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }


            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _PeopleDT.DefaultView.RowFilter = "";
                return;
            }
            if (FilterColumn == "PersonID")
                _PeopleDT.DefaultView.RowFilter = string.Format("[{0}] = {1} ", FilterColumn, txtFilterBy.Text.Trim());
            else
                _PeopleDT.DefaultView.RowFilter = string.Format("[{0}] like '{1}%' ", FilterColumn, txtFilterBy.Text.Trim());

        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete person with ID [" + (int)dgvAllPeople.CurrentRow.Cells[0].Value + "]", "", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsPerson.DeletePerson((int)dgvAllPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshDgvPeople();
                    return;
                }
                else
                {
                    MessageBox.Show("Sorry, person was not deleted because it has data linked to it!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
/*  DataRow[] ResultRows;

            switch (SelectedFilter)
            {
                case 1:
                    {

                        ResultRows = AllPeopleDT.Select($"PersonID =  '{(txtFilterBy.Text)}' ");
                        if (ResultRows.Length > 0)
                        {
                            DataTable filteredDataTable = ResultRows.CopyToDataTable();

                            dgvAllPeople.DataSource = filteredDataTable;
                        }
                        else
                            dgvAllPeople.DataSource = AllPeopleDT;
                        break;
                    }
                case 2:
                    {
                        ResultRows = AllPeopleDT.Select($"NationalNo =  '{FilterBy}' ");
                        if (ResultRows.Length > 0)
                        {
                            DataTable filteredDataTable = ResultRows.CopyToDataTable();

                            dgvAllPeople.DataSource = filteredDataTable;
                        }
                        else
                            dgvAllPeople.DataSource = AllPeopleDT;

                        break;
                    }
                case 3:
                    {
                        ResultRows = AllPeopleDT.Select($"FirstName =  '{FilterBy}' ");
                        if (ResultRows.Length > 0)
                        {
                            DataTable filteredDataTable = ResultRows.CopyToDataTable();

                            dgvAllPeople.DataSource = filteredDataTable;
                        }
                        else
                            dgvAllPeople.DataSource = AllPeopleDT;

                        break;
                    }
                case 4:
                    {

                        ResultRows = AllPeopleDT.Select($"SecondName =  '{FilterBy}' ");
                        if (ResultRows.Length > 0)
                        {
                            DataTable filteredDataTable = ResultRows.CopyToDataTable();

                            dgvAllPeople.DataSource = filteredDataTable;
                        }
                        else
                            dgvAllPeople.DataSource = AllPeopleDT;

                        break;
                    }
                case 5:
                    {

                        ResultRows = AllPeopleDT.Select($"ThirdName =  '{FilterBy}' ");
                        if (ResultRows.Length > 0)
                        {
                            DataTable filteredDataTable = ResultRows.CopyToDataTable();

                            dgvAllPeople.DataSource = filteredDataTable;
                        }
                        else
                            dgvAllPeople.DataSource = AllPeopleDT;

                        break;
                    }
                case 6:
                    {

                        ResultRows = AllPeopleDT.Select($"LastName =  '{FilterBy}' ");
                        if (ResultRows.Length > 0)
                        {
                            DataTable filteredDataTable = ResultRows.CopyToDataTable();

                            dgvAllPeople.DataSource = filteredDataTable;
                        }
                        else
                            dgvAllPeople.DataSource = AllPeopleDT;

                        break;
                    }
                case 7:
                    {

                        ResultRows = AllPeopleDT.Select($"NationalityCountryID =  '{int.Parse(txtFilterBy.Text)}' ");
                        if (ResultRows.Length > 0)
                        {
                            DataTable filteredDataTable = ResultRows.CopyToDataTable();

                            dgvAllPeople.DataSource = filteredDataTable;
                        }
                        else
                            dgvAllPeople.DataSource = AllPeopleDT;

                        break;
                    }
                case 8:
                    {

                        ResultRows = AllPeopleDT.Select($"Gendor =  {int.Parse(txtFilterBy.Text)} ");
                        if (ResultRows.Length > 0)
                        {
                            DataTable filteredDataTable = ResultRows.CopyToDataTable();

                            dgvAllPeople.DataSource = filteredDataTable;
                        }
                        else
                            dgvAllPeople.DataSource = AllPeopleDT;

                        break;
                    }
                case 9:
                    {

                        ResultRows = AllPeopleDT.Select($"Phone =  '{FilterBy}' ");
                        if (ResultRows.Length > 0)
                        {
                            DataTable filteredDataTable = ResultRows.CopyToDataTable();

                            dgvAllPeople.DataSource = filteredDataTable;
                        }
                        else
                            dgvAllPeople.DataSource = AllPeopleDT;

                        break;
                    }
                case 10:
                    {
                        ResultRows = AllPeopleDT.Select($"Email =  '{FilterBy}' ");
                        if (ResultRows.Length > 0)
                        {
                            DataTable filteredDataTable = ResultRows.CopyToDataTable();

                            dgvAllPeople.DataSource = filteredDataTable;
                        }
                        else
                            dgvAllPeople.DataSource = AllPeopleDT;

                        break;
                    }
            }*/