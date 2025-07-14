using System;
class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;

    }
    public void DisplayStartingMessage(string name, string description, int duration)
    {
        Console.Clear();

        Console.WriteLine($"\nWelcome to the {name} Activity.");

        Console.WriteLine($"\nThis activity will help you {description}\n");

        Console.Write("How long, in seconds, would you like your sesson? ");
        string userInput = Console.ReadLine();
        int userTime = int.Parse(userInput);
        userTime = duration;

        // Do I add the spinner and things here? This is where I left off.
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner();
    }
    public int ShowSpinner()
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

        foreach (string s in animationStrings)
        {
            Console.WriteLine(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        return 0;
    }

    public int ShowCountDown()
    {
        for (int scd = 5; scd > 0; scd--)
        {
            Console.WriteLine(scd);
            Thread.Sleep(1000);
            Console.WriteLine("\b \b");
        }
        return 0;
    }
}