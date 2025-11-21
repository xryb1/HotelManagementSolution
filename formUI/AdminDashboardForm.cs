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
    public partial class AdminDashboardForm : Form
    {
        private readonly User _currentUser;

        // Modify the constructor to accept the user object
        public AdminDashboardForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            this.Text = "Admin Dashboard - Welcome, " + _currentUser.Username;
        }
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void grpAdminTools_Enter(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        public partial class LoginForm : Form 
        {
            
        }
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
