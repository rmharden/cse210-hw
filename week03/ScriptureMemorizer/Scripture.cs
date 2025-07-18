public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public bool IsCompletelyHidden()
    {
        return true;
    }

}