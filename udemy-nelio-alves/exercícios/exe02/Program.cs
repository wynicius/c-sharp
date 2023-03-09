System.Console.WriteLine("--------------------------------------------------------------------------------------");
System.Console.WriteLine("Digite o número do combustível para abastecer: 1. Álcool 2. Gasolina 3. Diesel 4. Sair");
System.Console.WriteLine("--------------------------------------------------------------------------------------");

int num = int.Parse(Console.ReadLine());
int alcool = 0, gasolina = 0, diesel = 0;

while (num != 4) {
    if (num == 1) {
        alcool++;
    }
    else if (num == 2) {
        gasolina++;
    }
    else if (num == 3) {
        diesel++;
    }
    else {
        Console.WriteLine("código inválido (fora da faixa de 1 a 4)");
    }

    System.Console.WriteLine("--------------------------------------------------------------------------------------");
    System.Console.WriteLine("Digite o número do combustível para abastecer: 1. Álcool 2. Gasolina 3. Diesel 4. Sair");
    System.Console.WriteLine("--------------------------------------------------------------------------------------");

    num = int.Parse(Console.ReadLine());
}

System.Console.WriteLine("MUITO OBRIGADO!");
System.Console.WriteLine($"Alcool: {alcool}");
System.Console.WriteLine($"Gasolina: {gasolina}");
System.Console.WriteLine($"Diesel: {diesel}");