using System;

// Simple Goal
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    // Record Event to Simple Goal and override point scores and completion with x symbol
    public override void RecordEvent(ref int score)
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            score += _points;
        }
    }

    // Details of listed simple goal
    public override string GetDetails() => $"[{(_isCompleted ? "X" : " ")}] {_name} - {_description} ({_points} pts)";
    public override string SaveFormat() => $"Simple|{_name}|{_description}|{_points}|{_isCompleted}";
}