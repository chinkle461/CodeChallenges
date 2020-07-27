using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.UI.MVC
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {
            /*
             * Declare and initialize an array of any six fruit names (as text). Set up a FOR loop and iterate
             * through them (displaying each value in the console.)
             */

            //string[] fruitLoops = { "cherry", "blueberry", "apple", "pear", "strawberry", "raspberry" };

            //for (int fruit = 0; fruit < fruits.Length; fruit++)
            //{
            //    if (fruit == 0)
            //    {
            //        Console.WriteLine(fruit[0]);
            //    }
            //    if (fruit == 1)
            //    {

            //    }
            //}


            string[] fruitLoops = { "cherry", "blueberry", "apple", "pear", "strawberry", "raspberry" };

            for (int i = 0; i < fruitLoops.Length; i++)
            {
                Console.WriteLine(fruitLoops[i]);
            }

        }//end Main
    }//end class
}//end namespace
