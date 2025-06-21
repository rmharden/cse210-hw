using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts;

    List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    Console.WriteLine("Here are all the journal prompts:");
    
    foreach (string prompt in prompts)
    {
        Console.WriteLine(prompt);
    }    

    public string GetRandomPrompt()
    {

        //This is going to return an empty string.
        //It helps to add this for now so I can
        //run this code without a problem.
        //This returns an empty string for now.
        //return "";
    }
}