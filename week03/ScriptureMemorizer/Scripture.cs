
// "This class has a bunch of stuff to do. It is the "brain" of the program. (video at 10:02 of 16:27)

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {

        // "In here we have to initialize a reference but we've been given a reference." (video at 10:05 of 16:27)
        // "The words area different matter." (video at 10:15 of 16:27)
        // Split up the words in text and store each as a word object in the list _words. (video at 10:25 of 16:27)
        // Example:
        string name = "John Deere";
        string[] words = name.Split(" ");
        Console.WriteLine(words[0]);
        Console.WriteLine(words[1]);

        // Will need a loop (video at 11:30 of 16:27)
        // "Split and loop through each word" (video at 11:40 of 16:27)
        // Create a word object and put it into _words list (video at 11:50 of 16:27)

    }

    public void HideRandomWords(int numberToHide)
    {
        // This one is the hardest method to write out of all of them. Will spend the most time on. (video at 11:55 of 16:27)

        // Set the state of a randomly selected group of words to be hidden (video at 12:20 of 16:27)

        // Step 1:
        // Need to find a set of visible words (video at 12:20 of 16:27) The video says that "Word has a lot of "cool functions" like IsHidden, that will tell you if it returns false, it is visible." so we must be using IsHidden here somehow.

        //Step 2:
        // I need to randomly select numberToHide, whatever that value is, maybe passing that value through 3 or a 5, whatever value that is of those words (video at 12:45 of 16:27)
        // Lots of ways we can do this, think about loops, think about if-statements, make sure you call that IsVisible function, etc. (video at 12:50 of 16:27
        // "You might want to start one out to select a random set of words to hide and you don't care if the words are already hidden yet, <- a good place to begin, and then try to go in there and say, I just want to hide visible ones." (video at 13:08 of 16:27)


    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}