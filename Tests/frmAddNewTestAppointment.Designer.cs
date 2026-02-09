namespace People_Management
{
    partial class frmAddNewTestAppointment
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
            this.ctrScheduleTest1 = new People_Management.Tests.ctrScheduleTest();
            this.SuspendLayout();
            // 
            // ctrScheduleTest1
            // 
            this.ctrScheduleTest1.BackColor = System.Drawing.SystemColors.Control;
            this.ctrScheduleTest1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ctrScheduleTest1.Location = new System.Drawing.Point(12, 12);
            this.ctrScheduleTest1.Name = "ctrScheduleTest1";
            this.ctrScheduleTest1.RetakeTestEnabled = false;
            this.ctrScheduleTest1.Size = new System.Drawing.Size(649, 779);
            this.ctrScheduleTest1.TabIndex = 39;
            this.ctrScheduleTest1.TestTypeID = DVLD_BuisnessLayer.clsTestTypes.enTestType.VisionTest;
            this.ctrScheduleTest1.Load += new System.EventHandler(this.ctrScheduleTest1_Load);
            // 
            // frmAddNewTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(673, 803);
            this.Controls.Add(this.ctrScheduleTest1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddNewTestAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewTestAppointment";
            this.Load += new System.EventHandler(this.frmAddNewTestAppointment_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Tests.ctrScheduleTest ctrScheduleTest1;
    }
}