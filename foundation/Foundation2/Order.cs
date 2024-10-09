using System;
using System.Collections.Generic;

public class Order {
    private List<Product> _products;
    private Customer _customer;
    private double _USAShippingCost;
    private double _InternationalShippingCost;

    public Order(Customer customer, double USAShippingCost, double InternationalShippingCost)
    {
        _products = new List<Product>();
        _customer = customer;
        _USAShippingCost = USAShippingCost;
        _InternationalShippingCost = InternationalShippingCost;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double subtotal = 0;
        double total = 0;

        foreach (var product in _products)
        {
            subtotal += product.ComputeTotalCost();
        }
        if (_customer.IsInUSA() is true)
        {
            total = subtotal + _USAShippingCost;
        } else
        {
            total = subtotal + _InternationalShippingCost;
        }
        return total; 
    }

    public string DisplayPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _products)
        {
            packingLabel += $"{product.DisplayAll()}";
        }
        return packingLabel;
    
    }

    public string DisplayShippingLabel()
    {
        return _customer.DisplayCustomerAddress();
    }
}