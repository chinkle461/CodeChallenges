using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.UI.MVC
{
    class FruitLoop2
    {
        static void Main(string[] args)
        {
            /*
             * Repeat the FruitLoop1 exercise, but for each of the fruit names that you display, on the next line display a number of periods that
             * is equal to the number of the index of the array.
             */

            string[] fruitLoops = { "cherry", "blueberry", "apple", "pear", "strawberry", "raspberry" };

            for (int fruit = 0; fruit < fruitLoops.Length; fruit++)
            {
                if (fruit == 0)
                {
                    Console.WriteLine(fruitLoops[0] + "\n.");
                }
                if (fruit == 1)
                {
                    Console.WriteLine(fruitLoops[1] + "\n..");
                }
                if (fruit == 2)
                {
                    Console.WriteLine(fruitLoops[2] + "\n...");
                }
                if (fruit == 3)
                {
                    Console.WriteLine(fruitLoops[3] + "\n....");
                }
                if (fruit == 4)
                {
                    Console.WriteLine(fruitLoops[4] + "\n.....");
                }
                if (fruit == 5)
                {
                    Console.WriteLine(fruitLoops[5] + "\n......");
                }
            }
        }//end Main
    }//end class
}//end namespace
