using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business_Layer;

namespace DVLD_Project__19
{
    public partial class Person_Details : UserControl
    {
        public int PersonId = -1;

        public delegate void CloseDelegate();
        public CloseDelegate CloseD;

        public Person_Details()
        {
            InitializeComponent();
        }

        void LoadDateInLabels(Person person)
        {
            if (person == null)
                return;

            lblName.Text = person.FirstName + " " + person.SecondName + " " +
                person.ThirdName + " " + person.LastName;

            lblNationalNum.Text = person.NationalNum;

            lblPhone.Text = person.Phone;
            lblEmail.Text = person.Email;
            lblAddress.Text = person.Address;

            lblCountry.Text = Country.GetCountryName(person.CountryId);

            if (person.Gender == "M")
                lblGender.Text = "Male";
            else
                lblGender.Text = "Female";

            lblDate.Text = person.BirthDate.ToShortDateString();

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

        private void Person_Details_Load(object sender, EventArgs e)
        {
            lblId.Text = PersonId.ToString();

            Person person = Person.Find(PersonId);

            if (person == null)
                return;

            LoadDateInLabels(person);   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseD?.Invoke();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (PersonId == -1)
                {
                    MessageBox.Show("Invalid Person!");
                    return;
                }

                Form frm = new EditPersonForm(PersonId);
                frm.ShowDialog();
            }
            catch { MessageBox.Show("Invalid Person!"); return; }


            Person person = Person.Find(PersonId);

            LoadDateInLabels(person);
        }
    }
}
