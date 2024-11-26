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
    public partial class EditApplicationTypefrm : Form
    {
        int TypeId = -1;

        void LoadTypeData()
        {
            ApplicationsTypes Type = ApplicationsTypes.Find(TypeId);

            lblId.Text = TypeId.ToString();
            txtboxFees.Text = Type.Fees.ToString();
            txtboxTitle.Text = Type.Title;
        }
        public EditApplicationTypefrm(int Id)
        {
            InitializeComponent();
            TypeId = Id;
            
            LoadTypeData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if(txtboxFees.Text.Length <= 0) return true;
            if (txtboxTitle.Text.Length <= 0) return true;

            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(CheckErrorProvidersWork())
            {
                MessageBox.Show("Fill All Required Fields");
                return;
            }

            if (CheckEmptyFields())
            {
                MessageBox.Show("Fill All Required Fields");
                return;
            }

            ApplicationsTypes app = ApplicationsTypes.Find(TypeId);

            app.Fees = Convert.ToDecimal(txtboxFees.Text);
            app.Title = txtboxTitle.Text;

            if(app.Save())
            {
                MessageBox.Show("Application Type Saved Successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Saving Failed!");
            }
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
    }
}
