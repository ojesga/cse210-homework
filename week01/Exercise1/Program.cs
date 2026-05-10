using System;

class Program
{    static void Main(string[] args)
   
    {
        // Ask the user for their first name and last name, then display them in the format: "Your name is: last, first last"
        Console.Write("what is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.Write($"Your name is {last}, {first} {last}");
        string fullName = $"{last}, {first} {last}";
    }
}