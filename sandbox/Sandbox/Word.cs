public class Word
{
    private string _text;
    public Word(string text)
    {
        _text = text;
    }
    public string GetDisplay()
    {
        return _text;
    }
}