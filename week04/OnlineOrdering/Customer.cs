using System.Runtime.InteropServices;

public class Customer
{
    private string _customerName;

    public Customer(string customerName, string street, string city, string stateOrProvince, string country)
    {
        _customerName = customerName;
    }
    public bool IsCustUSA()
    {

        if ( == true)
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
        return _customerName + "";
    }
}
