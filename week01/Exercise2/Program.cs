using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string gradepercentage = Console.ReadLine();
        int number = int.Parse(gradepercentage);

        string lettergrade = "";

        if (number >= 90)
        {
            lettergrade = "A";
        }
        if (number >= 80)
        {
            lettergrade = "B";
        }
        else if (number >= 70)
        {
            lettergrade = "C";
        }
        else if (number >= 60)
        {
            lettergrade = "D";
        }
        else
        {
            lettergrade = "F";
        }

        Console.WriteLine($"Your grade is: {lettergrade}");

        if (number >= 70)
        {
            Console.WriteLine("You passed!");
        }

        else
        {
            Console.WriteLine("You did not pass.");
        }

    }
}