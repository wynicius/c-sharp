using System;
using System.Globalization;

public class Product
{
    // name, price, quantity
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product() {}

    public Product(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public double Total()
    {
        return Price * Quantity;
    }
}