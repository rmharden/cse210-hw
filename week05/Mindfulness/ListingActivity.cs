public class ListingActivity
{
    private string _name = "Listing";
    private string _description = "reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private int _duration = 0;
    private List<string> _usersEntries = new List<string>();

    public ListingActivity()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();

        Console.WriteLine("You may begin in: ");
        //base.ShowCountDown();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(60);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            _usersEntries.Add(Console.ReadLine());
        }
        Console.WriteLine();
        int usersNumber = _usersEntries.Count;
        Console.WriteLine($"You listed {usersNumber} items!");
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
        };
        int laIndex = displayPrompt.Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[laIndex]} ---");
        return _prompts[laIndex];
    }
}