
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("");
        // This is testing the initialized data in Word.cs: (video at 6:11 of 16:27)
        // Word w = new Word("truth");
        // Console.WriteLine(w.GetDisplayText()); //end of this test

        // For testing purposes, create some objects: (video at 14:30 of 16:27)
        // "Main function will have your main loop and will be "listening" for the enter key and stuff like that" (video at 14:46 of 16:27)

        // Probably need to create a scripture: (video at 14:50 of 16:27)
        // Then it needed a reference so we created a Reference: (video at 15:14 of 16:27)
        Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference, "I will go and do...");

        // Once implemented, it will split up all of the scripture passed through, the "I will go and do..." into parts(video at 15:20 of 16:27)

        // We will have our loop here (video at 15:29 of 16:27)
        // loop
        // display, hide, check if we need to quit
        // Use the functions in the Scripture class (video at 15:50 of 16:27)

        Console.WriteLine("\nThis is what it looks like when the program runs:");

        Console.WriteLine("\nProverbs 3:5-6 Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.\n");

        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        Console.Read();
        // I'm not sure, but I think this is what I use if I want the user to press enter.

        Console.WriteLine();

        Console.Clear();

        Console.WriteLine("\nAfter the user presses enter, the console is cleared and it shows some of the words missing, lile this:\n");

        Console.WriteLine("\nProverbs 3:5-6 Trust in the ____ ____ ___ thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.\n");

        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        Console.Read();

        Console.WriteLine();

        Console.Clear();

        Console.WriteLine("\nThis shows what it looks like after pressing enter few more times\n");

        Console.WriteLine("\nProverbs 3:5-6 Trust in the ____ ____ ___ thine heart; and lean ___ ____ thine own understanding. __ ___ thy ways acknowledge him, and he ____ ______ thy ______\n");

        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        Console.Read();

        Console.WriteLine();

        Console.Clear();


        Console.WriteLine("\nThis is what it looks like when the scripture is empty:\n");

        Console.WriteLine("\nProverbs 3:5-6 _____ __ ___ ____ ____ ___ _____ ______ ___ ____ ___ ____ _____ ___ ______________ __ ___ ___ ____ ___________ ____ ___ __ ____ ______ ___ ______\n");

        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        Console.Read();

        Console.WriteLine();


    }
}


// "Start out small, do word, then reference, when there is a lot of you have to do start out with the hidden words and just pick one hidden word or maybe just hade the first word, whatever it is start out slow and build upon it, incremental succcess..."  (video at 16:05 of 16:27)

/*

John 3:16

For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.

Proverbs 3:5-6

Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.

*/



// Watched video:
// BYU - Idaho Videos CSE 210: Week 3 Assignment 
// from Chad Macbeth May, 7th, 2024
// https://video.byui.edu/media/t/1_sv3gxgzs/259941952