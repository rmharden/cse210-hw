using System.Runtime.InteropServices;

public class Customer
{
    private string _customerName;

    public Customer(string customerName)
    {
        _customerName = customerName;
    }
    public bool IsCustUSA()
    {
        if (Address.IsAddressUSA() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetCustomer()
    {
        return _customerName + Address.CompleteAddress();
    }
}
