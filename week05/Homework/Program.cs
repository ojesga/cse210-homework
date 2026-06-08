using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("          INHERITANCE: HOMEWORK MANAGER          ");
            Console.WriteLine("==================================================\n");

            // Test 1: Base Assignment Class
            Assignment baseAssignment = new Assignment("Samuel Bennett", "Multiplication");
            Console.WriteLine("--- Test 1: Base Assignment ---");
            Console.WriteLine(baseAssignment.GetSummary());
            Console.WriteLine();

            // Test 2: Derived Math Assignment Class
            MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
            Console.WriteLine("--- Test 2: Math Assignment ---");
            Console.WriteLine(mathAssignment.GetSummary());
            Console.WriteLine(mathAssignment.GetHomeworkList());
            Console.WriteLine();

            // Test 3: Derived Writing Assignment Class
            WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
            Console.WriteLine("--- Test 3: Writing Assignment ---");
            Console.WriteLine(writingAssignment.GetSummary());
            Console.WriteLine(writingAssignment.GetWritingInformation());

            Console.WriteLine("\n==================================================");
        }
    }
}