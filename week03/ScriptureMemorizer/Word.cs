public class Word // Like week to Job??
{
    public string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {

    }
    public void Show()
    {
        
    }
    public bool IsHidden()
    {
        return false;
    }

    public void Display()
    {
        Console.Write($"{_text} ");
    }
    
}