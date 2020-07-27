using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.UI.MVC
{
    class ATM
    {
        static void Main(string[] args)
        {
            /*
            * Write a program that will:
            *  -a) ask the user to enter an account number for their account and continue
            *  to ask the user for their account number until they get it right (the correct
            *  account number will be hard coded in your code.  See the Login section for an
            *  example). Optionally, consider locking them out after a certain number of failed
            *  attempts.
            *  
            *  -b) Once they get the correct account number, ask them for a pin number
            *  (you can use the additional Login functionality as a reference). Just
            *  as you did for their account number, continue to prompt the user for 
            *  their pin until they get it correct.  (The correct value will be hard
            *  coded just as it was for the account number)
            *  
            *  -c)Once, the user has successfully given their account and pin numbers,
            *  prompt the user with a menu and ask them if they want to do a deposit, 
            *  a withdrawal, or exit the application.
            *  
            *  -d) If they choose to do a deposit, ask them for the amount to deposit,
            *  and display the amount deposited.
            *      i) Ex. "$500.00 has been deposited into account number 12345"
            *  
            *  -e)If they choose to withdraw money, ask them for the amount to withdraw
            *  and display the amount of withdraw.
            *      i) Ex. "$500.00 has been withdrawn from account number 12345"
            *  
            *  -f)After each transaction (deposit or withdrawal), ask the user if they
            *  want to do another transaction - deposit, withdraw, or exit the application
            *  
            *  -g)When the user exits the application, thank them for their business.
            *  
            *  Aditional options - 
            *      -keep a running total of the account balance, assuming that the account
            *      starts at $0
            *      -Everytime the user makes a deposit to - or withdraw from - the account,
            *     the balance should be updated and displayed
            *     - Add a feature for the user to make a balance request that will display
            *     their current balance (without needing to make a deposit or withdrawal)
            *      
            */


            int correctAcctNbr = 8675309;

            Console.WriteLine("Enter your username acct: ");
            for (int x = 0; x < 3; x++)
            //x=0 is where you start, x is less than 3 means you have 3 trys, x++ is counting up by 1
            {
                int acctNbr = Convert.ToInt32(Console.ReadLine());

                if (acctNbr != correctAcctNbr)
                {
                    if (x < 2)//established variable is less than 2
                    {
                        Console.WriteLine("You've entered the incorrect number, Please try again");
                        //strike one and two are here
                    }
                    else
                    {
                        //strike three
                        Console.WriteLine("Thank you, come again!");
                        Environment.Exit(0);
                    }//end else
                }//end if
                else
                {
                    Console.WriteLine("Hello Jenny, Jenny!");
                    Console.WriteLine("Enter you pin!!");
                    break;
                }//end else
            }//end for


            int pinName = Convert.ToInt32(Console.ReadLine());
            if (pinName != 5411)
            {
                Console.WriteLine("You entered an inccorect pin number. Thank you, come again!");
                Environment.Exit(0);
            }//end if

            Console.WriteLine("Access granted!!");




            Console.Clear();

            bool repeat = true; //Counter
            decimal balance = 0m;
            Console.Title = "Balance: $" + balance.ToString();//balance won't work unless you have ToString - if this is outside it won't update
            //now that this is before it shows and by putting it below in the do while it updates as you go

            do
            {

                Console.WriteLine("Welcome to the self-serve kiosk!\nChoose an option from the menu below:\n" +
                    "C)heck Balance\n" +
                    "M)ake a Deposit\n" +
                    "W)ithdraw\n" +
                    "E)xit");
                ConsoleKey userChoice = Console.ReadKey().Key;

                Console.Clear();

                switch (userChoice)
                {
                    case ConsoleKey.C:
                        Console.WriteLine("Your current balance is {0:c}.", balance);
                        break;

                    case ConsoleKey.M:
                        Console.Write("Enter your deposit amount: ");
                        balance += decimal.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Your deposit will reflect within 24 hrs.");
                        break;

                    case ConsoleKey.W:
                        Console.WriteLine("Enter your Withdraw amount: ");
                        balance -= decimal.Parse(Console.ReadLine());
                        break;

                    case ConsoleKey.E:
                    case ConsoleKey.X:
                        Console.WriteLine("Thank you! Have a great day!");
                        repeat = false; // This exits the program
                        break;

                    default:
                        Console.WriteLine("That was an invalid option.");
                        break;
                }//end switch
                Console.Title = "Balance: $" + balance.ToString();//balance won't work unless you have ToString
                                                                  //now that this is before it shows and by putting it below in the do while it updates as you go
            } while (repeat);//== true, !=false all work ---if you don't change this from true it will stay in a continual loop

        }//end Main
    }//end Class
}//end namespace
