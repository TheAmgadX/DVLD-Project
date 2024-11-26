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
    public partial class AddNewDrivingLicensesApplicationfrm : Form
    {
        public AddNewDrivingLicensesApplicationfrm()
        {
            InitializeComponent();
            ctrlShowPersonWithFilter1.person_Details1.CloseD += CloseForm; 
        }

        void CloseForm() => this.Close();

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(ctrlShowPersonWithFilter1.person_Details1.PersonId == -1)
            {
                MessageBox.Show("Invalid Person!");
                return;
            }

            Form frm = new FillLocalDrivingLicenseApplicationDatafrm(ctrlShowPersonWithFilter1.
                person_Details1.PersonId, ctrlShowPersonWithFilter1.person_Details1.lblNationalNum.Text);
            frm.ShowDialog();
        }
    }
}
