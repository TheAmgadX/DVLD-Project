﻿namespace DVLD_Project__19.Applications.Licenses
{
    partial class AddNewDrivingLicensesApplicationfrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlShowPersonWithFilter1 = new DVLD_Project__19.ctrlShowPersonWithFilter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(881, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "New Local Driving License Application";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.BorderRadius = 15;
            this.btnNext.BorderThickness = 1;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.FillColor = System.Drawing.Color.Lavender;
            this.btnNext.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Location = new System.Drawing.Point(908, 559);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(157, 48);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlShowPersonWithFilter1
            // 
            this.ctrlShowPersonWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlShowPersonWithFilter1.Location = new System.Drawing.Point(5, 72);
            this.ctrlShowPersonWithFilter1.Name = "ctrlShowPersonWithFilter1";
            this.ctrlShowPersonWithFilter1.Size = new System.Drawing.Size(1097, 481);
            this.ctrlShowPersonWithFilter1.TabIndex = 0;
            // 
            // AddNewDrivingLicensesApplicationfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 619);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlShowPersonWithFilter1);
            this.Name = "AddNewDrivingLicensesApplicationfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddNewDrivingLicensesApplicationfrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlShowPersonWithFilter ctrlShowPersonWithFilter1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
    }
}