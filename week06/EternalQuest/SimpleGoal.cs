using System.ComponentModel;
// don't know what is wrong here.
public class SimpleGoal : Goal
{
    // attributes
    private bool _isComplete;

    // constructor
    // public SimpleGoal(string name, string decription, int points)
    // {
    //     name = "Simple Goal";
    //     // string description = "";
    //     points = 0;
    // }

    public override int RecordEvent()
    {
        return 0;
    }

    public override bool IsComplete()
    {
        // Return is the goal complete or not.
        return false;
    }

    public override string GetStringRepresentation()
    {
        // virtual?
        // need checklist goal?
        return "";
    }


}