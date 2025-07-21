using System.Globalization;

public class Running : Activity
{
    private decimal _distance;
    private decimal _speed;
    private decimal _pace;
    private decimal _stepOne;
    
    public Running(string date, string name, decimal minutes, decimal distance) : base(date, name, minutes)
    {
        _distance = distance;
    }
    public override decimal GetSpeed()
    {
        decimal minutes = base.GetMinutes();
        _stepOne = _distance / minutes;
        _speed = _stepOne * 60;

        return Math.Round(_speed, 1);
        // https://learn.microsoft.com/en-us/dotnet/api/system.math?view=net-9.0
    }
    public override decimal GetPace()
    {
        decimal minutes = base.GetMinutes();
        _pace = minutes / _distance;
        return Math.Round(_pace, 1);
    }
    public override decimal GetCalcDistance()
    {
        return _distance;
    }
    public override string GetSummary()
    {
        string date = base.GetDate();
        decimal minutes = base.GetMinutes();
        string name = base.GetName();
        return $"{date} {name} ({minutes} min)- Distance: {_distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        // Output example:
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile

    }
}