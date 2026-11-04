namespace StudentLogin
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblWelcome = new Label();
            btnStudent = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(328, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(163, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Management System";
            lblTitle.Click += label1_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(364, 52);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(60, 15);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome!";
            // 
            // btnStudent
            // 
            btnStudent.Location = new Point(185, 121);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(135, 23);
            btnStudent.TabIndex = 2;
            btnStudent.Text = "Student Management";
            btnStudent.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(374, 121);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(135, 23);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnStudent);
            Controls.Add(lblWelcome);
            Controls.Add(lblTitle);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblWelcome;
        private Button btnStudent;
        private Button btnLogout;
    }
}