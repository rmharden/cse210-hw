using System.Runtime;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    /// unsure what to do here
    // public static void RecordEvent()
    // {

    // }


    // Also, not sure what to do here
    // public bool IsComplete()
    //{

    //}

    // Also, not sure what to do here
    // public string GetDetailsString()
    // {

    // }


    // Also, not sure what to do here
    // public string GetStringRepresentation()
    // {
    
    // }
}