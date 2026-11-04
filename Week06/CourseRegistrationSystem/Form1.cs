using System.Drawing;
namespace CourseRegistrationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbCourse.Items.AddRange(new string[]
            {
        "Computer Networks",
        "Database Systems",
        "Operating Systems",
        "Microprocessors",
        "Visual Programming"
            });

            mtxtPhone.Mask = "(000) 000-0000";
            dtpDOB.MaxDate = DateTime.Today;

            btnAddItem.Click += btnAddItem_Click;
            btnRegister.Click += btnRegister_Click;
            btnClear.Click += btnClear_Click;

            txtName.TextChanged += InputChanged;
            txtStudentID.TextChanged += InputChanged;
            mtxtPhone.TextChanged += InputChanged;
            rdoMale.CheckedChanged += InputChanged;
            rdoFemale.CheckedChanged += InputChanged;
            rdoThird.CheckedChanged += InputChanged;
            rdoFourth.CheckedChanged += InputChanged;
            chkCSharp.CheckedChanged += InputChanged;
            chkPython.CheckedChanged += InputChanged;
            chkCpp.CheckedChanged += InputChanged;

            UpdateRegisterButton();
        }
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
                return false;

            if (!mtxtPhone.MaskCompleted)
                return false;

            if (!rdoMale.Checked && !rdoFemale.Checked)
                return false;

            if (!rdoThird.Checked && !rdoFourth.Checked)
                return false;

            if (!chkCSharp.Checked && !chkPython.Checked && !chkCpp.Checked)
                return false;

            return true;
        }
        private void UpdateRegisterButton()
        {
            if (ValidateForm())
            {
                btnRegister.BackColor = Color.Green;
                btnRegister.ForeColor = Color.White;
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.BackColor = Color.Red;
                btnRegister.ForeColor = Color.White;
                btnRegister.Enabled = false;
            }
        }
        private void InputChanged(object sender, EventArgs e)
        {
            UpdateRegisterButton();
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbCourse.SelectedItem == null)
            {
                MessageBox.Show("Please select a course first.");
                return;
            }

            string course = cmbCourse.SelectedItem.ToString();

            if (!lstCourses.Items.Contains(course))
            {
                lstCourses.Items.Add(course);
            }
            else
            {
                MessageBox.Show("This course has already been added.");
            }

            cmbCourse.SelectedIndex = -1;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Please complete all required fields.");
                return;
            }

            string gender = rdoMale.Checked ? "Male" : "Female";
            string level = rdoThird.Checked ? "3rd Year" : "4th Year";

            string skills = "";

            if (chkCSharp.Checked)
                skills += "C# ";

            if (chkPython.Checked)
                skills += "Python ";

            if (chkCpp.Checked)
                skills += "C++ ";

            string courses = "";

            foreach (var course in lstCourses.Items)
            {
                courses += course.ToString() + "\n";
            }

            MessageBox.Show(
                "Registration Successful!\n\n" +
                "Name: " + txtName.Text +
                "\nStudent ID: " + txtStudentID.Text +
                "\nPhone: " + mtxtPhone.Text +
                "\nGender: " + gender +
                "\nLevel: " + level +
                "\nSkills: " + skills +
                "\nCourses:\n" + courses,
                "Registration"
            );
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtStudentID.Clear();
            mtxtPhone.Clear();

            dtpRegDate.Value = DateTime.Today;
            dtpDOB.Value = DateTime.Today;

            rdoMale.Checked = false;
            rdoFemale.Checked = false;

            rdoThird.Checked = false;
            rdoFourth.Checked = false;

            chkCSharp.Checked = false;
            chkPython.Checked = false;
            chkCpp.Checked = false;

            cmbCourse.SelectedIndex = -1;
            lstCourses.Items.Clear();

            UpdateRegisterButton();

            txtName.Focus();
        }
        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkPython_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
