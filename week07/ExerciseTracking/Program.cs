using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.\n");

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Swmming s1 = new Swmming(20, dateText, "Swimming", 30);
        Console.WriteLine($"{s1.GetSummary()}\n");
    }
}