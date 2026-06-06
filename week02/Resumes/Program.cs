using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create the first job instance
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "ABC Company";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // 2. Create the second job instance
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // 3. Create a resume instance and set the name
        Resume resume = new Resume();
        resume._name = "Allison Rose";

        // 4. Add the job instances to the resume's list of jobs
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // 5. Call the display method on the resume object
        // This will cleanly handle printing the name and iterating through all jobs.
        resume.Display();

    }
}