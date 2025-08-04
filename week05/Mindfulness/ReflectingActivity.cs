using System;
using System.Collections.Generic;
using System.Linq;

public class ReflectingActivity : Activity
{
    // List of prompts to get the user thinking about meaningful experiences
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you were selfless."
    };

     // List of questions to help the user reflect deeper on the chosen experience
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful?",
        "Have you done something like this before?",
        "How did you get started?",
        "How did you feel when it was done?",
        "What did you learn from it?",
        "What makes it stand out from other times?",
        "What will you do differently now?",
        "How can you apply this in the future?"
    };

    // Random generator to pick prompts/questions randomly
    private Random _rand = new Random();

    // Constructor that sets the name and description of this activity
    public ReflectingActivity()
    : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    // Main method that runs the reflecting activity logic
    public override void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write($"You may begin in: ");
        ShowCountDown(5);

        DisplayQuestions();

        DisplayEndingMessage();
    }

    // Displays a random prompt from the list of prompts
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine($" --- {prompt} ---");
    }

    // Displays reflection questions one by one until time runs out or questions finish
    public void DisplayQuestions()
    {
        DateTime end = DateTime.Now.AddSeconds(_duration);
        List<string> random = _questions.OrderBy(q => _rand.Next()).ToList();
        int i = 0;

        while (DateTime.Now < end && i < random.Count)
        {
            string question = random[i];
            Console.WriteLine();
            Console.Write($"> {question} ");
            ShowSpinner(5);
            i++;
        }
        Console.WriteLine();
    }

    // Returns a random prompt string from the _prompts list
    public string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }

    // Returns a random question string from the _questions list (not used in Run, but available)
    public string GetRandomQuestion()
    {
        return _questions[_rand.Next(_questions.Count)];
    }
}