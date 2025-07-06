using System;
using System.Security.Cryptography.X509Certificates;

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

        double materialAmountKt = kitchen.GetArea();

        Console.WriteLine(kitchen.GetArea());

        Blind livingRoom = new Blind();
        livingRoom._width = 83;
        livingRoom._height = 48;
        livingRoom._color = "eggshell";

        double materialAmountLr = livingRoom.GetArea();

        Console.WriteLine(livingRoom.GetArea());

        House johnsonHome = new House();
        johnsonHome._owner = "Johnson Family";

        johnsonHome._kitchen._width = 60;

        Console.WriteLine(johnsonHome._kitchen._width);


        foreach (Blind b in johnsonHome._blinds)
        {
            double amount = b.GetArea();
        }
    }
}

