public class Running
{
    private string _date;
    private string _name;
    private double _minutes;
    private double _distance;
    private double _speed;
    private double _pace;
    private double _stepOne;
    private double _stepTwo;
    public Running(string date, string name, double minutes, double distance)
    {
        _date = date;
        _name = name;
        _minutes = minutes;
        _distance = distance;
    }
    public double GetSpeed()
    {
        _stepOne = _distance / _minutes;
        _stepTwo = _stepOne * 60;
        _speed = _stepTwo.ToString("0.0");
        return _speed;
    }
    public double GetPace()
    {
        _pace = _minutes / _distance;
        return _pace;
    }
    public  string GetSummary()
    {
        return $"{_date} {_name} ({_minutes} min)- Distance {_distance} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        // Output example:
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    
    }
}