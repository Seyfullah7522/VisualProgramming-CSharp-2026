using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentLogin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnStudent.Click += btnStudent_Click;
            btnLogout.Click += btnLogout_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
