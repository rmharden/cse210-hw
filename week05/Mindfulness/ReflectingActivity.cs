using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
public class ReflectingActivity : Activity
{
    public ReflectingActivity()
    {
        Console.Clear();
        Console.WriteLine("\nWelcome to the Reflecting Activity.");
        Console.WriteLine("\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Console.Write("\nHow long, in seconds, would you like for your session? ");
        string userInput = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine("The spinner is under this");
        Console.Read();

        Console.WriteLine("Consider the following prompt:\n");
        GetRandomPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.Read();

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may being in: (will display numbers counting down here)");
        Console.Read();

        Console.Clear();
        GetRandomQuestion();
        Console.WriteLine("This spinner is on the same line after the question here.");
        Console.Read();
        Console.WriteLine("The program is counting and then it asks another question.");
        GetRandomQuestion();

        Console.Read();

        Console.WriteLine("\nWell done!!");

        Console.WriteLine($"\nYou have completed another {userInput} seconds of the Reflecting Activity.\n");
        Console.WriteLine("The spinner is shown here too.");
        Console.Read();
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
        Random displayQuestion = new Random();
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
        int qIndex = displayQuestion.Next(_questions.Count);
        Console.WriteLine($"--- {_questions[qIndex]} ---");
        return _questions[qIndex];
    }
}

/*
I used this link to learn how to do random prompt generators:
https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-9.0
*/