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

    public override decimal GetCalcDistance()
    {
        decimal _poolLength = 50;
        decimal _stepOne = _laps * _poolLength;
        decimal _stepTwo = 1000.00m * 0.52m;
        _distance = _stepOne / _stepTwo;
        return Math.Round(_distance, 1);
    }
    public override decimal GetSpeed()
    {
        decimal minutes = base.GetMinutes(); 
        _speed = GetCalcDistance() / minutes;
        return Math.Round(_speed, 1);
    }
    public override decimal GetPace()
    {
        decimal minutes = base.GetMinutes(); 
        _pace = minutes / GetCalcDistance();
        return Math.Round(_pace, 1);
    }
    public override string GetSummary()
    {
        string date = base.GetDate();
        decimal minutes = base.GetMinutes();
        string name = base.GetName();
        return $"{date} {name} ({minutes} min)- Distance: {GetCalcDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        // Output example:
        // 03 Nov 2022 Swimming (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    }
}