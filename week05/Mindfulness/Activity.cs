public class Activity
{
    /*
    protected string _name;
    public Activity(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    */


    private string _name = "";
    private string _description = "";
    private int _duration = 0;

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name} activity.");

        Console.WriteLine($"\n{_description}");

        Console.Write("How long, in seconds, would you like your session? ");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!");
    }

    public void ShowSpinner(int seconds)
    {
        Console.WriteLine("Get Ready...");

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("\\");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }

    public void ShowCountDown(int seconds)
    {
        
    }
}