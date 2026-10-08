namespace Frontend.Windows
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
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnOpenParenthesis = new Button();
            btnCloseParenthesis = new Button();
            btnDelete = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnClear = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnPow = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnResult = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = Color.Green;
            txtDisplay.Font = new Font("Segoe UI", 18F);
            txtDisplay.Location = new Point(21, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(670, 47);
            txtDisplay.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 18F);
            btn7.Location = new Point(21, 78);
            btn7.Name = "btn7";
            btn7.Size = new Size(69, 67);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button1_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 18F);
            btn8.Location = new Point(103, 78);
            btn8.Name = "btn8";
            btn8.Size = new Size(62, 67);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 18F);
            btn9.Location = new Point(187, 78);
            btn9.Name = "btn9";
            btn9.Size = new Size(63, 67);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnOpenParenthesis.Font = new Font("Segoe UI", 18F);
            btnOpenParenthesis.Location = new Point(272, 78);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(61, 67);
            btnOpenParenthesis.TabIndex = 4;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnCloseParenthesis.Font = new Font("Segoe UI", 18F);
            btnCloseParenthesis.Location = new Point(357, 78);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(63, 67);
            btnCloseParenthesis.TabIndex = 5;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Font = new Font("Segoe UI", 18F);
            btnDelete.Location = new Point(454, 78);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(237, 67);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 18F);
            btn6.Location = new Point(187, 163);
            btn6.Name = "btn6";
            btn6.Size = new Size(63, 67);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button7_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 18F);
            btn5.Location = new Point(103, 163);
            btn5.Name = "btn5";
            btn5.Size = new Size(62, 67);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 18F);
            btn4.Location = new Point(21, 163);
            btn4.Name = "btn4";
            btn4.Size = new Size(69, 67);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 128, 0);
            btnDivide.Font = new Font("Segoe UI", 18F);
            btnDivide.Location = new Point(357, 163);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(63, 67);
            btnDivide.TabIndex = 10;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(255, 128, 0);
            btnMultiply.Font = new Font("Segoe UI", 18F);
            btnMultiply.Location = new Point(272, 163);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(61, 67);
            btnMultiply.TabIndex = 11;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Font = new Font("Segoe UI", 18F);
            btnClear.Location = new Point(454, 163);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(237, 67);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += button12_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 18F);
            btn3.Location = new Point(187, 245);
            btn3.Name = "btn3";
            btn3.Size = new Size(63, 67);
            btn3.TabIndex = 13;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 18F);
            btn2.Location = new Point(103, 245);
            btn2.Name = "btn2";
            btn2.Size = new Size(62, 67);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 18F);
            btn1.Location = new Point(21, 245);
            btn1.Name = "btn1";
            btn1.Size = new Size(69, 67);
            btn1.TabIndex = 15;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 128, 0);
            btnMinus.Font = new Font("Segoe UI", 18F);
            btnMinus.Location = new Point(357, 245);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(63, 67);
            btnMinus.TabIndex = 16;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 128, 0);
            btnPlus.Font = new Font("Segoe UI", 18F);
            btnPlus.Location = new Point(272, 245);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(61, 67);
            btnPlus.TabIndex = 17;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnPow
            // 
            btnPow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPow.BackColor = Color.FromArgb(255, 128, 0);
            btnPow.Font = new Font("Segoe UI", 18F);
            btnPow.Location = new Point(454, 245);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(237, 67);
            btnPow.TabIndex = 18;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += button18_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 18F);
            btn0.Location = new Point(21, 330);
            btn0.Name = "btn0";
            btn0.Size = new Size(144, 80);
            btn0.TabIndex = 19;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 18F);
            btnDot.Location = new Point(187, 330);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(63, 80);
            btnDot.TabIndex = 20;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnResult
            // 
            btnResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnResult.BackColor = Color.FromArgb(255, 128, 0);
            btnResult.Font = new Font("Segoe UI", 18F);
            btnResult.Location = new Point(272, 330);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(419, 80);
            btnResult.TabIndex = 21;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(711, 453);
            Controls.Add(btnResult);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnPow);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btnClear);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btnDelete);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Functions Evaluator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnOpenParenthesis;
        private Button btnCloseParenthesis;
        private Button btnDelete;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnClear;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnPow;
        private Button btn0;
        private Button btnDot;
        private Button btnResult;
    }
}
