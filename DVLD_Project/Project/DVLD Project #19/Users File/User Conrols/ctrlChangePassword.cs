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
using DVLD_Business_Layer;
using DVLD_Project__19.People.UserControls;

namespace DVLD_Project__19.Users_File.User_Conrols
{
    public partial class ctrlChangePassword : UserControl
    {
        public delegate void CloseFormDelegate();
        public CloseFormDelegate CloseForm;
        public ctrlChangePassword()
        {
            InitializeComponent();
        }

        Users user;

        bool CheckEmptyFields()
        {
            if (txtboxConfirmPass.Text.Length < 4) return true;
            if (txtboxCurrentPass.Text.Length < 4)  return true; 
            if (txtboxNewPass.Text.Length < 4)  return true; 

            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(CheckEmptyFields())
            {
                MessageBox.Show("Fill All Required Fields!");
                return;
            }

            if (CheckErrorProvidersWorks())
            {
                MessageBox.Show("Fill All Required Fields!");
                return;
            }

            user = Users.FindWithPersonId(ctrlUserInfo1.ctrlPersonInfo1.PersonId);

            user.Password = txtboxNewPass.Text;

            if(user.Save())
            {
                MessageBox.Show("Password Updated Successfully!", "Updated",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CloseForm?.Invoke();
            }
            else
            {
                MessageBox.Show("Updating Failed", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Hashtable ErrorProviders = new Hashtable();
        private bool CheckErrorProvidersWorks()
        {
            foreach (DictionaryEntry pair in ErrorProviders)
            {
                if (pair.Value.ToString() == "1")
                    return true;
            }

            return false;
        }

        private void txtboxCurrentPass_Leave(object sender, EventArgs e)
        {
            user = Users.FindWithPersonId(ctrlUserInfo1.ctrlPersonInfo1.PersonId);
            
            bool WrongPass = user.Password != txtboxCurrentPass.Text;

            if(txtboxCurrentPass.Text == "" || WrongPass)
            {
                errorProvider1.SetError(txtboxCurrentPass, "Wrong Password");
                ErrorProviders[1] = "1";
            }
            else
            {
                errorProvider1.Clear();
                ErrorProviders[1] = "0";
            }
        }

        private void txtboxNewPass_Leave(object sender, EventArgs e)
        {
            if (txtboxNewPass.Text.Length < 4)
            {
                errorProvider2.SetError(txtboxNewPass, "Short Password");
                ErrorProviders[2] = "1";
            }
            else
            {
                errorProvider2.Clear();
                ErrorProviders[2] = "0";
            }
        }

        private void txtboxConfirmPass_Leave(object sender, EventArgs e)
        {
            if (txtboxConfirmPass.Text.Length < 4 ||
                txtboxConfirmPass.Text != txtboxNewPass.Text)
            {
                errorProvider3.SetError(txtboxConfirmPass, "Not Matched Passwords");
                ErrorProviders[3] = "1";
            }
            else
            {
                errorProvider3.Clear();
                ErrorProviders[3] = "0";
            }
        }
    

    }
}
