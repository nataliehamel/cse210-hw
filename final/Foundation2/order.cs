using System;
 
public class order 
{
    public List<product> _products;
    public customer _customer;

    public order(List<product> products, customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public decimal GetTotalCost()
    {
        decimal _totalCost = 0;
        foreach (product product in _products)
        {
            _totalCost += product.GetPrice();
        }

        _totalCost += _customer.InUSA() ? 5 : 35;
        return _totalCost;
    }

    public string GetPackingLabel()
    {
        string _label = "Packing Label | ";
        foreach (product product in _products)
        {
            _label += $"Name: {product._productName}, Product ID: {product._productID} ";
        }

        return _label;
    }

    public string GetShippingLabel()
    {
        string _label = "Shipping Label | ";
        _label += $"Customer: {_customer._customerName}, Address: {_customer._address.GetAddress()} ";
        return _label;
    }
}