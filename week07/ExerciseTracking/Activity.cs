public abstract class Activity
{
    private string _date;
    private string _name;
    private decimal _minutes;
    private decimal _distance;

    // This is the parent/base class
    public Activity(string date, string name, decimal minutes, decimal distance)
    {
        _date = date;
        _name = name;
        _minutes = minutes;
        _distance = distance;
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
        public decimal GetDistance()
    {
        return _distance;
    }

    public void SetDistance(decimal distance)
    {
        _distance = distance;
    }

    public abstract decimal GetCalcDistance(); // Only Swimming has this one.
    public abstract decimal GetSpeed();
    public abstract decimal GetPace();
    public abstract string GetSummary();
}