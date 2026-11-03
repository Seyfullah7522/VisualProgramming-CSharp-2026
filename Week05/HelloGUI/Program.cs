
using System;
using System.Windows.Forms;
using System.Drawing;

namespace HelloGUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Form form = new Form();
            form.Text = "HelloGUI";
            form.Size = new Size(400, 250);
            form.StartPosition = FormStartPosition.CenterScreen;

            Label nameLabel = new Label();
            nameLabel.Text = "Name:";
            nameLabel.Location = new Point(30, 35);
            nameLabel.AutoSize = true;

            TextBox txtName = new TextBox();
            txtName.Location = new Point(100, 30);
            txtName.Width = 220;

            Button btnSayHello = new Button();
            btnSayHello.Text = "Say Hello";
            btnSayHello.Location = new Point(100, 75);
            btnSayHello.Width = 100;

            Label lblResult = new Label();
            lblResult.Text = "Result:";
            lblResult.Location = new Point(100, 125);
            lblResult.AutoSize = true;

            btnSayHello.Click += (sender, e) =>
            {
                string name = txtName.Text.Trim();

                if (name == "")
                    lblResult.Text = "Please enter your name.";
                else
                    lblResult.Text = $"Hello, {name}!";
            };

            form.Controls.Add(nameLabel);
            form.Controls.Add(txtName);
            form.Controls.Add(btnSayHello);
            form.Controls.Add(lblResult);

            Application.Run(form);
        }
    }
}
