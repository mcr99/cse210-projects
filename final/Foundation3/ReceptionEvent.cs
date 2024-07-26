using System;

public class ReceptionEvent : Event
{
    public string _email{ get; set; }

    public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public string GetFullDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {GetAddress()}\nEmail: {_email}";
    }

    public string GetShortDescription()
    {
        return $"Type: Reception Event\nTitle: {_title}\nDate: {_date}";
    }
}