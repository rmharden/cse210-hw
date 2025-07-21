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

    public abstract decimal GetCalcDistance(); // Only Swimming needs this one.
    public abstract decimal GetSpeed();
    public abstract decimal GetPace();
    public abstract string GetSummary();


    // public virtual string GetSummary()
    // {
    //     return $"{_date} {_name} ({_minutes} min)- Distance: {GetCalcDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    // }

    // The GetSummary method is definied in the base class and calls virtual methods for getting the distance, speed, and pace....
    // How do I do that??
}