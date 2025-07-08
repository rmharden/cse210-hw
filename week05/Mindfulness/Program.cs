using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the Mindfulness Project.\n");
        Student student = new Student("Brigham", "234");
        string name = student.GetName();
        string number = student.GetNumber();
        Console.WriteLine(name);
        Console.WriteLine(number);
    }
}