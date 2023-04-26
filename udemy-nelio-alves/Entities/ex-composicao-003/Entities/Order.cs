using System;

public class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public Client Client { get; set; }
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();

    public Order()
    {
    }
    public Order(DateTime moment, OrderStatus status, Client client)
    {
        Moment = moment;
        Status = status;
        Client = client;
    }

    public void AddItems(OrderItem items)
    {
        Items.Add(items);
    }
    public void RemoveItems(OrderItem items)
    {
        Items.Remove(items);
    }
    public double Total()
    {
        double total = ??????????
    }

    // Estudar StingBuilder!!
}