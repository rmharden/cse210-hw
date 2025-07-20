using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // This displays even thought I don't have it displaying... It must mean that the getdisplay at the end of this class runs automatically... do I have a console.writeline somewhere?
        Reference r1 = new Reference("John", 3, 16);
        Scripture s1 = new Scripture(r1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        string userResponse = "";

        while (userResponse.ToLower() != "quit")
        {
            //Console.Clear();
            List<Word> _words = new List<Word>();
            string _scripture = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
            string[] s = _scripture.Split(" ");
            // why does this specifically print the actual text of each item???
            foreach (string word in s)
            {
                _words.Add(new Word(word));
                // This shows the words
                //Console.Write($"{word} ");
            }
            Console.WriteLine(_words.Count);

            // foreach (Word w in _words)
            // {
            //     Console.WriteLine(w);
            // }
            for (int i = 0; i < _words.Count; i++)
            {
                Console.Write(_words[i]);
            }



            // this also displays the object "Word" and not the word
                // Word firstWord = _words[0]; Console.Write(firstWord);
                // Console.Write(_words[1]);
                // This prints numbers/ the item index in a list
                // for (int i = 0; i < _words.Count; i++)
                // {
                //     Console.Write($"{i} ");
                // }
                // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/iterators
                // This also displays the object type for every item, not the item:
                // foreach (Word w in _words)
                // {
                //     Console.Write(w.ToString() + " ");
                // }




                // Found something about "new":
                // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.add?view=net-9.0

                // Random r = new Random();
                // int wordIndex = r.Next(_words.Count);
                // Word randomWord = _words[wordIndex];
                // Console.WriteLine(randomWord);
                Console.WriteLine("\nPress enter to continue or type 'quit' to finish:\n");
            userResponse = Console.ReadLine();
        }     
    }
}
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Reference r1 = new Reference("John", 3, 16);
//         Scripture s1 = new Scripture(r1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

//         // Reference r2 = new Reference("Proverbs", 3, 5, 6);
//         // Scripture s2= new Scripture(r2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

//         // // I am testing the word class
//         // Word w = new Word("loved");
//         // {
//         //     Console.WriteLine(w.GetDisplayText());
//         // }


//         string userResponse = "";

//         while (userResponse.ToLower() != "quit")
//         {
//             //Console.Clear();

//             //Console.WriteLine(r1.GetDisplayText());
//             // Console.WriteLine(s1.GetDisplayText());
   
//             Console.WriteLine("\nPress enter to continue or type 'quit' to finish:\n");
//             userResponse = Console.ReadLine();
//         }
//     }
// }


// // Watched video:
// // BYU - Idaho Videos CSE 210: Week 3 Assignment 
// // from Chad Macbeth May, 7th, 2024
// // https://video.byui.edu/media/t/1_sv3gxgzs/259941952

// // I found this about being able to read the Enter key from a user:
// // https://learn.microsoft.com/en-us/dotnet/api/system.console.readkey?view=net-9.0