public class Activity()
{
    private string _name = "";
    private string _description = "";
    private int _duration = 0;

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public int SetDuration(int duration)
    {
        Console.Write("How long, in seconds, would you like your session? ");
        string inputString = Console.ReadLine();
        int usersTime = int.Parse(inputString);
        usersTime = duration;
        return duration;
    }
    public void DisplayStartingMessage(string name, string description, int duration)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {name} Activity.\n");

        Console.WriteLine($"This activity will help you {description}\n");

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner();
    }
    // public void ShowSpinner(int seconds)
    public void ShowSpinner()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        int i3 = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i3];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void DisplayEndingMessage(int duration, string name)
    {
        Console.WriteLine("Well done!");
        ShowSpinner();

        Console.WriteLine();
        GetDuration();

        Console.WriteLine($"\nYou have completed another {duration} seconds of the {name} Activity.");
        ShowSpinner();

        Console.Clear();
    }

    public void ShowCountDown()
    {
        for (int i4 = 5; i4 > 0; i4--)
        {
            Console.Write("\b \b");
        }
    }
}