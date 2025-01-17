using System;
using System.IO;
using System.Collections.Generic;

// Save class
public class Save
{
    // Streamwriter and write filename and content matches to file
    public static void ToFile(string filename, List<Entry> entries)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"Date: {entry._date}");
                    writer.WriteLine($"Prompt: {entry._prompt}");
                    writer.WriteLine($"Entry: {entry._content}");
                    writer.WriteLine(new string('-', 50));  // Separator between entries
                }
            }
            Console.WriteLine($"Journal successfully saved to {filename}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }
}