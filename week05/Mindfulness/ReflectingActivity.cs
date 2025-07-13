public class ReflectingActivity
{
    public ReflectingActivity()
    {
        Console.WriteLine("Consider the following prompt:\n");
        GetRandomPrompt();
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
                Thread.Sleep(1000);
            }
        }
    }
    public string GetRandomPrompt()
    {
        Random displayPrompt = new Random();
        List<string> _prompts = new List<string>()
        {
            "1. Think of a time when you stood up for someone else.",
            "2. Think of a time when you did something really difficult.",
            "3. Think of a time when you helped someone in need.",
            "4. Think of a time when you did something truly selfless."
        };
        int pIndex = displayPrompt.Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[pIndex]} ---");
        return _prompts[pIndex];
    }
    public string GetRandomQuestion()
    {
        Random displayQuestions = new Random();
        List<string> _questions = new List<string>()
        { 
            
        };
        int qIndex = displayQuestions.Next(_questions.Count);
        Console.WriteLine($"--- {_questions[qIndex]} ---");
        return _questions[qIndex];
    }
}