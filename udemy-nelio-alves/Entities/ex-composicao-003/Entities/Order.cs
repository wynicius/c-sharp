using System.Text;

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
        return Items.Sum(item => item.SubTotal());
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Order moment: ");
        sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
        sb.Append("Order status: ");
        sb.AppendLine(Status.ToString());
        sb.Append("Client: ");
        sb.Append(Client.Name);
        sb.Append($" ({Client.BirthDate.ToString()})");
        sb.Append(" - ");
        sb.AppendLine(Client.Email);
        sb.AppendLine("Order items:");
        double sum = 0;
        foreach (OrderItem item in Items)
        {
            sb.AppendLine(item.ToString());
            double subTotal = item.SubTotal();
            sum += + subTotal;
            ;
            
        }
        return sb.ToString()
        + "Total: " + sum;
    }
}