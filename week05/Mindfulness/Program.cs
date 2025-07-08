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
        string response = "";
        while (response != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start the breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            response = Console.ReadLine();
            if (response == "1")
            {
                Console.WriteLine("\nYou chose the Breathing Activity.\n");
                BreathingActivity ba1 = new BreathingActivity();
            }
            else if (response == "2")
            {
                Console.WriteLine("\nYou chose the Reflecting Activity\n");
            }
            else if (response == "3")
            {
                Console.WriteLine("\nYou chose the Listing Activity\n");
                ListingActivity la = new ListingActivity();
                la.GetListFromUser();
                Console.WriteLine("");
            }
            else if (response == "4")
            {
                Console.WriteLine("\nThank you for using the Mindfulness Program!\n");
            }
            else
            {
                Console.WriteLine("\nInvalid number.\n");
            }
        }
    }
}