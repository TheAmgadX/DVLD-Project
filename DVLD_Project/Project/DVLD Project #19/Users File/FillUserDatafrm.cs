using DVLD_Business_Layer;
using System;
using System.Collections;
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
    public partial class FillUserDatafrm : Form
    {
        int personId = -1;
        public FillUserDatafrm(int personId)
        {
            InitializeComponent();
            this.personId = personId;
        }

        private void txtboxUsername_Leave(object sender, EventArgs e)
        {
            Users user = Users.Find(txtboxUsername.Text);
            if(user != null)
            {
                errorProvider1.SetError(txtboxUsername, "The username you entered already exists.");
                ErrorProviders[1] = "1";
            }
            else
            {
                if(txtboxUsername.Text == "")
                {
                    errorProvider1.SetError(txtboxUsername, "The username you entered too short.");
                    ErrorProviders[1] = "1";
                }
                else
                {
                    errorProvider1.Clear();
                    ErrorProviders[1] = "0";
                }
            }
        }

        private void txtboxConfirm_Leave(object sender, EventArgs e)
        {
            if (txtboxConfirm.Text != txtboxPassword.Text)
            {
                errorProvider3.SetError(txtboxConfirm, "Passwords do not match. Please try again.");
                ErrorProviders[2] = "1";
            }
            else
            {
                if(txtboxConfirm.Text == "" || txtboxPassword.Text.Length < 4)
                {
                    errorProvider3.SetError(txtboxConfirm, "The Password is too short!");
                    ErrorProviders[2] = "1";
                }
                else
                {
                    errorProvider3.Clear();
                    ErrorProviders[2] = "0";
                }
            }

        }

        private void txtboxPassword_Leave(object sender, EventArgs e)
        {
            if (txtboxPassword.Text == "" || txtboxPassword.Text.Length < 4)
            {
                errorProvider2.SetError(txtboxPassword, "The Password is too short!");
                ErrorProviders[3] = "1";
            }
            else
            {
                errorProvider2.Clear();
                ErrorProviders[3] = "0";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Hashtable ErrorProviders = new Hashtable();
        private bool CheckErrorProviders()
        {
            foreach (DictionaryEntry pair in ErrorProviders)
            {
                if (pair.Value.ToString() == "1")
                    return true;
            }

            return false;
        }
        bool CheckEmptyFields()
        {
            if(txtboxConfirm.Text.Length < 3) return false;
            if(txtboxPassword.Text.Length < 3) return false;
            if(txtboxUsername.Text.Length == 0) return false;

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckErrorProviders())
            {
                MessageBox.Show("Fill All The Required Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!CheckEmptyFields())
            {
                MessageBox.Show("Fill All The Required Fields!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Users user = new Users();

            user.UserName = txtboxUsername.Text;
            user.Password = txtboxPassword.Text;
            user.IsActive = checkBox1.Checked;
            user.PersonId = personId;


            if (user.Save())
            {
                MessageBox.Show("User Saved Successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Saving Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
