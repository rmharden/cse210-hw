// John 3:16
// For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. 


// Proverbs 3:5-6
// Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways, acknowledge him, and he shall direct thy paths.

using System;
class Program
{
    static void Main(string[] args)
    {
        Reference r2 = new Reference("John", 3, 16);
        Scripture s2 = new Scripture(r2, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. ");
        Console.WriteLine(s2.GetDisplayText());


        Reference r3 = new Reference("Proverbs", 3, 4, 6);
        Scripture s3 = new Scripture(r3, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.", "In all thy ways, acknowledge him, and he shall direct thy paths.");
        Console.WriteLine(s3.GetDisplayText());
    }
}
public class Word()
{

}




// Week 3 Homework Practice

// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         Fraction f1 = new Fraction();
//         Console.WriteLine(f1.GetFractionString());
//         Console.WriteLine(f1.GetDecimalValue());

//         Fraction f2 = new Fraction(5);
//         Console.WriteLine(f2.GetFractionString());
//         Console.WriteLine(f2.GetDecimalValue());

//         Fraction f3 = new Fraction(3, 4);
//         Console.WriteLine(f3.GetFractionString());
//         Console.WriteLine(f3.GetDecimalValue());

//         Fraction f4 = new Fraction(1, 3);
//         Console.WriteLine(f4.GetFractionString());
//         Console.WriteLine(f4.GetDecimalValue());
//     }
// }
// public class Fraction
// {
//     private int _top;
//     private int _bottom;
//     public Fraction()
//     {
//         // Default class that takes no parameters?
//         _top = 1;
//         _bottom = 1;

//     }
//     public Fraction(int wholeNumber)
//     {
//         _top = wholeNumber; // I didn't have to write this at the top?
//         _bottom = 1;
//     }
//     public Fraction(int top, int bottom)
//     {
//         _top = top;
//         _bottom = bottom;
//     }
//     public string GetFractionString()
//     {
//         // notice that this is not stored as a member variable.
//         // It is just a temporary, local variable that will be recomputed each time this is called.
//         string text = $"{_top}/{_bottom}";
//         return text;
//     }
//     public double GetDecimalValue()
//     {
//         // notice that this is not stored as a member variable.
//         // It will recompute each time it is called.
//         return (double)_top / (double)_bottom; // what is the type in ()?
//     }
// }

// // Week 3 Encapsulation Lesson/Study cont...

// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         // // calling a setter
//         // Person p = new Person(); // This calls a no-argument constructor and doesn't need any information.

//         // p.SetFirstName("Peter");

//         // Console.WriteLine(p.GetFirstName());

//         Person p1 = new Person(); // Don't pass any information to get the default values
//         Person p2 = new Person("Jane", "Doe"); // pass the first and last names
//         Person p3 = new Person("Mrs.", "Jane", "Doe"); // Pass all three variables
//     }
//     public class Account
//     {
//         private List<int> _transactions = new List<int>();

//         public void Deposit(int amount)
//         {
//             _transactions.Add(amount);
//         }
//     }
//     public class Person
//     {
//         private string _title;
//         private string _firstName;
//         private string _lastName;
//         public Person() // A constructor that sets up default values for all new Person objects.
//         {
//             _title = "";
//             _firstName = "Anonymous";
//             _lastName = "Unknown";
//         }
//         public Person(string first, string last)
//         {
//             _title = "";
//             _firstName = first;
//             _lastName = last;
//         }
//         public Person(string title, string first, string last)
//         {
//             _title = title;
//             _firstName = first;
//             _lastName = last;
//         }
//         public string GetInformalSignature()
//         {
//             return "Thanks," + _firstName;
//         }
//         public string GetFormalSignature()
//         {
//             return "Sincerely, " + GetFullName();
//         }
//         private string GetFullName()
//         {
//             return _title + " " + _firstName + " " + _lastName;
//         }
//         // This is a getter
//         public string GetFirstName()
//         {
//             return _firstName;
//         }
//         // This is a setter
//         public void SetFirstName(string firstName)
//         {
//             _firstName = firstName;
//         }
    
//     }
// }


// // Week 3 Encapsulation Lesson Video:

// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         // This whole thing from the example written just like this doesn't show what is in the list and it doesn't show the 50 that was deposited. It returns 0. I don't know why.

//         // an instance of the Account class
//         Account savings = new Account();
//         // this puts the 50 in the object, _balance

//         //savings._balance = 50; //changing the code to private in the Account classes, makes this unable to accesses the object _balance. It can only access the method and then the method can access the private area.

//         // accessors or mutators or getters and setters will help access the private area in Account.

//         // This isn't a good way because it exposes data. So there are better methods to use.
//         // savings.SetBalance(50);

//         // Using the Deposit into the list instead of SetBalance:
//         savings.Deposit(50);

//         // member function
//         int money = savings.GetBalance();
//         Console.WriteLine(money);
//         foreach(int item in savings._transactions)
//     }
//     public class Account
//     {
//         // need to change this to Private access
//         // public int _balance;
//         //private int _balance;
//         private int _amount;

//         // Example:
//         private List<int> _transactions = new List<int>();

//         // New approach:
//         public void Deposit(int amount)
//         {
//             _transactions.Add(amount);
//         }

//         // First approach:
//         // public void Deposit(int amount)
//         // {
//         //     _balance = _balance + amount;
//         // }
//         public void SetBalance(int amount)
//         {
//             _amount = amount;
//         }
//         public int GetBalance()
//         {
//             return _amount;
//         }
       
//     }
// }


// This is from the Week 3 Encapsulation Lesson

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Account savings = new Account();
//         savings._balance = 50; // this stops working with example two.
//         savings.Deposit(100); // this continues to work.
//     }

//     public class Account
//     {
//         // Example one:
//         // public int _balance = 0;
//         // public void Deposit(int amount)
//         // {
//         //     _balance = _balance + amount;
//         // }

//         // Example two:
//         public List<int> _transactions = new List<int>();
//         public void Deposit(int amount)
//         {
//             _transactions.Add(amount);
//         }
//     }
// }




// For the scripture memorizer:
// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         string _secret = "python";
//         // letter is a variable
//         foreach (char _letter in _secret)
//         {
//             Console.Write("_");
//         }
//         Console.WriteLine();
//         for (int i = 0; i < _secret.Length; i++)
//         {
//             Console.Write("_");
//         }
//         Console.WriteLine();
//     }
//     // These both do the samething. I think.
//     // How I use this to make the hidden words work in the scripture memorizer?

// }

// This was from Chad Macbeth's video on BYU-I Videos:
// https://video.byui.edu/media/t/1_86gjzj20



// using System;
// // Week 06: Video: Polymorphism (17:44 mins)

// // Method overriding so it can do something different in a derived class

// class Program
// {
//     static void Main(string[] args)
//     {
//         Person p1 = new Person();

//         p1.SetFirstName("Bob");
//         p1.SetLastName("Smith");

//         // Create the bank reports
//         Console.WriteLine(p1.GetFormalName());

//         Student p2 = new Student();
//         p2.SetFirstName("Emily");
//         p2.SetLastName("Jones");
//         p2.SetGpa(3.75);

//         Console.WriteLine(p2.GetStudentRecord());

//         Teacher p3 = new Teacher();
//         p3.SetFirstName("Michael");
//         p3.SetLastName("Broach");

//         Console.WriteLine(p1.GetFullName());
//         Console.WriteLine(p2.GetFullName());
//         Console.WriteLine(p3.GetFullName());

//         List<Person> people = new List<Person>();
//         people.Add(p1);
//         people.Add(p2);
//         people.Add(p3);

//         Console.WriteLine("\nLooking at the list of people...\n");
//         foreach (Person p in people)
//         {

//             // 11:08 of 15:06 in the video
//             // this is showing what happens if we don't override
//             // the teacher variable needs to be set.
//             if (p._personType == "teacher")
//             {
//                 // needs to say what to do
//             }
//             else
//             {
//                 // needs to say what happens otherwise for the regular person
//             }
//             // Without polymorphism, you have to have a bunch of the if statements for each new type of person


//             Console.WriteLine(p.GetFullName());
//         }
//     }

//     public static void PrintPersonDetails(Person p)
//     {
//         Console.WriteLine(p.GetFullName());
//     }
// }








// // using System;
// // using System.Security.Cryptography.X509Certificates;

// // class Program
// // {
// // 	static void Main(string[] args)
// // 	{

// //         // I used the information from Week 01 about Coverting Types by using the int.Parse() function.
// //         // I also watched the video from Week 05 om Display animations and used the things taught there to do the breathing activity.
// //         Console.Write("\nHow long, in seconds, would you like your session? ");

// //         string inputString = Console.ReadLine();
// //         int duration = int.Parse(inputString);

// //         DateTime startTime = DateTime.Now;
// // 		DateTime endTime = startTime.AddSeconds(duration);

// //         while (DateTime.Now < endTime)
// //         {
// //             Console.Write("\nBreathe in... ");
// //             for (int i = 5; i > 0; i--)
// //             {
// //                 Console.Write(i);
// //                 Thread.Sleep(1000);
// //                 Console.Write("\b \b");
// //             }
// //             Console.WriteLine();
// //             Console.Write("Breathe out... ");
// //             for (int i2 = 5; i2 > 0; i2--)
// //             {
// //                 Console.Write(i2);
// //                 Thread.Sleep(1000);
// //                 Console.Write("\b \b");
// //             }
// //             Console.WriteLine();
// // 		}	

// // 		Console.WriteLine("\nWell done!\n");
// // 	}
// // }



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
