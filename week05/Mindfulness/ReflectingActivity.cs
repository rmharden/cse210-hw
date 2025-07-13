public class ReflectingActivity
{
    public ReflectingActivity()
    {
        Console.WriteLine("Consider the following prompt:\n");
        //GetRandomPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.Read();

        Console.WriteLine("\nNow ponder on each of the following questions as the related to this experience.");
        Console.Write("You may begin in: ");
        //base.ShowCountDown();

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(20);
        while (DateTime.Now < endTime)
        {
            for (int ra1 = 5; ra1 > 0; ra1--)
            {
                //GetRandomQuestion();
                //base.ShowSpinner();
            }
        }

    }
}