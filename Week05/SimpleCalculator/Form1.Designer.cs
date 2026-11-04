namespace SimpleCalculator
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
            lblFirstNumber = new Label();
            lblSecondNumber = new Label();
            txtFirstNumber = new TextBox();
            txtSecondNumber = new TextBox();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblFirstNumber
            // 
            lblFirstNumber.AutoSize = true;
            lblFirstNumber.Location = new Point(137, 14);
            lblFirstNumber.Name = "lblFirstNumber";
            lblFirstNumber.Size = new Size(76, 15);
            lblFirstNumber.TabIndex = 0;
            lblFirstNumber.Text = "First Number";
            // 
            // lblSecondNumber
            // 
            lblSecondNumber.AutoSize = true;
            lblSecondNumber.Location = new Point(137, 49);
            lblSecondNumber.Name = "lblSecondNumber";
            lblSecondNumber.Size = new Size(93, 15);
            lblSecondNumber.TabIndex = 1;
            lblSecondNumber.Text = "Second Number";
            // 
            // txtFirstNumber
            // 
            txtFirstNumber.Location = new Point(275, 14);
            txtFirstNumber.Name = "txtFirstNumber";
            txtFirstNumber.Size = new Size(100, 23);
            txtFirstNumber.TabIndex = 2;
            // 
            // txtSecondNumber
            // 
            txtSecondNumber.Location = new Point(275, 49);
            txtSecondNumber.Name = "txtSecondNumber";
            txtSecondNumber.Size = new Size(100, 23);
            txtSecondNumber.TabIndex = 3;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(275, 96);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(24, 24);
            btnPlus.TabIndex = 4;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(315, 96);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(24, 24);
            btnMinus.TabIndex = 5;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(351, 96);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(24, 24);
            btnMultiply.TabIndex = 6;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(394, 96);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(24, 24);
            btnDivide.TabIndex = 7;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(275, 144);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(275, 193);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(42, 15);
            lblResult.TabIndex = 9;
            lblResult.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(txtSecondNumber);
            Controls.Add(txtFirstNumber);
            Controls.Add(lblSecondNumber);
            Controls.Add(lblFirstNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstNumber;
        private Label lblSecondNumber;
        private TextBox txtFirstNumber;
        private TextBox txtSecondNumber;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnCalculate;
        private Label lblResult;
    }
}
