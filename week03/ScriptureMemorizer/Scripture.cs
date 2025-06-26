public class Scripture
{
    private Reference _reference;

    private List<Word> _words;

    private Scripture(Reference reference, string text)
    {
        
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        //Returns an empty string.
        return "";
        //return "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}