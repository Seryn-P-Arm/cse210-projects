using System;

// Checklist Goal
public class ChecklistGoal : Goal
{
    private int _target;
    private int _completed;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _completed = 0;
        _bonus = bonus;
    }

    public override void RecordEvent(ref int score)
    {
        if (_completed < _target)
        {
            _completed++;
            score += _points;
            if (_completed == _target)
            {
                score += _bonus;
                _isCompleted = true;
            }
        }
    }
    public override string GetDetails() => $"[{(_isCompleted ? "X" : " ")}] {_name} - {_description} ({_completed}/{_target} completed, {_points} pts each, {_bonus} pts bonus)";
    public override string SaveFormat() => $"Checklist|{_name}|{_description}|{_points}|{_target}|{_completed}|{_bonus}";
}