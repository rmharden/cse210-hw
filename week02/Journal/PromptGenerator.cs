public class PromptGenerator
{
    public List<string> _prompts; // I don't know if I need this here.

    
    public string GetRandomPrompt()
    {
        Random displayPrompt = new Random();
        List<string> _prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        int i = displayPrompt.Next(_prompts.Count);
        //Console.WriteLine(_prompts[i]);
        return _prompts[i];
    }
}