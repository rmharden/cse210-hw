using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        // is this a instance of Square?
        Square s1 = new Square("green", 5);
        Console.WriteLine(s1.GetColor());
        Console.WriteLine(s1.GetArea());


    }
}