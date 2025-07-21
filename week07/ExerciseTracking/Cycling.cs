public class Cycling
{
    private string _date;
    private string _name;
    private int _time;
    private int _distance;
    private decimal _speed;
    private int _pace;
    public Cycling(string date, string name, int time, int distance, decimal speed, int pace)
    {
        _date = date;
        _name = name;
        _time = time;
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }
    public int GetDistance()
    {
        // Established in the main program?
        return _distance;
    }
    public decimal GetSpeed()
    {
        return _speed;
    }
    public int GetPace()
    {
        return _pace;
    }
    public  string GetSummary()
    {
        return $"{_date} {_name} ({_time} min)- Distance {_distance} miles, Speed {_speed} mph, Pace: {_pace} min per mile";
        // Output example:
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    
    }
}