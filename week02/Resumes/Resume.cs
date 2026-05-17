using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables (using the underscore convention)
    public string _name;
    public List<Job> _jobs = new List<Job>();
    // Method to display resume details in the required format
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        // Iterate through the list of jobs and call the Display method for each job
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}