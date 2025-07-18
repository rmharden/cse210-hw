using System.Collections;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    private string _isUsa;
    

    public void SetAddress(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public string GetStreet()
    {
        return _street;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetStateOrProvince()
    {
        return _stateOrProvince;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }
    public string GetCountry()
    {
        return _country;
    }

    public string IsAddressUsa()
    {
        string stupidCountry = GetCountry();
        Console.WriteLine(stupidCountry);
        // if (stupidCountry.ToLower() == "usa")
        // {
        //     _isUsa = "yes";
        // }
        // else
        // {
        //     _isUsa = "no";
        // }
        // return _isUsa;

        return "";
    }

    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_stateOrProvince}, {_country}";
    }
}