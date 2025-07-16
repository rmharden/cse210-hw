using System.Drawing;

public class Square : Shape
{
    private double _side;

    // error says the base says it doesn't take a constructor...
    public Square(string color, double side) // why does this not work?
    {
        base.GetColor();
        _side = side;
    }


    // Not sure about this. It populated this for me:
    public override double GetArea()
    {
        // return base.GetArea();
        return _side * _side;
    }
}