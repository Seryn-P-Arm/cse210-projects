using System;
using System.Net.Sockets;

public class Customer
{
    // Store customer details
    private string _name;
    private Address _address;

    // Receive and store customer name and address from program through constructors
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Getters
    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    // Call IsInUSA funtion from Address class if addess is from the country of USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}