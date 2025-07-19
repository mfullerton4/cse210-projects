using System;
using System.Collections.Generic;
using System.Linq;

// I added programing to modify ther method so it only hides visible words.
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Break the text into words and build Word objects
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count = 3)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        int wordsToHide = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    //GEtter for Reference
    public Reference GetReference()
    {
        return _reference;
    }

    // Getter for Words list
    public List<Word> GetWords()
    {
        return _words;
    }

    // Method to check if all words are hidden
    public bool IsFullyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    // Method to get the formatted scripture (reference + hidden words)
    public string GetDisplay()
    {
        string displayText = _reference.ToString() + "\n";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplay() + " ";
        }
        return displayText.TrimEnd();


    }
}