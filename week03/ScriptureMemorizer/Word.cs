public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Getter for text
    public string GetText()
    {
        return _text;
    }

    // Setter for text ( if needed)
    public void SetText(string text)
    {
        _text = text;
    }

    // Getter for hidden status
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Setter for hidden status
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to display the word (as text or underscores)
    public string GetDisplay()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}