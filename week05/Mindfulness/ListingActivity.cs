public class ListingActivity
{
    public ListingActivity()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        //GetRandomPrompt();
    }
    public string GetRandomPrompt()
    {
        Random displayPrompt = new Random();
        List<string> _prompts = new List<string>()
        {
            "> 1. Who are people that you appreciate?",
            "> 2. What are personal strengths of yours?",
            "> 3. Who are people that you have helped this week?",
            "> 4. When have you felt the Holy Ghost this month?",
            "> 5. Who are some of your personal heroes?",
            "> 6. What is your favorite thing about this experience?"            
        };
        
        return "";
    }
}