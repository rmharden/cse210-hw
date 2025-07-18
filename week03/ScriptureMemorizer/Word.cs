public class Word
{
    private string _text;
    private bool _isHidden;

    // "The role of the constructor is to initialize all of the data."
    public Word(string text)
    {
        _text = text;
        // This needs to be false in the beginning because the
        // scripture needs to be visible.
        _isHidden = false;
    }

    public void Hide()
    {
        // "The purpose of the Hide function is that the word should be hidden." (video: 7:19 of 16:27)
        // "All this is doing is changing the state." (video at 8:09 of 16:27)
        _isHidden = true;
    }

    public void Show()
    {

    }

    public bool IsHidden()
    {
        return false;
    }

    public string GetDisplayText()
    {
        // "Should return the word if visible or return underscores _____ if hidden." (video at 7:42 of 16:27)
        // "If you see "this or this," it sounds like an if statement" (Video 8:23 of 16:27)
        // This is testing the initialized data: (video at 6:11 of 16:27)
        return _text;
    }
}