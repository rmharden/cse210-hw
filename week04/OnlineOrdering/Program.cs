// ENCAPSULATION

using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("Bentsensvej 24", "Hvalso", "Sjælland", "Danmark");
        Customer c1 = new Customer("Sisde Madsen", a1);

        List<Product> products = new List<Product>();

        Product p1 = new Product("lamps", "la1234", 50, 5);
        products.Add(p1); 

        Product p2 = new Product("chairs", "ch1234", 250, 2);
        products.Add(p2); 

        Order o1 = new Order(products, c1);
        o1.GetShippingLabel();
        o1.GetPackingLabel();
        Console.WriteLine($"\nTotal Price: ${o1.GetTotalPrice()}");


        Address a2 = new Address("50 Village Dr", "Winter Park", "Colorado", "USA");
        Customer c2 = new Customer("Hugh Falconer", a2);

        Product p3 = new Product("chair", "ch1234", 250, 1);
        products.Add(p3); 

        Product p4 = new Product("sofa", "sf9874", 1885, 1);
        products.Add(p4); 

        Order o2 = new Order(products, c2);
        o2.GetShippingLabel();
        o2.GetPackingLabel();
        Console.WriteLine($"\nTotal Price: ${o2.GetTotalPrice()}\n");
    }
}