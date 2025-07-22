public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
    public bool IsAddressUSA()
    {
        if (_country.ToLower() == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public string CompleteAddress()
    {
        Console.WriteLine(_street);
        Console.WriteLine($"{_city}, {_stateOrProvince}, {_country}");
        return _street + _city + _stateOrProvince + _country;
    }
}