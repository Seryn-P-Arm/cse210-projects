using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcome message
        DisplayWelcome();

        // Get name and number
        string name = PromptUserName();
        int number = PromptUserNumber();

        // Calculate squared number
        int squaredNumber = SquareNumber(number);

        // Display results
        DisplayResult(name, squaredNumber);

        // Display welcome function
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // Promtp user's name and return
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            return userName;
        }

        // Prompt user number and return
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());

            return userNumber;
        }
        
        // Calculate the square of the given number and return
        static int SquareNumber(int userNumber)
        { 
            int squareNum = userNumber * userNumber;

            return squareNum;
        }

        // Display the reults with name and square
        static void DisplayResult(string userName, int squareNum)
        {
            Console.WriteLine($"{userName}, the square of your number is {squareNum}");
        }

    }
}