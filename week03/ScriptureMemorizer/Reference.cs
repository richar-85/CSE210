

using System.Reflection.Emit;

public class Reference
{
    private string _book; // Name of book
    private int _chapter; // Book chapter number
    private int _verse; // Single verse
    private int _startVerse; // Starting verse
    private int _endVerse; // Ending verse

    // Constructor for single verse reference
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }
    // Constructor for multi-verese reference 
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    // Returns the reference as a formatted string
    public string GetDisplayText()
    {
        // single verse reference
        if (_verse == _endVerse)
        {
            return _book + " " + _chapter + ":" + _verse;
        }
        else
        {
            // verse range reference 
            return _book + " " + _chapter + ":" + _startVerse + "-" + _endVerse;
        }
    }
}