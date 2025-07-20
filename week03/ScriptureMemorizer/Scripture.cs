public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>(); // I keep having trouble with this. It tells me it's not assigned. I don't know why.

        foreach (string t in text.Split(" "))
        {
            Word w = new Word(t);
            _words.Add(w);
            // Console.Write($"{t} "); //test
        }

        HideRandomWords(6);
        // Console.WriteLine(GetDisplayText());
    }

    public void HideRandomWords(int numberToHide)
    {
        Random r = new Random();
        int wordIndex = r.Next(_words.Count);
        Word randomWord = _words[wordIndex];
        Console.WriteLine(randomWord);

        


        // Set the state of a randomly selected group of words to be hidden (video at 12:20 of 16:27)
        // Need to find a set of visible words (video at 12:20 of 16:27) The video says that "C# has a lot of "cool functions" like IsHidden, that will tell you if it returns false, it is visible." so we must be using IsHidden here somehow.
        // "Lots of ways we can do this, think about loops, think about if-statements, make sure you call that IsVisible function, etc." (video at 12:50 of 16:27
        // "You might want to start one out to select a random set of words to hide and you don't care if the words are already hidden yet, <- a good place to begin, and then try to go in there and say, I just want to hide visible ones." (video at 13:08 of 16:27)
        // "To hide the words, use the Hide function" (video at 13:30 of 16:27) When you do that, and you use GetDisplayText, Bro. Macbeth said it works.
    }

    // public string GetDisplayText()
    // {
    //     // foreach (Word w in _words)
    //     // {
    //     // return "\n" + _reference.GetDisplayText() + " " + w.GetDisplayText() + " ";
    //     // }
    //     //return "\n" + _reference.GetDisplayText();
    //     // return "";
    //     return "\n" + _reference.GetDisplayText();
    // }
}