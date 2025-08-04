using System;
using System.Collections.Generic;
using System.Threading;

// Added Exercise Activity
public class ExercisingActivity : Activity
{
    // List of exercise names used in this activity
    private List<string> _exercises = new List<string>
    {
        "SitUps",
        "PushUps",
        "PullUps"
    };

    // Constructor sets the activity name and description by calling the base Activity constructor
    public ExercisingActivity()
    : base("Exercising Activity", "This activity will guide you through simple exercise. Clear your mind and follow along.")
    {
    }

    // Override the Run method to execute the exercise routine
    public override void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int i = 0;

        // Loop until the allocated duration expires
        while (DateTime.Now < endTime)
        {
            string exercise = _exercises[i % _exercises.Count];
            Console.Clear();

            // Call the corresponding method to show exercise animation
            if (exercise == "SitUps")
                ShowSitUp();
            else if (exercise == "PushUps")
                ShowPushUp();
            else if (exercise == "PullUps")
                ShowPullUp();

            i++;

            Console.WriteLine();
            Console.WriteLine("Great job! Take a short rest...");
            ShowCountDown(5);
        }
        DisplayEndingMessage();
    }

    // Displays SitUp exercise animation by alternating frames
    private void ShowSitUp()
    {
        Console.WriteLine("SitUps (Follow along)");

        string[] frames = {
            "   _____\n  /     \\\n   |o_o|\n  \\_____/   <-- Sitting up",
            "    _____\n   /     \\\n  |       |\n  |       |  <-- Lying down\n   \\_____/"
        };
        PlayAnimation(frames, 3, 700);
    }

    // Displays PushUp exercise animation by alternating frames
    private void ShowPushUp()
    {
        Console.WriteLine("PushUps (Follow along)");

        string[] frames = {
            "      ___o \n  ___/    \\___\n |            | <-- Up",
            "     ____\n|    ___o    |\n|___/    \\___| <-- Down"
        };
        PlayAnimation(frames, 3, 700);
    }

    // Displays PullUp exercise animation by alternating frames
    private void ShowPullUp()
    {
        Console.WriteLine("PullUps (Follow along)");

        string[] frames = {

            "  _________\n |  |_o_|  |\n |    |    |\n |   / \\   |  <-- Pulling up",
            "   _________\n  |   \\o/   |\n  |    |    |\n  |   / \\   | <-- Hanging"

        };
        PlayAnimation(frames, 3, 700);
    }

    private void PlayAnimation(string[] frames, int loops, int delay)
    {
        for (int i = 0; i < loops; i++)
        {
            foreach (string frame in frames)
            {
                Console.Clear();
                Console.WriteLine(frame);
                Thread.Sleep(delay);
            }
        }
    }

}
