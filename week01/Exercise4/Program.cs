using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Create new empty int list
        List<int> numbers = new List<int>();

        // Variables store
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        int sumTotal = 0;
        int largestNumber = 0;
        int smallestPosNumber = 9999999;

        // Loop through entering the numbers and calculations and add numbers to list
        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number > largestNumber)
            {
                largestNumber = number;
            }

            if (number != 0)
            {
                numbers.Add(number);

                number = sumTotal + number;
                sumTotal = number;
            }
        } while (number != 0);

        // iterate through list and determine the smallest positive number
        foreach (int num in numbers)
        {
            if (num > 0)
            {
                if (num < smallestPosNumber)
                {
                    smallestPosNumber = num;
                }
            }
            else
            {
                continue;
            }
        }

        // Calculate average
        int numCount = numbers.Count;
        double average = (double)sumTotal / numCount;
        // Sort list
        numbers.Sort();       

        // Results
        Console.WriteLine($"The sum is: {sumTotal}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPosNumber}");
        Console.WriteLine("The sorted list is:");
        // Iterate sorted list
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}