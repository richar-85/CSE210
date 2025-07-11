using System;
using System.Collections.Generic;
using System.IO;

// Manage collections of journal entries and handles operations of file
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public List<Entry> GetEntries()
    {
        return _entries;
    }

    // Displays journal entries
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries to display.\n");
            return;
        }
        foreach (var newEntry in _entries)
        {
            newEntry.Display();
        }
    }
    
    // Saves all journal entries in a file
    public void SaveToFile(string file)
    {
        using (StreamWriter inputFile = new StreamWriter(file))
        {
            foreach (var newEntry in _entries)
            {
                inputFile.WriteLine(newEntry._date);
                inputFile.WriteLine(newEntry._promptText);
                inputFile.WriteLine(newEntry._entryText);
            }
        }
        Console.WriteLine($"{file}\n");
    }

    // Load journal entries from saved file
    public void LoadFromFile(string file)
    {
        using (StreamReader outputFile = new StreamReader(file))
        {
            while (!outputFile.EndOfStream)
            {
                string dateLine = outputFile.ReadLine();
                string promptLine = outputFile.ReadLine();
                string responseLine = outputFile.ReadLine();

                Entry newEntry = new Entry
                {
                    _date = dateLine,
                    _promptText = promptLine,
                    _entryText = responseLine
                };
                _entries.Add(newEntry);
            }
        }
        Console.WriteLine($"{file}\n");
    }
}