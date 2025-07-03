using System;
using System.Net;

// Handles most of the user interaction.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program!");

        // 1. Write
        // 2. Display
        // 3. Load
        // 4. Save
        // 5. Quit

        string response = "";
        while (response != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            response = Console.ReadLine();

            // 1. Write
            if (response == "1")
            {
                Console.WriteLine("");
                Console.WriteLine($"You chose {response}.");
                Console.WriteLine("");
            }
            // 2. Display
            else if (response == "2")
            {
                Console.WriteLine("");
                Console.WriteLine($"You chose {response}.");
                Console.WriteLine("");
            }
            // 3. Load
            else if (response == "3")
            {
                Console.WriteLine("");
                Console.WriteLine($"You chose {response}.");
                Console.WriteLine("");
                Journal theJournal = new Journal();

            }
            // 4. Save 
            else if (response == "4")
            {
                Console.WriteLine("");
                Console.WriteLine($"You chose {response}.");
                Console.WriteLine("");
            }
            // 5. Quit
            else if (response == "5")
            {
                Console.WriteLine("\nThank you for using the Journal Program!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("\nInvalid number.");
                Console.WriteLine("");
            }
        }

    }
}