using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string response = "";
        while (response != "5")
        {
            Journal theJournal = new Journal();
            Entry anEntry = new Entry();

            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");

            response = Console.ReadLine();

            // 1. Write
            if (response == "1")
            {
                // gets the current time
                DateTime theCurrentTime = DateTime.Now;
                anEntry._date = theCurrentTime.ToShortDateString();

                // displays a random journal prompt
                PromptGenerator randomPrompt = new PromptGenerator();
                anEntry._promptText = randomPrompt.GetRandomPrompt();
                anEntry._entryText = Console.ReadLine();
            }

            // 2. Display
            else if (response == "2")
            {
                theJournal.DisplayAll();
            }

            // 3. Load 
            else if (response == "3")
            {

            }

            // 4. Save
            else if (response == "4")
            {

            }

            // 5. Quit
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