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

        return Math.Round(_speed, 2);
        // https://learn.microsoft.com/en-us/dotnet/api/system.math?view=net-9.0
    }
    public override decimal GetPace()
    {
        decimal minutes = base.GetMinutes();
        _pace = minutes / _distance;
        return Math.Round(_pace, 2);
    }
    public override decimal GetDistance()
    {
        return _distance;
    }
    public virtual string GetSummary()
    {
        return base.GetSummary();

        // Output example:
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    }
}



    // This has my code before creating the GetSummary() in the base class.
    // public override string GetSummary()
    // {
        // string date = base.GetDate();
        // decimal minutes = base.GetMinutes();
        // string name = base.GetName();
        // return $"{date} {name} ({minutes} min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        // Output example:
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    // }