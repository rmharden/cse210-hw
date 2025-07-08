public class ListingActivity : Activity
{
    public ListingActivity()
    {
        Console.Clear();
        Console.WriteLine("\nWelcome to the Listing Activity.");
        Console.WriteLine("\nThis activity will help you reflect on the good things \nin your life by having you list as \nmany things as you can in a certain area.");

        Console.Write("\nHow long, in seconds, would you like for your session? ");
        string userInput = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.Read();

        Console.WriteLine("Breathe in...");
        Console.WriteLine("Now breathe out...");

        Console.WriteLine("\nWell done!!");

        Console.WriteLine($"\nYou have completed another {userInput} seconds of the Breathing Activity.\n");
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
   
