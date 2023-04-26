using System;
using System.Globalization;

Console.WriteLine("Enter the client's data:");
Console.Write("Name: ");
string clientName = Console.ReadLine();
Console.Write("Email: ");
string clientEmail = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime clientBDate = DateTime.Parse(Console.ReadLine()); // DateTime funcionou?? 

Client client = new Client(clientName, clientEmail, clientBDate);

Console.WriteLine("Enter the order's data: ");
Console.Write("Status :");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

DateTime moment = DateTime.Now;
Order order = new Order(moment, status, client);

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

// Loop dos dados dos produtos
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter #{i + 1} item data: ");
    Console.Write("Product Name: ");
    string prodName = Console.ReadLine();
    Console.Write("Product Price: ");
    double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Product product = new Product(prodName, prodPrice);

    Console.Write("Quantity: ");
    int prodQnt = int.Parse(Console.ReadLine());   
    
    OrderItem items = new OrderItem(prodQnt, prodPrice, product);
    order.AddItems(items);
}

System.Console.WriteLine();
System.Console.WriteLine(order);
System.Console.WriteLine(order.Total());
