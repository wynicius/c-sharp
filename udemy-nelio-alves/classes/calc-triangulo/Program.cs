using System;
using System.Globalization;

    namespace Course {
        class Program {
            static void Main(string[] args) {

                Triangulo x,y; // Defini dois triângulos X e Y, pela classe do file Triangulo.cs, que serão "referência" do objeto composto Triangulo = A B e C

                x = new Triangulo(); // Instanciação de memória dentro do "Heap". Cria os espaços de memória A, B e C que foram criados no file Triangulo.cs
                y = new Triangulo(); // Instanciação de memória dentro do "Heap"

                Console.WriteLine("Entre com as medidas do triângulo X:");
                x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Entre com as medidas do triângulo Y:");
                y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double areaX = x.Area(); // Chamando a função contida na classe Triangulo

                double areaY = y.Area(); // Chamando a função contida na classe Triangulo

                Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

                if (areaX > areaY) {
                Console.WriteLine("Triângulo de maior área: X");
                }
                else {
                Console.WriteLine("Triângulo de maior área: Y");
                }
        }
    }
}