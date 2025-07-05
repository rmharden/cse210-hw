using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("\nHello Sandbox World!\n");


        Blind kitchen = new Blind();
        kitchen._width = 60;
        kitchen._height = 48;
        kitchen._color = "white";

        Console.WriteLine(kitchen._width);
        //double materialAmount = kitchen.GetArea();
    }
}