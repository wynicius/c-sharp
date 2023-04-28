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
}