using System;
using System.Runtime.ExceptionServices;

public class Journal
{
    
    List<Entry> _entries = new List<Entry>();
    public Journal()
    {

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

    }
}