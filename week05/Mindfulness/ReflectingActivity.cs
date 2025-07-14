public class ReflectingActivity
{
    private string _name = "Reflecting";
    private string _description = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private int _duration = 0;
    public ReflectingActivity()
    {
        Console.Clear();
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
                GetRandomQuestion();
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
            "> 1. Why was this experience meaningful to you?",
            "> 2. Have you ever done anything like this before?",
            "> 3. How did you get started?",
            "> 4. How did you feel when it was complete?",
            "> 5. What made this time different than other times when you were not as successful?",
            "> 6. What is your favorite thing about this experience?",
            "> 7. What could you learn from this experience that applies to other situations?",
            "> 8. What did you learn about yourself through this experience?",
            "> 9. How can you keep this experience in mind in the future?"
        };
        int qIndex = displayQuestions.Next(_questions.Count);
        Console.WriteLine($"--- {_questions[qIndex]} ---");
        return _questions[qIndex];
    }
}