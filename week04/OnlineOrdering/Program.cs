// ENCAPSULATION

using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("Bentsensvej 24", "Hvalso", "Sjælland", "Danmark");
        Customer c1 = new Customer("Sidse Thøhgersdatter Madsen", a1);

        List<Product> products1 = new List<Product>();

        Product p1 = new Product("lamps", "la9874", 50, 5);
        products1.Add(p1); 

        Product p2 = new Product("chairs", "ch8523", 250, 2);
        products1.Add(p2); 

        Order o1 = new Order(products1, c1);
        o1.GetShippingLabel();
        o1.GetPackingLabel();

        Console.WriteLine($"\nTotal Price: ${o1.GetTotalPrice()}");


        List<Product> products2 = new List<Product>();

        Address a2 = new Address("50 Village Dr", "Winter Park", "Colorado", "USA");
        Customer c2 = new Customer("Hugh Falconer", a2);

        Product p3 = new Product("ottoman", "ot7563", 350, 1);
        products2.Add(p3); 

        Product p4 = new Product("sofa", "sf9874", 1885, 1);
        products2.Add(p4); 

        Product p5 = new Product("bookshelf", "bk6478", 120, 1);
        products2.Add(p5); 

        Order o2 = new Order(products2, c2);
        o2.GetShippingLabel();
        o2.GetPackingLabel();
        
        Console.WriteLine($"\nTotal Price: ${o2.GetTotalPrice()}\n");
    }
}