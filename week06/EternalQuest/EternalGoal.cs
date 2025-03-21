using System;

// Eternal Goal
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    // Record Event for Eternal goal for its separate scoring and completion symbol and saveformat
    public override void RecordEvent(ref int score) => score += _points;
    public override string GetDetails() => $"[∞] {_name} - {_description} (+{_points} pts each time)";
    public override string SaveFormat() => $"Eternal|{_name}|{_description}|{_points}";
}