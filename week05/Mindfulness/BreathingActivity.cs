using System;
using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity
{

    // From our class diagram, this class only has BreathingActivity() and Run() : void.
    public BreathingActivity(string name, string description, int duration) : base()
    {

        // I used Week 01 Curriculum about the int.Parse() function and the Week 05 Video Demo on animations

        name = "Breathing";
        description = "by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

        base.DisplayStartingMessage(name, description, duration);

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
            Console.WriteLine();
            Console.Write("Breath out... ");
            for (int i2 = 5; i2 > 0; i2--)
            {
                Console.Write(i2);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }

        base.DisplayEndingMessage(duration, name);
    }
}