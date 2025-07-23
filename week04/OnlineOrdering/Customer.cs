// ENCAPSULATION

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }
    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }
    public string GetCustomerName()
    {
        return _customerName;
    }
    public void SetCountry(Address address)
    {
        _address = address;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public double CustomerUSA()
    {
        if (_address.IsCountryUSA() == true)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
}


// using System.Runtime.InteropServices;

// public class Customer
// {
//     private string _customerName;
    

//     public Customer(string customerName)
//     {
//         _customerName = customerName;
//     }

//     // Is this not a bool?? I am confused
    
//     // public bool IsCustUSA()
//     // {

//     //     if ( == true)
//     //     {
//     //         return true;
//     //     }
//     //     else
//     //     {
//     //         return false;
//     //     }
//     // }
//     public string GetCustomer()
//     {
//         return _customerName + "";
//     }
// }
