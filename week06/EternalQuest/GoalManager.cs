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
        // Here is where the main menu goes.
        // Call:
        // CreateGoal, ListGoalDetails, SaveGoals, LoadGoals
        // RecordEvent
        // Exit

    }

    public void DisplayPlayerInfo()
    {
        // display the points

    }

    public void ListGoalNames()
    {
        // loop through the list of goals and display the names of _shortname, the names (TO GET THE NAMES YOU NEED ANOTHER FUNCTION IN THE GOAL CLASS...)
        // 1. go to bed on time
        // 2. do my homework
    }

    public void ListGoalDetails()
    {
        // loop through the list of goals and display the full details. Call the GetDetailsString function?
        // print it out in the loop
    }

    public void CreateGoal()
    {
        // Three possible goals we need to display a submenu to select a goal type.
        // then ask for the name, description, and points
        // ask for more if they pick the checklist goal
        // Create the object they selec and add it to the goal list

    }

    public void RecordEvent()
    {
        // This is abstract
        // 
        // display a list of all the goal names
        // ask user to select a goal
        // call RecordEvent on the correct goal to get in the goal list and call recordevent 
        // recordevent returns integers and update the score based on the points
        // display current points
    }

    public void SaveGoals()
    {
        // Ask user for a file name
        // loop through the goals and convert each goal to a string and then save the string.

    }

    public void LoadGoals()
    {
        // ask user for a file name
        // read each line of the file and split it up
        // use the parts to re-create the goal object
    }
}