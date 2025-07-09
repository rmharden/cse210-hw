using System;
using System.Security.Cryptography.X509Certificates;

// Practice as of July 9, 2025 at 11:19 AM
// Display Animations Video from CSE 210 W05 Project:
// Mindfulness Program
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World");

        // Pausing, sleeping, waiting... 1000 milliseconds.
        // 1000 Milliseconds = 1 Second
        
        Thread.Sleep(1000);

        Console.WriteLine("Done.");
    }
}

/*
// Practice prior to July 9, 2025 at 11:15 AM
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("\nHello Sandbox World!\n");

        Blind kitchen = new Blind();
        kitchen._width = 60;
        kitchen._height = 48;
        kitchen._color = "white";

        Console.WriteLine(kitchen._width);

        double materialAmountKt = kitchen.GetArea();

        Console.WriteLine(kitchen.GetArea());

        Blind livingRoom = new Blind();
        livingRoom._width = 83;
        livingRoom._height = 48;
        livingRoom._color = "eggshell";

        double materialAmountLr = livingRoom.GetArea();

        Console.WriteLine(livingRoom.GetArea());

        House johnsonHome = new House();
        johnsonHome._owner = "Johnson Family";

        johnsonHome._kitchen._width = 60;

        Console.WriteLine(johnsonHome._kitchen._width);


        foreach (Blind b in johnsonHome._blinds)
        {
            double amount = b.GetArea();
        }

        int[] numbers = { 10, 30, 44, 21, 51, 21, 61, 24, 14 };
        Array.IndexOf(numbers, 21);
        int ans = Array.IndexOf(numbers, 21);
        Console.WriteLine(ans);

        int[] source = { 12, 1, 5, -2, 16, 14 };
        int[] dest = { 1, 2, 3, 4 };

        Array.Copy(source, dest, 3);

        int[] numbers2 = { 12, 1, 5, -2, 16, 14 };
        Array.Sort(numbers2);

        string message = "Hello World";
        string anotherMessage = "";
        string myName = "Hello World, " + "name is Jamie";
        string myName2 = "Hello world, my name is Jamie";

        Console.WriteLine("Hello World".Length);

        string newMessage = message.Substring(2, 5);
        Console.WriteLine(newMessage);

        string firstString = "This is Jamie";
        string secondString = "Hello.";

        firstString.Equals("This is Jamie");
        secondString.Equals("This is Jamie");

        string[] separator = { ",", ";" };
        string names = "Peter, John, Andy, , David";
        string[] substrings = names.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(names);

        List<string> _prompts = new List<string> { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };

        Console.WriteLine(_prompts[0] + _prompts[1] + _prompts[2] + _prompts[3] + _prompts[4]);
        Console.WriteLine(_prompts.Count);
    }

}
*/
