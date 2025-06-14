using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise3 Project.");

        //Part 1 and 2
        //Console.Write("What is the magic number? ");
        //int magicnumber = int.Parse(Console.ReadLine());

        //Part 3

        Random randomnumber = new Random();
        int magicnumber = randomnumber.Next(1, 101);

        int guess = -1;

        while (guess != magicnumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicnumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicnumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}