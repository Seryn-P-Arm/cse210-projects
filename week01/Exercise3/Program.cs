using System;

class Program
{
    static void Main(string[] args)
    {

        int guessNumber;
        string response;

        // Determine match and loop it until guess is correct
        do
        {
            // Get user magic number and guess and convert input to int
            Random randomMagicNumber = new Random();
            int magicNumber = randomMagicNumber.Next(1, 101);

            int guess = 0;

            do
            {
                Console.Write("What is your guess? ");
                string userGuessNumber = Console.ReadLine();
                guessNumber = int.Parse(userGuessNumber);

                guess+=1;

                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You have made {guess} guesses.");
                }
            } while (guessNumber != magicNumber);

            // Play in a loop as long as the response is yes
            Console.WriteLine("");
            Console.Write("Would you like to play again (yes or no)? ");
            response = Console.ReadLine().ToLower();

        } while (response == "yes");

        Console.WriteLine("");
        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}