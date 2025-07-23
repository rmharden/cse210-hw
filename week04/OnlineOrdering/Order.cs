// ENCAPSULATION


using System.Net.Security;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order()
    {
        List<Product> _products = new List<Product>();

    }
    public Order(List<Product> products)
    {
        List<Product> _products = products;
    }

    public string GetPackingLabel()
    {
        return "";
    }
    public Customer GetShippingLabel()
    {
        return _customer._address;
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