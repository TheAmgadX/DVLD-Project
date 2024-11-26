namespace DVLD_Project__19.Applications
{
    partial class Applicationsfrm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DrivingLicensesServicesTap = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageApplicationsTap = new System.Windows.Forms.TabPage();
            this.tabControlManageApplications = new System.Windows.Forms.TabControl();
            this.tabLocalDrivingLicensesApplications = new System.Windows.Forms.TabPage();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtboxFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddNewLocalLicenseApp = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridLocalLicensesApp = new System.Windows.Forms.DataGridView();
            this.contextMenuStripLocalLicensesApps = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.applicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedualeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.tabInternationalLicensesApplications = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.DetainLicensesTap = new System.Windows.Forms.TabPage();
            this.applicationTypesTap = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridAppTypes = new System.Windows.Forms.DataGridView();
            this.contextMenuStripAppTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditAppTypesStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testsTypesTap = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridTestsTypes = new System.Windows.Forms.DataGridView();
            this.contextMenuStripTestsTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditTestsTypesMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.DrivingLicensesServicesTap.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ManageApplicationsTap.SuspendLayout();
            this.tabControlManageApplications.SuspendLayout();
            this.tabLocalDrivingLicensesApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocalLicensesApp)).BeginInit();
            this.contextMenuStripLocalLicensesApps.SuspendLayout();
            this.tabInternationalLicensesApplications.SuspendLayout();
            this.applicationTypesTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppTypes)).BeginInit();
            this.contextMenuStripAppTypes.SuspendLayout();
            this.testsTypesTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTestsTypes)).BeginInit();
            this.contextMenuStripTestsTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DrivingLicensesServicesTap);
            this.tabControl1.Controls.Add(this.ManageApplicationsTap);
            this.tabControl1.Controls.Add(this.DetainLicensesTap);
            this.tabControl1.Controls.Add(this.applicationTypesTap);
            this.tabControl1.Controls.Add(this.testsTypesTap);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1558, 722);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // DrivingLicensesServicesTap
            // 
            this.DrivingLicensesServicesTap.Controls.Add(this.menuStrip1);
            this.DrivingLicensesServicesTap.Location = new System.Drawing.Point(4, 29);
            this.DrivingLicensesServicesTap.Name = "DrivingLicensesServicesTap";
            this.DrivingLicensesServicesTap.Size = new System.Drawing.Size(1550, 689);
            this.DrivingLicensesServicesTap.TabIndex = 3;
            this.DrivingLicensesServicesTap.Text = "Driving Licenses Services";
            this.DrivingLicensesServicesTap.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1550, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            // 
            // ManageApplicationsTap
            // 
            this.ManageApplicationsTap.Controls.Add(this.tabControlManageApplications);
            this.ManageApplicationsTap.Location = new System.Drawing.Point(4, 29);
            this.ManageApplicationsTap.Name = "ManageApplicationsTap";
            this.ManageApplicationsTap.Size = new System.Drawing.Size(1550, 689);
            this.ManageApplicationsTap.TabIndex = 2;
            this.ManageApplicationsTap.Text = "Manage Applications";
            this.ManageApplicationsTap.UseVisualStyleBackColor = true;
            // 
            // tabControlManageApplications
            // 
            this.tabControlManageApplications.Controls.Add(this.tabLocalDrivingLicensesApplications);
            this.tabControlManageApplications.Controls.Add(this.tabInternationalLicensesApplications);
            this.tabControlManageApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlManageApplications.Location = new System.Drawing.Point(0, 0);
            this.tabControlManageApplications.Name = "tabControlManageApplications";
            this.tabControlManageApplications.SelectedIndex = 0;
            this.tabControlManageApplications.Size = new System.Drawing.Size(1550, 689);
            this.tabControlManageApplications.TabIndex = 0;
            this.tabControlManageApplications.SelectedIndexChanged += new System.EventHandler(this.tabControlManageApplications_SelectedIndexChanged);
            // 
            // tabLocalDrivingLicensesApplications
            // 
            this.tabLocalDrivingLicensesApplications.Controls.Add(this.cbStatus);
            this.tabLocalDrivingLicensesApplications.Controls.Add(this.txtboxFilter);
            this.tabLocalDrivingLicensesApplications.Controls.Add(this.cbFilter);
            this.tabLocalDrivingLicensesApplications.Controls.Add(this.label5);
            this.tabLocalDrivingLicensesApplications.Controls.Add(this.btnAddNewLocalLicenseApp);
            this.tabLocalDrivingLicensesApplications.Controls.Add(this.dataGridLocalLicensesApp);
            this.tabLocalDrivingLicensesApplications.Controls.Add(this.label3);
            this.tabLocalDrivingLicensesApplications.Location = new System.Drawing.Point(4, 29);
            this.tabLocalDrivingLicensesApplications.Name = "tabLocalDrivingLicensesApplications";
            this.tabLocalDrivingLicensesApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocalDrivingLicensesApplications.Size = new System.Drawing.Size(1542, 656);
            this.tabLocalDrivingLicensesApplications.TabIndex = 0;
            this.tabLocalDrivingLicensesApplications.Text = "Local Driving Licenses Applications";
            this.tabLocalDrivingLicensesApplications.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BorderColor = System.Drawing.Color.Black;
            this.cbStatus.BorderRadius = 15;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FillColor = System.Drawing.Color.Lavender;
            this.cbStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cbStatus.FocusedState.Parent = this.cbStatus;
            this.cbStatus.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ForeColor = System.Drawing.Color.Black;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.HoverState.Parent = this.cbStatus;
            this.cbStatus.ItemHeight = 30;
            this.cbStatus.Items.AddRange(new object[] {
            "New",
            "Cancelled",
            "Completed"});
            this.cbStatus.ItemsAppearance.Parent = this.cbStatus;
            this.cbStatus.Location = new System.Drawing.Point(526, 118);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.ShadowDecoration.Parent = this.cbStatus;
            this.cbStatus.Size = new System.Drawing.Size(291, 36);
            this.cbStatus.TabIndex = 14;
            this.cbStatus.Visible = false;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // txtboxFilter
            // 
            this.txtboxFilter.BorderColor = System.Drawing.Color.Black;
            this.txtboxFilter.BorderRadius = 15;
            this.txtboxFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxFilter.DefaultText = "";
            this.txtboxFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxFilter.DisabledState.Parent = this.txtboxFilter;
            this.txtboxFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxFilter.FillColor = System.Drawing.Color.Lavender;
            this.txtboxFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxFilter.FocusedState.Parent = this.txtboxFilter;
            this.txtboxFilter.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFilter.ForeColor = System.Drawing.Color.Black;
            this.txtboxFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxFilter.HoverState.Parent = this.txtboxFilter;
            this.txtboxFilter.Location = new System.Drawing.Point(526, 115);
            this.txtboxFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxFilter.Name = "txtboxFilter";
            this.txtboxFilter.PasswordChar = '\0';
            this.txtboxFilter.PlaceholderText = "";
            this.txtboxFilter.SelectedText = "";
            this.txtboxFilter.ShadowDecoration.Parent = this.txtboxFilter;
            this.txtboxFilter.Size = new System.Drawing.Size(291, 43);
            this.txtboxFilter.TabIndex = 12;
            this.txtboxFilter.Visible = false;
            this.txtboxFilter.TextChanged += new System.EventHandler(this.txtboxFilter_TextChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BorderColor = System.Drawing.Color.Black;
            this.cbFilter.BorderRadius = 15;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FillColor = System.Drawing.Color.Lavender;
            this.cbFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilter.FocusedState.Parent = this.cbFilter;
            this.cbFilter.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.ForeColor = System.Drawing.Color.Black;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.HoverState.Parent = this.cbFilter;
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Application Id",
            "National Number",
            "FullName",
            "Status"});
            this.cbFilter.ItemsAppearance.Parent = this.cbFilter;
            this.cbFilter.Location = new System.Drawing.Point(173, 118);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.ShadowDecoration.Parent = this.cbFilter;
            this.cbFilter.Size = new System.Drawing.Size(328, 36);
            this.cbFilter.TabIndex = 13;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Filter By";
            // 
            // btnAddNewLocalLicenseApp
            // 
            this.btnAddNewLocalLicenseApp.CheckedState.Parent = this.btnAddNewLocalLicenseApp;
            this.btnAddNewLocalLicenseApp.CustomImages.Parent = this.btnAddNewLocalLicenseApp;
            this.btnAddNewLocalLicenseApp.FillColor = System.Drawing.Color.White;
            this.btnAddNewLocalLicenseApp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewLocalLicenseApp.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewLocalLicenseApp.HoverState.Parent = this.btnAddNewLocalLicenseApp;
            this.btnAddNewLocalLicenseApp.Image = global::DVLD_Project__19.Properties.Resources.Add_Person_Icon;
            this.btnAddNewLocalLicenseApp.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewLocalLicenseApp.Location = new System.Drawing.Point(1434, 113);
            this.btnAddNewLocalLicenseApp.Name = "btnAddNewLocalLicenseApp";
            this.btnAddNewLocalLicenseApp.ShadowDecoration.Parent = this.btnAddNewLocalLicenseApp;
            this.btnAddNewLocalLicenseApp.Size = new System.Drawing.Size(80, 63);
            this.btnAddNewLocalLicenseApp.TabIndex = 9;
            this.btnAddNewLocalLicenseApp.Click += new System.EventHandler(this.btnAddNewLocalLicenseApp_Click);
            // 
            // dataGridLocalLicensesApp
            // 
            this.dataGridLocalLicensesApp.BackgroundColor = System.Drawing.Color.White;
            this.dataGridLocalLicensesApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLocalLicensesApp.ContextMenuStrip = this.contextMenuStripLocalLicensesApps;
            this.dataGridLocalLicensesApp.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridLocalLicensesApp.Location = new System.Drawing.Point(29, 182);
            this.dataGridLocalLicensesApp.Name = "dataGridLocalLicensesApp";
            this.dataGridLocalLicensesApp.RowHeadersWidth = 20;
            this.dataGridLocalLicensesApp.RowTemplate.Height = 24;
            this.dataGridLocalLicensesApp.Size = new System.Drawing.Size(1485, 453);
            this.dataGridLocalLicensesApp.TabIndex = 7;
            // 
            // contextMenuStripLocalLicensesApps
            // 
            this.contextMenuStripLocalLicensesApps.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripLocalLicensesApps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationDetailsToolStripMenuItem,
            this.deleteApplicationsToolStripMenuItem,
            this.EditAppToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.schedualeToolStripMenuItem,
            this.issueDrivingLicenseToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStripLocalLicensesApps.Name = "contextMenuStrip1";
            this.contextMenuStripLocalLicensesApps.Size = new System.Drawing.Size(269, 212);
            // 
            // applicationDetailsToolStripMenuItem
            // 
            this.applicationDetailsToolStripMenuItem.Image = global::DVLD_Project__19.Properties.Resources.License_Card_Icon;
            this.applicationDetailsToolStripMenuItem.Name = "applicationDetailsToolStripMenuItem";
            this.applicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.applicationDetailsToolStripMenuItem.Text = "Application Details";
            // 
            // deleteApplicationsToolStripMenuItem
            // 
            this.deleteApplicationsToolStripMenuItem.Image = global::DVLD_Project__19.Properties.Resources.Delete_Icon;
            this.deleteApplicationsToolStripMenuItem.Name = "deleteApplicationsToolStripMenuItem";
            this.deleteApplicationsToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.deleteApplicationsToolStripMenuItem.Text = "delete Application";
            this.deleteApplicationsToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationsToolStripMenuItem_Click);
            // 
            // EditAppToolStripMenuItem
            // 
            this.EditAppToolStripMenuItem.Image = global::DVLD_Project__19.Properties.Resources.Edit_Icon;
            this.EditAppToolStripMenuItem.Name = "EditAppToolStripMenuItem";
            this.EditAppToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.EditAppToolStripMenuItem.Text = "Edit Application";
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = global::DVLD_Project__19.Properties.Resources.cancel;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // schedualeToolStripMenuItem
            // 
            this.schedualeToolStripMenuItem.Image = global::DVLD_Project__19.Properties.Resources.Schedule;
            this.schedualeToolStripMenuItem.Name = "schedualeToolStripMenuItem";
            this.schedualeToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.schedualeToolStripMenuItem.Text = "Schedule Test ";
            // 
            // issueDrivingLicenseToolStripMenuItem
            // 
            this.issueDrivingLicenseToolStripMenuItem.Enabled = false;
            this.issueDrivingLicenseToolStripMenuItem.Image = global::DVLD_Project__19.Properties.Resources.Add_License_Icon;
            this.issueDrivingLicenseToolStripMenuItem.Name = "issueDrivingLicenseToolStripMenuItem";
            this.issueDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.issueDrivingLicenseToolStripMenuItem.Text = "Issue Driving License";
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Enabled = false;
            this.showLicenseToolStripMenuItem.Image = global::DVLD_Project__19.Properties.Resources.License_Icon;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_Project__19.Properties.Resources.History_Icon;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(453, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(637, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Local Licenses Applications";
            // 
            // tabInternationalLicensesApplications
            // 
            this.tabInternationalLicensesApplications.Controls.Add(this.label4);
            this.tabInternationalLicensesApplications.Location = new System.Drawing.Point(4, 29);
            this.tabInternationalLicensesApplications.Name = "tabInternationalLicensesApplications";
            this.tabInternationalLicensesApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabInternationalLicensesApplications.Size = new System.Drawing.Size(1542, 656);
            this.tabInternationalLicensesApplications.TabIndex = 1;
            this.tabInternationalLicensesApplications.Text = "International Licenses Applications";
            this.tabInternationalLicensesApplications.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(361, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(821, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "International Licenses Applications";
            // 
            // DetainLicensesTap
            // 
            this.DetainLicensesTap.Location = new System.Drawing.Point(4, 29);
            this.DetainLicensesTap.Name = "DetainLicensesTap";
            this.DetainLicensesTap.Size = new System.Drawing.Size(1550, 689);
            this.DetainLicensesTap.TabIndex = 4;
            this.DetainLicensesTap.Text = "Detain Licenses";
            this.DetainLicensesTap.UseVisualStyleBackColor = true;
            // 
            // applicationTypesTap
            // 
            this.applicationTypesTap.Controls.Add(this.label1);
            this.applicationTypesTap.Controls.Add(this.dataGridAppTypes);
            this.applicationTypesTap.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationTypesTap.Location = new System.Drawing.Point(4, 29);
            this.applicationTypesTap.Name = "applicationTypesTap";
            this.applicationTypesTap.Padding = new System.Windows.Forms.Padding(3);
            this.applicationTypesTap.Size = new System.Drawing.Size(1550, 689);
            this.applicationTypesTap.TabIndex = 0;
            this.applicationTypesTap.Text = "Application Types";
            this.applicationTypesTap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(553, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Applications Types";
            // 
            // dataGridAppTypes
            // 
            this.dataGridAppTypes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAppTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAppTypes.ContextMenuStrip = this.contextMenuStripAppTypes;
            this.dataGridAppTypes.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridAppTypes.Location = new System.Drawing.Point(309, 112);
            this.dataGridAppTypes.Name = "dataGridAppTypes";
            this.dataGridAppTypes.RowHeadersWidth = 51;
            this.dataGridAppTypes.RowTemplate.Height = 24;
            this.dataGridAppTypes.Size = new System.Drawing.Size(932, 384);
            this.dataGridAppTypes.TabIndex = 1;
            // 
            // contextMenuStripAppTypes
            // 
            this.contextMenuStripAppTypes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripAppTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditAppTypesStripMenuItem});
            this.contextMenuStripAppTypes.Name = "contextMenuStrip1";
            this.contextMenuStripAppTypes.Size = new System.Drawing.Size(109, 30);
            // 
            // EditAppTypesStripMenuItem
            // 
            this.EditAppTypesStripMenuItem.Image = global::DVLD_Project__19.Properties.Resources.Edit_Icon;
            this.EditAppTypesStripMenuItem.Name = "EditAppTypesStripMenuItem";
            this.EditAppTypesStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.EditAppTypesStripMenuItem.Text = "Edit";
            this.EditAppTypesStripMenuItem.Click += new System.EventHandler(this.EditAppTypesStripMenuItem_Click);
            // 
            // testsTypesTap
            // 
            this.testsTypesTap.Controls.Add(this.label2);
            this.testsTypesTap.Controls.Add(this.dataGridTestsTypes);
            this.testsTypesTap.Location = new System.Drawing.Point(4, 29);
            this.testsTypesTap.Name = "testsTypesTap";
            this.testsTypesTap.Padding = new System.Windows.Forms.Padding(3);
            this.testsTypesTap.Size = new System.Drawing.Size(1550, 689);
            this.testsTypesTap.TabIndex = 1;
            this.testsTypesTap.Text = "Tests Types";
            this.testsTypesTap.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(632, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 48);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tests Types";
            // 
            // dataGridTestsTypes
            // 
            this.dataGridTestsTypes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridTestsTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTestsTypes.ContextMenuStrip = this.contextMenuStripTestsTypes;
            this.dataGridTestsTypes.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridTestsTypes.Location = new System.Drawing.Point(217, 112);
            this.dataGridTestsTypes.Name = "dataGridTestsTypes";
            this.dataGridTestsTypes.RowHeadersWidth = 51;
            this.dataGridTestsTypes.RowTemplate.Height = 24;
            this.dataGridTestsTypes.Size = new System.Drawing.Size(1117, 384);
            this.dataGridTestsTypes.TabIndex = 6;
            // 
            // contextMenuStripTestsTypes
            // 
            this.contextMenuStripTestsTypes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripTestsTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditTestsTypesMenuStripItem});
            this.contextMenuStripTestsTypes.Name = "contextMenuStrip1";
            this.contextMenuStripTestsTypes.Size = new System.Drawing.Size(109, 30);
            // 
            // EditTestsTypesMenuStripItem
            // 
            this.EditTestsTypesMenuStripItem.Image = global::DVLD_Project__19.Properties.Resources.Edit_Icon;
            this.EditTestsTypesMenuStripItem.Name = "EditTestsTypesMenuStripItem";
            this.EditTestsTypesMenuStripItem.Size = new System.Drawing.Size(108, 26);
            this.EditTestsTypesMenuStripItem.Text = "Edit";
            this.EditTestsTypesMenuStripItem.Click += new System.EventHandler(this.EditTestsTypesMenuStripItem_Click);
            // 
            // Applicationsfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1558, 722);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Applicationsfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applicationsfrm";
            this.Load += new System.EventHandler(this.Applicationsfrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.DrivingLicensesServicesTap.ResumeLayout(false);
            this.DrivingLicensesServicesTap.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ManageApplicationsTap.ResumeLayout(false);
            this.tabControlManageApplications.ResumeLayout(false);
            this.tabLocalDrivingLicensesApplications.ResumeLayout(false);
            this.tabLocalDrivingLicensesApplications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocalLicensesApp)).EndInit();
            this.contextMenuStripLocalLicensesApps.ResumeLayout(false);
            this.tabInternationalLicensesApplications.ResumeLayout(false);
            this.tabInternationalLicensesApplications.PerformLayout();
            this.applicationTypesTap.ResumeLayout(false);
            this.applicationTypesTap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppTypes)).EndInit();
            this.contextMenuStripAppTypes.ResumeLayout(false);
            this.testsTypesTap.ResumeLayout(false);
            this.testsTypesTap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTestsTypes)).EndInit();
            this.contextMenuStripTestsTypes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage applicationTypesTap;
        private System.Windows.Forms.TabPage testsTypesTap;
        private System.Windows.Forms.DataGridView dataGridAppTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAppTypes;
        private System.Windows.Forms.ToolStripMenuItem EditAppTypesStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridTestsTypes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTestsTypes;
        private System.Windows.Forms.ToolStripMenuItem EditTestsTypesMenuStripItem;
        private System.Windows.Forms.TabPage DrivingLicensesServicesTap;
        private System.Windows.Forms.TabPage ManageApplicationsTap;
        private System.Windows.Forms.TabPage DetainLicensesTap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlManageApplications;
        private System.Windows.Forms.TabPage tabLocalDrivingLicensesApplications;
        private System.Windows.Forms.TabPage tabInternationalLicensesApplications;
        private System.Windows.Forms.DataGridView dataGridLocalLicensesApp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLocalLicensesApps;
        private System.Windows.Forms.ToolStripMenuItem EditAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedualeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnAddNewLocalLicenseApp;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtboxFilter;
    }
}