using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        Order c1O = new Order();

        Customer c1 = new Customer();
        c1.SetCustomer("Sidse Thøgersdatter");

        Address a1 = new Address();
        a1.SetAddress("Bentsensvej 24", "Hvalso", "Sjælland", "Denmark");
        Console.WriteLine(a1.GetCountry());
        Console.WriteLine(c1.GetCustomer());

        Product c1P1 = new Product();
        c1P1.SetProduct("Accent Chairs", "ch581496", 250, 2);
        Product c1P2 = new Product();
        c1P2.SetProduct("Sofa", "sf789634", 988, 1);
        Product c1P3 = new Product();
        c1P3.SetProduct("Ottoman", "ot326598", 250, 1);
        Console.WriteLine($"{c1P1} + {c1P2} + { c1P3}");
        


        Order c2O = new Order();

        Customer c2 = new Customer();
        c2.SetCustomer("Hugh Falconer");

        Address a2 = new Address();
        a2.SetAddress("50 Village Dr", "Winter Park", "Colorado", "USA");
        Console.WriteLine(a2.GetCountry());
        Console.WriteLine(c2.GetCustomer());

        Product c2P1 = new Product();
        c2P1.SetProduct("Dining Table", "dt774422", 1190, 1);
        Product c2P2 = new Product();
        c2P2.SetProduct("Dining Chair", "dc753468", 292, 6);
        Product c2P3 = new Product();
        c2P3.SetProduct("Kitchen Cabinet", "kc159623", 1599, 1);

        Console.WriteLine($"{c2P1} + {c2P2} + { c2P3}");
        


        Console.Clear();
        Console.WriteLine(c1O.GetPackingLabel());
        Console.WriteLine(c1O.TotalPrice());
        Console.WriteLine(c1O.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine(c2O.GetPackingLabel());
        Console.WriteLine(c2O.TotalPrice());
        Console.WriteLine(c2O.GetShippingLabel());
        Console.WriteLine();

    }
}