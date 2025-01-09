using System;

class Program
{
    static void Main(string[] args)
    {
        // Write out iconic line using user's names into "Bond, James Bond"
        Console.Write("What is you first name? ");
        string fname = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lname = Console.ReadLine(); 

        Console.WriteLine("");
        Console.Write($"Your name is {lname}, {fname} {lname}.");
    }
}