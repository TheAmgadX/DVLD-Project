using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;
using DVLD_Business_Layer;
using System.Net.Http.Headers;
using System.Collections;

namespace DVLD_Project__19
{
    public partial class ctrlEditPersonData : UserControl
    {
        public ctrlEditPersonData()
        {
            InitializeComponent();
        }

        public delegate void ReturnNationalNum(string NationalNum);
        public ReturnNationalNum returnNationalNum;

        // If used in edit forms.
        public int PersonId = -1;
        private void FillData()
        {
            Person person = Person.Find(PersonId);
            if (person == null)
            {
                MessageBox.Show("Invalid Person Id!");
                return;
            }
            
            txtboxNationalNum.Text = person.NationalNum;

            txtboxFirstName.Text = person.FirstName;
            txtboxSecName.Text = person.SecondName;
            txtboxThirdName.Text = person.ThirdName;
            txtboxLastName.Text = person.LastName;

            txtboxPhone.Text = person.Phone;
            txtboxEmail.Text = person.Email;
            txtBoxAddress.Text = person.Address;

            if(person.Gender == "M")
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            cbCountries.SelectedIndex = person.CountryId - 1; // Country Id - 1 = Country Idx.

            DTBirthDate.Value = person.BirthDate;

            // Getting The Image 

            if (person.ImagePath == "")
            {
                if (person.Gender == "M")
                    pictureBox1.Image = Properties.Resources.Male_Person;
                else
                    pictureBox1.Image = Properties.Resources.Female_Person;
            }
            else
            {
                pictureBox1.Image = Image.FromFile(person.ImagePath);
            }

        }

        public delegate void CloseFormDelegate();

        public event CloseFormDelegate CloseForm;
        private void ctrlAddNewPerson_Load(object sender, EventArgs e)
        {
            DTBirthDate.MaxDate = DateTime.Now.AddYears(-18);

            // Loading Countries in the cbCountries
            DataTable dt = Country.GetAllCountries();

            foreach (DataRow row in dt.Rows)
            {
                cbCountries.Items.Add(row["CountryName"]);
            }

            // if used in Edit Forms.          
            if (PersonId != -1)
            {
                FillData();
                return;
            }

            // if used in Add New Person Forms.
            rbMale.Checked = true;
            cbCountries.SelectedIndex = 50;// Egypt

        }

        private Hashtable ErrorProviders = new Hashtable();
        private bool CheckErrorProvidersWork()
        {
            foreach (DictionaryEntry pair in ErrorProviders)
            {
                if (pair.Value.ToString() == "1")
                    return true;
            }

            return false;
        }

        private bool CheckEmptyFields()
        {
            if (txtboxFirstName.Text == string.Empty)
                return true;

            if (txtboxSecName.Text == string.Empty)
                return true;

            if (txtboxThirdName.Text == string.Empty)
                return true;

            if (txtboxLastName.Text == string.Empty)
                return true;

            if (txtboxNationalNum.Text == string.Empty)
                return true;

            if (txtboxPhone.Text == string.Empty)
                return true;

            if (txtBoxAddress.Text == string.Empty)
                return true;

            return false;
        }

        // Dealing With Image
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked && pictureBox1.Tag == null)
            {
                pictureBox1.Image = DVLD_Project__19.Properties.Resources.Female_Person;
                pictureBox1.Tag = null;
            }
        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked && pictureBox1.Tag == null)
            {
                pictureBox1.Image = DVLD_Project__19.Properties.Resources.Male_Person;
                pictureBox1.Tag = null;
            }
        }
        private string CopyImageToImagesFile()
        {
            // we will test it later after building the back-end.
            string CopyDir = @"C:\PeopleImages";
            Guid guid = Guid.NewGuid();
            string ImagePath = CopyDir + @"\" + guid.ToString() + ".JPG";

            pictureBox1.Image.Save(ImagePath);

            return ImagePath;
        }
        private void lblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.InitialDirectory = @"E:\Programming\P roject 19\Materials";
            openFileDialog1.Filter = "Images (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Tag = openFileDialog1.FileName; // to get the image path
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                lblDeleteImage.Visible = true;
            }
        }
        private void lblDeleteImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (rbFemale.Checked)
            {
                pictureBox1.Image = DVLD_Project__19.Properties.Resources.Female_Person;
                pictureBox1.Tag = null;
            }
            else
            {
                pictureBox1.Image = DVLD_Project__19.Properties.Resources.Male_Person;
                pictureBox1.Tag = null;
            }

            lblDeleteImage.Visible = false;
        }




        // Handling Error Providers:
        private void txtboxFirstName_Leave(object sender, EventArgs e)
        {
            if (txtboxFirstName.Text == "")
            {
                errorProvider1.SetError(txtboxFirstName, "Required");
                ErrorProviders[1] = "1";
            }
            else
            {
                ErrorProviders[1] = "0";
                errorProvider1.Clear();
            }
        }

        private void txtboxSecName_Leave(object sender, EventArgs e)
        {
            if (txtboxSecName.Text == "")
            {
                ErrorProviders[2] = "1";
                errorProvider2.SetError(txtboxSecName, "Required");
            }
            else
            {
                errorProvider2.Clear();
                ErrorProviders[2] = "0";
            }
        }

        private void txtboxThirdName_Leave(object sender, EventArgs e)
        {
            if (txtboxThirdName.Text == "")
            {
                errorProvider3.SetError(txtboxThirdName, "Required");
                ErrorProviders[3] = "1";
            }
            else
            {
                errorProvider3.Clear();
                ErrorProviders[3] = "0";
            }
        }

        private void txtboxLastName_Leave(object sender, EventArgs e)
        {
            if (txtboxLastName.Text == "")
            {
                errorProvider4.SetError(txtboxLastName, "Required");
                ErrorProviders[4] = "1";
            }
            else
            {
                errorProvider4.Clear();
                ErrorProviders[4] = "0";
            }
        }

        private void txtboxNationalNum_Leave(object sender, EventArgs e)
        {
            if (txtboxNationalNum.Text == "")
            {
                errorProvider5.SetError(txtboxNationalNum, "Required");
                ErrorProviders[5] = "1";
            }
            else
            {
                errorProvider5.Clear();
                ErrorProviders[5] = "0";
            }

            // Check if the National Number Exist In The DB Because It's Unique.
            bool Exists = false;

            Person person = Person.Find(txtboxNationalNum.Text);

            if (person != null)
                Exists = true;

            if (Exists)
            {
                errorProvider1.SetError(txtboxNationalNum, "This National Number Already Exists!");
            }
            else
            {
                errorProvider1.Clear();
            }

        }
        private void txtboxPhone_Leave(object sender, EventArgs e)
        {
            if (txtboxPhone.Text == "")
            {
                errorProvider6.SetError(txtboxPhone, "Required");
                ErrorProviders[6] = "1";
            }
            else
            {
                errorProvider6.Clear();
                ErrorProviders[6] = "0";
            }
        }
        private void txtboxEmail_Leave(object sender, EventArgs e)
        {
            // if it's not empty check if the email is in right format.
            if (txtboxEmail.Text != "")
            {
                string[] email = txtboxEmail.Text.Split('@');
                if (email.Length > 1)
                {
                    string[] secondPart = email[1].Split('.');
                    if (secondPart.Length <= 1)
                    {
                        errorProvider7.SetError(txtboxEmail, "Email is not correct");
                        ErrorProviders[7] = "1";
                    }
                    else
                    {
                        errorProvider7.Clear();
                        ErrorProviders[7] = "0";
                    }
                }
                else
                {
                    errorProvider7.SetError(txtboxEmail, "Email is not correct");
                    ErrorProviders[7] = "1";
                }
            }
        }
        private void txtBoxAddress_Leave(object sender, EventArgs e)
        {
            if (txtBoxAddress.Text == "")
            {
                errorProvider8.SetError(txtBoxAddress, "Required");
                ErrorProviders[8] = "1";
            }
            else
            {
                errorProvider8.Clear();
                ErrorProviders[8] = "0";
            }
        }


        // Buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseForm?.Invoke(); // Using Delegate to Use this User Control in multiple forms in the project
        }
        
        void Save(Person person)
        {
            if (person.Save())
            {
                returnNationalNum?.Invoke(person.NationalNum);
                if (MessageBox.Show("Saved Successfully!") == DialogResult.OK)
                    CloseForm?.Invoke();
            }
            else
            {
                MessageBox.Show("Saving Failed");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckErrorProvidersWork())
            {
                MessageBox.Show("Fill All The Required Fields!");
                return;
            }
            if (CheckEmptyFields())
            {
                MessageBox.Show("Fill All The Required Fields!");
                return;
            }

            Person person = new Person();

            if(PersonId != -1)
            {
                person = Person.Find(PersonId);
            }

            person.NationalNum = txtboxNationalNum.Text;

            person.FirstName = txtboxFirstName.Text;
            person.SecondName = txtboxSecName.Text;
            person.ThirdName = txtboxThirdName.Text;
            person.LastName = txtboxLastName.Text;

            person.Address = txtBoxAddress.Text;
            person.Email = txtboxEmail.Text;
            person.Phone = txtboxPhone.Text;

            // idx + 1 = CountryId in the DB Table
            person.CountryId = Convert.ToInt32(cbCountries.SelectedIndex + 1);


            if (rbFemale.Checked)
                person.Gender = "F";
            else
                person.Gender = "M";

            person.BirthDate = DTBirthDate.Value;

            // Saving Image Path:

            // If There Is no Image
            if (pictureBox1.Tag == null)
                person.ImagePath = null;

            else
            {
                // Copy The Image in PeopleImages file in C Drive and return the path.
                person.ImagePath = CopyImageToImagesFile();
            }

            Save(person);
        }
        
    }
}
