
using System;
using System.Windows.Forms;

namespace StudentProfileManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateStudent())
            {
                return;
            }

            string studentId = mtxtStudentId.Text;
            string name = txtName.Text;
            DateTime birthDate = dtpBirth.Value;
            string phone = mtxtPhone.Text;
            string address = rtbAddress.Text;
            string academicLevel = cmbAcademicLevel.Text;
            double gpa = Convert.ToDouble(txtGPA.Text);

            MessageBox.Show(
                "Student Profile Saved Successfully!\n\n" +
                "Student ID: " + studentId + "\n" +
                "Name: " + name + "\n" +
                "Birth Date: " + birthDate.ToShortDateString() + "\n" +
                "Phone: " + phone + "\n" +
                "Address: " + address + "\n" +
                "Academic Level: " + academicLevel + "\n" +
                "GPA: " + gpa
            );

            ClearForm();
        }

        private bool ValidateStudent()
        {
            if (!mtxtStudentId.MaskCompleted)
            {
                MessageBox.Show("Please enter a complete 8-digit Student ID.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the student's name.");
                return false;
            }

            if (!double.TryParse(txtGPA.Text, out double gpa))
            {
                MessageBox.Show("Please enter a valid GPA.");
                return false;
            }

            if (gpa < 0 || gpa > 4)
            {
                MessageBox.Show("GPA must be between 0 and 4.");
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            mtxtStudentId.Clear();
            txtName.Clear();
            dtpBirth.Value = DateTime.Today;
            mtxtPhone.Clear();
            rtbAddress.Clear();
            cmbAcademicLevel.SelectedIndex = -1;
            txtGPA.Clear();

            lblStatus.Text = "Ready";

            txtName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
