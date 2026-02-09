namespace People_Management
{
    partial class ctrPersonInfoWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrPersonInfoWithFilter));
            this.pnlFilter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnFind = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtFindBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cmbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrPersonDetails1 = new People_Management.ctrPersonDetails();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.BorderColor = System.Drawing.Color.Black;
            this.pnlFilter.BorderThickness = 1;
            this.pnlFilter.Controls.Add(this.btnFind);
            this.pnlFilter.Controls.Add(this.txtFindBy);
            this.pnlFilter.Controls.Add(this.btnAddNewUser);
            this.pnlFilter.Controls.Add(this.cmbFilterBy);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Location = new System.Drawing.Point(24, 12);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(845, 71);
            this.pnlFilter.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnFind.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnFind.ImageRotate = 0F;
            this.btnFind.ImageSize = new System.Drawing.Size(40, 40);
            this.btnFind.Location = new System.Drawing.Point(734, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnFind.Size = new System.Drawing.Size(43, 46);
            this.btnFind.TabIndex = 16;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFindBy
            // 
            this.txtFindBy.BorderRadius = 8;
            this.txtFindBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindBy.DefaultText = "";
            this.txtFindBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFindBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFindBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFindBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindBy.Location = new System.Drawing.Point(429, 12);
            this.txtFindBy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFindBy.Name = "txtFindBy";
            this.txtFindBy.PlaceholderText = "";
            this.txtFindBy.SelectedText = "";
            this.txtFindBy.Size = new System.Drawing.Size(299, 46);
            this.txtFindBy.TabIndex = 2;
            this.txtFindBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindBy_KeyPress);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddNewUser.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewUser.Image")));
            this.btnAddNewUser.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddNewUser.ImageRotate = 0F;
            this.btnAddNewUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewUser.Location = new System.Drawing.Point(783, 12);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewUser.Size = new System.Drawing.Size(40, 46);
            this.btnAddNewUser.TabIndex = 15;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilterBy.BorderRadius = 8;
            this.cmbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFilterBy.ItemHeight = 30;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.cmbFilterBy.Location = new System.Drawing.Point(109, 12);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(314, 36);
            this.cmbFilterBy.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Find By: ";
            // 
            // ctrPersonDetails1
            // 
            this.ctrPersonDetails1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrPersonDetails1.Location = new System.Drawing.Point(24, 89);
            this.ctrPersonDetails1.Name = "ctrPersonDetails1";
            this.ctrPersonDetails1.Size = new System.Drawing.Size(1064, 414);
            this.ctrPersonDetails1.TabIndex = 0;
            // 
            // ctrPersonInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.ctrPersonDetails1);
            this.Name = "ctrPersonInfoWithFilter";
            this.Size = new System.Drawing.Size(1103, 512);
            this.Load += new System.EventHandler(this.ctrPersonInfoWithFilter_Load);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrPersonDetails ctrPersonDetails1;
        private Guna.UI2.WinForms.Guna2Panel pnlFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilterBy;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddNewUser;
        private Guna.UI2.WinForms.Guna2ImageButton btnFind;
        private Guna.UI2.WinForms.Guna2TextBox txtFindBy;
    }
}
