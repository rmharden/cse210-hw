
using System;
public class BreathingActivity //: Activity
{
    public BreathingActivity()
    {
        Console.Clear();
        Console.WriteLine("\nWelcome to the Breathing Activity.");
        Console.WriteLine("\nThis activity will help you relax by walking you through breathing in and out slowly. \nClear your mind and focus on your breathing.");

        Console.Write("\nHow long, in seconds, would you like for your session? ");
        string _duration = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Get ready...");
        //ShowSpinner();
        Spinner();
        Console.Read();

        Run();

        Console.WriteLine("\nWell done!!");
        Spinner();

        Console.WriteLine($"\nYou have completed another {_duration} seconds of the Breathing Activity.\n");
        Console.Read();
    }

    public void Run()
    {
        // Week 01 Curriculum about the int.Parse() function
        // Week 05 Video Demo on animations
        Console.WriteLine("\nHow long, in seconds, would you like your session? ");
        string inputString = Console.ReadLine();
        int duration = int.Parse(inputString);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
    public void Spinner()
    {
        // This is here temorarily

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < endTime)
        {

            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
}
