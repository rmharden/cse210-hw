public class Circle : Shape
{
    private double _radius;
    
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        double _squared = _radius * _radius;
        return _squared * Math.PI;
    }
}