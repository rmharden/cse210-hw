public class GoalManager
{
    // This is going to need the menu system and is caled by Program.cs

    private int _score;
    private List<Goal> _goals; //This is polymorphism

    public GoalManager()
    {
        //_score = score; // this wouldn't work without putting the variable as a parameter.
        _goals = new List<Goal>();
    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {

    }

    public void RecordEvent()
    {
        // This is abstract
    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {
        
    }
}