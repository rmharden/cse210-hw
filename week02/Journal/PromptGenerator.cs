using System;
using System.Collections.Generic;

public class PromptGenerator
{
    //This was from the video demo but I don't know how
    //to use it.
    //public List<string> _prompts;

    public PromptGenerator()
    {
        //this makes the list of jounal prompts.
        List<string> promptsList = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        //random is the object.
        //Random is a class and it generates random indexes
        //for the questions in the list.
        Random random = new Random();
        /*
        I found this site to help me with writing code
        for the Random.Next Method.
        https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-9.0
        */
        int promptIndex = random.Next(promptsList.Count);
        string promptText = promptsList[promptIndex];

        //This will display the promptText.
        Console.WriteLine(promptText);

        //Temporarily returns an empty string for now.
        //return "";
    }
}