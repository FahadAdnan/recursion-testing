using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class RecursionAlgorithums
    {
        #region Checking if a String is a Palandrome
        //Base Case (Simpliest Case): either one character, "x", or "" empty string--> return true
        //General Case (Majority Cases): String.length>1 : Keep on checking first and last value 
        //returning substring w/0 first and last letter

        public static bool isPalindrome(string s)
        {
            if (s.Length > 1)
            {
                if (s[0] == s[s.Length - 1])
                {
                    return isPalindrome(s.Substring(1, s.Length - 2));
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        #endregion

        #region Find the Factorial of a number
        //Base Case (Simpliest Case): n = 1 or 0, Note: 0! =1
        //General Case (Majority Cases): return n * FindFactorial(n-1) -> ... * 1 
        public static ulong FindFactorial(ulong n)
        {
            if (n > 1)
            {
                return n*FindFactorial(n-1);
            }
           return 1; // only goes to this condition if n==0 or n==1
        }
        #endregion

        #region Fibbonachi value of a number w/ simple recursion
        //Base Case (Simpliest Case): n = 1 or n=2, first 2 values in fibbonachi sequence are 1
        //General Case (Majority Cases): Return sum of 2 previous fibbonachi values 
         // Note: Not a good method -> repeats calculating previous fibbonachi values
        public static int FibbonachiValue(int n)
        {
            // n == position of value in fibbonachi sequence
            if (n <= 1)
            {
                return 1;
            }
            return FibbonachiValue(n - 1) + FibbonachiValue(n - 2);
        }
        #endregion

        #region Euclidean GCD of Two Values

        // The Euclidean Algorithum for finding the GCD works on the basis that
        // GCD Divisor of (a and b) = GCD Divisor (b, a%b), where a > b
        // Example: 72 and 16 |  a = 72 , b = 16
        // 72%16 = 8 | b = 8    a= oldB = 16 
        // 16%8 = 0 | b = 0     a= oldB = 8
        // Now as B == 0 then return a which is 8 == greatest common divisor
        //Proved rigorously in Math135 using GCDWR


        //Base Case (Simpliest Case): b == 0, return the value of a which is the old b 
        //General Case (Majority Cases): b!=0 , return a=oldB  and b=a%b
      
        public static int EuclideanGCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0 && b == 0)
            {
                return 0;
            }
            else if (b == 0)// if position is 0 in sequence - not possible
            {
                return a;
            }
            return EuclideanGCD(b, a % b); //now  a==b and b==a%b, repeat until b==0

        }

        #endregion

        #region Summing values in Range with Recursion
        //Summing values from one index to the other 
        //Base Case (Simpliest Case): startval = endval --> sum is endvalue
        //General Case (Majority Cases): startval < endval -->sum all values in between w/ recursion
        public static int SumValuesRange(int start, int end)
        {
            // n == position of value in fibbonachi sequence
            if (start == end || start > end)
            {
                return end;
            }
            return start + SumValuesRange(start + 1, end);
        }
        #endregion

        #region Sum of Digits in a Integer
        //Summing values from one index to the other 
        //Base Case (Simpliest Case): Amount of digits is 1 --> return the number 
        //General Case (Majority Cases): Amount of digits > 1 --> add largest digits and remove from number repeat to base case
        public static int SumDigits(int number)
        {
            int power, NumAdd;
            // n == position of value in fibbonachi sequence
            power = (int)Math.Floor(Math.Log10(number));
            number = Math.Abs(number);

            if (power == 0)
            {
                return number;
            }
             NumAdd = (int)(number / Math.Pow(10, power));
            return NumAdd + SumDigits(number - (int)(NumAdd * Math.Pow(10, power)));
        }

        #endregion

        #region Fibbonachi value Memoization / Dynamic Programming
         //Base Case (Simpliest Case): index is 1 or 2: Returns value 1 
        //General Case (Majority Cases): Check if value is in arraylist otherwise calculate it with two previous values 

        public static ulong FibbonachiValueMemoized(int n, ulong[] fibvalues)
        {
            ulong result;
            if (fibvalues[n] != 0)
            {
                return fibvalues[n]; // if value exits in array 
            }
            else if (n == 1 || n == 2)
            {
                return 1; // base case endregion
            }
           
            result = FibbonachiValueMemoized(n - 2, fibvalues) + FibbonachiValueMemoized(n - 1, fibvalues);
            fibvalues[n] = result; //store index of fibbonachi sequence with value associated for later reference.
            return result;
        }
        #endregion

        #region Max Value Finder in Arraylist
        //Base Case (Simpliest Case): one number in array= largest number
        //General Case (Majority Cases): lots of numbers in list, so then compare 2 and remove one 
        public static List<int> LargestValue(List<int> arraynumbers)
        {
            if (arraynumbers.Count == 1)
            {
                return arraynumbers;
            }
            if (arraynumbers[0] < arraynumbers[1])
            {
                arraynumbers.RemoveAt(0);
            }
            else
            {
                arraynumbers.RemoveAt(1);
            }
            return arraynumbers;
        }
        #endregion

    }
}