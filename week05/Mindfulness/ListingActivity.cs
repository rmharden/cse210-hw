public class ListingActivity : Activity
{
    public ListingActivity(string name, string description, int duration) : base()
    {
        name = "Listing";
        description = "reflect on the good things in your life by having you list as many things as you can in a certain area.");

        base.DisplayStartingMessage(name, description, duration);

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();

        Console.Write("You may begin in: ");
        base.ShowCountDown();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine("> ");
                Console.ReadLine();
                Thread.Sleep(1000);
            }
        }
        int newListNumber = 0;
        Console.WriteLine($"You listed {newListNumber} items!");
        base.DisplayEndingMessage(duration, name);
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
        int pIndex = displayPrompt.Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[pIndex]} ---");
        return _prompts[pIndex];
    }
}