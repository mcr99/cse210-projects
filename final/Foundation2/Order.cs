using System;
using System.Collections.Generic;

public class Order
{
    public List<Product> _products { get; set; }
    public Customer _customerInfo { get; set; }

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customerInfo = customer;
    }

    public double CalculateFinalCost()
    {
        double finalCost = 0;
        foreach (var product in _products)
        {
            finalCost += product.CalculatePrice();
        }

        if (_customerInfo.AD())
        {
            finalCost += 5;
        }
        else 
        {
            finalCost += 35;
        }
        return finalCost;
    }

    public List<string> GetPackingLabel()
    {
        List<string> productIDs = new List<string>();
        foreach (var product in _products)
        {
            productIDs.Add(product._name);
            productIDs.Add(product._productID.ToString());
        }
        return productIDs;
    }

    public string GetShippingLabel()
    {
        return $"{_customerInfo._name}\n{_customerInfo._addressLocation.GetAddress()}";
    }
}