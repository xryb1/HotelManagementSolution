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
    }
}
