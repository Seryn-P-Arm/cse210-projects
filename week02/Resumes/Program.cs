using System;

class Program
{
    static void Main(string[] args)
    {
        // Set new Job instances
        Job job1 = new Job();

        job1._company = "Backspace Techologies(Pty) Ltd";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2025;
        job1._endYear = 2055;

        Job job2 = new Job();

        job2._company = "Lanline Technologies(Pty) Ltd";
        job2._jobTitle = "Customer Service";
        job2._startYear = 2026;
        job2._endYear = 2046;

        // Set new Resume instance
        Resume resume = new Resume();

        // Add to Resume list
        resume._name = "Mary Joanne";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // Display resume
        resume.Display();
    }
}