using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "";
        while (response != "5")
        {
            Console.Clear();
            PromptGenerator randomPrompt = new PromptGenerator();
            randomPrompt.GetRandomPrompt();
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