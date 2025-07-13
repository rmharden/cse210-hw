using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string response = "";
        while (response != "4")
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start the breathing activity");
            Console.WriteLine("2. Start the reflecting activity");
            Console.WriteLine("3. Start the listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            response = Console.ReadLine();
            if (response == "1")
            {
                Console.WriteLine("you chose 1");
                BreathingActivity ba1 = new BreathingActivity();
            }
            else if (response == "2")
            {
                Console.WriteLine("you chose 2");
                ReflectingActivity ra1 = new ReflectingActivity();
            }
            else if (response == "3")
            {
                Console.WriteLine("you chose 3");
            }
            else if (response == "4")
            {
                Console.WriteLine("\nThank you for using the Mindfulness Program");
            }
            else
            {
                Console.WriteLine("\nInvalid number.\n");
            }
        }
    }
}