using System;

public class customer
{
    public string _customerName;
    public address _address;

    public customer(string customerName, address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool InUSA()
    {
        return _address.InUSA();
    }
}