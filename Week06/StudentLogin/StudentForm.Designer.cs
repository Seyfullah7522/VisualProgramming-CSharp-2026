namespace StudentLogin
{
    partial class StudentForm
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
            lblStudentName = new Label();
            txtStudentName = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(77, 22);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(83, 15);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "Student Name";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(217, 19);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(100, 23);
            txtStudentName.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(206, 81);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtStudentName);
            Controls.Add(lblStudentName);
            Name = "StudentForm";
            Text = "StudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentName;
        private TextBox txtStudentName;
        private Button btnSave;
    }
}