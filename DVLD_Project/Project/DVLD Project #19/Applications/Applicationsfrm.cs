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
using DVLD_Project__19.Applications.Licenses;

namespace DVLD_Project__19.Applications
{
    public partial class Applicationsfrm : Form
    {
        public Applicationsfrm()
        {
            InitializeComponent();
        }

        // General 

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    LoadLocalLicensesApplications();
                    break;
                case 3:
                    LoadApplicationsTypes();
                    break;
                case 4:
                    LoadTestsTypes();
                    break;
            }
        }

        private void Applicationsfrm_Load(object sender, EventArgs e)
        {

        }

        // Test Types 

        void LoadTestsTypes()
        {
            dataGridTestsTypes.DataSource = TestsTypes.GetAllTestsTypes();
            dataGridTestsTypes.Columns[3].Width = 400;
            dataGridTestsTypes.Columns[1].Width = 200;
        }

        private void EditTestsTypesMenuStripItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridTestsTypes.CurrentCell.OwningRow;
            DataGridViewCell cell = row.Cells[0];

            Form frm = new EditTestTypefrm(Convert.ToInt32(cell.Value));
            frm.ShowDialog();

            LoadTestsTypes();
        }


        // Applications Types

        void LoadApplicationsTypes()
        {
            dataGridAppTypes.DataSource = ApplicationsTypes.GetAllApplicationsTypes();
            dataGridAppTypes.Columns[1].Width = 450;
        }

        private void EditAppTypesStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridAppTypes.CurrentCell.OwningRow;
            DataGridViewCell cell = row.Cells[0];

            Form frm = new EditApplicationTypefrm(Convert.ToInt32(cell.Value));
            frm.ShowDialog();

            LoadApplicationsTypes();
        }


        // Driving Licenses Services

        // Manage Applications
        void SetColumnsWidthForLocalLicensesApplications()
        {
            if (dataGridLocalLicensesApp.ColumnCount == 0)
                return;

            dataGridLocalLicensesApp.Columns[0].Width = 110; // App Id
            dataGridLocalLicensesApp.Columns[1].Width = 300; // Driving_Class
            dataGridLocalLicensesApp.Columns[2].Width = 110; // National Number
            dataGridLocalLicensesApp.Columns[3].Width = 250; // Full Name 
            dataGridLocalLicensesApp.Columns[4].Width = 130; // Date
        }
        void LoadLocalLicensesApplications()
        {
            dataGridLocalLicensesApp.DataSource = LocalLicenseApplication.GetAllApplications();
            SetColumnsWidthForLocalLicensesApplications();
        }
        private void tabControlManageApplications_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlManageApplications.SelectedIndex) {
                case 0:
                    LoadLocalLicensesApplications();
                    break;

                case 1:
                    break;
            }
        }
        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new AddNewDrivingLicensesApplicationfrm();
            frm.ShowDialog();
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridLocalLicensesApp.CurrentCell.OwningRow;
            DataGridViewCell cell = row.Cells[0];


            if (LocalLicenseApplication.CancelApplication(Convert.ToInt32(cell.Value)))
            {
                MessageBox.Show($"Application {cell.Value.ToString()} Cencelled Successfully!", "Cancelled",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadLocalLicensesApplications();
            }

            else
                MessageBox.Show("Cancel Application Failed!", "Failed", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);


        }

        private void deleteApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridLocalLicensesApp.CurrentCell.OwningRow;
            DataGridViewCell cell = row.Cells[0];

            if (LocalLicenseApplication.Delete(Convert.ToInt32(cell.Value)))
            {
                MessageBox.Show($"Application {cell.Value.ToString()} Deleted Successfully!", "Cancelled",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadLocalLicensesApplications();
            }

            else
                MessageBox.Show("Delete Application Failed!", "Failed", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                txtboxFilter.Visible = false;
                cbStatus.Visible = false;
            }
            else if (cbFilter.SelectedIndex == 4) // Status
            {
                cbStatus.Visible = true;
                txtboxFilter.Visible = false;
            }
            else
            {
                txtboxFilter.Visible = true;
                cbStatus.Visible = false;
            }

            LoadLocalLicensesApplications();
            txtboxFilter.Text = "";
        }

        private void txtboxFilter_TextChanged(object sender, EventArgs e)
        {
            /*
                None
                Application Id
                National Number
                FullName
                Status 
            */

            if (txtboxFilter.Text == "")
            {
                LoadLocalLicensesApplications();
            }

            if (cbFilter.SelectedIndex == 1) // Application Id
            {
                dataGridLocalLicensesApp.DataSource = LocalLicenseApplication.Search("ApplicationId",
                    txtboxFilter.Text);
            }
            if (cbFilter.SelectedIndex == 2) // NationalNum
            {
                dataGridLocalLicensesApp.DataSource = LocalLicenseApplication.Search("NationalNum",
                    txtboxFilter.Text);
            }
            if (cbFilter.SelectedIndex == 3) // FullName
            {
                dataGridLocalLicensesApp.DataSource = LocalLicenseApplication.Search("FullName",
                    txtboxFilter.Text);
            }

            SetColumnsWidthForLocalLicensesApplications();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
                New
                Cancelled
                Done 
            */
            if (cbStatus.SelectedIndex == 0) // new
            {
                dataGridLocalLicensesApp.DataSource = LocalLicenseApplication.Search("Status",
                    "New");

            }

            if (cbStatus.SelectedIndex == 1) // cancelled
            {
                dataGridLocalLicensesApp.DataSource = LocalLicenseApplication.Search("Status",
                                "Cancelled");

            }

            if (cbStatus.SelectedIndex == 2) // Completed
            {
                dataGridLocalLicensesApp.DataSource = LocalLicenseApplication.Search("Status",
                                    "Completed");

            }

            SetColumnsWidthForLocalLicensesApplications();
        }

        private void btnAddNewLocalLicenseApp_Click(object sender, EventArgs e)
        {
            Form frm = new AddNewDrivingLicensesApplicationfrm();
            frm.ShowDialog();

            LoadLocalLicensesApplications();
        }

    }
}
