using System.IO;

// Stores a list of journal entries.

public class Journal
{
    public void AddEntry(Entry newEntry)
    {
        List<string> _entries = new List<string>();
        newEntry.Add(Entry._entryText);
        foreach (Entry newEntry in _entries)
        {
            Console.WriteLine(newEntry._filename);
        }        
    }
    public void DisplayAll()
    {
        Console.WriteLine();
    }
    public void SaveToFile(string file)
    {

    }
    public void LoadFromFile(string file)
    {

    }
}