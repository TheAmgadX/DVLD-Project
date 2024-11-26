namespace DVLD_Project__19
{
    partial class Add_New_Person_Form
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlEditPersonData1 = new DVLD_Project__19.ctrlEditPersonData();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(520, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(362, 45);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add New Person";
            // 
            // ctrlEditPersonData1
            // 
            this.ctrlEditPersonData1.BackColor = System.Drawing.Color.White;
            this.ctrlEditPersonData1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlEditPersonData1.Location = new System.Drawing.Point(12, 94);
            this.ctrlEditPersonData1.Name = "ctrlEditPersonData1";
            this.ctrlEditPersonData1.Size = new System.Drawing.Size(1368, 476);
            this.ctrlEditPersonData1.TabIndex = 0;
            // 
            // Add_New_Person_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1402, 582);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlEditPersonData1);
            this.Name = "Add_New_Person_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_New_Person_Form";
            this.Load += new System.EventHandler(this.Add_New_Person_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlEditPersonData ctrlEditPersonData1;
        private System.Windows.Forms.Label lblTitle;
    }
}