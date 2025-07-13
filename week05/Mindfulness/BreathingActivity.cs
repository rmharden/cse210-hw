using System;
using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity
{

    // From our class diagram, this class only has BreathingActivity() and Run() : void.
    public BreathingActivity(string name, string description, int duration) : base()
    {
        // I used the information from Week 01 about Coverting Types by using the int.Parse() function.
        // I also watched the video from Week 05 om Display animations and used the things taught there to do the breathing activity.
        Console.Write("\nHow long, in seconds, would you like your session? ");

        string inputString = Console.ReadLine();
        int seconds = int.Parse(inputString);

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.Write("Breathe out... ");
            for (int i2 = 5; i2 > 0; i2--)
            {
                Console.Write(i2);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nWell done!\n");
    }
}




// public class BreathingActivity : Activity
// {

//     // From our class diagram, this class only has BreathingActivity() and Run() : void.
//     public BreathingActivity(string name, string description, int duration) : base()
//     {

//         // I used Week 01 Curriculum about the int.Parse() function and the Week 05 Video Demo on animations

//         name = "Breathing";
//         description = "by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

//         base.DisplayStartingMessage(name, description, duration);

//         DateTime startTime = DateTime.Now;
//         DateTime endTime = startTime.AddSeconds(duration);
//         while (DateTime.Now < endTime)
//         {
//             Console.Write("\nBreathe in... ");
//             for (int i = 5; i > 0; i--)
//             {
//                 Console.Write(i);
//                 Thread.Sleep(1000);
//                 Console.Write("\b \b");
//             }
//             Console.WriteLine();
//             Console.Write("Breath out... ");
//             for (int i2 = 5; i2 > 0; i2--)
//             {
//                 Console.Write(i2);
//                 Thread.Sleep(1000);
//                 Console.Write("\b \b");
//             }
//             Console.WriteLine();
//         }

//         base.DisplayEndingMessage(duration, name);
//     }
// }