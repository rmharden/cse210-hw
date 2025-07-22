public class Scripture()
{
    private string _text;
    private string _text2;
    public Scripture(string text)
    {
        _text = text;
        _text2 = _text;
    }
    public Scripture(string text, string text2)
    {
        _text = text;
        _text2 = text2;
    }
    public string GetDisplayText()
    {
        if (_text2 == _text)
        {
            return _text;
        }
        else
        {
            return _text + " " + _text2;
        }
    }
}
