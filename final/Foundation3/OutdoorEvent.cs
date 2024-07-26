using System;

public class OutdoorEvent : Event
{
    public string _weather { get; set; }

    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetFullDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {GetAddress()}\nWeather: {_weather}";
    }

    public string GetShortDescription()
    {
        return $"Type: Outdoor Event\nTitle: {_title}\nDate: {_date}";
    }
}