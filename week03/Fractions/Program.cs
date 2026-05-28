using System;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- Verification 1: Test all Constructors ---
            Fraction f1 = new Fraction();          // 1/1
            Fraction f2 = new Fraction(6);         // 6/1
            Fraction f3 = new Fraction(6, 7);      // 6/7

            Console.WriteLine("--- Constructor Verification ---");
            Console.WriteLine(f1.GetFractionString());
            Console.WriteLine(f2.GetFractionString());
            Console.WriteLine(f3.GetFractionString());
            Console.WriteLine();

            // --- Verification 2: Test Getters and Setters ---
            Console.WriteLine("--- Getters/Setters Verification ---");
            Fraction testFraction = new Fraction();
            testFraction.Top = f2.Top;         // Using setter & getter
            testFraction.Bottom = f3.Bottom;   // Using setter & getter
            Console.WriteLine($"New top: {testFraction.Top}, New bottom: {testFraction.Bottom}");
            Console.WriteLine($"Result: {testFraction.GetFractionString()}");
            Console.WriteLine();

            // --- Verification 3: Match Sample Output ---
            Console.WriteLine("--- Final Sample Output Verification ---");
            
            // Case 1: Default (1)
            Fraction case1 = new Fraction();
            Console.WriteLine(case1.GetFractionString());
            Console.WriteLine(case1.GetDecimalValue());

            // Case 2: Top only (5)
            Fraction case2 = new Fraction(5);
            Console.WriteLine(case2.GetFractionString());
            Console.WriteLine(case2.GetDecimalValue());

            // Case 3: 3/4
            Fraction case3 = new Fraction(3, 4);
            Console.WriteLine(case3.GetFractionString());
            Console.WriteLine(case3.GetDecimalValue());

            // Case 4: 1/3
            Fraction case4 = new Fraction(1, 3);
            Console.WriteLine(case4.GetFractionString());
            Console.WriteLine(case4.GetDecimalValue());
        }
    }
}