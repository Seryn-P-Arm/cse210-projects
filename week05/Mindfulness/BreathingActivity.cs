using System;

// Breathing Activity
public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by guiding your breathing. Clear your mind and focus on your breathing.";
    }

    // Breathe in and out animations and time elapse
    protected override void Run()
    {
        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            AnimateBreath("Breathe in...", 3, true);
            AnimateBreath("Breathe out...", 5, false);
            elapsedTime += 8;
        }
    }

    // Animate breath wihtin duration
    private void AnimateBreath(string message, int duration, bool isInhaling)
    {
        Console.Clear();
        Console.WriteLine(message);

        int steps = 10;
        int baseDelay = duration * 1000 / steps;

        for (int i = 1; i <= steps; i++)
        {
            int adjustedDelay = baseDelay + (isInhaling ? i * 5 : (steps - i) * 5);
            Console.Write("\r" + new string('█', i) + new string(' ', steps - 1));
            Thread.Sleep(adjustedDelay);
        }
        Console.WriteLine();
    }
}