﻿namespace DVLD_Project__19.People
{
    partial class PersonDetailsFrm
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
            this.person_Details1 = new DVLD_Project__19.Person_Details();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // person_Details1
            // 
            this.person_Details1.BackColor = System.Drawing.Color.White;
            this.person_Details1.Location = new System.Drawing.Point(12, 123);
            this.person_Details1.Name = "person_Details1";
            this.person_Details1.Size = new System.Drawing.Size(1050, 381);
            this.person_Details1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(396, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person Details";
            // 
            // PersonDetailsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1077, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.person_Details1);
            this.Name = "PersonDetailsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonDetailsFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Person_Details person_Details1;
        private System.Windows.Forms.Label label1;
    }
}