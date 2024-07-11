using System;

public class Reference 
{
    public string _book;
    public int _chapter;
    public int _verse;
    public int? _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        return _endVerse.HasValue
        ? $"{_book} {_chapter}:{_verse}-{_endVerse}"
        :$"{_book} {_chapter}:{_verse}";
    }
}