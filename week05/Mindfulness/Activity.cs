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
        Console.WriteLine($"");
        Console.WriteLine($"This activity will help you {description}");
    }

    public void DisplayEndingMessage()
    {

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