using System;

public class Event
{
    public string _title { get; set; }
    public string _description { get; set;}
    public string _date { get; set;}
    public string _time { get; set;}
    public Address _address { get; set; }

    public Event (string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {GetAddress()}";
    }

    public string GetAddress()
    {
        return $"{_address._street}, {_address._city} {_address._state}, {_address._country}";
    }
}