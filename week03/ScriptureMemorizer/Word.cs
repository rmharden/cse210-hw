public class Word // Like week to Job??
{
    public string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {

    }
    public bool IsHidden()
    {
        return false;
    }

    public void GetDisplayText()
    {
        // Needs to return the word if it is visiable or return underscores ____ if hidden.
        // How do I do that??? - ??? Would this work??
        // This is an if statement.
        if (_isHidden == false)
        {
            Console.Write($"{_text} ");
        }
        else
        {
            for (int i2 = 0; i2 < _text.Length; i2++)
            {
                Console.Write("_");
            }
        }
    }   
}