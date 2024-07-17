using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    public int _count;
    public List<string> _prompts;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowSpinner(5);

        List<string> responses = GetListFromUser();
        _count = responses.Count;

        Console.WriteLine($"You listed {_count} items");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];

    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List <string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);


        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string response = Console.ReadLine();
            responses.Add(response);
        }
        return responses;
    }
}