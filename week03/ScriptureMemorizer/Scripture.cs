using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference; // Hold the scripture reference 
    private List<Word> _words; // List of word objects that make up the scripture text
    private Random _random = new Random(); // Random generator used for hiding words

    // Constructor: initialize the reference and splits the scripture text into word objects
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the input text into words
        string[] splitWords = text.Split(' ');

        // Creates a word objetc for each split word and add to the list
        for (int i = 0; i < splitWords.Length; i++)
        {
            _words.Add(new Word(splitWords[i]));
        }
    }
    // Hides a given number of random words in the scripture
    public void HideRandomWords(int numberToHide)
    {
        // Create a list to store unhidden words
        List<int> unhiddenWords = new List<int>();

        // Loop through words to find words that are not hidden
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                unhiddenWords.Add(i);
            }
        }

        // Determine how many words can be hidden and available unhidden words not exceeded
        int wordsToHide;
        if (numberToHide < unhiddenWords.Count)
        {
            wordsToHide = numberToHide;
        }
        else
        {
            wordsToHide = unhiddenWords.Count;
        }

        // Randomly select and hide words from list if unhidden words
        for (int i = 0; i < wordsToHide; i++)
        {
            int randomWord = _random.Next(unhiddenWords.Count); // Get random unhidden word
            int wordWord = unhiddenWords[randomWord]; // Get actual word position 
            _words[wordWord].Hide(); // Hide the word
            unhiddenWords.RemoveAt(randomWord); // Remove and don't select hidden word
        }
    }
    // Returns the full scripture as a string and hidden word repalced as needed
    public string GetDisplayText()
    {
        string text = "";

        // Concatenate and display text for each word
        for (int i = 0; i < _words.Count; i++)
        {
            text += _words[i].GetDisplayText();

            // Add space between words and no space after the last word
            if (i < _words.Count - 1)
            {
                text += " ";
            }
        }
        // Return reference plus scripture text
        return _reference.GetDisplayText() + " " + text;
    }
    // Ckeck if all words in the scripture are hidden 
    public bool IsCompletelyHidden()
    {
        // Check if any word is still visible
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                return false;
            }
        }
        // All words are hidden
        return true;
    }

}