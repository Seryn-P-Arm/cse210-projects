using System;
using System.Collections.Specialized;

// Store address details
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Store address details from the given addresses in the program through constructors
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // If address is in USA
    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }

    // Return string for address
    public override string ToString()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}