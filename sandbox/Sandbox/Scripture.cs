public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private string _text;
    private string _text2;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _text2 = _text;
        List<Word> _words = new List<Word>();
        foreach (string t in text.Split(" "))
        {
            Word w = new Word(t);
            _words.Add(w);            
        }
    }
    public Scripture(Reference reference, string text, string text2)
    {
        _reference = reference;
        _text = text;
        _text2 = text2;
        string multiVerse = text + " " + text2;
        List<Word> _words2 = new List<Word>(); //not sure about this
        foreach (string m in multiVerse.Split(" "))
        {
            Word w = new Word(m);
            _words2.Add(w);            
        }
    }
    public string GetDisplayText()
    {
        if (_text2 == _text)
        {
            Reference r1 = new Reference("John", 3, 16);
            return r1.GetDisplayText() + "\n" + _text;
        }
        else
        {
            Reference r2 = new Reference("Proverbs", 3, 4, 6);
            return r2.GetDisplayText() + "\n" + _text + " " + _text2;
        }
    }
}
