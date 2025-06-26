public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        Reference reference = new Reference();
        reference._book = "John";
        reference._chapter = 3;
        reference._verse = 16;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Reference reference = new Reference();
        reference._book = "Proverbs";
        reference._chapter = 3;
        reference._verse = 5;
        reference._endVerse = 6;
    }

    //This is a getter.
    public string GetDisplayText()
    {
        return _book + " " + _chapter + ":" + _verse + "-" + _endVerse;
    }

}