public class Scripture
{
    public Reference _reference;

    public List<Word> _words;

    public Scripture(Reference reference, string text)
    {

    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        //Returns an empty string.
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}