using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Goal
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

    public int RecordEvent()
    {
        return 0;
    }

    public bool IsComplete()
    {
        return false;
    }

    public string GetDetailsString()
    {
        return "";
    }

    public string GetRepresentation()
    {
        return "";
    }
}