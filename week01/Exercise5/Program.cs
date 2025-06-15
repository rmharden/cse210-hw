using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        DisplayProgramMessage();

        string usersName = AskUsersName();
        int usersFavoriteNo = AskUsersNumber();

        int squaredNumber = SquareNumber(squaredNumber);

        DisplayResult(usersName, squaredNumber);


    }

    static void DisplayProgramMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string AskUsersName(string name)
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
    }

    static int AskUsersNumber()
    {

        Console.Write("What is your favorite number? ");
        string favorite = Console.ReadLine();
        int number = int.Parse(favorite);

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;

    }
    static void DisplayResult(string name, int square)
    {
        Console.Write($"{name}, the square of your number is {square}.");
    }
}