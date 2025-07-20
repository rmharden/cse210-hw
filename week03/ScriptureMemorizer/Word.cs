public class Word // Like week to Job??
{
    public string _text;

    public Word(string text)
    {
        _text = text;             
    }

    public void Hide()
    {

    }

    public void Display()
    {
        Console.Write($"{_text} ");
    }
    
}