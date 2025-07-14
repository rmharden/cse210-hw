using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.Marshalling;

public class Journal
{

    List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }
    public void AddEntry(Entry anEntry)
    {
        _entries.Add(anEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
            Console.WriteLine($"Date: {entry._entryText}\n");
        }
    }
    public void SaveToFile()
    {
        Console.WriteLine("What is the filename?");
        Console.WriteLine("> ");

    }

    public void LoadToFile()
    {
        Console.WriteLine("What is the filename you would like to load?");
        Console.WriteLine("> ");
    }
}