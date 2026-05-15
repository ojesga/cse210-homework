using System;
using System.Collections.Generic;

public class Resume
{
    public string _name;

    // Initialize the list immediately to avoid "Null Reference" errors
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Iterate through the list and call the Display method on each job
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}