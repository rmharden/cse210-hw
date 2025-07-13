using System;
public class BreathingActivity : Activity
{

    // From our class diagram, this class only has BreathingActivity() and Run() : void.
    public BreathingActivity()
    {
        // I used Week 01 Curriculum about the int.Parse() function and the Week 05 Video Demo on animations

        // Console.WriteLine("\nHow long, in seconds, would you like your session? ");
        // string inputString = Console.ReadLine();
        // int duration = int.Parse(inputString);

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

    }
    // I don't know what we're supposed to use Run() for.
    public void Run()
    {


    }
}