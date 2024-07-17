using System;
using System.Collections.Generic;
using System.Threading;


public class Activity 
{
    public string _name;
    public string _description;
    public int _duration;

    public Activity (string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} Activity: ");
        Console.WriteLine(_description);
        Console.WriteLine("Enter the duration in seconds");
        if  (int.TryParse(Console.ReadLine(), out _duration))
        {
            Console.WriteLine("Prepare to begin...");
            ShowSpinner(3);
        }
        else 
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            DisplayStartingMessage();
        }
        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds. ");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {

    List<string> animationStrings = new List<string>();
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);
    
    int i = 0;
    while (DateTime.Now < endTime)
    {
        string s = animationStrings[i];
        Console.Write(s);
        Thread.Sleep(1000);
        Console.Write("\b \b");

        i++;
        if (1 >= animationStrings.Count)
        {
            i = 0;
        }

    }
    }


    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
}