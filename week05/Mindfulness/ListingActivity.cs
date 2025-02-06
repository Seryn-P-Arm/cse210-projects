using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Transactions;

// Listing Activity
public class ListingActivity : Activity
{
    // List of prompts to make list
    private static List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you list things you are grateful for.";
    }

    // Run activity and random prompt for user, add responses to an empty list then display number of total listed items
    protected override void Run()
    {
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        ShowCountdown(5);

        List<string> _responses = new List<string>();
        int elapsedTime = 0;

        while (elapsedTime < _duration)
        {
            Console.Write("Enter an item: ");
            _responses.Add(Console.ReadLine());
            elapsedTime += 3;
        }
        Console.WriteLine($"You listed {_responses.Count} items!");
    }
}