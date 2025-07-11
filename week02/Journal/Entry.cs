using System;

// Journal entry date, prompt, and response
public class Entry
{
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _entryText { get; set; }

    public Entry(string prompts, string response)
    {
        // Store current journal entry in string format
        _date = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
        _promptText = prompts;
        _entryText = response;
    }

    public Entry()
    {
    }
    // Display entry contents
    public void Display()
    {
        Console.Write($"Date: {_date} - ");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}\n");
    }
}