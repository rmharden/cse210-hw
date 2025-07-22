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
    public string CustomerUSA()
    {
        // This needs to call a method.
        // I'm not sure how I want to handle this yet.
        return "";
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
