using System;
using System.Collections.Generic;
using System.IO;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = scriptureText.Split(" ");
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numbersToHide)
    {
        if (numbersToHide <= 0 || _words.Count == 0) return;

        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numbersToHide && _words.Any(word => !word.IsHidden())) //this checks to see if there are any words that haven't been hidden and doesn't try to hide them again if they have already been hidden
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText() 
    {
        string _scriptureText = "";
        foreach (Word word in _words)
        {
            _scriptureText += word.GetDisplayText() + " ";
        }
        if (_reference.GetDisplayText().Contains("-"))
            {
                return $"{_reference.GetDisplayText()}: {_scriptureText}";
            }
            else
            {
                return $"{_reference.GetDisplayText()}: {_scriptureText}";
            }
    }

    public bool IsCompletelyHidden() 
    {
        return _words.All(word => word.IsHidden());
    }
}