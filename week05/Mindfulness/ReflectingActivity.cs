using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
public class ReflectingActivity : Activity
{
    public ReflectingActivity()
    {
        Console.Clear();
        Console.WriteLine("\nWelcome to the Reflecting Activity.");
        Console.WriteLine("\nThis activity will help you reflect on times in your life when you have shown strength \nand resilience. This will help you recognize the power you have and how you can use it \nin other aspects of your life.");

        Console.Write("\nHow long, in seconds, would you like for your session? ");
        string userInput = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.Read();

        Console.WriteLine("Consider the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.Read();

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may being in: ");

        Console.Read();

        Console.WriteLine("\nWell done!!");

        Console.WriteLine($"\nYou have completed another {userInput} seconds of the Reflecting Activity.\n");
        Console.Read();
    }
    public string GetRandomPrompt()
    {
        Random displayPrompt = new Random();
        List<string> _prompts = new List<string>()
            {
                "1. Think of a time when you stood up for someone else.",
                "2. Think of a time when you did something really difficult.",
                "3. Think of a time when you helped someone in need.",
                "4. Think of a time when you did something truly selfless."
            };
        int pIndex = displayPrompt.Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[pIndex]} ---");
        return _prompts[pIndex];
    }
}