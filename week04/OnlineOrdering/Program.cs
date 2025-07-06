using System;

class Program
{
    static void Main(string[] args)
    {
        Product productTotal1 = new Product();
        productTotal1._productPrice = 50;
        productTotal1._productId = "la1234";
        productTotal1._productQty = 5;
        productTotal1._productName = "lamps";

        Product productTotal2 = new Product();
        productTotal2._productName = "chairs";
        productTotal2._productId = "ch1234";
        productTotal2._productPrice = 250;
        productTotal2._productQty = 2;


        /*
        Console.WriteLine(order1._price);
        Console.WriteLine(order1._quantity);
        Console.WriteLine(order1._name);
        */

        double firstOrderCost = productTotal1.GetTotalProductCost();
        Console.WriteLine(firstOrderCost);

        double secondOrderCost = productTotal2.GetTotalProductCost();
        Console.WriteLine(secondOrderCost);

        Address a = new Address();
        a._country = "Denmark";

        string orderShipping = a.IsAddressUSA();
        Console.WriteLine(orderShipping);


    }
}