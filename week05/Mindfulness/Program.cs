using System;
using System.ComponentModel.Design;
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

        /*
        Menu Options:
        1. Start the breathing activity
        2. Start reflecting activity
        3. Start listing activity
        4. Quit
        Select a choice from the menu: 
*/
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start the breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing Activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Select a choice from the menu");

        ListingActivity la = new ListingActivity();
        la.GetListFromUser();
        

    }
}