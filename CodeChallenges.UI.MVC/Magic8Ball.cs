using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.UI.MVC
{
    class Magic8Ball
    {
        static void Main(string[] args)
        {
            /*
             * Requirements:
             * 1)Ask the user for their yes/no question
             * 2)Respond with a random answer from your set (collection)
             *of answers
             * 3) Set the program to loop based on user choice
             * set of answers be test values, or write a custom answer, google search 
             * for magic 8 ball answers
             */

            bool exit = false;//counter

            do
            {

                Console.WriteLine("Do you have a question you'd like answered? Y/N");
                ConsoleKey userChoice = Console.ReadKey().Key;
                Console.Clear();

                switch (userChoice)
                {
                    case ConsoleKey.Y:
                        Console.WriteLine("\nWhat question do you have? ");
                        Console.ReadLine();
                        RandomGeneration();
                        break;


                    case ConsoleKey.N:
                        Console.WriteLine("Thank you for playing!");
                        exit = true;
                        break;


                }

            } while (!exit);


        }//end Main

        private static void RandomGeneration()
        {

            string[] answers = new string[20];

            answers[0] = "As I see it, yes.";
            answers[1] = "Ask again later.";
            answers[2] = "Better not tell you now.";
            answers[3] = "Cannot predict now.";
            answers[4] = "Concentrate and ask again.";
            answers[5] = "Don't count on it.";
            answers[6] = "It is certain.";
            answers[7] = "It is decidely so.";
            answers[8] = "Most likely.";
            answers[9] = "My reply is no.";
            answers[10] = "My sources say no.";
            answers[11] = "Outlook not so good.";
            answers[12] = "Outlook good.";
            answers[13] = "Reply hazy, try again";
            answers[14] = "Signs point to yes.";
            answers[15] = "Very doubtful.";
            answers[16] = "Without a doubt.";
            answers[17] = "Yes.";
            answers[18] = "Yes - definitely.";
            answers[19] = "You may rely on it.";

            Random randomNbrGen = new Random();
            int randomNbr = randomNbrGen.Next(20);
            Console.WriteLine(answers[randomNbr]);
            
        }//end RandomGeneration()

    }//end class
}//end namespace