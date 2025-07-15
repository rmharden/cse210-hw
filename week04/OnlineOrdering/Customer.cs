using System.Formats.Asn1;
using System.Net;
using System.Runtime.InteropServices;

public class Customer
{
    private string _name = "";
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }


    public Customer()
    {
        GetName();
        Address newAdd = new Address();
        newAdd.IsAddressUSA(_country, true);
        newAdd.SetAddress(_street, _city, _stateOrProvince, _country);   
    }
}