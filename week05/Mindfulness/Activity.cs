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
        _duration = duration;
        return duration;
        // had an error for this. not sure why
        // https://learn.microsoft.com/en-us/dotnet/csharp/misc/cs0161?f1url=%3FappId%3Droslyn%26k%3Dk(CS0161)
    }
    public void DisplayStartingMessage(string name, string description, int duration)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {name} Activity.\n");

        Console.WriteLine($"This activity will help you {description}\n");

        Console.Write("How long, in seconds, would you like your session? ");
        string inputString = Console.ReadLine();
        int usersTime = int.Parse(inputString);
        usersTime = duration;

        Console.Clear();
        Console.WriteLine("Get ready...");
    }
}