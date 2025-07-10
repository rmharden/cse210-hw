using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Globalization;

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
            Console.WriteLine("\nPlease select one of the following choices:");
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
                Console.WriteLine("\nYou chose 1.\n");
                Journal theJournal = new Journal();
                Entry anEntry = new Entry();

                PromptGenerator pg1 = new PromptGenerator();
                pg1.GetRandomPrompt(); // This actually displays the prompt.
                

            }
            // 2. Display
            else if (response == "2")
            {
                Console.WriteLine("\nYou chose 2.\n");

            }
            // 3. Load
            else if (response == "3")
            {
                Console.WriteLine("\nYou chose 3.\n");
            }
            // 4. Save 
            else if (response == "4")
            {
                Console.WriteLine("\nYou chose 4.\n");
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