using System;

public class Product
{
    // Store product detials
    private string _name;
    private string _id;
    private decimal _price;
    private int _quantity;

    // Receive and store product details from program through constructors
    public Product(string name, string id, decimal price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    // Get the total product cost
    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    // Get name of product
    public string GetName()
    {
        return _name;
    }

    // Get product ID
    public string GetID()
    {
        return _id;
    }
}