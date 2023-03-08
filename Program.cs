using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the guessing game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100...");
            Console.WriteLine("Can you guess what it is?");

            // Generate a random number between 1 and 100
            Random random = new Random();
            int number = random.Next(1, 101);

            // Keep track of the number of guesses
            int guessCount = 0;

            // Loop until the player guesses correctly
            while (true)
            {
                // Prompt the player to enter a guess
                Console.Write("Enter your guess: ");
                string guessString = Console.ReadLine()!;

                // Convert the guess to an integer
                int guess;
                bool isValidGuess = int.TryParse(guessString, out guess);

                if (!isValidGuess)
                {
                    Console.WriteLine("That's not a valid guess! Please enter a number.");
                    continue;
                }

                // Increment the guess count
                guessCount++;

                // Check if the guess is correct
                if (guess == number)
                {
                    Console.WriteLine($"Congratulations, you guessed the number in {guessCount} tries!");
                    break;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Your guess is too low. Try again!");
                }
                else
                {
                    Console.WriteLine("Your guess is too high. Try again!");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
