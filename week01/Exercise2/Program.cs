using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? "); // Use .Write so the user types on the same line
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Better luck next time! You did not pass the class.");
        }
    }
} 