using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Get grade percentage from user and convert to int
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        // Store letter variable
        string letter = "";

        // Determine grade letter
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Sign variable
        string sign;

        // Determine sign first for non-F grades and then specifically for F grades
        if (letter != "F")
        {
            int lastDigit = grade % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit <= 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else
        {
            if (grade >= 50)
            {
                sign = "+";
            }
            else if (grade < 40)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }

        // Print the letter and sign
        Console.WriteLine($"{letter}{sign}");

        // Determine Pass or Fail based on grade and print results
        if (grade >= 70)
        {
            Console.Write("You Passed! Congratulations!");
        }
        else
        {
            Console.Write("Fail... You have infinite potential. This isn't the end!");
        }
    }
}