using System;
public class ReflectingActivity : Activity
{
    public ReflectingActivity()
    {
        Console.Clear();
        Console.WriteLine("\nWelcome to the Reflecting Activity.");
        Console.WriteLine("\nThis activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.");

        Console.Write("\nHow long, in seconds, would you like for your session? ");
        string userInput = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.Read();

        Console.WriteLine("Breathe in...");
        Console.WriteLine("Now breathe out...");

        Console.WriteLine("\nWell done!!");

        Console.WriteLine($"\nYou have completed another {userInput} seconds of the Breathing Activity.\n");
        Console.Read();
    }
}