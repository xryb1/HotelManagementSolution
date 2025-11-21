using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using formBLL;
using formDAL;

namespace formUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Inside the LoginForm class in LoginForm.cs

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // 1. Instantiate the AuthService (from formBLL)
            AuthService authService = new AuthService();

            // 2. Call the Authenticate method to check credentials and get the user object
            User loggedInUser = authService.Authenticate(username, password);

            if (loggedInUser != null)
            {
                // Login Successful! Now we enforce permission separation
                this.Hide(); // Hide the Login form

                if (authService.IsAdmin(loggedInUser))
                {
                    // Admin user: Show the full-access dashboard
                    AdminDashboardForm adminForm = new AdminDashboardForm();
                    adminForm.Show();
                }
                else
                {
                    // Employee user: Show the restricted-access dashboard
                    EmployeeDashboardForm employeeForm = new EmployeeDashboardForm();
                    employeeForm.Show();
                }
            }
            else
            {
                // Login Failed
                MessageBox.Show("Invalid Username or Password. Please try again.",
                                "Login Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
