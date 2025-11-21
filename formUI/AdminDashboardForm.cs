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
    }
}
