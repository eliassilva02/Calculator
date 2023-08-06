namespace Calculator_001
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonMultiply = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            buttonDivision = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonSubstract = new Button();
            buttonSum = new Button();
            buttonResult = new Button();
            button0 = new Button();
            buttonLimpar = new Button();
            txtBoxVisor = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 76);
            button1.Name = "button1";
            button1.Size = new Size(76, 42);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(94, 76);
            button2.Name = "button2";
            button2.Size = new Size(76, 42);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(176, 76);
            button3.Name = "button3";
            button3.Size = new Size(76, 42);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMultiply.Location = new Point(258, 76);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(76, 42);
            buttonMultiply.TabIndex = 3;
            buttonMultiply.Text = "×";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 124);
            button4.Name = "button4";
            button4.Size = new Size(76, 42);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(94, 124);
            button5.Name = "button5";
            button5.Size = new Size(76, 42);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(176, 124);
            button6.Name = "button6";
            button6.Size = new Size(76, 42);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // buttonDivision
            // 
            buttonDivision.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDivision.ImageAlign = ContentAlignment.TopCenter;
            buttonDivision.Location = new Point(258, 124);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(76, 42);
            buttonDivision.TabIndex = 7;
            buttonDivision.Text = "÷";
            buttonDivision.UseVisualStyleBackColor = true;
            buttonDivision.Click += buttonDivision_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 172);
            button7.Name = "button7";
            button7.Size = new Size(76, 42);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(94, 172);
            button8.Name = "button8";
            button8.Size = new Size(76, 42);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(176, 172);
            button9.Name = "button9";
            button9.Size = new Size(76, 42);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // buttonSubstract
            // 
            buttonSubstract.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubstract.Location = new Point(258, 172);
            buttonSubstract.Name = "buttonSubstract";
            buttonSubstract.Size = new Size(76, 42);
            buttonSubstract.TabIndex = 11;
            buttonSubstract.Text = "-";
            buttonSubstract.UseVisualStyleBackColor = true;
            buttonSubstract.Click += buttonSubstract_Click;
            // 
            // buttonSum
            // 
            buttonSum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSum.Location = new Point(258, 220);
            buttonSum.Name = "buttonSum";
            buttonSum.Size = new Size(76, 42);
            buttonSum.TabIndex = 15;
            buttonSum.Text = "+";
            buttonSum.UseVisualStyleBackColor = true;
            buttonSum.Click += buttonSum_Click;
            // 
            // buttonResult
            // 
            buttonResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonResult.Location = new Point(176, 220);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(76, 42);
            buttonResult.TabIndex = 14;
            buttonResult.Text = "=";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // button0
            // 
            button0.Location = new Point(94, 220);
            button0.Name = "button0";
            button0.Size = new Size(76, 42);
            button0.TabIndex = 13;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(12, 220);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(76, 42);
            buttonLimpar.TabIndex = 12;
            buttonLimpar.Text = "C";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // txtBoxVisor
            // 
            txtBoxVisor.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxVisor.Location = new Point(12, 12);
            txtBoxVisor.Multiline = true;
            txtBoxVisor.Name = "txtBoxVisor";
            txtBoxVisor.ReadOnly = true;
            txtBoxVisor.Size = new Size(322, 49);
            txtBoxVisor.TabIndex = 16;
            txtBoxVisor.TextAlign = HorizontalAlignment.Right;
            txtBoxVisor.TextChanged += txtBoxVisor_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 270);
            Controls.Add(txtBoxVisor);
            Controls.Add(buttonSum);
            Controls.Add(buttonResult);
            Controls.Add(button0);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonSubstract);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(buttonDivision);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttonMultiply);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonMultiply;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button buttonDivision;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonSubstract;
        private Button buttonSum;
        private Button buttonResult;
        private Button button0;
        private Button buttonLimpar;
        private TextBox txtBoxVisor;
    }
}