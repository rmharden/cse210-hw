using System.Net.Sockets;
using System.Runtime.CompilerServices;

public class Order
{
    // I'm unsure if this is correct:
    // Many of these needed to be done over.
    private List<String> _productsAndCustomer = new List<String>();

    Customer aCustomer = new Customer();
    Product products = new Product();
    public int _shippingCost;

    public string GetPackingLabel()
    {
        _productsAndCustomer.Add(aCustomer.GetCustomer());
        _productsAndCustomer.Add(products.GetProductName());
        _productsAndCustomer.Add(products.GetProductId());
        foreach (string pC2 in _productsAndCustomer)
        {
            Console.WriteLine(pC2);
        }
        return "";
    }

    public string GetShippingLabel()
    {
        Console.WriteLine(aCustomer.GetCustomer());
        return aCustomer.GetCustomer();
    }

    public float TotalPrice()
    {
        if (aCustomer.IsCustomerUsa() == "USA")
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }

        return products.ProductTotal() + _shippingCost;
    }
}