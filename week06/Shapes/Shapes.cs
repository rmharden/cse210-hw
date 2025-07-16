using System.Drawing;

//our lesson puts "abstract" on the base class
public abstract class Shapes
{
    // this is a member variable
    private string _color;

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
    public abstract double GetArea()
    {
        return 0;
    }
}