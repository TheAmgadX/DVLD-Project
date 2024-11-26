using DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project__19.Applications.Licenses
{
    public partial class FillLocalDrivingLicenseApplicationDatafrm : Form
    {
        int PersonId = -1;
        string NationalNum = "";
        LicenseClasses lClass = null;
        public FillLocalDrivingLicenseApplicationDatafrm(int PersonId, string NationalNumber)
        {
            InitializeComponent();
            this.PersonId = PersonId;
            NationalNum = NationalNumber;
        }

        private void FillLocalDrivingLicenseApplicationDatafrm_Load(object sender, EventArgs e)
        {
            lblUser.Text = GlobalData.CurrentUser.UserName;

            DataTable dt = LicenseClasses.GetAllLicenseClasses();

            foreach(DataRow Row in dt.Rows)
            {
                cbClasses.Items.Add(Row[1]); // class name
            }

            lblDate.Text = DateTime.Now.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(lblFees.Text == "0")
            {
                MessageBox.Show("Please Choose License Class...", "Invalid",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LocalLicenseApplication application = new LocalLicenseApplication();
            Person person = Person.Find(PersonId);

            application.PersonId = person.Id;
            application.NationalNum = NationalNum;

            application.UserId = GlobalData.CurrentUser.UserId;

            application.Status = "New";
            application.AppDate = DateTime.Now;

            application.ClassId = lClass.Id;
            application.ClassName = cbClasses.SelectedItem.ToString(); // because used in check exist method.


            if(application.Save())
            {
                MessageBox.Show("Application Added Successfully", "Added", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Application Adding Failed There's Application from the same License Class in the system!"
                    , "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lClass = LicenseClasses.SearchForClass(cbClasses.SelectedItem.ToString());
  
            lblFees.Text = lClass.Fees.ToString();
        }
    }
}
