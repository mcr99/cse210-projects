using System;

public class Biking : Activity
{
    private double _speed;

    public Biking(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * Length / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return Length / GetDistance();
    }

}