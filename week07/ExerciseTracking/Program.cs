using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToString("dd MMM yyyy");

        Swmming s1 = new Swmming(20, dateText, "Swimming", 30);
        Console.WriteLine($"{s1.GetSummary()}\n");

        Running r1 = new Running(dateText, "Running", 88, 4.38m);
        Console.WriteLine($"{r1.GetSummary()}\n");

        Cycling c1 = new Cycling(dateText, "Cycling", 45, 8.75m);
        Console.WriteLine($"{c1.GetSummary()}\n");
    }
}

// I learned how to format the time here:
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings