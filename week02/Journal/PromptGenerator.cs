using System;
using System.Collections.Generic;

// Prompt generator class
public class PromptGenerator
{
    // Store prompts in list
    private List<string> _prompts;

    // List of prompts
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What is something you are grateful for today?",
            "Describe a moment that made you smile recently.",
            "Write about a challenge you overcame and how it made you feel.",
            "What are three goals you want to accomplish this week?",
            "Reflect on a recent conversation that impacted you.",
            "Describe a place that makes you feel at peace.",
            "What does success mean to you?",
            "Who is someone you admire and why?",
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    // Random prompt and return
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
