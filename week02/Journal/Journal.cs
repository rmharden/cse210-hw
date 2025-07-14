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
    public void SaveToFile(string file)
    {
        // Console.WriteLine("What is the filename?");
        // Console.WriteLine("> ");
        Console.WriteLine("");

    }

    public void LoadFromFile(string file)
    {
        // Console.WriteLine("What is the filename you would like to load?");
        // Console.WriteLine("> ");
        // file = Console.ReadLine(); 
    }
}