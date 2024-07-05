using System;
using System.Collections.Generic;
using System.IO;

public class Journal 
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
//        string file = "data.txt";
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        
//          string filename = "data.txt";
//          string [] lines = System.IO.File.ReadAllLines(filename);

             
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            if (parts.Length == 3)
            {
                string date = parts[0];
                string promptText = parts[1];
                string entryText = parts[2];

                _entries.Add(new Entry(date, promptText, entryText));
            }
        }
    }
}