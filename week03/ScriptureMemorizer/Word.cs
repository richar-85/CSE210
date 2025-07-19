public class Word
{
    private string _text; // The actual word text
    private bool _isHidden; // Check if the word is currently hidden 

    // Constructor: initialize the word given text and sets it as visible
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    // Mark the word as hidden
    public void Hide()
    {
        _isHidden = true;
    }
    // Mark the word as visible 
    public void Show()
    {
        _isHidden = false;
    }
    // Returns true if word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }
    // Returns either the original word text or underscores if hidden 
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Returns string of under scores with the same length as the word
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}