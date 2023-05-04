using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the guessing game!");
            Console.WriteLine("Guess a number between 1 and 10:");
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int guesses = 0;
            bool correctGuess = false;

            while (!correctGuess && guesses < 3)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                guesses++;

                if (guess == randomNumber)
                {
                    correctGuess = true;
                    Console.WriteLine("Congratulations! You guessed the number in " + guesses + " guesses.");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Too low! Guess again:");
                }
                else
                {
                    Console.WriteLine("Too high! Guess again:");
                }
            }

            if (!correctGuess)
            {
                Console.WriteLine("Sorry, you didn't guess the number. The number was " + randomNumber + ".");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
