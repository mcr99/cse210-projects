using System;

public class Word
{
    public string _text;
    public bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        return _isHidden ? "___" : _text;
    }
}