using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

// Represents a single journal entry.
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();


        PromptGenerator _promptText = new PromptGenerator();
        Console.WriteLine($"Date: {_date} - {_promptText.GetRandomPrompt}");
        Console.WriteLine($"{_entryText}");

        //PromptGenerator _promptText = new PromptGenerator();
        //Console.WriteLine(_promptText.GetRandomPrompt());

        // Console.Write("> ");
        // string _entryText = Console.ReadLine();
    }
}





/*
using System;
using System.Data.SqlTypes;
using System.Globalization;

// Represents a single journal entry.
// Main responsibility is to hold data.
// Has it's own display method.
// Keeps track of the date, prompt text, and 
// the text entry itself.

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public Entry()
    {
        Entry newEntry = new Entry();
        _date = DateTime.Now.ToShortDateString();
        //_promptText = PromptGenerator.GetRandomPrompt();
        Console.WriteLine(_promptText);
        _promptText = Console.ReadLine();
    }
    public void Display(string dateText, string promptText, string entryText)
    {
        _date = dateText;
        _promptText = promptText;
        _entryText = entryText;

        Console.WriteLine($"Date: {dateText} - Prompt: {promptText} ");
        Console.WriteLine(entryText);       
    }
}
*/