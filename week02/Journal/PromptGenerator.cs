using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> prompts = new List<string>();

    //I think this is a constructor. A internet search says
    //that contructors are methods that are named the same
    //as the class. I think I'm confused. :(
    public PromptGenerator()
    {
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
    }

}