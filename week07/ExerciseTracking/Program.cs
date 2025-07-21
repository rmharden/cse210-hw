using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Swmming s1 = new Swmming(20, dateText, "Swimming", 30);
        Console.WriteLine($"{s1}");
    }
}