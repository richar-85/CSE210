using System;
using System.Collections.Generic;

// Journal application main entry point
class Program
{
    static void Main(string[] args)
    {
        // Create journal and prompt generator
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool open = true;

        Console.WriteLine("Welcome to the Journal program!");

        // Using dictionary to define menu actions
        var menuActions = new Dictionary<string, Action>
        {
            { "1", () => WriteEntry(journal, promptGenerator) },
            {"2", journal.DisplayAll },
            {"3", () => LoadJournal(journal) },
            {"4", () => SaveJournal(journal) },
            {"5", () => {open = false;  Console.WriteLine("Thanks for writing on your journal today, Goodbye!"); }}
        };

        // Program loop
        while (open)
        {
            // Menu that gives user choices to choose from
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();
            
            // Carry out menu actions if user input is valid 
            if (menuActions.ContainsKey(choice))
            {
                menuActions[choice].Invoke();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 5. \n");
            }
        }
    }

    // Allows user to write a new journal entry
    static void WriteEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string _prompts = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"{_prompts}");
        //Console.WriteLine($"Prompt: {_prompts}");
        Console.Write("> ");
        //Console.WriteLine("Your response: ");
        string _entryText = Console.ReadLine();
        Entry entry = new Entry(_prompts, _entryText);
        journal.AddEntry(entry);
        Console.WriteLine("Entry added!\n");

    }

    // Loads journal entry from user saved file
    static void LoadJournal(Journal journal)
    {
        Console.Write("What is the filename? ");
        string file = Console.ReadLine();
        journal.LoadFromFile(file);
    }

    // Saves journal entry to user created file
    static void SaveJournal(Journal journal)
    {
        Console.Write("What is the filename? ");
        string file = Console.ReadLine();
        journal.SaveToFile(file);
    }
}