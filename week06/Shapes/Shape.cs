using System.Drawing;

//our lesson puts "abstract" on the base class
public abstract class Shape
{
    // this is a member variable
    private string _color;

    // this might have been why it isn't working: this is from the example:
    public Shape(string color)
    {
        _color = color;
    }

    // This is the getter
    public string GetColor()
    {
        return _color;
    }

    // This is a setter
    public void SetColor(string color)
    {
        _color = color;
    }

    // public virtual double GetArea()
    public virtual double GetArea()
    {
        return 0;
    }
}