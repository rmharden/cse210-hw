using System;
using System.Collections.Generic;

public class PromptGenerator
{
    //This was from the video demo but I don't know how
    //to use it.
    //public List<string> _prompts;

    public PromptGenerator()
    {

        List<string> promptsList = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();

        int promptIndex = random.Next(promptsList.Count);
        string promptText = promptsList[promptIndex];


        Console.WriteLine(promptText);

        //Temporarily returns an empty string for now.
        //return "";
    }
}