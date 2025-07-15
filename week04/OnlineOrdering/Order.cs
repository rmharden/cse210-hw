using System.Collections.Generic;

public class Order
{

    public List<string> _order = new List<string>();

    public void StupidProgram(string customerName, string productName, string productId, string productPrice, string productQty)
    {
        _order.Add(customerName);
        _order.Add(productName);
        _order.Add(productId);
        _order.Add(productPrice);
        _order.Add(productQty);

        foreach (string order in _order)
        {
            Console.WriteLine();    
        }
    }


    public class makePackingLabel
    {

    }


    public string makeShippingLabel()
    {
        // USA
        Address a1 = new Address();
        Customer c1 = new Customer();
        return $"{c1.GetName}\n{a1.CompleteAddress()}";
    }
}






// Order

// Contains a list of products and a customer. 
// Can calculate the total cost of the order. 
// Can return a string for the packing label. 
// Can return a string for the shipping label.

// The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.

// If the customer lives in the USA, then the shipping cost is $5. 
// If the customer does not live in the USA, then the shipping cost is $35.

// A packing label should list the name and product id of each product in the order.

// A shipping label should list the name and address of the customer