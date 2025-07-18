public class Scripture
{
    private Reference _reference;

    //private List<Word> _words; // I need to make the type Word but I don't know how to add the objects to the list when they become an array.
    private List<string> _words = new List<string>();

    private Scripture(Reference reference, string text)
    {
        _reference = reference; //This I am not sure... Do I call Reference here? or is it adding the info, because display text never works from here.

        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            _words.AddRange(words);
            Console.WriteLine(word[0]);
        }
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        //Returns an empty string.
        //return"";

        return _reference + " ";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}