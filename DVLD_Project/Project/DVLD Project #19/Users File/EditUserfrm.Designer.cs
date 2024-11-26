namespace DVLD_Project__19.Users_File
{
    partial class EditUserfrm
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
            this.ctrlEditUser1 = new DVLD_Project__19.Users_File.User_Conrols.ctrlEditUser();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlEditUser1
            // 
            this.ctrlEditUser1.BackColor = System.Drawing.Color.White;
            this.ctrlEditUser1.Location = new System.Drawing.Point(-5, 72);
            this.ctrlEditUser1.Name = "ctrlEditUser1";
            this.ctrlEditUser1.Size = new System.Drawing.Size(1042, 521);
            this.ctrlEditUser1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 48);
            this.label1.TabIndex = 14;
            this.label1.Text = "Edit User";
            // 
            // EditUserfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlEditUser1);
            this.Name = "EditUserfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditUserfrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Conrols.ctrlEditUser ctrlEditUser1;
        private System.Windows.Forms.Label label1;
    }
}