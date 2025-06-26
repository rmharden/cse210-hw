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

        //This was my original stes for step four:
        /*
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);
        */


        /*Step 5: Create the Getters and Setters
        1. verifing that I can call on the methods and get
        the correct values, using setters to change the
        values and getters to retrieve the new values and
        display them to the console.
        */

        //Attempt for Step 5, No. 2
        /*
        Fraction f1 = new Fraction();
        f1.GetFractionString();
        f1.GetDecimalValue();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine();

        Fraction f2 = new Fraction(6);
        f2.GetFractionString();
        f2.GetDecimalValue();
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine();

        Fraction f3 = new Fraction(6, 7);
        f3.GetFractionString();
        f3.GetDecimalValue();
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine();
        */


        //Step 6: Create methods to return the
        //representations.
        Fraction f1 = new Fraction();
        f1.GetFractionString();
        f1.GetDecimalValue();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction();
        f2.GetFractionString();
        f2.GetDecimalValue();
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Step. 6, no. 1.
        Fraction f3 = new Fraction(3, 4);
        f3.GetFractionString();
        f3.GetDecimalValue();
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        //Step 6, no. 3.
        Fraction f4 = new Fraction(1, 3);
        f4.GetFractionString();
        f4.GetDecimalValue();
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }    
}