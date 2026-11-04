namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int birthYear = int.Parse(txtBirthYear.Text);

            int age = 2026 - birthYear;

            lblResult.Text = $"{name} is approximately {age} years old.";
        
        }
    }
}
