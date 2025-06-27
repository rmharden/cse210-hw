
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        Reference r1 = new Reference();
        r1.GetDisplayText();
        Console.WriteLine(r1.GetDisplayText());

        Reference r2 = new Reference("John", 3, 16);
        r2.GetDisplayText();
        Console.WriteLine(r2.GetDisplayText());

        Reference r3 = new Reference("Proverbs", 3, 5, 6);
        r3.GetDisplayText();
        Console.WriteLine(r3.GetDisplayText());

        Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        Console.WriteLine("");
    }
}
