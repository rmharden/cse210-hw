using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise5 Project.");

        Console.WriteLine("Welcome to the Program!");

        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        

        Console.Write("What is your favorite number? ");
        string favorite = Console.ReadLine();
        int number = int.Parse(favorite);

        int square = number * number;

        Console.Write($"{name}, the square of your number is {square}.");
    }
}