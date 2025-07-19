using System;

class Program
{
    static void Main(string[] args)
    {
        // Added display scripture choice for user to select
        Console.WriteLine("Select a scripture to memorize:");
        Console.WriteLine("1. Proverbs 3:5-6");
        Console.WriteLine("2. John 3:16");
        Console.Write("Enter 1 or 2: ");

        // Read user select input
        string choice = Console.ReadLine();
        Scripture scripture;

        // Initialize user selected input
        if (choice == "1")
        {
            // Create reference and scripture from user selected input for Proverbs 3:5-6 
            Reference ref2 = new Reference("Proverbs", 3, 5, 6);
            string text2 = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways ackowledge him, and he shall direct thy paths.";
            scripture = new Scripture(ref2, text2);
        }
        else
        {
            // Added another create reference and scripture from user selected input for John 3:16
            Reference ref1 = new Reference("John", 3, 16);
            string text1 = "For God so loved the world that he gave his only begotten Son, that whomsoever believeth in him should not perish, but have everlasting life.";
            scripture = new Scripture(ref1, text1);
        }

        // Check if user chooses to quit
        bool userQuit = false;

        // Continued loop until selected scripture words are hidden or user quits
        while (!scripture.IsCompletelyHidden() && !userQuit)
        {
            // Clear and display current state of selected scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // Prompt user to continue or quit
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish");

            string input = Console.ReadLine();

            // Nomalize input
            if (input != null)
            {
                input = input.Trim().ToLower();
            }
            else
            {
                input = "";
            }

            // Check if user wants to quit
            if (input == "quit")
            {
                userQuit = true;
            }
            else
            {
                // Hide 3 random words in user selected scripture
                scripture.HideRandomWords(3);
            }
        }
        // Final display after loop ends
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        // Added output message based on user input and how the loop ended
        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nAll words are hidden. Program complete.");
        }
        else
        {
            Console.WriteLine("\nYou exited the program. Goodbye!");
        }

    }
}