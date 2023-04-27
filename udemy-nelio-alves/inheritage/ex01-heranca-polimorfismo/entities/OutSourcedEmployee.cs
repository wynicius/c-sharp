using System.Globalization;
public class OutSourcedEmployee : Employee
{
    public double AdditionalCharge { get; set; }

    public OutSourcedEmployee()
    {
    }
    public OutSourcedEmployee(string name, int hours, double valuePerHour , double additionalCharge)
        : base(name, hours, valuePerHour)
    {
        AdditionalCharge = additionalCharge;
    }

    public sealed override double Payment()
    {
        return (AdditionalCharge * 1.1) + base.Payment();
    }

    public override string ToString()
    { 
        foreach (OutSourcedEmployee outSourcedEmployee in outSourcedEmployee.Name)
        {
            return Name
            + " - $ "
            + Payment().ToString("F2", CultureInfo.InvariantCulture);
        };
    }
}