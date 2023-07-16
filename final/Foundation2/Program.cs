using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {   
        List<Order> orders= new List<Order>();

        List<Product> products= new List<Product>();
        Address _morgansAddress= new Address("210 Fox Drive", "Del Rio", "Texas", "USA");
        Customer customer= new Customer("Morgan Summers", _morgansAddress);
        Product _earrings = new Product("Rose Earrings", 411, 29.95, 2);
        products.Add(_earrings);
        Product _sunglasses = new Product("Sunglasses", 342, 19.95, 1);
        products.Add(_sunglasses);
        Order order= new Order(customer, products);
        orders.Add(order);
        Console.WriteLine();
        order.PackingLabel(order);
        Console.WriteLine();
        order.ShippingLabel(order);
        Console.WriteLine();
        double total = Math.Round(order.CalculateTotal(), 2);
        Console.WriteLine($"{customer.CustomerName}, Your total is ${total}");


        List<Product> products2= new List<Product>();
        Address _emilysAddress= new Address("309 Winding way", "Del Rio", "Texas", "USA");
        Customer _emily= new Customer("Emily Raymond", _emilysAddress);
        Product _paintBrushes = new Product("Paint brush set", 24, 8.95, 1);
        products2.Add(_paintBrushes);
        Product _canvases = new Product("Canvases", 244, 1.95, 12);
        products2.Add(_canvases);
        Product _paint = new Product("Paint", 111, 6.95, 6);
        products2.Add(_paint);        
        Order order2= new Order(_emily, products2);
        orders.Add(order2);
        Console.WriteLine();
        order2.PackingLabel(order2);
        Console.WriteLine();
        order2.ShippingLabel(order2);
        Console.WriteLine();
        double total2 = Math.Round(order2.CalculateTotal(), 2);
        Console.WriteLine($"{_emily.CustomerName}, Your total is ${total2}");

        List<Product> products3= new List<Product>();
        Address _micahsAddress= new Address("31 Royal Forest", "Paris", "Paris Region", "France");
        Customer _micah = new Customer("Micah Pearce", _micahsAddress);
        Product _rootbeer = new Product("Craft RootBeer", 216, 2.50, 6);
        products3.Add(_rootbeer);
        Product _alaskanChocolate = new Product("Alaskan Chocolate", 6, 3.99, 2);
        products3.Add(_alaskanChocolate);
        Order order3= new Order(_micah, products3);
        orders.Add(order3);
        Console.WriteLine();
        order3.PackingLabel(order3);
        Console.WriteLine();
        order3.ShippingLabel(order3);
        Console.WriteLine();
        double total3 = Math.Round(order3.CalculateTotal(), 2);
        Console.WriteLine($"{_micah.CustomerName}, Your total is ${total3}");
    }
}