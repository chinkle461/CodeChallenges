using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.UI.MVC
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("Would you like to do a temperature conversion? Y/N ");
                string userResponse1 = Console.ReadLine().ToUpper();
                if (userResponse1 == "Y" || userResponse1 == "YES")
                {
                    Console.Clear();
                    Console.WriteLine("Choose which temperature you'd like to convert to:\n"
                        + "C)elsius\n" +
                        "F)ahrenheit\n");
                    string userTemp = Console.ReadLine().ToUpper();

                    if (userTemp == "C" || userTemp == "CELSIUS")
                    {
                        Console.Clear();
                        Console.WriteLine("Enter the Fahrenheit temperature\n");
                        string response = Console.ReadLine();
                        decimal temp = decimal.Parse(response) - 32;
                        temp = temp / (9.0m / 5.0m);
                        int celsius = (int)temp;
                        Console.WriteLine($"The temperature in Celsius is {celsius}.");

                    }//end if celsius

                    else if (userTemp == "F" || userTemp == "FAHRENHEIT")
                    {
                        Console.Clear();
                        Console.WriteLine("Enter the Celsius temperature");
                        string userResponse = Console.ReadLine();
                        decimal temp = decimal.Parse(userResponse) * ((9.0m / 5.0m));
                        temp = temp + 32;
                        int fahrenheit = (int)temp;
                        Console.WriteLine($"The temperature in Fahrenheit is {fahrenheit}.");
                    }//end if fahrenheit

                }//end if user chose Y

                else if (userResponse1 == "N" || userResponse1 == "NO")
                {
                    Console.WriteLine("Thanks.  Program closing.");
                    repeat = false;
                }//end else if user chose N

                else
                {
                    Console.WriteLine("Invalid response. Program closing.");
                }//end else
            } while (repeat == true);


        }//end Main
    }//end class
}//end namespace