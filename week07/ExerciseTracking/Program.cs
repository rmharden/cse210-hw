using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToString("dd MMM yyyy");

        // The example video had different dates for each one... Should I have done that?
        // https://video.byui.edu/media/t/1_fnsp1qsi
        

        Cycling c1 = new Cycling(dateText, "Cycling", 45, 6.75m);

        Running r1 = new Running(dateText, "Running", 88, 4.38m);

        Swmming s1 = new Swmming(20, dateText, "Swimming", 30);


        List<string> _activities = new List<string>();
        _activities.Add(c1.GetSummary());
        _activities.Add(r1.GetSummary());
        _activities.Add(s1.GetSummary());
        foreach (string activity in _activities)
        {
            Console.WriteLine($"{activity}\n");
        }
    }
}

// I learned how to format the date here:
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings