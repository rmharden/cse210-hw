
// "This class has a bunch of stuff to do. It is the "brain" of the program. (video at 10:02 of 16:27)

using System.Formats.Asn1;
using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    // private List<string> _words = new List<string>();

    public Scripture(Reference reference, string text)
    {

        // "In here we have to initialize a reference but we've been given a reference." (video at 10:05 of 16:27)
        // _reference = reference;
        _reference = reference;

        // "The words are a different matter." (video at 10:15 of 16:27)

        // Split up the words in text and store each as a word object in the list _words. (video at 10:25 of 16:27)
        // Example:
        // start of code testing
        // string name = "John Deere";
        // string[] words = name.Split(" "); // this is an array
        // Console.WriteLine(words[0]);
        // Console.WriteLine(words[1]); //end of code testing

        // Will need a loop (video at 11:30 of 16:27)
        // "Split and loop through each word" (video at 11:40 of 16:27)
        // Create a word object and put it into _words list (video at 11:50 of 16:27)

        // string reference1 = "John 3:16";
        // if (reference1 == "John 3:16")
        // {
        //     text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        // }
        // else
        // {
        //     text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        // }
        // List<string> _words = new List<string>();
        //     string[] words = text.Split(" ");

        //     foreach (string word in words)
        //     {
        //         _words.AddRange(words);
        //     }
        // }

        // Trying something different than the array:

        List<Word> _words = new List<Word>();
        foreach (string w in text.Split(" "))
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // This one is the hardest method to write out of all of them. Will spend the most time on. (video at 11:55 of 16:27)

        // Set the state of a randomly selected group of words to be hidden (video at 12:20 of 16:27)

        // Step 1:
        // Need to find a set of visible words (video at 12:20 of 16:27) The video says that "Word has a lot of "cool functions" like IsHidden, that will tell you if it returns false, it is visible." so we must be using IsHidden here somehow.

        //Step 2:
        // I need to randomly select numberToHide, whatever that value is, maybe passing that value through 3 or a 5, whatever value that is of those words (video at 12:45 of 16:27)

        // "Lots of ways we can do this, think about loops, think about if-statements, make sure you call that IsVisible function, etc." (video at 12:50 of 16:27
        // "You might want to start one out to select a random set of words to hide and you don't care if the words are already hidden yet, <- a good place to begin, and then try to go in there and say, I just want to hide visible ones." (video at 13:08 of 16:27)

        // Step 3:
        // "To hide the words, use the Hide function" (video at 13:30 of 16:27) When you do that, and you use GetDisplayText, Bro. Macbeth said it works.
    }

    public string GetDisplayText()
    {
        // Display the Reference, all the Words, (video at 13:50 of 16:27)
        // It doesn't worry about if the words are hidden because that is the job of GetDisplayText in the Word class.
        // Example: (video at 14:20 of 16:27)
        // Combine strings together with a plus sign:
        //string text = "abc" + "def"; //example


        // does not work
        //Console.WriteLine(_reference);
        //return _reference + " ";
        return _reference + " " + _words;
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}