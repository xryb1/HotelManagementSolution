using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using formDAL;

namespace formUI
{
    public partial class EmployeeDashboardForm : Form
    {
        private readonly User _currentUser;

        // Modify the constructor to accept the user object
        public EmployeeDashboardForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            this.Text = "Employee Dashboard - Welcome, " + _currentUser.Username;
        }
        public EmployeeDashboardForm()
        {
            InitializeComponent();
        }

        private void EmployeeDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grpAdminTools_Enter(object sender, EventArgs e)
        {

        }

        private void grpSharedTools_Enter(object sender, EventArgs e)
        {

        }
        public partial class LoginForm : Form
        {

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public partial class NewBookingForm : Form
        {

        }
        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            // The NewBookingForm is shared functionality.
            NewBookingForm bookingForm = new NewBookingForm();
            bookingForm.ShowDialog(); // Use ShowDialog() to keep focus on this task
        }

        
    }
}
