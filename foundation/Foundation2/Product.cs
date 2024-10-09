using System;
using System.Collections.Generic;

public class Product
{
    private string _productName;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string productName, int productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double ComputeTotalCost()
    {
        return _price * _quantity;
    }

    public string DisplayAll()
    {
        return $"Product: {_productName} | Id: {_productId} | Price: {_price:F2} | Quantity: {_quantity}" + "\n";
    }

}