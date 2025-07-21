public class Cycling
{
    private string _date;
    private string _name;
    private double _minutes;
    private double _distance;
    private double _speed;
    private double _pace;
    public Cycling(string date, string name, double minutes, double distance)
    {
        _date = date;
        _name = name;
        _minutes = minutes;
        _distance = distance;
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
        return $"{_date} {_name} ({_minutes} min)- Distance {_distance} miles, Speed {_speed} mph, Pace: {_pace} min per mile";
        // Output example:
        // 03 Nov 2022 Cycling (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    
    }
}