using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        ///*
        Person p1 = new Person();
        p1._firstName = "June";
        p1._lastName = "Logan";
        p1._age = 32;

        Person p2 = new Person();
        p2._firstName = "Webster";
        p2._lastName = "McMullen";
        p2._age = 51;

        Person p3 = new Person();
        p3._firstName = "Fanny";
        p3._lastName = "Jullian";
        p3._age = 25;

        List<Person> people = new List<Person>();
        people.Add(p1);
        people.Add(p2);
        people.Add(p3);

        foreach (Person p in people)
        {
            Console.WriteLine(p._firstName);
        }
        SaveToFile(people);
        //*/

        List<Person> newPeople = ReadFromFile();
        foreach (Person p in newPeople)
        {
            Console.WriteLine();
            Console.Write($"{p._lastName}, ");
            Console.Write($"{p._firstName}, ");
            Console.WriteLine($"{p._age}");
        }
        Console.WriteLine();
    }
    public static void SaveToFile(List<Person> people)
    {
        Console.WriteLine();
        Console.WriteLine("Saving to file...");
        string filename = "people.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Person p in people)
            {
                outputFile.WriteLine($"{p._firstName}~~{p._lastName}~~{p._age}");
            }
        }
    }
    public static List<Person> ReadFromFile()
    {
        Console.WriteLine("Reading list from file...");
        List<Person> people = new List<Person>();
        string filename = "people.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            //Console.WriteLine(line);
            // line will have something like this: "Mary~~Smith~~25
            //John~~Watkins~~30"
            string[] parts = line.Split("~~");

            // parts[0] - Mary
            // parts[1] - Smith
            // parts[2] - 25

            Person newPerson = new Person();
            newPerson._firstName = parts[0];
            newPerson._lastName = parts[1];
            newPerson._age = int.Parse(parts[2]);

            people.Add(newPerson);
        }
        return people;
    }
}

/*
Week 03: ENCAPSULATION 
using System;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the OnlineOrdering Project.");


        First Step:
        Account savings = new Account(); // This an instance of the account class.
        savings._balance = 50;
        savings.Deposit(100);


        Second Step:
        Account savings = new Account(); // This is an instance of the account class.
        savings._balance = 50 // This doesn't work now
        savings.Deposit(100);


        Video: Encapsulation:
        Account savings = new Account();
        // This is an instance of the Account class.
        //savings._balance = 50 // This will not work when the _balance is set to "private".
        //savings.SetBalance(50); // This is an Access Modifier.
        // It has access to the _balance. It is a setter?
        // This is not great. It exposes the private data.

        //int money = savings.GetBalance(); // This is a getter.
        // it has access to _balance.
        // We don't need to update this area. We 
        //update the internal area to make changes.

        savings.Deposit(50);

    }

}
*/