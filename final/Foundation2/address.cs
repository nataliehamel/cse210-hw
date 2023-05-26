using System;

public class address
{
    public string _streetAddress;
    public string _city;
    public string _stateProvince;
    public string _country;

    public address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool InUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
        //??//
    }

    public string GetAddress()
    {
        return $"{_streetAddress} {_city}, {_stateProvince} {_country}";
    }
}