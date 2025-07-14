public class PromptGenerator
{
 
    public string GetRandomPrompt()
    {
        
        Random prompt = new Random();
        List<string> _prompts = new List<string>()
        {
            "1. Who was the most interesting person I interacted with today?",
            "2. What was the best part of my day?",
            "3. How did I see the hand of the Lord in my life today?",
            "4. What was the strongest emotion I felt today?",
            "5. If I had one thing I could do over today, what would it be?"
        };
        int i = prompt.Next(_prompts.Count);
        Console.WriteLine(_prompts[i]);
        return _prompts[i];
    }

}