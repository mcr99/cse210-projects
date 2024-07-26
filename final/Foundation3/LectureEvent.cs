using System;

public class LectureEvent : Event
{
    public string _speaker { get; set; }
    public int _capacity { get; set; }

    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {GetAddress()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public string GetShortDescription()
    {
        return $"Type: Lecture Event\nTitle: {_title}\nDate: {_date}";
    }
}