using System;

public class Product
{
    public string _name { get; set; }
    public int _productID { get; set; }
    public double _price { get; set; }
    public int _quantity { get; set; }

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _productID = id;
        _price = price;
        _quantity = quantity;
    }

    public double CalculatePrice()
    {
        return _price * _quantity;
    }
}