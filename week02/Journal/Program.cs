using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //        Journal theJournal = new Journal();
        //        Entry anEntry = new Entry();
        //        anEntry.Display();

        //        Console.WriteLine("Hello World! This is the Journal Project.");

        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        Console.WriteLine("Here are all the journal prompts:");
        foreach (string prompt in prompts)
        {
            Console.WriteLine(prompt);
        }

    }
}