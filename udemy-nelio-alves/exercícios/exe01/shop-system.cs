using System.Globalization;

System.Console.WriteLine("Digite o código da peça 1: ");
    int code1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Digite quantas peças 1 serão : ");
    int hMany1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Digite o valor da peça 1: ");
    double value1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double fValue1 = hMany1 * value1;

System.Console.WriteLine("Digite o código da peça 2: ");
    int code2 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Digite quantas peças 2 serão: ");
    int hMany2 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Digite o valor da peça 2: ");
    double value2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double fValue2 = hMany2 * value2;

double payment = (fValue1 + fValue2);

System.Console.WriteLine(fValue1);
System.Console.WriteLine(fValue2);

System.Console.WriteLine($"VALOR A PAGAR: R$ {payment:F2}");
