
using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("John", 3, 16);
        Scripture s1 = new Scripture(r1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        // Reference r2 = new Reference("Proverbs", 3, 5, 6);
        // Scripture s2= new Scripture(r2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        // // I am testing the word class
        // Word w = new Word("loved");
        // {
        //     Console.WriteLine(w.GetDisplayText());
        // }


        string userResponse = "";

        while (userResponse.ToLower() != "quit")
        {
            //Console.Clear();

            //Console.WriteLine(r1.GetDisplayText());
            // Console.WriteLine(s1.GetDisplayText());
   
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:\n");
            userResponse = Console.ReadLine();
        }
    }
}


// Watched video:
// BYU - Idaho Videos CSE 210: Week 3 Assignment 
// from Chad Macbeth May, 7th, 2024
// https://video.byui.edu/media/t/1_sv3gxgzs/259941952

// I found this about being able to read the Enter key from a user:
// https://learn.microsoft.com/en-us/dotnet/api/system.console.readkey?view=net-9.0