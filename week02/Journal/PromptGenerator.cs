using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public string _prompts;
    public List<string> prompt = new List<string>();

    //I think this is a constructor. A internet search says
    //that contructors are methods that are named the same
    //as the class. I think I'm confused. :(
    public PromptGenerator()
    {
        prompt.Add("Who was the most interesting person I interacted with today?");
        prompt.Add("What was the best part of my day?");
        prompt.Add("How did I see the hand of the Lord in my life today?");
        prompt.Add("What was the strongest emotion I felt today?");
        prompt.Add("If I had one thing I could do over today, what would it be?");
    }

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();

    }
}