using System.Runtime.InteropServices.Marshalling;

public class BreathingActivity
{
    private string _name = "Breathing";
    private string _description = "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    private int _duration = 0;
    
    public BreathingActivity()
    {
        Console.Clear();
        Console.WriteLine("\nWelcome to the Breathing Activity.");
        Console.WriteLine("\nby walking you through breathing in and out slowly.Clear your mind and focus on your breathing.");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(20);
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            for (int bi = 5; bi > 0; bi--)
            {
                Console.Write(bi);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.Write("Breathe out...");
            for (int bo = 6; bo > 0; bo--)
            {
                Console.Write(bo);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }
    }
}