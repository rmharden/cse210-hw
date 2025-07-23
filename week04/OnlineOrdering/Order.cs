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
    // public void AddProductsToOrder()
    // {
    //     foreach (Product product in _products)
    //     {
    //         _products.Add(product.GetProductName());
    //     }
    // } // I don't know how to add products here.

    public double GetTotalPrice()
    {
        double shipping = _customer.IsCustomerUSA();
        // double _totalPrice = 0;
        double _itemPrice = 0;
        foreach (Product product in _products)
        {
            _itemPrice += product.GetTotalPrice();
        }
        double _productPrice = _itemPrice;
        double _totalPrice = _productPrice + shipping;
        return _totalPrice;
        // This link showed how to add items in a list with +=
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/addition-operator
    }

    public void GetPackingLabel()
    {
        Console.WriteLine($"\n{_customer.GetCustomerName()}\n");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product Id: {product.GetId()}, Item: {product.GetProductName()}, ${product.GetPrice()}");
        }
        Console.WriteLine($"\nShipping: ${_customer.IsCustomerUSA()}");

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