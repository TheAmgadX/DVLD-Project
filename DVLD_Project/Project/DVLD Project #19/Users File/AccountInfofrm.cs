using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project__19.Users_File
{
    public partial class AccountInfofrm : Form
    {
        public AccountInfofrm(int PersonId)
        {
            InitializeComponent();
            ctrlUserInfo1.ctrlPersonInfo1.PersonId = PersonId;
            this.PersonId = PersonId;
        }

        int PersonId = -1;

        private void btnChengePassword_Click(object sender, EventArgs e)
        {
            Form frm = new ChangePasswordfrm(PersonId);
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form frm = new EditUserfrm(PersonId);
            frm.ShowDialog();
        }
        public void RestartApplication()
        {
            // Get the path of the current executable
            string applicationPath = Application.ExecutablePath;

            // Close the application
            Application.Exit();

            // Start the application again
            System.Diagnostics.Process.Start(applicationPath);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            GlobalData.DeleteAllRecords();

            RestartApplication();
        }
    }
}
