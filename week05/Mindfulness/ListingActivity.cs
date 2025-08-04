using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    // List of prompts for user reflection
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are the personal strength of yours?",
        "Who are people you helped this week?",
        "When have you felt spiritual peace recently?",
        "Who are some of your personal heroes?"
    };

    // Random object for selecting prompts randomly
    private Random _rand = new Random();

     // Constructor that passes activity name and description to the base Activity class
    public ListingActivity()
    : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    // The main logic for the activity
    public override void Run()
    {
        DisplayStartingMessage(); // Shows intro message and asks user for duration

        string prompt = GetRandomPrompt(); // Select a random prompt
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---"); // Display the prompt to the user

        Console.Write("You may begin in:");
        ShowCountDown(5); // Give the user a few seconds to prepare

        List<string> items = GetListFromUser(); // Collect user input during the timed session

        // Display the total number of items listed
        Console.WriteLine($"You listed {items.Count} items!");
        DisplayEndingMessage(); // Show closing/encouragement message
    }
    // Selects and returns a random prompt from the _prompts list
    public string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }

    // Collects user responses during the specified duration
    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Console.WriteLine("Start listing. Press Enter after each item:");

        // Keep collecting responses until time runs out
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            responses.Add(input);
        }
        return responses; // Return the collected list
    } 
}