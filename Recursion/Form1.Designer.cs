namespace Recursion
{
    partial class Form1
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
            this.PalindromeBtnClick = new System.Windows.Forms.Button();
            this.PalindromeStringInput = new System.Windows.Forms.TextBox();
            this.OutputTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FactorialInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FibbonacchiInputTxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numAinput = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.numBinput = new System.Windows.Forms.TextBox();
            this.RecursionTimeOutput = new System.Windows.Forms.Label();
            this.MemoizationTimeOutput = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SumBInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SumAInput = new System.Windows.Forms.TextBox();
            this.btn39 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.DigitSumInput = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PalindromeBtnClick
            // 
            this.PalindromeBtnClick.Location = new System.Drawing.Point(88, 125);
            this.PalindromeBtnClick.Name = "PalindromeBtnClick";
            this.PalindromeBtnClick.Size = new System.Drawing.Size(110, 36);
            this.PalindromeBtnClick.TabIndex = 0;
            this.PalindromeBtnClick.Text = "Check if Palindrome";
            this.PalindromeBtnClick.UseVisualStyleBackColor = true;
            this.PalindromeBtnClick.Click += new System.EventHandler(this.RecursionPalindromeBtn);
            // 
            // PalindromeStringInput
            // 
            this.PalindromeStringInput.Location = new System.Drawing.Point(84, 88);
            this.PalindromeStringInput.Name = "PalindromeStringInput";
            this.PalindromeStringInput.Size = new System.Drawing.Size(110, 20);
            this.PalindromeStringInput.TabIndex = 2;
            // 
            // OutputTxt
            // 
            this.OutputTxt.AutoSize = true;
            this.OutputTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTxt.ForeColor = System.Drawing.Color.Crimson;
            this.OutputTxt.Location = new System.Drawing.Point(13, 271);
            this.OutputTxt.Name = "OutputTxt";
            this.OutputTxt.Size = new System.Drawing.Size(126, 30);
            this.OutputTxt.TabIndex = 3;
            this.OutputTxt.Text = "OuputText";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Palindrome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Factorial";
            // 
            // FactorialInput
            // 
            this.FactorialInput.Location = new System.Drawing.Point(217, 88);
            this.FactorialInput.Name = "FactorialInput";
            this.FactorialInput.Size = new System.Drawing.Size(110, 20);
            this.FactorialInput.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Find Factorial";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RecursionFactorialBtn);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fibbonachi";
            // 
            // FibbonacchiInputTxt
            // 
            this.FibbonacchiInputTxt.Location = new System.Drawing.Point(348, 88);
            this.FibbonacchiInputTxt.Name = "FibbonacchiInputTxt";
            this.FibbonacchiInputTxt.Size = new System.Drawing.Size(110, 20);
            this.FibbonacchiInputTxt.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Find Fibbonachi value";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RecursionFibbonachiBtn);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Euclidean GCD";
            // 
            // numAinput
            // 
            this.numAinput.Location = new System.Drawing.Point(476, 88);
            this.numAinput.Name = "numAinput";
            this.numAinput.Size = new System.Drawing.Size(49, 20);
            this.numAinput.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(480, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 36);
            this.button3.TabIndex = 11;
            this.button3.Text = "Find GCD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.RecursionEuclideanGCD);
            // 
            // numBinput
            // 
            this.numBinput.Location = new System.Drawing.Point(531, 88);
            this.numBinput.Name = "numBinput";
            this.numBinput.Size = new System.Drawing.Size(49, 20);
            this.numBinput.TabIndex = 14;
            // 
            // RecursionTimeOutput
            // 
            this.RecursionTimeOutput.AutoSize = true;
            this.RecursionTimeOutput.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecursionTimeOutput.ForeColor = System.Drawing.Color.DarkBlue;
            this.RecursionTimeOutput.Location = new System.Drawing.Point(14, 311);
            this.RecursionTimeOutput.Name = "RecursionTimeOutput";
            this.RecursionTimeOutput.Size = new System.Drawing.Size(209, 23);
            this.RecursionTimeOutput.TabIndex = 15;
            this.RecursionTimeOutput.Text = "Elapsed Time Recursion";
            // 
            // MemoizationTimeOutput
            // 
            this.MemoizationTimeOutput.AutoSize = true;
            this.MemoizationTimeOutput.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoizationTimeOutput.ForeColor = System.Drawing.Color.DarkBlue;
            this.MemoizationTimeOutput.Location = new System.Drawing.Point(14, 334);
            this.MemoizationTimeOutput.Name = "MemoizationTimeOutput";
            this.MemoizationTimeOutput.Size = new System.Drawing.Size(237, 23);
            this.MemoizationTimeOutput.TabIndex = 16;
            this.MemoizationTimeOutput.Text = "Elapsed Time Memoization";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Recursion";
            // 
            // SumBInput
            // 
            this.SumBInput.Location = new System.Drawing.Point(668, 88);
            this.SumBInput.Name = "SumBInput";
            this.SumBInput.Size = new System.Drawing.Size(49, 20);
            this.SumBInput.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(598, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Sum from A to B";
            // 
            // SumAInput
            // 
            this.SumAInput.Location = new System.Drawing.Point(613, 88);
            this.SumAInput.Name = "SumAInput";
            this.SumAInput.Size = new System.Drawing.Size(49, 20);
            this.SumAInput.TabIndex = 20;
            // 
            // btn39
            // 
            this.btn39.Location = new System.Drawing.Point(617, 125);
            this.btn39.Name = "btn39";
            this.btn39.Size = new System.Drawing.Size(110, 36);
            this.btn39.TabIndex = 19;
            this.btn39.Text = "Find Sum";
            this.btn39.UseVisualStyleBackColor = true;
            this.btn39.Click += new System.EventHandler(this.RecursionFindSumBtn);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "String Input";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(235, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(235, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Integer Input";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(351, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Int Position Input";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(486, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "Int A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(539, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "Int B";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(623, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 15);
            this.label14.TabIndex = 29;
            this.label14.Text = "Int A";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(677, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 15);
            this.label15.TabIndex = 30;
            this.label15.Text = "Int B";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(767, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 15);
            this.label16.TabIndex = 34;
            this.label16.Text = "Int Input";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(740, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "Digits Sum";
            // 
            // DigitSumInput
            // 
            this.DigitSumInput.Location = new System.Drawing.Point(738, 88);
            this.DigitSumInput.Name = "DigitSumInput";
            this.DigitSumInput.Size = new System.Drawing.Size(110, 20);
            this.DigitSumInput.TabIndex = 32;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(742, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 36);
            this.button4.TabIndex = 31;
            this.button4.Text = "Digits Sum";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.RecursionDigitsSumBtn);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(352, 173);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 36);
            this.button6.TabIndex = 39;
            this.button6.Text = "Memoization Fibbonachi Value";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.FibbonachiMemoized);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(-1, 180);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 20);
            this.label20.TabIndex = 40;
            this.label20.Text = "Memoization";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(13, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 30);
            this.label8.TabIndex = 41;
            this.label8.Text = "Recursion Code ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 374);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.DigitSumInput);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SumBInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SumAInput);
            this.Controls.Add(this.btn39);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MemoizationTimeOutput);
            this.Controls.Add(this.RecursionTimeOutput);
            this.Controls.Add(this.numBinput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numAinput);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FibbonacchiInputTxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FactorialInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputTxt);
            this.Controls.Add(this.PalindromeStringInput);
            this.Controls.Add(this.PalindromeBtnClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PalindromeBtnClick;
        private System.Windows.Forms.TextBox PalindromeStringInput;
        private System.Windows.Forms.Label OutputTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FactorialInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FibbonacchiInputTxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numAinput;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox numBinput;
        private System.Windows.Forms.Label RecursionTimeOutput;
        private System.Windows.Forms.Label MemoizationTimeOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SumBInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SumAInput;
        private System.Windows.Forms.Button btn39;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox DigitSumInput;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label8;
    }
}

