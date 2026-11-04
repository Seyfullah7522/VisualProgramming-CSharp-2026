namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(txtFirstNumber.Text);
            double secondNumber = double.Parse(txtSecondNumber.Text);

            double result = firstNumber + secondNumber;

            lblResult.Text = "Result: " + result;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(txtFirstNumber.Text);
            double secondNumber = double.Parse(txtSecondNumber.Text);

            double result = firstNumber - secondNumber;

            lblResult.Text = "Result: " + result;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(txtFirstNumber.Text);
            double secondNumber = double.Parse(txtSecondNumber.Text);

            double result = firstNumber * secondNumber;

            lblResult.Text = "Result: " + result;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(txtFirstNumber.Text);
            double secondNumber = double.Parse(txtSecondNumber.Text);

            if (secondNumber == 0)
            {
                lblResult.Text = "Cannot divide by zero!";
                return;
            }

            double result = firstNumber / secondNumber;

            lblResult.Text = "Result: " + result;
        }
    }
}
