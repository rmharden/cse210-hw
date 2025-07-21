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
        // _distance = distance; // I think this needs to be here because all derived classes have distance, however, cycling is the only one that calculates distance... but I think we are supposed to override an attribute? //nvm - the rubric says that distance, speed, number of laps are not stored in the base class. Good!
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

    // The GetSummary method is definied in the base class and calls virtual methods for getting the distance, speed, and pace....
    // How do I do that??
}