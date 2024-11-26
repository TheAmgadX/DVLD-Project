namespace DVLD_Project__19.Users_File
{
    partial class ChangePasswordfrm
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
            this.ctrlChangePassword1 = new DVLD_Project__19.Users_File.User_Conrols.ctrlChangePassword();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlChangePassword1
            // 
            this.ctrlChangePassword1.BackColor = System.Drawing.Color.White;
            this.ctrlChangePassword1.Location = new System.Drawing.Point(-9, 64);
            this.ctrlChangePassword1.Name = "ctrlChangePassword1";
            this.ctrlChangePassword1.Size = new System.Drawing.Size(1079, 735);
            this.ctrlChangePassword1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 48);
            this.label1.TabIndex = 14;
            this.label1.Text = "Change Password";
            // 
            // ChangePasswordfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 794);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlChangePassword1);
            this.Name = "ChangePasswordfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangePasswordfrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Conrols.ctrlChangePassword ctrlChangePassword1;
        private System.Windows.Forms.Label label1;
    }
}