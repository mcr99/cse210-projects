using System;

public abstract class Activity
{
    private string _date;
    private int _length;

    protected Activity (string date, int length)
    {
        _date = date;
        _length = length;
    }

    public string Date => _date;
    public int Length => _length;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    
    public virtual string GetSummary()
    {
        return $"{_date} ({_length} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}