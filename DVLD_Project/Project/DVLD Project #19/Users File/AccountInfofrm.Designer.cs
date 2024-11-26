namespace DVLD_Project__19.Users_File
{
    partial class AccountInfofrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlUserInfo1 = new DVLD_Project__19.ctrlUserInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChengePassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ctrlUserInfo1
            // 
            this.ctrlUserInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlUserInfo1.Location = new System.Drawing.Point(0, 72);
            this.ctrlUserInfo1.Name = "ctrlUserInfo1";
            this.ctrlUserInfo1.Size = new System.Drawing.Size(1050, 531);
            this.ctrlUserInfo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(288, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "Account Informations";
            // 
            // btnChengePassword
            // 
            this.btnChengePassword.BackColor = System.Drawing.Color.White;
            this.btnChengePassword.BorderRadius = 15;
            this.btnChengePassword.BorderThickness = 1;
            this.btnChengePassword.CheckedState.Parent = this.btnChengePassword;
            this.btnChengePassword.CustomImages.Parent = this.btnChengePassword;
            this.btnChengePassword.FillColor = System.Drawing.Color.Lavender;
            this.btnChengePassword.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChengePassword.ForeColor = System.Drawing.Color.Black;
            this.btnChengePassword.HoverState.Parent = this.btnChengePassword;
            this.btnChengePassword.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnChengePassword.Location = new System.Drawing.Point(704, 641);
            this.btnChengePassword.Name = "btnChengePassword";
            this.btnChengePassword.ShadowDecoration.Parent = this.btnChengePassword;
            this.btnChengePassword.Size = new System.Drawing.Size(238, 55);
            this.btnChengePassword.TabIndex = 13;
            this.btnChengePassword.Text = "Change Password";
            this.btnChengePassword.Click += new System.EventHandler(this.btnChengePassword_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BorderRadius = 15;
            this.btnEdit.BorderThickness = 1;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.Lavender;
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEdit.Location = new System.Drawing.Point(385, 641);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(238, 55);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit Account";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.White;
            this.btnSignOut.BorderRadius = 15;
            this.btnSignOut.BorderThickness = 1;
            this.btnSignOut.CheckedState.Parent = this.btnSignOut;
            this.btnSignOut.CustomImages.Parent = this.btnSignOut;
            this.btnSignOut.FillColor = System.Drawing.Color.Lavender;
            this.btnSignOut.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.Black;
            this.btnSignOut.HoverState.Parent = this.btnSignOut;
            this.btnSignOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSignOut.Location = new System.Drawing.Point(66, 641);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.ShadowDecoration.Parent = this.btnSignOut;
            this.btnSignOut.Size = new System.Drawing.Size(238, 55);
            this.btnSignOut.TabIndex = 15;
            this.btnSignOut.Text = "Sign out";
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // AccountInfofrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 737);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnChengePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlUserInfo1);
            this.Name = "AccountInfofrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserInfofrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlUserInfo ctrlUserInfo1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnChengePassword;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnSignOut;
    }
}