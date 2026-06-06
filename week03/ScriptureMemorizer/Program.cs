using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    class Program
    {
        /* CREATIVITY & EXCEEDING REQUIREMENTS SHOWCASE:
          1. Library Storage: Instead of hardcoding a single scripture, this program hosts a list
             dictionary/library of scriptures. It selects one completely at random upon startup.
          2. Intelligent Word Erasure: Modified HideRandomWords() to dynamically find only words
             that remain visible. The program avoids re-selecting already hidden words, preventing
             dead loops at the end of the activity.
        */
        static void Main(string[] args)
        {
            // Setup a list of available scriptures to fulfill the library feature
            List<Scripture> scriptureLibrary = new List<Scripture>()
            {
                new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only Son that whoever believes in him should not perish but have eternal life"),
                new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding in all your ways acknowledge him and he will make straight your paths"),
                new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me"),
                new Scripture(new Reference("Joshua", 1, 9), "Have I not commanded you Be strong and courageous Do not be afraid do not be discouraged for the Lord your God will be with you wherever you go")
            };

            // Choose a scripture randomly from the list
            Random random = new Random();
            Scripture currentScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

            // Standard runtime loop
            while (true)
            {
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText());
                Console.WriteLine();

                // Stop iterating immediately if all words are successfully covered up
                if (currentScripture.IsCompletelyHidden())
                {
                    Console.WriteLine("Congratulations! You have completely hidden the passage!");
                    break;
                }

                Console.WriteLine("Press Enter to hide words, or type 'quit' to close the program:");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                // Hide 3 words per prompt cycle
                currentScripture.HideRandomWords(3);
            }
        }
    }
}