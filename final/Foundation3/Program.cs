using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("2211 Street", "Dallas", "TX", "USA");
        LectureEvent lectureEvent = new LectureEvent("Lecture Event 1", "Test lecture Event", "12/15/23", "12:00 PM", address, "Speaker 1", 30);
        Console.WriteLine($"Standard details:\n{lectureEvent.GetStandardDetails()}\n ");
        Console.WriteLine($"Full details:\n{lectureEvent.GetFullDetails()}\n");
        Console.WriteLine($"Short description:\n{lectureEvent.GetShortDescription()}");

        Console.WriteLine("-----------");

        Address address2 = new Address ("987 Street", "Dallas", "TX", "USA");
        ReceptionEvent receptionEvent = new ReceptionEvent ("Reception Event 1","Test Reception Event", "10/05/2022", "3:00 PM", address2, "email@emial.com");
        Console.WriteLine($"Standard details:\n{receptionEvent.GetStandardDetails()}\n");
        Console.WriteLine($"Full details:\n{receptionEvent.GetFullDetails()}\n");
        Console.WriteLine($"Short description:\n{receptionEvent.GetShortDescription()}\n");

        Console.WriteLine("-----------");

        Address address3 = new Address ("767 Street", "Houston", "TX", "USA");
        OutdoorEvent outdoorEvent = new OutdoorEvent ("Outdoor Event1","Test Outdoor Event", "09/12/2022", "1:00 PM", address3, "Mark");
        Console.WriteLine($"Standard details:\n{outdoorEvent.GetStandardDetails()}\n");
        Console.WriteLine($"Full details:\n{outdoorEvent.GetFullDetails()}\n");
        Console.WriteLine($"Short description:\n{outdoorEvent.GetShortDescription()}\n");

    }
}