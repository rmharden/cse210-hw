using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {

        Customer c1 = new Customer();
        c1.SetName("Bodil Larsdatter");
        Address a1 = new Address();
        a1.SetAddress("Bentsensvej 24", "Hvalso", "Sjælland", "Denmark");
        a1.GetAddress();

        Order newOrder1 = new Order();
        Console.WriteLine(newOrder1.makeShippingLabel());

        Customer c2 = new Customer();
        c2.SetName("Hugh Falconer");
        Address a2 = new Address();
        a2.SetAddress("50 Village Dr", "Winter Park", "Colorado", "USA");
        a2.GetAddress();

        Order newOrder2 = new Order();
        Console.WriteLine(newOrder2.makeShippingLabel());
        
        
        // Order o1 = new Order();
        // Console.WriteLine(o1.makeShippingLabel());



        // Product productTotal1 = new Product();
        // productTotal1._productPrice = 50;
        // productTotal1._productId = "la1234";
        // productTotal1._productQty = 5;
        // productTotal1._productName = "lamps";

        // Product productTotal2 = new Product();
        // productTotal2._productName = "chairs";
        // productTotal2._productId = "ch1234";
        // productTotal2._productPrice = 250;
        // productTotal2._productQty = 2;


        // /*
        // Console.WriteLine(order1._price);
        // Console.WriteLine(order1._quantity);
        // Console.WriteLine(order1._name);
        // */

        // double firstOrderCost = productTotal1.GetTotalProductCost();
        // Console.WriteLine($"Order 1: ${firstOrderCost}.00");

        // double secondOrderCost = productTotal2.GetTotalProductCost();
        // Console.WriteLine($"Order 2: ${secondOrderCost}.00");

        // Address a1 = new Address();
        // a1._street = "Bentsensvej 24";
        // a1._city = "Hvalso";
        // a1._stateOrProvince = "Sjælland";
        // a1._country = "Denmark";

        // string isAddUSA1 = a1.IsAddressUSA();
        // Console.WriteLine($"Is the address in the USA? {isAddUSA1}.");

        // string addressLabel1 = a1.CompleteAddress();
        // Console.WriteLine();

        // Address a2 = new Address();
        // a2._street = "50 Village Dr";
        // a2._city = "Winter Park";
        // a2._stateOrProvince = "Colorado";
        // a2._country = "USA";

        // string isAddUSA2 = a2.IsAddressUSA();
        // Console.WriteLine($"Is the address in the USA? {isAddUSA2}.");

        // string addressLabel2 = a2.CompleteAddress();
        // Console.WriteLine();


    }
}