using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.UI.MVC
{
    class Multiples3And5
    {
        static void Main(string[] args)
        {
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6, and 9. The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.
            Console.Title = "Multiples of 3 and 5";
            int sum = 0;//sum starts at 0
            for (int n = 0; n < 1000; n++)//n loops through 1000x's, starting at 0, going up by 1
            {
                if (n % 3 == 0 || n % 5 == 0)//n is the numbers going through the loop /3=0 and /5=0 saying divisible
                {
                    sum += n;//then add the #'s divisible to sum this is done with += 
                };
            }
            Console.WriteLine(sum);
        }
    }
}
