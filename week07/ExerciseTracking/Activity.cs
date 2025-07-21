public abstract class Activity
{
    private string _date;
    private string _name;
    private decimal _time;
    private decimal _distance;
    private decimal _speed;
    private decimal _pace;
    // This is the parent/base class
    public Activity(string date, string name, int time, decimal distance, decimal speed, decimal pace)
    {
        _date = date;
        _name = name;
        _time = time;
        _distance = distance;
        _speed = speed;
        _pace = pace;
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

    public abstract decimal GetDistance();
    public abstract decimal GetSpeed();
    public abstract decimal GetPace();
    public abstract decimal GetSummary();
}