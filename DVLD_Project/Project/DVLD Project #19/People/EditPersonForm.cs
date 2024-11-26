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
    public partial class EditPersonForm : Form
    {
        public EditPersonForm(int Id)
        {
            InitializeComponent();

            if (!this.DesignMode)
            {
                ctrlEditPersonData1.PersonId = Id;
                ctrlEditPersonData1.CloseForm += CloseForm;
            }
        }
        void CloseForm()
        {
            this.Close();
        }
    }
}
