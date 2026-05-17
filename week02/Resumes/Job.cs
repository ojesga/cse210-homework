using System;

public class Job
{
    // Member variables (using the underscore convention)
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    // Method to display job details in the required format
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} at {_company} ({_startYear} - {_endYear})");
    }   
}
