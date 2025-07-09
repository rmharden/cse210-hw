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

        Console.Write("\nHow long, in seconds, would you like for your session? ");
        string _duration = Console.ReadLine();
        int seconds = int.Parse(_duration);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!");
    }

    public void ShowSpinner()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(8);

        int i = 0;

        while (DateTime.Now < endTime)
        {

            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {

    }
}