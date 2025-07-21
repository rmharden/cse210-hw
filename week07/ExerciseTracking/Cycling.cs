public class Cycling
{
    private string _date;
    private string _name;
    private decimal _minutes;
    private decimal _distance;
    private decimal _speed;
    private decimal _pace;
    private decimal _stepOne;
    public Cycling(string date, string name, decimal minutes, decimal distance)
    {
        _date = date;
        _name = name;
        _minutes = minutes;
        _distance = distance;
    }
    public decimal GetSpeed()
    {
        _stepOne = _distance / _minutes;
        _speed = _stepOne * 60;
        return Math.Round(_speed, 1);
    }
    public decimal GetPace()
    {
        _pace = _minutes / _distance;
        return Math.Round(_pace, 1);
    }
    public  string GetSummary()
    {
        return $"{_date} {_name} ({_minutes} min)- Distance: {_distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        // Output example:
        // 03 Nov 2022 Cycling (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    
    }
}