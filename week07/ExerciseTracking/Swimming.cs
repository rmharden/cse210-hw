public class Swmming
{
    private string _date;
    private string _name;
    private double _minutes;
    private double _distance;
    private double _speed;
    private double _pace;
    private double _laps;
    private double _poolLength;
    public Swmming(double laps, string date, string name, double minutes)
    {
        _laps = laps;
        _date = date;
        _name = name;
        _minutes = minutes;
    }
    public double GetDistance()
    {
        _poolLength = 50;
        double _stepOne = _laps * _poolLength;
        double _stepTwo = 1000.00 * 0.52;
        _distance = _stepOne / _stepTwo;
        return _distance;
    }
    public double GetSpeed()
    {
        _speed = GetDistance() / _minutes;
        return _speed;
    }
    public double GetPace()
    {
        _pace = _minutes / GetDistance();
        return _pace;
    }
    public string GetSummary()
    {
        return $"{_date} {_name} ({_minutes} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        // Output example:
        // 03 Nov 2022 Swimming (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    }
}