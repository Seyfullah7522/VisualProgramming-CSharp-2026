
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Hide password characters
            txtPassword.UseSystemPasswordChar = true;

            // Initial Login button color
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.BackColor = Color.Red;
            btnLogin.ForeColor = Color.White;

            // Detect changes in the textboxes
            txtUsername.TextChanged += InputChanged;
            txtPassword.TextChanged += InputChanged;

            // Login button click
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

            MainForm mainForm = new MainForm();
            mainForm.Show();

            this.Hide();
        }

    }
}
