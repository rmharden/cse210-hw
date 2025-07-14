using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.Marshalling;
using System.IO;

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
        foreach (Entry e in _entries)
        {
            Console.WriteLine($"Date: {e._date} - Prompt: {e._entryText}");
            Console.WriteLine($"{e._entryText}\n");
        }
    }
    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {

    }
}