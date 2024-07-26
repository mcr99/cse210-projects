using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Swimming swimming = new Swimming("10/10/2024", 20, 2);
        activities.Add(swimming);
        Running running = new Running("12/11/2024", 30, 4);
        activities.Add(running);
        Biking biking = new Biking("11/10/2024",40, 5);
        activities.Add(biking);

        foreach (Activity i in activities)
        {
            Console.WriteLine(i.GetSummary());
        }
    }
}