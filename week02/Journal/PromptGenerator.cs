using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

// Supplies random prompts whenever needed.

public class PromptGenerator
{
    public String GetRandomPrompt()
    {
        List<string> _prompts = new List<string>()
        {
            "1. Who was the most interesting person I interacted with today?",
            "2. What was the best part of my day?",
            "3. How did I see the hand of the Lord in my life today?",
            "4. What was the strongest emotion I felt today?",
            "5. If I had one thing I could do over today, what would it be?"
        };
        Random random = new Random();
        int pIndex = random.Next(_prompts.Count);
        string promptText = _prompts[pIndex];
        Console.WriteLine(promptText); // This was creating a duplicate prompt.
        return promptText;
    }
}