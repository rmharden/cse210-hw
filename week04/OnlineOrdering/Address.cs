public class Address
{
    public string _street;
    public string _city;
    public string _stateOrProvince;
    public string _country;
    public string _isUSA;

    public string IsAddressUSA()
    {
        if (_country == "USA")
        {
            _isUSA = "yes";
        }
        else
        {
            _isUSA = "no";
        }
        return _isUSA;
    }
    public string CompleteAddress()
    {
        Console.WriteLine(_street);
        Console.WriteLine($"{_city}, {_stateOrProvince}, {_country}");
        return _street + _city + _stateOrProvince + _country;
    }
}