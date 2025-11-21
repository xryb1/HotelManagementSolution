namespace formUI
{
    partial class AdminDashboardForm
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
            this.grpSharedTools = new System.Windows.Forms.GroupBox();
            this.btnHousekeeping = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUserMgmt = new System.Windows.Forms.Button();
            this.btnRateMgmt = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.grpAdminTools = new System.Windows.Forms.GroupBox();
            this.grpSharedTools.SuspendLayout();
            this.grpAdminTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, Admin!";
            // 
            // grpSharedTools
            // 
            this.grpSharedTools.Controls.Add(this.btnHousekeeping);
            this.grpSharedTools.Controls.Add(this.btnCheckIn);
            this.grpSharedTools.Controls.Add(this.btnNewBooking);
            this.grpSharedTools.Location = new System.Drawing.Point(226, 85);
            this.grpSharedTools.Name = "grpSharedTools";
            this.grpSharedTools.Size = new System.Drawing.Size(200, 100);
            this.grpSharedTools.TabIndex = 2;
            this.grpSharedTools.TabStop = false;
            this.grpSharedTools.Text = "Hotel Operations";
            // 
            // btnHousekeeping
            // 
            this.btnHousekeeping.Location = new System.Drawing.Point(7, 71);
            this.btnHousekeeping.Name = "btnHousekeeping";
            this.btnHousekeeping.Size = new System.Drawing.Size(120, 23);
            this.btnHousekeeping.TabIndex = 2;
            this.btnHousekeeping.Text = "Housekeeping Status";
            this.btnHousekeeping.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(7, 46);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(98, 23);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check-in/Out";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.Location = new System.Drawing.Point(7, 20);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(98, 23);
            this.btnNewBooking.TabIndex = 0;
            this.btnNewBooking.Text = "New Reservation";
            this.btnNewBooking.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(580, 64);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnUserMgmt
            // 
            this.btnUserMgmt.Location = new System.Drawing.Point(7, 20);
            this.btnUserMgmt.Name = "btnUserMgmt";
            this.btnUserMgmt.Size = new System.Drawing.Size(113, 23);
            this.btnUserMgmt.TabIndex = 0;
            this.btnUserMgmt.Text = "User Account Mgmt";
            this.btnUserMgmt.UseVisualStyleBackColor = true;
            // 
            // btnRateMgmt
            // 
            this.btnRateMgmt.Location = new System.Drawing.Point(7, 46);
            this.btnRateMgmt.Name = "btnRateMgmt";
            this.btnRateMgmt.Size = new System.Drawing.Size(113, 23);
            this.btnRateMgmt.TabIndex = 1;
            this.btnRateMgmt.Text = "Room Rate Settings";
            this.btnRateMgmt.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(7, 71);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(113, 23);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Financial Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // grpAdminTools
            // 
            this.grpAdminTools.Controls.Add(this.btnReports);
            this.grpAdminTools.Controls.Add(this.btnRateMgmt);
            this.grpAdminTools.Controls.Add(this.btnUserMgmt);
            this.grpAdminTools.Location = new System.Drawing.Point(20, 85);
            this.grpAdminTools.Name = "grpAdminTools";
            this.grpAdminTools.Size = new System.Drawing.Size(200, 100);
            this.grpAdminTools.TabIndex = 1;
            this.grpAdminTools.TabStop = false;
            this.grpAdminTools.Text = "Admin Management Tools";
            this.grpAdminTools.Enter += new System.EventHandler(this.grpAdminTools_Enter);
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grpSharedTools);
            this.Controls.Add(this.grpAdminTools);
            this.Controls.Add(this.label1);
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.grpSharedTools.ResumeLayout(false);
            this.grpAdminTools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSharedTools;
        private System.Windows.Forms.Button btnHousekeeping;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUserMgmt;
        private System.Windows.Forms.Button btnRateMgmt;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.GroupBox grpAdminTools;
    }
}