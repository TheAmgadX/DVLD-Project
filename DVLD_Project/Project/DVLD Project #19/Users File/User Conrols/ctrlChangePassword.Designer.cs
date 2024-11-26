namespace DVLD_Project__19.Users_File.User_Conrols
{
    partial class ctrlChangePassword
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtboxNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtboxCurrentPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtboxConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlUserInfo1 = new DVLD_Project__19.ctrlUserInfo();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxNewPass
            // 
            this.txtboxNewPass.BorderColor = System.Drawing.Color.Black;
            this.txtboxNewPass.BorderRadius = 15;
            this.txtboxNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxNewPass.DefaultText = "";
            this.txtboxNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxNewPass.DisabledState.Parent = this.txtboxNewPass;
            this.txtboxNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxNewPass.FillColor = System.Drawing.Color.Lavender;
            this.txtboxNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxNewPass.FocusedState.Parent = this.txtboxNewPass;
            this.txtboxNewPass.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNewPass.ForeColor = System.Drawing.Color.Black;
            this.txtboxNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxNewPass.HoverState.Parent = this.txtboxNewPass;
            this.txtboxNewPass.Location = new System.Drawing.Point(312, 614);
            this.txtboxNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxNewPass.Name = "txtboxNewPass";
            this.txtboxNewPass.PasswordChar = '*';
            this.txtboxNewPass.PlaceholderText = "";
            this.txtboxNewPass.SelectedText = "";
            this.txtboxNewPass.ShadowDecoration.Parent = this.txtboxNewPass;
            this.txtboxNewPass.Size = new System.Drawing.Size(349, 43);
            this.txtboxNewPass.TabIndex = 1;
            this.txtboxNewPass.Leave += new System.EventHandler(this.txtboxNewPass_Leave);
            // 
            // txtboxCurrentPass
            // 
            this.txtboxCurrentPass.BorderColor = System.Drawing.Color.Black;
            this.txtboxCurrentPass.BorderRadius = 15;
            this.txtboxCurrentPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxCurrentPass.DefaultText = "";
            this.txtboxCurrentPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxCurrentPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxCurrentPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxCurrentPass.DisabledState.Parent = this.txtboxCurrentPass;
            this.txtboxCurrentPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxCurrentPass.FillColor = System.Drawing.Color.Lavender;
            this.txtboxCurrentPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxCurrentPass.FocusedState.Parent = this.txtboxCurrentPass;
            this.txtboxCurrentPass.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCurrentPass.ForeColor = System.Drawing.Color.Black;
            this.txtboxCurrentPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxCurrentPass.HoverState.Parent = this.txtboxCurrentPass;
            this.txtboxCurrentPass.Location = new System.Drawing.Point(312, 560);
            this.txtboxCurrentPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxCurrentPass.Name = "txtboxCurrentPass";
            this.txtboxCurrentPass.PasswordChar = '*';
            this.txtboxCurrentPass.PlaceholderText = "";
            this.txtboxCurrentPass.SelectedText = "";
            this.txtboxCurrentPass.ShadowDecoration.Parent = this.txtboxCurrentPass;
            this.txtboxCurrentPass.Size = new System.Drawing.Size(349, 43);
            this.txtboxCurrentPass.TabIndex = 0;
            this.txtboxCurrentPass.Leave += new System.EventHandler(this.txtboxCurrentPass_Leave);
            // 
            // txtboxConfirmPass
            // 
            this.txtboxConfirmPass.BorderColor = System.Drawing.Color.Black;
            this.txtboxConfirmPass.BorderRadius = 15;
            this.txtboxConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxConfirmPass.DefaultText = "";
            this.txtboxConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxConfirmPass.DisabledState.Parent = this.txtboxConfirmPass;
            this.txtboxConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxConfirmPass.FillColor = System.Drawing.Color.Lavender;
            this.txtboxConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxConfirmPass.FocusedState.Parent = this.txtboxConfirmPass;
            this.txtboxConfirmPass.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxConfirmPass.ForeColor = System.Drawing.Color.Black;
            this.txtboxConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxConfirmPass.HoverState.Parent = this.txtboxConfirmPass;
            this.txtboxConfirmPass.Location = new System.Drawing.Point(312, 667);
            this.txtboxConfirmPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxConfirmPass.Name = "txtboxConfirmPass";
            this.txtboxConfirmPass.PasswordChar = '*';
            this.txtboxConfirmPass.PlaceholderText = "";
            this.txtboxConfirmPass.SelectedText = "";
            this.txtboxConfirmPass.ShadowDecoration.Parent = this.txtboxConfirmPass;
            this.txtboxConfirmPass.Size = new System.Drawing.Size(349, 43);
            this.txtboxConfirmPass.TabIndex = 2;
            this.txtboxConfirmPass.Leave += new System.EventHandler(this.txtboxConfirmPass_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Current Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 674);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Confirm Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 621);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "New Password:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BorderRadius = 15;
            this.btnSave.BorderThickness = 1;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.Lavender;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSave.Location = new System.Drawing.Point(862, 655);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(176, 55);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlUserInfo1
            // 
            this.ctrlUserInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlUserInfo1.Location = new System.Drawing.Point(3, 3);
            this.ctrlUserInfo1.Name = "ctrlUserInfo1";
            this.ctrlUserInfo1.Size = new System.Drawing.Size(1050, 531);
            this.ctrlUserInfo1.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // ctrlChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlUserInfo1);
            this.Controls.Add(this.txtboxConfirmPass);
            this.Controls.Add(this.txtboxCurrentPass);
            this.Controls.Add(this.txtboxNewPass);
            this.Name = "ctrlChangePassword";
            this.Size = new System.Drawing.Size(1064, 735);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtboxNewPass;
        private Guna.UI2.WinForms.Guna2TextBox txtboxCurrentPass;
        private Guna.UI2.WinForms.Guna2TextBox txtboxConfirmPass;
        public ctrlUserInfo ctrlUserInfo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}
