using System;
using System.Collections.Generic;
using System.Globalization;

List<Product> products = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Product #{i+1} data: ");
    Console.Write("Common, used or imported (c/u/i)?");
    char productClass = Console.ReadLine()[0];

    if (productClass == 'i')
    {
        Console.WriteLine("Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Price: ");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine());
        Console.WriteLine();

        products.Add(new ImportedProducts(name, price, customsFee));
    }
    else if (productClass == 'u')
    {
        Console.WriteLine("Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Price: ");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine("Manufactured date (DD/MM/YYYY): ");
        DateTime manufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine();

        products.Add(new UsedProducts(name, price, manufactureDate));
    }
    else if (productClass == 'c')
    {
        Console.WriteLine("Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Price: ");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine();
        
        products.Add(new Product(name, price));
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again.");
        Console.WriteLine();
        i--; // decrement i to repeat the current iteration
    }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS:");

foreach (Product p in products)
{
    Console.WriteLine(p.PriceTag());
}
