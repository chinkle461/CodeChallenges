using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.UI.MVC
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.Title = "Fibonacci";

            Console.WriteLine("Enter a number");
            int userNum = int.Parse(Console.ReadLine());

            int num1 = 0;
            int num2 = 1;
            int num3 = 0;
            Console.WriteLine("{0}\n{1}", num1, num2);

            for (int i = 2; i < userNum; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine("{0}", num3);
                num1 = num2;
                num2 = num3;

            }
        }
    }
}
