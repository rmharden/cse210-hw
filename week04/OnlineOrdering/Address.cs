// ENCAPSULATION


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