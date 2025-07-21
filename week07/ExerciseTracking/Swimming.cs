using System.Collections.Specialized;

public class Swmming
{
    private string _date;
    private string _name;
    private double _time;
    private double _distance;
    private double _speed;
    private double _pace;
    private double _laps;
    private double _poolLength;
    public Swmming(double poolLength, double laps, string date, string name, double time, double distance, double speed, double pace)
    {
        _poolLength = poolLength;
        _laps = laps;
        _date = date;
        _name = name;
        _time = time;
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }
    public double GetDistance()
    {
        _poolLength = 50;
        double _stepOne = _laps * _poolLength;
        double _stepTwo = 1000.00 * 0.52;
        _distance = _stepOne / _stepTwo;
        // Established in the main program?
        return _distance;
    }
    public double GetSpeed()
    {
        return _speed;
    }
    public double GetPace()
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