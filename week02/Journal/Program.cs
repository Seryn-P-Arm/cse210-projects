using System;
using System.Diagnostics;

// Main program
/* I added an extra option to enter an entry without needing a prompt if the user has an idea already.
    They can generate a prompt when they really need help for a new entry.
    And I created a design for the journal entries when displayed wih a dotted line to separate the entries.
    File classes: Promgram.cs, PromptGenerator.cs, Entry.cs, Journal.cs, Save.cs, and Load.cs
*/
class Program
{
    static void Main(string[] args)
    {
        // Call Journal class with member variables
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        // Welcome
        Console.WriteLine("\nWelcome to the Journal Program!");

        // Options
        while (true)
        {
            Console.WriteLine("\nPlease select an option: ");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Generate Prompt");
            Console.WriteLine("3. Display Journal");
            Console.WriteLine("4. Load Journal from File");
            Console.WriteLine("5. Save Journal to File");
            Console.WriteLine("6. Quit");
            Console.Write("Enter the number of your choice: ");

            string choice = Console.ReadLine();

            // Switch choices and enter entries, save to file and load from file and quit
            switch (choice)
            {
                // New Entry
                case "1":
                    Console.Write("Enter a journal entry: ");
                    string content = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(content))
                    {
                        Entry newEntry = new Entry(null, content);
                        journal.AddEntry(newEntry);
                        Console.WriteLine("~~Entry added to your journal!~~");
                    }
                    else
                    {
                        Console.WriteLine("~~Empty entry. Not added.~~");
                    }
                    break;

                // Generate random prompt
                case "2":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(response))
                    {
                        Entry generatedEntry = new Entry(prompt, response);
                        journal.AddEntry(generatedEntry);
                        Console.WriteLine("~~Entry added to your journal!~~");
                    }
                    else
                    {
                        Console.WriteLine("~~Empty response. Not added.~~");
                    }
                    break;

                // Display Journal
                case "3":
                    journal.Display();
                    break;

                // Load file
                case "4":
                    Console.Write("Enter the filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;

                // Save to file
                case "5":
                    Console.Write("Enter the filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;

                // Exit program
                case "6":
                    Console.WriteLine("~~Goodbye!~~");
                    return;

                // If input does not match with given options
                default:
                    Console.WriteLine("~~Invalid choice. Please try again.~~");
                    break;
            }
        }
    }
}