public class Scripture // Like week 2 Resumes?
{
    public Reference _reference;
    public string _text;

    public List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;

        // Split up the words in text and store each as a word object in the list _words:
        // example from BYUI, Chad Macbeth: 
        // string name = "John Deere";
        // string[] words = name.Split(" ");
        // Console.WriteLine(words[0]);
        // Console.WriteLine(words[1]);

        // split and then loop through each word
            // create word object and put it into _words:
        string[] splitText = text.Split(" ");
        for (int i = 0; i < splitText.Length; i++)
        {
            // Console.Write($"{splitText[i]} ");
            Word aWord = new Word(splitText[i]);

            _words.Add(aWord);
        }

            // vhttps://learn.microsoft.com/en-us/dotnet/csharp/misc/cs1503?f1url=%3FappId%3Droslyn%26k%3Dk(CS1503)
    }
    public void HideRandomWords(int numberToHide)
    {
        // Goal: Set the state of randomly selecetd group of words to be hidden.

        // Need to find find a set of visible words... Chad Macbeth said that the Word class as IsHidden... so how do I use that here? A loop? How do I use that? That is confusing.. :`(

        // Need to randomly select a 'numberToHide' of those words.
        // loops, if statements, call IsVisible function.

        // Use the Hide function - to hide visible words.


        // I chose to make the number of words hidden random... though, how do I pick random words??

        Random randNumber = new Random();
        int hideNo = randNumber.Next(1, 3);

        numberToHide = hideNo;

        Random randomWord = new Random();
        int i = randomWord.Next(_words.Count);
        //Word useThisWord = _words[i];
        // string aHiddenWord = useThisWord.ToString();

        // //int lettersToHide = aHiddenWord.Length;
        // // hidding letters in a word:
        // for (int i2 = 0; i2 < aHiddenWord.Length; i2++)
        // {
        //     Console.Write("_");
        // }
        // Console.WriteLine();

        // This was from Chad Macbeth's video on BYU-I Videos:
        // https://video.byui.edu/media/t/1_86gjzj20


        // https://learn.microsoft.com/en-us/dotnet/api/system.string.tostring?view=net-9.0

        // https://learn.microsoft.com/en-us/dotnet/api/system.string.length?view=net-9.0
    }
    public void GetDisplayText() //this is supposed to be a string
    {
        
        Console.WriteLine(_reference.GetDisplayText());
        foreach (Word word in _words)
        {
            word.GetDisplayText();
        }
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}