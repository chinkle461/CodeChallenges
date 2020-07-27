using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.UI.MVC
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to play FizzBuzz: ");
            Console.Title = "FizzBuzz";
            int curNum = 0;
            int userNum = int.Parse(Console.ReadLine());

            do
            {
                bool fizz = false;
                bool buzz = false;
                bool fizzBuzz = false;
                curNum++;

                //FizzBuzz or no
                if (curNum % 3 == 0 && curNum % 5 == 0)
                {
                    fizzBuzz = true;
                }//end if

                //Buzz or no
                else if (curNum % 5 == 0)
                {
                    buzz = true;
                }//end else if

                //Fizz or no
                else if (curNum % 3 == 0)
                {
                    fizz = true;
                }//end else if

                //None of the above
                else
                {
                    Console.WriteLine(curNum);
                }//end else

                //Display FizzBuzz
                if (fizzBuzz == true)
                {
                    Console.WriteLine("Fizz" + "Buzz");
                }//end if

                //Display Fizz
                if (fizz == true)
                {
                    Console.WriteLine("Fizz");
                }//end if

                //Display Buzz
                if (buzz == true)
                {
                    Console.WriteLine("Buzz");
                }


            } while (curNum < userNum);



        }
    }
}
