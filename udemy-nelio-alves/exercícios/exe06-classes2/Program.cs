using System;
using System.Globalization;

class Program {
    static void Main(string[] args) {
        Retangulo X = new Retangulo();

        Console.WriteLine("Entre a largura e a altura do retângulo: ");
        System.Console.Write("Largura: ");
        X.Largura = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.Write("Altura: ");
        X.Altura = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine($"ÁREA: {X.Area().ToString("F2", CultureInfo.InvariantCulture)}");
        System.Console.WriteLine($"PERÍMETRO: {X.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
        System.Console.WriteLine($"DIAGONAL: {X.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
