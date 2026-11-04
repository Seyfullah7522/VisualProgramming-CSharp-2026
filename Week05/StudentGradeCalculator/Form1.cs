namespace StudentGradeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if (!int.TryParse(txtQuiz.Text, out int quiz) ||
                !int.TryParse(txtMidterm.Text, out int midterm) ||
                !int.TryParse(txtFinal.Text, out int final))
            {
                MessageBox.Show("Please enter valid numbers for all marks.");
                return;
            }

            if (quiz < 0 || quiz > 100 ||
                midterm < 0 || midterm > 100 ||
                final < 0 || final > 100)
            {
                MessageBox.Show("Marks must be between 0 and 100.");
                return;
            }

            int total = quiz + midterm + final;

            string grade;

            if (total >= 90)
                grade = "A";
            else if (total >= 80)
                grade = "B";
            else if (total >= 70)
                grade = "C";
            else if (total >= 60)
                grade = "D";
            else
                grade = "F";

            lblTotal.Text = "Total: " + total;
            lblGrade.Text = "Grade: " + grade;
        }
    }
}
