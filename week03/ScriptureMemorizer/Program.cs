
using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Clear();
        // Console.WriteLine();

        Reference r1 = new Reference();
        Scripture s1 = new Scripture(r1, "");

        Reference r2 = new Reference("John", 3, 16);
        Scripture s2 = new Scripture(r2, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        Reference r3 = new Reference("Proverbs", 3, 5, 6);
        Scripture s3 = new Scripture(r3, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        string userResponse = "";

        while (userResponse.ToLower() != "quit")
        {
            Console.Clear();

            Console.WriteLine(r1.GetDisplayText());
            Console.WriteLine(s1.GetDisplayText());

            Console.WriteLine(r2.GetDisplayText());
            Console.WriteLine(s2.GetDisplayText());
            
            Console.WriteLine(r3.GetDisplayText());
            Console.WriteLine(s3.GetDisplayText());

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:\n");
            userResponse = Console.ReadLine();
        }
    }
}
