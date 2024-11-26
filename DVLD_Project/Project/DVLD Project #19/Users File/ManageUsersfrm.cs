using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business_Layer;
using DVLD_Project__19.Users_File;

namespace DVLD_Project__19
{
    public partial class ManageUsersfrm : Form
    {
        public ManageUsersfrm()
        {
            InitializeComponent();
        }

        void LoadAllUsers(bool load = true)
        {
            if(load)
                dataGridView1.DataSource = Users.GetAllUsers();

            if(dataGridView1.Columns.Count != 0)
            {
                dataGridView1.Columns["FullName"].Width = 250;
                dataGridView1.Columns["UserName"].Width = 150;
            }

        }
        private void ManageUsersfrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Verdana", 9);
            LoadAllUsers();    
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                LoadAllUsers();
                txtboxFilter.Visible = false;
                cbIsActive.Visible = false;
            }

            if(cbFilter.SelectedIndex == 4)
            {
                txtboxFilter.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0;
            }
            
            else
                txtboxFilter.Visible = true;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            Form frm = new AddNewUserfrm();
            frm.ShowDialog();

            LoadAllUsers(); 
        }

        private void txtboxFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtboxFilter.Text == "")
            {
                LoadAllUsers();
                return;
            }

            if (cbFilter.SelectedIndex == 1 && int.TryParse(txtboxFilter.Text, out int id)) // Id
                dataGridView1.DataSource = Users.SearchWithUserId(id);

            if (cbFilter.SelectedIndex == 2) // Username
                dataGridView1.DataSource = Users.SearchWithUsername(txtboxFilter.Text);

            if (cbFilter.SelectedIndex == 3) // FulName
                dataGridView1.DataSource = Users.SearchWithFullName(txtboxFilter.Text);

            LoadAllUsers(false);
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsActive.SelectedIndex == 0) // All
            {
                dataGridView1.DataSource = Users.GetAllUsers();
            }
            if(cbIsActive.SelectedIndex == 1) // Active
            {
                dataGridView1.DataSource = Users.SearchWithIsActive();
            }
            if (cbIsActive.SelectedIndex == 2) // Not Active
            {
                dataGridView1.DataSource = Users.SearchWithIsActive(false);
            }

            LoadAllUsers(false);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            DataGridViewCell cell = row.Cells[2];

            Form frm = new UserDetailsfrm(Convert.ToInt32(cell.Value));

            frm.ShowDialog();

            LoadAllUsers();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            DataGridViewCell cell = row.Cells[2];

            Form frm = new EditUserfrm(Convert.ToInt32(cell.Value));

            frm.ShowDialog();

            LoadAllUsers();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            DataGridViewCell cell = row.Cells[2];

            Form frm = new ChangePasswordfrm(Convert.ToInt32(cell.Value));

            frm.ShowDialog();

            LoadAllUsers();
        }
    }
}
