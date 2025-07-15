using System;
using System.Collections.Generic;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        _date = DateTime.Now.ToShortDateString();
        PromptGenerator pg = new PromptGenerator();
        _promptText = pg.GetRandomPrompt();
        Console.WriteLine(_promptText);
        _entryText = Console.ReadLine();
    }

    public Entry(string line)
    {
        Deserialize(line);
    }

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _promptText = prompt;
        _entryText = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} Prompt: {_promptText}\n{_entryText}");
    }

    public string Serialize()
    {
        return $"{_date}~|~{_promptText}~|~{_entryText}";
    }

    public void Deserialize(string line)
    {
        string[] parts = line.Split("~|~");
        if (parts.Length < 3)
        {
            Console.WriteLine("Bad form");
        }
        else
        {
            _date = parts[0];
            _promptText = parts[1];
            _entryText = parts[2];
        }
    }
}