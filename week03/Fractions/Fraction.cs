using System;

/*
W03 Learning Activity: Encapsulation

Followed the class diagram for the setup.
*/

//Creates the Fraction class
public class Fraction
{
    /*
    This is a private member variable/atrribute 
    for the numerator. 
    */
    private int _top;
    /*
    This is a private member variable/attribute 
    for the denominator.
    */
    private int _bottom;

    /*
    This is the Fraction constructor, I think.
    It "has no parameters and initializes the number to 1/1."
    Is this the "no-argument constructor"?
    */
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        /*This is allowing me to see that the fractions
        were created for the constructor.*/
        Console.WriteLine($"{_top}/{_bottom}");
    }

    /*
    This is the constructor that has one parameter for
    the top and initializes the denominator as "1".
    "wholeNumber" is a value that is passed through
    the constructor for the _top member variable. The
    member variable name is given to us from the Fraction
    class diagram and is passed through the constructor.
    */
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
        /*This is allowing me to see that the fractions
        were created for the constructor.*/
        Console.WriteLine($"{_top}/{_bottom}");
    }

    /*
    This constructor allows the top and bottom parameters
    to be passed through it. I think, they are being
    called from the Program.cs file, right?
    */
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        /*This is allowing me to see that the fractions
        were created for the constructor.*/
        Console.WriteLine($"{top}/{bottom}");
    }

}