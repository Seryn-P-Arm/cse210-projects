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
        // Automatically load goals from file
        // Menu
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

    // Create a goal
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

    // Record event to complete goal
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

    // List of created goals and saved goals from loaded file
    private void ListGoals(bool pause = true)
    {
        Console.Clear();
        if (_goals.Count == 0) Console.WriteLine("No goals available.");
        else for (int i = 0; i < _goals.Count; i++) Console.WriteLine($"[{i + 1}] {_goals[i].GetDetails()}");
        if (pause) { Console.WriteLine("\nPress Enter to return to the menu..."); Console.ReadLine(); }
    }

    // Save goals to file
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

    // Load goals from file
    private void LoadGoals()
    {
         if (!File.Exists("goals.txt")) return;

        string[] lines = File.ReadAllLines("goals.txt");
        _goals.Clear(); // Clear existing goals before loading new ones
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            // Switch between cases of goal types
            switch (type)
            {
                case "Simple":
                    bool isCompleted = bool.Parse(parts[4]);
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    simpleGoal.SetCompleted(isCompleted);
                    _goals.Add(simpleGoal);
                    break;
                case "Eternal":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "Checklist":
                    int target = int.Parse(parts[4]);
                    int completed = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    checklistGoal.SetCompleted(completed == target);
                    _goals.Add(checklistGoal);
                    break;
            }
        }

        // Display succesful load message
        Console.WriteLine("Goals loaded successfully! Press Enter to continue...");
        Console.ReadLine();
    }
}
