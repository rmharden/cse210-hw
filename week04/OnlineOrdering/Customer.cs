using System.Configuration.Assemblies;

public class Customer
{
    private string _customerName;

      
    Address a1 = new Address();
   
    public void SetCustomer(string customerName)
    {
        _customerName = customerName;
    }

    public string GetCustomer()
    {
        return $"{_customerName}\n{a1.GetAddress()}";
    }
    
    public string IsCustomerUsa()
    {
        if (a1.IsAddressUsa() == "yes")
        {
            return "USA";
        }
        else
        {
            return "not USA";
        }
    }
}