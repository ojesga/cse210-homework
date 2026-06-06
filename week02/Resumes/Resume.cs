using System;
using System.Collections.Generic;

public class Resume
{
<<<<<<< HEAD
    // Member variables (using the underscore convention)
    public string _name;
    public List<Job> _jobs = new List<Job>();
    // Method to display resume details in the required format
=======
    public string _name;

    // Initialize the list immediately to avoid "Null Reference" errors
    public List<Job> _jobs = new List<Job>();

>>>>>>> 061298d6b7ae8d180143e7b7e35cc697f23694c9
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
<<<<<<< HEAD
        // Iterate through the list of jobs and call the Display method for each job
=======

        // Iterate through the list and call the Display method on each job
>>>>>>> 061298d6b7ae8d180143e7b7e35cc697f23694c9
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}