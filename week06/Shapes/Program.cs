using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.\n");

        // is this a instance of Square?
        Square s1 = new Square("green", 5);
        Console.WriteLine("This is a square:");
        Console.WriteLine(s1.GetColor());
        Console.WriteLine(s1.GetArea());


    }
}