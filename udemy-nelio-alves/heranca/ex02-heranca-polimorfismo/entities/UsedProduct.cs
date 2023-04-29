using System.Globalization;
using System.Collections.Generic;
public class UsedProducts : Product
{
    public DateTime ManufactedDate { get; set; }

    public UsedProducts()
    {
    }

    public UsedProducts(string name, double price, DateTime manufactedDate)
        : base(name, price)
    {
        ManufactedDate = manufactedDate;
    }

    public override string PriceTag()
    {
        return "$ " + Price.ToString("F2", CultureInfo.InvariantCulture)
        + " (Manufacture date: "
        +  ManufactedDate.ToString("dd/MM/yyyy");
    }
}