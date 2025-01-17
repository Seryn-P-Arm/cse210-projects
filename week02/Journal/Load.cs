using System;
using System.IO;
using System.Collections.Generic;

// Load class
public class Load
{
    // Load filename if exists
    public static List<Entry> FromFile(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine($"File {filename} does not exist.");
                return new List<Entry>();  // Return an empty list if the file doesn't exist.
            }

            List<Entry> entries = new List<Entry>();
            string[] lines = File.ReadAllLines(filename);
            Entry currentEntry = null;

            foreach (var line in lines)
            {
                if (line.StartsWith("Date:"))
                {
                    // If we encounter a new date line, start a new entry
                    if (currentEntry != null)
                    {
                        entries.Add(currentEntry);
                    }

                    currentEntry = new Entry(string.Empty, string.Empty);  // Create a new Entry
                    currentEntry._date = DateTime.Parse(line.Substring(6));  // Extract date
                }
                else if (line.StartsWith("Prompt:") && currentEntry != null)
                {
                    currentEntry._prompt = line.Substring(8).Trim();  // Extract prompt
                }
                else if (line.StartsWith("Entry:") && currentEntry != null)
                {
                    currentEntry._content = line.Substring(7).Trim();  // Extract content
                }
                else if (string.IsNullOrWhiteSpace(line) && currentEntry != null)
                {
                    // Empty line marks the end of an entry
                    entries.Add(currentEntry);
                    currentEntry = null;
                }
            }

            // Add the last entry if any
            if (currentEntry != null)
            {
                entries.Add(currentEntry);
            }

            Console.WriteLine($"Journal successfully loaded from {filename}.");
            return entries;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
            return new List<Entry>();  // Return an empty list on error.
        }
    }
}