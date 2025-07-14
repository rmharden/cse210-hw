using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Sandbox World!");
    }
}







// using System;
// using System.Security.Cryptography.X509Certificates;

// class Program
// {
// 	static void Main(string[] args)
// 	{

//         // I used the information from Week 01 about Coverting Types by using the int.Parse() function.
//         // I also watched the video from Week 05 om Display animations and used the things taught there to do the breathing activity.
//         Console.Write("\nHow long, in seconds, would you like your session? ");

//         string inputString = Console.ReadLine();
//         int duration = int.Parse(inputString);

//         DateTime startTime = DateTime.Now;
// 		DateTime endTime = startTime.AddSeconds(duration);

//         while (DateTime.Now < endTime)
//         {
//             Console.Write("\nBreathe in... ");
//             for (int i = 5; i > 0; i--)
//             {
//                 Console.Write(i);
//                 Thread.Sleep(1000);
//                 Console.Write("\b \b");
//             }
//             Console.WriteLine();
//             Console.Write("Breathe out... ");
//             for (int i2 = 5; i2 > 0; i2--)
//             {
//                 Console.Write(i2);
//                 Thread.Sleep(1000);
//                 Console.Write("\b \b");
//             }
//             Console.WriteLine();
// 		}	

// 		Console.WriteLine("\nWell done!\n");
// 	}
// }



// // using System;
// // using System.Security.Cryptography.X509Certificates;

// // class Program
// // {
// // 	static void Main(string[] args)
// // 	{
// //         Console.WriteLine("How long, in seconds, would you like your session? ");

// //         string inputString = Console.ReadLine();
// //         int duration = int.Parse(inputString);

// //         DateTime startTime = DateTime.Now;
// // 		DateTime endTime = startTime.AddSeconds(duration);
		
// // 		while (DateTime.Now < endTime)
// // 		{
// // 			Console.Write(".");
// // 			Thread.Sleep(1000);
// // 		}	

// // 		Console.WriteLine("Done");
// // 	}
// // }



// // using System;
// // using System.Security.Cryptography.X509Certificates;

// // // Practice as of July 9, 2025 at 11:19 AM
// // // Display Animations Video from CSE 210 W05 Project:
// // // Mindfulness Program
// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         Console.WriteLine("Hello Sandbox World");

// //         // Pausing, sleeping, waiting... 3000 milliseconds.
// //         // 1000 Milliseconds = 1 Second

// //         Thread.Sleep(3000);

// //         // This is a way to do a countdown:

// //         // Console.WriteLine("5");
// //         // Thread.Sleep(1000);
// //         // Console.WriteLine("4");
// //         // Thread.Sleep(1000);
// //         // Console.WriteLine("3");
// //         // Thread.Sleep(1000);
// //         // Cmd + / allows me to comment more than one highlighted line.
// //         // Console.WriteLine("2");
// //         // Thread.Sleep(1000);
// //         // Console.WriteLine("1");
// //         // Thread.Sleep(1000);


// //         // Here is another way to do a countdown:
// //         // This writes each number on a new line.

// //         // for (int i = 5; i > 0; i--)
// //         // {
// //         //     Console.WriteLine(i);
// //         //     Thread.Sleep(1000);
// //         // }

// //         // Changed to writing the numbers on one line.
// //         // for (int i = 5; i > 0; i--)
// //         // {
// //         //     Console.Write(i);
// //         //     Thread.Sleep(1000);
// //         // }

// //         // Console.Write("\b");  // "Does a back arrow"
// //         // Console.Write("\b \b");  // "Does a back arrow, overrides it, and goes back"
// //         // this works for single digits. Need to do two back arrows if there are more digits.
// //         // for (int i = 5; i > 0; i--)
// //         // {
// //         //     Console.Write(i);
// //         //     Thread.Sleep(1000);
// //         //     Console.Write("\b \b");
// //         // }

// //         // This one displays a count of dots:
// //         // for (int i = 5; i > 0; i--)
// //         // {
// //         //     Console.Write(".");
// //         //     Thread.Sleep(1000);
// //         // }

// //         // This is a spinner animation:
// //         // because a backslash is a special character, we have to add two in the quotes so it will display one for this special situation:

// //         List<string> animationStrings = new List<string>();
// //         animationStrings.Add("|");
// //         animationStrings.Add("/");
// //         animationStrings.Add("-");
// //         animationStrings.Add("\\");
// //         animationStrings.Add("|");
// //         animationStrings.Add("/");
// //         animationStrings.Add("\\");

// //         // foreach (string s in animationStrings)
// //         // {
// //         //     Console.Write(s);
// //         //     Thread.Sleep(1000);
// //         //     Console.Write("\b \b");
// //         // }

// //         // This creates a way to display by a specific time:
// //         DateTime startTime = DateTime.Now;
// //         DateTime endTime = startTime.AddSeconds(5);

// //         // This is starting at the 0 of the index of the list:

// //         int i = 0;

// //         while (DateTime.Now < endTime)
// //         {
// //             // This is telling the while loop to use the List with the index at 0:
// //             string s = animationStrings[i];
// //             Console.Write(s);
// //             Thread.Sleep(1000);
// //             Console.Write("\b \b");

// //             // Advances the "i":
// //             i++;

// //             // This prevents the error. It takes the number of items in the index and stops the count when it gets to that number; in this case, the number "8":
// //             // However, because we have a while loop, it will loop through that animation until it reaches the seconds provided.

// //             if (i >= animationStrings.Count)
// //             {
// //                 i = 0;
// //             }
// //         }

// //         Console.WriteLine("Done.");
// //     }
// // }

// // /*
// // // Practice prior to July 9, 2025 at 11:15 AM
// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         //Console.WriteLine("\nHello Sandbox World!\n");

// //         Blind kitchen = new Blind();
// //         kitchen._width = 60;
// //         kitchen._height = 48;
// //         kitchen._color = "white";

// //         Console.WriteLine(kitchen._width);

// //         double materialAmountKt = kitchen.GetArea();

// //         Console.WriteLine(kitchen.GetArea());

// //         Blind livingRoom = new Blind();
// //         livingRoom._width = 83;
// //         livingRoom._height = 48;
// //         livingRoom._color = "eggshell";

// //         double materialAmountLr = livingRoom.GetArea();

// //         Console.WriteLine(livingRoom.GetArea());

// //         House johnsonHome = new House();
// //         johnsonHome._owner = "Johnson Family";

// //         johnsonHome._kitchen._width = 60;

// //         Console.WriteLine(johnsonHome._kitchen._width);


// //         foreach (Blind b in johnsonHome._blinds)
// //         {
// //             double amount = b.GetArea();
// //         }

// //         int[] numbers = { 10, 30, 44, 21, 51, 21, 61, 24, 14 };
// //         Array.IndexOf(numbers, 21);
// //         int ans = Array.IndexOf(numbers, 21);
// //         Console.WriteLine(ans);

// //         int[] source = { 12, 1, 5, -2, 16, 14 };
// //         int[] dest = { 1, 2, 3, 4 };

// //         Array.Copy(source, dest, 3);

// //         int[] numbers2 = { 12, 1, 5, -2, 16, 14 };
// //         Array.Sort(numbers2);

// //         string message = "Hello World";
// //         string anotherMessage = "";
// //         string myName = "Hello World, " + "name is Jamie";
// //         string myName2 = "Hello world, my name is Jamie";

// //         Console.WriteLine("Hello World".Length);

// //         string newMessage = message.Substring(2, 5);
// //         Console.WriteLine(newMessage);

// //         string firstString = "This is Jamie";
// //         string secondString = "Hello.";

// //         firstString.Equals("This is Jamie");
// //         secondString.Equals("This is Jamie");

// //         string[] separator = { ",", ";" };
// //         string names = "Peter, John, Andy, , David";
// //         string[] substrings = names.Split(separator, StringSplitOptions.RemoveEmptyEntries);
// //         Console.WriteLine(names);

// //         List<string> _prompts = new List<string> { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };

// //         Console.WriteLine(_prompts[0] + _prompts[1] + _prompts[2] + _prompts[3] + _prompts[4]);
// //         Console.WriteLine(_prompts.Count);
// //     }

// // }
// // */
