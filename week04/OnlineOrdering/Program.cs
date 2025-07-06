using System;

class Program
{
    static void Main(string[] args)
    {
        Product order1 = new Product();
        order1._price = 50;
        order1._quantity = 5;
        order1._name = "lamps";

        Console.WriteLine(order1._price);
        Console.WriteLine(order1._quantity);
        Console.WriteLine(order1._name);
        double orderCost = order1.GetTotal();
        Console.WriteLine(orderCost);

    }
}