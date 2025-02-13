using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

// Goal Manager
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        LoadGoals();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Eternal Quest System ===");
            Console.WriteLine($"Score: {_score}\n");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. List Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit\n");
            Console.Write("> Select an option: ");

            switch (Console.ReadLine())
            {
                case "1": CreateGoal(); break;
                case "2": RecordEvent(); break;
                case "3": ListGoals(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": SaveGoals(); return;
                default: Console.WriteLine("Invalid option. Press Enter to continue..."); Console.ReadLine(); break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Create a Goal\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n");
        Console.Write("> Enter goal type: ");
        string type = Console.ReadLine();
        Console.Write("> Name: ");
        string name = Console.ReadLine();
        Console.Write("> Description: ");
        string desc = Console.ReadLine();
        Console.Write("> Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1": _goals.Add(new SimpleGoal(name, desc, points)); break;
            case "2": _goals.Add(new EternalGoal(name, desc, points)); break;
            case "3":
                Console.Write("> Target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("> Bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
            default: Console.WriteLine("Invalid selection."); return;
        }
        Console.WriteLine("Goal created! Press Enter to continue...");
        Console.ReadLine();
    }

    private void RecordEvent()
    {
        Console.Clear();
        ListGoals(false);
        Console.Write("\n> Select goal to record: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= _goals.Count)
        {
            _goals[index - 1].RecordEvent(ref _score);
            Console.WriteLine("Event recorded! Press Enter to continue...");
        }
        else
        {
            Console.WriteLine("Invalid selection. Press Enter to continue...");
        }
        Console.ReadLine();
    }

    private void ListGoals(bool pause = true)
    {
        Console.Clear();
        if (_goals.Count == 0) Console.WriteLine("No goals available.");
        else for (int i = 0; i < _goals.Count; i++) Console.WriteLine($"[{i + 1}] {_goals[i].GetDetails()}");
        if (pause) { Console.WriteLine("\nPress Enter to return to the menu..."); Console.ReadLine(); }
    }

    private void SaveGoals()
    {
        using (StreamWriter file = new StreamWriter("goals.txt"))
        {
            file.WriteLine(_score);
            foreach (Goal goal in _goals) file.WriteLine(goal.SaveFormat());
        }
        Console.WriteLine("Goals saved successfully! Press Enter to continue...");
        Console.ReadLine();
    }

    private void LoadGoals()
    {
        if (!File.Exists("goals.txt")) return;
        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);
        _goals.Clear();
        Console.WriteLine("Goals loaded successfully! Press Enter to continue...");
        Console.ReadLine();
    }
}
