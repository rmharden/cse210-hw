public class ListingActivity : Activity
{
    public ListingActivity()
    {
        Console.Clear();
        Console.WriteLine("\nWelcome to the Listing Activity.");
        Console.WriteLine("\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Console.Write("\nHow long, in seconds, would you like for your session? ");
        string userInput = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Get ready...");

        Console.WriteLine("--- This is where the random propmt will go. ---");
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("You may begin in: ");
        Console.WriteLine("> ");

        int newListNumber = 0;
        Console.WriteLine($"You listed {newListNumber} items!");

        Console.WriteLine("\nWell done!!");

        Console.WriteLine($"\nYou have completed another {userInput} seconds of the Listing Activity.\n");
        Console.Read();
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
   
