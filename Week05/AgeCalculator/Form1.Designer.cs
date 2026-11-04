namespace AgeCalculator
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
            lblTitle = new Label();
            lblName = new Label();
            lblBirthYear = new Label();
            btnCalculate = new Button();
            lblResult = new Label();
            txtName = new TextBox();
            txtBirthYear = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(287, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(85, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Age Calculator";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(94, 43);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblBirthYear
            // 
            lblBirthYear.AutoSize = true;
            lblBirthYear.Location = new Point(94, 75);
            lblBirthYear.Name = "lblBirthYear";
            lblBirthYear.Size = new Size(57, 15);
            lblBirthYear.TabIndex = 2;
            lblBirthYear.Text = "Birth Year";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(196, 121);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(196, 166);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(42, 15);
            lblResult.TabIndex = 4;
            lblResult.Text = "Result:";
            // 
            // txtName
            // 
            txtName.Location = new Point(196, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 5;
            // 
            // txtBirthYear
            // 
            txtBirthYear.Location = new Point(196, 75);
            txtBirthYear.Name = "txtBirthYear";
            txtBirthYear.Size = new Size(100, 23);
            txtBirthYear.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBirthYear);
            Controls.Add(txtName);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(lblBirthYear);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblBirthYear;
        private Button btnCalculate;
        private Label lblResult;
        private TextBox txtName;
        private TextBox txtBirthYear;
    }
}
