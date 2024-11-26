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
using static DVLD_Project__19.ctrlEditPersonData;

namespace DVLD_Project__19.Users_File.User_Conrols
{
    public partial class ctrlEditUser : UserControl
    {
        public delegate void CloseFormDelegate();
        public CloseFormDelegate CloseForm;
        public ctrlEditUser()
        {
            InitializeComponent();
        }

        bool errors = false;

        public int PersonId = -1;

        Users user;
        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            if(Users.Find(txtboxUsername.Text) != null)
            {
                errorProvider1.SetError(txtboxUsername, "This Username already Exists");
                errors = true;
            }
            else
            {
                errorProvider1.Clear();
                errors = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (errors || txtboxUsername.Text == "")
            {
                MessageBox.Show("Set Valid Username");
                return;
            }

            user.UserName = txtboxUsername.Text;

            if(user.Save())
            {
                MessageBox.Show("User Updated Successfully!", "Saved", MessageBoxButtons.OK
                    ,MessageBoxIcon.Information);

                CloseForm?.Invoke();
            }
            else
            {
                MessageBox.Show("Updating Failed");
            }
        }

        private void ctrlEditUser_Load(object sender, EventArgs e)
        {
            PersonId = ctrlPersonInfo1.PersonId;

            if (PersonId == -1)
            {
                MessageBox.Show("Invalid User ID");
                return;
            }

            user = Users.FindWithPersonId(PersonId);

            txtboxUsername.Text = user.UserName;
        }
    }
}
