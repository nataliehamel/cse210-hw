using System;

public class product
{
    public string _productName;
    public string _productID;
    public decimal _price;
    public int _quantity;

    public product(string productName, string productID, decimal price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    
    public decimal GetPrice()
    {
        return _price * _quantity;
    }
}