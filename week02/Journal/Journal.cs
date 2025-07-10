using System.Data;

public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry) //
    {
        // DateTime theCurrentTime = DateTime.Now;
        // string dateText = theCurrentTime.ToShortDateString();

        // Entry anEntry = new Entry();
        // anEntry._date = dateText;

        // PromptGenerator pg1 = new PromptGenerator();
        // anEntry._promptText = pg1.GetRandomPrompt(); // This actually displays the prompt.

        // Console.WriteLine(anEntry._promptText);
        // Console.Write("> ");
        // anEntry._entryText = Console.ReadLine();

        // Console.WriteLine($"\nDate: {anEntry._date} - Prompt: {anEntry._promptText}");
        // Console.WriteLine($"{anEntry._entryText}\n");

        _entries.Add(newEntry);
        foreach (Entry e in _entries)
        {
            Console.WriteLine(e._date);
            Console.WriteLine(e._entryText);
            Console.WriteLine(e._promptText);
        }
    }
    public void DisplayAll()
    {
        Console.Clear();
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Date: {entry._promptText}");
            Console.WriteLine($"Date: {entry._entryText}");
        }
    }
}