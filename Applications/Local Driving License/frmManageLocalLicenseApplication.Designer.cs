namespace People_Management
{
    partial class frmManageLocalLicenseApplication
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageLocalLicenseApplication));
            this.dgvLDLApplications = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsLocalDrivingLicenseApplication = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writingTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practicalTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.IssueDrivingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtFilterAppsBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbFilterAppsBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).BeginInit();
            this.cmsLocalDrivingLicenseApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLDLApplications
            // 
            this.dgvLDLApplications.AllowUserToAddRows = false;
            this.dgvLDLApplications.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLDLApplications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLDLApplications.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLDLApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLDLApplications.ColumnHeadersHeight = 40;
            this.dgvLDLApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLDLApplications.ContextMenuStrip = this.cmsLocalDrivingLicenseApplication;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLDLApplications.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLDLApplications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLDLApplications.Location = new System.Drawing.Point(12, 208);
            this.dgvLDLApplications.Name = "dgvLDLApplications";
            this.dgvLDLApplications.ReadOnly = true;
            this.dgvLDLApplications.RowHeadersVisible = false;
            this.dgvLDLApplications.RowHeadersWidth = 51;
            this.dgvLDLApplications.RowTemplate.Height = 24;
            this.dgvLDLApplications.Size = new System.Drawing.Size(1092, 351);
            this.dgvLDLApplications.TabIndex = 0;
            this.dgvLDLApplications.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLDLApplications.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLDLApplications.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLDLApplications.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLDLApplications.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLDLApplications.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLDLApplications.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLDLApplications.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLDLApplications.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLDLApplications.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLDLApplications.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLDLApplications.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLDLApplications.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvLDLApplications.ThemeStyle.ReadOnly = true;
            this.dgvLDLApplications.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLDLApplications.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLDLApplications.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLDLApplications.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLDLApplications.ThemeStyle.RowsStyle.Height = 24;
            this.dgvLDLApplications.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLDLApplications.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cmsLocalDrivingLicenseApplication
            // 
            this.cmsLocalDrivingLicenseApplication.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsLocalDrivingLicenseApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripSeparator3,
            this.cancelApplicationToolStripMenuItem,
            this.toolStripSeparator4,
            this.scheduleTestsToolStripMenuItem,
            this.toolStripSeparator1,
            this.IssueDrivingToolStripMenuItem,
            this.ShowLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsLocalDrivingLicenseApplication.Name = "guna2ContextMenuStrip1";
            this.cmsLocalDrivingLicenseApplication.RenderStyle.ArrowColor = System.Drawing.Color.LightGreen;
            this.cmsLocalDrivingLicenseApplication.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsLocalDrivingLicenseApplication.RenderStyle.ColorTable = null;
            this.cmsLocalDrivingLicenseApplication.RenderStyle.RoundedEdges = false;
            this.cmsLocalDrivingLicenseApplication.RenderStyle.SelectionArrowColor = System.Drawing.Color.Gainsboro;
            this.cmsLocalDrivingLicenseApplication.RenderStyle.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.cmsLocalDrivingLicenseApplication.RenderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.cmsLocalDrivingLicenseApplication.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsLocalDrivingLicenseApplication.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmsLocalDrivingLicenseApplication.Size = new System.Drawing.Size(305, 321);
            this.cmsLocalDrivingLicenseApplication.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Image = global::People_Management.Properties.Resources.Applications_64;
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 9);
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(304, 34);
            this.showApplicationDetailsToolStripMenuItem.Text = "  Show application details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(301, 6);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 8);
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(304, 33);
            this.editApplicationToolStripMenuItem.Text = "  Edit application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Image = global::People_Management.Properties.Resources.Delete_32;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 8);
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(304, 33);
            this.deleteApplicationToolStripMenuItem.Text = "  Delete application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(301, 6);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = global::People_Management.Properties.Resources.Close_64;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 8);
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(304, 33);
            this.cancelApplicationToolStripMenuItem.Text = "  Cancel application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(301, 6);
            // 
            // scheduleTestsToolStripMenuItem
            // 
            this.scheduleTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTestToolStripMenuItem,
            this.writingTestToolStripMenuItem,
            this.practicalTestToolStripMenuItem});
            this.scheduleTestsToolStripMenuItem.Image = global::People_Management.Properties.Resources.Schedule_Test_512;
            this.scheduleTestsToolStripMenuItem.Name = "scheduleTestsToolStripMenuItem";
            this.scheduleTestsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 8);
            this.scheduleTestsToolStripMenuItem.Size = new System.Drawing.Size(304, 33);
            this.scheduleTestsToolStripMenuItem.Text = "  Schedule Tests";
            // 
            // visionTestToolStripMenuItem
            // 
            this.visionTestToolStripMenuItem.Image = global::People_Management.Properties.Resources.Screenshot_2025_09_04_181224;
            this.visionTestToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            this.visionTestToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 8);
            this.visionTestToolStripMenuItem.Size = new System.Drawing.Size(224, 33);
            this.visionTestToolStripMenuItem.Text = "          Vision Test";
            this.visionTestToolStripMenuItem.Click += new System.EventHandler(this.visionTestToolStripMenuItem_Click);
            // 
            // writingTestToolStripMenuItem
            // 
            this.writingTestToolStripMenuItem.Image = global::People_Management.Properties.Resources.IngWrittenTest;
            this.writingTestToolStripMenuItem.Name = "writingTestToolStripMenuItem";
            this.writingTestToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 8);
            this.writingTestToolStripMenuItem.Size = new System.Drawing.Size(224, 33);
            this.writingTestToolStripMenuItem.Text = "         Writing Test";
            this.writingTestToolStripMenuItem.Click += new System.EventHandler(this.writingTestToolStripMenuItem_Click);
            // 
            // practicalTestToolStripMenuItem
            // 
            this.practicalTestToolStripMenuItem.Image = global::People_Management.Properties.Resources.Wallpaper3;
            this.practicalTestToolStripMenuItem.Name = "practicalTestToolStripMenuItem";
            this.practicalTestToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 8);
            this.practicalTestToolStripMenuItem.Size = new System.Drawing.Size(224, 33);
            this.practicalTestToolStripMenuItem.Text = "        Practical Test";
            this.practicalTestToolStripMenuItem.Click += new System.EventHandler(this.practicalTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(301, 6);
            // 
            // IssueDrivingToolStripMenuItem
            // 
            this.IssueDrivingToolStripMenuItem.Image = global::People_Management.Properties.Resources.car1;
            this.IssueDrivingToolStripMenuItem.Name = "IssueDrivingToolStripMenuItem";
            this.IssueDrivingToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 8);
            this.IssueDrivingToolStripMenuItem.Size = new System.Drawing.Size(304, 33);
            this.IssueDrivingToolStripMenuItem.Text = "  Issue Driving License (First Time)";
            this.IssueDrivingToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // ShowLicenseToolStripMenuItem
            // 
            this.ShowLicenseToolStripMenuItem.Image = global::People_Management.Properties.Resources.LicenseView_400;
            this.ShowLicenseToolStripMenuItem.Name = "ShowLicenseToolStripMenuItem";
            this.ShowLicenseToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 8);
            this.ShowLicenseToolStripMenuItem.Size = new System.Drawing.Size(304, 33);
            this.ShowLicenseToolStripMenuItem.Text = "  Show License";
            this.ShowLicenseToolStripMenuItem.Click += new System.EventHandler(this.ShowLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::People_Management.Properties.Resources.Local_Driving_License_512;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 8);
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(304, 33);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "  Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.DarkGreen;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(300, 21);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Padding = new System.Windows.Forms.Padding(0, 0, 155, 50);
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(818, 97);
            this.guna2HtmlLabel10.TabIndex = 11;
            this.guna2HtmlLabel10.Text = "Manage Local Driving License Applications";
            this.guna2HtmlLabel10.Click += new System.EventHandler(this.guna2HtmlLabel10_Click);
            // 
            // txtFilterAppsBy
            // 
            this.txtFilterAppsBy.BorderRadius = 8;
            this.txtFilterAppsBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterAppsBy.DefaultText = "";
            this.txtFilterAppsBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterAppsBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterAppsBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterAppsBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterAppsBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterAppsBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilterAppsBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterAppsBy.Location = new System.Drawing.Point(447, 150);
            this.txtFilterAppsBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterAppsBy.Name = "txtFilterAppsBy";
            this.txtFilterAppsBy.PlaceholderText = "";
            this.txtFilterAppsBy.SelectedText = "";
            this.txtFilterAppsBy.Size = new System.Drawing.Size(346, 42);
            this.txtFilterAppsBy.TabIndex = 17;
            this.txtFilterAppsBy.TextChanged += new System.EventHandler(this.txtFilterUsersBy_TextChanged);
            this.txtFilterAppsBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterAppsBy_KeyPress);
            // 
            // cmbFilterAppsBy
            // 
            this.cmbFilterAppsBy.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilterAppsBy.BorderRadius = 8;
            this.cmbFilterAppsBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilterAppsBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterAppsBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilterAppsBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilterAppsBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilterAppsBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFilterAppsBy.ItemHeight = 30;
            this.cmbFilterAppsBy.Items.AddRange(new object[] {
            "None",
            "L.D.L.App ID",
            "ClassName",
            "National No",
            "Full Name",
            "Status"});
            this.cmbFilterAppsBy.Location = new System.Drawing.Point(133, 150);
            this.cmbFilterAppsBy.Name = "cmbFilterAppsBy";
            this.cmbFilterAppsBy.Size = new System.Drawing.Size(287, 36);
            this.cmbFilterAppsBy.TabIndex = 15;
            this.cmbFilterAppsBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterAppsBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(23, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filter By :";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::People_Management.Properties.Resources.Applications_64;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(210, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(75, 72);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 25;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.Location = new System.Drawing.Point(1052, 150);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.Size = new System.Drawing.Size(52, 48);
            this.guna2ImageButton1.TabIndex = 18;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // frmManageLocalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1116, 571);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.txtFilterAppsBy);
            this.Controls.Add(this.cmbFilterAppsBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.dgvLDLApplications);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageLocalLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageLocalLicenseApplication";
            this.Load += new System.EventHandler(this.frmManageLocalLicenseApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).EndInit();
            this.cmsLocalDrivingLicenseApplication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvLDLApplications;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterAppsBy;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilterAppsBy;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsLocalDrivingLicenseApplication;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem IssueDrivingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writingTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practicalTestToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}