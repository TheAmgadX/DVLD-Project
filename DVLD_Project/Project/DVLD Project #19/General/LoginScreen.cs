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

namespace DVLD_Project__19
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users user = Users.Find(txtBoxUserName.Text, txtBoxPassword.Text);

            if (user != null)
            {
                GlobalData.WriteUserToFile(txtBoxUserName.Text, txtBoxPassword.Text, cboxRememberMe.Checked);

                Form frm = new MainScreen();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Invalid Login Data", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            (Users user, bool Remember) = GlobalData.ReadFirstUserFromFile();


            if (user != null && Remember) { 
                txtBoxUserName.Text = user.UserName;
                txtBoxPassword.Text = user.Password;
            }
        }
    }
}
