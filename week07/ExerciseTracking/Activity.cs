public abstract class Activity
{
    private string _date;
    private string _name;
    private int _time;
    private int _distance;
    private decimal _speed;
    private int _pace;
    // This is the parent/base class
    public Activity(string date, string name, int time, int distance, decimal speed, int pace)
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

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
}