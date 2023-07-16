using System;

class Product
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

    public string ProductName{
        get{ return _productName;}
    }
    public int ProductId{
        get{ return _productId;}
    }
    
    public double ComputePrice()
    {
        double _total = _quantity * _price;
        return _total;
    }
}