﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project__19.Users_File
{
    public partial class EditUserfrm : Form
    {
        public EditUserfrm(int PersonId)
        {
            InitializeComponent();
        
            ctrlEditUser1.ctrlPersonInfo1.PersonId = PersonId;

            ctrlEditUser1.CloseForm += CloseForm;
        }

        void CloseForm() => this.Close();

    }
}
