using System.Security.Cryptography.X509Certificates;

public class Word
{
    private string _text;
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
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return true;
    }

    //This is a getter.
    public string GetDisplayText()
    {
        //Returns an empty string.
        return _text;
    }
}