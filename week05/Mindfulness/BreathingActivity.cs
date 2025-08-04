using System;

public class BreathingActivity : Activity
{
    // Constructor: sets the activity name and description by calling the base Activity constructor
    public BreathingActivity()
    : base("Breathing Activity", "This activity will helps you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    
    // Override the Run method to implement the breathing exercise logic
    public override void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        // Loop through breathing cycles until the allotted time runs out
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();

            Console.Write("Breathe in...");
            ShowCountDown(5);


            Console.Write("Now breathe out...");
            ShowCountDown(5);
        }
        DisplayEndingMessage();
    }

}