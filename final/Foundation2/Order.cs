using System;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> product)
    {
        _products = product;
        _customer = customer;
    }

    public void PackingLabel(Order order)
    {
        foreach (Product product in _products)
        {
        Console.WriteLine($"{product.ProductName} -- {product.ProductId}");
        }
    }

    public void ShippingLabel(Order order)
    {
        string address = order._customer.CustomerAddress.ReturnString() as string;
        
        Console.WriteLine($"{_customer.CustomerName}\n{address}");
        
    }

    public double CalculateTotal()
    {
        
        double total = CalculateShipping();
        foreach(Product product in _products)
        {
            double _each = product.ComputePrice();
            total+= _each;
        }
        return total;
    }

    public int CalculateShipping()
    {
        if(_customer.CustomerAddress.Country.ToLower() == "usa")
        {
            return 5;
        }
        else
        {
            return 25;
        }
    }
}