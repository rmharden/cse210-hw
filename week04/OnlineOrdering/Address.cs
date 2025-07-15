public class Address
{
    public string _street;
    public string _city;
    public string _stateOrProvince;
    public string _country;
    // public string _isUSA;

    public bool IsAddressUSA(string _country, bool value)
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_stateOrProvince}, {_country}";
    }

    public void SetAddress(string city, string street, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
    public string CompleteAddress()
    {
        Console.WriteLine($"{_street}\n{_city}, {_stateOrProvince}, {_country}");
        return _street + _city + _stateOrProvince + _country;
    }
}