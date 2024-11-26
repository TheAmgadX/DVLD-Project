using DVLD_Project__19.Users_File;
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
using DVLD_Project__19.Applications;
using Microsoft.VisualBasic.ApplicationServices;

namespace DVLD_Project__19
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void btnPeople_Click_1(object sender, EventArgs e)
        {
            Form frm = new ManagePeopleForm();
            frm.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Form frm = new ManageUsersfrm();
            frm.ShowDialog();
        }
        
        private void btnAccountInfo_Click(object sender, EventArgs e)
        {
            (Users u, bool b) = GlobalData.ReadFirstUserFromFile();
            Users user = Users.Find(u.UserName);



            AccountInfofrm frm = new AccountInfofrm(user.PersonId);

            frm.ShowDialog();
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            Form frm = new Applicationsfrm();
            frm.ShowDialog();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            Users currentUser = null;
            bool b = false;
            (currentUser,b) = GlobalData.ReadFirstUserFromFile();



            GlobalData.CurrentUser = Users.Find(currentUser.UserName);

        }
    }
}
