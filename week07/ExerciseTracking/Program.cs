using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToString("dd MMM yyyy");

        // The example video had different dates for each one... Should I do that?
        
        Cycling c1 = new Cycling(dateText, "Cycling", 90, 3m);
        // Cycling c1 = new Cycling(dateText, "Cycling", 45, 8.75m);
        //Console.WriteLine($"{c1.GetSummary()}\n");

        Running r1 = new Running(dateText, "Running", 60, 15m);
        // Running r1 = new Running(dateText, "Running", 88, 4.38m);
        //Console.WriteLine($"{r1.GetSummary()}\n");

        Swmming s1 = new Swmming(2, dateText, "Swimming", 20);
        // Swmming s1 = new Swmming(20, dateText, "Swimming", 30);
        //Console.WriteLine($"{s1.GetSummary()}\n");

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

// I learned how to format the time here:
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings