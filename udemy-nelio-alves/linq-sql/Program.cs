using System;
using System.IO;
using System.Linq;
using System.Globalization;

string path = @"C:\Users\User1\Desktop\coding\c-sharp\udemy-nelio-alves\linq-sql\products.csv";
string productsList = "TV,900.00\n"
                    + "Mouse,50.00\n"
                    + "Tablet,350.00\n"
                    + "HD Case,80.00\n"
                    + "Computer,850.00\n"
                    + "Monitor,290.00";

List<ProductsList> products = new List<ProductsList>();

File.WriteAllText(path, productsList);

using (StreamReader sr = new StreamReader(path))
{
    while (!sr.EndOfStream)
    {
        string[] lines = sr.ReadLine().Split(",");
        string Name = lines[0];
        double Price = double.Parse(lines[1], CultureInfo.InvariantCulture);
        products.Add(new ProductsList() { Name = Name, Price = Price});
    }
}

// Exibir média do preço dos produtos:
double avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
Console.WriteLine(avg.ToString("F2", CultureInfo.InvariantCulture));

// Exibir os nomes, em ordem decrescente, dos produtos com preços abaixo da média
var names = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
foreach (var name in names)
{
    System.Console.WriteLine(name);
}
