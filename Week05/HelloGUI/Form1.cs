using System.Xml.Linq;

namespace HelloGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            lblResult.Text = $"Hello, {name}!";
        }
    }
}