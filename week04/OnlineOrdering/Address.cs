// ENCAPSULATION

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProv;
    private string _country;

    public Address(string street, string city, string stateOrProv, string country)
    {
        _street = street;
        _city = city;
        _stateOrProv = stateOrProv;
        _country = country;
    }
    public void SetStreet(string street)
    {
        _street = street;
    }
    public string GetSreet()
    {
        return _street;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetStateOrProv(string stateOrProv)
    {
        _stateOrProv = stateOrProv;
    }
    public string GetStateOrProv()
    {
        return _stateOrProv;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
    public string GetCountry()
    {
        return _country;
    }
    public string IsCountryUSA()
    {
        if (GetCountry().ToLower() == "usa")
        {
            return "yes";
        }
        else
        {
            return "true";
        }
    }
    public string GetAddress()
    {
        return GetSreet() + "\n" + GetCity() + ", " + GetStateOrProv() + ", " + GetCountry();
    }
}


// public class Address
// {
//     private string _street;
//     private string _city;
//     private string _stateOrProvince;
//     private string _country;

//     public Address(string street, string city, string stateOrProvince, string country)
//     {
//         _street = street;
//         _city = city;
//         _stateOrProvince = stateOrProvince;
//         _country = country;
//     }
//     public string GetCountry()
//     {
//         return _country;
//     }
//     public void SetCountry(string country)
//     {
//         _country = country;
//     }
//     public bool IsAddressUSA()
//     {
//         if (_country.ToLower() == "usa")
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }
//     public string CompleteAddress()
//     {
//         return _street + _city + _stateOrProvince + _country;
//     }
// }