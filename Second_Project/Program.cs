using System;

namespace Second_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); // Retrieve App Info

            UserGreeting(); //User Greeting Info

            while (true)
            {
                // Create new random object

                Random random = new Random();

                // Request guess input
                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10?");

                // Incorrect guess
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        // Set text color
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        // Output 
                        Console.WriteLine("Please input an actual number!");

                        // Clear color attribute
                        Console.ResetColor();

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        // Set text color
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        // Output 
                        Console.WriteLine("Incorrect - Try again!");

                        // Clear color attribute
                        Console.ResetColor();

                    }
                }

                // Correct guess

                // Set text color
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                // Output 
                Console.WriteLine("Correct!");

                // Clear color attribute
                Console.ResetColor();

                // Play again?
                Console.WriteLine("Play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
               
            }
        }

        static void GetAppInfo() {
            
            // Set App Varialbes
            string appName = "Number Guesser";
            string appVersion = "1.0.1";
            string appAuthor = "PatMan";

            // Set text color
            Console.ForegroundColor = ConsoleColor.Blue;

            // Output 
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Clear color attribute
            Console.ResetColor();

        }

        static void UserGreeting() {
            
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hi {0}, Let's play a game!", inputName);

        }
    }
}