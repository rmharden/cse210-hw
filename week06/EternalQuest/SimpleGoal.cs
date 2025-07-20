using System.ComponentModel;

public class SimpleGoal : Goal
{
    // attributes
    private bool _isComplete;

    public override int RecordEvent()
    {
        return 0;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        // virtual?
        return "";
    }


}