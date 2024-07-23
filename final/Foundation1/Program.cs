using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning C#", "C# teacher", 2000);
        Video video2 = new Video("Learning CSS", "CSS teacher", 1500);
        Video video3 = new Video("Learning HTML", "HTML teacher", 2500);
        Video video4 = new Video("Learning JS", "JS teacher", 1000);

        video1.AddComment("Username1", "Thank you!");
        video1.AddComment("Username2", "Great video!");

        video2.AddComment("Username1", "Greeaat");
        video2.AddComment("Username2", "I want to learn!");
        video2.AddComment("Username3", "thaaanks!");

        video3.AddComment("Username1", "thanks!!");
        video3.AddComment("Username2", "HI!");

        video4.AddComment("Username1", "awesome!");

        List<Video> videos = new List<Video>
        {
            video1, video2, video3, video4
        };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length (seconds): {video._length}");
            Console.WriteLine($"Number of Comments: {video.GetNumberComments()}");

            foreach (var comment in video.Comment)
            {
                Console.WriteLine($"{comment._commentName} - {comment._commentText}");
            }
            Console.WriteLine();
        }
    }
}