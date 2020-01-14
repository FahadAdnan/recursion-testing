using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursion
{
    public partial class Form1 : Form
    {
        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        System.Diagnostics.Stopwatch stopwatch2 = new System.Diagnostics.Stopwatch();
        int indexA, indexB;

        public Form1()
        {
            InitializeComponent();
        }


        private void RecursionPalindromeBtn(object sender, EventArgs e)
        {
            stopwatch.Start();
            bool b = RecursionAlgorithums.isPalindrome(PalindromeStringInput.Text);

            if (b == true)
            {
                OutputTxt.Text = "true";
            }
            else
            {
                OutputTxt.Text = "false";
            }
            stopwatch.Stop();
            RecursionTimeOutput.Text = "Recursion Time: " + (stopwatch.ElapsedMilliseconds.ToString()) + " ms";
            stopwatch.Reset();
        }

        private void RecursionFactorialBtn(object sender, EventArgs e)
        {
            stopwatch.Start();
            ulong factorialvalue = RecursionAlgorithums.FindFactorial(ulong.Parse(FactorialInput.Text));

            if (ulong.Parse(FactorialInput.Text) >= 0 && ulong.Parse(FactorialInput.Text) < 0)
            {
                OutputTxt.Text = factorialvalue.ToString();
            }
            else
            {
                OutputTxt.Text = "number entered is too large/negative";
            }
            stopwatch.Stop();
            RecursionTimeOutput.Text = "Recursion Time: " + (stopwatch.ElapsedMilliseconds.ToString()) + " ms";
            stopwatch.Reset();

        }

        private void RecursionFibbonachiBtn(object sender, EventArgs e)
        {
            stopwatch.Start();
            indexA = int.Parse(FibbonacchiInputTxt.Text);
            int factorialvalue = RecursionAlgorithums.FibbonachiValue(indexA) ;

            if (indexA > 0)
            {
                OutputTxt.Text = factorialvalue.ToString();
            }
            else
            {
                OutputTxt.Text = "not valid index";
            }
            stopwatch.Stop();
            RecursionTimeOutput.Text = "Recursion Time: " + (stopwatch.ElapsedMilliseconds.ToString()) + " ms";
            stopwatch.Reset();
        }

        private void RecursionEuclideanGCD(object sender, EventArgs e)
        {
            stopwatch.Start();

            indexA = int.Parse(numAinput.Text);
            indexB = int.Parse(numBinput.Text);

            int GCD = RecursionAlgorithums.EuclideanGCD(indexA, indexB);
           
            OutputTxt.Text = GCD.ToString();
        
            stopwatch.Stop();
            RecursionTimeOutput.Text = "Recursion Time: " + (stopwatch.ElapsedMilliseconds.ToString()) + " ms";
            stopwatch.Reset();
        }

        private void RecursionFindSumBtn(object sender, EventArgs e)
        {
            stopwatch.Start();

            indexA = int.Parse(SumAInput.Text);
            indexB = int.Parse(SumBInput.Text);
            int sum = RecursionAlgorithums.SumValuesRange(indexA, indexB);

            if (indexA <= indexB)
            {
                OutputTxt.Text = sum.ToString();
            }
            else
            {
                OutputTxt.Text = "Start is greater than End";
            }
            stopwatch.Stop();
            RecursionTimeOutput.Text = "Recursion Time: " + (stopwatch.ElapsedMilliseconds.ToString()) + " ms";
            stopwatch.Reset();
        }

        private void RecursionDigitsSumBtn(object sender, EventArgs e)
        {
            stopwatch.Start();

            indexA = int.Parse(DigitSumInput.Text);
            int sumdigits = RecursionAlgorithums.SumDigits(indexA);

            if (indexA >= 1)
            {
                OutputTxt.Text = sumdigits.ToString();
            }
            else
            {
                OutputTxt.Text = "Error with inputted Values";
            }
            stopwatch.Stop();
            RecursionTimeOutput.Text = "Recursion Time: " + (stopwatch.ElapsedMilliseconds.ToString()) + " ms";
            stopwatch.Reset();
        }

        private void FibbonachiMemoized(object sender, EventArgs e)
        {
            stopwatch2.Start();
            ulong[] fibvalues = new ulong[ulong.Parse(FibbonacchiInputTxt.Text) + 1];

            indexA = int.Parse(FibbonacchiInputTxt.Text);
            ulong fibvalue = RecursionAlgorithums.FibbonachiValueMemoized(indexA, fibvalues);

            stopwatch2.Stop();

            if (fibvalue > 0)
            {
                OutputTxt.Text = fibvalue.ToString();
            }
            else
            {
                OutputTxt.Text = "can't have a 0/- position in sequence";
            }
            MemoizationTimeOutput.Text = "Recursion Time Memoized: " + (stopwatch2.ElapsedMilliseconds.ToString()) + " ms";
            stopwatch2.Reset();
        }


    }
}
