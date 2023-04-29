public class Circle : Shape
{
    public double Radius { get; set; }
    public Color Color { get; set; }

    public Circle()
    {
    }

    public Circle(Color color ,double radius)
        : base(color)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return 3.14 * Math.Pow(Radius, 2.0);
    }
}