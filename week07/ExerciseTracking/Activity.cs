public abstract class Activity
{
    private string _date;
    private string _name;
    private decimal _minutes; // This the length of the activity.


    // This is the parent/base class
    public Activity(string date, string name, decimal minutes)
    {
        _date = date;
        _name = name;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public decimal GetMinutes()
    {
        return _minutes;
    }

    public void SetMinutes(decimal minutes)
    {
        _minutes = minutes;
    }

    public abstract decimal GetDistance();
    public abstract decimal GetSpeed();
    public abstract decimal GetPace();
    public virtual string GetSummary()
    {
        return $"{GetDate()} {GetName()} ({GetMinutes()} min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}