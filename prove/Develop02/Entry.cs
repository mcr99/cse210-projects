using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
    }

    public override string ToString()
    {
        return $"{_date}~{_promptText}~{_entryText}";
    }

    public static Entry FromString(string entryString)
    {
        var parts = entryString.Split('~');
        return new Entry(parts[0], parts[1], parts[2]);
    }
}