using System;
using System.Collections.Generic;

// Journal class
public class Journal
{
    // List of entries
    private List<Entry> _entries;

    // create journal with entries
    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // display journal empty and all entries when not empty
    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
            return;
        }

        Console.WriteLine("Journal Entries:");
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    // Save journal to a file
    public void SaveToFile(string filename)
    {
        Save.ToFile(filename, _entries);
    }

    // Load journal from file
    public void LoadFromFile(string filename)
    {
        _entries = Load.FromFile(filename);
    }
}