using System;
using System.Collections.Generic;
using System.Globalization;

List<Shape> shape = new List<Shape>();
Console.WriteLine("Enter the number of shapes:");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Shape #{i+1} data:");
    Console.Write("Rectangle or Circle (r/c)?");
    char conditionType = Console.ReadLine()[0];
    Console.Write("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<Color>(Console.ReadLine());
     
    if (conditionType == 'r')
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());
        shape.Add( new Rectangle(color, width, height));
    }
    else if (conditionType == 'c')
    {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine());
        shape.Add(new Circle(color, radius));
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again.");
        i--;
    }
}

Console.WriteLine("SHAPE AREAS:");
foreach (Shape area in shape)
{
    Console.WriteLine(area.Area().ToString("F2", CultureInfo.InvariantCulture));
}
