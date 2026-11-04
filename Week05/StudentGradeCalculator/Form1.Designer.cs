namespace StudentGradeCalculator
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
            lblQuiz = new Label();
            lblMidterm = new Label();
            lblFinal = new Label();
            txtName = new TextBox();
            txtQuiz = new TextBox();
            txtMidterm = new TextBox();
            txtFinal = new TextBox();
            btnCalculate = new Button();
            lblTotal = new Label();
            lblGrade = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(148, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(83, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Student Name";
            // 
            // lblQuiz
            // 
            lblQuiz.AutoSize = true;
            lblQuiz.Location = new Point(148, 43);
            lblQuiz.Name = "lblQuiz";
            lblQuiz.Size = new Size(31, 15);
            lblQuiz.TabIndex = 1;
            lblQuiz.Text = "Quiz";
            // 
            // lblMidterm
            // 
            lblMidterm.AutoSize = true;
            lblMidterm.Location = new Point(148, 78);
            lblMidterm.Name = "lblMidterm";
            lblMidterm.Size = new Size(57, 15);
            lblMidterm.TabIndex = 2;
            lblMidterm.Text = "Mid Term";
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Location = new Point(148, 113);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(32, 15);
            lblFinal.TabIndex = 3;
            lblFinal.Text = "Final";
            // 
            // txtName
            // 
            txtName.Location = new Point(254, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 4;
            // 
            // txtQuiz
            // 
            txtQuiz.Location = new Point(254, 43);
            txtQuiz.Name = "txtQuiz";
            txtQuiz.Size = new Size(100, 23);
            txtQuiz.TabIndex = 5;
            // 
            // txtMidterm
            // 
            txtMidterm.Location = new Point(254, 78);
            txtMidterm.Name = "txtMidterm";
            txtMidterm.Size = new Size(100, 23);
            txtMidterm.TabIndex = 6;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(254, 113);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(100, 23);
            txtFinal.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(254, 156);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 23);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate Grade";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(254, 206);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total:";
            lblTotal.Click += lblTotal_Click;
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(254, 241);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(41, 15);
            lblGrade.TabIndex = 10;
            lblGrade.Text = "Grade:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGrade);
            Controls.Add(lblTotal);
            Controls.Add(btnCalculate);
            Controls.Add(txtFinal);
            Controls.Add(txtMidterm);
            Controls.Add(txtQuiz);
            Controls.Add(txtName);
            Controls.Add(lblFinal);
            Controls.Add(lblMidterm);
            Controls.Add(lblQuiz);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblQuiz;
        private Label lblMidterm;
        private Label lblFinal;
        private TextBox txtName;
        private TextBox txtQuiz;
        private TextBox txtMidterm;
        private TextBox txtFinal;
        private Button btnCalculate;
        private Label lblTotal;
        private Label lblGrade;
    }
}
