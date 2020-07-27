using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.UI.MVC
{
    class InterestCalculator
    {
        static void Main(string[] args)
        {
            //decimal origDeposit = 1000;
            //decimal year1 = (origDeposit * .05m) + origDeposit;            
            //decimal year2 = (year1 * .05m) + year1;
            //Console.WriteLine(year2);

            Console.WriteLine("How much money would you like to deposit? ");
            string stringUser = Console.ReadLine();
            decimal origDeposit = decimal.Parse(stringUser);
            Console.WriteLine("What interest rate are you wanting? ");
            string userInterest = Console.ReadLine();
            decimal intPercentage = decimal.Parse(userInterest) / 100;
            Console.WriteLine("How many years are you looking to invest the money? ");
            string stringYears = Console.ReadLine();
            int years = Convert.ToInt32(stringYears);

            for (int x = 0; x < years; x++)
            {
                origDeposit = (origDeposit * intPercentage) + origDeposit;
            }

            Console.WriteLine("The amount you will have in {0} year{1} is: {2:c}", years, years == 1 ? "" : "s", origDeposit);

        }//end main
    }//end class
}//end namespace
