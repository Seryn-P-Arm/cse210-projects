// I added to the breaking activity an animation that will happen as you breathe in and out, it goes faster in and slower out.

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Menu options
            Console.Clear();
            Console.WriteLine("Mindfulness Programm");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            // End program if user quits
            string choice = Console.ReadLine();
            if (choice == "4") break;

            // Switch called activities depending on which activity user chooses
            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                _ => null
            };
            
            activity?.Start();
        }
    }
}