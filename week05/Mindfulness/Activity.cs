using System;
using System.Threading;

// Base Class
public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    // Start program with start message and description as well as prompting duration in seconds from user
    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"{_name} Activity");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("Invalid input. Enter a positive number: ");
        }
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
        Run();
        End();
    }

    protected abstract void Run();

    // End message of each activity
    protected void End()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.WriteLine(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
