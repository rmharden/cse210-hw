using System;

public class Program
{
    static void Main(string[] args)
    {

        // Moved here because I couldn't do the is completely hidden without moving it.
        //Word aWord = new Word();
        Reference r1 = new Reference("John", 3, 16);
        Scripture s1 = new Scripture(r1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        Random randNumber = new Random();
        int hideNo = randNumber.Next(1, 3);

        // Loop, Display, Hide, check if we need to quit


        // this doesn't work like I think it should.
        // while (userResponse != "quit" || s1.IsCompletelyHidden() != false)

        string userResponse = "";
// I don't think this works exactly if I change IsCompletelyHidden to true it doesn't end.
        while (s1.IsCompletelyHidden() != false || userResponse.ToLower() != "quit")
        {
            Console.Clear();

            s1.HideRandomWords(hideNo);

            s1.GetDisplayText();

            Console.WriteLine();
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:\n");

            userResponse = Console.ReadLine();
        }
    }
}

            
            // Random randNumber = new Random();
            // int hideNo = randNumber.Next(1, 3);
            // s1.HideRandomWords(hideNo);

            // Console.Clear();

            // s1.GetDisplayText();

            // Console.WriteLine();
            // Console.WriteLine("\nPress enter to continue or type 'quit' to finish:\n");
            // userResponse = Console.ReadLine();
        //}
        // Console.ReadKey();
  

//     public class Word // Like week to Job??
//     {
//         public string _text;

//         public Word(string text)
//         {
//             _text = text;
//         }

//         public void Hide()
//         {

//         }

//         public void Display()
//         {
//             Console.Write($"{_text} ");
//         }

//     }
//     public class Scripture // Like week 2 Resumes?
//     {
//         public string _text;

//         public List<Word> _words = new List<Word>();

//         public Scripture(string text)
//         {
//             _text = text;

//             string[] splitText = text.Split(" ");
//             for (int i = 0; i < splitText.Length; i++)
//             {
//                 // Console.Write($"{splitText[i]} ");
//                 Word aWord = new Word(splitText[i]);

//                 _words.Add(aWord);

//                 // vhttps://learn.microsoft.com/en-us/dotnet/csharp/misc/cs1503?f1url=%3FappId%3Droslyn%26k%3Dk(CS1503)
//             }
            
//         }
//         public void HideRandomWords(int numberToHide)
//         {
//             // I chose to make the number of words hidden random... though, how do I pick random words??

//             Random randNumber = new Random();
//             int hideNo = randNumber.Next(1, 3);

//             numberToHide = hideNo;

//             Random randomWord = new Random();
//             int i = randomWord.Next(_words.Count);
//             Word useThisWord = _words[i];
//             string aHiddenWord = useThisWord.ToString();

//             //int lettersToHide = aHiddenWord.Length;
//             // hidding letters in a word:
//             for (int i2 = 0; i2 < aHiddenWord.Length; i2++)
//             {
//                 Console.Write("_");
//             }
//             Console.WriteLine();
            
//             // This was from Chad Macbeth's video on BYU-I Videos:
//             // https://video.byui.edu/media/t/1_86gjzj20


//             // https://learn.microsoft.com/en-us/dotnet/api/system.string.tostring?view=net-9.0

//             // https://learn.microsoft.com/en-us/dotnet/api/system.string.length?view=net-9.0
//         }
//         public void GetDisplayText() //this is supposed to be a string
//         {
//             Console.WriteLine();
//             foreach (Word word in _words)
//             {
//                 word.Display();
//             }
//         }
//     }
// }


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Blind kitchen = new Blind();

//         kitchen._width = 60;
//         kitchen._height = 48;
//         kitchen._color = "white";

//         //Console.WriteLine(kitchen._width);

//         //double materialAmount = kitchen.GetArea();


//         // initializing the blinds to their new values after creating a new House object:
//         House johnsonHome = new House();

//         johnsonHome._kitchen = new Blind();
//         johnsonHome._livingRoom = new Blind();
//         johnsonHome._owner = "Johnson Family";

//         // After the new house object is created, you can access the member variables using the "dot" operator.
//         johnsonHome._kitchen._width = 60;

//         // I think this is something that I might need for the Journal and Scriptures and Word class, but I am not sure... I don't know...

//         // List of Custom Types:
//         // Do you add to the list here when it's in another class??
//         // how do I know what this means?
//         // the House class has the variables for _owner, _kitchen, and _livingroom. It also has the custom Blind list... however, there is a Blind class... are they connected??? We made a new House object called johnsonHome. We already had a new Blind object called kitchen, but then we assigned variables all the house variables to a new Blind object??? and the Blind object has _width, _height, _color... with a GetArea() method...
//         // when we added the House object to the _blinds list, we're specifically adding the kitchen new Blind object

//         johnsonHome._blinds.Add(kitchen);
//         foreach (Blind b in johnsonHome._blinds)
//         {
//             Console.WriteLine(b.GetArea());
//         }


//     }
//     public class Blind
//     {
//         public double _width;
//         public double _height;
//         public string _color;

//         public double GetArea()
//         {
//             return _width * _height;
//         }
//     }
//     public class House
//     {
//         // Custom types for member variables.
//         public string _owner;
//         public Blind _kitchen;
//         public Blind _livingRoom;

//         // List of Custom Types:
//         public List<Blind> _blinds = new List<Blind>();

//         // or you can initialize the variables in the class definition:
//         /*
//         public string _owner = "";
//         public Blind _kitchen = new Blind();
//         public Blind _livingRoom = new Blind();
//         */

//     }
// }



// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Reference r1 = new Reference("John", 3, 16);
//         // Scripture s1 = new Scripture(r1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

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


// Watched video:
// BYU - Idaho Videos CSE 210: Week 3 Assignment 
// from Chad Macbeth May, 7th, 2024
// https://video.byui.edu/media/t/1_sv3gxgzs/259941952

// I found this about being able to read the Enter key from a user:
// https://learn.microsoft.com/en-us/dotnet/api/system.console.readkey?view=net-9.0