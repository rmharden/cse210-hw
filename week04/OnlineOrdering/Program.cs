using System;

class Program
{
    static void Main(string[] args)
    {
        Product order1 = new Product();
        order1._price = 50;
        order1._quantity = 5;
        order1._name = "lamps";

        Product order2 = new Product();
        order2._price = 250;
        order2._quantity = 2;
        order2._name = "chairs";

        /*
        Console.WriteLine(order1._price);
        Console.WriteLine(order1._quantity);
        Console.WriteLine(order1._name);
        */

        double firstOrderCost = order1.GetTotal();
        Console.WriteLine(firstOrderCost);

        double secondOrderCost = order1.GetTotal();
        Console.WriteLine(secondOrderCost);

    }
}