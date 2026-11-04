
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Student_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Hide password characters
            txtPassword.UseSystemPasswordChar = true;

            // Initial button color
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.BackColor = Color.Red;
            btnLogin.ForeColor = Color.White;

            // Check whenever the user types
            txtUsername.TextChanged += InputChanged;
            txtPassword.TextChanged += InputChanged;

            // Login button event
            btnLogin.Click += btnLogin_Click;

            UpdateLoginButton();
        }

        private bool ValidateLogin()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
                return false;

            return true;
        }

        private void UpdateLoginButton()
        {
            if (ValidateLogin())
            {
                btnLogin.BackColor = Color.Green;
            }
            else
            {
                btnLogin.BackColor = Color.Red;
            }
        }

        private void InputChanged(object sender, EventArgs e)
        {
            UpdateLoginButton();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateLogin())
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            MessageBox.Show("Login validation successful!");
        }
    }
}
