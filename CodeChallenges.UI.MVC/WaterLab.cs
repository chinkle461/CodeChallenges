using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.UI.MVC
{
    class WaterLab
    {
        static void Main()
        {
            /*
             * Write a program that will:
             * 
             * -Assume that a gallon of water weighs 8.33 pounds
             * -Prompt the user to enter a number of gallons
             * -Display the total weight of the water in pounds
             */

            Console.Write("How many gallons of water do you have? ");
            string stringGalWater = Console.ReadLine();
            int galWater = int.Parse(stringGalWater);
            Console.WriteLine($"You have {galWater} gallons of water, and it weighs {galWater * 8.33} pounds.");
        }//end Main
    }//end class
}//end namespace
