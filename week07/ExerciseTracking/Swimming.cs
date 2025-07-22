public class Swmming : Activity
{
    private decimal _distance;
    private decimal _speed;
    private decimal _pace;
    private decimal _laps;

    public Swmming(decimal laps, string date, string name, decimal minutes) : base(date, name, minutes)
    {
        _laps = laps;
    }

    public override decimal GetDistance()
    {
        // 50 is the length of the pool in meters
        decimal _stepOne = _laps * 50;
        decimal _stepTwo = 1000.00m * 0.62m;
        _distance = _stepOne / _stepTwo;
        return Math.Round(_distance, 2);
        // I'm pretty sure my math is right.
    }
    // Cycling and Running have the same math...
    // I wonder if I am supposed to make these in the base, Activity, and then Swimming, specifically is supposed to override the GetSpeed and GetPace..
    // Also, GetDistance is different for just Swimming. Maybe that is the same, also, where I need to override only in Swimming.
    public override decimal GetSpeed()
    {
        decimal minutes = base.GetMinutes();
        _speed = GetDistance() / minutes;
        return Math.Round(_speed, 2);
    }
    public override decimal GetPace()
    {
        decimal minutes = base.GetMinutes();
        _pace = minutes / GetDistance();
        return Math.Round(_pace, 2);
    }
    public virtual string GetSummary()
    {
        return base.GetSummary();

        // Output example:
        // 03 Nov 2022 Swimming (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    }
}
    


    // This was my code before learning to make the summary in the base class.
    // public override string GetSummary()
    // {
        // string date = base.GetDate();
        // decimal minutes = base.GetMinutes();
        // string name = base.GetName();
        // return $"{date} {name} ({minutes} min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";

        // Output example:
        // 03 Nov 2022 Swimming (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    // }