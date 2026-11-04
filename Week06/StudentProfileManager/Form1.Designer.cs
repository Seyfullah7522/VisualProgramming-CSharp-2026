namespace StudentProfileManager
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
            grpIdentity = new GroupBox();
            txtName = new TextBox();
            lblName = new Label();
            mtxtStudentId = new MaskedTextBox();
            lblStudentId = new Label();
            grpContactBirth = new GroupBox();
            rtbAddress = new RichTextBox();
            lblAddress = new Label();
            mtxtPhone = new MaskedTextBox();
            lblPhone = new Label();
            dtpBirth = new DateTimePicker();
            lblBirth = new Label();
            grpAcademic = new GroupBox();
            txtGPA = new TextBox();
            lblGPA = new Label();
            cmbAcademicLevel = new ComboBox();
            lblAcademicLevel = new Label();
            lblStatus = new Label();
            btnSave = new Button();
            btnClear = new Button();
            grpIdentity.SuspendLayout();
            grpContactBirth.SuspendLayout();
            grpAcademic.SuspendLayout();
            SuspendLayout();
            // 
            // grpIdentity
            // 
            grpIdentity.Controls.Add(txtName);
            grpIdentity.Controls.Add(lblName);
            grpIdentity.Controls.Add(mtxtStudentId);
            grpIdentity.Controls.Add(lblStudentId);
            grpIdentity.Location = new Point(20, 20);
            grpIdentity.Name = "grpIdentity";
            grpIdentity.Size = new Size(380, 150);
            grpIdentity.TabIndex = 0;
            grpIdentity.TabStop = false;
            grpIdentity.Text = "Identity Information";
            // 
            // txtName
            // 
            txtName.Location = new Point(101, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(14, 51);
            lblName.Name = "lblName";
            lblName.Size = new Size(61, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Full Name";
            // 
            // mtxtStudentId
            // 
            mtxtStudentId.Location = new Point(101, 17);
            mtxtStudentId.Mask = "00000000";
            mtxtStudentId.Name = "mtxtStudentId";
            mtxtStudentId.Size = new Size(100, 23);
            mtxtStudentId.TabIndex = 1;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(14, 20);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(61, 15);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student Id";
            // 
            // grpContactBirth
            // 
            grpContactBirth.Controls.Add(rtbAddress);
            grpContactBirth.Controls.Add(lblAddress);
            grpContactBirth.Controls.Add(mtxtPhone);
            grpContactBirth.Controls.Add(lblPhone);
            grpContactBirth.Controls.Add(dtpBirth);
            grpContactBirth.Controls.Add(lblBirth);
            grpContactBirth.Location = new Point(20, 190);
            grpContactBirth.Name = "grpContactBirth";
            grpContactBirth.Size = new Size(380, 230);
            grpContactBirth.TabIndex = 1;
            grpContactBirth.TabStop = false;
            grpContactBirth.Text = "Contact & Birth Information";
            // 
            // rtbAddress
            // 
            rtbAddress.Location = new Point(113, 114);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(250, 65);
            rtbAddress.TabIndex = 8;
            rtbAddress.Text = "";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(16, 114);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Address:";
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(113, 76);
            mtxtPhone.Mask = "(000) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(100, 23);
            mtxtPhone.TabIndex = 6;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(16, 79);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(88, 15);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone Number";
            // 
            // dtpBirth
            // 
            dtpBirth.Format = DateTimePickerFormat.Short;
            dtpBirth.Location = new Point(113, 33);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(200, 23);
            dtpBirth.TabIndex = 4;
            // 
            // lblBirth
            // 
            lblBirth.AutoSize = true;
            lblBirth.Location = new Point(14, 39);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(59, 15);
            lblBirth.TabIndex = 3;
            lblBirth.Text = "Birth Date";
            // 
            // grpAcademic
            // 
            grpAcademic.Controls.Add(txtGPA);
            grpAcademic.Controls.Add(lblGPA);
            grpAcademic.Controls.Add(cmbAcademicLevel);
            grpAcademic.Controls.Add(lblAcademicLevel);
            grpAcademic.Location = new Point(430, 20);
            grpAcademic.Name = "grpAcademic";
            grpAcademic.Size = new Size(380, 170);
            grpAcademic.TabIndex = 2;
            grpAcademic.TabStop = false;
            grpAcademic.Text = "Academic Information";
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(125, 51);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(100, 23);
            txtGPA.TabIndex = 7;
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Location = new Point(17, 51);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(61, 15);
            lblGPA.TabIndex = 6;
            lblGPA.Text = "GPA (0–4):";
            // 
            // cmbAcademicLevel
            // 
            cmbAcademicLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAcademicLevel.FormattingEnabled = true;
            cmbAcademicLevel.Items.AddRange(new object[] { "First Year", "Second Year", "Third Year", "Fourth Year" });
            cmbAcademicLevel.Location = new Point(125, 17);
            cmbAcademicLevel.Name = "cmbAcademicLevel";
            cmbAcademicLevel.Size = new Size(121, 23);
            cmbAcademicLevel.TabIndex = 5;
            // 
            // lblAcademicLevel
            // 
            lblAcademicLevel.AutoSize = true;
            lblAcademicLevel.Location = new Point(17, 20);
            lblAcademicLevel.Name = "lblAcademicLevel";
            lblAcademicLevel.Size = new Size(90, 15);
            lblAcademicLevel.TabIndex = 4;
            lblAcademicLevel.Text = "Academic Level";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(385, 437);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Ready";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(319, 470);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Profile";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(417, 470);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 611);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(lblStatus);
            Controls.Add(grpAcademic);
            Controls.Add(grpContactBirth);
            Controls.Add(grpIdentity);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Profile Manager";
            grpIdentity.ResumeLayout(false);
            grpIdentity.PerformLayout();
            grpContactBirth.ResumeLayout(false);
            grpContactBirth.PerformLayout();
            grpAcademic.ResumeLayout(false);
            grpAcademic.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpIdentity;
        private MaskedTextBox mtxtStudentId;
        private Label lblStudentId;
        private TextBox txtName;
        private Label lblName;
        private GroupBox grpContactBirth;
        private Label lblBirth;
        private MaskedTextBox mtxtPhone;
        private Label lblPhone;
        private DateTimePicker dtpBirth;
        private Label lblAddress;
        private RichTextBox rtbAddress;
        private GroupBox grpAcademic;
        private ComboBox cmbAcademicLevel;
        private Label lblAcademicLevel;
        private Label lblGPA;
        private TextBox txtGPA;
        private Label lblStatus;
        private Button btnSave;
        private Button btnClear;
    }
}
