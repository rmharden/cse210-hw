public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        // "This doesn't have an endVerse so we have to decided what to set _endVerse to equal to." (video at 8:52 of 16:27)
        // "_endVerse needs to be an int/some number" (video at 8:58 of 16:27)
        // "It's best to start this program by not using endVerse and just use thsi one. Just provide a single verse scripture and then go back and try to get the endVerse to work in GetDisplayText." (video at 9:40 of 16:27)

        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        // There is another "if-statement" but I don't know where it goes. I think it's here because the Word class has it here. (video at 9:39 of 16:27)
        // "There are two ways to return the string:" (video at 9:37 of 16:27)
        // 1 Nephi 3:7
        // 1 Nephi 3:7-9
        // This works! <3
        return _book + " " + _chapter + ":" + _verse;
    }
}