namespace CourseRegistrationSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblStudentID = new Label();
            txtName = new TextBox();
            txtStudentID = new TextBox();
            lblPhone = new Label();
            lblRegDate = new Label();
            dtpRegDate = new DateTimePicker();
            dtpDOB = new DateTimePicker();
            lblDOB = new Label();
            mtxtPhone = new MaskedTextBox();
            grpGender = new GroupBox();
            grpLevel = new GroupBox();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            rdoThird = new RadioButton();
            rdoFourth = new RadioButton();
            lblCourse = new Label();
            cmbCourse = new ComboBox();
            btnAddItem = new Button();
            lblSkills = new Label();
            chkCSharp = new CheckBox();
            chkPython = new CheckBox();
            chkCpp = new CheckBox();
            lblSelectedCourses = new Label();
            lstCourses = new ListBox();
            btnRegister = new Button();
            btnClear = new Button();
            grpGender.SuspendLayout();
            grpLevel.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(12, 43);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(65, 15);
            lblStudentID.TabIndex = 1;
            lblStudentID.Text = "Student ID:";
            // 
            // txtName
            // 
            txtName.Location = new Point(129, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(129, 40);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(100, 23);
            txtStudentID.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(14, 82);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(44, 15);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone:";
            lblPhone.Click += lblPhone_Click;
            // 
            // lblRegDate
            // 
            lblRegDate.AutoSize = true;
            lblRegDate.Location = new Point(14, 122);
            lblRegDate.Name = "lblRegDate";
            lblRegDate.Size = new Size(106, 15);
            lblRegDate.TabIndex = 5;
            lblRegDate.Text = "Registeration Date:";
            // 
            // dtpRegDate
            // 
            dtpRegDate.Location = new Point(129, 116);
            dtpRegDate.Name = "dtpRegDate";
            dtpRegDate.Size = new Size(200, 23);
            dtpRegDate.TabIndex = 6;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(129, 152);
            dtpDOB.MaxDate = new DateTime(2026, 4, 11, 0, 0, 0, 0);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(200, 23);
            dtpDOB.TabIndex = 7;
            dtpDOB.Value = new DateTime(2026, 4, 11, 0, 0, 0, 0);
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(14, 158);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(76, 15);
            lblDOB.TabIndex = 8;
            lblDOB.Text = "Date of Birth:";
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(129, 82);
            mtxtPhone.Mask = "(000) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(100, 23);
            mtxtPhone.TabIndex = 9;
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rdoFemale);
            grpGender.Controls.Add(rdoMale);
            grpGender.Location = new Point(339, 6);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(200, 100);
            grpGender.TabIndex = 10;
            grpGender.TabStop = false;
            grpGender.Text = "Gender";
            // 
            // grpLevel
            // 
            grpLevel.Controls.Add(rdoFourth);
            grpLevel.Controls.Add(rdoThird);
            grpLevel.Location = new Point(339, 122);
            grpLevel.Name = "grpLevel";
            grpLevel.Size = new Size(200, 100);
            grpLevel.TabIndex = 11;
            grpLevel.TabStop = false;
            grpLevel.Text = "Level";
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(36, 29);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(51, 19);
            rdoMale.TabIndex = 0;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(36, 54);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(63, 19);
            rdoFemale.TabIndex = 1;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoThird
            // 
            rdoThird.AutoSize = true;
            rdoThird.Location = new Point(36, 22);
            rdoThird.Name = "rdoThird";
            rdoThird.Size = new Size(67, 19);
            rdoThird.TabIndex = 1;
            rdoThird.TabStop = true;
            rdoThird.Text = "3rd Year";
            rdoThird.UseVisualStyleBackColor = true;
            // 
            // rdoFourth
            // 
            rdoFourth.AutoSize = true;
            rdoFourth.Location = new Point(36, 47);
            rdoFourth.Name = "rdoFourth";
            rdoFourth.Size = new Size(67, 19);
            rdoFourth.TabIndex = 2;
            rdoFourth.TabStop = true;
            rdoFourth.Text = "4th Year";
            rdoFourth.UseVisualStyleBackColor = true;
            rdoFourth.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(571, 18);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(47, 15);
            lblCourse.TabIndex = 12;
            lblCourse.Text = "Course:";
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "Computer Networks", "Database Systems", "Operating Systems", "Microprocessors", "Visual Programming" });
            cmbCourse.Location = new Point(624, 15);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(121, 23);
            cmbCourse.TabIndex = 13;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(620, 65);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 14;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            // 
            // lblSkills
            // 
            lblSkills.AutoSize = true;
            lblSkills.Location = new Point(255, 245);
            lblSkills.Name = "lblSkills";
            lblSkills.Size = new Size(36, 15);
            lblSkills.TabIndex = 15;
            lblSkills.Text = "Skills:";
            // 
            // chkCSharp
            // 
            chkCSharp.AutoSize = true;
            chkCSharp.Location = new Point(297, 245);
            chkCSharp.Name = "chkCSharp";
            chkCSharp.Size = new Size(41, 19);
            chkCSharp.TabIndex = 16;
            chkCSharp.Text = "C#";
            chkCSharp.UseVisualStyleBackColor = true;
            // 
            // chkPython
            // 
            chkPython.AutoSize = true;
            chkPython.Location = new Point(339, 245);
            chkPython.Name = "chkPython";
            chkPython.Size = new Size(64, 19);
            chkPython.TabIndex = 17;
            chkPython.Text = "Python";
            chkPython.UseVisualStyleBackColor = true;
            chkPython.CheckedChanged += chkPython_CheckedChanged;
            // 
            // chkCpp
            // 
            chkCpp.AutoSize = true;
            chkCpp.Location = new Point(409, 245);
            chkCpp.Name = "chkCpp";
            chkCpp.Size = new Size(50, 19);
            chkCpp.TabIndex = 18;
            chkCpp.Text = "C++";
            chkCpp.UseVisualStyleBackColor = true;
            // 
            // lblSelectedCourses
            // 
            lblSelectedCourses.AutoSize = true;
            lblSelectedCourses.Location = new Point(562, 105);
            lblSelectedCourses.Name = "lblSelectedCourses";
            lblSelectedCourses.Size = new Size(99, 15);
            lblSelectedCourses.TabIndex = 19;
            lblSelectedCourses.Text = "Selected Courses:";
            // 
            // lstCourses
            // 
            lstCourses.FormattingEnabled = true;
            lstCourses.Location = new Point(562, 139);
            lstCourses.Name = "lstCourses";
            lstCourses.Size = new Size(120, 49);
            lstCourses.TabIndex = 20;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(286, 293);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 21;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(375, 293);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(lstCourses);
            Controls.Add(lblSelectedCourses);
            Controls.Add(chkCpp);
            Controls.Add(chkPython);
            Controls.Add(chkCSharp);
            Controls.Add(lblSkills);
            Controls.Add(btnAddItem);
            Controls.Add(cmbCourse);
            Controls.Add(lblCourse);
            Controls.Add(grpLevel);
            Controls.Add(grpGender);
            Controls.Add(mtxtPhone);
            Controls.Add(lblDOB);
            Controls.Add(dtpDOB);
            Controls.Add(dtpRegDate);
            Controls.Add(lblRegDate);
            Controls.Add(lblPhone);
            Controls.Add(txtStudentID);
            Controls.Add(txtName);
            Controls.Add(lblStudentID);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Student Course Registration System";
            Load += Form1_Load;
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            grpLevel.ResumeLayout(false);
            grpLevel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblStudentID;
        private TextBox txtName;
        private TextBox txtStudentID;
        private Label lblPhone;
        private Label lblRegDate;
        private DateTimePicker dtpRegDate;
        private DateTimePicker dtpDOB;
        private Label lblDOB;
        private MaskedTextBox mtxtPhone;
        private GroupBox grpGender;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private GroupBox grpLevel;
        private RadioButton rdoFourth;
        private RadioButton rdoThird;
        private Label lblCourse;
        private ComboBox cmbCourse;
        private Button btnAddItem;
        private Label lblSkills;
        private CheckBox chkCSharp;
        private CheckBox chkPython;
        private CheckBox chkCpp;
        private Label lblSelectedCourses;
        private ListBox lstCourses;
        private Button btnRegister;
        private Button btnClear;
    }
}
