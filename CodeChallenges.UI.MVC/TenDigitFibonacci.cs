using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.UI.MVC
{
    class TenDigitFibonacci
    {
        static void Main(string[] args)
        {
            /*
             * The Fibonacci sequence is defined by the recurrence relation:
             * 
             * Fn = Fn-1 + Fn-2, where F1 = 1 and F2=1.
             * 
             * Hence the first 12  terms will be:
             * 
             * F1 = 1
             * F2 = 1
             * F3 = 2
             * F4 = 
             * F5 = 
             * F6 = 
             * F7 =
             * F8 = 
             * F9 = 
             * F10 = 55
             * F11 = 89
             * F12 = 144
             *              * 
             * The 12th term, F12, is the first term to contain three digits.
             * 
             * What is the index of the first term in the Fibonacci sequence to contain 10 digits
             */

            //Solution 2
            //int num1 = 0;
            //int num2 = 1;
            //int num3 = 0;
            //int index = 0;
            //bool repeat = true;

            //while (repeat)
            //{
            //    num3 = num1 + num2;
            //    num1 = num2;
            //    num2 = num3;
            //    index++;
            //    if (num3.ToString().Length == 10)
            //    {
            //        repeat = false;
            //    }
            //}

            int num1 = 0;
            int num2 = 1;
            int num3 = 0;
            int tenDigit = 0;

            while (num3 <= 1000000000)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                tenDigit++;//+= 1 also works
            }
            Console.WriteLine($"It took {tenDigit} times to reach the first number with 10 digits.");
            Console.WriteLine($"The first number in the Fibonacci sequence that is 10 digits is {num3:N0}");

        }
    }
}