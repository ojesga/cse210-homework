using System;

class Program
{
    static void Main(string[] args)
    {
        //for parts 1 nad 2, where the user specified the number...
        //Console.Write("what is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        // for Part 3, where the number is generated randomly...
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101); // generates a number between 1 and 100

        int guess = -1; // initialize guess to an invalid number

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess )
            {
                Console.WriteLine("Higher! Try again.");
            }
            else if (magicNumber < guess)   
            {
                Console.WriteLine("Lower! Try again.");

            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number!");
            }

        }
    }   
}
    
