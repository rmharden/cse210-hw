public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>(); // I keep having trouble with this. It tells me it's not assigned. I don't know why.

        foreach (string t in text.Split(" "))
        {
            Word w = new Word(t);
            _words.Add(w);
            // Console.Write($"{t} "); //test
        }
    }
    public string GetDisplayText()
    {
        // this is only printing one word. why?
        foreach (Word w in _words)
        {
            return "\n" + _reference.GetDisplayText() + " " + w.GetDisplayText() + " ";
        }
        return "";
    }
}