using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("\nHello World! This is the Mindfulness Project.\n");
        BreathingActivity bActivity = new BreathingActivity("Brigham", "234");
        string name = bActivity.GetName();
        string number = bActivity.GetNumber();
        Console.WriteLine(name);
        Console.WriteLine(number);
        // This is in the lesson but I don't know where
        // it goes.
        // string number = base.GetName();
        Console.WriteLine($"Breathing Activity Number: {number}\n");
        */

        // This repeats and there is no end.
        ListingActivity la = new ListingActivity();
        la.GetListFromUser();
    }
}