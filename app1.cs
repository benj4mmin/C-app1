using System;

// Namespace
namespace NumberGuessingGame
{
    //Main class
    class Program
    {
        //entry point method
        static void Main(string[] args)
        {
            GetAppInfo(); //shows app info

            GreetUser(); //asks for users name then greets


            //while still playing
            while (true)
            {

                //create random object
                Random random = new Random();

                int correctNumber = Random.Next(1, 100);

                //Init guess variable
                int guess = 0;

                //ask user for a number
                Console.WriteLine("Guess a number between 1 and 100");

                //validate user input is a number and within params
                //if statement for validation response
                //Get users input
                string input = Console.ReadLine();
                if (!int.TryParse(input, out guess))
                {
                    //print validity response with function
                    PrintColorMessage(ConsoleColor.DarkRed, "Invalid response, try again with a number between 1 and 100!");
                }

                //while number is incorrect
                while (NumberGuessingGame != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();

                    //cast to int and put in guess
                    guess = int.Parse(input);

                    //match guess
                    if (NumberGuessingGame != correctNumber)
                    {
                        //print failure response with function
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, try again!");
                    }
                    //print winner response with function
                    PrintColorMessage(ConsoleColor.Blue, "You are correct!");

                    //ask to play again
                    Console.WriteLine("Play again? [Y or N]");

                    //get answer
                    string answer = Console.ReadLine().ToUpper();

                    if (answer == "Y")
                    {
                        continue;
                    }
                    else if (answer == "N")
                    {
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }

            // function for app info display
            static void GetAppInfo() {
                //Set app variables
                string appName = "Number Guessing Game";
                string appVersion = "1.0.0";
                string appAuthor = "Ben Street Yurchison";

                //Change text color
                Console.ForegroundColor = ConsoleColor.Green;

                //Write app info
                Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            }

            //greet user and ask name function
            static void GreetUser() {
                
                //Ask users name
                Console.WriteLine("What is your name?");

                //Get user input
                string inputName = Console.ReadLine();

                Console.WriteLine("Hello {0}, lets guess some numbers", inputName);
            }

            //print color message
            static void PrintColorMessage(ConsoleColor color, string message) {
                //Change text color
                Console.ForegroundColor = color;

                //tell user this isnt a valid response
                Console.WriteLine(message);

                //Reset text color
                Console.ResetColor();
            }
        }             
}