using System;

public class Customer
{
    public string _name { get; set; }
    public Address _addressLocation{ get; set; }

    public Customer(string name, Address address)
    {
        _name = name;
        _addressLocation = address;
    }

    public bool AD()
    {
        return _addressLocation.AD();
    }
}