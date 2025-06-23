using System;

class Program
{
    static void Main(string[] args)
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
    } 
}