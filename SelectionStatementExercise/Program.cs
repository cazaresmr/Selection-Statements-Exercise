using System;

namespace GuessFavoriteNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1001);

            Console.WriteLine("Guess my favorite number between 1 and 1000:");

            while (true)
            {
                Console.Write("Enter your guess: ");
                int userInput;
                bool isValidInput = int.TryParse(Console.ReadLine(), out userInput);

                if (!isValidInput)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 1000.");
                    continue;
                }

                if (userInput < 1 || userInput > 1000)
                {
                    Console.WriteLine("Please enter a number within the range 1 to 1000.");
                    continue;
                }

                if (userInput < favNumber)
                {
                    Console.WriteLine("Too low.");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too high.");
                }
                else
                {
                    Console.WriteLine("You guessed it!!!");
                    break;
                }
            }
        }
    }
}
