using System;

public class Job
{
<<<<<<< HEAD
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
=======
    // Member variables
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Method to display job details
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
>>>>>>> 061298d6b7ae8d180143e7b7e35cc697f23694c9
