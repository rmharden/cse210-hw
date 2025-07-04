using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

// Supplies random prompts whenever needed.
public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    public string GetRandomPrompt()
    {
        Random random = new();
        int promptIndex = random.Next(_prompts.Count);
        string promptText = _prompts[promptIndex];
      
        return promptText;
    }
}