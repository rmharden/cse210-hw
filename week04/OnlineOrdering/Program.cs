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
        products.Add(p1); // I don't think this is working

        Product p2 = new Product("chairs", "ch1234", 250, 2);
        products.Add(p2); // I don't think this is working

        Order o1 = new Order(products, c1);
        o1.GetShippingLabel();
        o1.GetPackingLabel();

        Address a2 = new Address("50 Village Dr", "Winter Park", "Colorado", "USA");
        Customer c2 = new Customer("Hugh Falconer", a2);
        Order o2 = new Order(products, c1);
        o2.GetShippingLabel();
        o2.GetPackingLabel();
    }
}




// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Product productTotal1 = new Product();
//         // productTotal1._productPrice = 50;
//         // productTotal1._productId = "la1234";
//         // productTotal1._productQty = 5;
//         // productTotal1._productName = "lamps";

//         // Product productTotal2 = new Product();
//         // productTotal2._productName = "chairs";
//         // productTotal2._productId = "ch1234";
//         // productTotal2._productPrice = 250;
//         // productTotal2._productQty = 2;


//         // double firstOrderCost = productTotal1.GetTotalProductCost();
//         // Console.WriteLine($"Order 1: ${firstOrderCost}.00");

//         // double secondOrderCost = productTotal2.GetTotalProductCost();
//         // Console.WriteLine($"Order 2: ${secondOrderCost}.00");

//         Customer c1 = new Customer("Sisde Madsen");
//         Address a1 = new Address("Bentsensvej 24", "Hvalso", "Sjælland", "Denmark");
//         a1.GetCountry(); // I'm not sure how to use this in Customer.

//         Customer c2 = new Customer("Hugh Falconer");
//         Address a2 = new Address("50 Village Dr", "Winter Park", "Colorado", "USA");
       
//     }
// }