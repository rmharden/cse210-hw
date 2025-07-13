using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nHow long in, in seconds, would you like your session? ");
        string userInput = Console.ReadLine();
        int duration = int.Parse(userInput);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

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

        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        foreach (string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
}