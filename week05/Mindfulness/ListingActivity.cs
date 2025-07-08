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
}
    /*
        private List<string> userEntries = new List<string>();
        public string GetListFromUser()
        {
            Console.WriteLine("Type an entry or type 'quit' to finish");
            string userEntry = Console.ReadLine();
            userEntries.Add(userEntry);

            foreach (string e in userEntries)
            {
                Console.WriteLine(e);
            }
            return GetListFromUser();
        }
    */
   
