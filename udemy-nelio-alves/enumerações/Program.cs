using Course.Entities;
using Course.Entities.Enums;
using System;


Order order = new Order
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);

string txt = OrderStatus.PendingPayment.ToString();

System.Console.WriteLine(txt);

OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

Console.WriteLine(os);
Console.WriteLine(txt);
