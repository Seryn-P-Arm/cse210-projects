using System;

// Entry class
public class Entry
{
    // Get prompt, content and date
    public string _prompt {get; set;}
    public string _content {get; set;}
    public DateTime _date {get; set;}

    // Store in variables
    public Entry(string prompt, string content)
    {
        _content = content;
        _date = DateTime.Now;
        _prompt = prompt ?? "No Prompt";
    }

    // Format display of individual entries
    public void Display()
    {
        Console.WriteLine(new string('-', 50));
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_content}");
        Console.WriteLine(new string('-', 50));
    }
}