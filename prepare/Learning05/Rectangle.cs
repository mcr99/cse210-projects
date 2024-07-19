public class Rectangle : Shape
{
    private double _lenght;
    private double _widht;

    public Rectangle(string color, double lenght, double width) : base(color)
    {
        _lenght = lenght;
        _widht = width;
    }

    public override double GetArea()
    {
        return _lenght * _widht;
    }
}