public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        //I'm not sure this is all that is displayed yet.
        //I don't know if the Entry class is only for
        //the menu option 2.
        Console.WriteLine($"Date: {_date} - {_promptText}");
        Console.WriteLine(_entryText);
    }

}