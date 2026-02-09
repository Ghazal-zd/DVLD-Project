namespace People_Management
{
    partial class frmIssueInternationalLicense
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
            this.btnIssue = new Guna.UI2.WinForms.Guna2Button();
            this.btnClosee = new Guna.UI2.WinForms.Guna2Button();
            this.lnkLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lnkLblLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.pnlApplicationInfo = new System.Windows.Forms.Panel();
            this.lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLDLLicenseID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblIntLicenseID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFees = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblExeprationDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblIssueDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblApplicationDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblApplicationID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ctrLicenseInfoWithFilter1 = new People_Management.ctrLicenseInfoWithFilter();
            this.pnlApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIssue
            // 
            this.btnIssue.BorderRadius = 8;
            this.btnIssue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIssue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIssue.Enabled = false;
            this.btnIssue.FillColor = System.Drawing.Color.DarkGreen;
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.Location = new System.Drawing.Point(954, 793);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(180, 45);
            this.btnIssue.TabIndex = 2;
            this.btnIssue.Text = "Issue";
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnClosee
            // 
            this.btnClosee.BorderRadius = 8;
            this.btnClosee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClosee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClosee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClosee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClosee.FillColor = System.Drawing.Color.DarkGreen;
            this.btnClosee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClosee.ForeColor = System.Drawing.Color.White;
            this.btnClosee.Location = new System.Drawing.Point(741, 793);
            this.btnClosee.Name = "btnClosee";
            this.btnClosee.Size = new System.Drawing.Size(180, 45);
            this.btnClosee.TabIndex = 3;
            this.btnClosee.Text = "Close";
            this.btnClosee.Click += new System.EventHandler(this.btnClosee_Click);
            // 
            // lnkLicenseInfo
            // 
            this.lnkLicenseInfo.AutoSize = true;
            this.lnkLicenseInfo.Enabled = false;
            this.lnkLicenseInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLicenseInfo.Location = new System.Drawing.Point(241, 793);
            this.lnkLicenseInfo.Name = "lnkLicenseInfo";
            this.lnkLicenseInfo.Size = new System.Drawing.Size(161, 25);
            this.lnkLicenseInfo.TabIndex = 7;
            this.lnkLicenseInfo.TabStop = true;
            this.lnkLicenseInfo.Text = "Show License Info";
            this.lnkLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLicenseInfo_LinkClicked);
            // 
            // lnkLblLicenseHistory
            // 
            this.lnkLblLicenseHistory.AutoSize = true;
            this.lnkLblLicenseHistory.Enabled = false;
            this.lnkLblLicenseHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLblLicenseHistory.Location = new System.Drawing.Point(15, 793);
            this.lnkLblLicenseHistory.Name = "lnkLblLicenseHistory";
            this.lnkLblLicenseHistory.Size = new System.Drawing.Size(189, 25);
            this.lnkLblLicenseHistory.TabIndex = 8;
            this.lnkLblLicenseHistory.TabStop = true;
            this.lnkLblLicenseHistory.Text = "Show License History";
            this.lnkLblLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblLicenseHistory_LinkClicked);
            // 
            // pnlApplicationInfo
            // 
            this.pnlApplicationInfo.Controls.Add(this.lbl);
            this.pnlApplicationInfo.Controls.Add(this.lblLDLLicenseID);
            this.pnlApplicationInfo.Controls.Add(this.guna2HtmlLabel6);
            this.pnlApplicationInfo.Controls.Add(this.lblIntLicenseID);
            this.pnlApplicationInfo.Controls.Add(this.guna2HtmlLabel3);
            this.pnlApplicationInfo.Controls.Add(this.lblFees);
            this.pnlApplicationInfo.Controls.Add(this.lblExeprationDate);
            this.pnlApplicationInfo.Controls.Add(this.lblUserName);
            this.pnlApplicationInfo.Controls.Add(this.lblIssueDate);
            this.pnlApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.pnlApplicationInfo.Controls.Add(this.lblApplicationID);
            this.pnlApplicationInfo.Controls.Add(this.guna2HtmlLabel7);
            this.pnlApplicationInfo.Controls.Add(this.guna2HtmlLabel4);
            this.pnlApplicationInfo.Controls.Add(this.guna2HtmlLabel2);
            this.pnlApplicationInfo.Controls.Add(this.guna2HtmlLabel12);
            this.pnlApplicationInfo.Controls.Add(this.guna2HtmlLabel10);
            this.pnlApplicationInfo.Location = new System.Drawing.Point(20, 533);
            this.pnlApplicationInfo.Name = "pnlApplicationInfo";
            this.pnlApplicationInfo.Size = new System.Drawing.Size(1114, 254);
            this.pnlApplicationInfo.TabIndex = 101;
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(30, 204);
            this.lbl.Name = "lbl";
            this.lbl.Padding = new System.Windows.Forms.Padding(0, 0, 100, 10);
            this.lbl.Size = new System.Drawing.Size(144, 37);
            this.lbl.TabIndex = 111;
            this.lbl.Text = "Fees:";
            // 
            // lblLDLLicenseID
            // 
            this.lblLDLLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.lblLDLLicenseID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLDLLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblLDLLicenseID.Location = new System.Drawing.Point(736, 78);
            this.lblLDLLicenseID.Name = "lblLDLLicenseID";
            this.lblLDLLicenseID.Padding = new System.Windows.Forms.Padding(0, 0, 100, 30);
            this.lblLDLLicenseID.Size = new System.Drawing.Size(127, 57);
            this.lblLDLLicenseID.TabIndex = 116;
            this.lblLDLLicenseID.Text = "???";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(540, 78);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Padding = new System.Windows.Forms.Padding(0, 0, 30, 10);
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(165, 37);
            this.guna2HtmlLabel6.TabIndex = 115;
            this.guna2HtmlLabel6.Text = "L.D.L License ID:";
            // 
            // lblIntLicenseID
            // 
            this.lblIntLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.lblIntLicenseID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblIntLicenseID.Location = new System.Drawing.Point(736, 15);
            this.lblIntLicenseID.Name = "lblIntLicenseID";
            this.lblIntLicenseID.Padding = new System.Windows.Forms.Padding(0, 0, 100, 30);
            this.lblIntLicenseID.Size = new System.Drawing.Size(127, 57);
            this.lblIntLicenseID.TabIndex = 114;
            this.lblIntLicenseID.Text = "???";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(540, 15);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Padding = new System.Windows.Forms.Padding(0, 0, 30, 10);
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(148, 37);
            this.guna2HtmlLabel3.TabIndex = 113;
            this.guna2HtmlLabel3.Text = "Int.License ID:";
            // 
            // lblFees
            // 
            this.lblFees.BackColor = System.Drawing.Color.Transparent;
            this.lblFees.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.ForeColor = System.Drawing.Color.Black;
            this.lblFees.Location = new System.Drawing.Point(226, 204);
            this.lblFees.Name = "lblFees";
            this.lblFees.Padding = new System.Windows.Forms.Padding(0, 0, 50, 10);
            this.lblFees.Size = new System.Drawing.Size(77, 37);
            this.lblFees.TabIndex = 112;
            this.lblFees.Text = "???";
            // 
            // lblExeprationDate
            // 
            this.lblExeprationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblExeprationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExeprationDate.ForeColor = System.Drawing.Color.Black;
            this.lblExeprationDate.Location = new System.Drawing.Point(736, 141);
            this.lblExeprationDate.Name = "lblExeprationDate";
            this.lblExeprationDate.Padding = new System.Windows.Forms.Padding(0, 0, 100, 10);
            this.lblExeprationDate.Size = new System.Drawing.Size(127, 37);
            this.lblExeprationDate.TabIndex = 110;
            this.lblExeprationDate.Text = "???";
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(736, 204);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Padding = new System.Windows.Forms.Padding(0, 0, 100, 10);
            this.lblUserName.Size = new System.Drawing.Size(127, 37);
            this.lblUserName.TabIndex = 109;
            this.lblUserName.Text = "???";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.BackColor = System.Drawing.Color.Transparent;
            this.lblIssueDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.ForeColor = System.Drawing.Color.Black;
            this.lblIssueDate.Location = new System.Drawing.Point(226, 141);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 30);
            this.lblIssueDate.Size = new System.Drawing.Size(57, 57);
            this.lblIssueDate.TabIndex = 106;
            this.lblIssueDate.Text = "???";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationDate.Location = new System.Drawing.Point(226, 78);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 20);
            this.lblApplicationDate.Size = new System.Drawing.Size(57, 47);
            this.lblApplicationDate.TabIndex = 105;
            this.lblApplicationDate.Text = "???";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationID.Location = new System.Drawing.Point(226, 15);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Padding = new System.Windows.Forms.Padding(0, 0, 100, 30);
            this.lblApplicationID.Size = new System.Drawing.Size(127, 57);
            this.lblApplicationID.TabIndex = 104;
            this.lblApplicationID.Text = "???";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(30, 141);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Padding = new System.Windows.Forms.Padding(0, 0, 60, 50);
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(153, 77);
            this.guna2HtmlLabel7.TabIndex = 103;
            this.guna2HtmlLabel7.Text = "Issue Date:";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(30, 78);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Padding = new System.Windows.Forms.Padding(0, 0, 50, 30);
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(196, 57);
            this.guna2HtmlLabel4.TabIndex = 102;
            this.guna2HtmlLabel4.Text = "Application Date:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(30, 15);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 10);
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(178, 37);
            this.guna2HtmlLabel2.TabIndex = 101;
            this.guna2HtmlLabel2.Text = "I.L Application ID:";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(540, 141);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Padding = new System.Windows.Forms.Padding(0, 0, 80, 30);
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(220, 57);
            this.guna2HtmlLabel12.TabIndex = 108;
            this.guna2HtmlLabel12.Text = "Exepration Date:";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(540, 204);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Padding = new System.Windows.Forms.Padding(0, 0, 100, 10);
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(197, 37);
            this.guna2HtmlLabel10.TabIndex = 107;
            this.guna2HtmlLabel10.Text = "Created By:";
            // 
            // ctrLicenseInfoWithFilter1
            // 
            this.ctrLicenseInfoWithFilter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrLicenseInfoWithFilter1.Location = new System.Drawing.Point(20, 2);
            this.ctrLicenseInfoWithFilter1.Name = "ctrLicenseInfoWithFilter1";
            this.ctrLicenseInfoWithFilter1.Size = new System.Drawing.Size(1114, 515);
            this.ctrLicenseInfoWithFilter1.TabIndex = 11;
            this.ctrLicenseInfoWithFilter1.OnSearchCompleted += new System.Action<int>(this.ctrLicenseInfoWithFilter1_OnSearchCompleted);
            // 
            // frmIssueInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 848);
            this.Controls.Add(this.pnlApplicationInfo);
            this.Controls.Add(this.btnClosee);
            this.Controls.Add(this.ctrLicenseInfoWithFilter1);
            this.Controls.Add(this.lnkLblLicenseHistory);
            this.Controls.Add(this.lnkLicenseInfo);
            this.Controls.Add(this.btnIssue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIssueInternationalLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIssueInternationalLicense";
            this.Load += new System.EventHandler(this.frmIssueInternationalLicense_Load);
            this.pnlApplicationInfo.ResumeLayout(false);
            this.pnlApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnIssue;
        private Guna.UI2.WinForms.Guna2Button btnClosee;
        private System.Windows.Forms.LinkLabel lnkLicenseInfo;
        private System.Windows.Forms.LinkLabel lnkLblLicenseHistory;
        private ctrLicenseInfoWithFilter ctrLicenseInfoWithFilter1;
        private System.Windows.Forms.Panel pnlApplicationInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLDLLicenseID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIntLicenseID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFees;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblExeprationDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUserName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIssueDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblApplicationDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblApplicationID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
    }
}