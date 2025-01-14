using System;
using System.Collections.Generic;

// Set class
public class Resume
{
    // Set new member variables
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Display function of resume with name and jobs together
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
        // iterate display of jobs
        foreach (Job j in _jobs)
        {
            j.Display();
        }
    }
}