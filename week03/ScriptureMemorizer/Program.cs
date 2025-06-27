
using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference();
        r1.GetDisplayText();
        Console.WriteLine(r1.GetDisplayText());

        Reference r2 = new Reference();
        r2.GetDisplayText();
        Console.WriteLine(r2.GetDisplayText());
    }
}
