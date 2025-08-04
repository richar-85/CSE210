using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

// class for all activities
public class Activity
{
    // Private fields to store activity name, description, and duration in seconds
    private string _name;
    private string _description;
    protected int _duration;

    // Constructor initializes the activity with a name and description
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Displays the starting message, prompts user for duration, and shows a get-ready spinner
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();

        // Validate input until user enters a valid positive number
        while (!IsValidNumber(input))
        {
            Console.Write("Please enter a valid positive number: ");
            input = Console.ReadLine();
        }
        _duration = int.Parse(input);

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    // Displays an ending message with encouraging text and spinner animations
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(2);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    // Helper method to check if input is a valid positive integer
    private bool IsValidNumber(string input)
    {
        return input.All(char.IsDigit) && input.Length > 0 && int.Parse(input) > 0;
    }

    // Shows a spinner animation for the specified number of seconds
    protected void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
        
    }

    // Shows a countdown timer that counts down from the specified number of seconds
    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b  \b\b");
        }
        Console.WriteLine();
    }
    public virtual void Run()
    {

    }
}