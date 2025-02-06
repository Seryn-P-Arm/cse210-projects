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
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("Enter how long you would like your session (in seconds): ");
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
        List<string> animationStrings = new List<string>
        {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\",
            "|"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]); // Print spinner
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i); // Display countdown number
            Thread.Sleep(1000); // Wait 1 second
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}
