using DVLD_Business_Layer;
using DVLD_Project__19.People;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project__19
{
    public partial class ManagePeopleForm : Form
    {
        public ManagePeopleForm()
        {
            InitializeComponent();
        }

        void SetColumnsWidth()
        {
            if (dataGridView1.Columns.Count == 0) return;

            dataGridView1.Columns["Email"].Width = 180;
            dataGridView1.Columns["FullName"].Width = 230;
            dataGridView1.Columns["Address"].Width = 130;
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            Form frm = new Add_New_Person_Form();
            frm.ShowDialog();

            dataGridView1.DataSource = Person.GetAllPeople();
        }
        private void ManagePeopleForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Font = new Font("Verdana", 9);
            dataGridView1.DataSource = Person.GetAllPeople();

            SetColumnsWidth();
        }
        private void txtboxFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtboxFilter.Text == "")
            {
                dataGridView1.DataSource = Person.GetAllPeople();

                SetColumnsWidth();
                return;
            }

            if (cbFilter.SelectedIndex == 1 && int.TryParse(txtboxFilter.Text, out int id)) // Id
                dataGridView1.DataSource = Person.SearchWithId(id);

            if (cbFilter.SelectedIndex == 2) // National Id
                dataGridView1.DataSource = Person.SearchWithNationalNum(txtboxFilter.Text);

            if (cbFilter.SelectedIndex == 3) // FullName
                dataGridView1.DataSource = Person.SearchWithFilter("FullName", txtboxFilter.Text);

            if (cbFilter.SelectedIndex == 4) // Phone
                dataGridView1.DataSource = Person.SearchWithFilter("Phone", txtboxFilter.Text);

            if (cbFilter.SelectedIndex == 5) // Email
                dataGridView1.DataSource = Person.SearchWithFilter("Email", txtboxFilter.Text);

            if (cbFilter.SelectedIndex == 6 ) // Address
                dataGridView1.DataSource = Person.SearchWithFilter("Address", txtboxFilter.Text);

            if (cbFilter.SelectedIndex == 7) // Country
                dataGridView1.DataSource = Person.SearchWithFilter("CountryName", txtboxFilter.Text);

            SetColumnsWidth();
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            DataGridViewCell cell = row.Cells[0];
            Form frm = new PersonDetailsFrm(Convert.ToInt32(cell.Value));
            frm.ShowDialog();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
                DataGridViewCell cell = row.Cells[0];
                Form frm = new EditPersonForm(Convert.ToInt32(cell.Value));
                frm.ShowDialog();
            }
            catch { MessageBox.Show("Invalid Person!"); }


            dataGridView1.DataSource = Person.GetAllPeople();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cheking if The Person related to user or driver.

            // Deleting...
            try
            {
                DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
                DataGridViewCell cell = row.Cells[0];
                int Id = Convert.ToInt32(cell.Value);

                if (MessageBox.Show($"Are You Sure You Want To Delete {Id}", "Ensure",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (Person.Delete(Id))
                        MessageBox.Show($"{Id} Deleted Seccessfully", "Succeed", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                }
            }
            catch { MessageBox.Show("Invalid Person!"); }

            // Load Grid View Again..

            dataGridView1.DataSource = Person.GetAllPeople();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilter.SelectedIndex == 0)
                txtboxFilter.Visible = false;
            else
                txtboxFilter.Visible = true;

            dataGridView1.DataSource = Person.GetAllPeople();

            SetColumnsWidth();
        }
    }
}
