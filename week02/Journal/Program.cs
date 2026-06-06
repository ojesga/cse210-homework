using System;
using System.Collections.Generic;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserJournal myJournal = new UserJournal();
            
            // List of at least 5 creative prompts
            List<string> prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "What is something new you learned or realized today?",
                "Describe a small detail from today that made you smile."
            };

            Random randomGenerator = new Random();
            string choice = "";

            Console.WriteLine("Welcome to the Journal Program!");

            while (choice != "5")
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Select a random prompt from the list
                    int index = randomGenerator.Next(prompts.Count);
                    string selectedPrompt = prompts[index];

                    Console.WriteLine($"\nPrompt: {selectedPrompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    // Exceeding Requirements feature: Mood Tracking
                    Console.Write("Rate your day's mood (1-5): ");
                    string mood = Console.ReadLine();

                    // Capture the current system date cleanly as a string
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();

                    // Abstract data containment into a new Entry object
                    Entry newEntry = new Entry();
                    newEntry._date = dateText;
                    newEntry._promptText = $"{selectedPrompt} [Mood: {mood}/5]";
                    newEntry._entryText = response;

                    myJournal.AddEntry(newEntry);
                    Console.WriteLine("Entry recorded.\n");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("\n--- Journal Entries ---");
                    myJournal.DisplayAll();
                }
                else if (choice == "3")
                {
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();
                    myJournal.LoadFromFile(filename);
                }
                else if (choice == "4")
                {
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();
                    myJournal.SaveToFile(filename);
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please choose a number from 1 to 5.\n");
                }
            }
        }
    }
}