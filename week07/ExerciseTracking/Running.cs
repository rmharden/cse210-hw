public class Running
{
    private string _date;
    private string _name;
    private int _time;
    private int _distance;
    private decimal _speed;
    private int _pace;
    public Running(string date, string name, int time, int distance, decimal speed, int pace)
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
        return _distance;
    }
    public decimal GetSpeed()
    {
        // Speed (mph or kph) = (distance / minutes) * 60
        _speed = _distance / _time * 60;
        return _speed;
    }
    public int GetPace()
    {
        _pace = 
        return 0;
    }
    public  string GetSummary()
    {
        return $"{_date} {_name} ({_time} min)- Distance {_distance} miles, Speed {_speed} mph, Pace: {_pace} min per mile";
        // Output example:
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    
    }
}