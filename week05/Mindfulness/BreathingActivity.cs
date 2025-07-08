using System;
public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        Console.Write("\nHow long, in seconds, would you like for your session? ");
        string userInput = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.Read();

        Console.WriteLine("Breathe in...");
        Console.WriteLine("Now breathe out...");

        Console.WriteLine("Well done!!");

        Console.WriteLine($"You have completed another {userInput} seconds of the Breathing Activity.");
    }

    public void Run()
    {

    }
}

   
   
   
    /*
    private string _number;
    public BreathingActivity(string name, string number) : base(name)
    {
        _number = number;
    }

    public string GetNumber()
    {
        return _number;
    }

    public string GetStudentInfo()
    {
        return _name + " " + _number; 
    }
    */