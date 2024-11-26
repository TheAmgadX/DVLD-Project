using DVLD_Business_Layer;
using DVLD_Project__19.People.UserControls;
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
    public partial class ctrlUserInfo : UserControl
    {
        public ctrlUserInfo()
        {
            InitializeComponent(); 
        }

        void LoadUserData(Users user)
        {
            lblUserId.Text = user.UserId.ToString();

            if(user.IsActive)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";

            lblUsername.Text = user.UserName;
        }
        private void ctrlUserInfo_Load(object sender, EventArgs e)
        {
            Users user = Users.FindWithPersonId(ctrlPersonInfo1.PersonId);
            if (user == null)
                return;
            
            LoadUserData(user);
        }
    }
}
