using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.UI.MVC
{
    class Login
    {
        static void Main(string[] args)
        {
            //bool isVerified = false;

            //Console.WriteLine("Please enter your username: ");
            //string userName = Console.ReadLine().ToUpper();
            //if (userName == "ADMIN" || userName == "CHRIS")
            //{
            //    isVerified = true;
            //}//end if

            //if (isVerified)
            //{
            //    Console.WriteLine("Access granted!!");
            //}//end if
            //else if (userName != "ADMIN" || userName != "CHRIS")
            //{
            //    Console.WriteLine("Username not on file! Access denied!");
            //}




            //put this in a do while loop######


            const string acctUserName = "CHRIS";
            Console.WriteLine("Enter your username: ");
            for (int x = 0; x < 3; x++)
            //x=0 is where you start, x is less than 3 means you have 3 trys, x++ is counting up by 1
            {
                string userName = (Console.ReadLine().ToUpper());


                if (userName != acctUserName)
                {
                    if (x < 2)//established variable is less than 2
                    {
                        Console.WriteLine("You've entered the incorrect username, Please try again");
                        //strike one and two are here
                    }
                    else
                    {
                        //strike three
                        Console.WriteLine("You've entered the incorrect username, please try again later.");
                        Environment.Exit(0);
                    }//end else

                }//end if
                else
                {
                    Console.WriteLine("Enter you pin!!");
                    break;
                }//end else


            }//end for


            const int correctPinNbr = 5409;
            for (int y = 0; y < 3; y++)
            //x=0 is where you start, x is less than 3 means you have 3 trys, x++ is counting up by 1
            {
                int pinNbr = Convert.ToInt32(Console.ReadLine());

                if (pinNbr != correctPinNbr)
                {
                    if (y < 2)//established variable is less than 2
                    {
                        Console.WriteLine("You've entered the incorrect pin number, Please try again");
                        //strike one and two are here
                    }
                    else
                    {
                        //strike three
                        Console.WriteLine("You've entered the incorrect pin, please try again later.");
                        Environment.Exit(0);
                    }//end else
                }//end if
                else
                {
                    Console.WriteLine("Access Granted!!");
                    break;
                }//end else access granted


            }//end for

        }//end main
    }//end class
}//end namespace
