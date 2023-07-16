using System;
using System.Collections.Concurrent;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string Country{
        get { return _country; }
    }

    public bool LocalOrNot(){
        return _country.Equals("USA");
    }

    public string ReturnString()
    {
        string _address = $"{_streetAddress}.\n{_city}, {_state}, {_country}";
        return _address;
    }

    public string FullString()
    {
        string _fullString= "";
        return _fullString;
    }
}