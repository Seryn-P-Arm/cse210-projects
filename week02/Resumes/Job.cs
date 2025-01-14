using System;

// Set class Job
public class Job
{
    // Set member variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Display function of Jobs
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}