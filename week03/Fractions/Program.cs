using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        I was using this to test running the program:

        Console.WriteLine("Hello World! This is the Fractions Project.");
        Console.Write("What is the numerator? ");
        string top = Console.ReadLine();

        Console.Write("What is the denominator? ");
        string bottom = Console.ReadLine();

        Console.WriteLine($"Your fraction is {top}/{bottom}.");
        */

        /*
        I think this is creating an instance of the class:
        ClassName objectName = new ClassName();
        In the example on "Objects - create an instance
        of types" on learn.microsoft.com, they use "p1"
        and "p2" as the object name. 
        Our Encapsulation lesson is doing this too for their
        "Person" class. I'm going to use "f1", etc., for 
        the object name because the class is "Fraction".
        */

        //Step 4: Create the Constructors
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);

    }
}