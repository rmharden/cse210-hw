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

    public double GetTotalPrice()
    {
        double _totalPrice = 0;
        foreach (Product product in _products)
        {
            _totalPrice = product.GetPrice() + _customer.IsCustomerUSA();
        }
        return _totalPrice;
    }

    public void GetPackingLabel()
    {
        Console.WriteLine($"\n{_customer.GetCustomerName()}\n");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product Id: {product.GetId()}: Item: {product.GetProductName()}, ${product.GetPrice()}");
        }

    }
    public void GetShippingLabel()
    {
        Console.WriteLine($"\n{_customer.GetCustomerName()}\n{_customer.CustAddress()}\n");
    }
        public void SetProduct(List<Product> products)
    {
        _products = products;
    }
    public List<Product> GetProducts()
    {
        return _products;
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