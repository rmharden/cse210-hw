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
    It has no parameters and initializes the number to 1/1.
    */
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
}