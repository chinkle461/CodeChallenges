using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.UI.MVC
{
    class AndThen
    {
        static void Main(string[] args)
        {
            /*
             * Count up by 1 and put then after each number.  Be sure there isn’t a then after last number
             */
            int number = 60;

            for (int i = 0; i < 10; i++)
            {
                if (number != 69)
                {
                    number = number + 1;
                    Console.WriteLine($"{number} then");
                }
                else
                {
                    number = number + 1;
                    Console.WriteLine(number);
                }
            }
        }
    }
}
