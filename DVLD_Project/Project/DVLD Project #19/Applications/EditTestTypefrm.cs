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

namespace DVLD_Project__19.Applications
{
    public partial class EditTestTypefrm : Form
    {
        int Id = -1;
        public EditTestTypefrm(int Id)
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void EditTestTypefrm_Load(object sender, EventArgs e)
        {
            TestsTypes test = TestsTypes.Find(Id);
            lblId.Text = test.Id.ToString();
            
            if (test != null)
            {
                txtboxTitle.Text = test.Title;
                txtboxDescription.Text = test.Description;
                txtboxFees.Text = test.Fees.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Hashtable ErrorProviders = new Hashtable();

        bool CheckValidDecimal(string input)
        {
            decimal num;
            // Try to parse the input string as a decimal
            bool isValid = decimal.TryParse(input, out num);

            // Check if it's a valid decimal and also greater than or equal to 0
            if (isValid && num >= 0)
            {
                return true;
            }

            return false;
        }

        bool CheckErrorProvidersWork()
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
            if (txtboxFees.Text.Length <= 0) return true;
            if (txtboxTitle.Text.Length <= 0) return true;
            if (txtboxDescription.Text.Length <= 0) return true;

            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckErrorProvidersWork())
            {
                MessageBox.Show("Fill All Required Fields");
                return;
            }

            if (CheckEmptyFields())
            {
                MessageBox.Show("Fill All Required Fields");
                return;
            }

            TestsTypes test = TestsTypes.Find(Id);

            test.Title = txtboxTitle.Text;
            test.Description = txtboxDescription.Text;
            test.Fees = Convert.ToDecimal(txtboxFees.Text);

            if (test.Save())
            {
                MessageBox.Show("Test Type Saved Successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Saving Failed!");
            }
        }
        private void txtboxFees_Leave(object sender, EventArgs e)
        {
            if (!CheckValidDecimal(txtboxFees.Text))
            {
                errorProvider1.SetError(txtboxFees, "Invalid Fee!");
                ErrorProviders[1] = "1";
            }
            else
            {
                errorProvider1.Clear();
                ErrorProviders[1] = "0";
            }
        }

        private void txtboxTitle_Leave(object sender, EventArgs e)
        {
            if (txtboxTitle.Text.Length == 0)
            {
                errorProvider2.SetError(txtboxTitle, "This Is a Rquired Field");
                ErrorProviders[2] = "1";
            }
            else
            {
                errorProvider2.Clear();
                ErrorProviders[2] = "0";
            }
        }

        private void txtboxDescription_Leave(object sender, EventArgs e)
        {
            if (txtboxDescription.Text.Length == 0)
            {
                errorProvider2.SetError(txtboxTitle, "This Is a Rquired Field");
                ErrorProviders[3] = "1";
            }
            else
            {
                errorProvider2.Clear();
                ErrorProviders[3] = "0";
            }
        }
    }
}
