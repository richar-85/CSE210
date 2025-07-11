using System;
using System.Collections.Generic;

// Randomly generates writen prompt from predefined list
public class PromptGenerator
{
    // List of prompts
    public List<string> _prompts = new List<string>
    {
        "Who was the most interested person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What am I grateful for today?",
        "How did I handle stressfull situations today?",
        "What challenges did I face today, and how did I overcome them?",
        "What did I learn today from scripture study?",
        "What, Who, Where, did I render service today?"
    };
    // Get new random prompts from list
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}