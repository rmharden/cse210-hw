using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public abstract class Goal
{
    // Attributes (private or protected according to the video)
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    
    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public string GetDetailsString()
    {
        // virtual?
        return "";
    }

    public abstract string GetRepresentation();
}