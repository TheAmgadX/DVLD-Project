using DVLD_Business_Layer;
using Guna.UI2.WinForms.Suite;
using System;
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
    public partial class ctrlShowPersonWithFilter : UserControl
    {
        public ctrlShowPersonWithFilter()
        {
            InitializeComponent();
        }
        private void FillData(Person person)
        {
            person_Details1.PersonId = person.Id; // used for checking when
                                           // click edit btn is id valid or not.

            person_Details1.lblId.Text = person.Id.ToString();

            person_Details1.lblName.Text = person.FirstName + " " + person.SecondName + " " +
                person.ThirdName + " " + person.LastName;

            person_Details1.lblNationalNum.Text = person.NationalNum;

            person_Details1.lblPhone.Text = person.Phone;
            person_Details1.lblEmail.Text = person.Email;
            person_Details1.lblAddress.Text = person.Address;

            person_Details1.lblCountry.Text = Country.GetCountryName(person.CountryId);

            if (person.Gender == "M")
                person_Details1.lblGender.Text = "Male";
            else
                person_Details1.lblGender.Text = "Female";

            person_Details1.lblDate.Text = person.BirthDate.ToShortDateString();

            // Getting The Image 

            if (person.ImagePath == "")
            {
                if (person.Gender == "M")
                    person_Details1.pictureBox1.Image = Properties.Resources.Male_Person;
                else
                    person_Details1.pictureBox1.Image = Properties.Resources.Female_Person;
            }
            else
            {
                person_Details1.pictureBox1.Image = Image.FromFile(person.ImagePath);
            }
        }
        private void ResetData()
        {

            person_Details1.lblId.Text = "???";
            person_Details1.PersonId = -1; // To Reset the Id which used in the edit button

            person_Details1.lblName.Text = "???";

            person_Details1.lblNationalNum.Text = "???";
            person_Details1.lblPhone.Text = "???";
            person_Details1.lblEmail.Text = "???";
            person_Details1.lblAddress.Text = "???";

            person_Details1.lblCountry.Text = "???";

            person_Details1.lblGender.Text = "???";

            person_Details1.lblDate.Text = "???";

            person_Details1.pictureBox1.Image = Properties.Resources.Male_Person;

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBoxFilter.Text == "")
            {
                ResetData();
                return;
            }

            if (cbFilter.SelectedIndex == 1 && int.TryParse(txtBoxFilter.Text, out int id)) // Id
            {
                // Search For Person With Id If Found Fill The Data.
                Person person = Person.Find(id);

                if (person != null)
                    FillData(person);
                
                else
                    ResetData();

            }
            else
                ResetData();

            if (cbFilter.SelectedIndex == 2) // National Id
            {
                Person person = Person.Find(txtBoxFilter.Text);

                if (person != null)
                    FillData(person);
                else
                    ResetData();
            }
        }

        public string PNationNumDelegate = "-1"; // PersonId From Delegate(Add New Person).
        void GetIdOfNewPerson(string nationalNum)
        {
            PNationNumDelegate = nationalNum;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frm = new Add_New_Person_Form();
            frm.ShowDialog();
            // Add The Data Of The New Person.
            if (PNationNumDelegate != "-1")
            {
                txtBoxFilter.Text = PNationNumDelegate;
                cbFilter.SelectedIndex = 1;

                Person person = Person.Find(PNationNumDelegate);
                FillData(person);
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilter.SelectedIndex == 0)
                txtBoxFilter.Visible = false;
            else
                txtBoxFilter.Visible = true;
        }
    }
}
