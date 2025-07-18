using System.Security.Cryptography.X509Certificates;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        // This needs to be false in the beginning because the scripture needs to be visible.
        _isHidden = false;
    }

    public void Hide()
    {
        // This will change the state. The word will be hidden.
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = true; // not sure here
    }

    public bool IsHidden()
    {
        return false;
    }

    //This is a getter.
    public string GetDisplayText()
    {
        // this needs an if statement.
        //Returns an empty string.
        return _text;
    }
}