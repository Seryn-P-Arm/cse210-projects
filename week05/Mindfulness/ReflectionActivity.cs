using System;
using System.Collections.Generic;

// Reflection Activity
public class ReflectionActivity : Activity{
    // Lists of prompts and questions to reflect on
    private static List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    
    public ReflectionActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on your strengths.";
    }

    // Run activity, random prompt and question
    protected override void Run()
    {
        Random random = new Random();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.Write(" --- ");
        Console.Write(_prompts[random.Next(_prompts.Count)]);
        Console.WriteLine(" --- ");

        // Prompt user to press Enter to continue when ready
        Console.Write("\nPonder on each of the following questions as they relate to this experience, then press Enter when you are ready to proceed...");
        Console.ReadLine();
        Console.Clear();

        char[] spinnerChars = GetSpinnerChars();

        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            string question = _questions[random.Next(_questions.Count)];
            Console.Write(" > " + question + " ");

            ShowSpinner(6);

            elapsedTime += 6;
            Console.WriteLine();
        }
    }
}
