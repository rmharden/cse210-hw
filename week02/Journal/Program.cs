using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "";
        while (response != "5")
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            response = Console.ReadLine();
            if (response == "1")
            {
                PromptGenerator randomPrompt = new PromptGenerator();
                randomPrompt.GetRandomPrompt();
            }
            else if (response == "2")
            {

            }
            else if (response == "3")
            {

            }
            else if (response == "4")
            {

            }
            else if (response == "5")
            {

            }
            else
            {
                Console.WriteLine("\nInvalid number\n");
            }
        }
    }
}

/*

Welcome to the Journal Program!
Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do?

*/