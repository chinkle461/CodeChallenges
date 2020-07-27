using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.UI.MVC
{
    class ChangeLab
    {
        static void Main(string[] args)
        {
            /*
          * Write a program that will:
          * 
          * -Prompt the user to enter an amount of dollars and 
          * cents. For example: 1.18
          * -Display the number of quarters, dimes, nickels,
          * and pennies to make that amount.
          * 
          * Ex: If they entered 1.18 it should say:
          * 4 quarters, 1 dimes, 1 nickels, 3 pennies
          * 
          * Ex: If they entered 2.02 it should say:
          * 8 quarters, 0 dimes, 0 nickels, 2 pennies
          * 
          * HINT: Break it into small problems
          * (how do I figure out the quarters, then dimes, etc)
          */

            Console.Write("How much money do you have? $");
            string stringUser = Console.ReadLine();

            decimal money = decimal.Parse(stringUser) * 100;
            int user = (int)money;



            //int user = Convert.ToInt32(stringUser);

            //need to convert # *100


            int quarters = user / 25;
            user = user % 25;


            int dimes = user / 10;
            user = user % 10;


            int nickels = user / 5;
            user = user % 5;


            int pennies = user;

            Console.WriteLine("\nYou have: \n{0} Quarters\n{1} Dimes\n{2} Nickels \n{3} Pennies", quarters, dimes, nickels, pennies);

        }
    }
}
