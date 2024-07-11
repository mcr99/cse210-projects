using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string text , Reference reference)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}\n";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool isCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word._isHidden)
            return false;
        }
        return true;
    }
}