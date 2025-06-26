using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Fractions Project.");
        Console.Write("What is the numerator? ");
        string top = Console.ReadLine();

        Console.Write("What is the denominator? ");
        string bottom = Console.ReadLine();

        Console.WriteLine($"Your fraction is {top}/{bottom}.");
    }
}