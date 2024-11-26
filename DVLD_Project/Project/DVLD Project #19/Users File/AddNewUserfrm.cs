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
    public partial class AddNewUserfrm : Form
    {
        public AddNewUserfrm()
        {
            InitializeComponent();
        }
        private void CloseForm()
        {
            this.Close();
        }
        private void AddNewUserfrm_Load(object sender, EventArgs e)
        {
            ctrlShowPersonWithFilter1.person_Details1.CloseD += CloseForm;
        }

        private int PersonId = -1;

        private void btnNext_Click(object sender, EventArgs e)
        {
            PersonId = ctrlShowPersonWithFilter1.person_Details1.PersonId;

            if (PersonId == -1)
            {
                MessageBox.Show("Person Id is Invalid!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Form frm = new FillUserDatafrm(PersonId);
            frm.ShowDialog();
        }
    }
}
