// ENCAPSULATION


using System.Net.Security;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public void SetProduct(List<Product> products)
    {
        _products = products;
    }
    public List<Product> GetProducts()
    {
        return _products;
    }
    public void GetPackingLabel()
    {
        Console.WriteLine($"\n{_customer.GetCustomerName()}\n");
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetId}: {product.GetProductName}");
        }

    }
    public void GetShippingLabel()
    {
        Console.WriteLine($"\n{_customer.GetCustomerName()}\n{_customer.CustAddress()}\n");
    }

}


// public class Order
// {
//     private List<Order> _product;
//     private Customer _customer;


//     public Order(Customer customer, List<Product> product)
//     {
//         _customer = customer;

//     }
//     public Customer GetCustomer()
//     {
//         return _customer;
//     }

//     public void AddProduct()
//     {

//     }
//     public void GetTotalPrice()
//     {
    

//     }
// }