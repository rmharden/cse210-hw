using System;
class Activity
{
    public Activity()
    {

    }
    public void DisplayStartingMessage()
    {

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
        return 0;
    }
}