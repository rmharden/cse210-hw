using System.Security.Cryptography.X509Certificates;

public class Goal
{
    // I believe this is the base class

    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {
        return true; //this is here temporarily
    }

    public string GetDetailsString()
    {
        return "";
    }

    public string GetStringRepresentation()
    {
        return "";
    }
}