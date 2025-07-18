
using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Clear();
        // Console.WriteLine();

        Reference r1 = new Reference();

        Reference r2 = new Reference("John", 3, 16);

        Reference r3 = new Reference("Proverbs", 3, 5, 6);

        string userResponse = "";

        while (userResponse.ToLower() != "quit")
        {
            Console.Clear();

            Console.WriteLine(r1.GetDisplayText());
            Console.WriteLine(r2.GetDisplayText());
            Console.WriteLine(r3.GetDisplayText());

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:\n");
            userResponse = Console.ReadLine();
        }
    }
}
