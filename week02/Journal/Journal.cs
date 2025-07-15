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
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}~|~{e._entryText}~|~{e._promptText}");
                // outputFile.WriteLine($"Date: {e._date} - Prompt: {e._promptText}");
                // outputFile.WriteLine("{e._entryText}");
            }
            Console.WriteLine("File Saved!");
        }
    }

    public void LoadFromFile(string file)
    {
        Console.WriteLine("Reading from file...");
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._entryText = parts[1];
            newEntry._promptText = parts[2];

            _entries.Add(newEntry);
        }
    }
}