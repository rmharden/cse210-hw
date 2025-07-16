using System.Drawing;

public class Shapes
{
    // this is a member variable
    string _color;

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

    public virtual double GetArea()
    {
        return 0;
    }

}