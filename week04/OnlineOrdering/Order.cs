public class Order
{
    private List<Order> _products = new List<Order>();
    private Customer _customer;

    public Order(Customer customer, Order products)
    {
        _customer = customer;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
    // public Customer SetCustomer(Customer customer)
    // {
    //     _customer = customer;
    // }

    public void AddProduct()
    {

    }
    public void GetTotalPrice()
    {
    

    }
}