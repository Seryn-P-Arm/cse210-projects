using System;
using System.Collections.Generic;
using System.IO;

// Base Class for Goals
public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    public string GetName() => _name;
    public int GetPoints() => _points;
    public abstract void RecordEvent(ref int score);
    public abstract string GetDetails();
    public abstract string SaveFormat();
}
