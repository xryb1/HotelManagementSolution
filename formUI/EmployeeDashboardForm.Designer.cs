namespace formUI
{
    partial class EmployeeDashboardForm
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
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.btnCheckInOut = new System.Windows.Forms.Button();
            this.btnHousekeeping = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.grpOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.Location = new System.Drawing.Point(6, 19);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(102, 23);
            this.btnNewBooking.TabIndex = 0;
            this.btnNewBooking.Text = "New Reservation";
            this.btnNewBooking.UseVisualStyleBackColor = true;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // btnCheckInOut
            // 
            this.btnCheckInOut.Location = new System.Drawing.Point(6, 48);
            this.btnCheckInOut.Name = "btnCheckInOut";
            this.btnCheckInOut.Size = new System.Drawing.Size(102, 23);
            this.btnCheckInOut.TabIndex = 1;
            this.btnCheckInOut.Text = "Check-in/Out";
            this.btnCheckInOut.UseVisualStyleBackColor = true;
            // 
            // btnHousekeeping
            // 
            this.btnHousekeeping.Location = new System.Drawing.Point(6, 77);
            this.btnHousekeeping.Name = "btnHousekeeping";
            this.btnHousekeeping.Size = new System.Drawing.Size(141, 23);
            this.btnHousekeeping.TabIndex = 3;
            this.btnHousekeeping.Text = "Housekeeping Status";
            this.btnHousekeeping.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(6, 106);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(215, 46);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome, Employee!";
            this.lblWelcome.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.btnNewBooking);
            this.grpOperations.Controls.Add(this.btnCheckInOut);
            this.grpOperations.Controls.Add(this.btnHousekeeping);
            this.grpOperations.Controls.Add(this.btnLogout);
            this.grpOperations.Location = new System.Drawing.Point(20, 101);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Size = new System.Drawing.Size(200, 139);
            this.grpOperations.TabIndex = 5;
            this.grpOperations.TabStop = false;
            this.grpOperations.Text = "Hotel Operations";
            // 
            // EmployeeDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.lblWelcome);
            this.Name = "EmployeeDashboardForm";
            this.Text = "EmployeeDashboardForm";
            this.Load += new System.EventHandler(this.EmployeeDashboardForm_Load);
            this.grpOperations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.Button btnCheckInOut;
        private System.Windows.Forms.Button btnHousekeeping;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox grpOperations;
    }
}