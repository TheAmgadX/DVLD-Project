﻿using System;
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
    public partial class UserDetailsfrm : Form
    {
        public UserDetailsfrm(int PersonId)
        {
            InitializeComponent();
            ctrlUserInfo1.ctrlPersonInfo1.PersonId = PersonId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
