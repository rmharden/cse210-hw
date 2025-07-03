using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program!");

        //Journal theJournal = new Journal();
        //Entry anEntry = new Entry();
        //anEntry.Display();

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

            if (response == "1")
            {
                Console.WriteLine("");
                Console.WriteLine($"You chose {response}.");
                Console.WriteLine("");
            }
            else if (response == "2")
            {
                Console.WriteLine("");
                Console.WriteLine($"You chose {response}.");
                Console.WriteLine("");
            }
            else if (response == "3")
            {
                Console.WriteLine("");
                Console.WriteLine($"You chose {response}.");
                Console.WriteLine("");
            }
            else if (response == "3")
            {
                Console.WriteLine("");
                Console.WriteLine($"You chose {response}.");
                Console.WriteLine("");
            }
            else if (response == "4")
            {
                Console.WriteLine("");
                Console.WriteLine($"You chose {response}.");
                Console.WriteLine("");
            }
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