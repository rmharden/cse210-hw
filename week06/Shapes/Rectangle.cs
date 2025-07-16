public class Rectangle : Shape
{
    private double _side;

    // error says the base says it doesn't take a constructor...
    public Rectangle(string color, double side) : base (color)
    {
        // base.GetColor();
        _side = side;
    }

    GetColor();
    // Not sure about this. It populated this for me:
    public override double GetArea()
    {
        // return base.GetArea();
        return _side * _side;
    }
}